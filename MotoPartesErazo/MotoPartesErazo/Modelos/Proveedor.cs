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
    public class Proveedor
    {
        private readonly DBHelper DB = new DBHelper(ClsComun.CadenaConexion, CommandType.StoredProcedure);
        private readonly string entidad = "Proveedor";

        private int id_proveedor;
        private string nombre;
        private string cuit_cuil;
        private int id_condicion_iva;
        private string contacto;
        private string telefono_fijo;
        private string telefono_movil;
        private string domicilio;
        private int id_localidad;
        private int id_provincia;
        private int id_pais;
        private int transporte;
        private string codigo_postal;
        private string fax;
        private string email;
        private string www;
        private int estado;
        private int empresa;
        private int enviado;

        /*  Getters y Setters  */
        public int Id_proveedor { get => id_proveedor; set => id_proveedor = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Cuit_cuil { get => cuit_cuil; set => cuit_cuil = value; }
        public int Id_condicion_iva { get => id_condicion_iva; set => id_condicion_iva = value; }
        public string Contacto { get => contacto; set => contacto = value; }
        public string Telefono_fijo { get => telefono_fijo; set => telefono_fijo = value; }
        public string Telefono_movil { get => telefono_movil; set => telefono_movil = value; }
        public string Domicilio { get => domicilio; set => domicilio = value; }
        public int Id_localidad { get => id_localidad; set => id_localidad = value; }
        public int Id_provincia { get => id_provincia; set => id_provincia = value; }
        public int Id_pais { get => id_pais; set => id_pais = value; }
        public int Transporte { get => transporte; set => transporte = value; }
        public string Codigo_postal { get => codigo_postal; set => codigo_postal = value; }
        public string Fax { get => fax; set => fax = value; }
        public string Email { get => email; set => email = value; }
        public string Www { get => www; set => www = value; }
        public int Estado { get => estado; set => estado = value; }
        public int Empresa { get => empresa; set => empresa = value; }
        public int Enviado { get => enviado; set => enviado = value; }

        /*   Métodos */

        public DataTable Datos()// con este método obtenemos todos los datos de la tabla proveedor y sus datos vinculados a otras tablas
        {
            return DB.ObtenerTabla("sp_proveedor_datos");
        }

        // Idem al método anterior pero solo trae los datos de la tabla proveedor
        public DataTable Lista() => DB.ObtenerTabla("sp_proveedor_lista");

        // método que crea nuevos proveedor
        public string Crear()
        {
            int resultado;

            // creamos los parametros y los agreamos al comando para que ejecute el procedimientos almacenado en la base de datos
            DB.AgregarParametro("nombre_", this.Nombre);
            DB.AgregarParametro("cuit_cuil_", this.Cuit_cuil);
            DB.AgregarParametro("id_condicion_iva_", this.Id_condicion_iva);
            DB.AgregarParametro("contacto_", this.Contacto);
            DB.AgregarParametro("telefono_fijo_", this.Telefono_fijo);
            DB.AgregarParametro("telefono_movil_", this.Telefono_movil);
            DB.AgregarParametro("domicilio_", this.Domicilio);
            DB.AgregarParametro("id_localidad_", this.Id_localidad);
            DB.AgregarParametro("id_provincia_", this.Id_provincia);
            DB.AgregarParametro("id_pais_", this.Id_pais);
            DB.AgregarParametro("transporte_",this.Transporte);
            DB.AgregarParametro("codigo_postal_", this.Codigo_postal);
            DB.AgregarParametro("fax_", this.Fax);
            DB.AgregarParametro("email_", this.Email);
            DB.AgregarParametro("www_", this.Www);
            DB.AgregarParametro("estado_", this.Estado);
            DB.AgregarParametro("empresa_", this.Empresa);
            DB.AgregarParametro("enviado_", this.Enviado);

            resultado = DB.CRUD("sp_proveedor_crear");

            return (resultado == 1 ? $"{ClsComun.FilaCreada} {entidad} " : ClsComun.NoFilasAgregada);
        }

        public string Actualizar() // actualiza registros
        {
            int resultado;

            DB.AgregarParametro("id_proveedor_", this.Id_proveedor);

            // creamos los parametros y los agreamos al comando para que ejecute el procedimientos almacenado en la base de datos
            DB.AgregarParametro("nombre_", this.Nombre);
            DB.AgregarParametro("cuit_cuil_", this.Cuit_cuil);
            DB.AgregarParametro("id_condicion_iva_", this.Id_condicion_iva);
            DB.AgregarParametro("contacto_", this.Contacto);
            DB.AgregarParametro("telefono_fijo_", this.Telefono_fijo);
            DB.AgregarParametro("telefono_movil_", this.Telefono_movil);
            DB.AgregarParametro("domicilio_", this.Domicilio);
            DB.AgregarParametro("id_localidad_", this.Id_localidad);
            DB.AgregarParametro("id_provincia_", this.Id_provincia);
            DB.AgregarParametro("id_pais_", this.Id_pais);
            DB.AgregarParametro("transporte_", this.Transporte);
            DB.AgregarParametro("codigo_postal_", this.Codigo_postal);
            DB.AgregarParametro("fax_", this.Fax);
            DB.AgregarParametro("email_", this.Email);
            DB.AgregarParametro("www_", this.Www);
            DB.AgregarParametro("estado_", this.Estado);
            DB.AgregarParametro("empresa_", this.Empresa);
            DB.AgregarParametro("enviado_", this.Enviado);

            resultado = DB.CRUD("sp_proveedor_actualizar");

            return (resultado == 1 ? $"{ClsComun.FilaActualizada} {entidad} " : ClsComun.NoFilasActualizada);
        }

        public string Eliminar() // eliminar registros
        {
            int resultado;

            DB.AgregarParametro("id_proveedor_", this.Id_proveedor);

            resultado = DB.CRUD("sp_proveedor_eliminar");

            return (resultado == 1 ? $"{ClsComun.FilaEliminada} {entidad} " : ClsComun.NoFilasEliminada);
        }

        public DataTable Buscar(string txtbuscar)// Buscar registros
        {
            DB.AgregarParametro("txt_", txtbuscar);

            return DB.ObtenerTabla("sp_proveedor_buscar");
        }

        public bool ExisteProveedor(string nombre)// este método verifica que no se repita proveedor.
        {
            DB.AgregarParametro("nombre_", nombre);

            DataTable info = DB.ObtenerTabla("sp_proveedor_existe");

            return (info != null && info.Rows.Count > 0 ? true : false);

        }
    }
}
