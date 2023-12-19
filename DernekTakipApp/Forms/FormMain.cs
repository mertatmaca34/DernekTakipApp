using Business.Abstract;
using DernekTakipApp.Forms;
using DernekTakipApp.Utils;

namespace DernekTakipApp
{
    public partial class FormMain : Form
    {
        readonly IMemberManager _memberManager;
        readonly IDueManager _dueManager;

        public FormMain(IMemberManager memberManager, IDueManager dueManager)
        {
            InitializeComponent();

            _memberManager = memberManager;
            _dueManager = dueManager;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            PageChange.Change(PanelContent, this, new FormMembers(_memberManager));
            RoundedCorners.MakeRounded(ButtonMembers, ButtonDues, ButtonPayments, ButtonMail);
        }

        private void ButtonMembers_Click(object sender, EventArgs e)
        {
            PageChange.Change(PanelContent, this, new FormMembers(_memberManager));
        }

        private void ButtonDues_Click(object sender, EventArgs e)
        {
            PageChange.Change(PanelContent, this, new FormDues(_dueManager));
        }
    }
}