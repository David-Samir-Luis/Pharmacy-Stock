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
    public partial class AddNewDrugs_Form : Form
    {
        public AddNewDrugs_Form()
        {
            InitializeComponent();
        }

        private void Add_New_Drugs_Load(object sender, EventArgs e)
        {
            searchBy_Combo.DataSource = new List<string> { "Code", "Name", "BarCode" };
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
            "You will lose your prograss?",   // Message text
            "Confirmation",               // Title
            MessageBoxButtons.YesNo,      // Buttons: Yes & No
            MessageBoxIcon.Question       // Icon: Question Mark
            );

            if (result == DialogResult.Yes)
            {
                this.Hide();
                main_Form main_Form = new();
                main_Form.ShowDialog();
                this.Close();
            }
            else
            {
                // Do Nothing
            }
        
            
        }
    }
}
