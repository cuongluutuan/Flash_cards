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
    public partial class WelcomeControls : UserControl
    {
        private UnitOfWork _unitOfWork;
        public WelcomeControls(UnitOfWork unitOfWork)
        {
            InitializeComponent();
            _unitOfWork = unitOfWork;
        }
    }
}
