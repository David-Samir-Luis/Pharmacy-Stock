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
            if (medicineData.Name != Name_txt.Text)
            {
                if(Name.IsNullOrEmpty())
                {
                    MessageBox.Show($"Please enter a Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Name_txt.Focus();
                    return;
                }

                if (DbServices.Instance.GetData<Medicine>().Where(m => m.Name == Name)?.Any() ?? false)
                {
                    MessageBox.Show($"This Name is already used ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Name_txt.Focus();
                    return;
                }

            }
            if (medicineData.Barcode != Barcode)
            {
                if (Barcode.IsNullOrEmpty())
                {
                    MessageBox.Show($"Please enter a Barcode", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Barcode_txt.Focus();
                    return;
                }
                var med = DbServices.Instance.GetData<Medicine>().Where(m => m.Barcode == Barcode).ToList();
                if (med.Count > 0)
                {
                    MessageBox.Show($"This Barcode is already used for {med.First().Name}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (medicineData.Code != Code)
            {
                if (Code.IsNullOrEmpty())
                {
                    MessageBox.Show($"Please enter a Code", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Code_txt.Focus();
                    return;
                }
                var med= DbServices.Instance.GetData<Medicine>().Where(m => m.Code == Code).ToList();
                if (med.Count>0)
                {
                    MessageBox.Show($"This Code is already used for {med.First().Name}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            int? Price ;
            if(Price_txt.Text=="")
            {
                Price = null;
            }
            else if (int.TryParse(Price_txt.Text, out int Price1) && Price1 >= 0)
            {
                Price = Price1;
            }
            else
            {
                MessageBox.Show($"Please enter a Valid Postive Integer number in \"Price\" Field!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            

            if (!int.TryParse(MinQuantity_txt.Text, out int MinQuantity) || MinQuantity < 0)
            {
                MessageBox.Show($"Please enter a Valid Postive Integer number in \"MinQuantity\" Field!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            /* Update local data  */
            medicineData.Name = Name_txt.Text;
            medicineData.Barcode = Barcode_txt.Text;
            medicineData.Code = Code_txt.Text;
            medicineData.Price = Price;
            medicineData.MinimumQuantity = MinQuantity;

            await UpdateMedicineUsingQueryAsync();
            this.Close();
        }
    }
}
