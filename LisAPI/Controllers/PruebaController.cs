using Microsoft.AspNetCore.Mvc;

namespace LisAPI.Controllers
{
    public class PruebaController : Controller
    {
        public IActionResult Index()
        {
            return Ok("API CORRIENDO");
        }
    }
}
