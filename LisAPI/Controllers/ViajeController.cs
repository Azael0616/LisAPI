using LisAPI.DAL.Interfaces;
using LisAPI.Models;
using LisAPI.Models.DTO;
using Microsoft.AspNetCore.Mvc;

namespace LisAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ViajeController : ControllerBase
    {
        
        private readonly IViajeDAL _viajeServicio;
        public ViajeController(IViajeDAL viajeServicio)
        {
            _viajeServicio = viajeServicio;
        }
        [HttpGet("ObtenerOperadores")]
        public IActionResult ObtenerOperadores()
        {
            List<Operador> lista = _viajeServicio.ObtenerOperadores();
            return Ok(lista);
        }
        [HttpGet("ObtenerPaises")]
        public IActionResult ObtenerPaises()
        {
            List<Pais> lista = new List<Pais>();
            lista = _viajeServicio.ObtenerPaises();
            return Ok(lista);
        }
        [HttpGet("ObtenerEstados")]
        public IActionResult ObtenerEstados(int id)
        {
            List<Estado> lista = new List<Estado>();
            lista = _viajeServicio.ObtenerEstados(id);
            return Ok(lista);
        }
        [HttpGet("ObtenerMunicipios")]
        public IActionResult ObtenerMunicipios(int id)
        {
            List<Municipio> lista = new List<Municipio>();
            lista = _viajeServicio.ObtenerMunicipios(id);
            return Ok(lista);
        }
        [HttpGet("ObtenerTipoEstatus")]
        public IActionResult ObtenerTipoEstatus()
        {
            List<TipoEstatus> lista = new List<TipoEstatus>();
            lista = _viajeServicio.ObtenerTipoEstatus();
            return Ok(lista);
        }
        [HttpPost("InsertarViaje")]
        public IActionResult InsertarViaje(Viaje viaje)
        {
            ResultadoBD _resultado = new ResultadoBD();
            _resultado = _viajeServicio.InsertarViaje(viaje);
            return Ok(_resultado);
        }
        [HttpPost("ModificarViaje")]
        public IActionResult ModificarViaje(Viaje viaje)
        {
            ResultadoBD _resultado = new ResultadoBD();
            _resultado = _viajeServicio.ModificarViaje(viaje);
            return Ok(_resultado);
        }
        [HttpGet("ObtenerViajes")]
        public IActionResult ObtenerViajes()
        {
            List<ViajeDTO> lista = new List<ViajeDTO>();
            lista = _viajeServicio.ObtenerViajes();
            return Ok(lista);
        }
        [HttpGet("ObtenerViajePorId")]
        public IActionResult ObtenerViajePorId(int Id)
        {
            Viaje _viaje = new Viaje();
            _viaje = _viajeServicio.ObtenerViajePorID(Id);
            return Ok(_viaje);
        }
    }
}
