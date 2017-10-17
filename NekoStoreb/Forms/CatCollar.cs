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
using Microsoft.VisualBasic;

namespace NekoStoreb
{
    public partial class CatCollar : Form
    {
        public int acumul = 0;
        MySqlConnection Con = null;
        Conexion obj = new Conexion();
        int i;
        int aleGlobal;
        Capturar objCapturar = new Capturar();
        Consultas objConsultas = new Consultas();
        public string capturar;
        public CatCollar()
        {
            InitializeComponent();
        }

        private void pnlDesplegable_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMenuDesplegable_Click(object sender, EventArgs e)
        {
            if(pnlDesplegable.Height==359&&pnlDesplegable.Width==136)
            {
                pnlDesplegable.Height = 359;
                pnlDesplegable.Width = 38;
            }
            else
            {
                pnlDesplegable.Height = 359;
                pnlDesplegable.Width = 136;
            }
        }

        private void CatCollar_Load(object sender, EventArgs e)
        {
           
            pnlDesplegable.Height = 359;
            pnlDesplegable.Width = 38;
            btnAtras.Visible = false;
            btnSiguiente.Visible = false;
            cmbMostrarMateriales.Visible = false;
            panel1.Visible = false;
            lstCategoria.Visible = false;
            lstId.Visible = false;
            lstMaterial.Visible = false;
            lstNombre.Visible = false;
            lstPrecio.Visible = false;
            pctFavoritosCat.Visible = false;
            try
            {

                Con = obj.openBd();

                DataSet dt = new DataSet();
                MySqlDataAdapter db = new MySqlDataAdapter("select usuarioo from usuario ", Con);
                db.Fill(dt, "usuario");
                cmbUsuarioo.DataSource = dt.Tables[0].DefaultView;
                cmbUsuarioo.ValueMember = "usuarioo";

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

        private void btnAcero_Click(object sender, EventArgs e)
        {
            btnAtras.Visible = false;
            btnSiguiente.Visible = false;
            cmbMostrarMateriales.Visible = true;
            panel1.Visible = true;
            lstCategoria.Visible = true;
            lstId.Visible = true;
            lstMaterial.Visible = true;
            lstNombre.Visible = true;
            lstPrecio.Visible = true;

            try
            {

                Con = obj.openBd();

                DataSet ds = new DataSet();
                MySqlDataAdapter da = new MySqlDataAdapter("select nombre from producto where categoria = 'Collares y pendientes'", Con);
                da.Fill(ds, "producto");
                cmbMostrarMateriales.DataSource = ds.Tables[0].DefaultView;
                cmbMostrarMateriales.ValueMember = "nombre";

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

        private void cmbMostrarMateriales_SelectedIndexChanged(object sender, EventArgs e)
        {
            Con = obj.openBd();
            try
            {

                //nombre
                DataSet ds = new DataSet();
                MySqlDataAdapter da = new MySqlDataAdapter("select nombre from producto where nombre = '" + cmbMostrarMateriales.Text + "'", Con);
                da.Fill(ds, "producto");
                lstNombre.DataSource = ds.Tables[0].DefaultView;
                lstNombre.ValueMember = "nombre";

                //precio
                DataSet dt = new DataSet();
                MySqlDataAdapter db = new MySqlDataAdapter("select precio from producto where nombre = '" + cmbMostrarMateriales.Text + "'", Con);
                db.Fill(dt, "producto");
                lstPrecio.DataSource = dt.Tables[0].DefaultView;
                lstPrecio.ValueMember = "precio";

                //categoria
                DataSet du = new DataSet();
                MySqlDataAdapter dc = new MySqlDataAdapter("select categoria from producto where nombre = '" + cmbMostrarMateriales.Text + "'", Con);
                dc.Fill(du, "producto");
                lstCategoria.DataSource = du.Tables[0].DefaultView;
                lstCategoria.ValueMember = "categoria";

                //material
                DataSet dv = new DataSet();
                MySqlDataAdapter dd = new MySqlDataAdapter("select material from producto where nombre = '" + cmbMostrarMateriales.Text + "'", Con);
                dd.Fill(dv, "producto");
                lstMaterial.DataSource = dv.Tables[0].DefaultView;
                lstMaterial.ValueMember = "material";

                //imagen
                DataSet dw = new DataSet();
                MySqlDataAdapter de = new MySqlDataAdapter("select id from producto where nombre = '" + cmbMostrarMateriales.Text + "'", Con);
                de.Fill(dw, "producto");
                lstId.DataSource = dw.Tables[0].DefaultView;
                lstId.ValueMember = "id";

                int ale = Convert.ToInt32(lstId.Text);
                aleGlobal = ale;

                for ( i = 1; i <= ale; i++)
                {
                    if (ale == 1)
                    {
                        pctBuscarBD.Image = Properties.Resources._1_collar_enfermeria_estetoscopio;

                    }
                    if (ale == 2)
                    {
                        pctBuscarBD.Image = Properties.Resources._2_collar_enfermeria_estetoscopio;

                    }
                    if (ale == 3)
                    {
                        pctBuscarBD.Image = Properties.Resources._3_collar_infinite_love;

                    }
                    if (ale == 4)
                    {
                        pctBuscarBD.Image = Properties.Resources._4_collar_enfermeria_estetoscopio;

                    }
                    if (ale == 5)
                    {
                        pctBuscarBD.Image = Properties.Resources._5_collar_enfermeria_electrocardiograma;

                    }
                    if (ale == 6)
                    {
                        pctBuscarBD.Image = Properties.Resources._6_collar_torre;

                    }
                    if (ale == 7)
                    {
                        pctBuscarBD.Image = Properties.Resources._7_collar_corazon_locker;

                    }
                    if (ale == 8)
                    {
                        pctBuscarBD.Image = Properties.Resources._8_collar_harrypotter;

                    }
                    if (ale == 9)
                    {
                        pctBuscarBD.Image = Properties.Resources._9_collar_snitch;

                    }
                    if (ale == 10)
                    {
                        pctBuscarBD.Image = Properties.Resources._10_collar_juegosdelhambre;

                    }
                    if (ale == 11)
                    {
                        pctBuscarBD.Image = Properties.Resources._11_collar_juegosyharrypotter;

                    }
                    if (ale == 12)
                    {
                        pctBuscarBD.Image = Properties.Resources._12_collar_deathnote;

                    }
                    if (ale == 13)
                    {
                        pctBuscarBD.Image = Properties.Resources._13_collar_934;

                    }
                    if (ale == 14)
                    {
                        pctBuscarBD.Image = Properties.Resources._14_collar_harrygiroscopio;

                    }
                    if (ale == 15)
                    {
                        pctBuscarBD.Image = Properties.Resources._15_collar_dragonballZ;

                    }
                    if (ale == 16)
                    {
                        pctBuscarBD.Image = Properties.Resources._16_collar_locker;

                    }
                    if (ale == 17)
                    {
                        pctBuscarBD.Image = Properties.Resources._17_collar_fullmetal;

                    }
                    if (ale == 18)
                    {
                        pctBuscarBD.Image = Properties.Resources._18_collar_electrocardiograma;
                    }
                    if (ale == 19)
                    {
                        pctBuscarBD.Image = Properties.Resources._19_collar_pokemon;
                    }
                    if (ale == 20)
                    {
                        pctBuscarBD.Image = Properties.Resources._20_collar_enfermeriaestetoscopio;
                    }
                    if (ale == 21)
                    {
                        pctBuscarBD.Image = Properties.Resources._21_collar_estetoscopio;
                    }
                    if (ale == 22)
                    {
                        pctBuscarBD.Image = Properties.Resources._22_collar_cristalgotadeagua;
                    }
                    if (ale == 23)
                    {
                        pctBuscarBD.Image = Properties.Resources._23_collar_onepiece;
                    }
                    if (ale == 24)
                    {
                        pctBuscarBD.Image = Properties.Resources._24_collar_beisball;
                    }
                    if (ale == 25)
                    {
                        pctBuscarBD.Image = Properties.Resources._25_collar_gotadeaguaazul;
                    }
                    if (ale == 26)
                    {
                        pctBuscarBD.Image = Properties.Resources._26_collar_parejanotamusical;
                    }
                    if (ale == 27)
                    {
                        pctBuscarBD.Image = Properties.Resources._27_collar_shingekinokiojin;
                    }
                    if (ale == 28)
                    {
                        pctBuscarBD.Image = Properties.Resources._28_collar_infinitelove;
                    }
                    if (ale == 29)
                    {
                        pctBuscarBD.Image = Properties.Resources._29_collar_religioso;
                    }
                    if (ale == 30)
                    {
                        pctBuscarBD.Image = Properties.Resources._30_collar_pinguino;
                    }
                    if (ale == 31)
                    {
                        pctBuscarBD.Image = Properties.Resources._31_collar_formadelunagalaxiaazul;
                    }
                    if (ale == 32)
                    {
                        pctBuscarBD.Image = Properties.Resources._32_collar_formadelunestilo2;
                    }
                    if (ale == 33)
                    {
                        pctBuscarBD.Image = Properties.Resources._33_collar_formadelunagalaxiapurpura;
                    }
                    if (ale == 34)
                    {
                        pctBuscarBD.Image = Properties.Resources._34_collar_notamusical;
                    }
                    if (ale == 35)
                    {
                        pctBuscarBD.Image = Properties.Resources._35_collar_atrapasuenos;
                    }
                    if (ale == 36)
                    {
                        pctBuscarBD.Image = Properties.Resources._36_collar_balondefutbol;
                    }
                    if (ale == 37)
                    {
                        pctBuscarBD.Image = Properties.Resources._37_collar_ank;
                    }
                    if (ale == 38)
                    {
                        pctBuscarBD.Image = Properties.Resources._38_collar_formabuho;
                    }
                    if (ale == 78)
                    {
                        pctBuscarBD.Image = Properties.Resources._78_collar_enfermeria_electrocardiogramadorado;
                    }
                    if (ale == 79)
                    {
                        pctBuscarBD.Image = Properties.Resources._79_collar__contenedor_de_corazon;
                    }

                    //llaveros
                    if (ale == 39)
                    {
                        pctBuscarBD.Image = Properties.Resources._39_llavero_cajadevelocidadesnegro;
                    }
                    if (ale == 40)
                    {
                        pctBuscarBD.Image = Properties.Resources._40_llavero_cajadevelocidadesazul;
                    }
                    if (ale == 41)
                    {
                        pctBuscarBD.Image = Properties.Resources._41_llavero_mecanicomensajepapa;
                    }
                    if (ale == 42)
                    {
                        pctBuscarBD.Image = Properties.Resources._42_llavero_mecanicomartillo;
                    }
                    if (ale == 43)
                    {
                        pctBuscarBD.Image = Properties.Resources._43_llavero_mecanicollaveinglesa;
                    }
                    if (ale == 44)
                    {
                        pctBuscarBD.Image = Properties.Resources._44_llavero_mecanicadesarmador;
                    }
                    if (ale == 45)
                    {
                        pctBuscarBD.Image = Properties.Resources._45_llavero_strongisbeautiful;
                    }
                    if (ale == 46)
                    {
                        pctBuscarBD.Image = Properties.Resources._46_llavero_Ican;
                    }
                    if (ale == 47)
                    {
                        pctBuscarBD.Image = Properties.Resources._47_llavero_mevsme;
                    }
                    if (ale == 48)
                    {
                        pctBuscarBD.Image = Properties.Resources._48_llavero_parejanotamusical;
                    }
                    if (ale == 49)
                    {
                        pctBuscarBD.Image = Properties.Resources._49_llavero_flechaycorazon;
                    }
                    if (ale == 50)
                    {
                        pctBuscarBD.Image = Properties.Resources._50_llavero_gatoblack;
                    }
                    if (ale == 51)
                    {
                        pctBuscarBD.Image = Properties.Resources._51_llavero_blancocafe;
                    }
                    if (ale == 52)
                    {
                        pctBuscarBD.Image = Properties.Resources._52_llavero_gatoblanco;
                    }
                    if (ale == 53)
                    {
                        pctBuscarBD.Image = Properties.Resources._53_llavero_parejadoblecorazon;
                    }
                    if (ale == 54)
                    {
                        pctBuscarBD.Image = Properties.Resources._54_llavero_religiosoblack;
                    }
                    if (ale == 55)
                    {
                        pctBuscarBD.Image = Properties.Resources._55_llavero_motocicleta;
                    }
                    if (ale == 56)
                    {
                        pctBuscarBD.Image = Properties.Resources._56_llavero_parejacorazonyllave;
                    }
                    if (ale == 57)
                    {
                        pctBuscarBD.Image = Properties.Resources._57_llavero_parejamensajelove;
                    }
                    if (ale == 58)
                    {
                        pctBuscarBD.Image = Properties.Resources._58_llavero_parejaestilista;
                    }
                    if (ale == 59)
                    {
                        pctBuscarBD.Image = Properties.Resources._59_llavero_parejabalonytaco;
                    }

                    //Brazalete
                    if (ale == 60)
                    {
                        pctBuscarBD.Image = Properties.Resources._60_brazalete_enfermerianegro;
                    }
                    if (ale == 61)
                    {
                        pctBuscarBD.Image = Properties.Resources._61_brazalete_ebfermeriaceleste;
                    }
                    if (ale == 62)
                    {
                        pctBuscarBD.Image = Properties.Resources._62_brazalete_enfermeriacafe;
                    }
                    if (ale == 63)
                    {
                        pctBuscarBD.Image = Properties.Resources._63_brazalete_infinitelove;
                    }
                    if (ale == 64)
                    {
                        pctBuscarBD.Image = Properties.Resources._64_brazalete_anclaazul;
                    }
                    if (ale == 65)
                    {
                        pctBuscarBD.Image = Properties.Resources._65_brazalete_anclanegro;
                    }
                    if (ale == 66)
                    {
                        pctBuscarBD.Image = Properties.Resources._65_brazalete_anclanegro;
                    }
                    if (ale == 67)
                    {
                        pctBuscarBD.Image = Properties.Resources._67_brazalete_anclahilos;
                    }
                    if (ale == 68)
                    {
                        pctBuscarBD.Image = Properties.Resources._68_brazalete_anclareligioso;
                    }
                    if (ale == 69)
                    {
                        pctBuscarBD.Image = Properties.Resources._69_brazalete_perlasmascristal;
                    }
                    if (ale == 70)
                    {
                        pctBuscarBD.Image = Properties.Resources._70_brazalete_hilopurpura;
                    }
                    if (ale == 71)
                    {
                        pctBuscarBD.Image = Properties.Resources._71_brazalete_shingekinokiojin;
                    }
                    if (ale == 72)
                    {
                        pctBuscarBD.Image = Properties.Resources._72_brazalete_bleach;
                    }
                    if (ale == 73)
                    {
                        pctBuscarBD.Image = Properties.Resources._73_brazalete_fearytail;
                    }
                    if (ale == 74)
                    {
                        pctBuscarBD.Image = Properties.Resources._74_brazalete_notamusical;
                    }
                    if (ale == 75)
                    {
                        pctBuscarBD.Image = Properties.Resources._75_brazalete_conjuntohilos;
                    }
                    if (ale == 76)
                    {
                        pctBuscarBD.Image = Properties.Resources._76_brazalete_infinitelovehilo;
                    }
                    if (ale == 77)
                    {
                        pctBuscarBD.Image = Properties.Resources._77_brazalete_infinitelovecristal;
                    }
                }
            }
            catch (Exception ex)
            {
                // MessageBox.Show("No se puede Listar " + ex);
            }
            finally
            {
                obj.closeBd();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (aleGlobal<79)
            {
                cmbMostrarMateriales.Text = (aleGlobal + 1).ToString();

                cmbMostrarMateriales.SelectedIndex = aleGlobal;
            }
            if (aleGlobal == 79)
            {
                cmbMostrarMateriales.Text = (aleGlobal ).ToString();

                cmbMostrarMateriales.SelectedIndex = 0;
            }
          
          

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            cmbMostrarMateriales.Text = (aleGlobal + 1).ToString();
            cmbMostrarMateriales.SelectedIndex = aleGlobal-2;
        }

        private void btnPulseras_Click(object sender, EventArgs e)
        {
            btnAtras.Visible = false;
            btnSiguiente.Visible = false;
            cmbMostrarMateriales.Visible = true;
            panel1.Visible = true;
            lstCategoria.Visible = true;
            lstId.Visible = true;
            lstMaterial.Visible = true;
            lstNombre.Visible = true;
            lstPrecio.Visible = true;
            
            try
            {

                Con = obj.openBd();

                DataSet ds = new DataSet();
                MySqlDataAdapter da = new MySqlDataAdapter("select nombre from producto where categoria = 'brazalates'", Con);
                da.Fill(ds, "producto");
                cmbMostrarMateriales.DataSource = ds.Tables[0].DefaultView;
                cmbMostrarMateriales.ValueMember = "nombre";

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

        private void btnTodo_Click(object sender, EventArgs e)
        {
            btnAtras.Visible = true;
            btnSiguiente.Visible = true;
            cmbMostrarMateriales.Visible = true;
            panel1.Visible = true;
            lstCategoria.Visible = true;
            lstId.Visible = true;
            lstMaterial.Visible = true;
            lstNombre.Visible = true;
            lstPrecio.Visible = true;

            try
            {

                Con = obj.openBd();

                DataSet ds = new DataSet();
                MySqlDataAdapter da = new MySqlDataAdapter("select nombre from producto ", Con);
                da.Fill(ds, "producto");
                cmbMostrarMateriales.DataSource = ds.Tables[0].DefaultView;
                cmbMostrarMateriales.ValueMember = "nombre";

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

        private void btnBrazaletes_Click(object sender, EventArgs e)
        {
            btnAtras.Visible = false;
            btnSiguiente.Visible = false;
            cmbMostrarMateriales.Visible = true;
            panel1.Visible = true;
            lstCategoria.Visible = true;
            lstId.Visible = true;
            lstMaterial.Visible = true;
            lstNombre.Visible = true;
            lstPrecio.Visible = true;

            try
            {

                Con = obj.openBd();

                DataSet ds = new DataSet();
                MySqlDataAdapter da = new MySqlDataAdapter("select nombre from producto where categoria = 'llaveros'", Con);
                da.Fill(ds, "producto");
                cmbMostrarMateriales.DataSource = ds.Tables[0].DefaultView;
                cmbMostrarMateriales.ValueMember = "nombre";

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

        private void pctFavoritos_Click(object sender, EventArgs e)
        {
            Conexion obj = new Conexion();
          
            Con = obj.openBd();

            string sql = "select count(*) from favoritos where nombre=@nombre";
            MySqlCommand cmd = new MySqlCommand(sql, Con);
            cmd.Parameters.AddWithValue("@nombre", lstNombre.Text);
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            obj.closeBd();
            if (count == 0)
            {
                Con = obj.openBd();

                DataSet ds = new DataSet();
                MySqlDataAdapter da = new MySqlDataAdapter("select idUsuario from usuario where usuarioo = '" + cmbUsuarioo.Text + "'", Con);
                da.Fill(ds, "usuario");
                cmbUsuarioIncognito.DataSource = ds.Tables[0].DefaultView;
                cmbUsuarioIncognito.ValueMember = "idUsuario";

                objCapturar.capturarNombreUsuario = cmbUsuarioIncognito.Text;
                obj.closeBd();

                objCapturar.capturarNombreProducto = lstNombre.Text;
                objCapturar.capturarPrecioProducto = lstPrecio.Text;
                objCapturar.capturarCategoriaProducto = lstCategoria.Text;
                objCapturar.capturarMaterialProducto = lstMaterial.Text;

                objConsultas.agregarFavorito(objCapturar);
                
                MessageBox.Show("Producto agregado correctamente");
            }

            else
            {
                MessageBox.Show("Ya has agregado a favoritos este producto");

            }
            


        }

        private void btnAtrass_Click(object sender, EventArgs e)
        {
            MenuPrincipal objLlamar = new MenuPrincipal();
            objLlamar.Show();
            this.Hide();
        }

        private void cmbUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            pctFavoritosCat.Visible = false;
        }

        private void pctSalir_Click(object sender, EventArgs e)
        {
            MenuPrincipal objllamar = new MenuPrincipal();
            objllamar.Show();
            pctSalir.Visible = false;
            this.Hide();
        }

        private void cmbUsuarioIncognito_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnContrasena_Click(object sender, EventArgs e)
        {

            capturar = Interaction.InputBox("Ingrese contraseña: ", "contraseña");

            try
            {
                Con = obj.openBd();

                MySqlCommand cmd = new MySqlCommand("SELECT * FROM usuario WHERE usuarioo='" + cmbUsuarioo.Text + "'AND contraseña='" + capturar + "' ", Con); //Realizamos una selecion de la tabla usuarios.
                MySqlDataReader leer = cmd.ExecuteReader();


                if (leer.Read()) //Si el usuario es correcto nos abrira la otra ventana.
                {
                    MessageBox.Show("Sesion iniciada");
                    pctFavoritosCat.Visible = true;
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
