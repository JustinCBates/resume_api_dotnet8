using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace resume_api.Models
{
  [Table("skills")]
  public class Skill
  {
    [Column("skillid")]    
    [Key]
    public int SkillId { get; set; }

    [Column("description")]
    public required string Description { get; set; }

    /* EF Relations */
    public User User {get;set;}
    public Resume Resume {get;set;}
  }
}