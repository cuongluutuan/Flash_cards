using Flash_cards.Question;
using Services.DTO;
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

        private FlashcardForm form;
        private string correctAnswer;
        private string question;
        private List<string> falseAnsList;
        public QuestionControl(QaDTO qaDTO, FlashcardForm form)
        {
            InitializeComponent();
            question = qaDTO.question!;
            correctAnswer = qaDTO.correctAns!;

            falseAnsList = qaDTO.falseAnswers!;


            questionLabel.Text = question;

            List<string> dispAns = qaDTO.getSuffled();
            answer1.Text = dispAns[0];
            answer2.Text = dispAns[1];
            answer3.Text = dispAns[2];
            answer4.Text = dispAns[3];
            this.form = form;


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void answer1_Click(object sender, EventArgs e)
        {
            if (answer1.Text == correctAnswer)
            {
                MessageBox.Show("Correct!");
            }
            else MessageBox.Show("Incorrect!");
        }

        private void handlePrevQuestion(object sender, EventArgs e)
        {
            form.showPrevQuestion();
        }

        private void handleNextQuestion(object sender, EventArgs e)
        {
            form.showNextQuestion();
        }

        private void answer2_Click(object sender, EventArgs e)
        {
            if (answer2.Text == correctAnswer)
            {
                MessageBox.Show("Correct!");
            }
            else MessageBox.Show("Incorrect!");
        }

        private void answer_3_click(object sender, EventArgs e)
        {
            if (answer3.Text == correctAnswer)
            {
                MessageBox.Show("Correct!");
            }
            else MessageBox.Show("Incorrect!");
        }

        private void answer_4_click(object sender, EventArgs e)
        {
            if (answer4.Text == correctAnswer)
            {
                MessageBox.Show("Correct!");
            }
            else MessageBox.Show("Incorrect!");
        }
    }
}
