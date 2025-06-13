using LisAPI.DAL.Interfaces;
using LisAPI.DAL.Utils;
using LisAPI.Models;
using System.Data;

namespace LisAPI.DAL
{
    public class OperadorDAL : IOperadorDAL
    {
        private readonly ISqlAuxiliar _sqlAuxiliar;        
        public OperadorDAL(ISqlAuxiliar sqlAuxiliar)
        {
            _sqlAuxiliar = sqlAuxiliar;
        }
        public List<Operador> ObtenerOperadores()
        {
            List<Operador> lista = new List<Operador>();

            DataTable dt = _sqlAuxiliar.EjecutarTablaProcedimientoAlmacenado("Sp_Operador_ObtenerActivos", null);

            if (dt.Rows.Count == 0)
                return lista;
            else
            {
                lista = Operador.ObtenerListaDesdeTabla(dt);
            }
            return lista;
        }
    }
}
