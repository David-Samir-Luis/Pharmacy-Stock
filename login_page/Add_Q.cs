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
    public partial class Add_Q : UserControl
    {
        List<Medicine> itemsToBeAdded_ls = new();
        public Add_Q()
        {
            InitializeComponent();
        }

        private void searchBy_Combo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void search_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                search_btn_Click(sender, e);
            }
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            List<Medicine> item;

                switch (searchBy_Combo?.SelectedItem?.ToString())
                {
                    case "Name":
                        item = DbServices.Instance.GetData<Medicine>().Where(m => m.Name.ToLower() == search_txt.Text.ToLower()).ToList();
                        break;
                    case "barcode":
                        ///to do search by barcode 
                        item = DbServices.Instance.GetData<Medicine>().Where(m => m.Barcode == search_txt.Text).ToList();
                        break;
                    case "Code":
                        ///to do search by code 
                        item = DbServices.Instance.GetData<Medicine>().Where(c => c.Code == search_txt.Text).ToList();
                        break;
                    default:
                        item = null;
                        break;
                }

                if (item.Any())
                {
                    itemsToBeAdded_ls.Add(item.First());
                }
                else
                {
                    MessageBox.Show("NO such item!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            itemsToBeAdded_GV.DataSource = null;
            itemsToBeAdded_GV.DataSource = itemsToBeAdded_ls;
            //MessageBox.Show(itemsToBeAdded_ls.Count.ToString());
        }
    }
}
