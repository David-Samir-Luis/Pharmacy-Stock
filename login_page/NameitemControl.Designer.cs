namespace login_page
{
    partial class NameitemControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbname = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lbname
            // 
            lbname.AutoSize = true;
            lbname.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbname.Location = new Point(13, 9);
            lbname.Name = "lbname";
            lbname.Size = new Size(134, 23);
            lbname.TabIndex = 0;
            lbname.Text = "complete name";
            lbname.DoubleClick += lbname_DoubleClick;
            lbname.MouseLeave += lbname_MouseLeave;
            lbname.MouseHover += lbname_MouseHover;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(lbname);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(275, 41);
            panel1.TabIndex = 1;
            panel1.DoubleClick += panel1_DoubleClick;
            panel1.MouseLeave += panel1_MouseLeave;
            panel1.MouseHover += panel1_MouseHover;
            // 
            // NameitemControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Margin = new Padding(0);
            Name = "NameitemControl";
            Size = new Size(275, 41);
            DoubleClick += NameitemControl_DoubleClick;
            MouseLeave += NameitemControl_MouseLeave;
            MouseHover += NameitemControl_MouseHover;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lbname;
        private Panel panel1;
    }
}
