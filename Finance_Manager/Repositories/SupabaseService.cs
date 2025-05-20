using Supabase;


namespace Finance_Manager
{
    /// <summary>
    /// Service class to handle all Supabase database operations.
    /// Includes saving invoices, fetching distinct supplier names, and fetching all invoices.
    /// </summary>
    public class SupabaseService
    {
        // The Supabase client that will handle our API calls
        public Client _supabaseClient;

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
    }
}
