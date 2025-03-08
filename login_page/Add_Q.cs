using login_page.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace login_page
{
    public partial class Add_Q : UserControl
    {

        List<Medicine> itemNames;
        BindingList<MedicineGV> itemsToBeAdded_ls = new();
        public Add_Q()
        {
            InitializeComponent();
            searchBy_Combo.SelectedIndex = 0; // default is search by Barcode
            StockOperationType.SelectedIndex = 0; // default is Stock Out 
            itemsToBeAdded_GV.DataSource = itemsToBeAdded_ls;
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

        void ResetPanel()
        {
            // Reset panel
            search_txt.Text = "";
            itemsToBeAdded_ls.Clear(); // clear the list 
            search_txt.Focus();
            // reset gridview 
            //itemsToBeAdded_GV.DataSource = null;
            //itemsToBeAdded_GV.DataSource = itemsToBeAdded_ls;
        }
        private void searchBy_Combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (searchBy_Combo?.SelectedItem?.ToString() == "Name")
            {
                timer1.Enabled = true;
            }
            else
            {
                timer1.Enabled = false;
            }
            search_txt.Focus();
        }
        public void searchGeneral(string searchText)
        {
            List<Medicine> item;
            ;
            switch (searchBy_Combo?.SelectedItem?.ToString())
            {
                case "Name":
                    item = DbServices.Instance.GetData<Medicine>().Where(m => m.Name?.ToLower().Trim() == searchText).ToList();
                    break;
                case "Barcode":
                    ///to do search by barcode 
                    item = DbServices.Instance.GetData<Medicine>().Where(m => m.Barcode?.ToLower().Trim() == searchText).ToList();
                    search_txt.Text = "";
                    break;
                case "Code":
                    ///to do search by code 
                    item = DbServices.Instance.GetData<Medicine>().Where(c => c.Code?.ToLower().Trim() == searchText).ToList();
                    break;
                default:
                    MessageBox.Show("Please select a valid search type!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    item = null;
                    break;
            }

            if (item?.Any() ?? false)
            {
                itemsToBeAdded_ls.Add(new MedicineGV(item.First(), 1));
                itemsToBeAdded_GV.CurrentCell = itemsToBeAdded_GV.Rows[itemsToBeAdded_GV.Rows.Count - 1].Cells[2];
                itemsToBeAdded_GV.BeginEdit(true);
            }
            else
            {
                MessageBox.Show($"NO drug with this {searchBy_Combo?.SelectedItem?.ToString()}!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                search_txt.Focus();
            }
        }
        private void search_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && searchBy_Combo?.SelectedItem?.ToString() != "Name")
            {
                searchGeneral(search_txt.Text.ToLower().Trim());
            }
        }
        private void DeleteRow()
        {
            if (itemsToBeAdded_GV.Rows.Count == 0) return; // No rows to delete
           // if (itemsToBeAdded_ls.Count == 0) return; // No rows to delete

            int rowIndex = -1;

            // Check if any cell is selected
            if (itemsToBeAdded_GV.SelectedCells.Count > 0)
            {
                rowIndex = itemsToBeAdded_GV.SelectedCells[0].RowIndex; // Get row index of selected cell
            }
            else if (itemsToBeAdded_GV.SelectedRows.Count > 0)
            {
                rowIndex = itemsToBeAdded_GV.SelectedRows[0].Index; // Get row index of selected row
            }
            else
            {
                rowIndex = itemsToBeAdded_GV.Rows.Count - 1; // No selection, delete last row
            }
            if (rowIndex >= 0 && rowIndex < itemsToBeAdded_GV.Rows.Count)
            {
                itemsToBeAdded_ls.RemoveAt(rowIndex); // Delete row
                itemsToBeAdded_GV.DataSource = null;
                itemsToBeAdded_GV.DataSource = itemsToBeAdded_ls;
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.Delete))
            {
                DeleteRow();
                //if (itemsToBeAdded_ls.Count >= 0)
                //{
                //    itemsToBeAdded_ls.RemoveAt(itemsToBeAdded_ls.Count - 1);
                //    itemsToBeAdded_GV.DataSource = null;
                //    itemsToBeAdded_GV.DataSource = itemsToBeAdded_ls;
                //}
            }
            if (keyData == Keys.Insert)
            {
                searchBy_Combo.SelectedIndex = 1;
            }
            if (keyData == Keys.F1)
            {
                searchBy_Combo.SelectedIndex = 2;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }


        private void search_btn_Click(object sender, EventArgs e)
        {
            if (searchBy_Combo?.SelectedItem?.ToString() != "Name")
            {
                searchGeneral(search_txt.Text.ToLower().Trim());
            }
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

        private async Task UpdateQuantityUsingQueryAsync()
        {
            using (var db = new PharmacyStoreContext()) // Replace with your actual DbContext
            {
                foreach (var item in itemsToBeAdded_ls)
                {
                    await db.Medicines
                        .Where(m => m.Code ==item.Code)
                        .ExecuteUpdateAsync(setters =>
                        setters.SetProperty(m => m.Quantity, item.Stock));
                }
            }
        }
        private async Task AddNewRowInOperationHistoryAsync()
        {
            using (var db = new PharmacyStoreContext()) // Replace with your actual DbContext
            {
                db.OperationsHistories.Add(new OperationsHistory
                {
                    OperationTime = DateTime.Now,
                    OperationType = StockOperationType?.SelectedItem?.ToString()?? "Stock Out",
                    //OperationDetails = "Add Quantity to Medicine",
                    OperationsMedicines = itemsToBeAdded_ls.Select(m => new OperationsMedicine
                    {
                        MedicineCode = m.Code,
                        Quantity = (short)m.QuantityToAdd
                    }).ToList()
                });
                await db.SaveChangesAsync();
            }
        }
        private async void save_n_Click(object sender, EventArgs e)
        {
            if (!itemsToBeAdded_ls.IsNullOrEmpty())
            {
           
                foreach (var item in itemsToBeAdded_ls)
                {
                    item.UpdateQuantity();
                }

                MessageBox.Show("Changes saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                await UpdateQuantityUsingQueryAsync(); // save changes to database table medicines
                await AddNewRowInOperationHistoryAsync(); // save changes to database tables operationsHistories and operationsMedicines
                await DbServices.Instance.LoadAllDataAsync(); // reload data
                ResetPanel();
            }
            else
            {
                MessageBox.Show("NO items to be saved.", "Can't save", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
        private void SearchByname(string name)
        {
            // itemNames = DbServices.Instance.GetData<Medicine>().Where(m =>(bool) m.Name?.ToLower().Trim().StartsWith(name)).ToList();
            itemNames = DbServices.Instance.GetData<Medicine>().Where(m => Regex.IsMatch(m.Name?.ToLower()?.Trim(), WildcardToRegex(name), RegexOptions.IgnoreCase)).ToList();

        }
        private void LoadDetails()
        {
            foreach (var item in itemNames)
            {
                NameitemControl name = new();
                name.Details(item);
                resultContainer.Controls.Add(name);
            }
        }
        // Converts `*` -> `.*` and `?` -> `.` for regex matching
        static string WildcardToRegex(string pattern)
        {
            return "^" + Regex.Escape(pattern)
                .Replace(@"\*", ".*")  // `*` matches any number of characters
                .Replace(@"\?", ".");   // `?` matches exactly one character

        }
        private void search_txt_TextChanged(object sender, EventArgs e)
        {
            if (searchBy_Combo?.SelectedItem?.ToString() == "Name" && search_txt.TextLength >= 1)
            {
                resultContainer.Controls.Clear();
                try
                {
                    SearchByname(search_txt.Text.ToLower().Trim());

                }
                catch (Exception)
                {
                    MessageBox.Show("Invalid regular expression : ", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                LoadDetails();
                resultContainer.Height = resultContainer.Controls.Count * 41;
            }
            else
            {
                resultContainer.Height = 0;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (NameitemControl.doubleClicked == true)
            {
                searchGeneral(NameitemControl.selectedName.ToLower().Trim());
                NameitemControl.doubleClicked = false;
                search_txt.Text = "";
                resultContainer.Height = 0;
            }
        }


        private void itemsToBeAdded_GV_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            // Check if the column should allow only numbers (optional)
            if (itemsToBeAdded_GV.Columns[e.ColumnIndex].Name == "QuantityToAdd")
            {
                if (!string.IsNullOrWhiteSpace(e.FormattedValue.ToString()))
                {
                    if (!int.TryParse(e.FormattedValue.ToString(), out int number) || number < 0)
                    {
                        MessageBox.Show("Please enter a positive number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        e.Cancel = true; // Cancel the entry and keep focus on the cell
                    }
                }
            }
        }
        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DeleteRow();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (itemsToBeAdded_GV.SelectedCells.Count > 0)
            {
                string searchedName = itemsToBeAdded_GV.SelectedCells[0].OwningRow.Cells["Name"].Value?.ToString() ?? "";
                Edit_Drug editDrug = new(searchedName);
                editDrug.ShowDialog();
            }

        }
    }
}
