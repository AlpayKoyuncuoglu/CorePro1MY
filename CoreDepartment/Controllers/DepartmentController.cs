using CoreDepartment.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CoreDepartment.Controllers
{
    public class DepartmentController : Controller
    {
        Context c = new Context();
        public IActionResult Index()
        {
            var values = c.Departments.ToList();
            return View(values);
        }
        [HttpGet]
        public IActionResult NewDepartment()
        {
            return View();
        }
        [HttpPost]
        public IActionResult NewDepartment(Department d)
        {
            c.Departments.Add(d);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult DeleteDepartment(int id)
        {
            var val = c.Departments.Find(id);
            c.Departments.Remove(val);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult UpdateDepartment(int id)
        {
            var value = c.Departments.Find(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateDepartment(Department d)
        {
            var value = c.Departments.Find(d.Id);
            value.DepartmentName = d.DepartmentName;
            c.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
