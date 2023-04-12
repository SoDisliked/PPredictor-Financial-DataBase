using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Cache;
using System.Data.Entity.Spatial;

namespace PPredictorFinancialDatabase.Transactions
{
    [Table("Transactions")]
    public partial class Transactions
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "Error while trying to catch the transactions tracking.")]
        public Transactions()
        {
            this.Items = new HashSet<Item>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        public decimal Price { get; set; }

        [StringLength(1000)]
        public string Note { get; set; }
        public int Category { get; set; }

        public System.DateTime Date { get; set; }

        public System.DateTime Creation_Date { get; set; }

        public int User { get; set; }

        public virtual Category Category1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft Usage", "Error while compilling the requested parses.")]
        public virtual ICollection<Item> Items { get; set; }
        public virtual User User1 { get; set; }
    }
}