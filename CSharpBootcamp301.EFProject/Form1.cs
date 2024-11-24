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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        BootcampEfTravelDbEntities db = new BootcampEfTravelDbEntities();

        private void btnList_Click(object sender, EventArgs e)
        {
            var values = db.TblGuide.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            TblGuide tblGuide = new TblGuide();
            tblGuide.GuideName = txtGuideName.Text;
            tblGuide.GuideSurname = txtGuideSurname.Text;
            db.TblGuide.Add(tblGuide);
            db.SaveChanges();
            MessageBox.Show("Rehber başarıyla eklendi.");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtGuideID.Text);
            var removeValue = db.TblGuide.Find(id);
            db.TblGuide.Remove(removeValue);
            db.SaveChanges();
            MessageBox.Show("Rehber başarıyla silindi.");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtGuideID.Text);
            var updateValue = db.TblGuide.Find(id);
            updateValue.GuideName = txtGuideName.Text;
            updateValue.GuideSurname = txtGuideSurname.Text;
            db.SaveChanges();
            MessageBox.Show("Rehber başarıyla güncellendi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnGetByID_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtGuideID.Text);
            var values = db.TblGuide.Where(x => x.GuideID == id).ToList();
            dataGridView1.DataSource = values;
        }
    }
}
