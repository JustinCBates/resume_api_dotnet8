using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace resume_api.Models
{
  [Table("degrees")]
  [Index(nameof(DegreeId))] 
  public class Degree
  {    
    [Column("degreeid")]    
    [Key]
    public int DegreeId { get; set; }

    [Column("degreetitle")]
    public required string DegreeTitle { get; set; }

    [Column("year")]
    public int? Year { get; set; }

    [Column("gpa")]
    public float? GPA { get; set; }

    /* EF Relations */
    public User User {get;set;}

    public ICollection<Resume> Resumes {get;set;}
  }
}