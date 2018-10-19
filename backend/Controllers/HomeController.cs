using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("person/all")]
        public string Index()
        {
            return "Fuck";
        }
    }
}