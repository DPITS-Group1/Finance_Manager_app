using System;
using System.Windows.Forms;

namespace Finance_Manager
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Heading.Text = "Dashboard";
            LoadUserControl(new DashboardUserControl());
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ActivePageIndicator.Top = btnDashboard.Top;
            Heading.Text = "Dashboard";
            LoadUserControl(new DashboardUserControl());
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            ActivePageIndicator.Top = btnReports.Top;
            Heading.Text = "Reports";
            LoadUserControl(new ReportsUserControl());
        }

        private void btnSupplierInvoice_Click(object sender, EventArgs e)
        {
            ActivePageIndicator.Top = btnSupplierInvoice.Top;
            Heading.Text = "Supplier Invoices";
            LoadUserControl(new SupplierInvoicesUserControl());
        }

        private void btnCustomerInvoice_Click(object sender, EventArgs e)
        {
            ActivePageIndicator.Top = btnCustomerInvoice.Top;
            Heading.Text = "Customer Invoices";
            LoadUserControl(new CustomerInvoicesUserControl());
        }

        private void btnExpenses_Click(object sender, EventArgs e)
        {
            ActivePageIndicator.Top = btnExpenses.Top;
            Heading.Text = "Expenses";
            LoadUserControl(new ExpensesUserControl());
        }

        private void btnIncome_Click(object sender, EventArgs e)
        {
            ActivePageIndicator.Top = btnIncome.Top;
            Heading.Text = "Income";
            LoadUserControl(new IncomeUserControl());
        }       

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void LoadUserControl(UserControl userControl)
        {
            if (this.panelContent.Controls.Count > 0)
            {
                this.panelContent.Controls.Clear();
            }

            this.panelContent.Controls.Add(userControl);
            userControl.Dock = DockStyle.Fill;
            this.panelContent.Tag = userControl;
            userControl.Show();
        }

        
    }
}
