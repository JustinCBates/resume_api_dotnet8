using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace resume_api.Models
{
  [Table("links")]
  public class Link
  {
    [Column("linkid")]
    [Key]
    public int LinkId { get; set; }

    [Column("url")]
    public required string URL { get; set; }

    /* EF Relations */
    public User User {get;set;}
    public Resume Resume {get; set;}
  }
}