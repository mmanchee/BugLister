using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using BugLister.Models;
using System.Linq;

namespace BugLister.Controllers
{
  public class LanguagesController : Controller
  {
    private readonly BugListerContext _db;

    public LanguagesController(BugListerContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Language> model = _db.Languages.ToList();
      return View(model);
    }
  }
}