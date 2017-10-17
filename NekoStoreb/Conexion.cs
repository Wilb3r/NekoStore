using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace NekoStoreb
{
   public class Conexion
    {
        MySqlConnection Coneccion = new MySqlConnection();
        private string Host = "localhost";
        private string DbName = "nekoobd";
        private string User = "root";
        private string Pass = "";
        bool BanderaConeccion = false;


        /// <summary>
        /// Esta funcion nos abre la conexión a la base de datos
        /// </summary>
        /// <returns>Nos retorna la conexión</returns>


        public MySqlConnection openBd()
        {

            try
            {
                string cadenaConeccion = "Server=" + Host + ";Database=" + DbName + ";User id=" + User + ";Password=" + Pass + ";ConvertZeroDatetime=True;AllowZeroDatetime=True";
                Coneccion.ConnectionString = cadenaConeccion;
                Coneccion.Open();
                BanderaConeccion = true;
            }
            catch (MySqlException ex)
            {

               // MessageBox.Show("No se puede conectar a la base de datos", ex.ToString());
            }

            return Coneccion;
        }

        /// <summary>
        /// Funcion que cierra la conexión a la base de datos
        /// </summary>
        public void closeBd()
        {
            if (BanderaConeccion)
            {
                try
                {
                    Coneccion.Close();
                    BanderaConeccion = false;
                }
                catch (MySqlException ex)
                {

                    MessageBox.Show("Error al cerrar la conexion." + ex);
                }
            }
        }
    }
}
