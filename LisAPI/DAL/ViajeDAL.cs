using LisAPI.DAL.Interfaces;
using LisAPI.Models;
using LisAPI.Models.DTO;
using System.Data;

namespace LisAPI.DAL
{
    public class ViajeDAL: IViajeDAL
    {
        private readonly ISqlAuxiliar _sqlAuxiliar;
        public ViajeDAL(ISqlAuxiliar sqlAuxiliar)
        {
            _sqlAuxiliar = sqlAuxiliar;
        }
        public List<Operador> ObtenerOperadores()
        {
            List<Operador> lista = new List<Operador>();

            DataTable dt = _sqlAuxiliar.EjecutarTablaPA("Sp_Operador_ObtenerActivos", null);

            if (dt.Rows.Count == 0)
                return lista;
            else
            {
                lista = Operador.ObtenerListaDesdeTabla(dt);
            }
            return lista;
        }
        public List<Pais> ObtenerPaises()
        {
            List<Pais> lista = new List<Pais>();

            DataTable dt = _sqlAuxiliar.EjecutarTablaPA("Sp_Pais_ObtenerActivos", null);

            if (dt.Rows.Count == 0)
                return lista;
            else
            {
                lista = Pais.ObtenerListaDesdeTabla(dt);
            }
            return lista;
        }
        public List<Estado> ObtenerEstados(int paisID)
        {
            List<Estado> lista = new List<Estado>();

            var parameters = new Dictionary<string, object>
            {
                { "@PaisID", paisID }
            };

            DataTable dt = _sqlAuxiliar.EjecutarTablaPA("Sp_Estado_ObtenerActivos", parameters);

            if (dt.Rows.Count == 0)
                return lista;
            else
            {
                lista = Estado.ObtenerListaDesdeTabla(dt);
            }
            return lista;
        }
        public List<Municipio> ObtenerMunicipios(int estadoID)
        {
            List<Municipio> lista = new List<Municipio>();

            var parameters = new Dictionary<string, object>
            {
                { "@EstadoID", estadoID }
            };

            DataTable dt = _sqlAuxiliar.EjecutarTablaPA("Sp_Municipio_ObtenerActivos", parameters);

            if (dt.Rows.Count == 0)
                return lista;
            else
            {
                lista = Municipio.ObtenerListaDesdeTabla(dt);
            }
            return lista;
        }
        public ResultadoBD InsertarViaje(Viaje _viaje)
        {
            ResultadoBD resultado = new ResultadoBD();
#nullable disable
            var parameters = new Dictionary<string, object>
            {
                { "@OperadorID", _viaje.OperadorID },
                { "@Fecha_inicio", _viaje.Fecha_inicio },
                { "@Fecha_fin", _viaje.Fecha_fin },
                { "@UsuarioID_insercion", _viaje.UsuarioID_insercion },
                { "@Calle_o", _viaje.Calle_o },
                { "@Colonia_o", _viaje.Colonia_o },
                { "@Numero_exterior_o", _viaje.Numero_exterior_o },
                { "@Numero_interior_o", _viaje.Numero_interior_o },
                { "@PaisID_o", _viaje.PaisID_o },
                { "@EstadoID_o", _viaje.EstadoID_o },
                { "@MunicipioID_o", _viaje.MunicipioID_o },
                { "@Calle_d", _viaje.Calle_d },
                { "@Colonia_d", _viaje.Colonia_d },
                { "@Numero_exterior_d", _viaje.Numero_exterior_d },
                { "@Numero_interior_d", _viaje.Numero_interior_d },
                { "@PaisID_d", _viaje.PaisID_d },
                { "@EstadoID_d", _viaje.EstadoID_d },
                { "@MunicipioID_d", _viaje.MunicipioID_d },
            };

            DataRow dt = _sqlAuxiliar.EjecutarPrimeraFilaPA("Sp_Viaje_Insercion", parameters);

            if (dt == null)
                return resultado;
            else
            {

                resultado.Error = Convert.ToBoolean(dt["Error"]);
                resultado.ErrorDesc = dt["ErrorDesc"] != null ? dt["ErrorDesc"].ToString() : "";
                resultado.Icon = dt["Icon"] != null ? dt["Icon"].ToString() : "";
#nullable enable
            }

            return resultado;
        }
        public ResultadoBD ModificarViaje(Viaje _viaje)
        {
            ResultadoBD resultado = new ResultadoBD();
#nullable disable
            var parameters = new Dictionary<string, object>
            {
                { "@OperadorID", _viaje.OperadorID },
                { "@Fecha_inicio", _viaje.Fecha_inicio },
                { "@Fecha_fin", _viaje.Fecha_fin },
                { "@UsuarioID_insercion", _viaje.UsuarioID_insercion },
                { "@Calle_o", _viaje.Calle_o },
                { "@Colonia_o", _viaje.Colonia_o },
                { "@Numero_exterior_o", _viaje.Numero_exterior_o },
                { "@Numero_interior_o", _viaje.Numero_interior_o },
                { "@PaisID_o", _viaje.PaisID_o },
                { "@EstadoID_o", _viaje.EstadoID_o },
                { "@MunicipioID_o", _viaje.MunicipioID_o },
                { "@Calle_d", _viaje.Calle_d },
                { "@Colonia_d", _viaje.Colonia_d },
                { "@Numero_exterior_d", _viaje.Numero_exterior_d },
                { "@Numero_interior_d", _viaje.Numero_interior_d },
                { "@PaisID_d", _viaje.PaisID_d },
                { "@EstadoID_d", _viaje.EstadoID_d },
                { "@MunicipioID_d", _viaje.MunicipioID_d },
                { "@ViajeID", _viaje.ViajeID },
                { "@TipoEstatusID", _viaje.TipoEstatusID },
            };

            DataRow dt = _sqlAuxiliar.EjecutarPrimeraFilaPA("Sp_Viaje_Modificacion", parameters);

            if (dt == null)
                return resultado;
            else
            {

                resultado.Error = Convert.ToBoolean(dt["Error"]);
                resultado.ErrorDesc = dt["ErrorDesc"] != null ? dt["ErrorDesc"].ToString() : "";
                resultado.Icon = dt["Icon"] != null ? dt["Icon"].ToString() : "";
#nullable enable
            }

            return resultado;
        }
        public List<TipoEstatus> ObtenerTipoEstatus()
        {
            List<TipoEstatus> lista = new List<TipoEstatus>();

            DataTable dt = _sqlAuxiliar.EjecutarTablaPA("Sp_TipoEstatus_ObtenerActivos", null);

            if (dt.Rows.Count == 0)
                return lista;
            else
            {
                lista = TipoEstatus.ObtenerListaDesdeTabla(dt);
            }
            return lista;
        }
        public List<ViajeDTO> ObtenerViajes()
        {
            List<ViajeDTO> lista = new List<ViajeDTO>();

            DataTable dt = _sqlAuxiliar.EjecutarTablaPA("Sp_Viaje_ObtenerTabla", null);

            if (dt.Rows.Count == 0)
                return lista;
            else
            {
                lista = ViajeDTO.ObtenerListaDesdeTabla(dt);
            }
            return lista;
        }
    }
}
