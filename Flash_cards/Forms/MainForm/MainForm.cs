using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Flash_cards.Forms.MainForm;
using Flash_cards.UserControls;
using Services.Repository;

namespace Flash_cards.Forms.MainForm
{
    public partial class MainForm : Form
    {
        private UserControl _welcomeControls;
        private UserControl _collectionControls;
        private UserControl _questionsBankControls;
        private Control _currentControl;
        private UnitOfWork _unitOfWork;
        public MainForm()
        {
            InitializeComponent();
            _unitOfWork = new UnitOfWork();
            _welcomeControls = new WelcomeControls(_unitOfWork);
            _collectionControls = new CollectionControls();
            _questionsBankControls = new QuestionsBankControls(_unitOfWork);

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
        private void handleWelcome(object sender, EventArgs e)
        {
            ChangeControl(mainUIPanel, _welcomeControls);
        }
        private void handleCollections(object sender, EventArgs e)
        {
            ChangeControl(mainUIPanel, _collectionControls);
        }
        private void handleQuestionBank(object sender, EventArgs e)
        {
            ChangeControl(mainUIPanel, _questionsBankControls);
        }

    
        private void handleFlashcardsControl(object sender, EventArgs e)
        {
            
        }

       
    }
}
