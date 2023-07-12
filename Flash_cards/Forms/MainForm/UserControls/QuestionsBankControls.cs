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
    public partial class QuestionsBankControls : UserControl
    {
        private string[] options = { "Questions", "Answers" };
        private UnitOfWork _unitOfWork;
        public QuestionsBankControls(UnitOfWork unitOfWork)
        {
            InitializeComponent();
            _unitOfWork = unitOfWork;
            foreach (String option in options)
            {
                searchFilterComboBox.Items.Add(option);
            }


        }

        private void searchFilterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
