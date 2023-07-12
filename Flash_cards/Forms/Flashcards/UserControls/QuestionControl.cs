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
        private QaDTO currentQaDto;
        public QuestionControl(QaDTO qaDTO, FlashcardForm form)
        {
            InitializeComponent();
            question = qaDTO.question!;
            correctAnswer = qaDTO.correctAns!;
            currentQaDto = qaDTO;
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
        private void showCorrectAnswers(Button clickedBtn)
        {
            List<Button> buttons = new List<Button>() {
                answer1,answer2,answer3,answer4
            };
            foreach (Button button in buttons)
            {
                if (button.Text == correctAnswer)
                {
                    button.UseVisualStyleBackColor = false;
                    button.BackColor = Color.Green;
                    button.ForeColor = Color.White;
                    if (clickedBtn.Equals(button))
                    {
                        form.updateScore();
                    }
                    else
                    {
                        form.handleFalseAnswer(currentQaDto);
                    }
                }
                else
                {
                    button.UseVisualStyleBackColor = false;
                    button.BackColor = Color.Red;
                    button.ForeColor = Color.White;
                }
                button.Enabled = false;
            }
            nextBtn.Visible = true;
        }

        private void answer1_Click(object sender, EventArgs e)
        {
            //if (answer1.Text == correctAnswer)
            //{
            //    answer1.BackColor = Color.Green;
            //    answer1.ForeColor = Color.White;
            //}
            //else {
            //    answer1.BackColor = Color.Red;
            //    answer1.ForeColor = Color.White;
            //}
            showCorrectAnswers(answer1);
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
            //if (answer2.Text == correctAnswer)
            //{
            //    answer2.BackColor = Color.Green;
            //    answer2.ForeColor = Color.White;
            //}
            //else {
            //    answer2.BackColor = Color.Red;
            //    answer2.ForeColor = Color.White;
            //}
            showCorrectAnswers(answer2);
        }

        private void answer_3_click(object sender, EventArgs e)
        {
            //if (answer3.Text == correctAnswer)
            //{
            //    answer3.BackColor = Color.Green;
            //    answer3.ForeColor = Color.White;
            //}
            //else {
            //    answer3.BackColor = Color.Red;
            //    answer3.ForeColor = Color.White;
            //}
            showCorrectAnswers(answer3);
        }

        private void answer_4_click(object sender, EventArgs e)
        {
            //if (answer4.Text == correctAnswer)
            //{
            //    answer4.BackColor = Color.Green;
            //    answer4.ForeColor = Color.White;
            //}
            //else {
            //    answer4.BackColor = Color.Red;
            //    answer4.ForeColor = Color.White;
            //}
            showCorrectAnswers(answer4);
        }
    }
}
