namespace login_page
{
    partial class LowStock_usercontrol
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
            lowStock_GV = new DataGridView();
            ignoreZero_checkBox = new CheckBox();
            Search_txt = new TextBox();
            search_btn = new Button();
            Reset_btn = new Button();
            SearchBy_combo = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)lowStock_GV).BeginInit();
            SuspendLayout();
            // 
            // lowStock_GV
            // 
            lowStock_GV.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lowStock_GV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            lowStock_GV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            lowStock_GV.Location = new Point(32, 96);
            lowStock_GV.Name = "lowStock_GV";
            lowStock_GV.RowHeadersWidth = 51;
            lowStock_GV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            lowStock_GV.Size = new Size(961, 510);
            lowStock_GV.TabIndex = 0;
            lowStock_GV.VirtualMode = true;
            // 
            // ignoreZero_checkBox
            // 
            ignoreZero_checkBox.AutoSize = true;
            ignoreZero_checkBox.Location = new Point(606, 18);
            ignoreZero_checkBox.Name = "ignoreZero_checkBox";
            ignoreZero_checkBox.Size = new Size(178, 24);
            ignoreZero_checkBox.TabIndex = 1;
            ignoreZero_checkBox.Text = "Ignore zero Quantities";
            ignoreZero_checkBox.UseVisualStyleBackColor = true;
            // 
            // Search_txt
            // 
            Search_txt.ForeColor = Color.Black;
            Search_txt.Location = new Point(166, 42);
            Search_txt.Name = "Search_txt";
            Search_txt.Size = new Size(198, 27);
            Search_txt.TabIndex = 2;
            Search_txt.KeyDown += minimum_txt_KeyDown;
            // 
            // search_btn
            // 
            search_btn.Location = new Point(32, 40);
            search_btn.Name = "search_btn";
            search_btn.Size = new Size(94, 29);
            search_btn.TabIndex = 3;
            search_btn.Text = "Search";
            search_btn.UseVisualStyleBackColor = true;
            search_btn.Click += search_btn_Click;
            // 
            // Reset_btn
            // 
            Reset_btn.Location = new Point(408, 42);
            Reset_btn.Name = "Reset_btn";
            Reset_btn.Size = new Size(94, 29);
            Reset_btn.TabIndex = 5;
            Reset_btn.Text = "Reset";
            Reset_btn.UseVisualStyleBackColor = true;
            Reset_btn.Click += Reset_btn_Click;
            // 
            // SearchBy_combo
            // 
            SearchBy_combo.DropDownStyle = ComboBoxStyle.DropDownList;
            SearchBy_combo.FormattingEnabled = true;
            SearchBy_combo.Items.AddRange(new object[] { "Quantity", "Expire Date" });
            SearchBy_combo.Location = new Point(596, 57);
            SearchBy_combo.Name = "SearchBy_combo";
            SearchBy_combo.Size = new Size(151, 28);
            SearchBy_combo.TabIndex = 6;
            // 
            // LowStock_usercontrol
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(SearchBy_combo);
            Controls.Add(Reset_btn);
            Controls.Add(search_btn);
            Controls.Add(Search_txt);
            Controls.Add(ignoreZero_checkBox);
            Controls.Add(lowStock_GV);
            Name = "LowStock_usercontrol";
            Size = new Size(1026, 642);
            Load += LowStock_usercontrol_Load;
            ((System.ComponentModel.ISupportInitialize)lowStock_GV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView lowStock_GV;
        private CheckBox ignoreZero_checkBox;
        private TextBox Search_txt;
        private Button search_btn;
        private Button Reset_btn;
        private ComboBox SearchBy_combo;
    }
}