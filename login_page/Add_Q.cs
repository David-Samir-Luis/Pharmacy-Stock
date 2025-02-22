﻿using login_page.Models;
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
    public partial class Add_Q : UserControl
    {
        public Add_Q()
        {
            InitializeComponent();
            searchBy_Combo.SelectedIndex = 0; // default is search by Barcode
        }
        class MedicineGV
        {
            private Medicine medicine;
            public string Code { get => medicine.Code; }
            public string Name { get => medicine.Name; }
            public int QuantityToAdd { get; set; }
            public int Stock { get => medicine.Quantity; }

            //public string? Barcode { get; }
            //public DateOnly ExpiryDate { get; set; }

            //public int? MinimumQuantity { get; set; }

            public MedicineGV(Medicine m, int q)
            {
                medicine = m;
                QuantityToAdd = q;
            }
            public void UpdateQuantity()
            {
                medicine.Quantity += QuantityToAdd;
            }
        }

        List<MedicineGV> itemsToBeAdded_ls = new();

        void ResetPanel()
        {
            // Reset panel
            search_txt.Text = "";
            itemsToBeAdded_ls.Clear(); // clear the list 
            // reset gridview 
            itemsToBeAdded_GV.DataSource = null;
            itemsToBeAdded_GV.DataSource = itemsToBeAdded_ls;
        }
        private void searchBy_Combo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void search_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                search_btn_Click(sender, e);
            }
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            List<Medicine> item;
            string searchText = search_txt.Text.ToLower().Trim();
            switch (searchBy_Combo?.SelectedItem?.ToString())
            {
                case "Name":
                    item = DbServices.Instance.GetData<Medicine>().Where(m => m.Name?.ToLower().Trim() == searchText).ToList();
                    break;
                case "Barcode":
                    ///to do search by barcode 
                    item = DbServices.Instance.GetData<Medicine>().Where(m => m.Barcode?.ToLower().Trim() == searchText).ToList();
                    search_txt.Text="";
                    break;
                case "Code":
                    ///to do search by code 
                    item = DbServices.Instance.GetData<Medicine>().Where(c => c.Code.ToLower().Trim() == searchText).ToList();
                    break;
                default:
                    MessageBox.Show("Please select a valid search type!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    item = null;
                    break;
            }

            if (item?.Any() ?? false)
            {
                itemsToBeAdded_ls.Add(new MedicineGV(item.First(), 1));
                itemsToBeAdded_GV.DataSource = null;
                itemsToBeAdded_GV.DataSource = itemsToBeAdded_ls;
                //itemsToBeAdded_GV.RowsAdded += (object sender, EventArgs e) => ;
                itemsToBeAdded_GV.CurrentCell = itemsToBeAdded_GV.Rows[itemsToBeAdded_GV.Rows.Count - 1].Cells[2];
                itemsToBeAdded_GV.BeginEdit(true);
            }
            else
            {
                MessageBox.Show($"NO drug with this {searchBy_Combo?.SelectedItem?.ToString()}!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                search_txt.Focus();
            }
            //MessageBox.Show(itemsToBeAdded_ls.Count.ToString());
        }

        private void Add_Q_Load(object sender, EventArgs e)
        {
            search_txt.Focus();
            CenterButton();
        }
        private void CenterButton()
        {
            int x = (itemsToBeAdded_GV.Width - save_n.Width) / 3;
            save_n.Location = new Point(x, save_n.Location.Y);
            cancel_n.Location = new Point(2 * x, cancel_n.Location.Y);
        }

        private void save_n_Click(object sender, EventArgs e)
        {
            using (var db = new PharmacyStoreContext()) // Replace with your actual DbContext
            {
                foreach (var item in itemsToBeAdded_ls)
                {
                    var existingItem = db.Medicines.FirstOrDefault(m => m.Code == item.Code);
                    if (existingItem != null)
                    {
                        // Update the database entity with modified values
                        existingItem.Name = item.Name;
                        existingItem.Code = item.Code;
                        // Add other fields if needed
                    }
                }

                db.SaveChanges(); // Save changes to the database
            }

            foreach (var item in itemsToBeAdded_ls)
            {
                item.UpdateQuantity();
            }

            ResetPanel();

            MessageBox.Show("Changes saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void cancel_n_Click(object sender, EventArgs e)
        {
            ResetPanel();
        }

        private void itemsToBeAdded_GV_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) // Ensure it's not the header row/column
            {
                search_txt.Text = "";
                search_txt.Focus();
            }
        }
    }
}
