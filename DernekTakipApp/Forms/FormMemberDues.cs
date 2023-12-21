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

            if(_member.UyelikTarihi == new DateTime(_member.UyelikTarihi.Value.Year, _member.UyelikTarihi.Month.Year,0))

            LabelOcakKalan.Text = $"{dues?.OcakAidat - duePayment?.OcakAidat}" ?? "0";
            LabelSubatKalan.Text = $"{dues?.SubatAidat - duePayment?.SubatAidat}" ?? "0";
            LabelMartKalan.Text = $"{dues?.MartAidat - duePayment?.MartAidat}" ?? "0";
            LabelNisanKalan.Text = $"{dues?.NisanAidat - duePayment?.NisanAidat}" ?? "0";
            LabelMayisKalan.Text = $"{dues?.MayisAidat - duePayment?.MayisAidat}" ?? "0";
            LabelHaziranKalan.Text = $"{dues?.HaziranAidat - duePayment?.HaziranAidat}" ?? "0";
            LabelTemmuzKalan.Text = $"{dues?.TemmuzAidat - duePayment?.TemmuzAidat}" ?? "0";
            LabelAgustosKalan.Text = $"{dues?.AgustosAidat - duePayment?.AgustosAidat}" ?? "0";
            LabelEylulKalan.Text = $"{dues?.EylulAidat - duePayment?.EylulAidat}" ?? "0";
            LabelEkimKalan.Text = $"{dues?.EkimAidat - duePayment?.EkimAidat}" ?? "0";
            LabelKasimKalan.Text = $"{dues?.KasimAidat - duePayment?.KasimAidat}" ?? "0";
            LabelAralikKalan.Text = $"{dues?.AralikAidat - duePayment?.AralikAidat}" ?? "0";
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
