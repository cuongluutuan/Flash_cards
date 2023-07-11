using Flash_cards.UserControls;
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
using Flash_cards.Forms.AddQuestionForm;

namespace Flash_cards.Forms.QuestionForm
{
    public partial class CollectionDetailsForm : Form
    {
        private List<CardsCollection> _cardsCollections;
        private Dictionary<string, object> _crossFormInfoDict;
        private CardEntry _clickedCardEntry;
        private List<CardEntry> _cardEntries;
        private UnitOfWork _unitOfWork;
        private string _collectionName;
        private string collectionDesc;
        private CollectionControls _collectionControls;

        ////Base Constructor (accessed from the AddCollectionForm.cs/Details)
        //public CollectionDetailsForm(Dictionary<string, object> crossFormInfoDict)
        //{
        //    InitializeComponent();
        //    _unitOfWork = new UnitOfWork();
        //    _cardsCollections = _unitOfWork.CardsCollectionRepository.GetAll();

        //    /*Saves the information sent from the parent form (e.g. collection Name, collection Details)
        //    in order to refresh the new Details of the Collection, after user hits the Update button.*/
        //    _crossFormInfoDict = crossFormInfoDict;

        //    //Sets the title to the name of the collection
        //    var obj = crossFormInfoDict.GetValueOrDefault("collection");
        //    CardsCollection? cardCollection = null;
        //    if (obj != null)
        //    {
        //        cardCollection = (CardsCollection)obj;
        //    }

        //    // Variables for finding the collection (called A), then update
        //    // A with new details later on.
        //    _collectionName = cardCollection!.Name;
        //    collectionDesc = cardCollection!.Description;

        //    //Updates the collection name and details on the Form.
        //    questionFormTitle.Text = "Collection - " + _collectionName;
        //    collectionNameTxt.Text = _collectionName;
        //    collectionDescTxt.Text = collectionDesc;

        //    refreshQuestionList();  

        //}

        //Constructor used when user chooses to update the Collection Details (name, desc)
        public CollectionDetailsForm(Dictionary<string, object> crossFormInfoDict,
            CollectionControls collectionControls)
        {
            InitializeComponent();
            _unitOfWork = new UnitOfWork();
            _cardsCollections = _unitOfWork.CardsCollectionRepository.GetAll();
            _collectionControls = collectionControls;

            /*Saves the information sent from the parent form (e.g. collection Name, collection Details)
            in order to refresh the new Details of the Collection, after user hits the Update button.*/
            _crossFormInfoDict = crossFormInfoDict;

            //Sets the title to the name of the collection
            var obj = crossFormInfoDict.GetValueOrDefault("collection");
            CardsCollection? cardCollection = null;
            if (obj != null)
            {
                cardCollection = (CardsCollection)obj;
            }

            // Variables for finding the collection (called A), then update
            // A with new details later on.
            _collectionName = cardCollection!.Name;
            collectionDesc = cardCollection!.Description!;

            //Updates the collection name and details on the Form.
            questionFormTitle.Text = "Collection - " + _collectionName;
            collectionNameTxt.Text = _collectionName;
            collectionDescTxt.Text = collectionDesc;

            refreshQuestionList();  
           
        }

        public void refreshQuestionList() { 
            _unitOfWork = new UnitOfWork();
            // 4. Updates the question list of that form
            CardsCollection cardsCollectionFullDetails = _cardsCollections
                 .Where(card => (card.Name == _collectionName
                        && card.Description == collectionDesc))
                 .FirstOrDefault();

            _cardEntries =
                _unitOfWork.CardEntryRepository.GetAll().
                Where(entry => entry.CardsCollectionId
                    == cardsCollectionFullDetails.Id).ToList();


            //Filters out the columns to be shown on the DataGridView
            //should be the same as the columns in the database
            string[] columnNames = { "Question", "Answer" }; 
            int[] columnWidths = { 280, 280};
            questionsGridView.AutoGenerateColumns = false;

            for (int index = 0; index < columnNames.Length; index++)
            {
                DataGridViewTextBoxColumn dataGridViewTextBoxColumn
                    = new DataGridViewTextBoxColumn();
                //The column name (in the CardCollections Entity) to get the data from.
                dataGridViewTextBoxColumn.DataPropertyName = columnNames[index];
                dataGridViewTextBoxColumn.HeaderText = columnNames[index];
                dataGridViewTextBoxColumn.Width = columnWidths[index];
                questionsGridView.Columns.Add(dataGridViewTextBoxColumn);
            }
            questionsGridView.DataSource = _cardEntries;
        }
        private void handleUpdateCollectionDetails(object sender, EventArgs e)
        {
            /* 1. Checks if the details are valid (not empty)*/
            if (collectionNameTxt.Text.Length == 0 ||
                collectionDescTxt.Text.Length == 0)
            {
                MessageBox.Show("Collection Name and Description must not be empty!",
                    "Information", MessageBoxButtons.OK);
                return;
            }


            /* 2. Search and update a Selected Card Collection (based on name/description)*/
            foreach (CardsCollection cardsCollection in _cardsCollections)
            {
                //Find the cardsCollection based on the given Name and Description
                if (cardsCollection.Name.Equals(_collectionName)
                    && cardsCollection.Description.Equals(collectionDesc))
                {
                    //Updates the cardsCollection with new details (new name, description)
                    cardsCollection.Name = collectionNameTxt.Text;
                    cardsCollection.Description = collectionDescTxt.Text;

                    //Updates that collection in the Repository (or CardsCollection
                    //Table in SQL Server)
                    _unitOfWork.CardsCollectionRepository.Update(cardsCollection);
                    _unitOfWork.Save();
                    break;
                }
            }

            /* 3.Refreshes the Collections list on the parent form (CollectionsControls)*/
            //by calling the refreshList() function in the parent.
            _collectionControls.refreshList();

            /* 4. Reopens the form, by creating another CollectionDetailsForm instance (B)
            and closing the current instance (A);*/
            _crossFormInfoDict.Remove("collection");
            //Reloads the information of the newly updated Collection
            _crossFormInfoDict.Add("collection", new CardsCollection()
            {
                Name = collectionNameTxt.Text,
                Description = collectionDescTxt.Text
            });
            CollectionDetailsForm collectionDetailsFormAnotherInstance =
                new CollectionDetailsForm(_crossFormInfoDict, _collectionControls);

            collectionDetailsFormAnotherInstance.Show();
            this.Close();
        }

        private void handleAddQuestion(object sender, EventArgs e)
        {            
            
            AddQuestionForm.AddQuestionForm addQuestionForm = 
                new AddQuestionForm.AddQuestionForm(_crossFormInfoDict,this);
            addQuestionForm.Show();
        }

        private void handleDeleteQuestion(object sender, EventArgs e)
        {
            if (_clickedCardEntry == null)
            {
                MessageBox.Show("Double click on one of the collections, u dummy!",
                    "Read this carefully", MessageBoxButtons.OK);
                return;
            }

            DialogResult res = MessageBox.Show("Do you really want to delete the following Question:\n\n" +
                "  Question: " + _clickedCardEntry.Question +
                "\n  Answer: " + _clickedCardEntry.Answer +
                "\n\nAny changes is irreversible!",
                "Read this carefully", MessageBoxButtons.OKCancel);
            if (res == DialogResult.OK)
            {
                _unitOfWork.CardEntryRepository.Delete(_clickedCardEntry);
                _unitOfWork.Save();
                //Removes the deleted collection from the clickedCardsCollection
                //To prevent accidental deletion of non-existent object.
                _clickedCardEntry = null;
                refreshQuestionList();
            }

        }          

        private void questionsGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            _clickedCardEntry = _cardEntries[e.RowIndex];
        }    

        private void handleQuestionUpdate(object sender, EventArgs e)
        {
            if (_crossFormInfoDict.ContainsKey("selectedQuestion")) {
                _crossFormInfoDict.Remove("selectedQuestion");
            }
            if (_clickedCardEntry == null)
            {
                MessageBox.Show("Double click on one of the collections, u dummy!",
                    "Read this carefully", MessageBoxButtons.OK);
                return;
            }
            _crossFormInfoDict.Add("selectedQuestion",_clickedCardEntry);
            UpdateQuestionForm.UpdateQuestionForm updateQuestionForm =
                new UpdateQuestionForm.UpdateQuestionForm(_crossFormInfoDict,this);
            updateQuestionForm.Show();            
        }
    }
}
