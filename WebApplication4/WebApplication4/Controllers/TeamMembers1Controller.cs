using Microsoft.AspNetCore.Mvc;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    public class TeamMembers1Controller : Controller
    {
        IatsContext context = new IatsContext();
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(TeamMembers teamMembers)
        {
            var acc = context.teamMembers.FirstOrDefault(u => u.Name == teamMembers.Name && u.Email == teamMembers.Email && u.Role == "Manage");
            var acc1 = context.teamMembers.FirstOrDefault(u => u.Name == teamMembers.Name && u.Email == teamMembers.Email && u.Role == "Emp");
            if (acc != null)
            {
                return RedirectToAction("Index", "Tasks1");
            }
            if (acc1 != null)
            {
                return RedirectToAction("Index1", "Tasks1");
            }
            else
            {
                ModelState.AddModelError("", "invaild name or email");
            }
            return View();
        }

    }
}
