﻿namespace login_page
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            searchBy_Combo = new ComboBox();
            search_txt = new TextBox();
            search_btn = new Button();
            itemsToBeAdded_GV = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            deleteToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem1 = new ToolStripMenuItem();
            save_n = new Button();
            cancel_n = new Button();
            panel1 = new Panel();
            resultContainer = new FlowLayoutPanel();
            panel2 = new Panel();
            StockOperationType = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)itemsToBeAdded_GV).BeginInit();
            contextMenuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // searchBy_Combo
            // 
            searchBy_Combo.DropDownStyle = ComboBoxStyle.DropDownList;
            searchBy_Combo.FormattingEnabled = true;
            searchBy_Combo.Items.AddRange(new object[] { "Barcode", "Code", "Name", "Dynamic Name" });
            searchBy_Combo.Location = new Point(482, 34);
            searchBy_Combo.Name = "searchBy_Combo";
            searchBy_Combo.Size = new Size(151, 28);
            searchBy_Combo.TabIndex = 12;
            searchBy_Combo.SelectedIndexChanged += searchBy_Combo_SelectedIndexChanged;
            // 
            // search_txt
            // 
            search_txt.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            search_txt.Location = new Point(183, 34);
            search_txt.Name = "search_txt";
            search_txt.Size = new Size(275, 31);
            search_txt.TabIndex = 11;
            search_txt.TextChanged += search_txt_TextChanged;
            search_txt.KeyDown += search_txt_KeyDown;
            // 
            // search_btn
            // 
            search_btn.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            search_btn.Location = new Point(57, 34);
            search_btn.Name = "search_btn";
            search_btn.Size = new Size(120, 31);
            search_btn.TabIndex = 10;
            search_btn.Text = "Search";
            search_btn.UseVisualStyleBackColor = true;
            search_btn.Click += search_btn_Click;
            // 
            // itemsToBeAdded_GV
            // 
            itemsToBeAdded_GV.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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
            itemsToBeAdded_GV.ContextMenuStrip = contextMenuStrip1;
            itemsToBeAdded_GV.EnableHeadersVisualStyles = false;
            itemsToBeAdded_GV.Location = new Point(57, 8);
            itemsToBeAdded_GV.Name = "itemsToBeAdded_GV";
            itemsToBeAdded_GV.RowHeadersVisible = false;
            itemsToBeAdded_GV.RowHeadersWidth = 51;
            itemsToBeAdded_GV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            itemsToBeAdded_GV.Size = new Size(958, 527);
            itemsToBeAdded_GV.TabIndex = 9;
            itemsToBeAdded_GV.CellValidating += itemsToBeAdded_GV_CellValidating;
            itemsToBeAdded_GV.CellValueChanged += itemsToBeAdded_GV_CellValueChanged;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { deleteToolStripMenuItem, deleteToolStripMenuItem1 });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(130, 60);
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(129, 28);
            deleteToolStripMenuItem.Text = "Edit";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem1
            // 
            deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            deleteToolStripMenuItem1.Size = new Size(129, 28);
            deleteToolStripMenuItem1.Text = "Delete";
            deleteToolStripMenuItem1.Click += deleteToolStripMenuItem1_Click;
            // 
            // save_n
            // 
            save_n.BackColor = Color.FromArgb(33, 8, 97);
            save_n.FlatAppearance.MouseDownBackColor = Color.FromArgb(75, 8, 138);
            save_n.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 8, 138);
            save_n.FlatStyle = FlatStyle.Flat;
            save_n.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            save_n.ForeColor = Color.White;
            save_n.Location = new Point(200, 15);
            save_n.Name = "save_n";
            save_n.Size = new Size(200, 40);
            save_n.TabIndex = 13;
            save_n.Text = "Save";
            save_n.UseVisualStyleBackColor = false;
            save_n.Click += save_n_Click;
            // 
            // cancel_n
            // 
            cancel_n.BackColor = Color.FromArgb(33, 8, 97);
            cancel_n.FlatAppearance.MouseDownBackColor = Color.FromArgb(75, 8, 138);
            cancel_n.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 8, 138);
            cancel_n.FlatStyle = FlatStyle.Flat;
            cancel_n.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cancel_n.ForeColor = Color.White;
            cancel_n.Location = new Point(742, 15);
            cancel_n.Name = "cancel_n";
            cancel_n.Size = new Size(203, 40);
            cancel_n.TabIndex = 14;
            cancel_n.Text = "Cancel";
            cancel_n.UseVisualStyleBackColor = false;
            cancel_n.Click += cancel_n_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(itemsToBeAdded_GV);
            panel1.Location = new Point(0, 72);
            panel1.Name = "panel1";
            panel1.Size = new Size(1086, 538);
            panel1.TabIndex = 15;
            // 
            // resultContainer
            // 
            resultContainer.BackColor = Color.White;
            resultContainer.Location = new Point(183, 65);
            resultContainer.Name = "resultContainer";
            resultContainer.Size = new Size(275, 0);
            resultContainer.TabIndex = 10;
            // 
            // panel2
            // 
            panel2.Controls.Add(cancel_n);
            panel2.Controls.Add(save_n);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 613);
            panel2.Name = "panel2";
            panel2.Size = new Size(1086, 107);
            panel2.TabIndex = 16;
            // 
            // StockOperationType
            // 
            StockOperationType.DropDownStyle = ComboBoxStyle.DropDownList;
            StockOperationType.FormattingEnabled = true;
            StockOperationType.Items.AddRange(new object[] { "Stock Out", "Stock In" });
            StockOperationType.Location = new Point(757, 28);
            StockOperationType.Name = "StockOperationType";
            StockOperationType.Size = new Size(151, 28);
            StockOperationType.TabIndex = 17;
            // 
            // Add_Q
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(StockOperationType);
            Controls.Add(resultContainer);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(searchBy_Combo);
            Controls.Add(search_txt);
            Controls.Add(search_btn);
            Name = "Add_Q";
            Size = new Size(1086, 720);
            Load += Add_Q_Load;
            ((System.ComponentModel.ISupportInitialize)itemsToBeAdded_GV).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
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
        private Button save_n;
        private Button cancel_n;
        private Panel panel1;
        private Panel panel2;
        private FlowLayoutPanel resultContainer;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem1;
        private ComboBox StockOperationType;
    }
}
