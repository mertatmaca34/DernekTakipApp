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

namespace DernekTakipApp.Forms
{
    public partial class FormMemberDebts : Form
    {
        IMemberManager _memberManager;
        IDuePaymentManager _duePaymentManager;
        IDueManager _dueManager;

        List<Member> _members;
        List<DuePayment> _duePayments;

        public FormMemberDebts(IMemberManager memberManager, IDuePaymentManager duePaymentManager, IDueManager dueManager)
        {
            InitializeComponent();

            _duePaymentManager = duePaymentManager;
            _memberManager = memberManager;
            _dueManager = dueManager;

            _members = _memberManager.GetAll().Data;
            _duePayments = _duePaymentManager.GetAll().Data;

            CalculateAndDisplayTotalDebts();
        }

        private void CalculateAndDisplayTotalDebts()
        {
            var dataTable = new DataTable();
            dataTable.Columns.Add("TC Kimlik", typeof(string));
            dataTable.Columns.Add("Toplam Borç", typeof(double));

            foreach (var member in _members)
            {
                var totalDebt = CalculateTotalDebt(member.TcKimlik);
                dataTable.Rows.Add(member.TcKimlik, totalDebt);
            }

            DataGridViewMemberDebts.DataSource = dataTable;
        }

        private double CalculateTotalDebt(string memberTc)
        {
            var startDate = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, 1);
            var endDate = new DateTime(dateTimePicker1.Value.Year, dateTimePicker2.Value.Month, 1);

            var dues = _dueManager.GetAll(d => d.DueDate >= startDate && d.DueDate <= endDate).Data.ToList();

            var totalPayment = _duePayments
                .Where(p=> p.MemberTC == memberTc && dues.Any(d=> d.Id == p.DueId)).ToList();

            return dues.Sum(d=> d.DueAmount) - totalPayment.Sum(p=> p.PaymentAmount);
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
