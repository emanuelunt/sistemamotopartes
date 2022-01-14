using System;
using System.Collections.Generic; // Para trabajar con listas 
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient; // para trabajar con el motor de base de Datos MySQL
using System.Data.Common; // para trabajar con la  conexión genérica a nuestro motor de base de datos
using System.Data;


namespace MotoPartesErazo.Datos
{
    public class DBHelper
    {
        // propiedades
        private string _CadenaDeConexion = "";
        private DbConnection _Conexion; //clase abstracta la cual representa una conexion a un Motor DB, para trabajar con cualquier motor de base de datos
        private DbCommand _Comando; // clase abstracta  la cual ejecutara una sentencia SLQ o procedimiento Almacenado, se puede trabajar con cualquier motor de DB
        private DbProviderFactory _MotorDB = null; // Clase abstracta que nos da los metodo o conjunto de metodos para crear instancias de conexion a distentos 
        // motores de base de datos, en este caso utilizaremos MySQL.
        private DbProveedor _MotorProvedor;// objeto ENUM donde tendremos una lista de los diferentes tipos de base de datos.(se define mas abajo el tipo enum)
        private CommandType _TipoComando; // Objeto del tipo ENUM, idicamos si vamos trabajar con procedimiento almacenado o consultas planas
        //osea como se interpresta  la propiedad  COmmandText del comando (1 = query o consulta, 4 = procedimientos almacenado, 512 = tableDirect)


            // Getters y Setters
        public string CadenaDeConexion { get => _CadenaDeConexion; set => _CadenaDeConexion = value; }
        public DbConnection Conexion { get => _Conexion; set => _Conexion = value; }
        public DbCommand Comando { get => _Comando; set => _Comando = value; }
        public DbProviderFactory MotorDB { get => _MotorDB; set => _MotorDB = value; }
        public DbProveedor MotorProvedor { get => _MotorProvedor; set => _MotorProvedor = value; }
        public CommandType TipoComando { get => _TipoComando; set => _TipoComando = value; }


        // Método Constructor
        public DBHelper(string CadenaConexion, CommandType TipoComando,DbProveedor MotorDB = DBHelper.DbProveedor.MySQL )
        {
            _MotorProvedor = MotorDB;

            _TipoComando = TipoComando; // trabajamos con procedimiento almacenado

            _MotorDB = MySqlClientFactory.Instance; // obtenemos todo los metodos para trabajar con MySQL

            _Conexion = _MotorDB.CreateConnection();// cresmo la conexión

            _Conexion.ConnectionString = CadenaConexion; // le pasamos la cadena de conexión a la conexión creada

            _Comando = _MotorDB.CreateCommand(); // creamos el comando que ejecutara las sentecias en la base de dato

            _Comando.Connection = _Conexion;// le indicamos al comando la conexión que utilizara.


        }


        //Método que se encargara de Inicializar las Transancciones contra la Base de datos
        private void IniciarTransaccion()
        {
            if (_Conexion.State == ConnectionState.Closed)
            {
                _Conexion.Open();
            }
            _Comando.Transaction = _Conexion.BeginTransaction();
        }


        //Método encargado de confirmar la transacción en la base de datos
        private void ConfirmarTransaccion()
        {
            if (_Conexion.State == ConnectionState.Open)
            {

                _Comando.Transaction.Commit();
                _Conexion.Close();
            }
        }

        //Método encargado de deshacer las operacion contra la base de datos que quedaron incompleta
        private void RevertirTransaccion()
        {
            if (_Conexion.State == ConnectionState.Open)
            {
                _Comando.Transaction.Rollback();
                _Conexion.Close();
            }
        }


        // Método  CRUD es el acrónimo de "Crear, Leer, Actualizar y Borrar"
        public int CRUD(string consulta)
        {
            _Comando.CommandText = consulta; //  le pasamos la consulta o el procedimiento almacenado, en este caso le pasamos el nombre del procedimiento
            _Comando.CommandType = _TipoComando; // le indicamos al comando que usaremos procedimiento almacenado
            int resultado = -1; // guardara el número de filas afectadas. cuando se ejecute un comando  contra la base de datos

            try
            {
                if (_Conexion.State == ConnectionState.Closed)
                {
                    _Conexion.Open();
                }
                IniciarTransaccion();
                resultado = _Comando.ExecuteNonQuery();
                ConfirmarTransaccion();
            }
            catch (Exception error)
            {
                RevertirTransaccion();
                // Logs con una clase almacenar todo los errores                
            }

            finally // este método se ejcute siempre 
            {
                _Comando.Parameters.Clear();
                if (_Conexion.State == ConnectionState.Open)
                {
                    _Conexion.Close();
                    _Conexion.Dispose();
                    _Comando.Dispose();
                }
            }

            return resultado;            
        }


        // Método co el cual obtenemos una tabla a partir de una consulta 
        public DataTable ObtenerTabla(string consulta)
        {
            DbDataAdapter adaptador = _MotorDB.CreateDataAdapter();
            _Comando.CommandText = consulta;
            _Comando.CommandType = _TipoComando;

            adaptador.SelectCommand = _Comando; // le indicamos al adaptador cual es el comando a utilizar.

            DataSet tabla = new DataSet(); // definimos un dataset dond guardaremos la tabla que obtemos al ejecutar la consulta, se guarda en memoria.

            try
            {
                adaptador.Fill(tabla); // el comando ejecuto la consulta se lo entrego al adapatador y el adaptador llena el dataset(tabla) con la información

            }
            catch (Exception error)
            {

                //Logs
            }

            finally
            {
                _Comando.Parameters.Clear();
                if (_Conexion.State == ConnectionState.Open)
                {
                    _Conexion.Close();
                    _Conexion.Dispose();
                    _Comando.Dispose();
                }
            }

            return tabla.Tables[0];
        }


        //Método que nos permitira agregar o manejar los parámetros en el comando, osea nos permitira enviar parámetros a nuestras procediemintos almacenados
        public int AgregarParametro(string nombre, object valor)
        {
            DbParameter parametro = _MotorDB.CreateParameter(); // creamos el parámetro
            parametro.ParameterName = nombre;
            parametro.Value = valor;

            return _Comando.Parameters.Add(parametro);
        }











        // Lista de proveedores de bases de datos
        public enum DbProveedor
        {
            MySQL, SqlServer, Oracle, OleDb,SQLite
        }
    }
}
