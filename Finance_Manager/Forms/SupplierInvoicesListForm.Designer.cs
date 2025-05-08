namespace Finance_Manager
{
    partial class SupplierInvoicesListForm
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
            this.dgvInvoices = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.buttonSaveAsPDF = new System.Windows.Forms.Button();
            this.buttonSaveAsCSV = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoices)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvInvoices
            // 
            this.dgvInvoices.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvInvoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoices.Location = new System.Drawing.Point(35, 88);
            this.dgvInvoices.Name = "dgvInvoices";
            this.dgvInvoices.Size = new System.Drawing.Size(753, 324);
            this.dgvInvoices.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(40, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(221, 31);
            this.label6.TabIndex = 14;
            this.label6.Text = "Supplier Invoices";
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(691, 421);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(35, 13);
            this.lblStatus.TabIndex = 15;
            this.lblStatus.Text = "label1";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Location = new System.Drawing.Point(651, 22);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(137, 39);
            this.btnRefresh.TabIndex = 16;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click_1);
            // 
            // buttonSaveAsPDF
            // 
            this.buttonSaveAsPDF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSaveAsPDF.Location = new System.Drawing.Point(497, 22);
            this.buttonSaveAsPDF.Name = "buttonSaveAsPDF";
            this.buttonSaveAsPDF.Size = new System.Drawing.Size(137, 39);
            this.buttonSaveAsPDF.TabIndex = 17;
            this.buttonSaveAsPDF.Text = "Save As PDF";
            this.buttonSaveAsPDF.UseVisualStyleBackColor = true;
            // 
            // buttonSaveAsCSV
            // 
            this.buttonSaveAsCSV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSaveAsCSV.Location = new System.Drawing.Point(339, 22);
            this.buttonSaveAsCSV.Name = "buttonSaveAsCSV";
            this.buttonSaveAsCSV.Size = new System.Drawing.Size(137, 39);
            this.buttonSaveAsCSV.TabIndex = 18;
            this.buttonSaveAsCSV.Text = "Save As CSV";
            this.buttonSaveAsCSV.UseVisualStyleBackColor = true;
            // 
            // SupplierInvoicesListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSaveAsCSV);
            this.Controls.Add(this.buttonSaveAsPDF);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvInvoices);
            this.Name = "SupplierInvoicesListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Supplier Invoices";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoices)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInvoices;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button buttonSaveAsPDF;
        private System.Windows.Forms.Button buttonSaveAsCSV;
    }
}