using MotoPartesErazo.ConfigGlobal;
using MotoPartesErazo.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotoPartesErazo.Modelos
{
    public class articulo_x_cod_barra
    {
        private readonly DBHelper DB = new DBHelper(ClsComun.CadenaConexion, CommandType.StoredProcedure);
        private readonly string entidad = "articulo_x_cod_barra";

        private int id_codbarra;
        private string codigo_barra;
        private string codigo_articulo;
        private int empresa;

        /*  Gettes y Settes*/
        public int Id_codbarra { get => id_codbarra; set => id_codbarra = value; }
        public string Codigo_barra { get => codigo_barra; set => codigo_barra = value; }
        public string Codigo_articulo { get => codigo_articulo; set => codigo_articulo = value; }
        public int Empresa { get => empresa; set => empresa = value; }

        /* Métodos de las clase */

        public DataTable Datos()// con este método obtenemos todos los datos de la tabla articulo_x_cod_barra junto con los artículos
        {
            return DB.ObtenerTabla("sp_articulo_x_cod_barra_datos");
        }

        // Idem al método devuelve solo los registros de la tabla articulo_x_cod_barra
        public DataTable Lista() => DB.ObtenerTabla("sp_articulo_x_cod_barra_lista");

        public DataTable CodigoBarra(string idcodbarra) // Método que devuelve los codigo de barra asociado a un articulo.(en teoria deveria devolver un solo codigo de barra)
        {
            DB.AgregarParametro("idCodbarra_",idcodbarra);
            return (DB.ObtenerTabla("sp_articulo_codBarra"));
        }

        public string Crear() // Método que se utiliza para crear un registro
        {
            int resultado;

            DB.AgregarParametro("codBarra_",this.Codigo_barra);
            DB.AgregarParametro("codigoArticulo_",this.Codigo_articulo);
            DB.AgregarParametro("empresa_",this.Empresa);

            resultado = DB.CRUD("sp_articulo_x_cod_barra_crear");

            return (resultado == 1 ? $"{ClsComun.FilaCreada} {entidad}" : ClsComun.NoFilasAgregada);

        }

        public string Actualizar()
        {
            int resultado;

            DB.AgregarParametro("id_",this.Id_codbarra);
            DB.AgregarParametro("codBarra_", this.Codigo_barra);
            DB.AgregarParametro("codigoArticulo_", this.Codigo_articulo);
            DB.AgregarParametro("empresa_", this.Empresa);

            resultado = DB.CRUD("sp_articulo_x_cod_barra_actualizar");

            return (resultado == 1 ? $"{ClsComun.FilaActualizada} {entidad}" : ClsComun.NoFilasActualizada);
        }


        public string Eliminar()
        {
            int resultado;

            DB.AgregarParametro("id_", this.Id_codbarra);

            resultado = DB.CRUD("sp_articulo_x_cod_barra_eliminar");

            return (resultado == 1 ? $"{ClsComun.FilaEliminada} {entidad}" : ClsComun.NoFilasEliminada);
        }

        public DataTable Buscar(string txtbuscar)
        {
            DB.AgregarParametro("txt_",txtbuscar);
            return (DB.ObtenerTabla("sp_articulo_x_cod_barra_buscar"));
        }




    }
}
