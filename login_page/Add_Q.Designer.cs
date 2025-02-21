namespace login_page
{
    partial class Add_Q
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
            searchBy_Combo = new ComboBox();
            search_txt = new TextBox();
            search_btn = new Button();
            itemsToBeAdded_GV = new DataGridView();
            cancel_btn = new Button();
            save_btn = new Button();
            ((System.ComponentModel.ISupportInitialize)itemsToBeAdded_GV).BeginInit();
            SuspendLayout();
            // 
            // searchBy_Combo
            // 
            searchBy_Combo.DropDownStyle = ComboBoxStyle.DropDownList;
            searchBy_Combo.FormattingEnabled = true;
            searchBy_Combo.Items.AddRange(new object[] { "Barcode", "Code", "Name" });
            searchBy_Combo.Location = new Point(486, 40);
            searchBy_Combo.Name = "searchBy_Combo";
            searchBy_Combo.Size = new Size(151, 28);
            searchBy_Combo.TabIndex = 12;
            searchBy_Combo.SelectedIndexChanged += searchBy_Combo_SelectedIndexChanged;
            // 
            // search_txt
            // 
            search_txt.Location = new Point(183, 42);
            search_txt.Name = "search_txt";
            search_txt.Size = new Size(275, 27);
            search_txt.TabIndex = 11;
            search_txt.KeyDown += search_txt_KeyDown;
            // 
            // search_btn
            // 
            search_btn.Location = new Point(57, 40);
            search_btn.Name = "search_btn";
            search_btn.Size = new Size(94, 29);
            search_btn.TabIndex = 10;
            search_btn.Text = "Search";
            search_btn.UseVisualStyleBackColor = true;
            search_btn.Click += search_btn_Click;
            // 
            // itemsToBeAdded_GV
            // 
            itemsToBeAdded_GV.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            itemsToBeAdded_GV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            itemsToBeAdded_GV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            itemsToBeAdded_GV.Location = new Point(45, 92);
            itemsToBeAdded_GV.Name = "itemsToBeAdded_GV";
            itemsToBeAdded_GV.RowHeadersWidth = 51;
            itemsToBeAdded_GV.Size = new Size(823, 251);
            itemsToBeAdded_GV.TabIndex = 9;
            // 
            // cancel_btn
            // 
            cancel_btn.Location = new Point(584, 444);
            cancel_btn.Name = "cancel_btn";
            cancel_btn.Size = new Size(94, 29);
            cancel_btn.TabIndex = 8;
            cancel_btn.Text = "Cancel";
            cancel_btn.UseVisualStyleBackColor = true;
            // 
            // save_btn
            // 
            save_btn.Location = new Point(141, 444);
            save_btn.Name = "save_btn";
            save_btn.Size = new Size(94, 29);
            save_btn.TabIndex = 7;
            save_btn.Text = "Save";
            save_btn.UseVisualStyleBackColor = true;
            // 
            // Add_Q
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(searchBy_Combo);
            Controls.Add(search_txt);
            Controls.Add(search_btn);
            Controls.Add(itemsToBeAdded_GV);
            Controls.Add(cancel_btn);
            Controls.Add(save_btn);
            Name = "Add_Q";
            Size = new Size(1330, 802);
            ((System.ComponentModel.ISupportInitialize)itemsToBeAdded_GV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox searchBy_Combo;
        private TextBox search_txt;
        private Button search_btn;
        private DataGridView itemsToBeAdded_GV;
        private Button cancel_btn;
        private Button save_btn;
    }
}
