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
    public partial class fArticulos : Form
    {
        public fArticulos()
        {
            InitializeComponent();
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fArticulos_Load(object sender, EventArgs e)
        {
            dataGrid_Articulos.Rows.Add(2, 2365,"Patillas de frenos",3,"Honda biz","china",125.23,"Pastilla de frenos para biz y gerero");
            dataGrid_Articulos.Rows.Add(23, 2365, "Aceite motul 5100",2, "Honda biz", "china", 125.23, "Pastilla de frenos para biz y gerero");
            dataGrid_Articulos.Rows.Add(22, 2365, "Cubierta 125x25x332",5, "Honda biz", "china", 125.23, "Pastilla de frenos para biz y gerero");
            dataGrid_Articulos.Rows.Add(5, 2455, "Platicos twiter", 10, "Honda biz", "china", 125.23, "Pastilla de frenos para biz y gerero");
            dataGrid_Articulos.Rows.Add(65, 23265, "Patillas de frenos", 6, "Honda biz", "china", 125.23, "Pastilla de frenos para biz y gerero");
            dataGrid_Articulos.Rows.Add(3, 23255, "Embrague Honda 125cc", 1, "Honda biz", "china", 125.23, "Embrague para honda 1252, tambine le va  al gillera 200");
            dataGrid_Articulos.Rows.Add(67, 235, "Patillas de frenos", 5, "Honda biz", "china", 125.23, "Pastilla de frenos para biz y gerero");
            dataGrid_Articulos.Rows.Add(21, 21265, "Patillas de frenos", 2, "Honda biz", "china",125.23, "Pastilla de frenos para biz y gerero");
        }
    }
}
