using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flash_cards.Forms.Flashcards.UserControls
{
    public partial class QuestionControl : UserControl
    {
        
        public QuestionControl(KeyValuePair<string, List<string>> questionData)
        {
            InitializeComponent();
            string question = questionData.Key;
            List<string> answerList = questionData.Value.ToList();
            questionLabel.Text = question;
            answer1.Text = (String?)answerList[0];
            answer2.Text = (String?)answerList[1];
            answer3.Text = (String?)answerList[2];
            answer4.Text = (String?)answerList[3];




        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
