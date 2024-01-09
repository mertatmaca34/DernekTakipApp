using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Services.Email;
using DernekTakipApp.Enums;

namespace DernekTakipApp.Forms
{
    public partial class FormMemberDebts : Form
    {
        private IMemberManager _memberManager;
        private IDuePaymentManager _duePaymentManager;
        private IDueManager _dueManager;
        private IEmailSettingsManager _emailSettingsManager;

        List<Member> _members;
        List<DuePayment> _duePayments;

        public FormMemberDebts(IMemberManager memberManager, IDuePaymentManager duePaymentManager, IDueManager dueManager, IEmailSettingsManager emailSettingsManager)
        {
            InitializeComponent();

            _duePaymentManager = duePaymentManager;
            _memberManager = memberManager;
            _dueManager = dueManager;
            _emailSettingsManager = emailSettingsManager;

            _members = _memberManager.GetAll().Data;
            _duePayments = _duePaymentManager.GetAll().Data;

            ComboBoxFilter.Text = "HEPSİ";

            CalculateAndDisplay();
        }

        private void CalculateAndDisplay()
        {
            var dataTable = new DataTable();

            if (ComboBoxFilter.Text == "HEPSİ")
            {
                dataTable.Columns.Add("TC Kimlik", typeof(string));
                dataTable.Columns.Add("Toplam Borç", typeof(double));
                dataTable.Columns.Add("Toplam Ödeme", typeof(double));

                foreach (var member in _members)
                {
                    var totalDebt = CalculateTotalDebt(member.TcKimlik, PaymentType.Debt);
                    var totalPayment = CalculateTotalDebt(member.TcKimlik, PaymentType.Payment);

                    dataTable.Rows.Add(member.TcKimlik, totalDebt, totalPayment);
                }
            }
            else if (ComboBoxFilter.Text == "ÖDEME YAPANLAR")
            {
                dataTable.Columns.Add("TC Kimlik", typeof(string));
                dataTable.Columns.Add("Toplam Ödeme", typeof(double));

                foreach (var member in _members)
                {
                    var totalPayment = CalculateTotalDebt(member.TcKimlik, PaymentType.Payment);

                    dataTable.Rows.Add(member.TcKimlik, totalPayment);
                }
            }

            else if (ComboBoxFilter.Text == "ÖDEME YAPMAYANLAR")
            {
                dataTable.Columns.Add("TC Kimlik", typeof(string));
                dataTable.Columns.Add("Toplam Borç", typeof(double));

                foreach (var member in _members)
                {
                    var totalDebt = CalculateTotalDebt(member.TcKimlik, PaymentType.Debt);

                    dataTable.Rows.Add(member.TcKimlik, totalDebt);
                }
            }

            DataGridViewMemberDebts.DataSource = dataTable;
            DataGridViewMemberDebts.Refresh();
        }

        private double CalculateTotalDebt(string memberTc, PaymentType paymentType)
        {
            var startDate = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, 1);
            var endDate = new DateTime(dateTimePicker2.Value.Year, dateTimePicker2.Value.Month, 1);

            var dues = _dueManager.GetAll(d => d.DueDate >= startDate && d.DueDate <= endDate).Data.ToList();

            var totalPayment = _duePayments
                .Where(p => p.MemberTC == memberTc && dues.Any(d => d.Id == p.DueId)).ToList();

            if (paymentType == PaymentType.Debt)
            {
                return dues.Sum(d => d.DueAmount) - totalPayment.Sum(p => p.PaymentAmount);

            }
            else
            {
                return totalPayment.Sum(d => d.PaymentAmount);
            }
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            CalculateAndDisplay();
        }

        private async void ButtonSendMails_Click(object sender, EventArgs e)
        {
            var _emailSettings = _emailSettingsManager.Get(e => e.Id == 1)?.Data;

            if (_emailSettings != null)
            {
                EmailService emailService = new EmailService();

                foreach (var member in _members)
                {
                    var totalDebt = CalculateTotalDebt(member.TcKimlik, PaymentType.Debt);

                    if (totalDebt > 0)
                    {
                        var body = _emailSettings.Body;

                        if (_emailSettings.IncludeDebtInfo)
                        {
                            body += $"Borç tutarınız: {totalDebt} TL'dir.";
                        }

                        var res = await emailService.MailSend(_emailSettings.Host, _emailSettings.Port,
                            _emailSettings.UserName, _emailSettings.Password, _emailSettings.UseSSL,
                            _emailSettings.UseDefaultCredentials, member.Mail, _emailSettings.Subject, body);

                        MessageBox.Show(res);
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen önce mail ayarlarını yapın.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void FormMemberDebts_Load(object sender, EventArgs e)
        {

        }
    }
}
