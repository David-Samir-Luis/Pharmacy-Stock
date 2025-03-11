namespace login_page
{
    partial class search_regex
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            resultContainer = new FlowLayoutPanel();
            panel1 = new Panel();
            itemsToBeAdded_GV = new DataGridView();
            searchBy_Combo = new ComboBox();
            search_txt = new TextBox();
            search_btn = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)itemsToBeAdded_GV).BeginInit();
            SuspendLayout();
            // 
            // resultContainer
            // 
            resultContainer.BackColor = Color.White;
            resultContainer.Location = new Point(142, 43);
            resultContainer.Name = "resultContainer";
            resultContainer.Size = new Size(275, 0);
            resultContainer.TabIndex = 18;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(itemsToBeAdded_GV);
            panel1.Location = new Point(16, 49);
            panel1.Name = "panel1";
            panel1.Size = new Size(960, 540);
            panel1.TabIndex = 22;
            // 
            // itemsToBeAdded_GV
            // 
            itemsToBeAdded_GV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(33, 11, 97);
            dataGridViewCellStyle1.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(33, 11, 97);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            itemsToBeAdded_GV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            itemsToBeAdded_GV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            itemsToBeAdded_GV.Dock = DockStyle.Fill;
            itemsToBeAdded_GV.EnableHeadersVisualStyles = false;
            itemsToBeAdded_GV.Location = new Point(0, 0);
            itemsToBeAdded_GV.Name = "itemsToBeAdded_GV";
            itemsToBeAdded_GV.RowHeadersVisible = false;
            itemsToBeAdded_GV.RowHeadersWidth = 51;
            itemsToBeAdded_GV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            itemsToBeAdded_GV.Size = new Size(960, 540);
            itemsToBeAdded_GV.TabIndex = 9;
            itemsToBeAdded_GV.CellDoubleClick += itemsToBeAdded_GV_CellDoubleClick;
            // 
            // searchBy_Combo
            // 
            searchBy_Combo.DropDownStyle = ComboBoxStyle.DropDownList;
            searchBy_Combo.FormattingEnabled = true;
            searchBy_Combo.Items.AddRange(new object[] { "Name", "Barcode", "Code" });
            searchBy_Combo.Location = new Point(441, 12);
            searchBy_Combo.Name = "searchBy_Combo";
            searchBy_Combo.Size = new Size(151, 28);
            searchBy_Combo.TabIndex = 21;
            searchBy_Combo.SelectedIndexChanged += searchBy_Combo_SelectedIndexChanged;
            // 
            // search_txt
            // 
            search_txt.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            search_txt.Location = new Point(142, 12);
            search_txt.Name = "search_txt";
            search_txt.Size = new Size(275, 31);
            search_txt.TabIndex = 20;
            search_txt.KeyDown += search_txt_KeyDown;
            // 
            // search_btn
            // 
            search_btn.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            search_btn.Location = new Point(16, 12);
            search_btn.Name = "search_btn";
            search_btn.Size = new Size(120, 31);
            search_btn.TabIndex = 19;
            search_btn.Text = "Search";
            search_btn.UseVisualStyleBackColor = true;
            search_btn.Click += search_btn_Click;
            // 
            // search_regex
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(998, 615);
            Controls.Add(resultContainer);
            Controls.Add(panel1);
            Controls.Add(searchBy_Combo);
            Controls.Add(search_txt);
            Controls.Add(search_btn);
            Name = "search_regex";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "search_regex";
            Load += search_regex_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)itemsToBeAdded_GV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel resultContainer;
        private Panel panel1;
        private DataGridView itemsToBeAdded_GV;
        private ComboBox searchBy_Combo;
        private TextBox search_txt;
        private Button search_btn;
    }
}