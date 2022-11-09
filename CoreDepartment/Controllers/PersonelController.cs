using Microsoft.AspNetCore.Mvc;

namespace CoreDepartment.Controllers
{
    public class PersonelController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
