using resume_api.Models;
using Microsoft.EntityFrameworkCore;

namespace resume_api.DataContext
{
  public class ResumeContext : DbContext
  {
    public ResumeContext(DbContextOptions<ResumeContext> options) : base(options)
    {
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);    
        // Fluent API Configuration
        
        /* Primary Keys */
        modelBuilder.Entity<User>()
        .HasKey(a => a.UserId);

        modelBuilder.Entity<Address>()       
        .HasKey(a => a.AddressId);

        modelBuilder.Entity<Award>()       
        .HasKey(a => a.AwardId);

        modelBuilder.Entity<Certification>()       
        .HasKey(a => a.CertificationId);

        modelBuilder.Entity<Degree>()       
        .HasKey(a => a.DegreeId);

        modelBuilder.Entity<Duty>()       
        .HasKey(a => a.DutyId);

        modelBuilder.Entity<Job>()       
        .HasKey(a => a.JobId);

        modelBuilder.Entity<Role>()       
        .HasKey(a => a.RoleId);

        modelBuilder.Entity<Skill>()       
        .HasKey(a => a.SkillId);

        modelBuilder.Entity<Role>()       
        .HasKey(a => a.RoleId);        

        modelBuilder.Entity<Resume>()       
        .HasKey(a => a.ResumeId);        


        /* User Relationships */
        modelBuilder.Entity<User>()
        .HasMany(a=>a.Resumes)
        .WithOne(b => b.User);

        modelBuilder.Entity<User>()
        .HasMany(a=>a.Addresses)
        .WithOne(b => b.User);

        modelBuilder.Entity<User>()
        .HasMany(a=>a.Links)
        .WithOne(b => b.User);

        modelBuilder.Entity<User>()
        .HasMany(a=>a.Jobs)
        .WithOne(b => b.User);

        modelBuilder.Entity<User>()
        .HasMany(a=>a.Degrees)
        .WithOne(b => b.User);

        modelBuilder.Entity<User>()
        .HasMany(a=>a.Certifications)
        .WithOne(b => b.User);

        modelBuilder.Entity<User>()
        .HasMany(a=>a.Awards)
        .WithOne(b => b.User);

        modelBuilder.Entity<User>()
        .HasMany(a=>a.Skills)
        .WithOne(b => b.User);

        /* Resume Relationships */
        modelBuilder.Entity<Resume>()
        .HasOne(a=>a.User);

        modelBuilder.Entity<Resume>()
        .HasMany(a=>a.Addresses);

        modelBuilder.Entity<Resume>()
        .HasMany(a=>a.Links);

        modelBuilder.Entity<Resume>()
        .HasMany(a=>a.Jobs);

        modelBuilder.Entity<Resume>()
        .HasMany(a=>a.Degrees);

        modelBuilder.Entity<Resume>()
        .HasMany(a=>a.Certifications);

        modelBuilder.Entity<Resume>()
        .HasMany(a=>a.Awards);

        modelBuilder.Entity<Resume>()
        .HasMany(a=>a.Skills);

        /* Job Relationships*/
        modelBuilder.Entity<Job>()
        .HasOne(a=>a.User);

        modelBuilder.Entity<Job>()
        .HasMany(a=>a.Roles)
        .WithOne(b=>b.Job);

        modelBuilder.Entity<Job>()
        .HasMany(a=>a.Duties)
        .WithOne(b=>b.Job);

        /* Degree Relationships*/
        modelBuilder.Entity<Degree>()
        .HasOne(a=>a.User)
        .WithMany(b=>b.Degrees)
        .IsRequired();

        /* Certification Relationships*/
        modelBuilder.Entity<Certification>()
        .HasOne(a=>a.User)
        .WithMany(b=>b.Certifications)
        .IsRequired();

        /* Awards Relationships*/
        modelBuilder.Entity<Award>()
        .HasOne(a=>a.User)
        .WithMany(b=>b.Awards)
        .IsRequired();

        /* Address Relationships*/
        modelBuilder.Entity<Address>()
        .HasOne(a=>a.User)
        .WithMany(b=>b.Addresses)
        .IsRequired();

        /* Skill Relationships*/
        modelBuilder.Entity<Skill>()
        .HasOne(a=>a.User)
        .WithMany(b=>b.Skills)
        .IsRequired();

        /* Role Relationships*/
        modelBuilder.Entity<Role>()
        .HasOne(a=>a.Job)
        .WithMany(b=>b.Roles)
        .IsRequired();

        /* Duty Relationships*/
        modelBuilder.Entity<Duty>()
        .HasOne(a=>a.Job)
        .WithMany(b=>b.Duties)
        .IsRequired();

        

        


    }

    public DbSet<User> Users { get; set; }
    public DbSet<Job> Jobs { get; set; }
    public DbSet<Duty> Duties { get; set; }
    public DbSet<Degree> Degrees { get; set; }
    public DbSet<Certification> Certifications { get; set; }    
    public DbSet<Award> Awards { get; set; }
    public DbSet<Role> Roles { get; set; }    
    public DbSet<Link> Links { get; set; }
    public DbSet<Skill> Skills { get; set; }
    
  }
}