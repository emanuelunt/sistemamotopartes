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
    public class Localidad
    {
        private readonly DBHelper DB = new DBHelper(ClsComun.CadenaConexion, CommandType.StoredProcedure);
        private readonly string entidad = "Localidad";

        private int id_localidad;
        private int localidad_id;
        private int id_provincia;
        private int enviado;
        /* Getters  y Setters*/
        public int Id_localidad { get => id_localidad; set => id_localidad = value; }
        public int Localidad_id { get => localidad_id; set => localidad_id = value; }
        public int Id_provincia { get => id_provincia; set => id_provincia = value; }
        public int Enviado { get => enviado; set => enviado = value; }

        /*Métodos*/
        public DataTable Datos()// con este método obtenemos todos los datos de la tabla localidad y sus datos vinculados a otras tablas
        {
            return DB.ObtenerTabla("sp_localidad_datos");
        }

        //  método  devuelve todos los registros de la tabla localidad
        public DataTable Lista() => DB.ObtenerTabla("sp_localidad_lista");

    }
}
