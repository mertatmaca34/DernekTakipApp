using Business.Abstract;
using DernekTakipApp.Forms;
using DernekTakipApp.Utils;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Query.Internal;

namespace DernekTakipApp
{
    public partial class FormMain : Form
    {
        private readonly IMemberManager _memberManager;
        private readonly IDueManager _dueManager;
        private readonly IDuePaymentManager _duePaymentManager;
        private readonly IEmailSettingsManager _emailSettingsManager;

        public FormMain(IMemberManager memberManager, IDueManager dueManager, IDuePaymentManager duePaymentManager, IEmailSettingsManager emailSettingsManager)
        {
            InitializeComponent();

            _memberManager = memberManager;
            _dueManager = dueManager;
            _duePaymentManager = duePaymentManager;
            _emailSettingsManager = emailSettingsManager;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            PageChange.Change(PanelContent, this, new FormMembers(_memberManager, _dueManager, _duePaymentManager));
            RoundedCorners.MakeRounded(ButtonMembers, ButtonDues, ButtonPayments, ButtonMail, ButtonHome);
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
            PageChange.Change(PanelContent, this, new FormMemberDebts(_memberManager, _duePaymentManager, _dueManager, _emailSettingsManager));
            ColorTransformations.Replace(TableLayoutPanelLeftBar, ButtonPayments);
        }

        private void ButtonMail_Click(object sender, EventArgs e)
        {
            PageChange.Change(PanelContent, this, new FormMail(_emailSettingsManager));
            ColorTransformations.Replace(TableLayoutPanelLeftBar, ButtonMail);
        }

        private void ButtonHome_Click(object sender, EventArgs e)
        {
            PageChange.Change(PanelContent, this, new FormHomePage(_memberManager, _duePaymentManager, _dueManager));
            ColorTransformations.Replace(TableLayoutPanelLeftBar, ButtonHome);
        }

        private void FormMain_SizeChanged(object sender, EventArgs e)
        {
            foreach (Form activeForm in PanelContent.Controls)
            {
                activeForm.Size = PanelContent.Size;
            }
        }

        private void AssignDefaultValues()
        {

        }
    }
}