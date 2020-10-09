using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using BugLister.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

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

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Language language)
    {
      _db.Languages.Add(language);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      Language thisLanguage = _db.Languages
      .Include(language => language.Issues)
      .FirstOrDefault(languages => languages.LanguageId == id);
      return View(thisLanguage);
    }

    public ActionResult Edit(int id)
    {
      Language thisLanguage = _db.Languages.FirstOrDefault(languages => languages.LanguageId == id);
      return View(thisLanguage);
    }

    [HttpPost]
    public ActionResult Edit(Language language)
    {
      _db.Entry(language).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}