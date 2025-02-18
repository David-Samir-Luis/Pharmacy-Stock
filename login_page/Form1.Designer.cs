namespace login_page
{
    partial class login_form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login_form));
            side_panel = new Panel();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            label4 = new Label();
            label1 = new Label();
            label2 = new Label();
            user_txt = new TextBox();
            pass_txt = new TextBox();
            label3 = new Label();
            checkBox = new CheckBox();
            login_bt = new Button();
            side_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // side_panel
            // 
            side_panel.BackColor = Color.FromArgb(75, 8, 138);
            side_panel.BorderStyle = BorderStyle.FixedSingle;
            side_panel.Controls.Add(pictureBox1);
            side_panel.Controls.Add(label5);
            side_panel.Controls.Add(label4);
            side_panel.Dock = DockStyle.Left;
            side_panel.Location = new Point(0, 0);
            side_panel.Name = "side_panel";
            side_panel.Size = new Size(478, 719);
            side_panel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(89, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(229, 227);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(140, 332);
            label5.Name = "label5";
            label5.Size = new Size(99, 36);
            label5.TabIndex = 1;
            label5.Text = "Stock";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(89, 278);
            label4.Name = "label4";
            label4.Size = new Size(237, 36);
            label4.TabIndex = 0;
            label4.Text = "Dr.Samy Farid ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(539, 75);
            label1.Name = "label1";
            label1.Size = new Size(301, 46);
            label1.TabIndex = 1;
            label1.Text = "Login Account";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(539, 203);
            label2.Name = "label2";
            label2.Size = new Size(128, 28);
            label2.TabIndex = 2;
            label2.Text = "Username :";
            // 
            // user_txt
            // 
            user_txt.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            user_txt.Location = new Point(539, 234);
            user_txt.Name = "user_txt";
            user_txt.Size = new Size(448, 35);
            user_txt.TabIndex = 3;
            user_txt.KeyDown += user_txt_KeyDown;
            // 
            // pass_txt
            // 
            pass_txt.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pass_txt.Location = new Point(539, 340);
            pass_txt.Name = "pass_txt";
            pass_txt.PasswordChar = '*';
            pass_txt.Size = new Size(448, 35);
            pass_txt.TabIndex = 5;
            pass_txt.KeyDown += pass_txt_KeyDown;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(539, 309);
            label3.Name = "label3";
            label3.Size = new Size(122, 28);
            label3.TabIndex = 4;
            label3.Text = "Password :";
            // 
            // checkBox
            // 
            checkBox.AutoSize = true;
            checkBox.Cursor = Cursors.Hand;
            checkBox.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox.Location = new Point(857, 381);
            checkBox.Name = "checkBox";
            checkBox.Size = new Size(130, 22);
            checkBox.TabIndex = 6;
            checkBox.Text = "Show Password";
            checkBox.UseVisualStyleBackColor = true;
            checkBox.CheckedChanged += checkBox_CheckedChanged;
            // 
            // login_bt
            // 
            login_bt.BackColor = Color.FromArgb(33, 11, 97);
            login_bt.Cursor = Cursors.Hand;
            login_bt.FlatAppearance.BorderSize = 0;
            login_bt.FlatAppearance.MouseDownBackColor = Color.FromArgb(75, 8, 138);
            login_bt.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 8, 138);
            login_bt.FlatStyle = FlatStyle.Flat;
            login_bt.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_bt.ForeColor = Color.White;
            login_bt.Location = new Point(539, 458);
            login_bt.Name = "login_bt";
            login_bt.Size = new Size(155, 45);
            login_bt.TabIndex = 7;
            login_bt.Text = "LOGIN";
            login_bt.UseVisualStyleBackColor = false;
            login_bt.Click += login_bt_Click;
            // 
            // login_form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1245, 719);
            Controls.Add(login_bt);
            Controls.Add(checkBox);
            Controls.Add(pass_txt);
            Controls.Add(label3);
            Controls.Add(user_txt);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(side_panel);
            Name = "login_form";
            Text = "Pharmacy Stock";
            WindowState = FormWindowState.Maximized;
            Load += login_form_Load;
            side_panel.ResumeLayout(false);
            side_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel side_panel;
        private Label label1;
        private Label label2;
        private TextBox user_txt;
        private TextBox pass_txt;
        private Label label3;
        private CheckBox checkBox;
        private Button login_bt;
        private Label label5;
        private Label label4;
        private PictureBox pictureBox1;
    }
}
