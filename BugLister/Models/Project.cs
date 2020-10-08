using System.Collections.Generic;

namespace BugLister.Models
{
  public class Project
  {
    public Project()
    {
      this.Issues = new HashSet<Issue>();
    }

    public string ProjectName { get; set; }
    public int ProjectId { get; set; }
    public string Description { get; set; }
    public string Link { get; set; }
    public virtual ICollection<Issue> Issues { get; set; }
  }
}