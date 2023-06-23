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
    public partial class QuestionControls : UserControl
    {
        private UnitOfWork _unitOfWork;
        private List<CardsCollection> cardsCollections = null!;

        public QuestionControls(UnitOfWork unitOfWork)
        {
            InitializeComponent();
            _unitOfWork = unitOfWork;
            loadDataToList();
            displayData(cardsCollections);
        }

        private void loadDataToList()
        {

            var collection = new CardsCollection
            {
                Name = "hi",
                Description = "sad",
            };

            _unitOfWork.CardEntryRepository.Create(new CardEntry
            {
                Question = "What am i",
                Learned = false,
                Answer = "cac",
                AnswerSet = "cac|cu|lon|boobs",
                CardsCollection = collection
            });

            _unitOfWork.Save();

            //=====
            cardsCollections = new List<CardsCollection>();
            var list = _unitOfWork.CardsCollectionRepository.GetAll();
            list.ForEach(card => cardsCollections.Add(card));
        }

        private void displayData(List<CardsCollection> list)
        {
            dataGridView1.DataSource = new BindingSource
            {
                DataSource = list,
            };
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
