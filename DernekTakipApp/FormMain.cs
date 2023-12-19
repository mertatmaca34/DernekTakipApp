using Business.Abstract;
using DernekTakipApp.Forms;
using DernekTakipApp.Utils;

namespace DernekTakipApp
{
    public partial class FormMain : Form
    {
        readonly IMemberManager _memberManager;

        public FormMain(IMemberManager memberManager)
        {
            _memberManager = memberManager;

            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            PageChange.Change(PanelContent, this, new FormMembers(_memberManager));
            RoundedCorners.MakeRounded(ButtonMembers, ButtonDues, ButtonPayments, ButtonMail);
        }
    }
}