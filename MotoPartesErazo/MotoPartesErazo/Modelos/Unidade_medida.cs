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
    public class Unidade_medida
    {
        private readonly DBHelper DB = new DBHelper(ClsComun.CadenaConexion, CommandType.StoredProcedure);
        private readonly string entidad = "Unidad de Medida";

        private int id_unidad_medida;
        private string nombre;
        private string abreviatura;
        private int enviado;

        /* Getters y Setters */

        public int Id_unidad_medida { get => id_unidad_medida; set => id_unidad_medida = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Abreviatura { get => abreviatura; set => abreviatura = value; }
        public int Enviado { get => enviado; set => enviado = value; }

        /*   Métodos  */

        // método que devuelve todo los registros de la tabla Uniddadde_medida
        public DataTable Lista() => DB.ObtenerTabla("sp_unidadmedida_lista");


        // método que crea nuevos unidad de medida
        public string Crear()
        {
            int resultado;

            // creamos los parametros y los agreamos al comando para que ejecute el procedimeintos almacenado en la base de datos
            DB.AgregarParametro("nombre_", this.Nombre);
            DB.AgregarParametro("abreviatura_", this.Abreviatura);
            DB.AgregarParametro("enviado_", this.Enviado);
            

            resultado = DB.CRUD("sp_unidadmedida_crear");

            return (resultado == 1 ? $"{ClsComun.FilaCreada} {entidad} " : ClsComun.NoFilasAgregada);
        }

        public string Actualizar() // actualiza registros
        {
            int resultado;

            DB.AgregarParametro("id_", this.Id_unidad_medida);

            DB.AgregarParametro("nombre_", this.Nombre);
            DB.AgregarParametro("abreviatura_", this.Abreviatura);
            DB.AgregarParametro("enviado_", this.Enviado);
            

            resultado = DB.CRUD("sp_unidadmedida_actualizar");

            return (resultado == 1 ? $"{ClsComun.FilaActualizada} {entidad} " : ClsComun.NoFilasActualizada);
        }

        public string Eliminar() // eliminar registros
        {
            int resultado;

            DB.AgregarParametro("id_", this.Id_unidad_medida);

            resultado = DB.CRUD("sp_unidadmedida_eliminar");

            return (resultado == 1 ? $"{ClsComun.FilaEliminada} {entidad} " : ClsComun.NoFilasEliminada);
        }

        public DataTable Buscar(string txtbuscar)// Buscar registros
        {
            DB.AgregarParametro("txt_", txtbuscar);

            return DB.ObtenerTabla("sp_unidadmedida_buscar");
        }

        public bool ExisteUnidad(string nombre)// este método verifica que no se repita unidades de medida.
        {
            DB.AgregarParametro("nombre_", nombre);

            DataTable info = DB.ObtenerTabla("sp_unidadmedida_existe");

            return (info != null && info.Rows.Count > 0 ? true : false);
        }
    }
}
