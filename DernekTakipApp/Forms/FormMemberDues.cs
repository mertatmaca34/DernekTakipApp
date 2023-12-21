using Business.Abstract;
using DernekTakipApp.Utils;
using Entities.Concrete;
using System.Diagnostics.Metrics;

namespace DernekTakipApp.Forms
{
    public partial class FormMemberDues : Form
    {
        readonly IDuePaymentManager _duePaymentManager;
        readonly IDueManager _dueManager;

        readonly Member _member;

        public FormMemberDues(Member member, IDuePaymentManager duePaymentManager, IDueManager dueManager)
        {
            InitializeComponent();

            _duePaymentManager = duePaymentManager;
            _dueManager = dueManager;
            _member = member;

            ComboBoxYear.Text = "2023";
            LabelMemberName.Text = $"ÜYE: {_member.AdSoyad}";

            AssignDefaultValues(member);
        }

        private void AssignDefaultValues(Member member)
        {
            AssignDues();
            AssignDebts();

            DuePayment selectedYearDuePayment = _duePaymentManager.Get(d => d.Year == ComboBoxYear.Text && d.MemberTC == member.TcKimlik).Data;

            TextBoxOcakOdenen.Text = selectedYearDuePayment?.OcakAidat.ToString() ?? "0";
            TextBoxSubatOdenen.Text = selectedYearDuePayment?.SubatAidat.ToString() ?? "0";
            TextBoxMartOdenen.Text = selectedYearDuePayment?.MartAidat.ToString() ?? "0";
            TextBoxNisanOdenen.Text = selectedYearDuePayment?.NisanAidat.ToString() ?? "0";
            TextBoxMayisOdenen.Text = selectedYearDuePayment?.MayisAidat.ToString() ?? "0";
            TextBoxHaziranOdenen.Text = selectedYearDuePayment?.HaziranAidat.ToString() ?? "0";
            TextBoxTemmuzOdenen.Text = selectedYearDuePayment?.TemmuzAidat.ToString() ?? "0";
            TextBoxAgustosOdenen.Text = selectedYearDuePayment?.AgustosAidat.ToString() ?? "0";
            TextBoxEylulOdenen.Text = selectedYearDuePayment?.EylulAidat.ToString() ?? "0";
            TextBoxEkimOdenen.Text = selectedYearDuePayment?.EkimAidat.ToString() ?? "0";
            TextBoxKasimOdenen.Text = selectedYearDuePayment?.KasimAidat.ToString() ?? "0";
            TextBoxAralikOdenen.Text = selectedYearDuePayment?.AralikAidat.ToString() ?? "0";

        }

        private void AssignDues()
        {
            Due dues = _dueManager.Get(d => d.Year == ComboBoxYear.Text).Data;

            LabelOcakAidat.Text = dues?.OcakAidat.ToString() ?? "0";
            LabelSubatAidat.Text = dues?.SubatAidat.ToString() ?? "0";
            LabelMartAidat.Text = dues?.MartAidat.ToString() ?? "0";
            LabelNisanAidat.Text = dues?.NisanAidat.ToString() ?? "0";
            LabelMayisAidat.Text = dues?.MayisAidat.ToString() ?? "0";
            LabelHaziranAidat.Text = dues?.HaziranAidat.ToString() ?? "0";
            LabelTemmuzAidat.Text = dues?.TemmuzAidat.ToString() ?? "0";
            LabelAgustosAidat.Text = dues?.AgustosAidat.ToString() ?? "0";
            LabelEylulAidat.Text = dues?.EylulAidat.ToString() ?? "0";
            LabelEkimAidat.Text = dues?.EkimAidat.ToString() ?? "0";
            LabelKasimAidat.Text = dues?.KasimAidat.ToString() ?? "0";
            LabelAralikAidat.Text = dues?.AralikAidat.ToString() ?? "0";
        }

        private void AssignDebts()
        {
            DuePayment duePayment = _duePaymentManager.Get(d => d.Year == ComboBoxYear.Text).Data;
            Due dues = _dueManager.Get(d => d.Year == ComboBoxYear.Text).Data;

            int startMonth = _member.UyelikTarihi!.Value.Month;
            int currentMonth = DateTime.Now.Month;

            LabelOcakKalan.Text = GetRemainingAmount(dues?.OcakAidat, duePayment?.OcakAidat, startMonth, 1, currentMonth);
            LabelSubatKalan.Text = GetRemainingAmount(dues?.SubatAidat, duePayment?.SubatAidat, startMonth, 2, currentMonth);
            LabelMartKalan.Text = GetRemainingAmount(dues?.MartAidat, duePayment?.MartAidat, startMonth, 3, currentMonth);
            LabelNisanKalan.Text = GetRemainingAmount(dues?.NisanAidat, duePayment?.NisanAidat, startMonth, 4, currentMonth);
            LabelMayisKalan.Text = GetRemainingAmount(dues?.MayisAidat, duePayment?.MayisAidat, startMonth, 5, currentMonth);
            LabelHaziranKalan.Text = GetRemainingAmount(dues?.HaziranAidat, duePayment?.HaziranAidat, startMonth, 6, currentMonth);
            LabelTemmuzKalan.Text = GetRemainingAmount(dues?.TemmuzAidat, duePayment?.TemmuzAidat, startMonth, 7, currentMonth);
            LabelAgustosKalan.Text = GetRemainingAmount(dues?.AgustosAidat, duePayment?.AgustosAidat, startMonth, 8, currentMonth);
            LabelEylulKalan.Text = GetRemainingAmount(dues?.EylulAidat, duePayment?.EylulAidat, startMonth, 9, currentMonth);
            LabelEkimKalan.Text = GetRemainingAmount(dues?.EkimAidat, duePayment?.EkimAidat, startMonth, 10, currentMonth);
            LabelKasimKalan.Text = GetRemainingAmount(dues?.KasimAidat, duePayment?.KasimAidat, startMonth, 11, currentMonth);
            LabelAralikKalan.Text = GetRemainingAmount(dues?.AralikAidat, duePayment?.AralikAidat, startMonth, 12, currentMonth);
        }

        private string GetRemainingAmount(double? due, double? paid, int startMonth, int currentMonth, int nowMonth)
        {
            DuePayment duePayment = _duePaymentManager.Get(d => d.Year == ComboBoxYear.Text).Data;

            if (ComboBoxYear.Text == (duePayment?.Year ?? DateTime.Now.Year.ToString()))
            {
                if (currentMonth < startMonth || currentMonth > nowMonth)
                {
                    return "Üye değildi";
                }
                else if (!_member.Aktif)
                {
                    return "Üyelik Pasif";
                }

                return $"{due - paid}" ?? "0";
            }
            else
            {
                return $"{due - paid}" ?? "0";
            }
        }

        private void ComboBoxYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            DuePayment duePayment = _duePaymentManager.Get(d => d.Year == ComboBoxYear.Text).Data;

            TextBoxOcakOdenen.Text = duePayment?.OcakAidat.ToString() ?? "0";
            TextBoxSubatOdenen.Text = duePayment?.SubatAidat.ToString() ?? "0";
            TextBoxMartOdenen.Text = duePayment?.MartAidat.ToString() ?? "0";
            TextBoxNisanOdenen.Text = duePayment?.NisanAidat.ToString() ?? "0";
            TextBoxMayisOdenen.Text = duePayment?.MayisAidat.ToString() ?? "0";
            TextBoxHaziranOdenen.Text = duePayment?.HaziranAidat.ToString() ?? "0";
            TextBoxTemmuzOdenen.Text = duePayment?.TemmuzAidat.ToString() ?? "0";
            TextBoxAgustosOdenen.Text = duePayment?.AgustosAidat.ToString() ?? "0";
            TextBoxEylulOdenen.Text = duePayment?.EylulAidat.ToString() ?? "0";
            TextBoxEkimOdenen.Text = duePayment?.EkimAidat.ToString() ?? "0";
            TextBoxKasimOdenen.Text = duePayment?.KasimAidat.ToString() ?? "0";
            TextBoxAralikOdenen.Text = duePayment?.AralikAidat.ToString() ?? "0";

            AssignDefaultValues(_member);
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            DuePayment duePayment = new()
            {
                MemberTC = _member.TcKimlik,
                Year = ComboBoxYear.Text,
                OcakAidat = TextBoxOcakOdenen.Text.ToDouble(),
                SubatAidat = TextBoxSubatOdenen.Text.ToDouble(),
                MartAidat = TextBoxMartOdenen.Text.ToDouble(),
                NisanAidat = TextBoxNisanOdenen.Text.ToDouble(),
                MayisAidat = TextBoxMayisOdenen.Text.ToDouble(),
                HaziranAidat = TextBoxHaziranOdenen.Text.ToDouble(),
                TemmuzAidat = TextBoxTemmuzOdenen.Text.ToDouble(),
                AgustosAidat = TextBoxAgustosOdenen.Text.ToDouble(),
                EylulAidat = TextBoxEylulOdenen.Text.ToDouble(),
                EkimAidat = TextBoxEkimOdenen.Text.ToDouble(),
                KasimAidat = TextBoxKasimOdenen.Text.ToDouble(),
                AralikAidat = TextBoxAralikOdenen.Text.ToDouble(),
            };

            var res = _duePaymentManager.Add(duePayment);

            MessageBox.Show(res.Message);

            this.Close();
        }
    }
}
