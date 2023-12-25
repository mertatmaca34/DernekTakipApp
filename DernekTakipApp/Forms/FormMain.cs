using Business.Abstract;
using DernekTakipApp.Forms;
using DernekTakipApp.Utils;

namespace DernekTakipApp
{
    public partial class FormMain : Form
    {
        readonly IMemberManager _memberManager;
        readonly IDueManager _dueManager;
        readonly IDuePaymentManager _duePaymentManager;

        public FormMain(IMemberManager memberManager, IDueManager dueManager, IDuePaymentManager duePaymentManager)
        {
            InitializeComponent();

            _memberManager = memberManager;
            _dueManager = dueManager;
            _duePaymentManager = duePaymentManager;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            PageChange.Change(PanelContent, this, new FormMembers(_memberManager, _dueManager, _duePaymentManager));
            RoundedCorners.MakeRounded(ButtonMembers, ButtonDues, ButtonPayments, ButtonMail);
        }

        private void ButtonMembers_Click(object sender, EventArgs e)
        {
            PageChange.Change(PanelContent, this, new FormMembers(_memberManager, _dueManager, _duePaymentManager));
            ColorTransformations.Replace(TableLayoutPanelLeftBar, ButtonMembers);
        }

        private void ButtonDues_Click(object sender, EventArgs e)
        {
            PageChange.Change(PanelContent, this, new FormDues(_dueManager));
            ColorTransformations.Replace(TableLayoutPanelLeftBar, ButtonDues);
        }

        private void ButtonPayments_Click(object sender, EventArgs e)
        {
            PageChange.Change(PanelContent, this, new FormMemberDebts(_memberManager, _duePaymentManager, _dueManager));
            ColorTransformations.Replace(TableLayoutPanelLeftBar, ButtonPayments);
        }

        private void ButtonMail_Click(object sender, EventArgs e)
        {
            ColorTransformations.Replace(TableLayoutPanelLeftBar, ButtonMail);
        }
    }
}