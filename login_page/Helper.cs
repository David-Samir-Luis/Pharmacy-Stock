using login_page.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace login_page
{
    public enum ErrorID
    {
        Success,
        Name = 1,
        Code = 2,
        Barcode = 3,
        Price = 4,
        MinQuantity = 5
    }
    class Helper
    {
        public static bool AreMedicineInputsValid(string name, string code, string barcode,  string priceTxt, string minQuantityTxt, out ErrorID errorID, Medicine? existingMedicine = null)
        {
            if (existingMedicine is null || existingMedicine.Name != name)
            {
                if (string.IsNullOrEmpty(name))
                {
                    MessageBox.Show("Please enter a Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    errorID = ErrorID.Name;
                    return false;
                }

                if (DbServices.Instance.GetData<Medicine>().Any(m => m.Name == name))
                {
                    MessageBox.Show("This Name is already used", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    errorID = ErrorID.Name;
                    return false;
                }
            }

            if (existingMedicine is null || existingMedicine.Barcode != barcode)
            {
                if (string.IsNullOrEmpty(barcode))
                {
                    MessageBox.Show("Please enter a Barcode", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    errorID = ErrorID.Barcode;
                    return false;
                }

                var existingBarcode = DbServices.Instance.GetData<Medicine>().FirstOrDefault(m => m.Barcode == barcode);
                if (existingBarcode != null)
                {
                    MessageBox.Show($"This Barcode is already used for {existingBarcode.Name}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    errorID = ErrorID.Barcode;
                    return false;
                }
            }

            if (existingMedicine is null || existingMedicine.Code != code)
            {
                if (string.IsNullOrEmpty(code))
                {
                    MessageBox.Show("Please enter a Code", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    errorID = ErrorID.Code;
                    return false;
                }

                var existingCode = DbServices.Instance.GetData<Medicine>().FirstOrDefault(m => m.Code == code);
                if (existingCode != null)
                {
                    MessageBox.Show($"This Code is already used for {existingCode.Name}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    errorID = ErrorID.Code;
                    return false;
                }
            }

            if (!string.IsNullOrEmpty(priceTxt) && (!int.TryParse(priceTxt, out int price) || price < 0))
            {
                MessageBox.Show("Please enter a Valid Positive Integer number in \"Price\" Field!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorID = ErrorID.Price;
                return false;
            }

            if (!string.IsNullOrEmpty(minQuantityTxt) && (!int.TryParse(minQuantityTxt, out int minQuantity) || minQuantity < 0))
            {
                MessageBox.Show("Please enter a Valid Positive Integer number in \"MinQuantity\" Field!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorID = ErrorID.MinQuantity;
                return false;
            }
            errorID = ErrorID.Success;
            return true;
        }


    }
}
