using login_page.Models;
using Microsoft.EntityFrameworkCore;
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
    public partial class LowStock_usercontrol : UserControl
    {
        public LowStock_usercontrol()
        {
            InitializeComponent();
        }
        private void LoadMedicinesOnGridView()
        {
            lowStock_GV.DataSource = DbServices.Instance.GetData<Medicine>().Where(n => n.Quantity <= n.MinimumQuantity)
                .Select(n => new
                {
                    Code = n.Code,
                    Name = n.Name,
                    Quantity = n.Quantity,
                    MinimumQuantity = n.MinimumQuantity
                }).ToList();
        }
        private void displayLowStockByQuantity_GV()
        {
            IEnumerable<Medicine> medicines_var = DbServices.Instance.GetData<Medicine>();
            if (string.IsNullOrEmpty(Search_txt.Text))
            {
                return;
            }
            else
            {
                if (!int.TryParse(Search_txt.Text, out int min))
                {
                    MessageBox.Show("Incorrect number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                min = min <= 0 ? 0 : min;
                medicines_var = medicines_var.Where(n => (n.Quantity <= min))
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
        private void displayLowStockByDate_GV()
        {
            IEnumerable<DrugDateStock> medicines_var = DbServices.Instance.GetData<DrugDateStock>();
                var searchDate= DateOnly.FromDateTime(DateTime.Now);

            if (string.IsNullOrEmpty(Search_txt.Text))
            {
                return;
            }
            else
            {
                if (!int.TryParse(Search_txt.Text, out int searchValue))
                {
                    MessageBox.Show("Incorrect number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
               
                searchDate = searchValue <= 0 ? DateOnly.FromDateTime(DateTime.Now) : DateOnly.FromDateTime(DateTime.Now.AddMonths(searchValue));
                medicines_var = DbServices.Instance.GetData<DrugDateStock>().Where(n => n.ExpireDate <= searchDate)
                    .OrderBy(m => m.ExpireDate).ToList();
            }

            //if (ignoreZero_checkBox.Checked)
            //{

            //    medicines_var = medicines_var.Where(n => n.Quantity != 0)
            //    .ToList();
            //}
            //else
            //{
            //    // do Nothing
            //}

            lowStock_GV.DataSource= medicines_var
                .Select(n => new
                {
                    Code = DbServices.Instance.GetData<Medicine>().Find(n2=>n2.Id==n.MedicineId)?.Code,
                    Name = DbServices.Instance.GetData<Medicine>().Find(n2 => n2.Id == n.MedicineId)?.Name,
                    TotalQuantity = DbServices.Instance.GetData<Medicine>().Find(n2 => n2.Id == n.MedicineId)?.Quantity,
                    ExpQuantity = n.Quantity,
                    ExpireDate = n.ExpireDate.ToString("MM/yy")
                }).ToList();

            lowStock_GV.Columns["TotalQuantity"].HeaderText = "Total Quantity";
            lowStock_GV.Columns["ExpQuantity"].HeaderText = "Expire Date Quantity";
            lowStock_GV.Columns["ExpireDate"].HeaderText = "Expiry Date (MM/YY)";
        }

        private void LowStock_usercontrol_Load(object sender, EventArgs e)
        {
            LoadMedicinesOnGridView();
            SearchBy_combo.SelectedIndex = 0; // default is search by Barcode
        }

        private void Reset_btn_Click(object sender, EventArgs e)
        {
            Search_txt.Text = "";
            ignoreZero_checkBox.Checked = false;
            SearchBy_combo.SelectedIndex = 0;
            lowStock_GV.DataSource = DbServices.Instance.GetData<Medicine>().Where(n => n.Quantity <= n.MinimumQuantity)
                .Select(n => new
                {
                    Code = n.Code,
                    Name = n.Name,
                    Quantity = n.Quantity,
                    MinimumQuantity = n.MinimumQuantity
                }).ToList();
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            if (SearchBy_combo.SelectedIndex == 0) // search by qantity
            {
                displayLowStockByQuantity_GV(); 
            }
            else // search by Expiry Date
            {
                displayLowStockByDate_GV();
            }
            
        }

        private void minimum_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                search_btn_Click(sender, e);
            }
        }

        
    }
}