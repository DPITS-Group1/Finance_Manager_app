using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Finance_Manager.Forms;

namespace Finance_Manager
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Heading.Text = "Dashboard";
            LoadForm(new DashboardForm());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            btnActivePageIndicator.Top = btnDashboard.Top;
            LoadForm(new DashboardForm());
            Heading.Text = "Dashboard";            
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            btnActivePageIndicator.Top = btnReports.Top;
            LoadForm(new ReportsForm());
            Heading.Text = "Reports";
        }

        private void btnSupplierInvoice_Click(object sender, EventArgs e)
        {
            btnActivePageIndicator.Top = btnSupplierInvoice.Top;
            LoadForm(new SupplierInvoicesForm());
            Heading.Text = "Supplier Invoices";
        }

        private void btnCustomerInvoice_Click(object sender, EventArgs e)
        {
            btnActivePageIndicator.Top = btnCustomerInvoice.Top;
            LoadForm(new CustomerInvoicesForm());
            Heading.Text = "Customer Invoices";
        }

        private void btnExpenses_Click(object sender, EventArgs e)
        {
            btnActivePageIndicator.Top = btnExpenses.Top;
            LoadForm(new ExpensesForm());
            Heading.Text = "Expenses";
        }

        private void btnIncome_Click(object sender, EventArgs e)
        {
            btnActivePageIndicator.Top = btnIncome.Top;
            LoadForm(new IncomeForm());
            Heading.Text = "Income";
        }

        public void LoadForm(object Form)
        {
            if (this.ContentPanel.Controls.Count > 0) {
                this.ContentPanel.Controls.Clear(); // is better than Controls.RemoveAt(0)
            }

            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.ContentPanel.Controls.Add(f);
            this.ContentPanel.Tag = f;
            f.Show();
        }       
    }
}
