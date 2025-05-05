using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Make sure you have the Supabase NuGet package installed
// e.g., supabase-community/supabase-csharp
using Supabase;
using Finance_Manager.Models; // Your model namespace

namespace Finance_Manager
{
    /// <summary>
    /// Service class to handle all Supabase database operations
    /// This is a simplified version focused only on saving data
    /// </summary>
    internal class SupabaseService
    {
        // The Supabase client that will handle our API calls
        private Client _supabaseClient;

        // NOTE: Table name is now primarily defined by the [Table] attribute
        // on the SupplierInvoice model. Keep this constant if needed elsewhere.
        private const string TABLE_NAME = "supplier_invoices";

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
                    // Use lazy initialization
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
        /// Sets up the connection to Supabase
        /// </summary>
        private void InitializeClient()
        {
            // IMPORTANT: Replace these with your actual Supabase URL and Key
            // It's highly recommended to load these from a configuration file
            // or environment variables instead of hardcoding them.
            string supabaseUrl = "https://fafuehauxhlpxnxbjukm.supabase.co";  // Your Supabase URL
            string supabaseKey = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6ImZhZnVlaGF1eGhscHhueGJqdWttIiwicm9sZSI6ImFub24iLCJpYXQiOjE3NDM2NjkwNjIsImV4cCI6MjA1OTI0NTA2Mn0.OeyUxFTKiGR7Cla8B1IYKQ70QDCroro1Gv9e850bqo0"; // Your public anon key

            // Optional Supabase client options (e.g., schema)
            var options = new Supabase.SupabaseOptions
            {
                // AutoRefreshToken = true,
                // AutoConnectRealtime = true,
                // Schema = "public" // Default is public
            };

            // Create the client that will connect to Supabase
            // Use Supabase.Client.InitializeAsync for proper async initialization if available/needed
            // For basic setup, the constructor is often sufficient.
            _supabaseClient = new Client(supabaseUrl, supabaseKey, options);

            // If using an older version or needing explicit initialization:
            // await Supabase.Client.InitializeAsync(supabaseUrl, supabaseKey, options);
            // _supabaseClient = Supabase.Client.Instance; // Access the singleton instance
        }

        /// <summary>
        /// Saves a new invoice to the Supabase database
        /// </summary>
        /// <param name="invoice">The invoice to save</param>
        /// <returns>The saved invoice with any server-updated fields</returns>
        public async Task<SupplierInvoice> SaveInvoiceAsync(SupplierInvoice invoice)
        {
            try
            {
                // *** CORRECTED LINE ***
                // Use From<T>() where T is your model class.
                // The table name is specified via the [Table] attribute on the model.
                var response = await _supabaseClient
                    .From<SupplierInvoice>() // Specify the model type mapping to the table
                    .Insert(invoice);

                // Check if the response contains models and return the first one
                if (response?.Models != null && response.Models.Count > 0)
                {
                    return response.Models[0];
                }
                else
                {
                    // Handle cases where the insert might succeed but doesn't return the model,
                    // or if the response format is different than expected.
                    // Returning the original invoice or null might be options.
                    // Log the response content for debugging if needed.
                    Console.WriteLine($"Warning: Insert response did not contain the expected model. Response: {response?.Content}");
                    // Depending on requirements, you might return the input invoice
                    // or throw a more specific exception.
                    // For now, let's assume success if no exception was thrown and return input.
                    // return invoice;
                    // Or throw if a returned model is strictly required:
                    throw new Exception("Failed to save invoice: Did not receive confirmation model from Supabase.");
                }
            }
            catch (Exception ex)
            {
                // Log the detailed exception
                Console.WriteLine($"Error saving invoice to Supabase: {ex}");

                // Rethrow a more specific or user-friendly exception
                throw new Exception($"Failed to save invoice. Please check connection and data. Details: {ex.Message}", ex);
            }
        }
    }
}
