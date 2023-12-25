using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DernekTakipApp.Utils;
using Entities.Concrete;

namespace DernekTakipApp.Forms
{
    public partial class FormDues : Form
    {
        private readonly IDueManager _dueManager;

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
            var year = Convert.ToInt32((ComboBoxYear.Text));

            SaveDue(TextBoxOcakAidat, year, 1);
            SaveDue(TextBoxSubatAidat, year, 2);
            SaveDue(TextBoxMartAidat, year, 3);
            SaveDue(TextBoxNisanAidat, year, 4);
            SaveDue(TextBoxMayisAidat, year, 5);
            SaveDue(TextBoxHaziranAidat, year, 6);
            SaveDue(TextBoxTemmuzAidat, year, 7);
            SaveDue(TextBoxAgustosAidat, year, 8);
            SaveDue(TextBoxEylulAidat, year, 9);
            SaveDue(TextBoxEkimAidat, year, 10);
            SaveDue(TextBoxKasimAidat, year, 11);
            var res = SaveDue(TextBoxAralikAidat, year, 12);

            MessageBox.Show(res.Message, Messages.CaptionInfo, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private IResult SaveDue(Control textBox, int year, int month)
        {
            var due = new Due()
            {
                DueAmount = textBox.Text.ToDouble(),
                DueDate = new DateTime(year, month, 1),
            };

            return _dueManager.Add(due);
        }

        private void ComboBoxYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedYearDues = _dueManager.GetAll(a => a.DueDate.Year == Convert.ToInt32(ComboBoxYear.Text));

            if (selectedYearDues.Data.Count > 0)
            {
                TextBoxOcakAidat.Text       =  selectedYearDues?.Data[0]?.DueAmount.ToString()     ?? "0";
                TextBoxSubatAidat.Text      =  selectedYearDues.Data[1]?.DueAmount.ToString()      ?? "0";
                TextBoxMartAidat.Text       =  selectedYearDues.Data[2].DueAmount.ToString()       ?? "0";
                TextBoxNisanAidat.Text      =  selectedYearDues.Data[3].DueAmount.ToString()       ?? "0";
                TextBoxMayisAidat.Text      =  selectedYearDues.Data[4].DueAmount.ToString()       ?? "0";
                TextBoxHaziranAidat.Text    =  selectedYearDues.Data[5].DueAmount.ToString()       ?? "0";
                TextBoxTemmuzAidat.Text     =  selectedYearDues.Data[6].DueAmount.ToString()       ?? "0";
                TextBoxAgustosAidat.Text    =  selectedYearDues.Data[7].DueAmount.ToString()       ?? "0";
                TextBoxEylulAidat.Text      =  selectedYearDues.Data[8].DueAmount.ToString()       ?? "0";
                TextBoxEkimAidat.Text       =  selectedYearDues.Data[9].DueAmount.ToString()       ?? "0";
                TextBoxKasimAidat.Text      =  selectedYearDues.Data[10].DueAmount.ToString()      ?? "0";
                TextBoxAralikAidat.Text     =  selectedYearDues.Data[11].DueAmount.ToString()      ?? "0";
            }
            else
            {
                TextBoxOcakAidat.Text = "0";
                TextBoxSubatAidat.Text = "0";
                TextBoxMartAidat.Text = "0";
                TextBoxNisanAidat.Text =
                TextBoxMayisAidat.Text = "0";
                TextBoxHaziranAidat.Text = "0";
                TextBoxTemmuzAidat.Text =
                TextBoxAgustosAidat.Text = "0";
                TextBoxEylulAidat.Text = "0";
                TextBoxEkimAidat.Text = "0";
                TextBoxKasimAidat.Text =
                TextBoxAralikAidat.Text = "0";
            }

        }
    }
}
