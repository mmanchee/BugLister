using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using BugLister.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BugLister.Controllers
{
  public class ProjectsController : Controller
  {
    private readonly BugListerContext _db;

    public ProjectsController(BugListerContext db)
    {
      _db = db;
    }
    public ActionResult Index()
    {
      List<Project> model = _db.Projects.ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Project project)
    {
      _db.Projects.Add(project);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      Project thisProject = _db.Projects
      .Include(project => project.Issues)
      .FirstOrDefault(projects => projects.ProjectId == id);
      return View(thisProject);
    }

    public ActionResult Edit(int id)
    {
      Project thisProject = _db.Projects.FirstOrDefault(projects => projects.ProjectId == id);
      return View(thisProject);
    }

    [HttpPost]
    public ActionResult Edit(Project project)
    {
      _db.Entry(project).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Delete(int id)
    {
      Project thisProject = _db.Projects.FirstOrDefault(projects => projects.ProjectId == id);
      return View(thisProject);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      Project thisProject = _db.Projects.FirstOrDefault(projects => projects.ProjectId == id);
      _db.Projects.Remove(thisProject);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}
