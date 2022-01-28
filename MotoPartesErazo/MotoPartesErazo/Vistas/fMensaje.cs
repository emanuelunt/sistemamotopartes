using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MotoPartesErazo.Vistas
{
    public partial class fMensajes : Form
    {
        private string mensaje = "";
        private string titulo = "";
        private Image icono;


        

        public fMensajes()
        {
            InitializeComponent();
           
            this.Padding = new Padding(3); // paddin del formulario para darle sensacion de borde
            this.BackColor = Color.CornflowerBlue;


            
        }

        public fMensajes(string mensaje_,string titulo_, TipoIcono tipo_)
        {
            InitializeComponent();

            this.Padding = new Padding(3); // padin del formulario para darle sensacion de borde
            this.BackColor = Color.CornflowerBlue;
            this.mensaje = mensaje_;
            this.titulo = titulo_;

            string ruta = System.IO.Directory.GetCurrentDirectory();

            

            switch (tipo_)
            {
                case TipoIcono.advertencia:
                    icono = Image.FromFile(ruta + "\\Resursos\\IconosMensajes\\exclamation.png");
                    pictureBoxIcono.Image = icono;
                    break;
                case TipoIcono.consulta:
                    icono = Image.FromFile(ruta + @"\Resursos\IconosMensajes\question.png");
                    pictureBoxIcono.Image = icono;
                    break;
                case TipoIcono.error:
                    icono = Image.FromFile(ruta + @"\Resursos\IconosMensajes\error.png");
                    pictureBoxIcono.Image = icono;
                    break;
                case TipoIcono.informacion:
                    icono = Image.FromFile(ruta + @"\Resursos\IconosMensajes\information.png");
                    pictureBoxIcono.Image = icono;
                    break;                    
                default:
                    icono = Image.FromFile(ruta + @"\Resursos\IconosMensajes\chat.png");
                    pictureBoxIcono.Image = icono;
                    break;
            }
        }

        
        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelBarraTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fMensajes_Shown(object sender, EventArgs e)
        {
            etMensaje.Text = this.mensaje;
            etTitulo.Text = this.titulo;
            pictureBoxIcono.Image = this.icono;
        }

        private void fMensajes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

        // Lista de proveedores de bases de datos
        public enum TipoIcono
        {
            chat, error, advertencia, informacion, consulta
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fConfirmar ventana = new fConfirmar("Eliminar");

            DialogResult resultado = ventana.ShowDialog();

            MessageBox.Show(resultado.ToString());

        }
    }
}
