using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flash_cards.Question
{
    public partial class singleChoice : Form
    {

        private int currentQuestionIndex = 0;
        private int correctAnswersCount = 0;

        private List<QuestionEntity> questions = new List<QuestionEntity>{
                new QuestionEntity
                {
                    Text = "What is the capital of France?",
                    Choices = new List<string> { "London", "Paris", "Berlin", "Madrid" },
                    CorrectAnswerIndex = 1 // Index of the correct answer in the Choices list
                },
                    // Add more questions...
                };
        public singleChoice()
        {

            InitializeComponent();
        }


        private void DisplayQuestion(QuestionEntity question)
        {
            questionContent.Text = question.Text;

            answer1.Text = question.Choices[0];
            answer2.Text = question.Choices[0];
            answer3.Text = question.Choices[0];
            answer4.Text = question.Choices[0];
        }

        private void answer_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            int selectedAnswerIndex = int.Parse(clickedButton.Tag.ToString());

            // Check if the selected answer is correct
            QuestionEntity currentQuestion = questions[currentQuestionIndex];
            bool isCorrect = selectedAnswerIndex == currentQuestion.CorrectAnswerIndex;

            // Process the answer (e.g., display feedback, keep score, etc.)

            // Move to the next question
            currentQuestionIndex++;
            if (currentQuestionIndex < questions.Count)
            {
                DisplayQuestion(questions[currentQuestionIndex]);
            }
            else
            {
                // Handle the end of the quiz (e.g., display score, show results, etc.)
            }
        }
    }
}
