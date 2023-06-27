using Flash_cards.Forms.Flashcards.UserControls;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Services.Models;
using Services.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Flash_cards.Question
{
    public partial class FlashcardForm : Form
    {

        private int currentQuestionIndex = 0;
        private int correctAnswersCount = 0;
        private UnitOfWork _unitOfWork;
        private Dictionary<string, object> _crossFormInfoDict;
        private CardsCollection _cardsCollection;
        private List<CardEntry> _allCardEntriesInCollection;
        private List<string> _answerList;
        private int _questionNumber;
        private Dictionary<string, List<string>> _oneQuestionWithManyAnsDict;

        public FlashcardForm(Dictionary<string, object> crossFormInfoDict)
        {

            InitializeComponent();
            _crossFormInfoDict = crossFormInfoDict;
            var qNumberObj = crossFormInfoDict.GetValueOrDefault("questionNumber");
            if (qNumberObj != null) _questionNumber = Convert.ToInt32(qNumberObj);
            runAsyncTasks();


        }
        //Using async-await to prevent the UI from freezing
        private async void runAsyncTasks()
        {
            //The await keyword helps each Task:
            //- Runs STEP BY STEP (setup -> generateQuestionsAnswersList -> showQuestions)
            //- Prevents the UI from freezing

            await Task.Run(() => { setup(); });
            await Task.Run(() => { generateQuestionsAnswersList(); });
            await Task.Run(() => { showQuestions();});
        }

        private void setup()
        {
            _oneQuestionWithManyAnsDict = new Dictionary<string, List<string>>();
            /*1. Gets the selected Collection */
            var collectionObj = _crossFormInfoDict.GetValueOrDefault("collection");
            if (collectionObj != null)
            {
                _cardsCollection = (CardsCollection)collectionObj;
            }

            /*2. Gets a full list of Q&As of that Selected Collection.*/
            _unitOfWork = new UnitOfWork();

            _allCardEntriesInCollection = _unitOfWork.CardEntryRepository
                                            .GetAll()
                                            .Where(cardEntry => cardEntry.CardsCollectionId
                                                == _cardsCollection.Id)
                                            .ToList();
            /*3. Gets the ANSWER list of all Questions, to randomize 3
                    False answers for each questions later on.*/
            _answerList = _allCardEntriesInCollection
                .Select(entry => entry.Answer)
                .ToList();


        }

        private void generateQuestionsAnswersList()
        {
            List<string> answerListPerQuestion = new List<string>();
            //contains generated index. Prevents duplicated index(question).
            List<int> whitelistedIndex = new List<int>();

            Random rnd = new Random();
            for (int index = 0; index < _questionNumber; index++) //Generates 10 questions+answersList pairs.
            {
                /*0: For each generated question, reset its answer list and random index.*/
                int randomCardIndex = 0;
                answerListPerQuestion.Clear();
                /*1. Gets a random question from the _allCardEntriesInCollectionList*/

                do
                {
                    randomCardIndex = rnd.Next(0, _allCardEntriesInCollection.Count());
                }
                while (whitelistedIndex.Contains(randomCardIndex));
                whitelistedIndex.Add(randomCardIndex);

                /*2. Extracts the question and answer, then adds it to the answer list.*/
                CardEntry eachCardEntry = _allCardEntriesInCollection[index];
                string question = eachCardEntry.Question;
                string correctAnswer = eachCardEntry.Answer;
                answerListPerQuestion.Add(correctAnswer);

                /*3. Generates 3 random false answers to fill up the answerListPerQuestion.*/
                List<int> whitelistedFalseAnsIndex = new List<int>();
                for (int count = 1; count <= 3; count++)
                {
                    int falseAnswerIndex = 0;

                    /*
                     * If the generated answer has not existed before AND 
                     * NOT similar to the Correct Answer, then add it to 
                     * the answerListPerQuestion.
                     */
                    do
                    {
                        falseAnswerIndex = rnd.Next(0, _answerList.Count - 1);
                    } while (whitelistedFalseAnsIndex.Contains(falseAnswerIndex)
                    || _answerList[falseAnswerIndex].Equals(correctAnswer));
                    whitelistedFalseAnsIndex.Add(falseAnswerIndex);

                    string falseAnswer = _answerList[falseAnswerIndex];
                    answerListPerQuestion.Add(falseAnswer);
                }
                _oneQuestionWithManyAnsDict.Add(question, answerListPerQuestion);
            }           

           
        }
        private void showQuestions()
        {
            //delegate helps another thread (generateQuestionsAnswersList) invokes the UI thread
            //(main thread) to update the form elements with the latest data.
            //in other words, it is a pointer like C/C++.
            this.questionLayoutPanel.Invoke((MethodInvoker)delegate
            {
                foreach (KeyValuePair<string, List<string>> questionData in _oneQuestionWithManyAnsDict)
                {
                    QuestionControl questionControl = new QuestionControl(questionData);
                    questionLayoutPanel.Controls.Add(questionControl);
                }
            });            
        }
    }

}
