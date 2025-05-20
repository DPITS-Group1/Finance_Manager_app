using System;
using System.Windows.Forms;
using Finance_Manager.Views.Forms;

namespace Finance_Manager.Views.UserControls
{
    public partial class ReportViewDialog : Form
    {
        public enum ReportTypes
        {
            SupplierInvoices,
            CustomerInvoices,            
        }

        public ReportTypes reportType;
        public string reportName;

        public ReportViewDialog(ReportTypes reportType, string reportName)
        {
            InitializeComponent();
            this.reportType = reportType;
            this.reportName = reportName;
        }

        private void ReportViewDialog_Load(object sender, EventArgs e)
        {
            DateTime financialYearStart = new DateTime(DateTime.Now.Year, 1,1);
            labelReportTitle.Text = reportName;
            dateTimePickerStartDate.MaxDate = DateTime.Today;
            dateTimePickerStartDate.Value = financialYearStart;
            dateTimePickerEndDate.Value = DateTime.Now;
            dateTimePickerEndDate.MaxDate = DateTime.Today;
        }
        
        private void buttonGenerateReport_Click(object sender, EventArgs e)
        {
            DateTime startDate = dateTimePickerStartDate.Value;
            DateTime endDate = dateTimePickerEndDate.Value;
            if (startDate > endDate)
            {
                MessageBox.Show("Start date cannot be greater than end date.", "Invalid Date Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            switch (reportType)
            {
                case ReportTypes.SupplierInvoices:                    
                    SupplierInvoicesReportForm supplierInvoicesReportForm = new SupplierInvoicesReportForm(startDate, endDate);
                    supplierInvoicesReportForm.ShowDialog();
                    this.Close();
                    break;
                case ReportTypes.CustomerInvoices:
                    this.Close();
                    break;
                default:
                    this.Close();
                    break;
            }
        }
    }
}
