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

        private UserControl _welcomeControls = new WelcomeControls();
        private UserControl _importControls = new ImportControls();
        private UserControl _questionControls = new QuestionControls();

        private Control _currentControl;

        public MainForm()
        {
            InitializeComponent();
            _currentControl = _welcomeControls;
            mainUIPanel.Controls.Clear();
            ToScrollable(mainUIPanel);
            mainUIPanel.Controls.Add(_currentControl);
        }

        private void ToScrollable(Panel panel)
        {
            if (panel is not null)
            {
                panel.AutoScroll = false;
                panel.HorizontalScroll.Enabled = false;
                panel.VerticalScroll.Visible = true;
                panel.AutoScroll = true;
            }
        }

        private void ChangeControl(Panel panel, Control control)
        {
            if (panel is null || control is null) return;
            
            panel.Controls.Remove(_currentControl);
            panel.Controls.Add(control);
            _currentControl = control;

        }

        private void handleImport(object sender, EventArgs e)
        {
            ChangeControl(mainUIPanel, _importControls);
        }

        private void handleQuestionBank(object sender, EventArgs e)
        {
            ChangeControl(mainUIPanel, _questionControls);
        }

        private void handleWelcome(object sender, EventArgs e)
        {
            ChangeControl(mainUIPanel, _welcomeControls);
        }
    }
}
