using System;
using System.Windows.Forms;
using Finance_Manager.Views.Forms;
using Finance_Manager.Views.UserControls;

namespace Finance_Manager
{
    public partial class ReportsUserControl : UserControl
    {
        public ReportsUserControl()
        {
            InitializeComponent();
        }

        private void buttonAllSupplierInvoicesReport_Click(object sender, EventArgs e)        {
          
            ReportViewDialog reportViewDialog = new ReportViewDialog(ReportViewDialog.ReportTypes.SupplierInvoices, "Supplier Invoices Report");
            reportViewDialog.ShowDialog();
        }

        
    }
}
