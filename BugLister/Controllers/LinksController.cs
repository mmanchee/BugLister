// using System.Collections.Generic;
// using Microsoft.AspNetCore.Mvc;
// using BugLister.Models;
// using System.Linq;
// using Microsoft.EntityFrameworkCore;
// using Microsoft.AspNetCore.Mvc.Rendering;

// namespace BugLister.Controllers
// {
//   public class LinksController : Controller
//   {
//     private readonly BugListerContext _db;

//     public LinksController(BugListerContext db)
//     {
//       _db = db;
//     }
//     public ActionResult Index()
//     {
//       List<Link> model = _db.Links.Include(Links => Links.Language).ToList();
//       return View(model);
//     }
//     public ActionResult Create()
//     {
//       ViewBag.LanguageId = new SelectList(_db.Languages, "LanguageId", "Name");
//       ViewBag.Type = Link.TypeList();
//       return View();
//     }
//     [HttpPost]
//     public ActionResult Create(Link Link)
//     {
//       _db.Links.Add(Link);
//       _db.SaveChanges();
//       return RedirectToAction("Index");
//     }
//     public ActionResult Details(int id)
//     {
//       Link thisLink = _db.Links.FirstOrDefault(Links => Links.LinkId == id);
//       ViewBag.Name = _db.Languages.FirstOrDefault(languages => languages.LanguageId == thisLink.LanguageId);
//       return View(thisLink);
//     }
//     public ActionResult Edit(int id)
//     {
//       var thisLink = _db.Links.FirstOrDefault(Links => Links.LinkId == id);
//       ViewBag.LanguageId = new SelectList(_db.Languages, "LanguageId", "Name");
//       ViewBag.Type = Link.TypeList();
//       return View(thisLink);
//     }
//     [HttpPost]
//     public ActionResult Edit(Link Link)
//     {
//       _db.Entry(Link).State = EntityState.Modified;
//       _db.SaveChanges();
//       return RedirectToAction("Index");
//     }
//     public ActionResult Search(string search)
//     {
//       List<Link> searchList = _db.Links.Include(Links => Links.Language).ToList();
//       List<Link> model = Link.Search(searchList, search);
//       return View(model);
//     }
//   }
// }
