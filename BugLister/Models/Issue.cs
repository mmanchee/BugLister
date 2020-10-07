using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

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
    private BugListerContext _db;

    public static List<Issue> Search(List<Issue> allIssues, string searchParam)
    {
      List<Issue> matchingIssues = new List<Issue> { };
      foreach (Issue issue in allIssues)
      {
        if (issue.Title.ToUpper().Contains(searchParam.ToUpper()))
        {
          matchingIssues.Add(issue);
        }
        else if (issue.Description.ToUpper().Contains(searchParam.ToUpper()))
        {
          matchingIssues.Add(issue);
        }
      }
      return matchingIssues;
    }
  }
}