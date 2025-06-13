using System.Data;

namespace LisAPI.Models.DTO
{
    public class ViajeDTO
    {
        public int ViajeID { get; set; } = 0;
        public string Pais_origen { get; set; } = string.Empty;
        public string Estado_origen { get; set; } = string.Empty;
        public string Municipio_origen { get; set; } = string.Empty;
        public string Pais_destino {  get; set; } = string.Empty;
        public string Estado_destino { get; set; } = string.Empty;
        public string Municipio_destino { get; set; } = string.Empty;
        public string Fecha_inicio {  get; set; } = string.Empty;
        public string Fecha_fin {  get; set; } = string.Empty;
        public string Operador {  get; set; } = string.Empty;
        public string Estatus {  get; set; } = string.Empty;
        public string Usuario_insercion {  get; set; } = string.Empty;
        public ViajeDTO() { }
        public ViajeDTO(DataRow dt)
        {
#nullable disable            
            this.ViajeID = (dt.Table.Columns.Contains("ViajeID") && dt["ViajeID"] != DBNull.Value) ? int.Parse(dt["ViajeID"].ToString()) : 0;
            this.Pais_origen = (dt.Table.Columns.Contains("Pais_origen") && dt["Pais_origen"] != DBNull.Value) ? dt["Pais_origen"].ToString() : "";
            this.Estado_origen = (dt.Table.Columns.Contains("Estado_origen") && dt["Estado_origen"] != DBNull.Value) ? dt["Estado_origen"].ToString().Trim() : "";
            this.Municipio_origen = (dt.Table.Columns.Contains("Municipio_origen") && dt["Municipio_origen"] != DBNull.Value) ? dt["Municipio_origen"].ToString().Trim() : "";
            this.Pais_destino = (dt.Table.Columns.Contains("Pais_destino") && dt["Pais_destino"] != DBNull.Value) ? dt["Pais_destino"].ToString().Trim() : "";
            this.Estado_destino = (dt.Table.Columns.Contains("Estado_destino") && dt["Estado_destino"] != DBNull.Value) ? dt["Estado_destino"].ToString().Trim() : "";
            this.Municipio_destino = (dt.Table.Columns.Contains("Municipio_destino") && dt["Municipio_destino"] != DBNull.Value) ? dt["Municipio_destino"].ToString().Trim() : "";
            this.Fecha_inicio = (dt.Table.Columns.Contains("Fecha_inicio") && dt["Estado_origen"] != DBNull.Value) ? dt["Fecha_inicio"].ToString().Trim() : "";
            this.Fecha_fin = (dt.Table.Columns.Contains("Fecha_fin") && dt["Fecha_fin"] != DBNull.Value) ? dt["Fecha_fin"].ToString().Trim() : "";
            this.Operador = (dt.Table.Columns.Contains("Operador") && dt["Operador"] != DBNull.Value) ? dt["Operador"].ToString().Trim() : "";
            this.Estatus = (dt.Table.Columns.Contains("Estatus") && dt["Estatus"] != DBNull.Value) ? dt["Estatus"].ToString().Trim() : "";
            this.Usuario_insercion = (dt.Table.Columns.Contains("Usuario_insercion") && dt["Usuario_insercion"] != DBNull.Value) ? dt["Usuario_insercion"].ToString().Trim() : "";
#nullable restore
        }
        public static List<ViajeDTO> ObtenerListaDesdeTabla(DataTable dt)
        {
            List<ViajeDTO> list = new List<ViajeDTO>();
            foreach (DataRow dr in dt.Rows)
            {
                ViajeDTO _viaje = new ViajeDTO(dr);
                list.Add(_viaje);
            }
            return list;
        }
    }
}
