using Business.Abstract;
using Business.Constants;
using DernekTakipApp.Utils;
using Entities.Concrete;

namespace DernekTakipApp.Forms
{
    public partial class FormDues : Form
    {
        readonly IDueManager _dueManager;

        public FormDues(IDueManager dueManager)
        {
            _dueManager = dueManager;

            InitializeComponent();
        }

        private void FormDues_Load(object sender, EventArgs e)
        {
            ComboBoxYear.Text = DateTime.Now.Year.ToString();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            Due due = new()
            {
                Year                = ComboBoxYear.Text,
                OcakAidat           = TextBoxOcakAidat.Text.ToDouble(),
                SubatAidat          = TextBoxSubatAidat.Text.ToDouble(),
                MartAidat           = TextBoxMartAidat.Text.ToDouble(),
                NisanAidat          = TextBoxNisanAidat.Text.ToDouble(),
                MayisAidat          = TextBoxMayisAidat.Text.ToDouble(),
                HaziranAidat        = TextBoxHaziranAidat.Text.ToDouble(),
                TemmuzAidat         = TextBoxTemmuzAidat.Text.ToDouble(),
                AgustosAidat        = TextBoxAgustosAidat.Text.ToDouble(),
                EylulAidat          = TextBoxEylulAidat.Text.ToDouble(),
                EkimAidat           = TextBoxEkimAidat.Text.ToDouble(),
                KasimAidat          = TextBoxKasimAidat.Text.ToDouble(),
                AralikAidat         = TextBoxAralikAidat.Text.ToDouble()
            };

            var res = _dueManager.Add(due);

            MessageBox.Show(res.Message, Messages.CaptionInfo, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ComboBoxYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedYearDues = _dueManager.Get(a => a.Year == ComboBoxYear.Text);

            TextBoxOcakAidat.Text       = selectedYearDues.Data?.OcakAidat.ToString()       ?? "0";
            TextBoxSubatAidat.Text      = selectedYearDues.Data?.SubatAidat.ToString()      ?? "0";
            TextBoxMartAidat.Text       = selectedYearDues.Data?.MartAidat.ToString()       ?? "0";
            TextBoxNisanAidat.Text      = selectedYearDues.Data?.NisanAidat.ToString()      ?? "0";
            TextBoxMayisAidat.Text      = selectedYearDues.Data?.MayisAidat.ToString()      ?? "0";
            TextBoxHaziranAidat.Text    = selectedYearDues.Data?.HaziranAidat.ToString()    ?? "0";
            TextBoxTemmuzAidat.Text     = selectedYearDues.Data?.TemmuzAidat.ToString()     ?? "0";
            TextBoxAgustosAidat.Text    = selectedYearDues.Data?.AgustosAidat.ToString()    ?? "0";
            TextBoxEylulAidat.Text      = selectedYearDues.Data?.EylulAidat.ToString()      ?? "0";
            TextBoxEkimAidat.Text       = selectedYearDues.Data?.EkimAidat.ToString()       ?? "0";
            TextBoxKasimAidat.Text      = selectedYearDues.Data?.KasimAidat.ToString()      ?? "0";
            TextBoxAralikAidat.Text     = selectedYearDues.Data?.AralikAidat.ToString()     ?? "0";
        }
    }
}
