using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace resume_api.Models
{
  [Table("users")]
  public class User
  {
    [Column("userid")]
    public int UserId { get; set; }

    [Column("firstname")]
    public required string FirstName { get; set; }

    [Column("middlename")]
    public string? MiddleName { get; set; }

    [Column("lastname")]
    public required string LastName { get; set; }    

    /* EF Relations */
    public ICollection<Resume>? Resumes { get; set; }

    public ICollection<Link>? Links { get; set; }

    public ICollection<Address>? Addresses { get; set; }

    public ICollection<Job>? Jobs { get; set; }

    public ICollection<Degree>? Degrees { get; set; }

    public ICollection<Certification>? Certifications { get; set; }

    public ICollection<Award>? Awards { get; set; }

    public ICollection<Skill>? Skills { get; set; }
  }
}