using System;
using Newtonsoft.Json; // For JsonProperty
using Postgrest.Attributes; // Required for [Table] and [Column] attributes
using Postgrest.Models; // Required for BaseModel

namespace Finance_Manager.Models
{
    // *** ADDED [Table] Attribute ***
    // Maps this C# class to the "supplier_invoices" table in Supabase.
    [Table("supplier_invoices")]
    public class SupplierInvoice : BaseModel // Inherit from BaseModel for Supabase integration
    {
        // Supabase typically uses 'id' as the primary key (int8 or uuid)
        // Use [PrimaryKey] attribute if your key column name is different or composite.
        [PrimaryKey("id", false)] // Specify the column name and if it should be ignored on insert (false means it's included)
        [JsonProperty("id")] // Maps JSON property during serialization
        public Guid Id { get; set; }

        [Column("supplier_name")] // Maps property to the database column
        [JsonProperty("supplier_name")]
        public string SupplierName { get; set; }

        [Column("invoice_number")]
        [JsonProperty("invoice_number")]
        public string InvoiceNumber { get; set; }

        [Column("invoice_date")]
        [JsonProperty("invoice_date")]
        public DateTime InvoiceDate { get; set; }

        [Column("amount")]
        [JsonProperty("amount")]
        public decimal Amount { get; set; }

        [Column("payment_terms")]
        [JsonProperty("payment_terms")]
        public string PaymentTerms { get; set; }

        [Column("status")]
        [JsonProperty("status")]
        public string Status { get; set; }

        // These columns are often managed automatically by Supabase/Postgres
        // Use [Column(ignoreOnInsert: true, ignoreOnUpdate: true)] if needed
        [Column("created_at")]
        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        [Column("updated_at")]
        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; set; }

        // Constructor to set default values
        public SupplierInvoice()
        {
            Id = Guid.NewGuid(); // Generate a new ID client-side
            InvoiceDate = DateTime.SpecifyKind(DateTime.Today, DateTimeKind.Unspecified); // Ensure date kind is appropriate if needed
            // Supabase usually sets created_at/updated_at automatically via triggers
            // You might not need to set them client-side unless required by your setup.
            // CreatedAt = DateTime.UtcNow; // Use UtcNow for consistency
            // UpdatedAt = DateTime.UtcNow;
        }
    }
}
