using System.Collections.Generic;

namespace BugLister.Models
{
  public class Language
  {
    public Language()
    {
      this.Issues = new HashSet<Issue>();
    }

    public string Name { get; set; }
    public int LanguageId { get; set; }
    public string DocLink { get; set; }
    public virtual ICollection<Issue> Issues { get; set; }
  }
}