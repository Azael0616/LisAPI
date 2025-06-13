using System.Data;

namespace LisAPI.Models
{
    public class TipoEstatus
    {
        public int TipoEstatusID { get; set; } = 0;
        public string Nombre { get; set; } = string.Empty;
        public string? Descripcion { get; set; } = string.Empty;
        public bool Activo { get; set; } = false;
        public TipoEstatus() { }
        public TipoEstatus(int tipoEstatusID, string nombre, string? descripcion, bool activo) {
            this.TipoEstatusID = tipoEstatusID;
            this.Nombre = nombre;
            this.Descripcion = descripcion;
            this.Activo = activo;
        }
        public TipoEstatus(DataRow dt)
        {
#nullable disable
            this.TipoEstatusID = (dt.Table.Columns.Contains("TipoEstatusID") && dt["TipoEstatusID"] != DBNull.Value) ? int.Parse(dt["TipoEstatusID"].ToString()) : 0;
            this.Nombre = (dt.Table.Columns.Contains("Nombre") && dt["Nombre"] != DBNull.Value) ? dt["Nombre"].ToString() : "";
            this.Descripcion = (dt.Table.Columns.Contains("Descripcion") && dt["Descripcion"] != DBNull.Value) ? dt["Descripcion"].ToString().Trim() : "";
            this.Activo = (dt.Table.Columns.Contains("Activo") && dt["Activo"] != DBNull.Value) ? (bool)dt["Activo"] : false;
#nullable restore
        }
        public static List<TipoEstatus> ObtenerListaDesdeTabla(DataTable dt)
        {
            List<TipoEstatus> list = new List<TipoEstatus>();
            foreach (DataRow dr in dt.Rows)
            {
                TipoEstatus _estatus = new TipoEstatus(dr);
                list.Add(_estatus);
            }
            return list;
        }
    }
}
