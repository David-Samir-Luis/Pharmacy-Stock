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

    public partial class NameitemControl : UserControl
    {
        public static bool doubleClicked = false;
        public static string selectedName;
        public NameitemControl()
        {
            InitializeComponent();
        }

        public void Details(Medicine m)
        {
            lbname.Text = m.Name;
        }

        private void NameitemControl_DoubleClick(object sender, EventArgs e)
        {
            doubleClicked = true;
            selectedName = lbname.Text;
        }

        private void NameitemControl_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.Silver;
        }

        private void NameitemControl_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void lbname_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.Silver;
        }

        private void lbname_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void lbname_DoubleClick(object sender, EventArgs e)
        {
            doubleClicked = true;
            selectedName = lbname.Text;
        }

        private void panel1_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.Silver;
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void panel1_DoubleClick(object sender, EventArgs e)
        {
            doubleClicked = true;
            selectedName = lbname.Text;
        }
    }
}
