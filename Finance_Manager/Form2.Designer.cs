namespace Finance_Manager
{
    partial class Form2
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
            this.btnSave = new System.Windows.Forms.Button();
            this.txtsuppliername = new System.Windows.Forms.TextBox();
            this.txtamount = new System.Windows.Forms.TextBox();
            this.txtinvoicenumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpInvoiceDate = new System.Windows.Forms.DateTimePicker();
            this.cmbpaymentterms = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbstatus = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(631, 399);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(137, 39);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Create Supplier Invoice";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtsuppliername
            // 
            this.txtsuppliername.Location = new System.Drawing.Point(148, 107);
            this.txtsuppliername.Name = "txtsuppliername";
            this.txtsuppliername.Size = new System.Drawing.Size(213, 20);
            this.txtsuppliername.TabIndex = 1;
            // 
            // txtamount
            // 
            this.txtamount.Location = new System.Drawing.Point(148, 190);
            this.txtamount.Name = "txtamount";
            this.txtamount.Size = new System.Drawing.Size(213, 20);
            this.txtamount.TabIndex = 2;
            // 
            // txtinvoicenumber
            // 
            this.txtinvoicenumber.Location = new System.Drawing.Point(555, 103);
            this.txtinvoicenumber.Name = "txtinvoicenumber";
            this.txtinvoicenumber.Size = new System.Drawing.Size(213, 20);
            this.txtinvoicenumber.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Supplier Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(449, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Invoice Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Amount";
            // 
            // dtpInvoiceDate
            // 
            this.dtpInvoiceDate.Location = new System.Drawing.Point(148, 143);
            this.dtpInvoiceDate.Name = "dtpInvoiceDate";
            this.dtpInvoiceDate.Size = new System.Drawing.Size(213, 20);
            this.dtpInvoiceDate.TabIndex = 8;
            // 
            // cmbpaymentterms
            // 
            this.cmbpaymentterms.FormattingEnabled = true;
            this.cmbpaymentterms.Location = new System.Drawing.Point(555, 185);
            this.cmbpaymentterms.Name = "cmbpaymentterms";
            this.cmbpaymentterms.Size = new System.Drawing.Size(213, 21);
            this.cmbpaymentterms.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(449, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Payment Terms";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Status";
            // 
            // cmbstatus
            // 
            this.cmbstatus.FormattingEnabled = true;
            this.cmbstatus.Location = new System.Drawing.Point(148, 248);
            this.cmbstatus.Name = "cmbstatus";
            this.cmbstatus.Size = new System.Drawing.Size(213, 21);
            this.cmbstatus.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(42, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(296, 31);
            this.label6.TabIndex = 13;
            this.label6.Text = "Create Supplier Invoice";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(488, 399);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(137, 39);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Invoice Date";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbstatus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbpaymentterms);
            this.Controls.Add(this.dtpInvoiceDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtinvoicenumber);
            this.Controls.Add(this.txtamount);
            this.Controls.Add(this.txtsuppliername);
            this.Controls.Add(this.btnSave);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create New Supplier";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtsuppliername;
        private System.Windows.Forms.TextBox txtamount;
        private System.Windows.Forms.TextBox txtinvoicenumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpInvoiceDate;
        private System.Windows.Forms.ComboBox cmbpaymentterms;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbstatus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label7;
    }
}