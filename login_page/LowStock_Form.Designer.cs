﻿namespace login_page
{
    partial class LowStock_Form
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
            minimum_txt = new TextBox();
            search_min_btn = new Button();
            Reset_btn = new Button();
            ((System.ComponentModel.ISupportInitialize)lowStock_GV).BeginInit();
            SuspendLayout();
            // 
            // lowStock_GV
            // 
            lowStock_GV.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lowStock_GV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            lowStock_GV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            lowStock_GV.Location = new Point(0, 96);
            lowStock_GV.Name = "lowStock_GV";
            lowStock_GV.RowHeadersWidth = 51;
            lowStock_GV.Size = new Size(800, 353);
            lowStock_GV.TabIndex = 0;
            lowStock_GV.VirtualMode = true;
            // 
            // ignoreZero_checkBox
            // 
            ignoreZero_checkBox.AutoSize = true;
            ignoreZero_checkBox.Location = new Point(605, 13);
            ignoreZero_checkBox.Name = "ignoreZero_checkBox";
            ignoreZero_checkBox.Size = new Size(178, 24);
            ignoreZero_checkBox.TabIndex = 1;
            ignoreZero_checkBox.Text = "Ignore zero Quantities";
            ignoreZero_checkBox.UseVisualStyleBackColor = true;
            // 
            // minimum_txt
            // 
            minimum_txt.ForeColor = Color.Gray;
            minimum_txt.Location = new Point(166, 42);
            minimum_txt.Name = "minimum_txt";
            minimum_txt.Size = new Size(198, 27);
            minimum_txt.TabIndex = 2;
            minimum_txt.Text = "Enter Minimum Quantity . . .";
            minimum_txt.Enter += minimum_txt_Enter;
            minimum_txt.KeyDown += minimum_txt_KeyDown;
            minimum_txt.Leave += minimum_txt_Leave;
            // 
            // search_min_btn
            // 
            search_min_btn.Location = new Point(32, 40);
            search_min_btn.Name = "search_min_btn";
            search_min_btn.Size = new Size(94, 29);
            search_min_btn.TabIndex = 3;
            search_min_btn.Text = "Search";
            search_min_btn.UseVisualStyleBackColor = true;
            search_min_btn.Click += search_min_btn_Click;
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
            // LowStock_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Reset_btn);
            Controls.Add(search_min_btn);
            Controls.Add(minimum_txt);
            Controls.Add(ignoreZero_checkBox);
            Controls.Add(lowStock_GV);
            Name = "LowStock_Form";
            Text = "Low Stock";
            WindowState = FormWindowState.Maximized;
            Load += LowStock_Form_Load;
            ((System.ComponentModel.ISupportInitialize)lowStock_GV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView lowStock_GV;
        private CheckBox ignoreZero_checkBox;
        private TextBox minimum_txt;
        private Button search_min_btn;
        private Button Reset_btn;
    }
}