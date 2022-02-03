using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MotoPartesErazo.Datos;
using MotoPartesErazo.ConfigGlobal;

namespace MotoPartesErazo.Modelos
{
    public class Provincia
    {
        private readonly DBHelper DB = new DBHelper(ClsComun.CadenaConexion, CommandType.StoredProcedure);
        private readonly string entidad = "Provincias";

        private int id_provincia;
        private string nombre_completo;
        private string iso_id;
        private string nombre;
        private string iso_nombre;
        private string longitud;
        private string latitud;
        private int id_pais;
        /* Getters  y Setters*/
        public int Id_provincia { get => id_provincia; set => id_provincia = value; }
        public string Nombre_completo { get => nombre_completo; set => nombre_completo = value; }
        public string Iso_id { get => iso_id; set => iso_id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Iso_nombre { get => iso_nombre; set => iso_nombre = value; }
        public string Longitud { get => longitud; set => longitud = value; }
        public string Latitud { get => latitud; set => latitud = value; }
        public int Id_pais { get => id_pais; set => id_pais = value; }

        /*Métodos*/
        public DataTable Datos()// con este método obtenemos todos los datos de la tabla provincia y sus datos vinculados a otras tablas
        {
            return DB.ObtenerTabla("sp_provincia_datos");
        }

        //  método  devuelve todos los registros de la tabla provincia
        public DataTable Lista() => DB.ObtenerTabla("sp_provincia_lista");
    }
}
