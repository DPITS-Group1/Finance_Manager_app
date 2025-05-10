namespace Finance_Manager
{
    partial class Supplier_Control
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
            this.tbcSupplierInvoices = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblInvoiceDate = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblSupplierControl = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lnlPaymentTearms = new System.Windows.Forms.Label();
            this.cmbPaymentTerms = new System.Windows.Forms.ComboBox();
            this.dtpInvoiceDate = new System.Windows.Forms.DateTimePicker();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblInvoiceNumber = new System.Windows.Forms.Label();
            this.lblSupplierName = new System.Windows.Forms.Label();
            this.txtInvoiceNumber = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtSupplierName = new System.Windows.Forms.TextBox();
            this.btnSaveSupplier = new System.Windows.Forms.Button();
            this.lblSupplierInvoices = new System.Windows.Forms.Label();
            this.btnCreateSupplierInvoice = new System.Windows.Forms.Button();
            this.tbcSupplierInvoices.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcSupplierInvoices
            // 
            this.tbcSupplierInvoices.Controls.Add(this.tabPage1);
            this.tbcSupplierInvoices.Controls.Add(this.tabPage2);
            this.tbcSupplierInvoices.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcSupplierInvoices.Location = new System.Drawing.Point(18, 64);
            this.tbcSupplierInvoices.Name = "tbcSupplierInvoices";
            this.tbcSupplierInvoices.SelectedIndex = 0;
            this.tbcSupplierInvoices.Size = new System.Drawing.Size(852, 436);
            this.tbcSupplierInvoices.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(844, 404);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Invoice List";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.lblInvoiceDate);
            this.tabPage2.Controls.Add(this.btnClear);
            this.tabPage2.Controls.Add(this.lblSupplierControl);
            this.tabPage2.Controls.Add(this.lblStatus);
            this.tabPage2.Controls.Add(this.cmbStatus);
            this.tabPage2.Controls.Add(this.lnlPaymentTearms);
            this.tabPage2.Controls.Add(this.cmbPaymentTerms);
            this.tabPage2.Controls.Add(this.dtpInvoiceDate);
            this.tabPage2.Controls.Add(this.lblAmount);
            this.tabPage2.Controls.Add(this.lblInvoiceNumber);
            this.tabPage2.Controls.Add(this.lblSupplierName);
            this.tabPage2.Controls.Add(this.txtInvoiceNumber);
            this.tabPage2.Controls.Add(this.txtAmount);
            this.tabPage2.Controls.Add(this.txtSupplierName);
            this.tabPage2.Controls.Add(this.btnSaveSupplier);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(844, 404);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Create Invoice";
            // 
            // lblInvoiceDate
            // 
            this.lblInvoiceDate.AutoSize = true;
            this.lblInvoiceDate.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoiceDate.Location = new System.Drawing.Point(459, 160);
            this.lblInvoiceDate.Name = "lblInvoiceDate";
            this.lblInvoiceDate.Size = new System.Drawing.Size(92, 19);
            this.lblInvoiceDate.TabIndex = 45;
            this.lblInvoiceDate.Text = "Invoice Date";
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(465, 390);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(137, 39);
            this.btnClear.TabIndex = 44;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // lblSupplierControl
            // 
            this.lblSupplierControl.AutoSize = true;
            this.lblSupplierControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplierControl.Location = new System.Drawing.Point(24, 30);
            this.lblSupplierControl.Name = "lblSupplierControl";
            this.lblSupplierControl.Size = new System.Drawing.Size(296, 31);
            this.lblSupplierControl.TabIndex = 43;
            this.lblSupplierControl.Text = "Create Supplier Invoice";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(26, 234);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(49, 19);
            this.lblStatus.TabIndex = 42;
            this.lblStatus.Text = "Status";
            // 
            // cmbStatus
            // 
            this.cmbStatus.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(144, 231);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(213, 27);
            this.cmbStatus.TabIndex = 41;
            // 
            // lnlPaymentTearms
            // 
            this.lnlPaymentTearms.AutoSize = true;
            this.lnlPaymentTearms.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnlPaymentTearms.Location = new System.Drawing.Point(459, 231);
            this.lnlPaymentTearms.Name = "lnlPaymentTearms";
            this.lnlPaymentTearms.Size = new System.Drawing.Size(110, 19);
            this.lnlPaymentTearms.TabIndex = 40;
            this.lnlPaymentTearms.Text = "Payment Terms";
            // 
            // cmbPaymentTerms
            // 
            this.cmbPaymentTerms.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPaymentTerms.FormattingEnabled = true;
            this.cmbPaymentTerms.Location = new System.Drawing.Point(590, 226);
            this.cmbPaymentTerms.Name = "cmbPaymentTerms";
            this.cmbPaymentTerms.Size = new System.Drawing.Size(213, 27);
            this.cmbPaymentTerms.TabIndex = 39;
            // 
            // dtpInvoiceDate
            // 
            this.dtpInvoiceDate.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpInvoiceDate.Location = new System.Drawing.Point(590, 160);
            this.dtpInvoiceDate.Name = "dtpInvoiceDate";
            this.dtpInvoiceDate.Size = new System.Drawing.Size(213, 27);
            this.dtpInvoiceDate.TabIndex = 38;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(26, 166);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(62, 19);
            this.lblAmount.TabIndex = 37;
            this.lblAmount.Text = "Amount";
            // 
            // lblInvoiceNumber
            // 
            this.lblInvoiceNumber.AutoSize = true;
            this.lblInvoiceNumber.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoiceNumber.Location = new System.Drawing.Point(459, 98);
            this.lblInvoiceNumber.Name = "lblInvoiceNumber";
            this.lblInvoiceNumber.Size = new System.Drawing.Size(114, 19);
            this.lblInvoiceNumber.TabIndex = 36;
            this.lblInvoiceNumber.Text = "Invoice Number";
            // 
            // lblSupplierName
            // 
            this.lblSupplierName.AutoSize = true;
            this.lblSupplierName.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplierName.Location = new System.Drawing.Point(26, 101);
            this.lblSupplierName.Name = "lblSupplierName";
            this.lblSupplierName.Size = new System.Drawing.Size(108, 19);
            this.lblSupplierName.TabIndex = 35;
            this.lblSupplierName.Text = "Supplier Name";
            // 
            // txtInvoiceNumber
            // 
            this.txtInvoiceNumber.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvoiceNumber.Location = new System.Drawing.Point(590, 95);
            this.txtInvoiceNumber.Name = "txtInvoiceNumber";
            this.txtInvoiceNumber.Size = new System.Drawing.Size(213, 27);
            this.txtInvoiceNumber.TabIndex = 34;
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(144, 163);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(213, 27);
            this.txtAmount.TabIndex = 33;
            // 
            // txtSupplierName
            // 
            this.txtSupplierName.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSupplierName.Location = new System.Drawing.Point(144, 98);
            this.txtSupplierName.Name = "txtSupplierName";
            this.txtSupplierName.Size = new System.Drawing.Size(213, 27);
            this.txtSupplierName.TabIndex = 32;
            // 
            // btnSaveSupplier
            // 
            this.btnSaveSupplier.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveSupplier.Location = new System.Drawing.Point(608, 390);
            this.btnSaveSupplier.Name = "btnSaveSupplier";
            this.btnSaveSupplier.Size = new System.Drawing.Size(195, 39);
            this.btnSaveSupplier.TabIndex = 31;
            this.btnSaveSupplier.Text = "Create Supplier Invoice";
            this.btnSaveSupplier.UseVisualStyleBackColor = true;
            // 
            // lblSupplierInvoices
            // 
            this.lblSupplierInvoices.AutoSize = true;
            this.lblSupplierInvoices.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplierInvoices.Location = new System.Drawing.Point(14, 20);
            this.lblSupplierInvoices.Name = "lblSupplierInvoices";
            this.lblSupplierInvoices.Size = new System.Drawing.Size(171, 24);
            this.lblSupplierInvoices.TabIndex = 1;
            this.lblSupplierInvoices.Text = "Supplier Invoices";
            // 
            // btnCreateSupplierInvoice
            // 
            this.btnCreateSupplierInvoice.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnCreateSupplierInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateSupplierInvoice.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCreateSupplierInvoice.Location = new System.Drawing.Point(698, 13);
            this.btnCreateSupplierInvoice.Name = "btnCreateSupplierInvoice";
            this.btnCreateSupplierInvoice.Size = new System.Drawing.Size(168, 41);
            this.btnCreateSupplierInvoice.TabIndex = 2;
            this.btnCreateSupplierInvoice.Text = "+ New Invoice";
            this.btnCreateSupplierInvoice.UseVisualStyleBackColor = false;
            // 
            // Supplier_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCreateSupplierInvoice);
            this.Controls.Add(this.lblSupplierInvoices);
            this.Controls.Add(this.tbcSupplierInvoices);
            this.Name = "Supplier_Control";
            this.Size = new System.Drawing.Size(873, 503);
            this.tbcSupplierInvoices.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tbcSupplierInvoices;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblInvoiceDate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblSupplierControl;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label lnlPaymentTearms;
        private System.Windows.Forms.ComboBox cmbPaymentTerms;
        private System.Windows.Forms.DateTimePicker dtpInvoiceDate;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblInvoiceNumber;
        private System.Windows.Forms.Label lblSupplierName;
        private System.Windows.Forms.TextBox txtInvoiceNumber;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtSupplierName;
        private System.Windows.Forms.Button btnSaveSupplier;
        private System.Windows.Forms.Label lblSupplierInvoices;
        private System.Windows.Forms.Button btnCreateSupplierInvoice;
    }
}
