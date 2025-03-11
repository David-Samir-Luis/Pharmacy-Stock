using login_page.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login_page
{
    public partial class search_regex : Form
    {
        Action<string> callback_func;
        List<MedicineGV> itemsToBeAdded_ls = new();
        public search_regex(Action<string> call )
        {
            callback_func = call;
            InitializeComponent();
            searchBy_Combo.SelectedIndex = 0; // default is search by Name
            itemsToBeAdded_GV.DataSource = null;
            search_txt.Focus();
        }
        class MedicineGV
        {

            private string code;
            private string name;
            private int? price;
            public MedicineGV(string _code, string _name, int? _price)
            {
                code = _code;
                name = _name;
                price = _price;
            }


            public string Code { get => code; }
            public string Name { get => name; }
            public int? Price { get => price; }
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
                    itemsToBeAdded_ls = DbServices.Instance.GetData<Medicine>().Where(m => Regex.IsMatch(m.Name?.ToLower()?.Trim() ?? string.Empty, WildcardToRegex(searchText), RegexOptions.IgnoreCase)).Select(m => new MedicineGV(m.Code, m.Name, m.Price)).ToList();
                    break;
                case "Barcode":
                    ///to do search by barcode 
                    itemsToBeAdded_ls = DbServices.Instance.GetData<Medicine>().Where(m => Regex.IsMatch(m.Barcode?.ToLower()?.Trim() ?? string.Empty, WildcardToRegex(searchText), RegexOptions.IgnoreCase)).Select(m => new MedicineGV(m.Code, m.Name, m.Price)).ToList();

                    break;
                case "Code":
                    ///to do search by code 
                    itemsToBeAdded_ls = DbServices.Instance.GetData<Medicine>().Where(m => Regex.IsMatch(m.Code?.ToLower()?.Trim() ?? string.Empty, WildcardToRegex(searchText), RegexOptions.IgnoreCase)).Select(m => new MedicineGV(m.Code, m.Name, m.Price)).ToList();
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
        private void search_regex_Load(object sender, EventArgs e)
        {
            search_txt.Focus();
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
            itemsToBeAdded_GV.DataSource = null;
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
                callback_func?.Invoke(name);

            }
        }
    }

}
