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
    public class Impuesto
    {
        private readonly DBHelper DB = new DBHelper(ClsComun.CadenaConexion, CommandType.StoredProcedure);
        private readonly string entidad = "Impuesto";

        private int id_impuesto;
        private string nombre;
        private decimal olicuota;
        private int id_tipo_iva;
        private decimal importe_neto;
        private decimal importe_bruto;
        private int tipo;
        private int enviado;
        private int empresa;
        private int recibo;

        /* Getters y Setters*/
        public int Id_impuesto { get => id_impuesto; set => id_impuesto = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public decimal Olicuota { get => olicuota; set => olicuota = value; }
        public int Id_tipo_iva { get => id_tipo_iva; set => id_tipo_iva = value; }
        public decimal Importe_neto { get => importe_neto; set => importe_neto = value; }
        public decimal Importe_bruto { get => importe_bruto; set => importe_bruto = value; }
        public int Tipo { get => tipo; set => tipo = value; }
        public int Enviado { get => enviado; set => enviado = value; }
        public int Empresa { get => empresa; set => empresa = value; }
        public int Recibo { get => recibo; set => recibo = value; }

        /*   Métodos */

        public DataTable Datos()// con este método obtenemos todos los datos de la tabla impuesto
        {
            return DB.ObtenerTabla("sp_impuesto_datos");
        }

        // Idem al método anterior
        public DataTable Lista() => DB.ObtenerTabla("sp_impuesto_lista");

        // método que crea nuevos Impuestos
        public string Crear()
        {
            int resultado;

            // creamos los parametros y los agreamos al comando para que ejecute el procedimeintos almacenado en la base de datos
            DB.AgregarParametro("nombre_", this.Nombre);
            DB.AgregarParametro("olicuota_", this.Olicuota);
            DB.AgregarParametro("id_tipo_iva_", this.Id_tipo_iva);
            DB.AgregarParametro("importe_neto_", this.Importe_neto);
            DB.AgregarParametro("importe_bruto_", this.Importe_bruto);
            DB.AgregarParametro("tipo_", this.Tipo);
            DB.AgregarParametro("enviado_", this.Enviado);
            DB.AgregarParametro("empresa_", this.Empresa);
            DB.AgregarParametro("recibo_", this.Recibo);
            

            resultado = DB.CRUD("sp_impuesto_crear");

            return (resultado == 1 ? $"{ClsComun.FilaCreada} {entidad} " : ClsComun.NoFilasAgregada);

        }
        public string Actualizar() // actualiza registros
        {
            int resultado;

            DB.AgregarParametro("id_impuesto_", this.Id_impuesto);

            DB.AgregarParametro("nombre_", this.Nombre);
            DB.AgregarParametro("olicuota_", this.Olicuota);
            DB.AgregarParametro("id_tipo_iva_", this.Id_tipo_iva);
            DB.AgregarParametro("importe_neto_", this.Importe_neto);
            DB.AgregarParametro("importe_bruto_", this.Importe_bruto);
            DB.AgregarParametro("tipo_", this.Tipo);
            DB.AgregarParametro("enviado_", this.Enviado);
            DB.AgregarParametro("empresa_", this.Empresa);
            DB.AgregarParametro("recibo_", this.Recibo);

            resultado = DB.CRUD("sp_impuesto_actualizar");

            return (resultado == 1 ? $"{ClsComun.FilaActualizada} {entidad} " : ClsComun.NoFilasActualizada);
        }

        public string Eliminar() // eliminar registros
        {
            int resultado;

            DB.AgregarParametro("id_impuesto_", this.Id_impuesto);

            resultado = DB.CRUD("sp_impuesto_eliminar");

            return (resultado == 1 ? $"{ClsComun.FilaEliminada} {entidad} " : ClsComun.NoFilasEliminada);
        }

        public DataTable Buscar(string txtbuscar)// Buscar registros
        {
            DB.AgregarParametro("txt_", txtbuscar);

            return DB.ObtenerTabla("sp_impuesto_buscar");
        }

        //public bool HasComprobantesDetalles(int impuesto_id)// Este método verifica que no exite ningun tipo de iva en la tabla Tipo_iva.
        //{//                                                    relacionado con un impuesto para poder eliminar.     
        //    DB.AgregarParametro("id_impuesto_", impuesto_id);

        //    DataTable info = DB.ObtenerTabla("sp_impuesto_hasTipoIva");

        //    return (info != null && info.Rows.Count > 0 ? true : false);

        //}

        public bool ExisteImpuesto(string nombre)// este método verifica que no se repita impuesto.
        {
            DB.AgregarParametro("nombre_", nombre);

            DataTable info = DB.ObtenerTabla("sp_impuesto_existe");

            return (info != null && info.Rows.Count > 0 ? true : false);

        }
    }
}
