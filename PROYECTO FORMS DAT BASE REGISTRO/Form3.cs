using System;
using System.Data.SqlClient;
using System.Data;
using System.Runtime.ConstrainedExecution;
using System.Windows.Forms;


namespace PROYECTO_FORMS_DAT_BASE_REGISTRO
{
    public partial class FrmConsultas : Form
    {
        private readonly object ver;

        public FrmConsultas()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();  // Ocultamos el Formulario Actual
            Form Consultas = new FrmInPrin();
        }

        private void FrmConsultas_Load(object sender, EventArgs e)
        {
            conexionBD conexion = new conexionBD();
            conexion.abrir();

            string cadena = "SELECT * FROM registro";
            SqlCommand comando = new SqlCommand(cadena, conexion.conectarbd);
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);

            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);

            datConsultas.DataSource = tabla;
        }

        private void btnRegresar_Click_1(object sender, EventArgs e)
        {
           this.Hide();  // Ocultamos el Formulario Actual
            Form Consultas = new FrmInPrin();
        }
    }
}
