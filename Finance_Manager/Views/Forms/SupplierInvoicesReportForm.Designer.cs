namespace Finance_Manager.Views.Forms
{
    partial class SupplierInvoicesReportForm
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
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvInvoices = new System.Windows.Forms.DataGridView();
            this.buttonDownloadAsPDF = new System.Windows.Forms.Button();
            this.buttonDownloadAsCSV = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoices)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Location = new System.Drawing.Point(691, 21);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(137, 39);
            this.btnRefresh.TabIndex = 21;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(705, 455);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(35, 13);
            this.lblStatus.TabIndex = 20;
            this.lblStatus.Text = "label1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(35, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(221, 31);
            this.label6.TabIndex = 19;
            this.label6.Text = "Supplier Invoices";
            // 
            // dgvInvoices
            // 
            this.dgvInvoices.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvInvoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoices.Location = new System.Drawing.Point(41, 82);
            this.dgvInvoices.Name = "dgvInvoices";
            this.dgvInvoices.Size = new System.Drawing.Size(787, 370);
            this.dgvInvoices.TabIndex = 17;
            // 
            // buttonDownloadAsPDF
            // 
            this.buttonDownloadAsPDF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDownloadAsPDF.Location = new System.Drawing.Point(535, 21);
            this.buttonDownloadAsPDF.Name = "buttonDownloadAsPDF";
            this.buttonDownloadAsPDF.Size = new System.Drawing.Size(137, 39);
            this.buttonDownloadAsPDF.TabIndex = 22;
            this.buttonDownloadAsPDF.Text = "Download As PDF";
            this.buttonDownloadAsPDF.UseVisualStyleBackColor = true;
            this.buttonDownloadAsPDF.Click += new System.EventHandler(this.buttonDownloadAsPDF_Click);
            // 
            // buttonDownloadAsCSV
            // 
            this.buttonDownloadAsCSV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDownloadAsCSV.Location = new System.Drawing.Point(372, 21);
            this.buttonDownloadAsCSV.Name = "buttonDownloadAsCSV";
            this.buttonDownloadAsCSV.Size = new System.Drawing.Size(137, 39);
            this.buttonDownloadAsCSV.TabIndex = 23;
            this.buttonDownloadAsCSV.Text = "Download As CSV";
            this.buttonDownloadAsCSV.UseVisualStyleBackColor = true;
            this.buttonDownloadAsCSV.Click += new System.EventHandler(this.buttonDownloadAsCSV_Click);
            // 
            // SupplierInvoicesReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 481);
            this.Controls.Add(this.buttonDownloadAsCSV);
            this.Controls.Add(this.buttonDownloadAsPDF);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvInvoices);
            this.Name = "SupplierInvoicesReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Supplier Invoices Report";
            this.Load += new System.EventHandler(this.SupplierInvoicesReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoices)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvInvoices;
        private System.Windows.Forms.Button buttonDownloadAsPDF;
        private System.Windows.Forms.Button buttonDownloadAsCSV;
    }
}