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
        public Add_Q()
        {
            InitializeComponent();
        }

        private void searchBy_Combo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Add_Q_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                switch(searchBy_Combo?.SelectedItem?.ToString())
                {
                    case "barcode":
                        ///to do search by barcode 
                        //var item = DbServices.Instance.GetData<Medicine>().Where(barcode => barcode.Code==
                        break;

                    case "Code":
                        ///to do search by code 
                        var item = DbServices.Instance.GetData<Medicine>().Where(c => c.Code ==search_txt.Text)
                            .Select(n => new
                            {
                                Code = n.Code,
                                Name = n.Name,
                                Quantity = n.Quantity,
                                MinimumQuantity = n.MinimumQuantity
                            }).ToList();
                        break;
                }
            }
        }
    }
}
