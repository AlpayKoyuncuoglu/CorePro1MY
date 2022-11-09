using CoreDepartment.Models;
using Microsoft.AspNetCore.Mvc;
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
    }
}
