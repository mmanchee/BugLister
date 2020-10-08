using System.Collections.Generic;

namespace BugLister.Models
{
  public class Project
  {
    public Project()
    {
      this.Issues = new HashSet<Issue>();
    }

    public string Name { get; set; }
    public int ProjectId { get; set; }
    public virtual ICollection<Issue> Issues { get; set; }
  }
}