using System.Data;

namespace LisAPI.Models
{
    public class Estado
    {
        public int EstadoID { get; set; } = 0;
        public int PaisID { get; set; } = 0;
        public string Nombre { get; set; } = string.Empty;
        public string Siglas { get; set; } = string.Empty;
        public bool Activo { get; set; } = false;
        public Estado() { }
        public Estado(int estadoID, int paisID, string nombre, string siglas, bool activo)
        {
            this.EstadoID = estadoID;
            this.PaisID = paisID;
            this.Nombre = nombre;
            this.Siglas = siglas;
            this.Activo = activo;
        }
        public Estado(DataRow dt)
        {
#nullable disable
            this.EstadoID = (dt.Table.Columns.Contains("EstadoID") && dt["EstadoID"] != DBNull.Value) ? int.Parse(dt["EstadoID"].ToString()) : 0;
            this.PaisID = (dt.Table.Columns.Contains("PaisID") && dt["PaisID"] != DBNull.Value) ? int.Parse(dt["PaisID"].ToString()) : 0;
            this.Nombre = (dt.Table.Columns.Contains("Nombre") && dt["Nombre"] != DBNull.Value) ? dt["Nombre"].ToString() : "";
            this.Siglas = (dt.Table.Columns.Contains("Siglas") && dt["Siglas"] != DBNull.Value) ? dt["Siglas"].ToString().Trim() : "";
            this.Activo = (dt.Table.Columns.Contains("Activo") && dt["Activo"] != DBNull.Value) ? (bool)dt["Activo"] : false;
#nullable restore
        }
        public static List<Estado> ObtenerListaDesdeTabla(DataTable dt)
        {
            List<Estado> list = new List<Estado>();
            foreach (DataRow dr in dt.Rows)
            {
                Estado _estado = new Estado(dr);
                list.Add(_estado);
            }
            return list;
        }
    }
}
