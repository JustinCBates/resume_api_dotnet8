using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace resume_api.Models
{
  [Table("resumes")]
  public class Resume
  {
    [Column("resumeid")]
    public required int ResumeId { get; set; }

    [Column("description")]
    public string? description { get; set; }

    /* EF Relations */    
    public User User { get; set; }

    public ICollection<Address>? Addresses { get; set; }

    public ICollection<Link>? Links { get; set; }
    
    public ICollection<Job>? Jobs { get; set; }
    
    public ICollection<Degree>? Degrees { get; set; }
    
    public ICollection<Certification>? Certifications { get; set; }

    public ICollection<Award>? Awards { get; set; }

    public ICollection<Skill>? Skills { get; set; }
  }
}