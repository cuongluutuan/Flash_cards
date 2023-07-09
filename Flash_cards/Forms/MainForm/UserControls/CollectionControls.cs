using Flash_cards.Forms.AddCollectionForm;
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

namespace Flash_cards.UserControls
{
    public partial class CollectionControls : UserControl
    {
        private UnitOfWork _unitOfWork;
        private List<CardsCollection> _cardsCollections;
        private CardsCollection ?_clickedCardsCollection;
        private Dictionary<string, object> _crossFormInfoDict;
        public CollectionControls()
        {
            InitializeComponent();
            _unitOfWork = new UnitOfWork();
            _cardsCollections = new List<CardsCollection>();
            _crossFormInfoDict = new Dictionary<string, object>();

            //Load data from database to Collection List. (for coding)
            _cardsCollections = _unitOfWork.
                                CardsCollectionRepository.GetAll();

            //Load data from Collection List to Grid View (for viewing)
            refreshList();
        }
        public void refreshList()
        {
            _unitOfWork = new UnitOfWork(); //replaces the old UoW instance with a
                                            //new UoW instance, to refresh the updated Collection.
            _cardsCollections = _unitOfWork.
                CardsCollectionRepository.GetAll();

            //Filters out the columns to be shown on the DataGridView
            string[] columnNames = { "Name", "Description" };
            int[] columnWidths = { 300, 348 };
            collectionsGridView.AutoGenerateColumns = false;
            
            for(int index=0;index<columnNames.Length;index++) { 
                DataGridViewTextBoxColumn dataGridViewTextBoxColumn
                    = new DataGridViewTextBoxColumn();  
                //The column name (in the CardCollections Entity) to get the data from.
                dataGridViewTextBoxColumn.DataPropertyName = columnNames[index];    
                dataGridViewTextBoxColumn.HeaderText = columnNames[index];
                dataGridViewTextBoxColumn.Width = columnWidths[index];
                collectionsGridView.Columns.Add(dataGridViewTextBoxColumn);
            }
            collectionsGridView.DataSource = _cardsCollections;
        }
        private void handleAddCollection(object sender, EventArgs e)
        {
            AddCollectionForm addCollectionForm = new AddCollectionForm(this);
            addCollectionForm.Show();
        }

        private void handleCollectionDetails(object sender, EventArgs e)
        {

            if (_clickedCardsCollection == null)
            {
                MessageBox.Show("Double click on one of the collections, u dummy!",
                    "Read this carefully", MessageBoxButtons.OK);
                return;
            }


            if (_crossFormInfoDict.ContainsKey("collection"))
            {
                _crossFormInfoDict.Remove("collection");
            }
            _crossFormInfoDict.Add("collection", _clickedCardsCollection);
            CollectionDetailsForm collectionDetailsForm =
                new CollectionDetailsForm(_crossFormInfoDict, this);
            collectionDetailsForm.Show();
        }

        private void collectionsGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            _clickedCardsCollection = _cardsCollections[e.RowIndex];
        }

        private void handleCollectionDelete(object sender, EventArgs e)
        {
            if (_clickedCardsCollection == null)
            {
                MessageBox.Show("Double click on one of the collections, u dummy!",
                    "Read this carefully", MessageBoxButtons.OK);
                return;
            }
            
            DialogResult res = MessageBox.Show("Do you really want to delete the following Collection:\n\n" +
                "  Name: "+_clickedCardsCollection.Name+
                "\n  Description: " + _clickedCardsCollection.Description +
                "\n\nAny changes is irreversible!",
                "Read this carefully", MessageBoxButtons.OKCancel);
            if (res == DialogResult.OK)
            {
                _unitOfWork.CardsCollectionRepository.Delete(_clickedCardsCollection);
                _unitOfWork.Save();
                //Removes the deleted collection from the clickedCardsCollection
                //To prevent accidental deletion of non-existent object.
                _clickedCardsCollection = null; 
                refreshList();                
            }

        }
    }
}
