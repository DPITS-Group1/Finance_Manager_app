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
            this.header = new System.Windows.Forms.Panel();
            this.Heading = new System.Windows.Forms.Label();
            this.NavToggle = new System.Windows.Forms.Button();
            this.SideNavigation = new System.Windows.Forms.Panel();
            this.btnIncome = new System.Windows.Forms.Button();
            this.btnExpenses = new System.Windows.Forms.Button();
            this.btnCustomerInvoice = new System.Windows.Forms.Button();
            this.btnSupplierInvoice = new System.Windows.Forms.Button();
            this.Reports = new System.Windows.Forms.Button();
            this.Dashboard = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.header.SuspendLayout();
            this.SideNavigation.SuspendLayout();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.header.Controls.Add(this.Heading);
            this.header.Controls.Add(this.NavToggle);
            this.header.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.header.Location = new System.Drawing.Point(197, 0);
            this.header.Margin = new System.Windows.Forms.Padding(0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(816, 52);
            this.header.TabIndex = 0;
            // 
            // Heading
            // 
            this.Heading.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.Heading.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Heading.Location = new System.Drawing.Point(78, 7);
            this.Heading.Name = "Heading";
            this.Heading.Size = new System.Drawing.Size(238, 34);
            this.Heading.TabIndex = 1;
            this.Heading.Text = "Finance Manager";
            this.Heading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NavToggle
            // 
            this.NavToggle.BackColor = System.Drawing.SystemColors.Control;
            this.NavToggle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.NavToggle.FlatAppearance.BorderSize = 0;
            this.NavToggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NavToggle.ForeColor = System.Drawing.Color.Transparent;
            this.NavToggle.Image = ((System.Drawing.Image)(resources.GetObject("NavToggle.Image")));
            this.NavToggle.Location = new System.Drawing.Point(13, 7);
            this.NavToggle.Name = "NavToggle";
            this.NavToggle.Size = new System.Drawing.Size(41, 34);
            this.NavToggle.TabIndex = 0;
            this.NavToggle.UseVisualStyleBackColor = false;
            // 
            // SideNavigation
            // 
            this.SideNavigation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SideNavigation.Controls.Add(this.btnIncome);
            this.SideNavigation.Controls.Add(this.btnExpenses);
            this.SideNavigation.Controls.Add(this.btnCustomerInvoice);
            this.SideNavigation.Controls.Add(this.btnSupplierInvoice);
            this.SideNavigation.Controls.Add(this.Reports);
            this.SideNavigation.Controls.Add(this.Dashboard);
            this.SideNavigation.Controls.Add(this.label2);
            this.SideNavigation.Controls.Add(this.label1);
            this.SideNavigation.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SideNavigation.Location = new System.Drawing.Point(-2, -5);
            this.SideNavigation.Margin = new System.Windows.Forms.Padding(0);
            this.SideNavigation.Name = "SideNavigation";
            this.SideNavigation.Size = new System.Drawing.Size(200, 568);
            this.SideNavigation.TabIndex = 1;
            // 
            // btnIncome
            // 
            this.btnIncome.BackColor = System.Drawing.SystemColors.Control;
            this.btnIncome.FlatAppearance.BorderSize = 0;
            this.btnIncome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncome.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnIncome.Image = ((System.Drawing.Image)(resources.GetObject("btnIncome.Image")));
            this.btnIncome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIncome.Location = new System.Drawing.Point(15, 345);
            this.btnIncome.Margin = new System.Windows.Forms.Padding(5);
            this.btnIncome.Name = "btnIncome";
            this.btnIncome.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnIncome.Size = new System.Drawing.Size(168, 28);
            this.btnIncome.TabIndex = 7;
            this.btnIncome.Text = "     Income";
            this.btnIncome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIncome.UseVisualStyleBackColor = false;
            // 
            // btnExpenses
            // 
            this.btnExpenses.BackColor = System.Drawing.SystemColors.Control;
            this.btnExpenses.FlatAppearance.BorderSize = 0;
            this.btnExpenses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExpenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpenses.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnExpenses.Image = ((System.Drawing.Image)(resources.GetObject("btnExpenses.Image")));
            this.btnExpenses.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExpenses.Location = new System.Drawing.Point(15, 307);
            this.btnExpenses.Margin = new System.Windows.Forms.Padding(5);
            this.btnExpenses.Name = "btnExpenses";
            this.btnExpenses.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnExpenses.Size = new System.Drawing.Size(168, 28);
            this.btnExpenses.TabIndex = 6;
            this.btnExpenses.Text = "     Expenses";
            this.btnExpenses.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExpenses.UseVisualStyleBackColor = false;
            // 
            // btnCustomerInvoice
            // 
            this.btnCustomerInvoice.BackColor = System.Drawing.SystemColors.Control;
            this.btnCustomerInvoice.FlatAppearance.BorderSize = 0;
            this.btnCustomerInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomerInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerInvoice.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCustomerInvoice.Image = ((System.Drawing.Image)(resources.GetObject("btnCustomerInvoice.Image")));
            this.btnCustomerInvoice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomerInvoice.Location = new System.Drawing.Point(15, 269);
            this.btnCustomerInvoice.Margin = new System.Windows.Forms.Padding(5);
            this.btnCustomerInvoice.Name = "btnCustomerInvoice";
            this.btnCustomerInvoice.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnCustomerInvoice.Size = new System.Drawing.Size(168, 28);
            this.btnCustomerInvoice.TabIndex = 5;
            this.btnCustomerInvoice.Text = "     Customer Invoices";
            this.btnCustomerInvoice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCustomerInvoice.UseVisualStyleBackColor = false;
            // 
            // btnSupplierInvoice
            // 
            this.btnSupplierInvoice.BackColor = System.Drawing.SystemColors.Control;
            this.btnSupplierInvoice.FlatAppearance.BorderSize = 0;
            this.btnSupplierInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupplierInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupplierInvoice.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSupplierInvoice.Image = ((System.Drawing.Image)(resources.GetObject("btnSupplierInvoice.Image")));
            this.btnSupplierInvoice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSupplierInvoice.Location = new System.Drawing.Point(15, 231);
            this.btnSupplierInvoice.Margin = new System.Windows.Forms.Padding(5);
            this.btnSupplierInvoice.Name = "btnSupplierInvoice";
            this.btnSupplierInvoice.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnSupplierInvoice.Size = new System.Drawing.Size(168, 28);
            this.btnSupplierInvoice.TabIndex = 4;
            this.btnSupplierInvoice.Text = "     Supplier Invoices";
            this.btnSupplierInvoice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSupplierInvoice.UseVisualStyleBackColor = false;
            // 
            // Reports
            // 
            this.Reports.BackColor = System.Drawing.SystemColors.Control;
            this.Reports.FlatAppearance.BorderSize = 0;
            this.Reports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reports.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reports.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Reports.Image = ((System.Drawing.Image)(resources.GetObject("Reports.Image")));
            this.Reports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Reports.Location = new System.Drawing.Point(15, 99);
            this.Reports.Margin = new System.Windows.Forms.Padding(5);
            this.Reports.Name = "Reports";
            this.Reports.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.Reports.Size = new System.Drawing.Size(168, 28);
            this.Reports.TabIndex = 3;
            this.Reports.Text = "     Reports";
            this.Reports.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Reports.UseVisualStyleBackColor = false;
            // 
            // Dashboard
            // 
            this.Dashboard.BackColor = System.Drawing.SystemColors.Control;
            this.Dashboard.FlatAppearance.BorderSize = 0;
            this.Dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Dashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dashboard.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Dashboard.Image = ((System.Drawing.Image)(resources.GetObject("Dashboard.Image")));
            this.Dashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Dashboard.Location = new System.Drawing.Point(15, 61);
            this.Dashboard.Margin = new System.Windows.Forms.Padding(5);
            this.Dashboard.Name = "Dashboard";
            this.Dashboard.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.Dashboard.Size = new System.Drawing.Size(168, 28);
            this.Dashboard.TabIndex = 2;
            this.Dashboard.Text = "     Dashboard";
            this.Dashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Dashboard.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(3, 209);
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
            this.label1.Location = new System.Drawing.Point(3, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Overview";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 561);
            this.Controls.Add(this.SideNavigation);
            this.Controls.Add(this.header);
            this.Name = "Form1";
            this.header.ResumeLayout(false);
            this.SideNavigation.ResumeLayout(false);
            this.SideNavigation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Panel SideNavigation;
        private System.Windows.Forms.Button NavToggle;
        private System.Windows.Forms.Label Heading;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIncome;
        private System.Windows.Forms.Button btnCustomerInvoice;
        private System.Windows.Forms.Button btnSupplierInvoice;
        private System.Windows.Forms.Button Reports;
        private System.Windows.Forms.Button Dashboard;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExpenses;
    }
}

