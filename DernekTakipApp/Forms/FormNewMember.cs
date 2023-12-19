﻿using Business.Abstract;
using Business.Constants;
using Entities.Concrete;

namespace DernekTakipApp.Forms
{
    public partial class FormNewMember : Form
    {
        IMemberManager _memberManager;

        public FormNewMember(IMemberManager memberManager)
        {
            _memberManager = memberManager;

            InitializeComponent();
        }

        public FormNewMember(IMemberManager memberManager, Member member)
        {
            _memberManager = memberManager;

            TextBoxName.Text = member.AdSoyad;
            TextBoxTc.Text = member.TcKimlik;
            ComboBoxBloodGroup.Text = member.KanGrubu;
            ComboBoxCity.Text = member.Sehir;
            ButtonDues.Enabled = true;

            InitializeComponent();
        }

        private void FormNewMember_Load(object sender, EventArgs e)
        {
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            Member member = new Member
            {
                AdSoyad = TextBoxName.Text,
                TcKimlik = TextBoxTc.Text,
                KanGrubu = ComboBoxBloodGroup.Text,
                Sehir = ComboBoxCity.Text,
                Aktif = CheckBoxMemberStatement.Checked
            };

            var res = _memberManager.Add(member);

            MessageBox.Show(res.Message, Messages.CaptionInfo, MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

        private void ButtonDues_Click(object sender, EventArgs e)
        {
            FormMemberDues formMemberDues = new FormMemberDues();

            formMemberDues.ShowDialog();
        }
    }
}
