using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Finance_Manager.Models;
using Supabase;

namespace Finance_Manager.Repositories
{
    public class SupplierRepository
    {

        private Client supabaseClient;

        public SupplierRepository()
        {
            SupabaseService supabaseService = SupabaseService.Instance;
            supabaseClient = supabaseService._supabaseClient;
        }

        /// <summary>
        /// Saves a new invoice to the Supabase database.
        /// Takes an invoice object and sends it to the 'supplier_invoices' table.
        /// </summary>
        /// <param name="invoice">The SupplierInvoice object to save.</param>
        /// <returns>The saved SupplierInvoice object (might include database-generated values like timestamps).</returns>
        public async Task<SupplierInvoice> SaveInvoiceAsync(SupplierInvoice invoice)
        {
            try
            {
                // Tell Supabase which table we want to work with (using the SupplierInvoice class)
                // and call Insert() to add the new invoice data.
                var response = await supabaseClient
                    .From<SupplierInvoice>() // Maps to the table defined in SupplierInvoice model
                    .Insert(invoice);

                // Check if the database sent back the saved data
                if (response?.Models != null && response.Models.Count > 0)
                {
                    // Return the first item from the response (should be our saved invoice)
                    return response.Models[0];
                }
                else
                {
                    // If we didn't get the saved data back, something might be wrong
                    Console.WriteLine($"Warning: Insert response did not contain the expected model. Response: {response?.Content}");
                    throw new Exception("Failed to save invoice: Did not receive confirmation model from Supabase.");
                }
            }
            catch (Exception ex)
            {
                // If an error occurs during saving, print it to the console for debugging
                Console.WriteLine($"Error saving invoice to Supabase: {ex}");
                // Throw a new, more user-friendly error message
                throw new Exception($"Failed to save invoice. Please check connection and data. Details: {ex.Message}", ex);
            }
        }

        /// <summary>
        /// Fetches a list of distinct supplier names from the supplier_invoices table.
        /// Useful for populating dropdown lists or simple lists.
        /// </summary>
        /// <returns>A list of unique supplier names (strings).</returns>
        public async Task<List<string>> GetDistinctSupplierNamesAsync()
        {
            try
            {
                // Ask Supabase for data from the SupplierInvoice table
                var response = await supabaseClient
                    .From<SupplierInvoice>()
                    // Specify *only* the column we need ('supplier_name')
                    // This helps make the query faster.
                    .Select(x => new object[] { x.SupplierName })
                    .Get(); // Execute the request to get the data

                // Check if the database sent back any data
                if (response?.Models != null)
                {
                    // Process the received data:
                    var distinctNames = response.Models
                                              .Select(m => m.SupplierName) // Get just the name from each invoice object
                                              .Where(name => !string.IsNullOrEmpty(name)) // Ignore any empty names
                                              .Distinct() // Get only unique names (remove duplicates)
                                              .OrderBy(name => name) // Sort the names alphabetically
                                              .ToList(); // Convert the result into a List
                    return distinctNames;
                }
                else
                {
                    // If no data was received, log a warning and return an empty list
                    Console.WriteLine($"Warning: GetDistinctSupplierNamesAsync response did not contain models. Response: {response?.Content}");
                    return new List<string>();
                }
            }
            catch (Exception ex)
            {
                // If an error occurs during fetching, print it to the console
                Console.WriteLine($"Error fetching distinct supplier names: {ex}");
                // Throw a new, more user-friendly error message
                throw new Exception($"Failed to fetch supplier names. Details: {ex.Message}", ex);
            }
        }

        /// <summary>
        /// Fetches all invoices from the Supabase database.
        /// Useful for displaying data in a grid.
        /// </summary>
        /// <returns>A list of all SupplierInvoice objects found in the table.</returns>
        public async Task<List<SupplierInvoice>> GetAllInvoicesAsync(DateTime startDate, DateTime endDate)
        {
            try
            {
                // Ask Supabase for all data (*) from the SupplierInvoice table
                var response = await supabaseClient
                    .From<SupplierInvoice>()
                    .Where(x => x.InvoiceDate >= startDate && x.InvoiceDate <= endDate)
                    // .Select("*") // Select all columns (this is often the default)
                    // You could also specify columns:
                    .Select("id, supplier_name, invoice_number, invoice_date, amount, payment_terms, status")
                    .Get(); // Execute the request

                // Check if the database sent back data
                if (response?.Models != null)
                {
                    // Return the list of invoice objects directly
                    return response.Models;
                }
                else
                {
                    // If no data, log a warning and return an empty list
                    Console.WriteLine($"Warning: GetAllInvoicesAsync response did not contain models. Response: {response?.Content}");
                    return new List<SupplierInvoice>();
                }
            }
            catch (Exception ex)
            {
                // If an error occurs, log it
                Console.WriteLine($"Error fetching all invoices: {ex}");
                // Throw a new error message
                throw new Exception($"Failed to fetch invoices. Details: {ex.Message}", ex);
            }
        }
    }
}
