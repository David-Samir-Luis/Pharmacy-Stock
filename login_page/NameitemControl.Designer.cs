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
            SuspendLayout();
            // 
            // lbname
            // 
            lbname.AutoSize = true;
            lbname.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbname.Location = new Point(3, 9);
            lbname.Name = "lbname";
            lbname.Size = new Size(134, 23);
            lbname.TabIndex = 0;
            lbname.Text = "complete name";
            lbname.Click += label1_Click;
            lbname.DoubleClick += lbname_DoubleClick;
            lbname.MouseLeave += lbname_MouseLeave;
            lbname.MouseHover += lbname_MouseHover;
            // 
            // NameitemControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lbname);
            Margin = new Padding(0);
            Name = "NameitemControl";
            Size = new Size(275, 41);
            DoubleClick += NameitemControl_DoubleClick;
            MouseLeave += NameitemControl_MouseLeave;
            MouseHover += NameitemControl_MouseHover;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbname;
    }
}
