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
        
        public LowStock_Form()
        {
            InitializeComponent();
        }
        private void displayLowStock_GV()
        {
            IEnumerable<Medicine> medicines_var =db.Medicines.ToList();
            if (minimum_txt.Text != "")
            {
                medicines_var = medicines_var.Where(n => (n.Quantity <= int.Parse(minimum_txt.Text)) )
                    .ToList();
            }
            else
            {
                medicines_var = medicines_var.Where(n => (n.Quantity <= n.MinimumQuantity))
                .ToList();
            }
            if (ignoreZero_checkBox.Checked)
            {

                medicines_var = medicines_var.Where(n => n.Quantity != 0)
                .ToList();
            }
            else
            {
                // do Nothing
            }
            lowStock_GV.DataSource = medicines_var.Select(n => new { Code=n.Code,Name = n.Name,
                Quantity = n.Quantity, MinimumQuantity = n.MinimumQuantity })
                .ToList();
        }
        private void ignoreZero_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            displayLowStock_GV();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LowStock_Form_Load(object sender, EventArgs e)
        {
            lowStock_GV.DataSource = db.Medicines.Where(n => n.Quantity <= n.MinimumQuantity)
                .Select(n => new { Code = n.Code, Name = n.Name, Quantity = n.Quantity,
                MinimumQuantity = n.MinimumQuantity }).ToList();
        }

        private void Reset_btn_Click(object sender, EventArgs e)
        {
            minimum_txt.Text = "";
            ignoreZero_checkBox.Checked = false;
            lowStock_GV.DataSource = db.Medicines.Where(n => n.Quantity <= n.MinimumQuantity)
                .Select(n => new { Code = n.Code, Name = n.Name, Quantity = n.Quantity,
                MinimumQuantity = n.MinimumQuantity }).ToList();
        }

        private void search_min_btn_Click(object sender, EventArgs e)
        {

            displayLowStock_GV();
        }

        private void minimum_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                displayLowStock_GV();
            }
        }
    }
}