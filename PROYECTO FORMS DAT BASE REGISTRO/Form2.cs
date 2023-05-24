using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using System.Data.SqlClient;
using System.Data.SqlTypes;



namespace PROYECTO_FORMS_DAT_BASE_REGISTRO
{
    public partial class FrmRegistros : Form
    {
        public FrmRegistros()
        {
            InitializeComponent();
        }

        private void btnregresar_Click(object sender, EventArgs e)
        {
            this.Hide();  // Ocultamos el Formulario Actual
            Form Registros = new FrmInPrin();
        }

        private void FrmRegistros_Load(object sender, EventArgs e)
        {
           

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        { 
            
                conexionBD conexion = new conexionBD();
                conexion.abrir();

                string nombre = txtNombres.Text;
                string apellido = txtApellidos.Text;
                string Cui = txtCui.Text;
                string Correo = txtCorreo.Text;
                string departamento = txtDepartamento.Text;
                string municipio = txtMunicipio.Text;

                string cadena = "insert into registro (Nombres, Apellidos, Cui,CorreoElectronico, Departamento, Municipio) values ('" + txtNombres.Text + "', '" + txtApellidos.Text + "','" + txtCui.Text + "','" + txtCorreo.Text + "', '" + txtDepartamento.Text + "', '" + txtMunicipio.Text + "')";
                SqlCommand comando = new SqlCommand(cadena, conexion.conectarbd);
                comando.ExecuteNonQuery();
            MessageBox.Show("!!!!!Enpadronamiento con exito!!!!!!");

                txtNombres.Text = "";
                txtApellidos.Text = "";
                txtCui.Text = "";
                txtCorreo.Text = "";
                txtDepartamento.Text = "";
                txtMunicipio.Text = "";

            }
        }
}
