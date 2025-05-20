namespace Finance_Manager
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ActivePageIndicator = new System.Windows.Forms.Panel();
            this.buttonExit = new System.Windows.Forms.Button();
            this.Heading = new System.Windows.Forms.Label();
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.btnIncome = new System.Windows.Forms.Button();
            this.btnExpenses = new System.Windows.Forms.Button();
            this.btnCustomerInvoice = new System.Windows.Forms.Button();
            this.btnSupplierInvoice = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelSidebar.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // ActivePageIndicator
            // 
            this.ActivePageIndicator.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ActivePageIndicator.Location = new System.Drawing.Point(15, 55);
            this.ActivePageIndicator.Name = "ActivePageIndicator";
            this.ActivePageIndicator.Size = new System.Drawing.Size(10, 30);
            this.ActivePageIndicator.TabIndex = 2;
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonExit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonExit.BackColor = System.Drawing.Color.GhostWhite;
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonExit.Image = ((System.Drawing.Image)(resources.GetObject("buttonExit.Image")));
            this.buttonExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonExit.Location = new System.Drawing.Point(801, 14);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(5);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.buttonExit.Size = new System.Drawing.Size(43, 34);
            this.buttonExit.TabIndex = 8;
            this.buttonExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // Heading
            // 
            this.Heading.AutoSize = true;
            this.Heading.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.Heading.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Heading.Location = new System.Drawing.Point(24, 16);
            this.Heading.Name = "Heading";
            this.Heading.Size = new System.Drawing.Size(200, 29);
            this.Heading.TabIndex = 1;
            this.Heading.Text = "Finance Manager";
            this.Heading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.GhostWhite;
            this.panelSidebar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSidebar.Controls.Add(this.ActivePageIndicator);
            this.panelSidebar.Controls.Add(this.btnIncome);
            this.panelSidebar.Controls.Add(this.btnExpenses);
            this.panelSidebar.Controls.Add(this.btnCustomerInvoice);
            this.panelSidebar.Controls.Add(this.btnSupplierInvoice);
            this.panelSidebar.Controls.Add(this.btnReports);
            this.panelSidebar.Controls.Add(this.btnDashboard);
            this.panelSidebar.Controls.Add(this.label2);
            this.panelSidebar.Controls.Add(this.label1);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.Margin = new System.Windows.Forms.Padding(0);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(208, 581);
            this.panelSidebar.TabIndex = 1;
            // 
            // btnIncome
            // 
            this.btnIncome.AutoSize = true;
            this.btnIncome.BackColor = System.Drawing.Color.GhostWhite;
            this.btnIncome.FlatAppearance.BorderSize = 0;
            this.btnIncome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncome.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnIncome.Image = ((System.Drawing.Image)(resources.GetObject("btnIncome.Image")));
            this.btnIncome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIncome.Location = new System.Drawing.Point(27, 374);
            this.btnIncome.Margin = new System.Windows.Forms.Padding(5);
            this.btnIncome.Name = "btnIncome";
            this.btnIncome.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnIncome.Size = new System.Drawing.Size(168, 30);
            this.btnIncome.TabIndex = 7;
            this.btnIncome.Text = "     Income";
            this.btnIncome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIncome.UseVisualStyleBackColor = false;
            this.btnIncome.Click += new System.EventHandler(this.btnIncome_Click);
            // 
            // btnExpenses
            // 
            this.btnExpenses.AutoSize = true;
            this.btnExpenses.BackColor = System.Drawing.Color.GhostWhite;
            this.btnExpenses.FlatAppearance.BorderSize = 0;
            this.btnExpenses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExpenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpenses.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnExpenses.Image = ((System.Drawing.Image)(resources.GetObject("btnExpenses.Image")));
            this.btnExpenses.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExpenses.Location = new System.Drawing.Point(27, 324);
            this.btnExpenses.Margin = new System.Windows.Forms.Padding(5);
            this.btnExpenses.Name = "btnExpenses";
            this.btnExpenses.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnExpenses.Size = new System.Drawing.Size(168, 30);
            this.btnExpenses.TabIndex = 6;
            this.btnExpenses.Text = "     Expenses";
            this.btnExpenses.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExpenses.UseVisualStyleBackColor = false;
            this.btnExpenses.Click += new System.EventHandler(this.btnExpenses_Click);
            // 
            // btnCustomerInvoice
            // 
            this.btnCustomerInvoice.AutoSize = true;
            this.btnCustomerInvoice.BackColor = System.Drawing.Color.GhostWhite;
            this.btnCustomerInvoice.FlatAppearance.BorderSize = 0;
            this.btnCustomerInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomerInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerInvoice.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCustomerInvoice.Image = ((System.Drawing.Image)(resources.GetObject("btnCustomerInvoice.Image")));
            this.btnCustomerInvoice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomerInvoice.Location = new System.Drawing.Point(27, 274);
            this.btnCustomerInvoice.Margin = new System.Windows.Forms.Padding(5);
            this.btnCustomerInvoice.Name = "btnCustomerInvoice";
            this.btnCustomerInvoice.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnCustomerInvoice.Size = new System.Drawing.Size(171, 30);
            this.btnCustomerInvoice.TabIndex = 5;
            this.btnCustomerInvoice.Text = "     Customer Invoices";
            this.btnCustomerInvoice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCustomerInvoice.UseVisualStyleBackColor = false;
            this.btnCustomerInvoice.Click += new System.EventHandler(this.btnCustomerInvoice_Click);
            // 
            // btnSupplierInvoice
            // 
            this.btnSupplierInvoice.AutoSize = true;
            this.btnSupplierInvoice.BackColor = System.Drawing.Color.GhostWhite;
            this.btnSupplierInvoice.FlatAppearance.BorderSize = 0;
            this.btnSupplierInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupplierInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupplierInvoice.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSupplierInvoice.Image = ((System.Drawing.Image)(resources.GetObject("btnSupplierInvoice.Image")));
            this.btnSupplierInvoice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSupplierInvoice.Location = new System.Drawing.Point(27, 224);
            this.btnSupplierInvoice.Margin = new System.Windows.Forms.Padding(5);
            this.btnSupplierInvoice.Name = "btnSupplierInvoice";
            this.btnSupplierInvoice.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnSupplierInvoice.Size = new System.Drawing.Size(168, 30);
            this.btnSupplierInvoice.TabIndex = 4;
            this.btnSupplierInvoice.Text = "     Supplier Invoices";
            this.btnSupplierInvoice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSupplierInvoice.UseVisualStyleBackColor = false;
            this.btnSupplierInvoice.Click += new System.EventHandler(this.btnSupplierInvoice_Click);
            // 
            // btnReports
            // 
            this.btnReports.AutoSize = true;
            this.btnReports.BackColor = System.Drawing.Color.GhostWhite;
            this.btnReports.FlatAppearance.BorderSize = 0;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnReports.Image = ((System.Drawing.Image)(resources.GetObject("btnReports.Image")));
            this.btnReports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReports.Location = new System.Drawing.Point(27, 103);
            this.btnReports.Margin = new System.Windows.Forms.Padding(5);
            this.btnReports.Name = "btnReports";
            this.btnReports.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnReports.Size = new System.Drawing.Size(168, 30);
            this.btnReports.TabIndex = 3;
            this.btnReports.Text = "     Reports";
            this.btnReports.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReports.UseVisualStyleBackColor = false;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.AutoSize = true;
            this.btnDashboard.BackColor = System.Drawing.Color.GhostWhite;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Image")));
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(27, 53);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(5);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnDashboard.Size = new System.Drawing.Size(168, 30);
            this.btnDashboard.TabIndex = 2;
            this.btnDashboard.Text = "     Dashboard";
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(15, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Transactions";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(15, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Overview";
            // 
            // panelHeader
            // 
            this.panelHeader.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelHeader.BackColor = System.Drawing.Color.GhostWhite;
            this.panelHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelHeader.Controls.Add(this.buttonExit);
            this.panelHeader.Controls.Add(this.Heading);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(208, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(870, 61);
            this.panelHeader.TabIndex = 2;
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.GhostWhite;
            this.panelContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(208, 61);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(870, 520);
            this.panelContent.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1078, 581);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelSidebar);
            this.MinimumSize = new System.Drawing.Size(1091, 600);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Finance Manager";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelSidebar.ResumeLayout(false);
            this.panelSidebar.PerformLayout();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Label Heading;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIncome;
        private System.Windows.Forms.Button btnCustomerInvoice;
        private System.Windows.Forms.Button btnSupplierInvoice;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExpenses;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Panel ActivePageIndicator;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelContent;
    }
}

