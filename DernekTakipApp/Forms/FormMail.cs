using System;
using System.Collections.Generic;
using Business.Abstract;
using Entities.Concrete;

namespace DernekTakipApp.Forms
{
    public partial class FormMail : Form
    {
        IEmailSettingsManager _emailSettingsManager;

        public FormMail(IEmailSettingsManager emailSettingsManager)
        {
            _emailSettingsManager = emailSettingsManager;

            InitializeComponent();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            EmailSettings emailSettings = new EmailSettings
            {
                Host = TextBoxHost.Text,
                Body = TextBoxBody.Text,
                Subject = TextBoxSubject.Text,
                IncludeDebtInfo = CheckBoxDebtInfo.Checked,
                Port = TextBoxPort.Text,
                Password = TextBoxPassword.Text,
                UserName = TextBoxMailAddress.Text,
                UseSSL = CheckBoxUseSSL.Checked,
                UseDefaultCredentials = CheckBoxUseCredentials.Checked
            };

            var res = _emailSettingsManager.Add(emailSettings);

            MessageBox.Show(res.Message);
        }

        private void FormMail_Load(object sender, EventArgs e)
        {
            var res = _emailSettingsManager.Get(e => e.Id == 1).Data;

            if (res != null)
            {
                TextBoxHost.Text = res.Host;
                TextBoxBody.Text = res.Body;
                TextBoxSubject.Text = res.Subject;
                CheckBoxDebtInfo.Checked = res.IncludeDebtInfo;
                TextBoxPort.Text = res.Port;
                TextBoxPassword.Text = res.Password;
                TextBoxMailAddress.Text = res.UserName;
                CheckBoxUseCredentials.Checked = res.UseDefaultCredentials;
                CheckBoxUseSSL.Checked = res.UseSSL;
            }
        }
    }
}
