using System.Data;

namespace LisAPI.DAL.Interfaces
{
    public interface ISqlAuxiliar
    {
        public DataTable EjecutarTablaProcedimientoAlmacenado(string procedimientoAlmacenado, Dictionary<string, object>? parametros = null);
    }
}
