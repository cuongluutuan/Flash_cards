﻿using Services.Repository;
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
        private string[] options = { "Q&A Keywords", "Collections" };
        public QuestionsBankControls()
        {
            InitializeComponent();
            foreach (String option in options)
            {
                searchFilterComboBox.Items.Add(option);
            }

        }
    }
}
