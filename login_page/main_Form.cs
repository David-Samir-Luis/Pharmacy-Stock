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
            remove_q.Visible = false;
            lowStock_user.Visible = false;
            drugs_Control.Visible = false;
            history_control.Visible = false;
            add_q.Visible = true;
        }

        private void Add_Quantity_Click(object sender, EventArgs e)
        {
            remove_q.Visible = false;
            lowStock_user.Visible = false;
            drugs_Control.Visible = false;
            history_control.Visible = false;
            add_q.Visible = true;
        }

        private void Drugs_bt_Click(object sender, EventArgs e)
        {
            remove_q.Visible = false;
            lowStock_user.Visible = false;
            add_q.Visible = false;
            history_control.Visible = false;
            drugs_Control.Visible = true;
        }



        private void History_bt_Click(object sender, EventArgs e)
        {
            remove_q.Visible = false;
            lowStock_user.Visible = false;
            drugs_Control.Visible = false;
            add_q.Visible = false;
            history_control.Visible = true;
        }

        private void Low_Stocks_bt_Click(object sender, EventArgs e)
        {
            remove_q.Visible = false;
            drugs_Control.Visible = false;
            add_q.Visible = false;
            history_control.Visible = false;
            lowStock_user.Visible = true;
        }

        private void Remove_Qantity_Click(object sender, EventArgs e)
        {
            drugs_Control.Visible = false;
            add_q.Visible = false;
            history_control.Visible = false;
            lowStock_user.Visible = false;
            remove_q.Visible = true;
        }
    }
}