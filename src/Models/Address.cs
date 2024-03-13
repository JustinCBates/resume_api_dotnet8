using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace resume_api.Models
{
  [Table("addresses")]
  public class Address
  {
    [Column("addressid")]
    public int AddressId { get; set; }

    [Column("email")]
    public string? Email { get; set; }

    [Column("phone")]
    public string? Phone { get; set; }

    [Column("street")]
    public string? Street { get; set; }

    [Column("city")]
    public string? City { get; set; }

    [Column("state")]
    public string? State { get; set; }

    [Column("zip")]
    public int? Zip { get; set; }

    /* EF Relations */    
    public User User { get; set; }
    
    public ICollection<Resume> Resumes {get;set;}
  }
}