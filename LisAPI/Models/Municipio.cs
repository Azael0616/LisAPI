using System.Data;

namespace LisAPI.Models
{
    public class Municipio
    {
        public int MunicipioID { get; set; } = 0;
        public int EstadoID { get; set; } = 0;        
        public string Nombre { get; set; } = string.Empty;
        public string Siglas { get; set; } = string.Empty;
        public bool Activo { get; set; } = false;
        public Municipio() { }
        public Municipio(int municipioID, int estadoID, string nombre, string siglas, bool activo)
        {
            this.MunicipioID = municipioID;
            this.EstadoID = estadoID;            
            this.Nombre = nombre;
            this.Siglas = siglas;
            this.Activo = activo;
        }
        public Municipio(DataRow dt)
        {
#nullable disable
            this.MunicipioID = (dt.Table.Columns.Contains("MunicipioID") && dt["MunicipioID"] != DBNull.Value) ? int.Parse(dt["MunicipioID"].ToString()) : 0;
            this.EstadoID = (dt.Table.Columns.Contains("EstadoID") && dt["EstadoID"] != DBNull.Value) ? int.Parse(dt["EstadoID"].ToString()) : 0;            
            this.Nombre = (dt.Table.Columns.Contains("Nombre") && dt["Nombre"] != DBNull.Value) ? dt["Nombre"].ToString() : "";
            this.Siglas = (dt.Table.Columns.Contains("Siglas") && dt["Siglas"] != DBNull.Value) ? dt["Siglas"].ToString().Trim() : "";
            this.Activo = (dt.Table.Columns.Contains("Activo") && dt["Activo"] != DBNull.Value) ? (bool)dt["Activo"] : false;
#nullable restore
        }
        public static List<Municipio> ObtenerListaDesdeTabla(DataTable dt)
        {
            List<Municipio> list = new List<Municipio>();
            foreach (DataRow dr in dt.Rows)
            {
                Municipio _municipio = new Municipio(dr);
                list.Add(_municipio);
            }
            return list;
        }
    }
}
