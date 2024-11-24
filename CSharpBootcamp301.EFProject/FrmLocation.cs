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
    public partial class FrmLocation : Form
    {
        public FrmLocation()
        {
            InitializeComponent();
        }
        BootcampEfTravelDbEntities db = new BootcampEfTravelDbEntities();
        private void btnList_Click(object sender, EventArgs e)
        {
            var values = db.TblLocation.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            TblLocation tblLocation = new TblLocation();            
            tblLocation.City = txtCity.Text;
            tblLocation.Country = txtCountry.Text;
            tblLocation.Capacity = byte.Parse(numCapacity.Value.ToString());
            tblLocation.Price = decimal.Parse(txtPrice.Text);
            tblLocation.DayNight = txtDayNight.Text;
            tblLocation.GuideID = int.Parse(cmbGuide.SelectedValue.ToString());
            db.TblLocation.Add(tblLocation);
            db.SaveChanges();
            MessageBox.Show("Ekleme işlemi başarılı.");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtLocationID.Text);
            var deletedValue = db.TblLocation.Find(id);
            db.TblLocation.Remove(deletedValue);
            db.SaveChanges();
            MessageBox.Show("Silme işlemi başarılı.");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtLocationID.Text);
            var updatedValue = db.TblLocation.Find(id);
            updatedValue.City = txtCity.Text;
            updatedValue.Country = txtCountry.Text;
            updatedValue.Capacity = byte.Parse(numCapacity.Value.ToString());
            updatedValue.Price = decimal.Parse(txtPrice.Text);
            updatedValue.DayNight = txtDayNight.Text;
            updatedValue.GuideID = int.Parse(cmbGuide.SelectedValue.ToString());
            db.SaveChanges();
            MessageBox.Show("Güncelleme işlemi başarılı.");

        }

        private void FrmLocation_Load(object sender, EventArgs e)
        {
            var values = db.TblGuide.Select(x => new
            {
                FullName = x.GuideName + " " + x.GuideSurname,
                x.GuideID
            }).ToList();
            cmbGuide.DisplayMember = "FullName";
            cmbGuide.ValueMember = "GuideID";
            cmbGuide.DataSource = values;
        }
    }
}
