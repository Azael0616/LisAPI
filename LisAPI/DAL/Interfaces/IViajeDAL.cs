using LisAPI.Models;
using LisAPI.Models.DTO;

namespace LisAPI.DAL.Interfaces
{
    public interface IViajeDAL
    {
        public List<Operador> ObtenerOperadores();
        public List<Pais> ObtenerPaises();
        public List<Estado> ObtenerEstados(int paisID);
        public List<Municipio> ObtenerMunicipios(int estadoID);
        public ResultadoBD InsertarViaje(Viaje viaje);
        public ResultadoBD ModificarViaje(Viaje viaje);
        public List<TipoEstatus> ObtenerTipoEstatus();
        public List<ViajeDTO> ObtenerViajes();
    }
}
