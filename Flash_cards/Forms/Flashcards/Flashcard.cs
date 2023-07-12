using Flash_cards.Forms.Flashcards.UserControls;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Services.DTO;
using Services.Models;
using Services.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        private List<QaDTO> qaDTOs;
        private List<string> _answerList;
        private int _questionNumber;
        private int _currentQuestionIndex = 0;
        private Dictionary<string, List<string>> _oneQuestionWithManyAnsDict;
        private QuestionControl currentQuestionControl;

        public FlashcardForm(Dictionary<string, object> crossFormInfoDict)
        {

            InitializeComponent();
            _crossFormInfoDict = crossFormInfoDict;
            var qNumberObj = crossFormInfoDict.GetValueOrDefault("questionNumber");
            if (qNumberObj != null) _questionNumber = Convert.ToInt32(qNumberObj);
            runAsyncTasks();


        }

        private CardsCollection currentCollection;
        private CardEntry currentCardEntry;

        //public FlashcardForm(int collectionId)
        //{
        //    InitializeComponent();
        //    _unitOfWork = new UnitOfWork();

        //    _allCardEntriesInCollection = _unitOfWork.CardEntryRepository
        //                                    .GetAll()
        //                                    .Where(cardEntry => cardEntry.CardsCollectionId
        //                                        == collectionId)
        //                                    .ToList();

        //    currentCardEntry = _allCardEntriesInCollection[0];                                       
        //}

        private void questionLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }





        // =====================
        //Using async-await to prevent the UI from freezing
        private async void runAsyncTasks()
        {
            //The await keyword helps each Task:
            //- Runs STEP BY STEP (setup -> generateQuestionsAnswersList -> showQuestions)
            //- Prevents the UI from freezing

            await Task.Run(() => { setup(); });
            await Task.Run(() => { generateQuestionsAnswersList(); });
            await Task.Run(() => { showQuestions(); });
        }

        private void setup()
        {
            _unitOfWork = new UnitOfWork();

            var cardCol = _crossFormInfoDict.GetValueOrDefault("collection");
            CardsCollection chosenOne = (CardsCollection)cardCol!;
            if (cardCol != null)
                _allCardEntriesInCollection = _unitOfWork.CardEntryRepository
                                                .GetAll()
                                                .Where(cardEntry => cardEntry.CardsCollectionId
                                                    == chosenOne.Id)
                                                .ToList();



            _oneQuestionWithManyAnsDict = new Dictionary<string, List<string>>();
            qaDTOs = new List<QaDTO>();
            /*1. Gets the selected Collection */
            var collectionObj = _crossFormInfoDict.GetValueOrDefault("collection");
            if (collectionObj != null)
            {
                _cardsCollection = (CardsCollection)collectionObj;
            }

            /*2. Gets a full list of Q&As of that Selected Collection.*/
            _unitOfWork = new UnitOfWork();

            List<CardEntry> cardEntryList = _unitOfWork.CardEntryRepository
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

        private List<string> falseAnswerGenerator(string correctAnswer) {

            /*3. Generates 3 random false answers to fill up the answerListPerQuestion.*/
            List<string> result = new List<string>();
            List<int> whitelistedFalseAnsIndex = new List<int>();
            Random rnd = new Random();
            for (int count = 1; count <= 3; count++)
            {
                int falseAnswerIndex = 0;

                /*
                 * If the generated answer has not existed before AND 
                 * NOT similar to the Correct Answer, then add it to 
                 * the answerListPerQuestion.
                 */
                string falseAnswer = "";
                do
                {
                    falseAnswerIndex = rnd.Next(0, _answerList.Count);
                    falseAnswer = _answerList[falseAnswerIndex];
                } while (whitelistedFalseAnsIndex.Contains(falseAnswerIndex)
                || falseAnswer.Equals(correctAnswer));
                whitelistedFalseAnsIndex.Add(falseAnswerIndex);

                falseAnswer = _answerList[falseAnswerIndex];
                result.Add(falseAnswer);
            }

            return result;
        }
        private void generateQuestionsAnswersList()
        {
            List<string> falseAnswerListPerQuestion = new List<string>();
            //contains generated index. Prevents duplicated index(question).
            List<int> whitelistedIndex = new List<int>();

            Random rnd = new Random();
            for (int index = 0; index < _questionNumber; index++) //Generates 10 questions+answersList pairs.
            {
                /*0: For each generated question, reset its answer list and random index.*/
                QaDTO eachQaDTO = new QaDTO();

                int randomCardIndex = 0;
                falseAnswerListPerQuestion.Clear();
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
                eachQaDTO.question = question;
                eachQaDTO.correctAns = correctAnswer;
                eachQaDTO.falseAnswers = falseAnswerGenerator(correctAnswer);
                qaDTOs.Add(eachQaDTO);

                                
                
            }


        }
        private void showQuestions()
        {
            //delegate helps another thread (generateQuestionsAnswersList) invokes the UI thread
            //(main thread) to update the form elements with the latest data.
            //in other words, it is a pointer like C/C++.
            this.questionLayoutPanel.Invoke((MethodInvoker)delegate
            {

                QuestionControl questionControl = new QuestionControl(qaDTOs[_currentQuestionIndex],this);
                currentQuestionControl = questionControl;
                questionLayoutPanel.Controls.Add(questionControl);
            });
        }
        public void showNextQuestion()
        {
            this.questionLayoutPanel.Invoke((MethodInvoker)delegate
            {
                if (_currentQuestionIndex < qaDTOs.Count)
                {


                    questionLayoutPanel.Controls.Remove(currentQuestionControl);
                    
                    QuestionControl questionControl = new QuestionControl(qaDTOs[_currentQuestionIndex], this);
                    _currentQuestionIndex += 1;
                    currentQuestionControl = questionControl;
                    questionLayoutPanel.Controls.Add(questionControl);

                }
            });
        }
        public void showPrevQuestion()
        {
            this.questionLayoutPanel.Invoke((MethodInvoker)delegate
            {
                if (_currentQuestionIndex > 0)
                {
                    questionLayoutPanel.Controls.Remove(currentQuestionControl);
                    
                    QuestionControl questionControl = new QuestionControl(qaDTOs[_currentQuestionIndex], this);
                    _currentQuestionIndex -= 1;
                    currentQuestionControl = questionControl;
                    questionLayoutPanel.Controls.Add(questionControl);
                }
            });
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}
