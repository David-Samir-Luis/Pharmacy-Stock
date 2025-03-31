using login_page.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;

namespace login_page
{
    public partial class Add_Q : UserControl
    {
        enum GVColumnsIndex
        {
            Code,
            Name,
            Stock,
            Price,
            InQuantity,
            ExpireDate
        }

        List<Medicine> itemNames;
        BindingList<MedicineGV> itemsToBeAdded_ls = new();
        public Add_Q()
        {
            InitializeComponent();           
            itemsToBeAdded_GV.DataSource = itemsToBeAdded_ls;
        }
        class MedicineGV
        {
            private Medicine medicine;
            public string Code { get => medicine.Code; }
            public string Name { get => medicine.Name; }
            public int Stock { get => medicine.Quantity; }
            public int? Price { get => medicine.Price; }
            public int InQuantity { get; set; }
            [DisplayName("Expire Date")] // display name in the DataGridView
            public string ExpireDate { get; set; }
            public MedicineGV(Medicine m, int q)
            {
                medicine = m;
                InQuantity = q;
            }
            public int GetID()
            {
                return medicine.Id;
            }
            public void UpdateQuantity()
            {
                medicine.Quantity += InQuantity;
            }
        }

        void ResetPanel()
        {
            search_txt.Text = "";
            itemsToBeAdded_ls.Clear(); // clear the list 
            search_txt.Focus();
        }
        private void searchBy_Combo_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (searchBy_Combo?.SelectedItem?.ToString() == "Name")
            {
                search_regex searchRegex = new(callbackBySearch_regex);
                searchRegex.ShowDialog();
                searchBy_Combo.SelectedIndex = 0; // default is search by Barcode
            }

            search_txt.Focus();
        }
        public void searchGeneral(string searchText)
        {
            List<Medicine> item;
            if (string.IsNullOrEmpty(searchText)) return;
            switch (searchBy_Combo?.SelectedItem?.ToString())
            {
                //case "Name":
                //    item = DbServices.Instance.GetData<Medicine>().Where(m => m.Name?.ToLower().Trim() == searchText).ToList();
                //    break;
                case "Barcode":
                    ///to do search by barcode 
                    item = DbServices.Instance.GetData<Medicine>().Where(m => m.Barcode?.ToLower().Trim() == searchText).ToList();
                    break;
                case "Code":
                    ///to do search by code 
                    item = DbServices.Instance.GetData<Medicine>().Where(c => c.Code?.ToLower().Trim() == searchText).ToList();
                    break;
                default:
                    item = null;
                    break;
            }

            if (item?.Any() ?? false)
            {
                itemsToBeAdded_ls.Add(new MedicineGV(item.First(), 1));
                itemsToBeAdded_GV.CurrentCell = itemsToBeAdded_GV.Rows[itemsToBeAdded_GV.Rows.Count - 1].Cells[(int)GVColumnsIndex.InQuantity];
                itemsToBeAdded_GV.BeginEdit(true);
            }
            else
            {
                search_txt.Focus();
                search_txt.SelectAll();
            }
        }
        private void search_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && searchBy_Combo?.SelectedItem?.ToString() != "Dynamic Name")
            {
                searchGeneral(search_txt.Text.ToLower().Trim());
            }
        }
        private void DeleteRow()
        {
            if (itemsToBeAdded_GV?.Rows?.Count == 0) return; // No rows to delete
            if (itemsToBeAdded_ls.Count == 1)
            {
                for (int i = 0; i < 10; i++) ; // wait for a while ,this avoids the error of deleting the first and only row
                itemsToBeAdded_ls.Clear();
                return; // No rows to delete
            }
            int rowIndex = -1;

            // Check if any cell is selected
            if (itemsToBeAdded_GV?.SelectedCells?.Count > 0)
            {
                rowIndex = itemsToBeAdded_GV.SelectedCells[0].RowIndex; // Get row index of selected cell
            }
            else if (itemsToBeAdded_GV?.SelectedRows?.Count > 0)
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
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.Delete))
            {
                DeleteRow();
            }
            if (keyData == Keys.Insert)
            {
                searchBy_Combo.SelectedIndex = 1;
            }
            if (keyData == Keys.F1)
            {
                searchBy_Combo.SelectedIndex = 2;
            }
            if (keyData == Keys.F2)
            {
                searchBy_Combo.SelectedIndex = 3;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }


        private void search_btn_Click(object sender, EventArgs e)
        {
            if (searchBy_Combo?.SelectedItem?.ToString() != "Dynamic Name")
            {
                searchGeneral(search_txt.Text.ToLower().Trim());
            }
        }

        private void Add_Q_Load(object sender, EventArgs e)
        {
            searchBy_Combo.SelectedIndex = 0; // default is search by Barcode
            search_txt.Focus();
            resultContainer.BringToFront();
            // CenterButton();
        }
        //private void CenterButton()
        //{
        //    int x = (itemsToBeAdded_GV.Width - save_n.Width) / 3;
        //    save_n.Location = new Point(x, save_n.Location.Y);
        //    cancel_n.Location = new Point(2 * x, cancel_n.Location.Y);
        //}

        private async Task UpdateQuantityAsync()
        {
            using (var db = new PharmacyStoreContext())
            {
                foreach (var item in itemsToBeAdded_ls)
                {
                    await db.Medicines
                        .Where(m => m.Code == item.Code)
                        .ExecuteUpdateAsync(setters =>
                        setters.SetProperty(m => m.Quantity, item.Stock));
                }
            }
        }
        private async Task AddNewRowInOperationHistoryAsync()
        {
            using (var db = new PharmacyStoreContext())
            {
                db.OperationsHistories.Add(new OperationsHistory
                {
                    OperationTime = DateTime.Now,
                    OperationType = "Stock In",
                    OperationsMedicines = itemsToBeAdded_ls.Select(m => new OperationsMedicine
                    {
                        MedicineId = m.GetID(),
                        Quantity = (short)m.InQuantity
                    }).ToList()
                });
                await db.SaveChangesAsync();
            }
        }
        private async Task AddNewRowInDrugDateStockAsync()
        {
            //TODO: parse the date and add it to the database as Dateonly
            using (var db = new PharmacyStoreContext())
            {
                foreach (var item in itemsToBeAdded_ls)
                {
                    DateOnly ExpireDate;                
                    if (!DateOnly.TryParseExact($"01/{item.ExpireDate}", "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out ExpireDate))
                    {
                        MessageBox.Show("Invalid date", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    
                    var drugDateStock=DbServices.Instance.GetData<DrugDateStock>().Find(m => (m.MedicineId == item.GetID() && (m.ExpireDate == ExpireDate)));
                    
                    if (drugDateStock is not null) // if the record already exists
                    {
                       drugDateStock.Quantity += item.InQuantity;
                    }
                    else
                    {
                        db.DrugDateStocks.Add(new DrugDateStock
                        {
                            MedicineId = item.GetID(),
                            Quantity = item.InQuantity,
                            ExpireDate = ExpireDate
                        });
                    }
                    
                }
               
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

                await UpdateQuantityAsync(); // save changes to database table medicines
                await AddNewRowInOperationHistoryAsync(); // save changes to database tables operationsHistories and operationsMedicines
                await DbServices.Instance.LoadDataAsync<OperationsHistory>(); // reload OperationsHistory data 
                await DbServices.Instance.LoadDataAsync<OperationsMedicine>(); // reload OperationsMedicine data
                ResetPanel();
            }
            //else
            //{
            //    MessageBox.Show("NO items to be saved.", "Can't save", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
        }

        private void cancel_n_Click(object sender, EventArgs e)
        {
            //DateOnly ExpireDate ;
            //DateOnly.TryParseExact($"01/{itemsToBeAdded_ls[0].ExpireDate}", "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out ExpireDate);
            //MessageBox.Show($"{ExpireDate}");
            DialogResult result = MessageBox.Show("Are you sure you want to cancel changes ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                ResetPanel();
            }
        }

        private void itemsToBeAdded_GV_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) // Ensure it's not the header row/column
            {
                if (e.ColumnIndex == (int)GVColumnsIndex.InQuantity)
                {
                    // move the focus to the next cell (date cell)
                    itemsToBeAdded_GV.CurrentCell = itemsToBeAdded_GV.Rows[e.RowIndex].Cells[(int)GVColumnsIndex.ExpireDate];
                    itemsToBeAdded_GV.BeginEdit(true);
                }
                else if (e.ColumnIndex == (int)GVColumnsIndex.ExpireDate)
                {
                    search_txt.Focus();
                    search_txt.SelectAll();
                }
            }
        }
        private void SearchByname(string name)
        {
            // itemNames = DbServices.Instance.GetData<Medicine>().Where(m =>(bool) m.Name?.ToLower().Trim().StartsWith(name)).ToList();
            itemNames = DbServices.Instance.GetData<Medicine>().Where(m => Regex.IsMatch(m.Name, WildcardToRegex(name), RegexOptions.IgnoreCase)).ToList();

        }
        private void LoadDetails()
        {
            NameitemControl.callback_func = callbackBySearch_NameitemControl;
            foreach (var item in itemNames)
            {
                NameitemControl name = new();
                name.Details(item);
                resultContainer.Controls.Add(name);
            }
        }

        private void callbackBySearch_NameitemControl(string name)
        {
            callbackBySearch_regex(name);
            search_txt.Text = "";
            resultContainer.Height = 0;

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
            if (searchBy_Combo?.SelectedItem?.ToString() == "Dynamic Name" && search_txt.TextLength >= 1)
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


        private void itemsToBeAdded_GV_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            // Check if the column should allow only numbers (optional)
            if (itemsToBeAdded_GV.CurrentCell.ColumnIndex==(int)GVColumnsIndex.InQuantity) // column index of InQuantity
            {
                if (!string.IsNullOrWhiteSpace(e.FormattedValue?.ToString()))
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

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (itemsToBeAdded_GV.SelectedCells.Count > 0)
            //{
            //    string searchedName = itemsToBeAdded_GV.SelectedCells[0].OwningRow.Cells["Name"].Value?.ToString() ?? "NA";
            //    Edit_Drug editDrug = new(searchedName);
            //    editDrug.ShowDialog();

            //}
            if (itemsToBeAdded_GV.SelectedRows.Count > 0)
            {
                string searchedName = itemsToBeAdded_GV.SelectedRows[0].Cells["Name"].Value?.ToString() ?? "NA";
                Edit_Drug editDrug = new(searchedName);
                editDrug.ShowDialog();
            }


        }
        public void callbackBySearch_regex(string name)
        {
            Medicine item;
            item = DbServices.Instance.GetData<Medicine>().Where(m => m.Name == name.Trim()).First();
            itemsToBeAdded_ls.Add(new MedicineGV(item, 1));
            itemsToBeAdded_GV.CurrentCell = itemsToBeAdded_GV.Rows[itemsToBeAdded_GV.Rows.Count - 1].Cells[(int)GVColumnsIndex.InQuantity];
            itemsToBeAdded_GV.BeginEdit(true);
        }

        private void Add_Q_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                search_txt.Focus(); // Focus the TextBox when the UserControl becomes visible
            }
        }

        private void itemsToBeAdded_GV_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (e.Control is TextBox textBox)
            {
                if (itemsToBeAdded_GV.CurrentCell.ColumnIndex == (int)GVColumnsIndex.ExpireDate )
                {
                    textBox.KeyPress -= TextBox_KeyPress;
                    textBox.Leave -= TextBox_Leave;

                    textBox.KeyPress += TextBox_KeyPress;
                    textBox.Leave += TextBox_Leave;
                    textBox.Name = "ExpireDate";
                }
                else
                {
                    textBox.Name = "InQuantity";
                }
                // Remove old event handlers to avoid duplicates
                textBox.KeyDown -= TextBox_KeyDown;
                    textBox.KeyDown += TextBox_KeyDown;
            }
        }

        private void TextBox_Leave(object? sender, EventArgs e)
        {
            TextBox? textBox = sender as TextBox;
            if (textBox is not null && textBox.Name== "ExpireDate")
            {
                if (textBox?.Text?.Length > 0 && textBox?.Text?.Length < 3)
                {
                    MessageBox.Show("Please enter a valid date. (725) or (0725) ", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (textBox?.Text?.Length == 3) // if the user entered 3 digits (example 125 => 1/25 )
                {
                    textBox.Text = $"0{textBox?.Text?.Substring(0, 1)}/20{textBox?.Text?.Substring(1, 2)}";
                }
                else if (textBox?.Text?.Length == 4) // if the user entered 4 digits (example 1125 => 11/25 )
                {
                    textBox.Text = $"{textBox?.Text?.Substring(0, 2)}/20{textBox?.Text?.Substring(2, 2)}";
                }
                else
                {
                    textBox.Text = "01/0001";
                } 
            }
        }

        private void TextBox_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Delete)
            {
                e.SuppressKeyPress = true; // Prevents deletion in edit mode
            }
        }
        private void expirationDatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Expiration_dates expiration = new();
            expiration.ShowDialog();
        }

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox? textBox = sender as TextBox;

            // the column should allow only numbers ,and any character except numbers should be blocked (ignored)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Block non-numeric input
                return;
            }

            int? pos = textBox?.SelectionStart;

            if (char.IsDigit(e.KeyChar))
            {
                // allow only 4 characters maximum , 1 or 2 digits for the month and 2 digits for the year
                if (textBox.Text.Length==4) e.Handled = true; // Prevent extra typing
            }
        }       
    }
}
