using System.Collections.Generic;

namespace BugLister.Models
{
  public class Link
  {
    public Link()
    {
      this.Issues = new HashSet<Issue>();
    }

    public string Name { get; set; }
    public int LinkId { get; set; }
    public virtual ICollection<Issue> Issues { get; set; }
  }
}