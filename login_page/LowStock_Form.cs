using login_page.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login_page
{
    public partial class LowStock_Form : Form
    {
        PharmacyStoreContext db = new PharmacyStoreContext();
        //List<Medicine> medicines_var= db.Medicines.ToList();
        public LowStock_Form()
        {
            InitializeComponent();
        }

        private void ignoreZero_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ignoreZero_checkBox.Checked)
            {

                lowStock_GV.DataSource = db.Medicines.Where(n => (n.Quantity <= n.MinimumQuantity) && (n.Quantity != 0))
                .Select(n => new { Name = n.Name, Quantity = n.Quantity, MinimumQuantity = n.MinimumQuantity })
                .ToList();
            }
            else
            {
                lowStock_GV.DataSource = db.Medicines.Where(n => n.Quantity <= n.MinimumQuantity)
                .Select(n => new { Name = n.Name, Quantity = n.Quantity, MinimumQuantity = n.MinimumQuantity })
                .ToList();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LowStock_Form_Load(object sender, EventArgs e)
        {
            lowStock_GV.DataSource = db.Medicines.Where(n => n.Quantity <= n.MinimumQuantity)
                .Select(n => new { Name = n.Name, Quantity = n.Quantity, MinimumQuantity = n.MinimumQuantity }).ToList();
        }

        private void Reset_btn_Click(object sender, EventArgs e)
        {
            minimum_txt.Text = "";
            ignoreZero_checkBox.Checked = false;
            lowStock_GV.DataSource = db.Medicines.Where(n => n.Quantity <= n.MinimumQuantity)
                .Select(n => new { Name = n.Name, Quantity = n.Quantity, MinimumQuantity = n.MinimumQuantity }).ToList();
        }

        private void search_min_btn_Click(object sender, EventArgs e)
        {

            if (ignoreZero_checkBox.Checked)
            {
                lowStock_GV.DataSource = db.Medicines.Where(n => (n.Quantity <= int.Parse(minimum_txt.Text)) && (n.Quantity != 0))
                    .ToList();
            }
            else
            {
                lowStock_GV.DataSource = db.Medicines.Where(n => n.Quantity <= int.Parse(minimum_txt.Text))
                    .ToList();
            }
        }

        private void minimum_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                search_min_btn_Click (sender, e);
            }
        }
    }
}