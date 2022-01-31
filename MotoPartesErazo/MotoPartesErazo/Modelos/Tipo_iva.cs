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
    public class Tipo_iva
    {
        private readonly DBHelper DB = new DBHelper(ClsComun.CadenaConexion, CommandType.StoredProcedure);
        private readonly string entidad = "Tipo de IVA";

        private int id_tipo_iva;
        private string nombre;
        private byte discrimina_iva;
        private byte enviado;
        private byte cuit_opcional;

        /* Getters y Setters*/
        public int Id_tipo_iva { get => id_tipo_iva; set => id_tipo_iva = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public byte Discrimina_iva { get => discrimina_iva; set => discrimina_iva = value; }
        public byte Enviado { get => enviado; set => enviado = value; }
        public byte Cuit_opcional { get => cuit_opcional; set => cuit_opcional = value; }

        /*Métodos*/

        //  método  devuelve todos los registros de la tabla tipo de iva 
        public DataTable Lista() => DB.ObtenerTabla("sp_tipoiva_lista");

        // método que crea nuevos tipo de iva
        public string Crear()
        {
            int resultado;

            // creamos los parametros y los agreamos al comando para que ejecute el procedimiento almacenado en la base de datos
            DB.AgregarParametro("nombre_", this.Nombre);
            DB.AgregarParametro("discriminaIva_", this.Discrimina_iva);
            DB.AgregarParametro("enviado_", this.Enviado);
            DB.AgregarParametro("cuit_opcional_", this.Cuit_opcional);
           
            resultado = DB.CRUD("sp_tipoiva_crear");

            return (resultado == 1 ? $"{ClsComun.FilaCreada} {entidad} " : ClsComun.NoFilasAgregada);
        }

        public string Actualizar() // actualiza registros
        {
            int resultado;

            DB.AgregarParametro("id_tipo_iva_", this.Id_tipo_iva);

            DB.AgregarParametro("nombre_", this.Nombre);
            DB.AgregarParametro("discriminaIva_", this.Discrimina_iva);
            DB.AgregarParametro("enviado_", this.Enviado);
            DB.AgregarParametro("cuit_opcional_", this.Cuit_opcional);

            resultado = DB.CRUD("sp_tipoiva_actualizar");

            return (resultado == 1 ? $"{ClsComun.FilaActualizada} {entidad} " : ClsComun.NoFilasActualizada);
        }

        public string Eliminar() // eliminar registros
        {
            int resultado;

            DB.AgregarParametro("id_tipo_iva_", this.Id_tipo_iva);

            resultado = DB.CRUD("sp_tipoiva_eliminar");

            return (resultado == 1 ? $"{ClsComun.FilaEliminada} {entidad} " : ClsComun.NoFilasEliminada);
        }

        public DataTable Buscar(string txtbuscar)// Buscar registros
        {
            DB.AgregarParametro("txt_", txtbuscar);

            return DB.ObtenerTabla("sp_tipoiva_buscar");
        }

        public bool ExisteTipo_iva(string nombre)// este método verifica que no se repita impuesto.
        {
            DB.AgregarParametro("nombre_", nombre);

            DataTable info = DB.ObtenerTabla("sp_tipoiva_existe");

            return (info != null && info.Rows.Count > 0 ? true : false);
        }
    }
}
