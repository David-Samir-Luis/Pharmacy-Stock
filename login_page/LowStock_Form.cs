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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace login_page
{
    public partial class LowStock_Form : Form
    {
        List<Medicine> medicinesList;

        public LowStock_Form()
        {
            InitializeComponent();
            using (PharmacyStoreContext db = new PharmacyStoreContext())
            {
                medicinesList = db.Medicines.ToList();
            }
        }
        private void displayLowStock_GV()
        {
            IEnumerable<Medicine> medicines_var = medicinesList;
            int min;
            if (!(minimum_txt.Text == "Enter Minimum Quantity . . ."))
            {
                try
                {
                    min = int.Parse(minimum_txt.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Incorrect number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                min = min <= 0 ? 0 : min;
                medicines_var = medicines_var.Where(n => (n.Quantity <= min))
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


            lowStock_GV.DataSource = medicines_var.Select(n => new
            {
                Code = n.Code,
                Name = n.Name,
                Quantity = n.Quantity,
                MinimumQuantity = n.MinimumQuantity
            })
                .ToList();
        }

        private void LowStock_Form_Load(object sender, EventArgs e)
        {
            lowStock_GV.DataSource = medicinesList.Where(n => n.Quantity <= n.MinimumQuantity)
                .Select(n => new
                {
                    Code = n.Code,
                    Name = n.Name,
                    Quantity = n.Quantity,
                    MinimumQuantity = n.MinimumQuantity
                }).ToList();
        }

        private void Reset_btn_Click(object sender, EventArgs e)
        {
            ignoreZero_checkBox.Checked = false;
            minimum_txt.Text = "Enter Minimum Quantity . . .";  // Restore placeholder
            minimum_txt.ForeColor = Color.Gray;  // Set text color to gray
            lowStock_GV.DataSource = medicinesList.Where(n => n.Quantity <= n.MinimumQuantity)
                .Select(n => new
                {
                    Code = n.Code,
                    Name = n.Name,
                    Quantity = n.Quantity,
                    MinimumQuantity = n.MinimumQuantity
                }).ToList();
        }

        private void search_min_btn_Click(object sender, EventArgs e)
        {
            displayLowStock_GV();
        }

        private void minimum_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                search_min_btn_Click(sender, e);
            }
        }

        private void minimum_txt_Enter(object sender, EventArgs e)
        {
            if (minimum_txt.Text == "Enter Minimum Quantity . . ." && minimum_txt.ForeColor == Color.Gray)
            {
                minimum_txt.Text = "";  // Clear the placeholder
                minimum_txt.ForeColor = Color.Black;  // Set text color to black
            }
        }

        private void minimum_txt_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(minimum_txt.Text))
            {
                minimum_txt.Text = "Enter Minimum Quantity . . .";  // Restore placeholder
                minimum_txt.ForeColor = Color.Gray;  // Set text color to gray
            }
        }
    }
}