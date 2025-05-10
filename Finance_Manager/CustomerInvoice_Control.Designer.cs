namespace Finance_Manager
{
    partial class CustomerInvoice_Control
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbcCustomerInvoices = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnCreateCustomerInvoice = new System.Windows.Forms.Button();
            this.tbcCustomerInvoices.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Invoices";
            // 
            // tbcCustomerInvoices
            // 
            this.tbcCustomerInvoices.Controls.Add(this.tabPage1);
            this.tbcCustomerInvoices.Controls.Add(this.tabPage2);
            this.tbcCustomerInvoices.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcCustomerInvoices.Location = new System.Drawing.Point(3, 64);
            this.tbcCustomerInvoices.Name = "tbcCustomerInvoices";
            this.tbcCustomerInvoices.SelectedIndex = 0;
            this.tbcCustomerInvoices.Size = new System.Drawing.Size(852, 436);
            this.tbcCustomerInvoices.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(844, 404);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Customer List";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(844, 404);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Create Invoice";
            // 
            // btnCreateCustomerInvoice
            // 
            this.btnCreateCustomerInvoice.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnCreateCustomerInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateCustomerInvoice.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCreateCustomerInvoice.Location = new System.Drawing.Point(687, 24);
            this.btnCreateCustomerInvoice.Name = "btnCreateCustomerInvoice";
            this.btnCreateCustomerInvoice.Size = new System.Drawing.Size(168, 41);
            this.btnCreateCustomerInvoice.TabIndex = 3;
            this.btnCreateCustomerInvoice.Text = "+  New Invoice";
            this.btnCreateCustomerInvoice.UseVisualStyleBackColor = false;
            // 
            // CustomerInvoice_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCreateCustomerInvoice);
            this.Controls.Add(this.tbcCustomerInvoices);
            this.Controls.Add(this.label1);
            this.Name = "CustomerInvoice_Control";
            this.Size = new System.Drawing.Size(873, 503);
            this.tbcCustomerInvoices.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tbcCustomerInvoices;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnCreateCustomerInvoice;
    }
}
