using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace resume_api.Models
{
  [Table("duties")]
  [Index(nameof(DutyId))]  
  public class Duty
  {
    [Column("dutyid")]
    public int DutyId { get; set; }

    [Column("description")]
    public required string Description { get; set; }

    /* EF Relationships */
    public Job Job {get;set;}
  }
}