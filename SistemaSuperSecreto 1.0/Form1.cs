using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaSuperSecreto_1._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close(); //cierra mi formulario
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if(txtUsuario.Text=="juancho" && txtContra.Text=="123tamarindo")
            {
                MessageBox.Show("Bienvenido Señor Don Juancho");
                //Creamos y cargamos la nueva ventana
                this.Hide(); //minimiza o esconde el login
                VentanaPrincipal CursosVentana = new VentanaPrincipal();
                CursosVentana.Show(); //Llamamos la ventana
               


            }else
            {
                MessageBox.Show("Error en contraseña, vuelva a intentarlo");
                txtUsuario.Text = "";
                txtContra.Text = "";
                txtUsuario.Focus();
            }
        }
    }
}
