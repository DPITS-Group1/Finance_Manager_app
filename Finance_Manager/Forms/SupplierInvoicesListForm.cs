using Finance_Manager.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finance_Manager
{
    public partial class SupplierInvoicesListForm : Form
    {

        public SupplierInvoicesListForm()
        {
            InitializeComponent();

        }
        private async void Form3_Load(object sender, EventArgs e)
        {
            // Set up the DataGridView columns when the form loads
            SetupDataGridView();

            // Load the invoice data from the database asynchronously
            await LoadInvoiceDataAsync();
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
                DefaultCellStyle = new DataGridViewCellStyle { Format = "C2", Alignment = DataGridViewContentAlignment.MiddleRight } // Format currency
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


        /// <summary>
        /// Asynchronously fetches invoice data from the Supabase service
        /// and displays it in the DataGridView.
        /// </summary>
        private async Task LoadInvoiceDataAsync()
        {
            // Ensure controls are not null before accessing
            if (lblStatus == null || dgvInvoices == null || btnRefresh == null)
            {
                MessageBox.Show("One or more required controls (lblStatus, dgvInvoices, btnRefresh) are not initialized.", "Initialization Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblStatus.Text = "Loading invoices...";
            this.Cursor = Cursors.WaitCursor;
            dgvInvoices.Enabled = false;
            btnRefresh.Enabled = false;
            buttonSaveAsCSV.Enabled = false;
            buttonSaveAsPDF.Enabled = false;

            try
            {
                List<SupplierInvoice> invoices = await SupabaseService.Instance.GetAllInvoicesAsync();
                // Use BindingList for better update notifications if needed later, otherwise List is fine
                // var bindingList = new BindingList<SupplierInvoice>(invoices);
                // dgvInvoices.DataSource = bindingList;
                dgvInvoices.DataSource = invoices; // Assign the list directly

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
                buttonSaveAsCSV.Enabled = true;
                buttonSaveAsPDF.Enabled = true;
            }
        }

        // Event Handler: Runs when the Refresh button is clicked
       

        private async void btnRefresh_Click_1(object sender, EventArgs e)
        {
            // Reload the data when the refresh button is clicked
            await LoadInvoiceDataAsync();
        }

        //private void btnOpenSupplierForm_Click(object sender, EventArgs e)
        //{
        //    SupplierInvoicesForm supplierForm = new SupplierInvoicesForm();
        //    supplierForm.ShowDialog();
        //}

    
    }
}
