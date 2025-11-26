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
    public partial class FrmLocation : Form
    {
        public FrmLocation()
        {
            InitializeComponent();
        }
        EgitimKampıEfTravelDbEntities db = new EgitimKampıEfTravelDbEntities();
        private void btn_list_Click(object sender, EventArgs e)
        {
            var values = db.Location.ToList();
            dataGridView1.DataSource = values;

        }

        private void FrmLocation_Load(object sender, EventArgs e)
        {
            var values = db.Guide.Select(x => new
            {
                FullName = x.GuideName + " " + x.GuideSurname
            }).ToList();
            cmb_guide.DisplayMember = "FullName";
            cmb_guide.ValueMember = "GuideId";
            cmb_guide.DataSource = values;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Location location = new Location();
            location.Capacity = int.Parse(numericUpDown1.Value.ToString());
            location.DayNight = txt_day_night.Text;
            location.City = txt_city.Text;
            location.Country = txt_country.Text;
            location.Price = int.Parse(txt_price.Text);
            location.GuideId = cmb_guide.SelectedIndex;
            db.Location.Add(location);
            db.SaveChanges();
            MessageBox.Show("Başarılı");
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txt_id.Text);
            var location = db.Location.Find(id);
            db.Location.Remove(location);
            db.SaveChanges();
            MessageBox.Show($"Silindi: {location.City}/{location.Country}");
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txt_id.Text);
            var updatedValue = db.Location.Find(id);
            updatedValue.Capacity = int.Parse(numericUpDown1.Value.ToString());
            updatedValue.DayNight = txt_day_night.Text;
            updatedValue.City = txt_city.Text;
            updatedValue.Country = txt_country.Text;
            updatedValue.Price = int.Parse(txt_price.Text);
            updatedValue.GuideId = int.Parse(cmb_guide.SelectedValue.ToString());
            db.SaveChanges();
            MessageBox.Show("Güncellendi");
        }

        private void btn_get_Click(object sender, EventArgs e)
        {

            int id = int.Parse(txt_id.Text);
            var location = db.Location.Where(x => x.LocationId==id).ToList();
            dataGridView1.DataSource = location;
        }
    }
}
