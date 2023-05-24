using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

using System.Threading.Tasks;
using System.Data;

using System.Data.SqlTypes;


namespace PROYECTO_FORMS_DAT_BASE_REGISTRO
{
    class conexionBD
    {

        string cadena = "Data Source=DESKTOP-J1L81GP\\SQLEXPRESS;Initial Catalog=Registro;Integrated Security=True";
        public SqlConnection conectarbd = new SqlConnection();

        public conexionBD()
        {
            conectarbd.ConnectionString = cadena;
        }

        public void abrir()
        {
            try
            {
                conectarbd.Open();
                Console.WriteLine("Completado");

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error no se pudo conectar a la Base de Datos !! comuniquese a soporte!!!!" + ex.Message);
            }

        }

        public void cerrar()
        {
            conectarbd.Close();
        }
    }
}
