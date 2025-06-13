using System.Data;

namespace LisAPI.Models
{
    public class Pais
    {
        public int PaisID { get; set; } = 0;
        public string Nombre { get; set; } = string.Empty;
        public string Siglas {  get; set; } = string.Empty;
        public bool Activo { get; set; } = false;
        public Pais() { }
        public Pais(int paisID, string nombre, string siglas, bool activo) {
            this.PaisID = paisID;
            this.Nombre = nombre;
            this.Siglas = siglas;
            this.Activo = activo;
        }
        public Pais(DataRow dt)
        {
#nullable disable
            this.PaisID = (dt.Table.Columns.Contains("PaisID") && dt["PaisID"] != DBNull.Value) ? int.Parse(dt["PaisID"].ToString()) : 0;
            this.Nombre = (dt.Table.Columns.Contains("Nombre") && dt["Nombre"] != DBNull.Value) ? dt["Nombre"].ToString() : "";
            this.Siglas = (dt.Table.Columns.Contains("Siglas") && dt["Siglas"] != DBNull.Value) ? dt["Siglas"].ToString().Trim() : "";
            this.Activo = (dt.Table.Columns.Contains("Activo") && dt["Activo"] != DBNull.Value) ? (bool)dt["Activo"] : false;
#nullable restore
        }
        public static List<Pais> ObtenerListaDesdeTabla(DataTable dt)
        {
            List<Pais> list = new List<Pais>();
            foreach (DataRow dr in dt.Rows)
            {
                Pais _pais = new Pais(dr);
                list.Add(_pais);
            }
            return list;
        }
    }
}
