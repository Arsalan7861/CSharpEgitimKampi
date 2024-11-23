using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi301.EFProject
{
    public partial class FrmStatistics : Form
    {
        public FrmStatistics()
        {
            InitializeComponent();
        }

        EgitimKampiEFTravelDbEntities db = new EgitimKampiEFTravelDbEntities();
        private void FrmStatistics_Load(object sender, EventArgs e)
        {
            lblLocationCount.Text = db.Locations.Count().ToString();
            lblSumCapacity.Text = db.Locations.Sum(x => x.LocationCapacity).ToString();
            lblGuideCount.Text = db.Locations.Count().ToString();
            lblAvgCapacity.Text = db.Locations.Average(x => x.LocationCapacity).ToString();
            var avgPrice = db.Locations.Average(x => x.LocationPrice);
            lblAvgLocationPrice.Text = $"{avgPrice:F2} TL";
            int lastCountryId = db.Locations.Max(x=> x.LocationId);
            lblLastCountryName.Text = db.Locations.Where(x => x.LocationId == lastCountryId).Select(x => x.LocationCountry).FirstOrDefault();
            lblCappadociaLocationCapacity.Text=db.Locations.Where(x=>x.LocationCity=="Kapadokya").Select(y=>y.LocationCapacity).FirstOrDefault().ToString();
            lblTurkiyeCapacityAvg.Text = db.Locations.Where(x => x.LocationCountry == "Turkiye").Average(y => y.LocationCapacity).ToString();

            var romeGuideId = db.Locations.Where(x => x.LocationCity == "Roma").Select(y => y.GuideId).FirstOrDefault();
            lblRomeGuideName.Text = db.Guides.Where(x=>x.GuideId==romeGuideId).Select(y=>y.GuideName + " " + y.GuideSurname).FirstOrDefault();

            var maxCapacity = db.Locations.Max(x => x.LocationCapacity);
            lblMaxCapacityLocation.Text = db.Locations.Where(x => x.LocationCapacity == maxCapacity).Select(y => y.LocationCity).FirstOrDefault();

            var maxPrice = db.Locations.Max(x => x.LocationPrice);
            lblMaxPriceLocation.Text = db.Locations.Where(x => x.LocationPrice == maxPrice).Select(y => y.LocationCity).FirstOrDefault();

            var guideIdByNameArsalanKhroush = db.Guides.Where(x => x.GuideName == "Arsalan" && x.GuideSurname == "Khroush").Select(y => y.GuideId).FirstOrDefault();
            lblArsalanKhroushLocationCount.Text = db.Locations.Where(x => x.GuideId == guideIdByNameArsalanKhroush).Count().ToString();
        }
    }
}
