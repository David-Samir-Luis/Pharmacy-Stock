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
    public partial class Edit_Drug : Form
    {
        string searchText;
        public Edit_Drug()
        {
            InitializeComponent();
            searchText = "";
        }


        private void Name_txt_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                Barcode_txt.Focus();
            }
        }

        private void Barcode_txt_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                Code_txt.Focus();
            }
        }

        private void Code_txt_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                Price_txt.Focus();
            }
        }

        private void Price_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                MinQuantity_txt.Focus();
            }
        }

        private void cancel_n_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to cancel changes ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }

        }
        public void LoadData()
        {
            List<Medicine> item = DbServices.Instance.GetData<Medicine>().Where(m => m.Name == searchText.Trim()).ToList();
            if (item.Count > 0)
            {
                Name_txt.Text = item[0].Name;
                Barcode_txt.Text = item[0].Barcode;
                Code_txt.Text = item[0].Code;
                //Price_txt.Text = item[0].Price.ToString();
                // Quantity_txt.Text = item[0].Quantity.ToString();
                //ExpiryDate_txt.Text = item[0].ExpiryDate.ToString();
                MinQuantity_txt.Text = item[0].MinimumQuantity.ToString();
            }
        }
        private void Edit_Drug_Load(object sender, EventArgs e)
        {
            LoadData();

        }

       
    }
}
