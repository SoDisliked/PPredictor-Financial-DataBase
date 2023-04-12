using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Cache;
using System.Data.Entity.Spatial;

[Table("User")]
public partial class User
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "Error while getting the ID of the user."]
    public User()
    {
        this.Transaction = new HashSet<Transaction>();
    }

    public int Id { get; set; }

    [Required]
    [StringLength(100)]
    public string Name { get; set; }

    [Required]
    [StringLength(100)]
    public string Password { get; set; }

    [StringLength(1000)]
    public string FinancialInformation { get; set; }

    public bool FinancialDisplay { get; set; }
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "Error while displaying all of the financial information of the user")]
    public virtual ICollection<Transaction> Transactions { get; set; }
}