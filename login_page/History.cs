using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using login_page.Models;
namespace login_page
{
    public partial class History : UserControl
    {
        public History()
        {
            InitializeComponent();
        }

        private void History_Load(object sender, EventArgs e)
        {
            var source  = DbServices.Instance.GetData<OperationsHistory>().Select(s => new { OperationId = s.OperationId, OperationType = s.OperationType, OperationTime = s.OperationTime }).OrderByDescending(m=>m.OperationTime).ToList();

            dataGridView1.DataSource = source;
            
            if (source.Count!=0)
            {
                dataGridView1.ClearSelection(); // Clears any previous selection
                dataGridView1.Rows[0].Selected = true; // Selects the first row
            }
            dataGridView1.Focus();
            //dataGridView2.DataSource = DbServices.Instance.GetData<OperationsMedicine>().Where(o => o.OperationId == (int)dataGridView1.SelectedRows[0].Cells[0].Value).Select(o => new { /*Name = o.Medicine.Name,*/nn=o.MedicineId, Quantity = o.Quantity }).ToList();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 1)
            {
                // Keep only the first selected row
                for (int i = 1; i < dataGridView1.SelectedRows.Count; i++)
                {
                    dataGridView1.SelectedRows[i].Selected = false;
                }
            }
            if (dataGridView1?.SelectedRows?.Count > 0)  // Check if any row is selected
            {
                  dataGridView2.DataSource = DbServices.Instance.GetData<OperationsMedicine>()
                    .Where(o => o.OperationId == (int)dataGridView1.SelectedRows[0].Cells[0].Value)
                    .Select(o => new 
                    {
                        Name = DbServices.Instance.GetData<Medicine>().Find(o1=>o1.Id==o.MedicineId)?.Name??"NO Medicine",
                        Quantity = o.Quantity 
                    }).ToList();
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Refresh_btn_Click(object sender, EventArgs e)
        {
            History_Load(sender,e);
        }
    }
}
