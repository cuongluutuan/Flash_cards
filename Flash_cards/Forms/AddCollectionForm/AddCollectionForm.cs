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

namespace Flash_cards.Forms.AddCollectionForm
{
    public partial class AddCollectionForm : Form
    {
        private UnitOfWork _unitOfWork;
        private Dictionary<string,object> _infoToChild;
        private CollectionControls _collectionControls;  
        public AddCollectionForm(CollectionControls collectionControls)
        {
            InitializeComponent();
            _unitOfWork = new UnitOfWork();
            _infoToChild = new Dictionary<string, object>();
            _collectionControls = collectionControls;
        }       

        private void handleAddCollection(object sender, EventArgs e)
        {
            if (collectionNameTxt.Text.Trim().Length == 0
               || collectionDescTxt.Text.Trim().Length == 0)
            {
                MessageBox.Show("Collection Name and Description must not be empty!",
                           "Information", MessageBoxButtons.OK);
                return;
            }

            CardsCollection cardsCollection= new CardsCollection()
            {
                Name = collectionNameTxt.Text,
                Description = collectionDescTxt.Text
            }; 
            _unitOfWork.CardsCollectionRepository.Create(cardsCollection);
            _unitOfWork.Save();

            _collectionControls.refreshList(); //refresh the list adding a new collection.

            DialogResult result = MessageBox.Show("Collection is successfully added!" +
                "Would you like to add a Question to this Collection now?",
                            "Information", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                _infoToChild.Add("collection", cardsCollection);  
                CollectionDetailsForm collectionDetailsForm = 
                    new CollectionDetailsForm(_infoToChild,_collectionControls);
                collectionDetailsForm.Show();
                this.Close();
            }
        }
    }
}
