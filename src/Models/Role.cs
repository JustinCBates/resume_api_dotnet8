using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace resume_api.Models
{
  [Table("roles")]
  public class Role
  {
    [Column("roleid")]
    public int RoleId { get; set; }

    [Column("description")]
    public required string description { get; set; }

    /* EF Relationships */
    public Job Job {get; set;}
  }
}