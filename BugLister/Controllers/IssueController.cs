using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using BugLister.Models;
using System.Linq;

namespace BugLister.Controllers
{
  public class IssuesController : Controller
  {
    private readonly BugListerContext _db;

    public IssuesController(BugListerContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Issue> model = _db.Issues.ToList();
      return View(model);
    }
  }
}