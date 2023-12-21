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

            AssignDefaultValues(member);
        }

        private void AssignDefaultValues(Member member)
        {
            AssignDues();

            DuePayment selectedYearDuePayment = _duePaymentManager.Get(d => d.Year == ComboBoxYear.Text && d.MemberTC == member.TcKimlik).Data;

            TextBoxOcakOdenen.Text = selectedYearDuePayment.OcakAidat.ToString() ?? "0";
            TextBoxSubatOdenen.Text = selectedYearDuePayment.SubatAidat.ToString() ?? "0";
            TextBoxMartOdenen.Text = selectedYearDuePayment.MartAidat.ToString() ?? "0";
            TextBoxNisanOdenen.Text = selectedYearDuePayment.NisanAidat.ToString() ?? "0";
            TextBoxMayisOdenen.Text = selectedYearDuePayment.MayisAidat.ToString() ?? "0";
            TextBoxHaziranOdenen.Text = selectedYearDuePayment.HaziranAidat.ToString() ?? "0";
            TextBoxTemmuzOdenen.Text = selectedYearDuePayment.TemmuzAidat.ToString() ?? "0";
            TextBoxAgustosOdenen.Text = selectedYearDuePayment.AgustosAidat.ToString() ?? "0";
            TextBoxEylulOdenen.Text = selectedYearDuePayment.EylulAidat.ToString() ?? "0";
            TextBoxEkimOdenen.Text = selectedYearDuePayment.EkimAidat.ToString() ?? "0";
            TextBoxKasimOdenen.Text = selectedYearDuePayment.KasimAidat.ToString() ?? "0";
            TextBoxAralikOdenen.Text = selectedYearDuePayment.AralikAidat.ToString() ?? "0";

        }

        private void AssignDues()
        {
            var selectedYearDues = _dueManager.Get(d => d.Year == ComboBoxYear.Text);

            LabelOcakAidat.Text = selectedYearDues.Data?.OcakAidat.ToString() ?? "0";
            LabelSubatAidat.Text = selectedYearDues.Data?.SubatAidat.ToString() ?? "0";
            LabelMartAidat.Text = selectedYearDues.Data?.MartAidat.ToString() ?? "0";
            LabelNisanAidat.Text = selectedYearDues.Data?.NisanAidat.ToString() ?? "0";
            LabelMayisAidat.Text = selectedYearDues.Data?.MayisAidat.ToString() ?? "0";
            LabelHaziranAidat.Text = selectedYearDues.Data?.HaziranAidat.ToString() ?? "0";
            LabelTemmuzAidat.Text = selectedYearDues.Data?.TemmuzAidat.ToString() ?? "0";
            LabelAgustosAidat.Text = selectedYearDues.Data?.AgustosAidat.ToString() ?? "0";
            LabelEylulAidat.Text = selectedYearDues.Data?.EylulAidat.ToString() ?? "0";
            LabelEkimAidat.Text = selectedYearDues.Data?.EkimAidat.ToString() ?? "0";
            LabelKasimAidat.Text = selectedYearDues.Data?.KasimAidat.ToString() ?? "0";
            LabelAralikAidat.Text = selectedYearDues.Data?.AralikAidat.ToString() ?? "0";
        }

        private void ComboBoxYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            DuePayment duePayment = _duePaymentManager.Get(d => d.Year == ComboBoxYear.Text).Data;

            TextBoxOcakOdenen.Text          = duePayment.OcakAidat.ToString();
            TextBoxSubatOdenen.Text         = duePayment.SubatAidat.ToString();
            TextBoxMartOdenen.Text          = duePayment.MartAidat.ToString();
            TextBoxNisanOdenen.Text         = duePayment.NisanAidat.ToString();
            TextBoxMayisOdenen.Text         = duePayment.MayisAidat.ToString();
            TextBoxHaziranOdenen.Text       = duePayment.HaziranAidat.ToString();
            TextBoxTemmuzOdenen.Text        = duePayment.TemmuzAidat.ToString();
            TextBoxAgustosOdenen.Text       = duePayment.AgustosAidat.ToString();
            TextBoxEylulOdenen.Text         = duePayment.EylulAidat.ToString();
            TextBoxEkimOdenen.Text          = duePayment.EkimAidat.ToString();
            TextBoxKasimOdenen.Text         = duePayment.KasimAidat.ToString();
            TextBoxAralikOdenen.Text        = duePayment.AralikAidat.ToString();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            DuePayment duePayment = new DuePayment
            {
                MemberTC        = _member.TcKimlik,
                Year            = ComboBoxYear.Text,
                OcakAidat       = TextBoxOcakOdenen.Text.ToDouble(),
                SubatAidat      = TextBoxSubatOdenen.Text.ToDouble(),
                MartAidat       = TextBoxMartOdenen.Text.ToDouble(),
                NisanAidat      = TextBoxNisanOdenen.Text.ToDouble(),
                MayisAidat      = TextBoxMayisOdenen.Text.ToDouble(),
                HaziranAidat    = TextBoxHaziranOdenen.Text.ToDouble(),
                TemmuzAidat     = TextBoxTemmuzOdenen.Text.ToDouble(),
                AgustosAidat    = TextBoxAgustosOdenen.Text.ToDouble(),
                EylulAidat      = TextBoxEylulOdenen.Text.ToDouble(),
                EkimAidat       = TextBoxEkimOdenen.Text.ToDouble(),
                KasimAidat      = TextBoxKasimOdenen.Text.ToDouble(),
                AralikAidat     = TextBoxAralikOdenen.Text.ToDouble(),
            };

            var res = _duePaymentManager.Add(duePayment);

            MessageBox.Show(res.Message);
        }
    }
}
