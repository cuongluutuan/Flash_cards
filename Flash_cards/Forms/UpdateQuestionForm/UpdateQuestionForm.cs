using Flash_cards.Forms.QuestionForm;
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

namespace Flash_cards.Forms.UpdateQuestionForm
{
    public partial class UpdateQuestionForm : Form
    {
        private Dictionary<string, object> _crossFormInfoDict;
        private CardEntry _cardEntry;
        private UnitOfWork _unitOfWork;
        private CollectionDetailsForm _collectionDetailsForm;
        public UpdateQuestionForm(Dictionary<string, object> crossFormInfoDict,
            CollectionDetailsForm collectionDetailsForm)
        {
            InitializeComponent();
            _crossFormInfoDict = crossFormInfoDict;
            _unitOfWork= new UnitOfWork();
            
            /*This helps us call the refreshQuestionsList function in Parent form (CollectionDetailsForm)
             from Child Form (UpdateQuestionForm)*/
            _collectionDetailsForm = collectionDetailsForm;
            
            //Loads the currently selected Question
            var questionObj = _crossFormInfoDict.GetValueOrDefault("selectedQuestion");
            if (questionObj != null)
            {
                _cardEntry = (CardEntry)questionObj;
            }

            questionNameTxt.Text = _cardEntry!.Question;
            answerTxt.Text = _cardEntry.Answer; 
        }

        private void handleUpdate(object sender, EventArgs e)
        {
            if (answerTxt.Text.Length == 0)               
            {
                MessageBox.Show("The new Answer must not be empty!",
                    "Information", MessageBoxButtons.OK);
                return;
            }
           
            _cardEntry.Answer = answerTxt.Text;
            _unitOfWork.CardEntryRepository.Update(_cardEntry);            
            _unitOfWork.Save();
            _collectionDetailsForm.refreshQuestionList();

            this.Close();
        }
    }
}
