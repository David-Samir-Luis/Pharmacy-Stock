using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using login_page.Models;
namespace login_page
{
    public partial class Form2 : Form
    {
        PharmacyStoreContext db = new PharmacyStoreContext();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.OperationsHistories.Select(s => new { OperationId = s.OperationId, OperationType = s.OperationType, OperationTime=s.OperationTime }).ToList();

            dataGridView1.ClearSelection(); // Clears any previous selection
            dataGridView1.Rows[0].Selected = true; // Selects the first row

            dataGridView2.DataSource = db.OperationsMedicines.Where(o => o.OperationId == (int)dataGridView1.SelectedRows[0].Cells[0].Value).ToList();

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
            if (dataGridView1.SelectedRows.Count > 0)  // Check if any row is selected
            {
                dataGridView2.DataSource = db.OperationsMedicines.Where(o => o.OperationId == (int)dataGridView1.SelectedRows[0].Cells[0].Value).ToList();
            
            }

            }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
