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
    public partial class Add_Drug : Form
    {

        Medicine medicineData;
        public Add_Drug()
        {
            InitializeComponent();

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

        private void Add_Drug_Load(object sender, EventArgs e)
        {


        }

        private void MinQuantity_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                save_n.Focus();
            }
        }

        //private async Task UpdateMedicineUsingQueryAsync()
        //{

        //    using (var db = new PharmacyStoreContext()) 
        //    {

        //        await db.Medicines
        //            .Where(m => m.Id == medicineData.Id)
        //            .ExecuteUpdateAsync(setters => setters
        //            .SetProperty(m => m.Barcode, medicineData.Barcode)
        //            .SetProperty(m => m.Name, medicineData.Name)
        //            .SetProperty(m => m.MinimumQuantity, medicineData.MinimumQuantity)
        //            .SetProperty(m => m.Price, medicineData.Price)
        //            .SetProperty(m => m.Code, medicineData.Code)
        //            );
        //    }
        //}

        private async void save_n_Click(object sender, EventArgs e)
        {
            ///todo save the new drug to the database
            string Code = Code_txt.Text.ToLower().Trim();
            string Barcode = Barcode_txt.Text.ToLower().Trim();
            string Name = Name_txt.Text.ToLower().Trim();
            string PriceTXT = Price_txt.Text.Trim();
            string MinQuantityTXT = MinQuantity_txt.Text.Trim();


            if (!Helper.AreMedicineInputsValid(Name, Code, Barcode, PriceTXT, MinQuantityTXT, out ErrorID errorID))
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

            Medicine medicine = new Medicine
            {
                Name = Name,
                Barcode = Barcode,
                Code = Code,
                Price = string.IsNullOrEmpty(PriceTXT) ? null:int.Parse(PriceTXT),
                MinimumQuantity = string.IsNullOrEmpty(MinQuantityTXT) ?null: int.Parse(MinQuantityTXT)
            };
            DbServices.Instance.GetData<Medicine>().Add(medicine); // Add the new medicine to the local data
            DbServices.Instance.AddData<Medicine>(medicine); // Add the new medicine to the database
            this.Close();
        }
    }
}
