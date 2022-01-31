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
    public class Rubro
    {
        private readonly DBHelper DB = new DBHelper(ClsComun.CadenaConexion, CommandType.StoredProcedure);
        private readonly string entidad = "Categoría";

        private int id_rubro;
        private string nombre;
        private string descripcion;
        private int enviado;
        private int empresa;

        /* Getters y Setters */
        public int Id_rubro { get => id_rubro; set => id_rubro = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int Enviado { get => enviado; set => enviado = value; }
        public int Empresa { get => empresa; set => empresa = value; }

        /* Métodos */

        // método que devuelve todo los registros de la tabla Rubro
        public DataTable Lista() => DB.ObtenerTabla("sp_rubro_lista");

        // método que crea nuevos Rubros
        public string Crear()
        {
            int resultado;

            // creamos los parametros y los agreamos al comando para que ejecute el procedimeintos almacenado en la base de datos
            DB.AgregarParametro("nombre_", this.Nombre);
            DB.AgregarParametro("descripcion_", this.Descripcion);
            DB.AgregarParametro("enviado_", this.Enviado);
            DB.AgregarParametro("empresa_", this.Empresa);


            resultado = DB.CRUD("sp_rubro_crear");

            return (resultado == 1 ? $"{ClsComun.FilaCreada} {entidad} " : ClsComun.NoFilasAgregada);
        }

        public string Actualizar() // actualiza registros
        {
            int resultado;

            DB.AgregarParametro("id_", this.Id_rubro);

            DB.AgregarParametro("nombre_", this.Nombre);
            DB.AgregarParametro("descripcion_", this.Descripcion);
           // DB.AgregarParametro("enviado_", this.Enviado);
           // DB.AgregarParametro("empresa_", this.Empresa);

            resultado = DB.CRUD("sp_rubro_actualizar");

            return (resultado == 1 ? $"{ClsComun.FilaActualizada} {entidad} " : ClsComun.NoFilasActualizada);
        }
        public string Eliminar() // eliminar registros
        {
            int resultado;

            DB.AgregarParametro("id_", this.Id_rubro);

            resultado = DB.CRUD("sp_rubro_eliminar");

            return (resultado == 1 ? $"{ClsComun.FilaEliminada} {entidad} " : ClsComun.NoFilasEliminada);
        }
        public DataTable Buscar(string txtbuscar)// Buscar registros
        {
            DB.AgregarParametro("txt_", txtbuscar);

            return DB.ObtenerTabla("sp_rubro_buscar");
        }

        public bool ExisteRubro(string nombre)// este método verifica que no se repita rubros.
        {
            DB.AgregarParametro("nombre_", nombre);

            DataTable info = DB.ObtenerTabla("sp_rubro_existe");

            return (info != null && info.Rows.Count > 0 ? true : false);
        }
    }
}
