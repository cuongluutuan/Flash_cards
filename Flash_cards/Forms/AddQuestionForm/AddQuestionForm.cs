using Flash_cards.Forms.QuestionForm;
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

namespace Flash_cards.Forms.AddQuestionForm
{
    public partial class AddQuestionForm : Form
    {
        private UnitOfWork _unitOfWork;
        private Dictionary<string, object> _crossFormInfoDict;
        
        private CollectionDetailsForm _collectionDetailsForm;
        public AddQuestionForm(Dictionary<string, object> crossFormInfoDict,
            CollectionDetailsForm collectionDetailsForm)
        {
            InitializeComponent();
            _unitOfWork = new UnitOfWork();
            _crossFormInfoDict = crossFormInfoDict;            
            
            /*Needed for this form to call the refresh question list function of
            the CollectionDetailsForm.*/
            _collectionDetailsForm = collectionDetailsForm;
        }       

        private void handleAddQuestion(object sender, EventArgs e)
        {
            if (questionNameTxt.Text.Trim().Length == 0
               || answerTxt.Text.Trim().Length == 0)
            {
                MessageBox.Show("Collection Name and Description must not be empty!",
                           "Information", MessageBoxButtons.OK);
                return;
            }
            var collectionObj= _crossFormInfoDict
                .GetValueOrDefault("collection");
            CardsCollection cardsCollection = null!;
            if (collectionObj!= null)
            {
                cardsCollection = (CardsCollection)collectionObj;   
            }

            CardEntry cardEntry = new CardEntry() { 
                CardsCollectionId = cardsCollection.Id,
                Question = questionNameTxt.Text,
                Answer = answerTxt.Text,
                Learned = false
            };  
            _unitOfWork.CardEntryRepository.Create(cardEntry);
            _unitOfWork.Save();
            _collectionDetailsForm.refreshQuestionList();
            this.Close();

        }
    }
}
