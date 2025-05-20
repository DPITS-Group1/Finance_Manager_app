using System;
using System.Windows.Forms;
using Finance_Manager.Models;
using Finance_Manager.Repositories;

namespace Finance_Manager
{
    public partial class SupplierInvoicesUserControl : UserControl
    {
        public SupplierInvoicesUserControl()
        {
            InitializeComponent();
        }

        private void SupplierInvoicesUserControl_Load(object sender, EventArgs e)
        {
            //default list for status
            cmbstatus.Items.Add("Pending");
            cmbstatus.Items.Add("Paid");
            cmbstatus.Items.Add("Overdue");



            cmbpaymentterms.Items.Add("Net 15");
            cmbpaymentterms.Items.Add("Net 30");
            cmbpaymentterms.Items.Add("Net 45");
            cmbpaymentterms.Items.Add("Net 60");

            cmbpaymentterms.SelectedIndex = 1;
            cmbstatus.SelectedIndex = 0;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtsuppliername.Text = string.Empty;
            txtinvoicenumber.Text = string.Empty;
            dtpInvoiceDate.Value = DateTime.Today;
            txtamount.Text = string.Empty;
            cmbpaymentterms.SelectedIndex = 0;
            cmbstatus.SelectedIndex = 0;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Step 1: Validate all form fields
                if (string.IsNullOrWhiteSpace(txtsuppliername.Text))
                {
                    MessageBox.Show("Please enter supplier name.", "Required Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtsuppliername.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtinvoicenumber.Text))
                {
                    MessageBox.Show("Please enter invoice number.", "Required Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtinvoicenumber.Focus();
                    return;
                }

                // Check if amount is a valid number
                decimal amount;
                if (!decimal.TryParse(txtamount.Text, out amount))
                {
                    MessageBox.Show("Please enter a valid amount.", "Invalid Amount", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtamount.Focus();
                    return;
                }

                // Make sure a status is selected
                if (cmbstatus.SelectedIndex < 0)
                {
                    MessageBox.Show("Please select a status.", "Required Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbstatus.Focus();
                    return;
                }

                // Make sure payment terms are selected
                if (cmbpaymentterms.SelectedIndex < 0)
                {
                    MessageBox.Show("Please select payment terms.", "Required Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbpaymentterms.Focus();
                    return;
                }

                // Step 2: Show waiting cursor while saving
                this.Cursor = Cursors.WaitCursor;

                // Step 3: Create a new invoice object with form data
                var invoice = new SupplierInvoice
                {
                    // Fill the properties from the form fields
                    SupplierName = txtsuppliername.Text.Trim(),
                    InvoiceNumber = txtinvoicenumber.Text.Trim(),
                    InvoiceDate = dtpInvoiceDate.Value.ToUniversalTime(),
                    Amount = amount,
                    PaymentTerms = cmbpaymentterms.SelectedItem.ToString(),
                    Status = cmbstatus.SelectedItem.ToString()
                };

                // Step 4: Save to Supabase database
                SupplierRepository supplierRepository = new SupplierRepository();
                await supplierRepository.SaveInvoiceAsync(invoice);

                // Step 5: Show success message
                MessageBox.Show("Invoice saved successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Step 6: Clear the form for next entry
                ClearForm();
            }
            catch (Exception ex)
            {
                // If anything goes wrong, show error message
                MessageBox.Show($"Error saving invoice: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Always restore the cursor
                this.Cursor = Cursors.Default;
            }
        }
        private void ClearForm()
        {
            txtsuppliername.Text = string.Empty;
            txtinvoicenumber.Text = string.Empty;
            dtpInvoiceDate.Value = DateTime.Today;
            txtamount.Text = string.Empty;

            // Reset dropdowns to first item if they have items
            if (cmbpaymentterms.Items.Count > 0)
                cmbpaymentterms.SelectedIndex = 0;

            if (cmbstatus.Items.Count > 0)
                cmbstatus.SelectedIndex = 0;
        }
    }
}
