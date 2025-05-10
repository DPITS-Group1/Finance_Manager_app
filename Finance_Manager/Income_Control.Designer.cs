namespace Finance_Manager
{
    partial class Income_Control
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
            this.tabIncome = new System.Windows.Forms.TabControl();
            this.tabIncomeList = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.customerInvoice_Control1 = new Finance_Manager.CustomerInvoice_Control();
            this.tabIncome.SuspendLayout();
            this.tabIncomeList.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblIncome
            // 
            this.lblIncome.AutoSize = true;
            this.lblIncome.Location = new System.Drawing.Point(6, 19);
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
            this.btnNewIncome.Location = new System.Drawing.Point(723, 16);
            this.btnNewIncome.Name = "btnNewIncome";
            this.btnNewIncome.Size = new System.Drawing.Size(143, 35);
            this.btnNewIncome.TabIndex = 1;
            this.btnNewIncome.Text = "+  New Income";
            this.btnNewIncome.UseVisualStyleBackColor = false;
            // 
            // tabIncome
            // 
            this.tabIncome.Controls.Add(this.tabIncomeList);
            this.tabIncome.Controls.Add(this.tabPage2);
            this.tabIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabIncome.Location = new System.Drawing.Point(11, 81);
            this.tabIncome.Name = "tabIncome";
            this.tabIncome.SelectedIndex = 0;
            this.tabIncome.Size = new System.Drawing.Size(859, 404);
            this.tabIncome.TabIndex = 2;
            // 
            // tabIncomeList
            // 
            this.tabIncomeList.Controls.Add(this.customerInvoice_Control1);
            this.tabIncomeList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabIncomeList.Location = new System.Drawing.Point(4, 27);
            this.tabIncomeList.Name = "tabIncomeList";
            this.tabIncomeList.Padding = new System.Windows.Forms.Padding(3);
            this.tabIncomeList.Size = new System.Drawing.Size(851, 373);
            this.tabIncomeList.TabIndex = 0;
            this.tabIncomeList.Text = "Income List";
            this.tabIncomeList.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(851, 373);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Record Income";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // customerInvoice_Control1
            // 
            this.customerInvoice_Control1.Location = new System.Drawing.Point(257, 128);
            this.customerInvoice_Control1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.customerInvoice_Control1.Name = "customerInvoice_Control1";
            this.customerInvoice_Control1.Size = new System.Drawing.Size(8, 8);
            this.customerInvoice_Control1.TabIndex = 0;
            // 
            // Income_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabIncome);
            this.Controls.Add(this.btnNewIncome);
            this.Controls.Add(this.lblIncome);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Income_Control";
            this.Size = new System.Drawing.Size(873, 503);
            this.Load += new System.EventHandler(this.Income_Control_Load);
            this.tabIncome.ResumeLayout(false);
            this.tabIncomeList.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIncome;
        private System.Windows.Forms.Button btnNewIncome;
        private System.Windows.Forms.TabControl tabIncome;
        private System.Windows.Forms.TabPage tabIncomeList;
        private System.Windows.Forms.TabPage tabPage2;
        private CustomerInvoice_Control customerInvoice_Control1;
    }
}
