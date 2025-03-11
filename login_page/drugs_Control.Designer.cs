namespace login_page
{
    partial class drugs_Control
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            resultContainer = new FlowLayoutPanel();
            panel1 = new Panel();
            itemsToBeAdded_GV = new DataGridView();
            searchBy_Combo = new ComboBox();
            search_txt = new TextBox();
            search_btn = new Button();
            Edit_bt = new Button();
            Add_bt = new Button();
            Copy_bt = new Button();
            Delete_bt = new Button();
            panel2 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)itemsToBeAdded_GV).BeginInit();
            panel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // resultContainer
            // 
            resultContainer.BackColor = Color.White;
            resultContainer.Location = new Point(150, 51);
            resultContainer.Name = "resultContainer";
            resultContainer.Size = new Size(275, 0);
            resultContainer.TabIndex = 24;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(itemsToBeAdded_GV);
            panel1.Location = new Point(24, 57);
            panel1.Name = "panel1";
            panel1.Size = new Size(966, 506);
            panel1.TabIndex = 27;
            // 
            // itemsToBeAdded_GV
            // 
            itemsToBeAdded_GV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(33, 11, 97);
            dataGridViewCellStyle2.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(33, 11, 97);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            itemsToBeAdded_GV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            itemsToBeAdded_GV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            itemsToBeAdded_GV.Dock = DockStyle.Fill;
            itemsToBeAdded_GV.EnableHeadersVisualStyles = false;
            itemsToBeAdded_GV.Location = new Point(0, 0);
            itemsToBeAdded_GV.Name = "itemsToBeAdded_GV";
            itemsToBeAdded_GV.RowHeadersVisible = false;
            itemsToBeAdded_GV.RowHeadersWidth = 51;
            itemsToBeAdded_GV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            itemsToBeAdded_GV.Size = new Size(966, 506);
            itemsToBeAdded_GV.TabIndex = 9;
            // 
            // searchBy_Combo
            // 
            searchBy_Combo.DropDownStyle = ComboBoxStyle.DropDownList;
            searchBy_Combo.FormattingEnabled = true;
            searchBy_Combo.Items.AddRange(new object[] { "Name", "Barcode", "Code" });
            searchBy_Combo.Location = new Point(449, 20);
            searchBy_Combo.Name = "searchBy_Combo";
            searchBy_Combo.Size = new Size(151, 28);
            searchBy_Combo.TabIndex = 26;
            // 
            // search_txt
            // 
            search_txt.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            search_txt.Location = new Point(150, 20);
            search_txt.Name = "search_txt";
            search_txt.Size = new Size(275, 31);
            search_txt.TabIndex = 0;
            // 
            // search_btn
            // 
            search_btn.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            search_btn.Location = new Point(24, 20);
            search_btn.Name = "search_btn";
            search_btn.Size = new Size(120, 31);
            search_btn.TabIndex = 25;
            search_btn.Text = "Search";
            search_btn.UseVisualStyleBackColor = true;
            search_btn.Click += search_btn_Click;
            // 
            // Edit_bt
            // 
            Edit_bt.Anchor = AnchorStyles.None;
            Edit_bt.BackColor = Color.FromArgb(33, 8, 97);
            Edit_bt.FlatAppearance.MouseDownBackColor = Color.FromArgb(75, 8, 138);
            Edit_bt.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 8, 138);
            Edit_bt.FlatStyle = FlatStyle.Flat;
            Edit_bt.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Edit_bt.ForeColor = Color.White;
            Edit_bt.Location = new Point(272, 32);
            Edit_bt.Name = "Edit_bt";
            Edit_bt.Size = new Size(178, 40);
            Edit_bt.TabIndex = 29;
            Edit_bt.Text = "Edit";
            Edit_bt.UseVisualStyleBackColor = false;
            // 
            // Add_bt
            // 
            Add_bt.Anchor = AnchorStyles.None;
            Add_bt.BackColor = Color.FromArgb(33, 8, 97);
            Add_bt.FlatAppearance.MouseDownBackColor = Color.FromArgb(75, 8, 138);
            Add_bt.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 8, 138);
            Add_bt.FlatStyle = FlatStyle.Flat;
            Add_bt.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Add_bt.ForeColor = Color.White;
            Add_bt.Location = new Point(31, 32);
            Add_bt.Name = "Add_bt";
            Add_bt.Size = new Size(178, 40);
            Add_bt.TabIndex = 28;
            Add_bt.Text = "Add";
            Add_bt.UseVisualStyleBackColor = false;
            // 
            // Copy_bt
            // 
            Copy_bt.Anchor = AnchorStyles.None;
            Copy_bt.BackColor = Color.FromArgb(33, 8, 97);
            Copy_bt.FlatAppearance.MouseDownBackColor = Color.FromArgb(75, 8, 138);
            Copy_bt.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 8, 138);
            Copy_bt.FlatStyle = FlatStyle.Flat;
            Copy_bt.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Copy_bt.ForeColor = Color.White;
            Copy_bt.Location = new Point(513, 32);
            Copy_bt.Name = "Copy_bt";
            Copy_bt.Size = new Size(178, 40);
            Copy_bt.TabIndex = 30;
            Copy_bt.Text = "Copy";
            Copy_bt.UseVisualStyleBackColor = false;
            // 
            // Delete_bt
            // 
            Delete_bt.Anchor = AnchorStyles.None;
            Delete_bt.BackColor = Color.FromArgb(33, 8, 97);
            Delete_bt.FlatAppearance.MouseDownBackColor = Color.FromArgb(75, 8, 138);
            Delete_bt.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 8, 138);
            Delete_bt.FlatStyle = FlatStyle.Flat;
            Delete_bt.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Delete_bt.ForeColor = Color.White;
            Delete_bt.Location = new Point(755, 32);
            Delete_bt.Name = "Delete_bt";
            Delete_bt.Size = new Size(178, 40);
            Delete_bt.TabIndex = 31;
            Delete_bt.Text = "Delete";
            Delete_bt.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(tableLayoutPanel1);
            panel2.Location = new Point(24, 569);
            panel2.Name = "panel2";
            panel2.Size = new Size(966, 105);
            panel2.TabIndex = 17;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(Delete_bt, 3, 0);
            tableLayoutPanel1.Controls.Add(Copy_bt, 2, 0);
            tableLayoutPanel1.Controls.Add(Add_bt, 0, 0);
            tableLayoutPanel1.Controls.Add(Edit_bt, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(966, 105);
            tableLayoutPanel1.TabIndex = 32;
            // 
            // drugs_Control
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(resultContainer);
            Controls.Add(panel1);
            Controls.Add(searchBy_Combo);
            Controls.Add(search_txt);
            Controls.Add(search_btn);
            Name = "drugs_Control";
            Size = new Size(1016, 674);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)itemsToBeAdded_GV).EndInit();
            panel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
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
        private Button Edit_bt;
        private Button Add_bt;
        private Button Copy_bt;
        private Button Delete_bt;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
