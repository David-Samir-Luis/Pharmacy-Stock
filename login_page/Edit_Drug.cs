using login_page.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
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
        Medicine medicineData;
        public Edit_Drug()
        {
            InitializeComponent();
            searchText = "";
        }
        public Edit_Drug(string searchTxt)
        {
            InitializeComponent();
            searchText = searchTxt;
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
            medicineData = DbServices.Instance.GetData<Medicine>().Where(m => m.Name == searchText.Trim()).First();
            if (medicineData is not null)
            {
                Name_txt.Text = medicineData.Name;
                Barcode_txt.Text = medicineData.Barcode;
                Code_txt.Text = medicineData.Code;
                Price_txt.Text = medicineData.Price.ToString();
                // Quantity_txt.Text = item[0].Quantity.ToString();
                //ExpiryDate_txt.Text = item[0].ExpiryDate.ToString();
                MinQuantity_txt.Text = medicineData.MinimumQuantity.ToString();
            }
        }
        private void Edit_Drug_Load(object sender, EventArgs e)
        {
            LoadData();

        }

        private void MinQuantity_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                save_n.Focus();
            }
        }

        private async Task UpdateMedicineUsingQueryAsync()
        {

            using (var db = new PharmacyStoreContext())
            {

                await db.Medicines
                    .Where(m => m.Id == medicineData.Id)
                    .ExecuteUpdateAsync(setters => setters
                    .SetProperty(m => m.Barcode, medicineData.Barcode)
                    .SetProperty(m => m.Name, medicineData.Name)
                    .SetProperty(m => m.MinimumQuantity, medicineData.MinimumQuantity)
                    .SetProperty(m => m.Price, medicineData.Price)
                    .SetProperty(m => m.Code, medicineData.Code)
                    );
            }
        }

        private async void save_n_Click(object sender, EventArgs e)
        {
            string Code = Code_txt.Text.Trim();
            string Barcode = Barcode_txt.Text.Trim();
            string Name = Name_txt.Text.Trim();
            string PriceTXT = Price_txt.Text.Trim();
            string MinQuantityTXT = MinQuantity_txt.Text.Trim();

            if (!Helper.AreMedicineInputsValid(Name, Code, Barcode, PriceTXT, MinQuantityTXT, out ErrorID errorID, medicineData))
            {
                switch (errorID)
                {
                    case ErrorID.Success:
                        break;
                    case ErrorID.Name:
                        Name_txt.Focus();
                        break;
                    case ErrorID.Code:
                        Code_txt.Focus();
                        break;
                    case ErrorID.Barcode:
                        Barcode_txt.Focus();
                        break;
                    case ErrorID.Price:
                        Price_txt.Focus();
                        break;
                    case ErrorID.MinQuantity:
                        MinQuantity_txt.Focus();
                        break;
                }
                return;
            }
            /* Update local data  */
            medicineData.Name = Name_txt.Text;
            medicineData.Barcode = Barcode_txt.Text;
            medicineData.Code = Code_txt.Text;
            medicineData.Price = string.IsNullOrEmpty(PriceTXT)?null:int.Parse(PriceTXT);
            medicineData.MinimumQuantity = string.IsNullOrEmpty(MinQuantityTXT) ?null: int.Parse(MinQuantityTXT);

            await UpdateMedicineUsingQueryAsync();
            this.Close();
        }
    }
}