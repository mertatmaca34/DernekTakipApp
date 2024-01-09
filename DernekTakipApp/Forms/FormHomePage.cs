using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Abstract;
using ZedGraph;

namespace DernekTakipApp.Forms
{
    public partial class FormHomePage : Form
    {
        private IMemberManager _memberManager;
        private IDuePaymentManager _duePaymentManager;
        private IDueManager _dueManager;

        public FormHomePage(IMemberManager memberManager, IDuePaymentManager duePaymentManager, IDueManager dueManager)
        {
            _memberManager = memberManager;
            _duePaymentManager = duePaymentManager;
            _dueManager = dueManager;

            InitializeComponent();

            //graphPaneAidatAylik = ZedGraphAylaraGoreAidat.GraphPane;
            ConfigureZedGraph();
            ConfigureZedGraphYillik();
            ConfigureZedGraphSehirlereGoreDagilim();
        }

        private void FormHomePage_Load(object sender, EventArgs e)
        {
            //AssignAylaraGoreAidatGraph();
        }

        private void ConfigureZedGraph()
        {
            // ZedGraph kontrolü için ayarları yap
            GraphPane myPane = ZedGraphAylaraGoreAidat.GraphPane;
            myPane.Title.Text = "Aylara Göre Aidat Gelirleri";
            myPane.XAxis.Title.Text = "Aylar";
            myPane.YAxis.Title.Text = "Aidat Geliri (TL)";

            // Aylık aidat gelirlerini hesapla
            Dictionary<string, double> monthlyIncome = CalculateMonthlyIncome();

            // ZedGraph için veri ekle
            BarItem myBar = myPane.AddBar("Aylık Aidat Geliri", null, monthlyIncome.Values.ToArray(), monthlyIncome.Count > 0 ? Color.Blue : Color.Red);
            myPane.XAxis.Scale.TextLabels = monthlyIncome.Keys.ToArray();
            myPane.XAxis.Type = AxisType.Text;
            myPane.BarSettings.MinClusterGap = 1.0f;

            // ZedGraph'i yeniden çiz
            ZedGraphAylaraGoreAidat.AxisChange();
            ZedGraphAylaraGoreAidat.Invalidate();
        }

        private Dictionary<string, double> CalculateMonthlyIncome()
        {
            // Aylık aidat gelirlerini hesapla
            Dictionary<string, double> monthlyIncome = new Dictionary<string, double>();

            // Üyeleri al
            var members = _memberManager.GetAll().Data;

            foreach (var member in members)
            {
                // Üyenin ödemelerini al
                var duePayments = _duePaymentManager.GetAll().Data;

                foreach (var duePayment in duePayments)
                {
                    // DueId ile Due bilgisini al
                    var due = _dueManager.Get(d => d.Id == duePayment.DueId).Data;

                    // DueDate değerini kullanarak aylık anahtarı oluştur
                    string monthKey = due.DueDate.ToString("MMM yyyy");

                    if (monthlyIncome.ContainsKey(monthKey))
                    {
                        monthlyIncome[monthKey] += duePayment.PaymentAmount;
                    }
                    else
                    {
                        monthlyIncome.Add(monthKey, duePayment.PaymentAmount);
                    }
                }
            }

            return monthlyIncome;
        }

        private Dictionary<string, double> CalculateYearlyIncome()
        {
            // Yıllık aidat gelirlerini hesapla
            Dictionary<string, double> yearlyIncome = new Dictionary<string, double>();

            // Üyeleri al
            var members = _memberManager.GetAll().Data;

            foreach (var member in members)
            {
                // Üyenin ödemelerini al
                var duePayments = _duePaymentManager.GetAll().Data;

                foreach (var duePayment in duePayments)
                {
                    // DueId ile Due bilgisini al
                    var due = _dueManager.Get(d => d.Id == duePayment.DueId).Data;

                    // Yıl değerini kullanarak yıllık anahtarı oluştur
                    string yearKey = due.DueDate.Year.ToString();

                    if (yearlyIncome.ContainsKey(yearKey))
                    {
                        yearlyIncome[yearKey] += duePayment.PaymentAmount;
                    }
                    else
                    {
                        yearlyIncome.Add(yearKey, duePayment.PaymentAmount);
                    }
                }
            }

            return yearlyIncome;
        }

        private void ConfigureZedGraphYillik()
        {
            // ZedGraph kontrolü için ayarları yap
            GraphPane myPane = ZedGraphAidatGelirleriYillik.GraphPane;
            myPane.Title.Text = "Yıllara Göre Aidat Gelirleri";
            myPane.XAxis.Title.Text = "Yıllar";
            myPane.YAxis.Title.Text = "Toplam Aidat Geliri (TL)";

            // Yıllık aidat gelirlerini hesapla
            Dictionary<string, double> yearlyIncome = CalculateYearlyIncome();

            // Eğer veri yoksa veya veri sıfırsa kullanıcıya uyarı ver
            if (yearlyIncome == null || yearlyIncome.Values.All(value => value == 0))
            {
                MessageBox.Show("Yıllık aidat geliri verisi bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ZedGraph için veri ekle
            BarItem myBar = myPane.AddBar("Yıllık Aidat Geliri", null, yearlyIncome.Values.ToArray(), yearlyIncome.Count > 0 ? Color.Green : Color.Red);
            myPane.XAxis.Scale.TextLabels = yearlyIncome.Keys.ToArray();
            myPane.XAxis.Type = AxisType.Text;
            myPane.BarSettings.MinClusterGap = 3.0f;

            // ZedGraph'i yeniden çiz
            ZedGraphAidatGelirleriYillik.AxisChange();
            ZedGraphAidatGelirleriYillik.Invalidate();
        }

        private void ConfigureZedGraphSehirlereGoreDagilim()
        {
            // ZedGraph kontrolü için ayarları yap
            GraphPane myPane = ZedGraphSehirlereGoreDagilim.GraphPane;
            myPane.Title.Text = "Şehirlere Göre Üye Dağılımı";
            myPane.XAxis.Title.Text = "Şehirler";
            myPane.YAxis.Title.Text = "Üye Sayısı";

            // Şehirlere göre üye dağılımını hesapla
            Dictionary<string, double> cityDistribution = CalculateCityDistribution();

            // Eğer veri yoksa veya veri sıfırsa kullanıcıya uyarı ver
            if (cityDistribution == null || cityDistribution.Values.All(value => value == 0))
            {
                MessageBox.Show("Üye dağılımı verisi bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ZedGraph için veri ekle
            BarItem myBar = myPane.AddBar("Üye Sayısı", null, cityDistribution.Values.ToArray(), cityDistribution.Count > 0 ? Color.Orange : Color.Red);

            // X ekseni metin etiketlerini belirle
            myPane.XAxis.Scale.TextLabels = cityDistribution.Keys.ToArray();
            myPane.XAxis.Type = AxisType.Text; // X ekseni tipini metin olarak belirt
            myPane.BarSettings.MinClusterGap = 1.0f;

            // ZedGraph'i yeniden çiz
            ZedGraphSehirlereGoreDagilim.AxisChange();
            ZedGraphSehirlereGoreDagilim.Invalidate();
        }

        private Dictionary<string, double> CalculateCityDistribution()
        {
            // Şehirlere göre üye dağılımını hesapla
            Dictionary<string, double> cityDistribution = new Dictionary<string, double>();

            // Üyeleri al

            var members = _memberManager.GetAll().Data;

            foreach (var member in members)
            {
                string city = member.Sehir ?? "Bilinmiyor"; // Şehir bilgisi null ise veya boşsa "Bilinmiyor" olarak kabul et

                if (cityDistribution.ContainsKey(city))
                {
                    cityDistribution[city]++;
                }
                else
                {
                    cityDistribution.Add(city, 1);
                }
            }

            return cityDistribution;
        }
    }
}
