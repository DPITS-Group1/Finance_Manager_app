using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using CsvHelper;
using Finance_Manager.Models;
using Finance_Manager.Repositories;

namespace Finance_Manager.Views.Forms
{
    public partial class SupplierInvoicesReportForm : Form
    {
        private DateTime startDate;
        private DateTime endDate;
        private List<SupplierInvoice> invoices;
        public SupplierInvoicesReportForm(DateTime startDate, DateTime endDate)
        {
            InitializeComponent();
            this.startDate = startDate;
            this.endDate = endDate;           
        }

        private async void SupplierInvoicesReportForm_Load(object sender, EventArgs e)
        {
            // Set up the DataGridView columns when the form loads
            SetupDataGridView();
            await FetchInvoicesAsync();
            LoadDataGridView();
        }

        /// <summary>
        /// Asynchronously fetches invoice data from the Supabase service        
        /// </summary>
        private async Task FetchInvoicesAsync()
        {
            lblStatus.Text = "Loading invoices...";
            this.Cursor = Cursors.WaitCursor;
            dgvInvoices.Enabled = false;
            btnRefresh.Enabled = false;
            buttonDownloadAsCSV.Enabled = false;
            buttonDownloadAsPDF.Enabled = false;

            try
            {
                SupplierRepository supplierRepository = new SupplierRepository();
                invoices = await supplierRepository.GetAllInvoicesAsync(startDate, endDate);
                lblStatus.Text = $"Loaded {invoices.Count} invoices.";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading invoice data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblStatus.Text = "Error loading data.";
                // Clear the grid on error?
                dgvInvoices.DataSource = null;                
            }
            finally
            {
                this.Cursor = Cursors.Default;
                dgvInvoices.Enabled = true;
                btnRefresh.Enabled = true;
                buttonDownloadAsCSV.Enabled = true;
                buttonDownloadAsPDF.Enabled = true;
            }
        }


       
        private void LoadDataGridView()       
        {
            dgvInvoices.DataSource = invoices; // Assign the list directly                        
        }

        /// <summary>
        /// Configures the appearance and columns of the DataGridView.
        /// </summary>
        private void SetupDataGridView()
        {
            // --- Basic Grid Setup ---
            dgvInvoices.ReadOnly = true; // Prevent users from editing cells directly in the grid
            dgvInvoices.AllowUserToAddRows = false; // Don't show the blank row at the bottom for adding new data
            dgvInvoices.AllowUserToDeleteRows = false; // Prevent users from deleting rows
            dgvInvoices.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Make columns automatically fill the grid width
            dgvInvoices.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Select the whole row when a cell is clicked
            dgvInvoices.MultiSelect = false; // Allow selecting only one row at a time
            dgvInvoices.RowHeadersVisible = false; // Hide the empty column on the far left
            // ** Prevent automatic column generation based on DataSource properties **
            dgvInvoices.AutoGenerateColumns = false;


            // --- Define Columns Manually (Good Practice) ---
            // Clear any existing columns
            dgvInvoices.Columns.Clear();

            // --- Add Required Columns ---

            // 1. Supplier Name
            dgvInvoices.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "SupplierNameCol",           // Internal name
                HeaderText = "Supplier",            // Header text
                DataPropertyName = "SupplierName"   // Links to SupplierInvoice.SupplierName
            });

            // 2. Invoice Number
            dgvInvoices.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "InvoiceNumberCol",
                HeaderText = "Invoice #",
                DataPropertyName = "InvoiceNumber" // Links to SupplierInvoice.InvoiceNumber
            });

            // 3. Invoice Date
            dgvInvoices.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "InvoiceDateCol",
                HeaderText = "Date",
                DataPropertyName = "InvoiceDate", // Links to SupplierInvoice.InvoiceDate
                DefaultCellStyle = new DataGridViewCellStyle { Format = "yyyy-MM-dd" } // Format date
            });

            // 4. Amount
            dgvInvoices.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "AmountCol",
                HeaderText = "Amount",
                DataPropertyName = "Amount", // Links to SupplierInvoice.Amount
                DefaultCellStyle = new DataGridViewCellStyle { Format = "C2", Alignment = DataGridViewContentAlignment.MiddleRight, FormatProvider = CultureInfo.GetCultureInfo("en-ZA") } // Format currency

            });

            // 5. Payment Terms  ** (This column was added based on your request) **
            dgvInvoices.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "PaymentTermsCol",
                HeaderText = "Payment Terms",
                DataPropertyName = "PaymentTerms" // Links to SupplierInvoice.PaymentTerms
            });

            // 6. Status
            dgvInvoices.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "StatusCol",
                HeaderText = "Status",
                DataPropertyName = "Status" // Links to SupplierInvoice.Status
            });
        }

        // Event Handler: Runs when the Refresh button is clicked        

        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            // Reload the data when the refresh button is clicked
            await FetchInvoicesAsync();
            LoadDataGridView();
        }

        private void buttonDownloadAsPDF_Click(object sender, EventArgs e)
        {
            MessageBox.Show("PDF download functionality is not yet implemented.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonDownloadAsCSV_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveAsDialog = new SaveFileDialog() { Filter = "CSV|*.csv", ValidateNames = true })
            {
                if (saveAsDialog.ShowDialog() == DialogResult.OK)
                {
                    using (var writer = new StreamWriter(saveAsDialog.FileName))
                    using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
                    {
                        csv.WriteRecords(invoices);
                    }
                }
            }
        }
    }
}
