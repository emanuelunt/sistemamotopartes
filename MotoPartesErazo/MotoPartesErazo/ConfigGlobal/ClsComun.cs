using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotoPartesErazo.ConfigGlobal
{
    public class ClsComun
    {
        public static int bandera = 0;
        public static bool pagado = false;
        public static string Nombre_Ticket;


        public static readonly string version = "1.0.1";
        public static readonly string app = "MotoPartes";


        public static string Servidor = "192.168.1.50";
        public static string BaseDato = "motopartedb";
        public static string Usuario = "sebaerazo";
        public static string Password = "seba.admin";
        public static string CadenaConexion = $"Server={Servidor};Database={BaseDato};User id={Usuario};password={Password}";  // si ahy error agregar ;SSL Mode=None



        // Mesnajes de Crear, Leer, Actualizar y Borrar
        public static readonly string NoFilasAfectadas   = "Ningún registro eliminado";
        public static readonly string NoFilasAgregada    = "No se guardó el registro, intente nuevamente";
        public static readonly string NoFilasActualizada = "No se actualizó el registro";
        public static readonly string NoFilasEliminada = "No se eliminó el registro";

        public static readonly string FilaCreada      = "Se agregó correctamente el registro a la tabla";
        public static readonly string FilaEliminada   = "Se eliminó correctamente el registro de la tabla";
        public static readonly string FilaActualizada = "Se actualizó correctamente el registro en la tabla";

         


    }
}
