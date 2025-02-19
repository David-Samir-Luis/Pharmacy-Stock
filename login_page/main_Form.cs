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
    public partial class main_Form : Form
    {
        public main_Form()
        {
            InitializeComponent();
          
        }

        private void main_Form_Load(object sender, EventArgs e)
        {

        }

        private void added_qantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void lowStock_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LowStock_Form lowStock_Form = new();
            lowStock_Form.ShowDialog();
            this.Close();
        }

        private void history_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new();
            form2.ShowDialog();
            this.Close();
        }

        private void AddNewDrug_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddNewDrugs_Form addNewDrugs_Form = new();
            addNewDrugs_Form.ShowDialog();
            this.Close();
        }
    }
}