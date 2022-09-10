using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace SistemaSuperSecreto_1._0
{
    public partial class VentanaPrincipal : Form
    {
        public VentanaPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 formulario = new Form1();
            formulario.Visible = true;
        }

        private void VentanaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            int conteo = 0;
            string seleccion;

            if(cbVisualC.Checked==true)
            {
                conteo++;
            }
            if(cbVisualBasic.Checked==true)
            {
                conteo++;
            }
            if(rbTarjeta.Checked==true)
            {
                seleccion = "Tarjeta de Crédito";
            }else
            {
                seleccion = "Paypal";
            }

            MessageBox.Show("Ha seleccionado " + conteo + " cursos y su método de pago es mediante " + seleccion);
        }
    }
}
