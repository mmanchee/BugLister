using Microsoft.EntityFrameworkCore;

namespace BugLister.Models
{
  public class BugListerContext : DbContext
  {
    public virtual DbSet<Language> Languages { get; set; }
    public DbSet<Issue> Issues { get; set; }
    public virtual DbSet<Project> Projects { get; set; }
    public BugListerContext(DbContextOptions options) : base(options) { }
  }
}