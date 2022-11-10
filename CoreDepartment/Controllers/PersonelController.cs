using CoreDepartment.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace CoreDepartment.Controllers
{
    public class PersonelController : Controller
    {
        Context c = new Context();

        public IActionResult Index()
        {
            var values = c.Personels.Include(x => x.Department).ToList();
            return View(values);
        }
        [HttpGet]
        public IActionResult NewPersonel()
        {
            List<SelectListItem> values = (from x in c.Departments.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.DepartmentName,
                                               Value = x.Id.ToString()
                                           }
                                           ).ToList();
            ViewBag.val = values;
            return View();
        }
        public IActionResult NewPersonel(Personel p)
        {
            var prsnl = c.Departments.Where(x => x.Id == p.Department.Id).FirstOrDefault();
            p.Department = prsnl;
            c.Personels.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}
