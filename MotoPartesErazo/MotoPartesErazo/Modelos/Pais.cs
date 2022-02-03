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
    public class Pais
    {
        private readonly DBHelper DB = new DBHelper(ClsComun.CadenaConexion, CommandType.StoredProcedure);
        private readonly string entidad = "Provincias";

        private int id_pais;
        private string nombre;
        private int enviado;
        /* Getters  y Setters*/
        public int Id_pais { get => id_pais; set => id_pais = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Enviado { get => enviado; set => enviado = value; }

        /*Métodos*/
        

        //  método  devuelve todos los registros de la tabla provincia
        public DataTable Lista() => DB.ObtenerTabla("sp_pais_lista");
    }
}
