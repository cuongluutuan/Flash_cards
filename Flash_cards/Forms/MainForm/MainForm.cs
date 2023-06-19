using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Flash_cards.UserControls;

namespace Flash_cards.Forms.MainForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            mainUIPanel.Controls.Clear();
            mainUIPanel.Controls.Add(new WelcomeControls());
        }

        private void handleImport(object sender, EventArgs e)
        {
            mainUIPanel.Controls.Clear();
            
            /*Allows the Panel to be scrollable*/
            mainUIPanel.AutoScroll = false;
            mainUIPanel.HorizontalScroll.Enabled = false;
            mainUIPanel.VerticalScroll.Visible = true;
            mainUIPanel.AutoScroll = true;
            /*----------------------------------*/
            
            mainUIPanel.Controls.Add(new ImportControls());
        }

        private void handleQuestionBank(object sender, EventArgs e)
        {
            mainUIPanel.Controls.Clear();

            /*Allows the Panel to be scrollable*/
            mainUIPanel.AutoScroll = false;
            mainUIPanel.HorizontalScroll.Enabled = false;
            mainUIPanel.VerticalScroll.Visible = true;
            mainUIPanel.AutoScroll = true;
            /*----------------------------------*/
            mainUIPanel.Controls.Add(new QuestionControls());
        }

        private void handleWelcome(object sender, EventArgs e)
        {
            mainUIPanel.Controls.Clear();

            /*Allows the Panel to be scrollable*/
            mainUIPanel.AutoScroll = false;
            mainUIPanel.HorizontalScroll.Enabled = false;
            mainUIPanel.VerticalScroll.Visible = true;
            mainUIPanel.AutoScroll = true;
            /*----------------------------------*/
            mainUIPanel.Controls.Add(new WelcomeControls());
        }
    }
}
