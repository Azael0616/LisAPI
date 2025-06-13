using System.Data;

namespace LisAPI.Models
{
    public class Operador
    {
        public int OperadorID { get; set; } = 0;
        public string Nombre_completo { get; set; } = string.Empty;
        public int Edad { get; set; } = 0;
        public int TipoLicenciaID { get; set; } = 0;
        public int TipoOperadorID { get; set; } = 0;
        public bool Activo { get; set; } = false;
        public Operador(){}
        public Operador(int operadorID, string nombre_completo, int edad, int tipoLicenciaID, int tipoOperadorID, bool activo) {
            this.OperadorID = operadorID;
            this.Nombre_completo = nombre_completo;
            this.Edad = edad;
            this.TipoOperadorID= tipoOperadorID;
            this.TipoLicenciaID= tipoLicenciaID;
            this.Activo = activo;
        }
        public Operador(DataRow dt)
        {
#nullable disable
            this.OperadorID = (dt.Table.Columns.Contains("OperadorID") && dt["OperadorID"] != DBNull.Value) ? int.Parse(dt["OperadorID"].ToString()) : 0;
            this.Nombre_completo = (dt.Table.Columns.Contains("Nombre_completo") && dt["Nombre_completo"] != DBNull.Value) ? dt["Nombre_completo"].ToString() : "";
            this.Edad = (dt.Table.Columns.Contains("Edad") && dt["Edad"] != DBNull.Value) ? int.Parse(dt["Edad"].ToString()) : 0;
            this.TipoLicenciaID = (dt.Table.Columns.Contains("TipoLicenciaID") && dt["TipoLicenciaID"] != DBNull.Value) ? int.Parse(dt["TipoLicenciaID"].ToString()) : 0;
            this.TipoOperadorID = (dt.Table.Columns.Contains("TipoOperadorID") && dt["TipoOperadorID"] != DBNull.Value) ? int.Parse(dt["TipoOperadorID"].ToString()) : 0;
            this.Activo = (dt.Table.Columns.Contains("Activo") && dt["Activo"] != DBNull.Value) ? (bool)dt["Activo"] : false;
#nullable restore
        }
        public static List<Operador> ObtenerListaDesdeTabla(DataTable dt)
        {
            List<Operador> list = new List<Operador>();
            foreach (DataRow dr in dt.Rows)
            {
                Operador _op = new Operador(dr);
                list.Add(_op);
            }
            return list;
        }
    }
}
