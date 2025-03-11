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
            Drugs_bt = new Button();
            Remove_Qantity = new Button();
            Add_Quantity = new Button();
            AddNewDrug_btn = new Button();
            history_btn = new Button();
            lowStock_btn = new Button();
            add_q = new Add_Q();
            drugs_Control = new drugs_Control();
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
            panel2.Controls.Add(Drugs_bt);
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
            // Drugs_bt
            // 
            Drugs_bt.BackColor = Color.FromArgb(33, 8, 97);
            Drugs_bt.FlatAppearance.MouseDownBackColor = Color.FromArgb(75, 8, 138);
            Drugs_bt.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 8, 138);
            Drugs_bt.FlatStyle = FlatStyle.Flat;
            Drugs_bt.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Drugs_bt.ForeColor = Color.White;
            Drugs_bt.Location = new Point(12, 372);
            Drugs_bt.Name = "Drugs_bt";
            Drugs_bt.Size = new Size(200, 40);
            Drugs_bt.TabIndex = 14;
            Drugs_bt.Text = "Drugs";
            Drugs_bt.UseVisualStyleBackColor = false;
            Drugs_bt.Click += Drugs_bt_Click;
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
            Add_Quantity.Click += Add_Quantity_Click;
            // 
            // AddNewDrug_btn
            // 
            AddNewDrug_btn.Location = new Point(29, 522);
            AddNewDrug_btn.Name = "AddNewDrug_btn";
            AddNewDrug_btn.Size = new Size(191, 29);
            AddNewDrug_btn.TabIndex = 11;
            AddNewDrug_btn.Text = "Add New drugs ";
            AddNewDrug_btn.UseVisualStyleBackColor = true;
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
            // add_q
            // 
            add_q.Dock = DockStyle.Fill;
            add_q.Location = new Point(225, 35);
            add_q.Name = "add_q";
            add_q.Size = new Size(1087, 720);
            add_q.TabIndex = 2;
            // 
            // drugs_Control
            // 
            drugs_Control.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            drugs_Control.Location = new Point(222, 35);
            drugs_Control.Name = "drugs_Control";
            drugs_Control.Size = new Size(1087, 717);
            drugs_Control.TabIndex = 3;
            // 
            // main_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1312, 755);
            Controls.Add(drugs_Control);
            Controls.Add(add_q);
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
        private Button Drugs_bt;
        private Button Remove_Qantity;
        private Add_Q add_q;
        private drugs_Control drugs_Control;
    }
}