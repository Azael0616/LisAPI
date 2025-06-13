using LisAPI.DAL.Interfaces;
using LisAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace LisAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PruebaController : ControllerBase
    {
        private readonly IOperadorDAL _operadorServicio;
        public PruebaController(IOperadorDAL operadorServicio)
        {
            _operadorServicio = operadorServicio;
        }        
        public IActionResult Index()
        {
            return Ok("API CORRIENDO");
        }
        [HttpGet("ObtenerOperadores")]
        public IActionResult ObtenerOperadores()
        {
            List <Operador> lista = _operadorServicio.ObtenerOperadores();
            return Ok(lista);
        }
    }
}
