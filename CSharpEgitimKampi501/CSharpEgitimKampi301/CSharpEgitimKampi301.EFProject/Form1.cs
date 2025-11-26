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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        EgitimKampıEfTravelDbEntities db = new EgitimKampıEfTravelDbEntities();

        private void btn_list_Click(object sender, EventArgs e)
        {
            var values = db.Guide.ToList();
            dataGridView1.DataSource = values;

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Guide guide = new Guide();
            guide.GuideName = txt_name.Text;
            guide.GuideSurname = txt_soyadı.Text;
            db.Guide.Add(guide);
            db.SaveChanges();
            MessageBox.Show("Eklendi!");
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txt_id.Text);
            var removeValue = db.Guide.Find(id);
            db.Guide.Remove(removeValue);
            db.SaveChanges();
            MessageBox.Show("Silindi!");
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txt_id.Text);
            var updateValue = db.Guide.Find(id);
            updateValue.GuideName = txt_name.Text;
            updateValue.GuideSurname = txt_soyadı.Text;
            db.SaveChanges();
            MessageBox.Show($"Güncellendi! {txt_name.Text} {txt_soyadı.Text}");
        }

        private void btn_get_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txt_id.Text);
            var findingPerson = db.Guide.Where(x => x.GuideId == id).ToList();
            dataGridView1.DataSource = findingPerson;
        }
    }
}
