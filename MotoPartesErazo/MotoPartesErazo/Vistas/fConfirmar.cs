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
    public partial class fConfirmar : Form
    {
        public fConfirmar(string titulo_)
        {
            InitializeComponent();

            if (!string.IsNullOrEmpty(titulo_))
                this.etTitulo.Text = titulo_;


            this.Padding = new Padding(3); // paddin del formulario para darle sensacion de borde
            this.BackColor = Color.CornflowerBlue;
        }

        private void pictureBoxIcono_Click(object sender, EventArgs e)
        {

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Si_Click(object sender, EventArgs e)
        {

        }
    }
}
