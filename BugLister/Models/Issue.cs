using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

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

    // public Type IssueType { get; set; }

    public static List<Issue> Search(List<Issue> allIssues, string searchParam)
    {
      List<Issue> matchingIssues = new List<Issue> { };
      if (searchParam != null)
      {
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
      }
      return matchingIssues;
    }
    public static List<SelectListItem> TypeList()
    {
      List<SelectListItem> items = new List<SelectListItem>();
      items.Add(new SelectListItem { Text = "Critical", Value = "Critical", Selected = true});
      items.Add(new SelectListItem { Text = "Minor", Value = "Minor" });
      items.Add(new SelectListItem { Text = "Suggestion", Value = "Suggestion" });
      return items;
    }
  }
}