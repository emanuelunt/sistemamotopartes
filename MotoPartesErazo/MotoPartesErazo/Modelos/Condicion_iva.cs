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
    public class Condicion_iva
    {
        private readonly DBHelper DB = new DBHelper(ClsComun.CadenaConexion, CommandType.StoredProcedure);
        private readonly string entidad = "Condición iva";

        private int id_condicion_iva;
        private byte codigo;
        private string descripcion;
        /* Getters  y Setters*/
        public int Id_condicion_iva { get => id_condicion_iva; set => id_condicion_iva = value; }
        public byte Codigo { get => codigo; set => codigo = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }


        /*Métodos*/
        //  método  devuelve todos los registros de la tabla Condicion iva
        public DataTable Lista() => DB.ObtenerTabla("sp_condicioniva_lista");

    }
}
