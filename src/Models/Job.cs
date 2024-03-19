using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace resume_api.Models
{
  [Table("jobs")]
  public class Job
  {
    [Column("jobid")]
    public int JobId { get; set; }
    
    [Column("organizationname")]
    public required string OrganizationName { get; set; }

    [Column("location")]
    public string? Location { get; set; }

    [Column("jobtitle")]
    public string? JobTitle { get; set; }

    [Column("startyear")]
    public int StartYear { get; set; }

    [Column("startmonth")]
    public int StartMonth { get; set; }

    [Column("endyear")]
    public int? EndYear { get; set; }

    [Column("endmonth")]
    public int? EndMonth { get; set; }

    /* EF Relationships */
    public User User { get; set; }
    public ICollection<Resume>? Resumes { get; set; }
    public ICollection<Role>? Roles { get; set; }
    public ICollection<Duty>? Duties { get; set; }
  }
}