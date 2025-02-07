namespace login_page
{
    partial class AddNewDrugs_Form
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
            save_btn = new Button();
            cancel_btn = new Button();
            dataGridView1 = new DataGridView();
            search_btn = new Button();
            search_txt = new TextBox();
            searchBy_Combo = new ComboBox();
            searchBy_label = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // save_btn
            // 
            save_btn.Location = new Point(129, 379);
            save_btn.Name = "save_btn";
            save_btn.Size = new Size(94, 29);
            save_btn.TabIndex = 0;
            save_btn.Text = "Save";
            save_btn.UseVisualStyleBackColor = true;
            // 
            // cancel_btn
            // 
            cancel_btn.Location = new Point(346, 379);
            cancel_btn.Name = "cancel_btn";
            cancel_btn.Size = new Size(94, 29);
            cancel_btn.TabIndex = 1;
            cancel_btn.Text = "Cancel";
            cancel_btn.UseVisualStyleBackColor = true;
            cancel_btn.Click += cancel_btn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(24, 106);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(726, 251);
            dataGridView1.TabIndex = 2;
            // 
            // search_btn
            // 
            search_btn.Location = new Point(39, 32);
            search_btn.Name = "search_btn";
            search_btn.Size = new Size(94, 29);
            search_btn.TabIndex = 3;
            search_btn.Text = "Search";
            search_btn.UseVisualStyleBackColor = true;
            // 
            // search_txt
            // 
            search_txt.Location = new Point(165, 34);
            search_txt.Name = "search_txt";
            search_txt.Size = new Size(125, 27);
            search_txt.TabIndex = 4;
            // 
            // searchBy_Combo
            // 
            searchBy_Combo.DropDownStyle = ComboBoxStyle.DropDownList;
            searchBy_Combo.FormattingEnabled = true;
            searchBy_Combo.Location = new Point(553, 62);
            searchBy_Combo.Name = "searchBy_Combo";
            searchBy_Combo.Size = new Size(151, 28);
            searchBy_Combo.TabIndex = 5;
            // 
            // searchBy_label
            // 
            searchBy_label.AutoSize = true;
            searchBy_label.Location = new Point(595, 32);
            searchBy_label.Name = "searchBy_label";
            searchBy_label.Size = new Size(73, 20);
            searchBy_label.TabIndex = 6;
            searchBy_label.Text = "Search By";
            // 
            // AddNewDrugs_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(searchBy_label);
            Controls.Add(searchBy_Combo);
            Controls.Add(search_txt);
            Controls.Add(search_btn);
            Controls.Add(dataGridView1);
            Controls.Add(cancel_btn);
            Controls.Add(save_btn);
            Name = "AddNewDrugs_Form";
            Text = "Add New Drugs";
            WindowState = FormWindowState.Maximized;
            Load += Add_New_Drugs_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button save_btn;
        private Button cancel_btn;
        private DataGridView dataGridView1;
        private Button search_btn;
        private TextBox search_txt;
        private ComboBox searchBy_Combo;
        private Label searchBy_label;
    }
}