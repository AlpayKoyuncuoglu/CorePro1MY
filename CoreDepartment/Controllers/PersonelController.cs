using CoreDepartment.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;

namespace CoreDepartment.Controllers
{
    public class PersonelController : Controller
    {
        Context c = new Context();

        public IActionResult Index()
        {
            var values = c.Personels.ToList();
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
    }
}
