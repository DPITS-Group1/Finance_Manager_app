namespace Finance_Manager
{
    partial class Income_UserControl
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
            this.lblIncome = new System.Windows.Forms.Label();
            this.btnNewIncome = new System.Windows.Forms.Button();
            this.tabRecordIncome = new System.Windows.Forms.TabControl();
            this.tabIncome = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colSource = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabRecordIncome.SuspendLayout();
            this.tabIncome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIncome
            // 
            this.lblIncome.AutoSize = true;
            this.lblIncome.Location = new System.Drawing.Point(6, 25);
            this.lblIncome.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblIncome.Name = "lblIncome";
            this.lblIncome.Size = new System.Drawing.Size(87, 25);
            this.lblIncome.TabIndex = 0;
            this.lblIncome.Text = "Income";
            // 
            // btnNewIncome
            // 
            this.btnNewIncome.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnNewIncome.FlatAppearance.BorderSize = 0;
            this.btnNewIncome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnNewIncome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewIncome.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNewIncome.Location = new System.Drawing.Point(690, 15);
            this.btnNewIncome.Name = "btnNewIncome";
            this.btnNewIncome.Size = new System.Drawing.Size(143, 35);
            this.btnNewIncome.TabIndex = 1;
            this.btnNewIncome.Text = "+  New Income";
            this.btnNewIncome.UseVisualStyleBackColor = false;
            // 
            // tabRecordIncome
            // 
            this.tabRecordIncome.Controls.Add(this.tabIncome);
            this.tabRecordIncome.Controls.Add(this.tabPage2);
            this.tabRecordIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabRecordIncome.Location = new System.Drawing.Point(5, 55);
            this.tabRecordIncome.Name = "tabRecordIncome";
            this.tabRecordIncome.SelectedIndex = 0;
            this.tabRecordIncome.Size = new System.Drawing.Size(843, 594);
            this.tabRecordIncome.TabIndex = 2;
            // 
            // tabIncome
            // 
            this.tabIncome.Controls.Add(this.dataGridView1);
            this.tabIncome.Controls.Add(this.label1);
            this.tabIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabIncome.Location = new System.Drawing.Point(4, 29);
            this.tabIncome.Name = "tabIncome";
            this.tabIncome.Padding = new System.Windows.Forms.Padding(3);
            this.tabIncome.Size = new System.Drawing.Size(835, 561);
            this.tabIncome.TabIndex = 0;
            this.tabIncome.Text = "Income List";
            this.tabIncome.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Income Records";
            // 
            // tabPage2
            // 
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(835, 561);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Record Income";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSource,
            this.colDate,
            this.colAmount,
            this.colDescription});
            this.dataGridView1.Location = new System.Drawing.Point(17, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(812, 517);
            this.dataGridView1.TabIndex = 2;
            // 
            // colSource
            // 
            this.colSource.HeaderText = "Source";
            this.colSource.Name = "colSource";
            this.colSource.Width = 150;
            // 
            // colDate
            // 
            this.colDate.HeaderText = "Date";
            this.colDate.Name = "colDate";
            this.colDate.Width = 150;
            // 
            // colAmount
            // 
            this.colAmount.HeaderText = "Amount";
            this.colAmount.Name = "colAmount";
            this.colAmount.Width = 150;
            // 
            // colDescription
            // 
            this.colDescription.HeaderText = "Decscription";
            this.colDescription.Name = "colDescription";
            this.colDescription.Width = 300;
            // 
            // Income_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabRecordIncome);
            this.Controls.Add(this.btnNewIncome);
            this.Controls.Add(this.lblIncome);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Income_UserControl";
            this.Size = new System.Drawing.Size(850, 650);
            this.tabRecordIncome.ResumeLayout(false);
            this.tabIncome.ResumeLayout(false);
            this.tabIncome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIncome;
        private System.Windows.Forms.Button btnNewIncome;
        private System.Windows.Forms.TabControl tabRecordIncome;
        private System.Windows.Forms.TabPage tabIncome;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescription;
    }
}
