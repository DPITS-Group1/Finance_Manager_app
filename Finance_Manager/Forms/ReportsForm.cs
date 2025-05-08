using System;
using System.Windows.Forms;

namespace Finance_Manager.Forms
{
    public partial class ReportsForm : Form
    {
        public ReportsForm()
        {
            InitializeComponent();
        }

        private void buttonAllSupplierInvoicesReport_Click(object sender, EventArgs e)
        {
            SupplierInvoicesListForm supplierInvoicesListForm = new SupplierInvoicesListForm();
            supplierInvoicesListForm.ShowDialog();
        }
    }
}
