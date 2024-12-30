using Microsoft.AspNetCore.Mvc;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    public class Tasks1Controller : Controller
    {
        IatsContext context = new IatsContext();
        public IActionResult Index()
        {
            List<Taasks> tasks = context.Taasks.ToList();
            return View(tasks);
        }
        public IActionResult Index1()
        {
            List<Taasks> tasks = context.Taasks.ToList();
            return View(tasks);
        }
        public IActionResult Create()
        {
           
            return View();
        }
        [HttpPost]
        public IActionResult Create(string task_name , string description,string status, string priority)
        {
            Taasks taaskss = new Taasks()
            {
                Task_Name = task_name,
                Description = description,
                status = status,
                priority = priority

            };
            context.Taasks.Add(taaskss);
            context.SaveChanges();
            return RedirectToAction("Index","Tasks1");
        }
        public IActionResult Update(int ? id)
        {
            if (id == null)
            {
                return BadRequest();
            }
            var o1 = context.Taasks.FirstOrDefault(t => t.Id == id);
            if (o1 == null)
            {
                return NotFound();
            }
            return View(o1);
        }
        [HttpPost]
        public IActionResult Update(int id,string task_name, string description, string status, string priority)
        {
            var oop = context.Taasks.FirstOrDefault(t => t.Id == id);
            oop.Task_Name = task_name;
            oop.Description = description;
            oop.status = status;
            oop.priority = priority;
            context.SaveChanges();
            return RedirectToAction("Index","Tasks1");
        }
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }
            var o1 = context.Taasks.FirstOrDefault(t => t.Id == id);
            if (o1 == null)
            {
                return NotFound();
            }
            return View(o1);
        }
        [HttpPost]
        public IActionResult Edit(int id, string status)
        {
            var oop = context.Taasks.FirstOrDefault(t => t.Id == id);
            
            oop.status = status;
           
            context.SaveChanges();
            return RedirectToAction("Index1", "Tasks1");
        }


        public IActionResult Delete(int ? id)
        {
            if (id == null)
            {
                return BadRequest();
            }
            var o1 = context.Taasks.FirstOrDefault(t => t.Id == id);
            if (o1 == null)
            {
                return NotFound();
            }
            context.Taasks.Remove(o1);
            context.SaveChanges();
            return RedirectToAction("Index","Tasks1");
        }


    }
}
