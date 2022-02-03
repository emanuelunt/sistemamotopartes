using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MotoPartesErazo.ConfigGlobal;
using MotoPartesErazo.Modelos;


namespace MotoPartesErazo.Vistas
{
    public partial class fImpuesto : Form
    {
        private readonly Impuesto impu = new Impuesto(); // declaramos un objeto del tipo Impuesto.
        private readonly Tipo_iva tipo = new Tipo_iva(); // declaramos un objeto de la clase Tipo iva.

        // declaramos dos data table para poder manipular las tablas Impuesto y tipo de iva

        private DataTable TBimpuesto = new DataTable();
        private DataTable TBtipo_iva = new DataTable();



        public fImpuesto()
        {
            InitializeComponent();
            this.Datos();
            
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /* Metodos*/
        public void Datos() // Método que carga de datos el datagrid
        {
            this.dataGrid_Impuesto.Columns.Clear();
            this.TBimpuesto = impu.Datos();
            this.dataGrid_Impuesto.DataSource = TBimpuesto;

            this.dataGrid_Impuesto.RowTemplate.Height = 40; // define la altura de las filas del datagrid
            this.dataGrid_Impuesto.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.dataGrid_Impuesto.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

     /*   private void Lista_tipoIva()
        {
            this.TBtipo_iva = tipo.Lista();
        }  */

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            // f_Impuesto nuevo = new f_Impuesto(false);// mandamo  con el valor false porque es para crear un nuevo registro
            // nuevo.Show();

            f_Impuesto nuevo = new f_Impuesto(false);
            AddOwnedForm(nuevo);
            nuevo.Show();
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            this.Eliminar();
        }
        private void Eliminar()
        {

            fConfirmar ventan = new fConfirmar("Esta por eliminar un registro");

            if (ventan.ShowDialog() == DialogResult.Yes)
            {
                int fila = dataGrid_Impuesto.CurrentRow.Index;
                this.impu.Id_impuesto = int.Parse(dataGrid_Impuesto.Rows[fila].Cells[0].Value.ToString());
                ClsComun.Mensaje(impu.Eliminar(),"Elimnar",fMensajes.TipoIcono.advertencia);
                this.Datos();
            }

            

        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {

            impu.Id_impuesto = int.Parse(dataGrid_Impuesto.Rows[dataGrid_Impuesto.CurrentRow.Index].Cells[0].Value.ToString());
            impu.Nombre = dataGrid_Impuesto.Rows[dataGrid_Impuesto.CurrentRow.Index].Cells[1].Value.ToString();
            impu.Olicuota = decimal.Parse(dataGrid_Impuesto.Rows[dataGrid_Impuesto.CurrentRow.Index].Cells[2].Value.ToString());
            impu.Id_tipo_iva = ObtenerId(dataGrid_Impuesto.Rows[dataGrid_Impuesto.CurrentRow.Index].Cells[3].Value.ToString());
            impu.Importe_neto = decimal.Parse(dataGrid_Impuesto.Rows[dataGrid_Impuesto.CurrentRow.Index].Cells[4].Value.ToString());
            impu.Importe_bruto = decimal.Parse(dataGrid_Impuesto.Rows[dataGrid_Impuesto.CurrentRow.Index].Cells[5].Value.ToString());


            f_Impuesto nuevo = new f_Impuesto(true,impu);
            AddOwnedForm(nuevo);
            nuevo.Show();
        }

        private int ObtenerId(string txt_) // busca el id del tipo de inpuesto
        {
            TBtipo_iva = tipo.Buscar(txt_);
            int id = int.Parse(TBtipo_iva.Rows[0][0].ToString());
            return id;
        }

    }
}
