namespace Finance_Manager
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ActivePageIndicator = new System.Windows.Forms.Panel();
            this.header = new System.Windows.Forms.Panel();
            this.btnpower = new System.Windows.Forms.Button();
            this.Heading = new System.Windows.Forms.Label();
            this.SideNavigation = new System.Windows.Forms.Panel();
            this.btnIncome = new System.Windows.Forms.Button();
            this.btnExpenses = new System.Windows.Forms.Button();
            this.btnCustomerInvoice = new System.Windows.Forms.Button();
            this.btnSupplierInvoice = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.income_Control1 = new Finance_Manager.Income_Control();
            this.expenses_Control1 = new Finance_Manager.Expenses_Control();
            this.customerInvoice_Control1 = new Finance_Manager.CustomerInvoice_Control();
            this.supplier_Control1 = new Finance_Manager.Supplier_Control();
            this.reports_Control1 = new Finance_Manager.Reports_Control();
            this.dashboard_Control1 = new Finance_Manager.Dashboard_Control();
            this.header.SuspendLayout();
            this.SideNavigation.SuspendLayout();
            this.SuspendLayout();
            // 
            // ActivePageIndicator
            // 
            this.ActivePageIndicator.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ActivePageIndicator.Location = new System.Drawing.Point(15, 62);
            this.ActivePageIndicator.Name = "ActivePageIndicator";
            this.ActivePageIndicator.Size = new System.Drawing.Size(10, 30);
            this.ActivePageIndicator.TabIndex = 2;
            // 
            // header
            // 
            this.header.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.header.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.header.BackColor = System.Drawing.Color.GhostWhite;
            this.header.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.header.Controls.Add(this.btnpower);
            this.header.Controls.Add(this.Heading);
            this.header.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.header.Location = new System.Drawing.Point(202, -1);
            this.header.Margin = new System.Windows.Forms.Padding(0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(876, 68);
            this.header.TabIndex = 0;
            this.header.Paint += new System.Windows.Forms.PaintEventHandler(this.header_Paint);
            // 
            // btnpower
            // 
            this.btnpower.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnpower.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnpower.BackColor = System.Drawing.Color.GhostWhite;
            this.btnpower.FlatAppearance.BorderSize = 0;
            this.btnpower.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpower.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpower.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnpower.Image = ((System.Drawing.Image)(resources.GetObject("btnpower.Image")));
            this.btnpower.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnpower.Location = new System.Drawing.Point(818, 17);
            this.btnpower.Margin = new System.Windows.Forms.Padding(5);
            this.btnpower.Name = "btnpower";
            this.btnpower.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnpower.Size = new System.Drawing.Size(43, 34);
            this.btnpower.TabIndex = 8;
            this.btnpower.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnpower.UseVisualStyleBackColor = false;
            this.btnpower.Click += new System.EventHandler(this.button1_Click);
            // 
            // Heading
            // 
            this.Heading.AutoSize = true;
            this.Heading.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.Heading.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Heading.Location = new System.Drawing.Point(87, 17);
            this.Heading.Name = "Heading";
            this.Heading.Size = new System.Drawing.Size(200, 29);
            this.Heading.TabIndex = 1;
            this.Heading.Text = "Finance Manager";
            this.Heading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SideNavigation
            // 
            this.SideNavigation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.SideNavigation.BackColor = System.Drawing.Color.GhostWhite;
            this.SideNavigation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SideNavigation.Controls.Add(this.ActivePageIndicator);
            this.SideNavigation.Controls.Add(this.btnIncome);
            this.SideNavigation.Controls.Add(this.btnExpenses);
            this.SideNavigation.Controls.Add(this.btnCustomerInvoice);
            this.SideNavigation.Controls.Add(this.btnSupplierInvoice);
            this.SideNavigation.Controls.Add(this.btnReports);
            this.SideNavigation.Controls.Add(this.btnDashboard);
            this.SideNavigation.Controls.Add(this.label2);
            this.SideNavigation.Controls.Add(this.label1);
            this.SideNavigation.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SideNavigation.Location = new System.Drawing.Point(-4, -1);
            this.SideNavigation.Margin = new System.Windows.Forms.Padding(0);
            this.SideNavigation.Name = "SideNavigation";
            this.SideNavigation.Size = new System.Drawing.Size(208, 577);
            this.SideNavigation.TabIndex = 1;
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
            this.btnIncome.Location = new System.Drawing.Point(27, 381);
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
            this.btnExpenses.Location = new System.Drawing.Point(27, 331);
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
            this.btnCustomerInvoice.Location = new System.Drawing.Point(27, 281);
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
            this.btnSupplierInvoice.Location = new System.Drawing.Point(27, 231);
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
            this.btnReports.Location = new System.Drawing.Point(27, 110);
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
            this.btnDashboard.Location = new System.Drawing.Point(27, 60);
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
            this.label2.Location = new System.Drawing.Point(15, 209);
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
            this.label1.Location = new System.Drawing.Point(15, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Overview";
            // 
            // income_Control1
            // 
            this.income_Control1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.income_Control1.Location = new System.Drawing.Point(206, 68);
            this.income_Control1.Margin = new System.Windows.Forms.Padding(6);
            this.income_Control1.Name = "income_Control1";
            this.income_Control1.Size = new System.Drawing.Size(873, 503);
            this.income_Control1.TabIndex = 2;
            // 
            // expenses_Control1
            // 
            this.expenses_Control1.Location = new System.Drawing.Point(205, 68);
            this.expenses_Control1.Name = "expenses_Control1";
            this.expenses_Control1.Size = new System.Drawing.Size(873, 503);
            this.expenses_Control1.TabIndex = 3;
            // 
            // customerInvoice_Control1
            // 
            this.customerInvoice_Control1.Location = new System.Drawing.Point(204, 68);
            this.customerInvoice_Control1.Name = "customerInvoice_Control1";
            this.customerInvoice_Control1.Size = new System.Drawing.Size(873, 503);
            this.customerInvoice_Control1.TabIndex = 4;
            // 
            // supplier_Control1
            // 
            this.supplier_Control1.Location = new System.Drawing.Point(205, 68);
            this.supplier_Control1.Name = "supplier_Control1";
            this.supplier_Control1.Size = new System.Drawing.Size(873, 503);
            this.supplier_Control1.TabIndex = 5;
            // 
            // reports_Control1
            // 
            this.reports_Control1.Location = new System.Drawing.Point(204, 69);
            this.reports_Control1.Name = "reports_Control1";
            this.reports_Control1.Size = new System.Drawing.Size(873, 503);
            this.reports_Control1.TabIndex = 6;
            // 
            // dashboard_Control1
            //             this.dashboard_Control1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dashboard_Control1.Location = new System.Drawing.Point(205, 68);
            this.dashboard_Control1.Name = "dashboard_Control1";
            this.dashboard_Control1.Size = new System.Drawing.Size(873, 503);
            this.dashboard_Control1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1078, 572);
            this.Controls.Add(this.dashboard_Control1);
            this.Controls.Add(this.reports_Control1);
            this.Controls.Add(this.supplier_Control1);
            this.Controls.Add(this.customerInvoice_Control1);
            this.Controls.Add(this.expenses_Control1);
            this.Controls.Add(this.income_Control1);
            this.Controls.Add(this.SideNavigation);
            this.Controls.Add(this.header);
            this.MinimumSize = new System.Drawing.Size(1091, 600);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            this.SideNavigation.ResumeLayout(false);
            this.SideNavigation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Panel SideNavigation;
        private System.Windows.Forms.Label Heading;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIncome;
        private System.Windows.Forms.Button btnCustomerInvoice;
        private System.Windows.Forms.Button btnSupplierInvoice;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExpenses;
        private System.Windows.Forms.Button btnpower;
        private System.Windows.Forms.Panel ActivePageIndicator;
        private Income_Control income_Control1;
        private Expenses_Control expenses_Control1;
        private CustomerInvoice_Control customerInvoice_Control1;
        private Supplier_Control supplier_Control1;
        private Reports_Control reports_Control1;
        private Dashboard_Control dashboard_Control1;
    }
}

