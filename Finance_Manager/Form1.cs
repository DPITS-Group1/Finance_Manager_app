using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finance_Manager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ActivePageIndicator.Top = btnDashboard.Top;
            dashboard_Control1.BringToFront();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            ActivePageIndicator.Top = btnReports.Top;
            reports_Control1.BringToFront();
        }

        private void btnSupplierInvoice_Click(object sender, EventArgs e)
        {
            ActivePageIndicator.Top = btnSupplierInvoice.Top;
            supplier_Control1.BringToFront();
        }

        private void btnCustomerInvoice_Click(object sender, EventArgs e)
        {
            ActivePageIndicator.Top = btnCustomerInvoice.Top;
            customerInvoice_Control1.BringToFront();
        }

        private void btnExpenses_Click(object sender, EventArgs e)
        {
            ActivePageIndicator.Top = btnExpenses.Top;
            expenses_Control1.BringToFront();
        }

        private void btnIncome_Click(object sender, EventArgs e)
        {
            ActivePageIndicator.Top = btnIncome.Top;
            income_Control1.BringToFront();
        }

        private void header_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
