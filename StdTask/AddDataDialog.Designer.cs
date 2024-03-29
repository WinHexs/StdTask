﻿namespace StdTask
{
    partial class AddDataDialog
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
            this.addDataPanel = new System.Windows.Forms.Panel();
            this.addButton = new System.Windows.Forms.Button();
            this.dataCountLabel = new System.Windows.Forms.Label();
            this.autoGenerateDataCheckBox = new System.Windows.Forms.CheckBox();
            this.dataNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.addDataGridView = new System.Windows.Forms.DataGridView();
            this.addDataPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // addDataPanel
            // 
            this.addDataPanel.Controls.Add(this.addButton);
            this.addDataPanel.Controls.Add(this.dataCountLabel);
            this.addDataPanel.Controls.Add(this.autoGenerateDataCheckBox);
            this.addDataPanel.Controls.Add(this.dataNumericUpDown);
            this.addDataPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.addDataPanel.Location = new System.Drawing.Point(0, 0);
            this.addDataPanel.Name = "addDataPanel";
            this.addDataPanel.Size = new System.Drawing.Size(327, 66);
            this.addDataPanel.TabIndex = 0;
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.addButton.Location = new System.Drawing.Point(242, 18);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 36);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // dataCountLabel
            // 
            this.dataCountLabel.AutoSize = true;
            this.dataCountLabel.Location = new System.Drawing.Point(12, 18);
            this.dataCountLabel.Name = "dataCountLabel";
            this.dataCountLabel.Size = new System.Drawing.Size(114, 13);
            this.dataCountLabel.TabIndex = 2;
            this.dataCountLabel.Text = "Количество записей:";
            // 
            // autoGenerateDataCheckBox
            // 
            this.autoGenerateDataCheckBox.AutoSize = true;
            this.autoGenerateDataCheckBox.Location = new System.Drawing.Point(132, 37);
            this.autoGenerateDataCheckBox.Name = "autoGenerateDataCheckBox";
            this.autoGenerateDataCheckBox.Size = new System.Drawing.Size(104, 17);
            this.autoGenerateDataCheckBox.TabIndex = 1;
            this.autoGenerateDataCheckBox.Text = "Автоматически";
            this.autoGenerateDataCheckBox.UseVisualStyleBackColor = true;
            // 
            // dataNumericUpDown
            // 
            this.dataNumericUpDown.Location = new System.Drawing.Point(12, 34);
            this.dataNumericUpDown.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.dataNumericUpDown.Name = "dataNumericUpDown";
            this.dataNumericUpDown.ReadOnly = true;
            this.dataNumericUpDown.Size = new System.Drawing.Size(114, 20);
            this.dataNumericUpDown.TabIndex = 0;
            this.dataNumericUpDown.ValueChanged += new System.EventHandler(this.dataNumericUpDown_ValueChanged);
            // 
            // addDataGridView
            // 
            this.addDataGridView.AllowUserToAddRows = false;
            this.addDataGridView.AllowUserToDeleteRows = false;
            this.addDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.addDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addDataGridView.Location = new System.Drawing.Point(0, 66);
            this.addDataGridView.Name = "addDataGridView";
            this.addDataGridView.RowHeadersVisible = false;
            this.addDataGridView.Size = new System.Drawing.Size(327, 384);
            this.addDataGridView.TabIndex = 3;
            this.addDataGridView.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.addDataGridView_CellBeginEdit);
            this.addDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.addDataGridView_CellEndEdit);
            // 
            // AddDataDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 450);
            this.Controls.Add(this.addDataGridView);
            this.Controls.Add(this.addDataPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "AddDataDialog";
            this.Text = "Добавить";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddDataDialog_FormClosing);
            this.addDataPanel.ResumeLayout(false);
            this.addDataPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel addDataPanel;
        private System.Windows.Forms.Label dataCountLabel;
        private System.Windows.Forms.CheckBox autoGenerateDataCheckBox;
        private System.Windows.Forms.NumericUpDown dataNumericUpDown;
        private System.Windows.Forms.DataGridView addDataGridView;
        private System.Windows.Forms.Button addButton;
    }
}