using DernekTakipApp.Forms;
using DernekTakipApp.Utils;

namespace DernekTakipApp
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            PageChange.Change(PanelContent, this, new FormMembers());
        }
    }
}