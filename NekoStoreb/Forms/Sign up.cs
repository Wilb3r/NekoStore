using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace NekoStoreb.Forms
{
    public partial class Sign_up : Form
    {
        MySqlConnection Con = new MySqlConnection();
        MySqlCommand comand = new MySqlCommand();
        public Conexion obj = new Conexion();

        MenuPrincipal objMenuPrincipal = new MenuPrincipal();
        CatCollar objCatCollar = new CatCollar();
        Capturar objCapturar = new Capturar();
        Consultas objConsultas = new Consultas();

        public Sign_up()
        {
            InitializeComponent();
        }

        private void Registrar_Enter(object sender, EventArgs e)
        {

        }

        private void Sign_up_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            
            try
            {

                objCapturar.capturarUsuario = txtNombreRegistrarse.Text;
                objCapturar.capturarContraseña = txtContraseñaRegistrarse.Text;
                objCapturar.capturarDireccion = txtUbicacionRegistrarse.Text;

                Con = obj.openBd();

                string sql = "select count(*) from usuario where usuarioo=@nombre";
                MySqlCommand cmd = new MySqlCommand(sql, Con);
                cmd.Parameters.AddWithValue("@nombre", txtNombreRegistrarse.Text);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                if (count == 0)
                {
                    objConsultas.agregarUsuario(objCapturar);
                    MessageBox.Show("El usuario se ha agregado correctamente");
                }

                else
                {
                    MessageBox.Show("El usuario ya existe");

                }


                comand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                MessageBox.Show("El error es " + ex);
            }
            finally
            {
                obj.closeBd();
            }

        }

        private void btnIniciarSeccion_Click(object sender, EventArgs e)
        {
            try
            {
               
                Con = obj.openBd();

                MySqlCommand cmd = new MySqlCommand("SELECT * FROM usuario WHERE usuarioo='" + txtNombreIniciar.Text + "'AND contraseña='" + txtContraseñaIniciar.Text + "' ", Con); //Realizamos una selecion de la tabla usuarios.
                MySqlDataReader leer = cmd.ExecuteReader();


                    if (leer.Read()) //Si el usuario es correcto nos abrira la otra ventana.
                {
                    MessageBox.Show("Sesion iniciada");
                    objMenuPrincipal.Show();
                    this.Hide();
                }
                else
                {
                    
                    MessageBox.Show("Sesion no iniciada");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede Listar " + ex);
            }
            finally
            {
                obj.closeBd();
            }
            
        }
    }
}
