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
            // Her bir üyenin toplam borcunu hesaplayarak bir DataTable oluştur
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("TC Kimlik", typeof(string));
            dataTable.Columns.Add("Toplam Borç", typeof(double));

            foreach (Member member in _members)
            {
                double totalDebt = CalculateTotalDebt(member.TcKimlik);
                dataTable.Rows.Add(member.TcKimlik, totalDebt);
            }

            // DataTable'ı DataGridView'a bağla
            DataGridViewMemberDebts.DataSource = dataTable;
        }

        private double CalculateTotalDebt(string memberTC)
        {
            // Üyenin toplam borcunu hesapla
            double totalPayment = _duePayments
                .Where(d => d.MemberTC == memberTC)
                .Sum(d => CalculateRemainingAmount(d));

            double mustPay = _dueManager.GetAll().Data.Where(d => d.Year == "2023")
                .Sum(d=> d.OcakAidat + d.SubatAidat + d.MartAidat + d.MayisAidat + d.HaziranAidat + d.TemmuzAidat + d.AgustosAidat + d.EylulAidat + d.EkimAidat + d.KasimAidat + d.AralikAidat);

            return totalDebt;
        }

        private double CalculateRemainingAmount(DuePayment duePayment)
        {
            // Geçerli aylara ait aidatların toplamını hesapla
            int currentMonth = DateTime.Now.Month;
            double remainingAmount = 0;

            for (int month = 1; month <= currentMonth; month++)
            {
                remainingAmount += GetRemainingAmount(duePayment, month);
            }

            return remainingAmount;
        }

        public double GetRemainingAmount(DuePayment duePayment, int currentMonth)
        {
            double currentMonthAidat = GetAidatAmount(duePayment, currentMonth);
            double currentMonthPaid = GetPaidAmount(duePayment, currentMonth);

            return currentMonthAidat - currentMonthPaid;
        }

        private double GetAidatAmount(DuePayment duePayment, int currentMonth)
        {
            switch (currentMonth)
            {
                case 1: return duePayment.OcakAidat;
                case 2: return duePayment.SubatAidat;
                case 3: return duePayment.MartAidat;
                case 4: return duePayment.NisanAidat;
                case 5: return duePayment.MayisAidat;
                case 6: return duePayment.HaziranAidat;
                case 7: return duePayment.TemmuzAidat;
                case 8: return duePayment.AgustosAidat;
                case 9: return duePayment.EylulAidat;
                case 10: return duePayment.EkimAidat;
                case 11: return duePayment.KasimAidat;
                case 12: return duePayment.AralikAidat;
                default: return 0; // Geçersiz ay
            }
        }

        private double GetPaidAmount(DuePayment duePayment, int currentMonth)
        {
            return 0; // Örnekte herhangi bir ödeme yapılmadığını varsayalım
        }
    }
}
