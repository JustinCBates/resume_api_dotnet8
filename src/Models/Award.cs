using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace resume_api.Models
{
  [Table("awards")]
  public class Award
  {
    [Column("awardid")]
    public int AwardId { get; set; }

    [Column("awardtitle")]
    public required string AwardTitle { get; set; }

    [Column("awardingbody")]
    public string? AwardingBody { get; set; }

    [Column("year")]
    public int? Year { get; set; }

    [Column("month")]
    public int? Month { get; set; }

    /* EF Relations */
    public User User {get;set;}
    
    public ICollection<Resume> Resumes {get;set;}
  }
}