using MotoPartesErazo.ConfigGlobal;
using MotoPartesErazo.Modelos;
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
    public partial class f_Impuesto : Form
    {

        private bool crearActualizar;// con este miembro diferenciamos si es para ctualizar o es un nuevo regristro
                                     // si esta en true se actualiza si esta false se crea uno nuevo  
        private readonly Impuesto impo = new Impuesto();
        private readonly Tipo_iva tipo = new Tipo_iva(); // declaramos un objeto de la clase Tipo iva.

        private DataTable TBtipo_iva = new DataTable(); // cargamos la tabla tipo de iva



        public f_Impuesto(bool crear_actualizar_) // Constuctor
        {
            InitializeComponent();
            crearActualizar = crear_actualizar_;
            this.ListaTipoIva();
        }

        public f_Impuesto(bool crear_actualizar_ , Impuesto impo_) // Constructor
        {
            InitializeComponent();
            crearActualizar = crear_actualizar_;
            this.ListaTipoIva();

            impo.Id_impuesto = impo_.Id_impuesto;// asignamos al objeto que  va actualizar

            // asignar valores a los controles
            txt_impuesto.Text = impo_.Nombre;
            txt_alicuota.Text = impo_.Olicuota.ToString();

            //cmb_tipoIva.SelectedIndex = cmb_tipoIva.Items.Contains("Monotributo");
            //this.etTitulo.Text = cmb_tipoIva.SelectedValue.ToString();

            //  this.etTitulo.Text = 


            int indice = 0;
            foreach (DataRowView item in cmb_tipoIva.Items) // recorremos el combo buscando un tipo de iva para luego selecinarlo en el combo
            {
                if (item.Row["id_tipo_iva"].ToString() == impo_.Id_tipo_iva.ToString())
                {
                    cmb_tipoIva.SelectedIndex = indice;
                   //MessageBox.Show(item.Row["id_tipo_iva"].ToString());
                    
                }
                indice++;
            }
           
            txt_importeNeto.Text = impo_.Importe_neto.ToString();
            txt_importeBruto.Text = impo_.Importe_bruto.ToString();
            txt_impuesto.Focus();
            
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ListaTipoIva() // con este metodo cargamos el combobox
        {
            this.TBtipo_iva = tipo.Lista();
            cmb_tipoIva.DisplayMember = "nombre"; // establesemos que columna del data table vera el usuario
            cmb_tipoIva.ValueMember = "id_tipo_iva"; // establesemos que valor se obtiene a partir del item selecionado
            // ej: si se deleciona Resposable inscripto la propiedad SelectValue devolvera 5 porque ese es el id en la tabla.
            cmb_tipoIva.DataSource = TBtipo_iva; // llenamos el combo con los datos del datatable.

        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CrearActualizar()
        {
            fImpuesto principal = Owner as fImpuesto;

              
            
            if (string.IsNullOrEmpty(txt_impuesto.Text.Trim()))
            {
                ClsComun.Mensaje("Ingrese el nombre del impuesto","Completar Campo",fMensajes.TipoIcono.informacion);
                this.txt_impuesto.Focus();
                return;
            }

           
            MessageBox.Show(impo.Id_impuesto.ToString());
            impo.Nombre = txt_impuesto.Text.Trim();
            impo.Olicuota = decimal.Parse(txt_alicuota.Text.Trim().Replace(".",","));
            impo.Id_tipo_iva = int.Parse(cmb_tipoIva.SelectedValue.ToString());
            impo.Importe_neto = decimal.Parse(txt_importeNeto.Text.Trim().Replace(".", ","));
            impo.Importe_bruto = decimal.Parse(txt_importeBruto.Text.Trim().Replace(".", ","));

            ClsComun.Mensaje(this.crearActualizar ? impo.Actualizar() : impo.Crear(),this.crearActualizar ? "Actualizando Regitro" : "Nuevo Registro",fMensajes.TipoIcono.informacion);

            principal.Datos();

            this.Close();


        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
                        
            CrearActualizar();
        }
    }
}
