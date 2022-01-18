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
    public class Articulo
    {
        private readonly DBHelper DB = new DBHelper(ClsComun.CadenaConexion,CommandType.StoredProcedure);
        private readonly string entidad = "Artículos";

        private int id_articulo;
        private string codigo_interno;
        private string nombre;
        private string descripcion;
        private string modelo;
        private string marca;
        private decimal costo;
        private decimal precio;
        private decimal lista1;
        private decimal lista2;
        private DateTime fecha_creado;
        private int stock;
        private int minimo;
        private int idImpuesto;
        private int idProveedor;
        private int idUnidad_medida;
        private bool servicio; // en la base de guarda 0 o 1, si esta en 1 verdadero es un servicio y no un articulo.
        private int idCodigoBarra;
        private int idRubro;
        private int descuento; // representa un porcentaje de descuento.
        private bool estado;// enla base de guarda 0 o 1 indica si el articulo esta activo o no.
        private byte[] imagen;


        // Getters y Setters
        public int Id_articulo { get => id_articulo; set => id_articulo = value; }
        public string Codigo_interno { get => codigo_interno; set => codigo_interno = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public string Marca { get => marca; set => marca = value; }
        public decimal Costo { get => costo; set => costo = value; }
        public decimal Precio { get => precio; set => precio = value; }
        public decimal Lista1 { get => lista1; set => lista1 = value; }
        public decimal Lista2 { get => lista2; set => lista2 = value; }
        public DateTime Fecha_creado { get => fecha_creado; set => fecha_creado = value; }
        public int Stock { get => stock; set => stock = value; }
        public int Minimo { get => minimo; set => minimo = value; }
        public int IdImpuesto { get => idImpuesto; set => idImpuesto = value; }
        public int IdProveedor { get => idProveedor; set => idProveedor = value; }
        public int IdUnidad_medida { get => idUnidad_medida; set => idUnidad_medida = value; }
        public bool Servicio { get => servicio; set => servicio = value; }
        public int IdCodigoBarra { get => idCodigoBarra; set => idCodigoBarra = value; }
        public int IdRubro { get => idRubro; set => idRubro = value; }
        public int Descuento { get => descuento; set => descuento = value; }
        public bool Estado { get => estado; set => estado = value; }
        public byte[] Imagen { get => imagen; set => imagen = value; }



        /*   Métodos */

        public DataTable Datos()// con este métdo obtenemos todos los datos de la tabla artículo
        {
            return DB.ObtenerTabla("sp_articulo_datos");
        }

        // Idem al métod anterior
        public DataTable Lista() => DB.ObtenerTabla("sp_articulos_lista");

        // métdo que crea nuevos articulos
        public string Crear()
        {
            int resultado;

            // creamos los parametros y los agreamos al comando para que ejecute el procedimeintos almacenado en la base de datos
            DB.AgregarParametro("codigo_interno_",this.Codigo_interno);
            DB.AgregarParametro("nombre_",this.Nombre);
            DB.AgregarParametro("descripcion_",this.Descripcion);
            DB.AgregarParametro("modelo_",this.Modelo);
            DB.AgregarParametro("marca_",this.Marca);
            DB.AgregarParametro("costo_",this.Costo);
            DB.AgregarParametro("precio_",this.Precio);
            DB.AgregarParametro("lista1_",this.Lista1);
            DB.AgregarParametro("lista2_",this.Lista2);
            DB.AgregarParametro("fecha_creado_",this.Fecha_creado);
            DB.AgregarParametro("stock_",this.Stock);
            DB.AgregarParametro("minimo_",this.Minimo);
            DB.AgregarParametro("idImpuesto_",this.IdImpuesto);
            DB.AgregarParametro("idProveedor_",this.IdProveedor);
            DB.AgregarParametro("idUnidad_medida_",this.IdUnidad_medida);
            DB.AgregarParametro("servicio_",this.Servicio);
            DB.AgregarParametro("idCodigoBarra_",this.IdCodigoBarra);
            DB.AgregarParametro("idRubro_",this.IdRubro);
            DB.AgregarParametro("descuento_",this.Descuento);
            DB.AgregarParametro("estado_",this.Estado);
            DB.AgregarParametro("imagen_",this.Imagen);

            resultado = DB.CRUD("sp_articulo_crear");

            return (resultado == 1 ? $"{ClsComun.FilaCreada} {entidad} " : ClsComun.NoFilasAgregada);


        }


    }
}
