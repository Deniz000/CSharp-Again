using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
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
        EgitimKampıEfTravelDbEntities db = new EgitimKampıEfTravelDbEntities();
        private void FrmStatistics_Load(object sender, EventArgs e)
        {
            lblLocationCount.Text = db.Location.Count().ToString();
            lblCapacityCount.Text = db.Location.Sum(x=> x.Capacity).ToString();
            lblGuideCount.Text = db.Guide.Count().ToString();
            lblAvarageCapacity.Text = db.Location.Average(x => x.Capacity).ToString().Substring(0,6);
            lblAvarageLocationPrice.Text = db.Location.Average(z => z.Price)?.ToString("N2") + "\u20BA";

            int lastCountryId = db.Location.Max(x => x.LocationId);
            lblLastCountryName.Text = db.Location.Where(x => x.LocationId == lastCountryId).Select(x => x.Country).FirstOrDefault();

            lblCapacityOfKapadokya.Text = 
                db.Location.Where(x => x.City == "Kapadokya").Select(x => x.Capacity).FirstOrDefault().ToString();

            lblAverageTourCapacityOfTurkiye.Text =
                db.Location.Where(x=> x.Country == "Türkiye").Average(x=>x.Capacity).ToString();


            //l.Guide ise Location entity’sinin içindeki navigation property’dir.
            //Yani Location ile Guide arasında ilişki varsa (FK), EF sana Location nesnesinin
            //içinden Guide’a gitmen için bir “kısayol” property verir.
            lblRomeGuideName.Text = db.Location
                .Where(l => l.City == "Adana")
                .Select(l => l.Guide.GuideName + " " + l.Guide.GuideSurname)
                .FirstOrDefault() ?? "";

            lblMaxCapacityCountry.Text = db.Location
                .OrderByDescending(x => x.Capacity)
                .Select (x => x.Country).FirstOrDefault().ToString();

            lblMaxPriceTour.Text = db.Location
                .OrderByDescending(x => x.Price)
                .Select(x=>x.City + ", " + x.Country).FirstOrDefault().ToString();

            int personId = db.Guide.Where(x=> x.GuideName=="Neriman" && x.GuideSurname=="Öztürk").Select(x=>x.GuideId).FirstOrDefault();

            lblPersonLocationCount.Text = db.Location.Where(x=> x.GuideId == personId).Count().ToString();
        }
    }
}
