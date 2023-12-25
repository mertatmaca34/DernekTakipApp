using Business.Abstract;
using DernekTakipApp.Utils;
using Entities.Concrete;

namespace DernekTakipApp.Forms
{
    public partial class FormMemberDues : Form
    {
        readonly IDuePaymentManager _duePaymentManager;
        readonly IDueManager _dueManager;

        readonly Member _member;
        List<Due> _dueList;

        public FormMemberDues(Member member, IDuePaymentManager duePaymentManager, IDueManager dueManager)
        {
            InitializeComponent();

            _duePaymentManager = duePaymentManager;
            _dueManager = dueManager;
            _member = member;

            ComboBoxYear.Text = "2023";
            LabelMemberName.Text = $"ÜYE: {_member.AdSoyad}";

            _dueList = _dueManager.GetAll(d => d.DueDate.Year == Convert.ToInt32(ComboBoxYear.Text)).Data.ToList();

            AssignDefaultValues(member);
        }

        private void AssignDefaultValues(Member member)
        {
            AssignDues();
            AssignDebts();

            var selectedYearDues = _dueManager.GetAll(d => d.DueDate.Year == Convert.ToInt32(ComboBoxYear.Text)).Data.ToList();

            if (selectedYearDues.Count > 0)
            {
                TextBoxOcakOdenen.Text = _duePaymentManager.Get(d => d.DueId == selectedYearDues[0].Id)?.Data.PaymentAmount.ToString() ?? "0";
                TextBoxSubatOdenen.Text = _duePaymentManager.Get(d => d.DueId == selectedYearDues[1].Id)?.Data.PaymentAmount.ToString() ?? "0";
                TextBoxMartOdenen.Text = _duePaymentManager.Get(d => d.DueId == selectedYearDues[2].Id)?.Data.PaymentAmount.ToString() ?? "0";
                TextBoxNisanOdenen.Text = _duePaymentManager.Get(d => d.DueId == selectedYearDues[3].Id)?.Data.PaymentAmount.ToString() ?? "0";
                TextBoxMayisOdenen.Text = _duePaymentManager.Get(d => d.DueId == selectedYearDues[4].Id)?.Data.PaymentAmount.ToString() ?? "0";
                TextBoxHaziranOdenen.Text = _duePaymentManager.Get(d => d.DueId == selectedYearDues[5].Id)?.Data.PaymentAmount.ToString() ?? "0";
                TextBoxTemmuzOdenen.Text = _duePaymentManager.Get(d => d.DueId == selectedYearDues[6].Id)?.Data.PaymentAmount.ToString() ?? "0";
                TextBoxAgustosOdenen.Text = _duePaymentManager.Get(d => d.DueId == selectedYearDues[7].Id)?.Data.PaymentAmount.ToString() ?? "0";
                TextBoxEylulOdenen.Text = _duePaymentManager.Get(d => d.DueId == selectedYearDues[8].Id)?.Data.PaymentAmount.ToString() ?? "0";
                TextBoxEkimOdenen.Text = _duePaymentManager.Get(d => d.DueId == selectedYearDues[9].Id)?.Data.PaymentAmount.ToString() ?? "0";
                TextBoxKasimOdenen.Text = _duePaymentManager.Get(d => d.DueId == selectedYearDues[10].Id)?.Data.PaymentAmount.ToString() ?? "0";
                TextBoxAralikOdenen.Text = _duePaymentManager.Get(d => d.DueId == selectedYearDues[11].Id)?.Data.PaymentAmount.ToString() ?? "0";
            }
        }

        private void AssignDues()
        {
            var selectedYearDues = _dueManager.GetAll(a => a.DueDate.Year == Convert.ToInt32(ComboBoxYear.Text));

            LabelOcakAidat.Text = selectedYearDues.Data[0].DueAmount.ToString() ?? "0";
            LabelSubatAidat.Text = selectedYearDues.Data[1].DueAmount.ToString() ?? "0";
            LabelMartAidat.Text = selectedYearDues.Data[2].DueAmount.ToString() ?? "0";
            LabelNisanAidat.Text = selectedYearDues.Data[3].DueAmount.ToString() ?? "0";
            LabelMayisAidat.Text = selectedYearDues.Data[4].DueAmount.ToString() ?? "0";
            LabelHaziranAidat.Text = selectedYearDues.Data[5].DueAmount.ToString() ?? "0";
            LabelTemmuzAidat.Text = selectedYearDues.Data[6].DueAmount.ToString() ?? "0";
            LabelAgustosAidat.Text = selectedYearDues.Data[7].DueAmount.ToString() ?? "0";
            LabelEylulAidat.Text = selectedYearDues.Data[8].DueAmount.ToString() ?? "0";
            LabelEkimAidat.Text = selectedYearDues.Data[9].DueAmount.ToString() ?? "0";
            LabelKasimAidat.Text = selectedYearDues.Data[10].DueAmount.ToString() ?? "0";
            LabelAralikAidat.Text = selectedYearDues.Data[11].DueAmount.ToString() ?? "0";
        }

        private void AssignDebts()
        {
            var selectedYearDues = _dueManager.GetAll(d => d.DueDate.Year == Convert.ToInt32(ComboBoxYear.Text));
            var memberPayments = _duePaymentManager.GetAll(d => d.MemberTC == _member.TcKimlik).Data.ToList();

            var selectedYearPayments = memberPayments.Where(d => selectedYearDues.Data.Any(p => p.Id == d.DueId)).ToList();

            if (selectedYearPayments.Count > 0)
            {
                LabelOcakKalan.Text = (selectedYearDues.Data[0].DueAmount - _duePaymentManager.Get(d => d.DueId == selectedYearDues.Data[0].Id)?.Data.PaymentAmount).ToString() ?? "0";
                LabelSubatKalan.Text = (selectedYearDues.Data[1].DueAmount - _duePaymentManager.Get(d => d.DueId == selectedYearDues.Data[1].Id)?.Data.PaymentAmount).ToString() ?? "0";
                LabelMartKalan.Text = (selectedYearDues.Data[2].DueAmount - _duePaymentManager.Get(d => d.DueId == selectedYearDues.Data[2].Id)?.Data.PaymentAmount).ToString() ?? "0";
                LabelNisanKalan.Text = (selectedYearDues.Data[3].DueAmount - _duePaymentManager.Get(d => d.DueId == selectedYearDues.Data[3].Id)?.Data.PaymentAmount).ToString() ?? "0";
                LabelMayisKalan.Text = (selectedYearDues.Data[4].DueAmount - _duePaymentManager.Get(d => d.DueId == selectedYearDues.Data[4].Id)?.Data.PaymentAmount).ToString() ?? "0";
                LabelHaziranKalan.Text = (selectedYearDues.Data[5].DueAmount - _duePaymentManager.Get(d => d.DueId == selectedYearDues.Data[5].Id)?.Data.PaymentAmount).ToString() ?? "0";
                LabelTemmuzKalan.Text = (selectedYearDues.Data[6].DueAmount - _duePaymentManager.Get(d => d.DueId == selectedYearDues.Data[6].Id)?.Data.PaymentAmount).ToString() ?? "0";
                LabelAgustosKalan.Text = (selectedYearDues.Data[7].DueAmount - _duePaymentManager.Get(d => d.DueId == selectedYearDues.Data[7].Id)?.Data.PaymentAmount).ToString() ?? "0";
                LabelEylulKalan.Text = (selectedYearDues.Data[8].DueAmount - _duePaymentManager.Get(d => d.DueId == selectedYearDues.Data[8].Id)?.Data.PaymentAmount).ToString() ?? "0";
                LabelEkimKalan.Text = (selectedYearDues.Data[9].DueAmount - _duePaymentManager.Get(d => d.DueId == selectedYearDues.Data[9].Id)?.Data.PaymentAmount).ToString() ?? "0";
                LabelKasimKalan.Text = (selectedYearDues.Data[10].DueAmount - _duePaymentManager.Get(d => d.DueId == selectedYearDues.Data[10].Id)?.Data.PaymentAmount).ToString() ?? "0";
                LabelAralikKalan.Text = (selectedYearDues.Data[11].DueAmount - _duePaymentManager.Get(d => d.DueId == selectedYearDues.Data[11].Id)?.Data.PaymentAmount).ToString() ?? "0";
            }
            else
            {
                LabelOcakKalan.Text = "0";
                LabelSubatKalan.Text = "0";
                LabelMartKalan.Text = "0";
                LabelNisanKalan.Text = "0";
                LabelMayisKalan.Text = "0";
                LabelHaziranKalan.Text = "0";
                LabelTemmuzKalan.Text = "0";
                LabelAgustosKalan.Text = "0";
                LabelEylulKalan.Text = "0";
                LabelEkimKalan.Text = "0";
                LabelKasimKalan.Text = "0";
                LabelAralikKalan.Text = "0";
            }
        }

        private void ComboBoxYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            AssignDefaultValues(_member);
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            SaveDuePayment(TextBoxOcakOdenen, 1);
            SaveDuePayment(TextBoxSubatOdenen, 2);
            SaveDuePayment(TextBoxMartOdenen, 3);
            SaveDuePayment(TextBoxNisanOdenen, 4);
            SaveDuePayment(TextBoxMayisOdenen, 5);
            SaveDuePayment(TextBoxHaziranOdenen, 6);
            SaveDuePayment(TextBoxTemmuzOdenen, 7);
            SaveDuePayment(TextBoxAgustosOdenen, 8);
            SaveDuePayment(TextBoxEylulOdenen, 9);
            SaveDuePayment(TextBoxEkimOdenen, 10);
            SaveDuePayment(TextBoxKasimOdenen, 11);
            SaveDuePayment(TextBoxAralikOdenen, 12);

            this.Close();
        }

        private void SaveDuePayment(Control textBox, int month)
        {
            var year = Convert.ToInt32(ComboBoxYear.Text);

            var due = _dueManager.Get(d => d.DueDate.Year == year && d.DueDate.Month == month).Data;

            var duePayment = new DuePayment()
            {
                DueId = due.Id,
                MemberTC = _member.TcKimlik,
                PaymentAmount = textBox.Text.ToDouble()
            };

            var res = _duePaymentManager.Add(duePayment);
        }
    }
}
