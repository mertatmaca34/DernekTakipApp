using Business.Abstract;
using Business.Constants;
using Entities.Concrete;

namespace DernekTakipApp.Forms
{
    public partial class FormMembers : Form
    {
        readonly IMemberManager _memberManager;
        readonly IDuePaymentManager _duePaymentManager;

        List<Member> _members;

        public FormMembers(IMemberManager memberManager, IDuePaymentManager duePaymentManager)
        {
            InitializeComponent();

            _memberManager = memberManager;
            _duePaymentManager = duePaymentManager;

            _members = _memberManager.GetAll().Data.ToList();

            DataGridViewMembers.DataSource = _members;

            DataGridViewCustomization();
        }

        private void ButtonNewMember_Click(object sender, EventArgs e)
        {
            FormNewMember formNewMember = new(_memberManager);
            formNewMember.ShowDialog();
        }

        private void DataGridViewCustomization()
        {
            _members = _memberManager.GetAll().Data.ToList();

            DataGridViewMembers.DataSource = null;
            DataGridViewMembers.DataSource = _members;

            DataGridViewMembers.Columns[3].HeaderText = "TCKN";
            DataGridViewMembers.Columns[4].HeaderText = "Ad Soyad";
            DataGridViewMembers.Columns[5].HeaderText = "Kan Grubu";
            DataGridViewMembers.Columns[6].HeaderText = "Şehir";
            DataGridViewMembers.Columns[7].HeaderText = "Üyelik Durumu";

            DataGridViewMembers.Refresh();
        }

        private void DataGridViewMembers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                var row = DataGridViewMembers.Rows[e.RowIndex];

                string tckn = row.Cells[3].Value.ToString()!;
                string nameSurname = row.Cells[4].Value.ToString()!;
                string bloodGroup = row.Cells[5].Value.ToString()!;
                string city = row.Cells[6].Value.ToString()!;
                bool memberStatement = bool.Parse(row.Cells[7].Value.ToString()!);

                FormNewMember formNewMember = new(_memberManager);

                formNewMember.TextBoxTc.Text = tckn;
                formNewMember.TextBoxName.Text = nameSurname;
                formNewMember.ComboBoxBloodGroup.Text = bloodGroup;
                formNewMember.ComboBoxCity.Text = city;
                formNewMember.CheckBoxMemberStatement.Checked = memberStatement;
                formNewMember.ButtonDues.Enabled = true;
                formNewMember.LabelHeaderText.Text = "Üye Düzenle";

                formNewMember.Text = "Üye Düzenle";

                formNewMember.ShowDialog(this);

                DataGridViewCustomization();
            }
            else if (e.ColumnIndex == 1 && e.RowIndex >= 0)
            {
                var res = MessageBox.Show(Messages.MemberCheckDelete, Messages.CaptionWarning, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (res == DialogResult.Yes)
                {
                    string tckn = DataGridViewMembers.Rows[e.RowIndex].Cells[2].Value.ToString()!;

                    Member member = new() { TcKimlik = tckn };

                    var result = _memberManager.Delete(member);

                    DataGridViewCustomization();

                    MessageBox.Show(result.Message);
                }
            }
            else if (e.ColumnIndex == 2 && e.RowIndex >= 0)
            {
                
            }
        }
    }
}
