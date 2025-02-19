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
            panel1 = new Panel();
            panel2 = new Panel();
            Add_Quantity = new Button();
            AddNewDrug_btn = new Button();
            history_btn = new Button();
            lowStock_btn = new Button();
            Remove_Qantity = new Button();
            Add_New_Drug = new Button();
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
            panel2.Controls.Add(Add_New_Drug);
            panel2.Controls.Add(Remove_Qantity);
            panel2.Controls.Add(Add_Quantity);
            panel2.Controls.Add(AddNewDrug_btn);
            panel2.Controls.Add(history_btn);
            panel2.Controls.Add(lowStock_btn);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 35);
            panel2.Name = "panel2";
            panel2.Size = new Size(225, 720);
            panel2.TabIndex = 1;
            // 
            // Add_Quantity
            // 
            Add_Quantity.BackColor = Color.FromArgb(33, 8, 97);
            Add_Quantity.FlatAppearance.MouseDownBackColor = Color.FromArgb(75, 8, 138);
            Add_Quantity.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 8, 138);
            Add_Quantity.FlatStyle = FlatStyle.Flat;
            Add_Quantity.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Add_Quantity.ForeColor = Color.White;
            Add_Quantity.Location = new Point(12, 233);
            Add_Quantity.Name = "Add_Quantity";
            Add_Quantity.Size = new Size(200, 40);
            Add_Quantity.TabIndex = 12;
            Add_Quantity.Text = "Add Quantity";
            Add_Quantity.UseVisualStyleBackColor = false;
            // 
            // AddNewDrug_btn
            // 
            AddNewDrug_btn.Location = new Point(29, 522);
            AddNewDrug_btn.Name = "AddNewDrug_btn";
            AddNewDrug_btn.Size = new Size(191, 29);
            AddNewDrug_btn.TabIndex = 11;
            AddNewDrug_btn.Text = "Add New drugs ";
            AddNewDrug_btn.UseVisualStyleBackColor = true;
            AddNewDrug_btn.Click += AddNewDrug_btn_Click;
            // 
            // history_btn
            // 
            history_btn.Location = new Point(29, 634);
            history_btn.Name = "history_btn";
            history_btn.Size = new Size(134, 29);
            history_btn.TabIndex = 10;
            history_btn.Text = "IN/OUT History ";
            history_btn.UseVisualStyleBackColor = true;
            history_btn.Click += history_btn_Click;
            // 
            // lowStock_btn
            // 
            lowStock_btn.Location = new Point(29, 568);
            lowStock_btn.Name = "lowStock_btn";
            lowStock_btn.Size = new Size(137, 29);
            lowStock_btn.TabIndex = 9;
            lowStock_btn.Text = "Low Stock Drugs";
            lowStock_btn.UseVisualStyleBackColor = true;
            lowStock_btn.Click += lowStock_btn_Click;
            // 
            // Remove_Qantity
            // 
            Remove_Qantity.BackColor = Color.FromArgb(33, 8, 97);
            Remove_Qantity.FlatAppearance.MouseDownBackColor = Color.FromArgb(75, 8, 138);
            Remove_Qantity.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 8, 138);
            Remove_Qantity.FlatStyle = FlatStyle.Flat;
            Remove_Qantity.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Remove_Qantity.ForeColor = Color.White;
            Remove_Qantity.Location = new Point(12, 301);
            Remove_Qantity.Name = "Remove_Qantity";
            Remove_Qantity.Size = new Size(200, 40);
            Remove_Qantity.TabIndex = 13;
            Remove_Qantity.Text = "Remove Quantity";
            Remove_Qantity.UseVisualStyleBackColor = false;
            // 
            // Add_New_Drug
            // 
            Add_New_Drug.BackColor = Color.FromArgb(33, 8, 97);
            Add_New_Drug.FlatAppearance.MouseDownBackColor = Color.FromArgb(75, 8, 138);
            Add_New_Drug.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 8, 138);
            Add_New_Drug.FlatStyle = FlatStyle.Flat;
            Add_New_Drug.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Add_New_Drug.ForeColor = Color.White;
            Add_New_Drug.Location = new Point(12, 372);
            Add_New_Drug.Name = "Add_New_Drug";
            Add_New_Drug.Size = new Size(200, 40);
            Add_New_Drug.TabIndex = 14;
            Add_New_Drug.Text = "Add New Drug";
            Add_New_Drug.UseVisualStyleBackColor = false;
            // 
            // main_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1312, 755);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "main_Form";
            Text = "Pharmacy Stock";
            WindowState = FormWindowState.Maximized;
            Load += main_Form_Load;
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button lowStock_btn;
        private Button history_btn;
        private Button AddNewDrug_btn;
        private Button Add_Quantity;
        private Button Add_New_Drug;
        private Button Remove_Qantity;
    }
}