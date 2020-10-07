namespace BugLister.Models
{
  public class Issue
  {
    public string Title { get; set; }
    public string Type { get; set; }
    public string Description { get; set; }
    public int IssueId { get; set; }
    public string Solution { get; set; }
    public int LanguageId { get; set; }
    public virtual Language Language { get; set; }
  }
  public List<Issue> Search()
  {
    
  }
}