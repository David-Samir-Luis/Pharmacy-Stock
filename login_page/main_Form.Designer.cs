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
            pictureBox1 = new PictureBox();
            Low_Stocks_bt = new Button();
            History_bt = new Button();
            Drugs_bt = new Button();
            Remove_Qantity = new Button();
            Add_Quantity = new Button();
            add_q = new Add_Q();
            drugs_Control = new drugs_Control();
            history_control = new History();
            lowStock_user = new LowStock_usercontrol();
            remove_q = new Remove_Q();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(Low_Stocks_bt);
            panel2.Controls.Add(History_bt);
            panel2.Controls.Add(Drugs_bt);
            panel2.Controls.Add(Remove_Qantity);
            panel2.Controls.Add(Add_Quantity);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 35);
            panel2.Name = "panel2";
            panel2.Size = new Size(225, 720);
            panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.add_quantity;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(222, 204);
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // Low_Stocks_bt
            // 
            Low_Stocks_bt.BackColor = Color.FromArgb(33, 8, 97);
            Low_Stocks_bt.FlatAppearance.MouseDownBackColor = Color.FromArgb(75, 8, 138);
            Low_Stocks_bt.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 8, 138);
            Low_Stocks_bt.FlatStyle = FlatStyle.Flat;
            Low_Stocks_bt.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Low_Stocks_bt.ForeColor = Color.White;
            Low_Stocks_bt.Location = new Point(12, 504);
            Low_Stocks_bt.Name = "Low_Stocks_bt";
            Low_Stocks_bt.Size = new Size(200, 40);
            Low_Stocks_bt.TabIndex = 16;
            Low_Stocks_bt.Text = "Low Stocks";
            Low_Stocks_bt.UseVisualStyleBackColor = false;
            Low_Stocks_bt.Click += Low_Stocks_bt_Click;
            // 
            // History_bt
            // 
            History_bt.BackColor = Color.FromArgb(33, 8, 97);
            History_bt.FlatAppearance.MouseDownBackColor = Color.FromArgb(75, 8, 138);
            History_bt.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 8, 138);
            History_bt.FlatStyle = FlatStyle.Flat;
            History_bt.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            History_bt.ForeColor = Color.White;
            History_bt.Location = new Point(12, 435);
            History_bt.Name = "History_bt";
            History_bt.Size = new Size(200, 40);
            History_bt.TabIndex = 15;
            History_bt.Text = "History";
            History_bt.UseVisualStyleBackColor = false;
            History_bt.Click += History_bt_Click;
            // 
            // Drugs_bt
            // 
            Drugs_bt.BackColor = Color.FromArgb(33, 8, 97);
            Drugs_bt.FlatAppearance.MouseDownBackColor = Color.FromArgb(75, 8, 138);
            Drugs_bt.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 8, 138);
            Drugs_bt.FlatStyle = FlatStyle.Flat;
            Drugs_bt.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Drugs_bt.ForeColor = Color.White;
            Drugs_bt.Location = new Point(12, 368);
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
            Remove_Qantity.Click += Remove_Qantity_Click;
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
            // history_control
            // 
            history_control.Dock = DockStyle.Fill;
            history_control.Location = new Point(225, 35);
            history_control.Name = "history_control";
            history_control.Size = new Size(1087, 720);
            history_control.TabIndex = 4;
            // 
            // lowStock_user
            // 
            lowStock_user.Dock = DockStyle.Fill;
            lowStock_user.Location = new Point(225, 35);
            lowStock_user.Name = "lowStock_user";
            lowStock_user.Size = new Size(1087, 720);
            lowStock_user.TabIndex = 5;
            // 
            // remove_q
            // 
            remove_q.Dock = DockStyle.Fill;
            remove_q.Location = new Point(225, 35);
            remove_q.Name = "remove_q";
            remove_q.Size = new Size(1087, 720);
            remove_q.TabIndex = 6;
            // 
            // main_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1312, 755);
            Controls.Add(remove_q);
            Controls.Add(lowStock_user);
            Controls.Add(history_control);
            Controls.Add(drugs_Control);
            Controls.Add(add_q);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "main_Form";
            Text = "Pharmacy Stock";
            WindowState = FormWindowState.Maximized;
            Load += main_Form_Load;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button Add_Quantity;
        private Button Remove_Qantity;
        private Add_Q add_q;
        private Button Drugs_bt;
        private Button History_bt;
        private drugs_Control drugs_Control;
        private History history_control;
        private LowStock_usercontrol lowStock_user;
        private Button Low_Stocks_bt;
        private Remove_Q remove_q;
        private PictureBox pictureBox1;
    }
}