using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using login_page.Models;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace login_page
{
    public partial class drugs_Control : UserControl
    {
        List<MedicineGV> itemsToBeAdded_ls = new();
        public drugs_Control()
        {
            InitializeComponent();
            searchBy_Combo.SelectedIndex = 0; // default is search by Name
            itemsToBeAdded_GV.DataSource = itemsToBeAdded_ls;
        }
        class MedicineGV
        {
            private Medicine medicine;
            List<DrugDateStock> drugDateStock;
            //private string code;
            //private string name;
            //private int? price;
            public MedicineGV(Medicine medicine)
            {
                this.medicine = medicine;
                drugDateStock = DbServices.Instance.GetData<DrugDateStock>().Where(d => d.MedicineId == medicine.Id).ToList();
                //code = _code;
                //name = _name;
                //price = _price;
            }

            
            public string Code { get => medicine.Code; }
            public string Name { get => medicine.Name; }
            public List<DateOnly> ExpireDate { get => drugDateStock.Select(m=>m.ExpireDate).ToList(); }

            public int Stock { get => medicine.Quantity; }
            public int? Price { get => medicine.Price; }
        }
        // Converts `*` -> `.*` and `?` -> `.` for regex matching
        static string WildcardToRegex(string pattern)
        {
            return "^" + Regex.Escape(pattern)
                .Replace(@"\*", ".*")  // `*` matches any number of characters
                .Replace(@"\?", ".");   // `?` matches exactly one character

        }

        public void searchGeneral(string searchText)
        {
            if (search_txt.TextLength < 1) return;

            switch (searchBy_Combo?.SelectedItem?.ToString())
            {
                case "Name":
                    itemsToBeAdded_ls = DbServices.Instance.GetData<Medicine>().Where(m => Regex.IsMatch(m.Name?.ToLower()?.Trim() ?? string.Empty, WildcardToRegex(searchText), RegexOptions.IgnoreCase)).Select(m => new MedicineGV(m)).ToList();
                    break;
                case "Barcode":
                    ///to do search by barcode 
                    itemsToBeAdded_ls = DbServices.Instance.GetData<Medicine>().Where(m => Regex.IsMatch(m.Barcode?.ToLower()?.Trim() ?? string.Empty, WildcardToRegex(searchText), RegexOptions.IgnoreCase)).Select(m => new MedicineGV(m)).ToList();

                    break;
                case "Code":
                    ///to do search by code 
                    itemsToBeAdded_ls = DbServices.Instance.GetData<Medicine>().Where(m => Regex.IsMatch(m.Code?.ToLower()?.Trim() ?? string.Empty, WildcardToRegex(searchText), RegexOptions.IgnoreCase)).Select(m => new MedicineGV(m)).ToList();
                    break;
                default:
                    MessageBox.Show("Please select a valid search type!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    itemsToBeAdded_GV.DataSource = null;
                    break;
            }
            itemsToBeAdded_GV.DataSource = null;
            itemsToBeAdded_GV.DataSource = itemsToBeAdded_ls;
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            searchGeneral(search_txt.Text.ToLower().Trim());
        }

        private void search_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                searchGeneral(search_txt.Text.ToLower().Trim());
            }

        }

        private void searchBy_Combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            search_txt.Text = "";
            search_txt.Focus();
        }

        private void itemsToBeAdded_GV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure the row index is valid (not a header row)
            if (e.RowIndex >= 0)
            {
                // Get the selected row
                string name = itemsToBeAdded_GV.Rows[e.RowIndex].Cells[1].Value?.ToString();


            }
        }

        private void drugs_Control_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                search_txt.Focus(); // Focus the TextBox when the UserControl becomes visible
            }
        }

        private void Add_bt_Click(object sender, EventArgs e)
        {
            Add_Drug addDrug = new Add_Drug();
            addDrug.ShowDialog();
        }

        private void Delete_bt_Click(object sender, EventArgs e)
        {
            if (itemsToBeAdded_GV.SelectedRows.Count > 0)
            {
                string selected_Name = itemsToBeAdded_GV.SelectedRows[0].Cells["Name"].Value?.ToString() ?? "NA";
                ///todo delete the drug in the selected row 
            }

        }

        private void Edit_bt_Click(object sender, EventArgs e)
        {
            if (itemsToBeAdded_GV.SelectedRows.Count > 0)
            {
                string searchedName = itemsToBeAdded_GV.SelectedRows[0].Cells["Name"].Value?.ToString() ?? "NA";
                Edit_Drug editDrug = new(searchedName);
                editDrug.ShowDialog();
            }
        }

        
    }
}
