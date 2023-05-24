using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_FORMS_DAT_BASE_REGISTRO
{
    public partial class FrmInPrin : Form
    {
        public FrmInPrin()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            //Generamos la instancia hacia le formulario 
            Form Inicio = new FrmRegistros();
            this.Hide();  // Ocultamos el Formulario Actual
            Inicio.ShowDialog(); // Muestra el Formulario #2 Registros
            this.Show();  // muestra el Formulario #1 Inicio 


        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            //Generamos la instancia hacia le formulario 
            Form Inicio = new FrmConsultas();
            this.Hide();  // Ocultamos el Formulario Actual
            Inicio.ShowDialog(); // Muestra el Formulario #2 Registros
            this.Show();  // muestra el Formulario #1 Inicio 

        }
    }
}
