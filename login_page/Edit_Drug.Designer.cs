namespace login_page
{
    partial class Edit_Drug
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
            lbName = new Label();
            Name_txt = new TextBox();
            Code_txt = new TextBox();
            lbCode = new Label();
            Barcode_txt = new TextBox();
            lbBarcode = new Label();
            Price_txt = new TextBox();
            lbPrice = new Label();
            cancel_n = new Button();
            save_n = new Button();
            MinQuantity_txt = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbName.Location = new Point(30, 47);
            lbName.Name = "lbName";
            lbName.Size = new Size(57, 23);
            lbName.TabIndex = 0;
            lbName.Text = "Name";
            // 
            // Name_txt
            // 
            Name_txt.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name_txt.Location = new Point(156, 44);
            Name_txt.Name = "Name_txt";
            Name_txt.Size = new Size(293, 30);
            Name_txt.TabIndex = 1;
            Name_txt.KeyDown += Name_txt_KeyDown;
            // 
            // Code_txt
            // 
            Code_txt.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Code_txt.Location = new Point(156, 149);
            Code_txt.Name = "Code_txt";
            Code_txt.Size = new Size(293, 30);
            Code_txt.TabIndex = 3;
            Code_txt.KeyDown += Code_txt_KeyDown;
            // 
            // lbCode
            // 
            lbCode.AutoSize = true;
            lbCode.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbCode.Location = new Point(30, 152);
            lbCode.Name = "lbCode";
            lbCode.Size = new Size(51, 23);
            lbCode.TabIndex = 2;
            lbCode.Text = "Code";
            // 
            // Barcode_txt
            // 
            Barcode_txt.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Barcode_txt.Location = new Point(156, 94);
            Barcode_txt.Name = "Barcode_txt";
            Barcode_txt.Size = new Size(293, 30);
            Barcode_txt.TabIndex = 5;
            Barcode_txt.KeyDown += Barcode_txt_KeyDown;
            // 
            // lbBarcode
            // 
            lbBarcode.AutoSize = true;
            lbBarcode.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbBarcode.Location = new Point(30, 97);
            lbBarcode.Name = "lbBarcode";
            lbBarcode.Size = new Size(75, 23);
            lbBarcode.TabIndex = 4;
            lbBarcode.Text = "Barcode";
            // 
            // Price_txt
            // 
            Price_txt.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Price_txt.Location = new Point(156, 207);
            Price_txt.Name = "Price_txt";
            Price_txt.Size = new Size(293, 30);
            Price_txt.TabIndex = 7;
            Price_txt.KeyDown += Price_txt_KeyDown;
            // 
            // lbPrice
            // 
            lbPrice.AutoSize = true;
            lbPrice.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbPrice.Location = new Point(30, 210);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new Size(49, 23);
            lbPrice.TabIndex = 6;
            lbPrice.Text = "Price";
            // 
            // cancel_n
            // 
            cancel_n.BackColor = Color.FromArgb(33, 8, 97);
            cancel_n.FlatAppearance.MouseDownBackColor = Color.FromArgb(75, 8, 138);
            cancel_n.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 8, 138);
            cancel_n.FlatStyle = FlatStyle.Flat;
            cancel_n.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cancel_n.ForeColor = Color.White;
            cancel_n.Location = new Point(482, 363);
            cancel_n.Name = "cancel_n";
            cancel_n.Size = new Size(203, 40);
            cancel_n.TabIndex = 16;
            cancel_n.Text = "Cancel";
            cancel_n.UseVisualStyleBackColor = false;
            cancel_n.Click += cancel_n_Click;
            // 
            // save_n
            // 
            save_n.BackColor = Color.FromArgb(33, 8, 97);
            save_n.FlatAppearance.MouseDownBackColor = Color.FromArgb(75, 8, 138);
            save_n.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 8, 138);
            save_n.FlatStyle = FlatStyle.Flat;
            save_n.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            save_n.ForeColor = Color.White;
            save_n.Location = new Point(81, 363);
            save_n.Name = "save_n";
            save_n.Size = new Size(200, 40);
            save_n.TabIndex = 15;
            save_n.Text = "Save";
            save_n.UseVisualStyleBackColor = false;
            // 
            // MinQuantity_txt
            // 
            MinQuantity_txt.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MinQuantity_txt.Location = new Point(156, 272);
            MinQuantity_txt.Name = "MinQuantity_txt";
            MinQuantity_txt.Size = new Size(293, 30);
            MinQuantity_txt.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(30, 275);
            label1.Name = "label1";
            label1.Size = new Size(111, 23);
            label1.TabIndex = 17;
            label1.Text = "MinQuantity";
            // 
            // Edit_Drug
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(MinQuantity_txt);
            Controls.Add(label1);
            Controls.Add(cancel_n);
            Controls.Add(save_n);
            Controls.Add(Price_txt);
            Controls.Add(lbPrice);
            Controls.Add(Barcode_txt);
            Controls.Add(lbBarcode);
            Controls.Add(Code_txt);
            Controls.Add(lbCode);
            Controls.Add(Name_txt);
            Controls.Add(lbName);
            Name = "Edit_Drug";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Edit Drug";
            Load += Edit_Drug_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbName;
        private TextBox Name_txt;
        private TextBox Code_txt;
        private Label lbCode;
        private TextBox Barcode_txt;
        private Label lbBarcode;
        private TextBox Price_txt;
        private Label lbPrice;
        private Button cancel_n;
        private Button save_n;
        private TextBox MinQuantity_txt;
        private Label label1;
    }
}