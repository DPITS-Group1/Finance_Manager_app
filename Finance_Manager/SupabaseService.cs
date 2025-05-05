using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supabase;

using Finance_Manager.Models; // Your model namespace
using Postgrest.Attributes; // Required for Table attribute if you define it here too

namespace Finance_Manager
{
    /// <summary>
    /// Service class to handle all Supabase database operations.
    /// Includes saving invoices, fetching distinct supplier names, and fetching all invoices.
    /// </summary>
    internal class SupabaseService
    {
        // The Supabase client that will handle our API calls
        private Client _supabaseClient;

        // Singleton pattern - ensures we only create one instance of this service
        private static SupabaseService _instance;
        private static readonly object _lock = new object();

        // Public property to access the singleton instance
        public static SupabaseService Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new SupabaseService();
                    }
                    return _instance;
                }
            }
        }

        // Private constructor - can only be called from within this class
        private SupabaseService()
        {
            InitializeClient();
        }

        /// <summary>
        /// Sets up the connection to Supabase.
        /// Reads the URL and Key needed to connect.
        /// </summary>
        private void InitializeClient()
        {
            // IMPORTANT: Load these from a secure configuration source in a real app
            string supabaseUrl = "https://fafuehauxhlpxnxbjukm.supabase.co";  // Your Supabase URL
            string supabaseKey = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6ImZhZnVlaGF1eGhscHhueGJqdWttIiwicm9sZSI6ImFub24iLCJpYXQiOjE3NDM2NjkwNjIsImV4cCI6MjA1OTI0NTA2Mn0.OeyUxFTKiGR7Cla8B1IYKQ70QDCroro1Gv9e850bqo0"; // Your public anon key

            // Optional settings for the connection
            var options = new Supabase.SupabaseOptions
            {
                // AutoRefreshToken = true, // Keep the connection alive automatically
                // AutoConnectRealtime = true, // Connect to real-time updates if needed
                Schema = "public" // The database schema to use (usually "public")
            };

            // Create the Supabase client object using the URL, Key, and options
            _supabaseClient = new Client(supabaseUrl, supabaseKey, options);
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
                var response = await _supabaseClient
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
                var response = await _supabaseClient
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
        public async Task<List<SupplierInvoice>> GetAllInvoicesAsync()
        {
            try
            {
                // Ask Supabase for all data (*) from the SupplierInvoice table
                var response = await _supabaseClient
                    .From<SupplierInvoice>()
                    // .Select("*") // Select all columns (this is often the default)
                    // You could also specify columns: .Select("id, supplier_name, invoice_number, invoice_date, amount, status")
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
