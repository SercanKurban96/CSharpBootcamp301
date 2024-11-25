using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpBootcamp301.EFProject
{
    public partial class FrmStatistics : Form
    {
        public FrmStatistics()
        {
            InitializeComponent();
        }
        BootcampEfTravelDbEntities db = new BootcampEfTravelDbEntities();
        private void FrmStatistics_Load(object sender, EventArgs e)
        {
            // Lokasyon Sayısı
            lblLocationCount.Text = db.TblLocation.Count().ToString();

            // Toplam Kapasite
            lblSumCapacity.Text = db.TblLocation.Sum(x => x.Capacity).ToString();

            // Rehber Sayısı
            lblGuideCount.Text = db.TblGuide.Count().ToString();

            // Ortalama Kapasite
            lblAvgCapacity.Text = db.TblLocation.Average(x => x.Capacity)?.ToString("0.00");

            // Ortalama Tur Fiyatı
            lblAvgLocationPrice.Text = db.TblLocation.Average(x => x.Price)?.ToString("0.00") + " ₺";

            // Eklenen Son Ülke
            int lastCountryID = db.TblLocation.Max(x => x.LocationID);
            lblLastCountryName.Text = db.TblLocation.Where(x => x.LocationID == lastCountryID).Select(y => y.Country).FirstOrDefault();

            // Kapadokya Tur Kapasitesi
            lblCappadociaLocationCapacity.Text = db.TblLocation.Where(x=>x.City == "Kapadokya").Select(y => y.Capacity).FirstOrDefault().ToString();

            // Türkiye Turları Ortalama Kapasite
            lblTurkiyeCapacityAvg.Text = db.TblLocation.Where(x=>x.Country == "Türkiye").Average(y => y.Capacity).ToString();

            // Roma Gezi Rehberi
            var romeGuideID = db.TblLocation.Where(x=>x.City == "Roma Turistik").Select(y=>y.GuideID).FirstOrDefault();
            lblRomeGuideName.Text = db.TblGuide.Where(x=>x.GuideID == romeGuideID).Select(y=>y.GuideName + " " + y.GuideSurname).FirstOrDefault().ToString();

            // En Yüksek Kapasiteli Tur
            var maxCapacity = db.TblLocation.Max(x => x.Capacity);
            lblMaxCapacityLocation.Text = db.TblLocation.Where(x=>x.Capacity == maxCapacity).Select(y=>y.City).FirstOrDefault().ToString();

            // En Pahalı Tur
            var maxPrice = db.TblLocation.Max(x => x.Price);
            lblMaxPriceLocation.Text = db.TblLocation.Where(x=>x.Price == maxPrice).Select(y=>y.City).FirstOrDefault().ToString();

            // Ayşegül Çınar Tur Sayısı
            var guideIDByNameAysegulCinar = db.TblGuide.Where(x => x.GuideName == "Ayşegül" && x.GuideSurname == "Çınar").Select(y => y.GuideID).FirstOrDefault();
            lblAysegulCinarLocationCount.Text = db.TblLocation.Where(x=>x.GuideID == guideIDByNameAysegulCinar).Count().ToString();
        }
    }
}
