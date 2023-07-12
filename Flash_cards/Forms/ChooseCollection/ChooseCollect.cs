using Flash_cards.Question;
using Flash_cards.UserControls;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
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

namespace Flash_cards.Forms.LearnForm
{
    public partial class ChooseCollect : Form
    {
        private UnitOfWork _unitOfWork;
        private List<CardsCollection> _cardsCollections;
        private CardsCollection _clickedCardsCollection;
        private Dictionary<string, object> _crossFormInfoDict;
        private int _questionNumber;
        private List<CardEntry> _cardEntryList;
        public ChooseCollect()
        {
            InitializeComponent();
            _unitOfWork = new UnitOfWork();
            _cardsCollections = _unitOfWork.CardsCollectionRepository
                                .GetAll();
            _crossFormInfoDict = new Dictionary<string, object>();

            string[] collectionNames = _cardsCollections
                .Select(collection => collection.Name)
                .ToArray();
            foreach (CardsCollection collection in _cardsCollections)
            {
                
                collectionComboBox.Items.Add(new { Text = collection.Name, Value = collection.Id });
                

            }

        }

        private void handleLearn(object sender, EventArgs e)
        {
            string selectedCollection = collectionComboBox.
                GetItemText(collectionComboBox.SelectedItem);
            CardsCollection? cardsCollection = _cardsCollections.
                Find(card => card.Name == selectedCollection);

            if (_crossFormInfoDict.ContainsKey("collection"))
            {
                _crossFormInfoDict.Remove("collection");
            }
            if (cardsCollection != null)
            {
                _crossFormInfoDict.Add("collection", cardsCollection);
            }


            //Only allows the user to learn a collection with 4 or more question-answers.
            loadQuestionNumber();
            if (_questionNumber < 4)
            {
                MessageBox.Show("The number of question-answer pairs in your collection must" +
                    " be greater or equal to 4. Please add more pairs then try again.",
                    "Information", MessageBoxButtons.OK);
                return;
            }

            FlashcardForm flashcardForm = new FlashcardForm(_crossFormInfoDict);

            //int selectedItemIndex = (collectionComboBox.SelectedItem as dynamic).Value;  
            

            //FlashcardForm flashcardForm = new FlashcardForm(selectedItemIndex);
            flashcardForm.Show();
            this.Close();

        }
        private void loadQuestionNumber() {
            CardsCollection selectedCardsCollection = _cardsCollections
               .FirstOrDefault(card => card.Name == collectionComboBox.Text);

            _cardEntryList = _unitOfWork.CardEntryRepository.GetAll()
                .Where(entry => entry.CardsCollectionId == selectedCardsCollection.Id)
                .ToList();
            _questionNumber = _cardEntryList.Count;
        }
        private void handleLoadQuestionNumber(object sender, EventArgs e)
        {
            loadQuestionNumber();
            questionNumberComboBox.Items.Clear();
            for (int count = 1; count <= _questionNumber; count++)
            {
                questionNumberComboBox.Items.Add(count);
            }

        }

        private void handleChangeQuestionNumber(object sender, EventArgs e)
        {
            if (_crossFormInfoDict.ContainsKey("questionNumber"))
            {
                _crossFormInfoDict.Remove("questionNumber");
            }
            _crossFormInfoDict.Add("questionNumber", Int32.Parse(questionNumberComboBox.Text));
        }
    }
}
