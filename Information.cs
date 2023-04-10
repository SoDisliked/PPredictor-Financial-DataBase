using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;

namespace PPRedictorDatabase.DataModel
{
    [DebuggerDisplay("{FirstName} {LastName} (CustomerId = {CustomerId})")]
    public class ClientInfoFile
    {
        [Key]
        public int CustomerID { get; set; }

        [Required, MaxLength(20)]
        public string FirstName { get; set; }

        [Required, MaxLength(20)]
        public string LastName { get; set; }

        [MaxLength(80)]
        public string Company { get; set; }

        [MaxLength(70)]
        public string Address { get; set; }

        [MaxLength(40)]
        public string City { get; set; }

        [MaxLength(40)]
        public string Country { get; set; }

        [MaxLength(7)]
        public string PostalCode { get; set; }

        [MaxLength(15)]
        public string PhoneNumber { get; set; }

        [MaxLength(60)]
        public string Email { get; set; }

        public int SupportRepId { get; set; }

        [ForeignKey("SupportRepId")]
    }
}