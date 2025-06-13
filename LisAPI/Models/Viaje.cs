using System.Data;

namespace LisAPI.Models
{
    public class Viaje
    {
        public int ViajeID { get; set; } = 0;
        public int OperadorID { get; set; } = 0;
        public DateTimeOffset Fecha_inicio {  get; set; } = DateTimeOffset.Now;
        public DateTimeOffset Fecha_fin { get; set; } = DateTimeOffset.Now;
        public int TipoEstatusID { get; set; } = 0;
        public bool? Activo { get; set; } = false;
        public int UsuarioID_insercion { get; set; } = 0;
        public DateTimeOffset? Fecha_insercion { get; set; } = DateTimeOffset.Now;
        public int? UsuarioID_modificacion { get; set; } = 0;
        public DateTimeOffset? Fecha_modificacion { get; set; } = DateTimeOffset.Now;
        //Direccion
        public string Calle_o { get; set; } = string.Empty;
        public string Colonia_o { get; set; } = string.Empty;
        public string? Numero_interior_o { get; set; } = string.Empty;
        public string Numero_exterior_o { get; set; } = string.Empty;
        public int PaisID_o { get; set; } = 0;
        public int EstadoID_o { get; set; } = 0;
        public int MunicipioID_o { get; set; } = 0;
        public string Calle_d { get; set; } = string.Empty;
        public string Colonia_d { get; set; } = string.Empty;
        public string? Numero_interior_d { get; set; } = string.Empty;
        public string Numero_exterior_d { get; set; } = string.Empty;
        public int PaisID_d { get; set; } = 0;
        public int EstadoID_d { get; set; } = 0;
        public int MunicipioID_d { get; set; } = 0;
        public Viaje() { }
        public Viaje(DataRow dt)
        {
#nullable disable
            this.ViajeID = (dt.Table.Columns.Contains("ViajeID") && dt["ViajeID"] != DBNull.Value) ? int.Parse(dt["ViajeID"].ToString()) : 0;
            this.OperadorID = (dt.Table.Columns.Contains("OperadorID") && dt["OperadorID"] != DBNull.Value) ? int.Parse(dt["OperadorID"].ToString()) : 0;
            this.Fecha_inicio = (dt.Table.Columns.Contains("Fecha_inicio") && dt["Fecha_inicio"] != DBNull.Value) ? (DateTimeOffset) dt["Fecha_inicio"]: DateTimeOffset.Now;
            this.Fecha_fin = (dt.Table.Columns.Contains("Fecha_fin") && dt["Fecha_fin"] != DBNull.Value) ? (DateTimeOffset)dt["Fecha_fin"] : DateTimeOffset.Now;
            this.TipoEstatusID = (dt.Table.Columns.Contains("TipoEstatusID") && dt["TipoEstatusID"] != DBNull.Value) ? int.Parse(dt["TipoEstatusID"].ToString()) : 0;
            this.Activo = (dt.Table.Columns.Contains("Activo") && dt["Activo"] != DBNull.Value) ? (bool)dt["Activo"] : false;
            this.UsuarioID_insercion = (dt.Table.Columns.Contains("UsuarioID_insercion") && dt["UsuarioID_insercion"] != DBNull.Value) ? int.Parse(dt["UsuarioID_insercion"].ToString()) : 0;
            this.Fecha_insercion = (dt.Table.Columns.Contains("Fecha_insercion") && dt["Fecha_insercion"] != DBNull.Value) ? (DateTimeOffset)dt["Fecha_insercion"] : DateTimeOffset.Now;
            this.UsuarioID_modificacion = (dt.Table.Columns.Contains("UsuarioID_modificacion") && dt["UsuarioID_modificacion"] != DBNull.Value) ? int.Parse(dt["UsuarioID_modificacion"].ToString()) : 0;
            this.Fecha_modificacion = (dt.Table.Columns.Contains("Fecha_modificacion") && dt["Fecha_modificacion"] != DBNull.Value) ? (DateTimeOffset)dt["Fecha_modificacion"] : DateTimeOffset.Now;
            this.Calle_o = (dt.Table.Columns.Contains("Calle_o") && dt["Calle_o"] != DBNull.Value) ? dt["Calle_o"].ToString().Trim() : "";
            this.Colonia_o = (dt.Table.Columns.Contains("Colonia_o") && dt["Colonia_o"] != DBNull.Value) ? dt["Colonia_o"].ToString().Trim() : "";
            this.Numero_exterior_o = (dt.Table.Columns.Contains("Numero_exterior_o") && dt["Numero_exterior_o"] != DBNull.Value) ? dt["Numero_exterior_o"].ToString().Trim() : "";
            this.Numero_interior_o = (dt.Table.Columns.Contains("Numero_interior_o") && dt["Numero_interior_o"] != DBNull.Value) ? dt["Numero_interior_o"].ToString().Trim() : "";
            this.PaisID_o = (dt.Table.Columns.Contains("PaisID_o") && dt["PaisID_o"] != DBNull.Value) ? int.Parse(dt["PaisID_o"].ToString()) : 0;
            this.EstadoID_o = (dt.Table.Columns.Contains("EstadoID_o") && dt["EstadoID_o"] != DBNull.Value) ? int.Parse(dt["EstadoID_o"].ToString()) : 0;
            this.MunicipioID_o = (dt.Table.Columns.Contains("MunicipioID_o") && dt["MunicipioID_o"] != DBNull.Value) ? int.Parse(dt["MunicipioID_o"].ToString()) : 0;
            this.Calle_d = (dt.Table.Columns.Contains("Calle_d") && dt["Calle_d"] != DBNull.Value) ? dt["Calle_d"].ToString().Trim() : "";
            this.Colonia_d = (dt.Table.Columns.Contains("Colonia_d") && dt["Colonia_d"] != DBNull.Value) ? dt["Colonia_d"].ToString().Trim() : "";
            this.Numero_exterior_d = (dt.Table.Columns.Contains("Numero_exterior_d") && dt["Numero_exterior_d"] != DBNull.Value) ? dt["Numero_exterior_d"].ToString().Trim() : "";
            this.Numero_interior_d = (dt.Table.Columns.Contains("Numero_interior_d") && dt["Numero_interior_d"] != DBNull.Value) ? dt["Numero_interior_d"].ToString().Trim() : "";
            this.PaisID_d = (dt.Table.Columns.Contains("PaisID_d") && dt["PaisID_d"] != DBNull.Value) ? int.Parse(dt["PaisID_d"].ToString()) : 0;
            this.EstadoID_d = (dt.Table.Columns.Contains("EstadoID_d") && dt["EstadoID_d"] != DBNull.Value) ? int.Parse(dt["EstadoID_d"].ToString()) : 0;
            this.MunicipioID_d = (dt.Table.Columns.Contains("MunicipioID_d") && dt["MunicipioID_d"] != DBNull.Value) ? int.Parse(dt["MunicipioID_d"].ToString()) : 0;
#nullable restore
        }
        public static List<Viaje> ObtenerListaDesdeTabla(DataTable dt)
        {
            List<Viaje> list = new List<Viaje>();
            foreach (DataRow dr in dt.Rows)
            {
                Viaje _viaje = new Viaje(dr);
                list.Add(_viaje);
            }
            return list;
        }
    }
}
