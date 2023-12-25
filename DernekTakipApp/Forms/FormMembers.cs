using Business.Abstract;
using Business.Constants;
using Entities.Concrete;
using System.Reflection;
using System.Windows.Forms;

namespace DernekTakipApp.Forms
{
    public partial class FormMembers : Form
    {
        readonly IMemberManager _memberManager;
        readonly IDueManager _dueManager;
        readonly IDuePaymentManager _duePaymentManager;

        List<Member> _members;

        public FormMembers(IMemberManager memberManager, IDueManager dueManager, IDuePaymentManager duePaymentManager)
        {
            InitializeComponent();

            _memberManager = memberManager;
            _dueManager = dueManager;
            _duePaymentManager = duePaymentManager;

            _members = _memberManager.GetAll().Data.ToList();

            DataGridViewMembers.DataSource = _members;

            DataGridViewCustomization(_members);
        }

        private void ButtonNewMember_Click(object sender, EventArgs e)
        {
            FormNewMember formNewMember = new(_memberManager);
            formNewMember.ShowDialog();
        }

        private void DataGridViewCustomization(List<Member> members = null)
        {
            DataGridViewMembers.DataSource = null;
            DataGridViewMembers.DataSource = members;

            DataGridViewMembers.Columns[3].HeaderText = "TCKN";
            DataGridViewMembers.Columns[4].HeaderText = "Üyelik Tarihi";
            DataGridViewMembers.Columns[5].HeaderText = "Ad Soyad";
            DataGridViewMembers.Columns[6].HeaderText = "Kan Grubu";
            DataGridViewMembers.Columns[7].HeaderText = "Şehir";
            DataGridViewMembers.Columns[8].HeaderText = "Üyelik Durumu";

            DataGridViewMembers.Refresh();
        }

        private void DataGridViewMembers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (e)
            {
                case { ColumnIndex: 0, RowIndex: >= 0 }:
                    {
                        var row = DataGridViewMembers.Rows[e.RowIndex];

                        var tckn = row.Cells[3].Value.ToString()!;
                        var registerDate = Convert.ToDateTime(row.Cells[4].Value);
                        var nameSurname = row.Cells[5].Value.ToString()!;
                        var bloodGroup = row.Cells[6].Value.ToString()!;
                        var city = row.Cells[7].Value.ToString()!;
                        var memberStatement = bool.Parse(row.Cells[8].Value.ToString()!);

                        FormNewMember formNewMember = new(_memberManager);

                        formNewMember.TextBoxTc.Text = tckn;
                        formNewMember.TextBoxName.Text = nameSurname;
                        formNewMember.ComboBoxBloodGroup.Text = bloodGroup;
                        formNewMember.ComboBoxCity.Text = city;
                        formNewMember.dateTimePicker1.Value = registerDate;
                        formNewMember.CheckBoxMemberStatement.Checked = memberStatement;
                        formNewMember.LabelHeaderText.Text = "Üye Düzenle";

                        formNewMember.Text = "Üye Düzenle";

                        formNewMember.ShowDialog(this);

                        DataGridViewCustomization(_members);
                        break;
                    }
                case { ColumnIndex: 1, RowIndex: >= 0 }:
                    {
                        var res = MessageBox.Show(Messages.MemberCheckDelete, Messages.CaptionWarning, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                        if (res == DialogResult.Yes)
                        {
                            var tckn = DataGridViewMembers.Rows[e.RowIndex].Cells[2].Value.ToString()!;

                            Member member = new() { TcKimlik = tckn };

                            var result = _memberManager.Delete(member);

                            DataGridViewCustomization(_members);

                            MessageBox.Show(result.Message);
                        }

                        break;
                    }
                case { ColumnIndex: 2, RowIndex: >= 0 }:
                    {
                        var row = DataGridViewMembers.Rows[e.RowIndex];

                        var tckn = row.Cells[3].Value.ToString()!;

                        var member = _memberManager.Get(m => m.TcKimlik == tckn).Data;

                        FormMemberDues formMemberDues = new(member, _duePaymentManager, _dueManager);

                        formMemberDues.ShowDialog(this);
                        break;
                    }
            }
        }

        private void ComboBoxFilterBloodGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            var filteredMembers = _members.Where(m => m.KanGrubu == ComboBoxFilterBloodGroup.Text).ToList();

            DataGridViewCustomization(filteredMembers);
        }

        private void ComboBoxFilterCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            var filteredMembers = _members.Where(m => m.Sehir == ComboBoxFilterCity.Text).ToList();

            DataGridViewCustomization(filteredMembers);
        }

        private void TextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            var filteredMembers = _members.Where(customer =>
            {
                for (var index = 0; index < customer.GetType().GetProperties().Length; index++)
                {
                    var property = customer.GetType().GetProperties()[index];
                    var value = property.GetValue(customer);

                    if (value != null &&
                        value.ToString()?.IndexOf(TextBoxSearch.Text, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        return true;
                    }
                }

                return false;
            }).ToList();

            DataGridViewCustomization(filteredMembers);
        }
    }
}
