using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Abstract;

namespace DernekTakipApp.Forms
{
    public partial class FormHomePage : Form
    {
        private IMemberManager _memberManager;
        private IDuePaymentManager _duePaymentManager;
        private IDueManager _dueManager;

        public FormHomePage(IMemberManager memberManager, IDuePaymentManager duePaymentManager, IDueManager dueManager)
        {
            _memberManager = memberManager;
            _duePaymentManager = duePaymentManager;
            _dueManager = dueManager;

            InitializeComponent();
        }

        private void FormHomePage_Load(object sender, EventArgs e)
        {

        }
    }
}
