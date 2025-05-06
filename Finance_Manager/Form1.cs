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
            btnActivePageIndicator.Top = btnDashboard.Top;
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            btnActivePageIndicator.Top = btnReports.Top;
        }

        private void btnSupplierInvoice_Click(object sender, EventArgs e)
        {
            btnActivePageIndicator.Top = btnSupplierInvoice.Top;
        }

        private void btnCustomerInvoice_Click(object sender, EventArgs e)
        {
            btnActivePageIndicator.Top = btnCustomerInvoice.Top;
        }

        private void btnExpenses_Click(object sender, EventArgs e)
        {
            btnActivePageIndicator.Top = btnExpenses.Top;
        }

        private void btnIncome_Click(object sender, EventArgs e)
        {
            btnActivePageIndicator.Top = btnIncome.Top;
        }
    }
}
