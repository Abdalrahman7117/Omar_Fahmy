using Microsoft.AspNetCore.Mvc;
using Microsoft.Build.Evaluation;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    public class Project1Controller : Controller
    {
        IatsContext context = new IatsContext();
        public IActionResult Index()
        {
            List<Projects> tasks = context.projects.ToList();
            return View(tasks);
        }
     
        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Create(string name , string description , DateTime startdate , DateTime enddate)
        {
            Projects ddd = new Projects()
            {
                Name = name,
                Description = description,
                Startdate = startdate,
                Enddate = enddate

            };
            context.projects.Add(ddd);
            context.SaveChanges();
            return RedirectToAction("Index", "Project1");
        }
        public IActionResult Update(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }
            var o1 = context.projects.FirstOrDefault(t => t.Id == id);
            if (o1 == null)
            {
                return NotFound();
            }
            return View(o1);
        }
        [HttpPost]
        public IActionResult Update(int id, string name, string description, DateTime startdate, DateTime enddate)
        {
            var oop = context.projects.FirstOrDefault(t => t.Id == id);
           oop.Name = name;
            oop.Description = description;
            oop.Startdate = startdate;
            oop.Enddate = enddate;

            context.SaveChanges();
            return RedirectToAction("Index", "Project1");
        }



        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }
            var o1 = context.projects.FirstOrDefault(t => t.Id == id);
            if (o1 == null)
            {
                return NotFound();
            }
            context.projects.Remove(o1);
            context.SaveChanges();
            return RedirectToAction("Index", "Project1");
        }
    }
}
