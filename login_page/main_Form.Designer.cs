namespace login_page
{
    partial class main_Form
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main_Form));
            panel1 = new Panel();
            panel2 = new Panel();
            label4 = new Label();
            quantity = new TextBox();
            label3 = new Label();
            added_qantity = new TextBox();
            label1 = new Label();
            label2 = new Label();
            price = new TextBox();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(33, 11, 97);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1312, 35);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(33, 11, 97);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(quantity);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(added_qantity);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(price);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 35);
            panel2.Name = "panel2";
            panel2.Size = new Size(478, 720);
            panel2.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 13.8F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(32, 259);
            label4.Name = "label4";
            label4.Size = new Size(112, 29);
            label4.TabIndex = 7;
            label4.Text = "Quantity :";
            // 
            // quantity
            // 
            quantity.BackColor = Color.DarkGray;
            quantity.Font = new Font("Microsoft Sans Serif", 13.8F);
            quantity.Location = new Point(219, 259);
            quantity.Name = "quantity";
            quantity.Size = new Size(146, 34);
            quantity.TabIndex = 6;
            quantity.Text = "a";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 13.8F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(32, 331);
            label3.Name = "label3";
            label3.Size = new Size(161, 29);
            label3.TabIndex = 5;
            label3.Text = "Add Quantity :";
            // 
            // added_qantity
            // 
            added_qantity.Font = new Font("Microsoft Sans Serif", 13.8F);
            added_qantity.Location = new Point(219, 331);
            added_qantity.Name = "added_qantity";
            added_qantity.Size = new Size(146, 34);
            added_qantity.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(143, 96);
            label1.Name = "label1";
            label1.Size = new Size(0, 41);
            label1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 13.8F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(32, 199);
            label2.Name = "label2";
            label2.Size = new Size(81, 29);
            label2.TabIndex = 2;
            label2.Text = "Price :";
            // 
            // price
            // 
            price.BackColor = Color.DarkGray;
            price.Font = new Font("Microsoft Sans Serif", 13.8F);
            price.Location = new Point(219, 199);
            price.Name = "price";
            price.Size = new Size(146, 34);
            price.TabIndex = 1;
            // 
            // main_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1312, 755);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "main_Form";
            Text = "Pharmacy Stock";
            WindowState = FormWindowState.Maximized;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label2;
        private TextBox price;
        private Label label1;
        private Label label4;
        private TextBox quantity;
        private Label label3;
        private TextBox added_qantity;
    }
}