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
using NekoStoreb.Forms;
using Microsoft.VisualBasic;

namespace NekoStoreb
{
    public partial class MenuPrincipal : Form
    {
        MySqlConnection Con = new MySqlConnection();
        MySqlCommand comand = new MySqlCommand();
        public Conexion obj = new Conexion();
        CatCollar objCatCollar = new CatCollar();
        Capturar objCapturar = new Capturar();
        Consultas objConsultas = new Consultas();

        public MenuPrincipal()
        {
            InitializeComponent();
        }
        
        private void tmrMenuPrincipal_Tick(object sender, EventArgs e)
        {
            Random objAlea = new Random();
            int ale = objAlea.Next(0, 37);

            for (int i = 0; i <= ale; i++)
            {
                if (ale == 0)
                {
                    pctInicio1.Image = Properties.Resources._1_collar_enfermeria_estetoscopio;

                }
                if (ale == 1)
                {
                    pctInicio1.Image = Properties.Resources._2_collar_enfermeria_estetoscopio;

                }
                if (ale == 2)
                {
                    pctInicio1.Image = Properties.Resources._3_collar_infinite_love;

                }
                if (ale == 3)
                {
                    pctInicio1.Image = Properties.Resources._4_collar_enfermeria_estetoscopio;

                }
                if (ale == 4)
                {
                    pctInicio1.Image = Properties.Resources._5_collar_enfermeria_electrocardiograma;

                }
                if (ale == 5)
                {
                    pctInicio1.Image = Properties.Resources._6_collar_torre;

                }
                if (ale == 6)
                {
                    pctInicio1.Image = Properties.Resources._7_collar_corazon_locker;

                }
                if (ale == 7)
                {
                    pctInicio1.Image = Properties.Resources._8_collar_harrypotter;

                }
                if (ale == 8)
                {
                    pctInicio1.Image = Properties.Resources._9_collar_snitch;

                }
                if (ale == 9)
                {
                    pctInicio1.Image = Properties.Resources._10_collar_juegosdelhambre;

                }
                if (ale == 10)
                {
                    pctInicio1.Image = Properties.Resources._11_collar_juegosyharrypotter;

                }
                if (ale == 11)
                {
                    pctInicio1.Image = Properties.Resources._12_collar_deathnote;

                }
                if (ale == 12)
                {
                    pctInicio1.Image = Properties.Resources._13_collar_934;

                }
                if (ale == 13)
                {
                    pctInicio1.Image = Properties.Resources._14_collar_harrygiroscopio;

                }
                if (ale == 14)
                {
                    pctInicio1.Image = Properties.Resources._15_collar_dragonballZ;

                }
                if (ale == 15)
                {
                    pctInicio1.Image = Properties.Resources._16_collar_locker;

                }
                if (ale == 16)
                {
                    pctInicio1.Image = Properties.Resources._17_collar_fullmetal;

                }
                if (ale == 17)
                {
                    pctInicio1.Image = Properties.Resources._18_collar_electrocardiograma;
                }
                if (ale == 18)
                {
                    pctInicio1.Image = Properties.Resources._19_collar_pokemon;
                }
                if (ale == 19)
                {
                    pctInicio1.Image = Properties.Resources._20_collar_enfermeriaestetoscopio;
                }
                if (ale == 20)
                {
                    pctInicio1.Image = Properties.Resources._21_collar_estetoscopio;
                }
                if (ale == 21)
                {
                    pctInicio1.Image = Properties.Resources._22_collar_cristalgotadeagua;
                }
                if (ale == 22)
                {
                    pctInicio1.Image = Properties.Resources._23_collar_onepiece;
                }
                if (ale == 23)
                {
                    pctInicio1.Image = Properties.Resources._24_collar_beisball;
                }
                if (ale == 24)
                {
                    pctInicio1.Image = Properties.Resources._25_collar_gotadeaguaazul;
                }
                if (ale == 25)
                {
                    pctInicio1.Image = Properties.Resources._26_collar_parejanotamusical;
                }
                if (ale == 26)
                {
                    pctInicio1.Image = Properties.Resources._27_collar_shingekinokiojin;
                }
                if (ale == 27)
                {
                    pctInicio1.Image = Properties.Resources._28_collar_infinitelove;
                }
                if (ale == 28)
                {
                    pctInicio1.Image = Properties.Resources._29_collar_religioso;
                }
                if (ale == 29)
                {
                    pctInicio1.Image = Properties.Resources._30_collar_pinguino;
                }
                if (ale == 30)
                {
                    pctInicio1.Image = Properties.Resources._31_collar_formadelunagalaxiaazul;
                }
                if (ale == 31)
                {
                    pctInicio1.Image = Properties.Resources._32_collar_formadelunestilo2;
                }
                if (ale == 32)
                {
                    pctInicio1.Image = Properties.Resources._33_collar_formadelunagalaxiapurpura;
                }
                if (ale == 33)
                {
                    pctInicio1.Image = Properties.Resources._34_collar_notamusical;
                }
                if (ale == 34)
                {
                    pctInicio1.Image = Properties.Resources._35_collar_atrapasuenos;
                }
                if (ale == 35)
                {
                    pctInicio1.Image = Properties.Resources._36_collar_balondefutbol;
                }
                if (ale == 36)
                {
                    pctInicio1.Image = Properties.Resources._37_collar_ank;
                }
                if (ale == 37)
                {
                    pctInicio1.Image = Properties.Resources._38_collar_formabuho;
                }


            }
        }

        private void tmrMenuPrincipalPulseras_Tick(object sender, EventArgs e)
        {

            Random objAlea = new Random();
            int ale = objAlea.Next(0, 16);

            for (int i = 0; i <= ale; i++)
            {
                if (ale == 0)
                {
                    pctInicio2.Image = Properties.Resources._60_brazalete_enfermerianegro;

                }
                if (ale == 1)
                {
                    pctInicio2.Image = Properties.Resources._61_brazalete_ebfermeriaceleste;

                }
                if (ale == 2)
                {
                    pctInicio2.Image = Properties.Resources._62_brazalete_enfermeriacafe;

                }
                if (ale == 3)
                {
                    pctInicio2.Image = Properties.Resources._63_brazalete_infinitelove;

                }
                if (ale == 4)
                {
                    pctInicio2.Image = Properties.Resources._64_brazalete_anclaazul;

                }
                if (ale == 5)
                {
                    pctInicio2.Image = Properties.Resources._65_brazalete_anclanegro;

                }
                if (ale == 6)
                {
                    pctInicio2.Image = Properties.Resources._67_brazalete_anclahilos;

                }
                if (ale == 7)
                {
                    pctInicio2.Image = Properties.Resources._68_brazalete_anclareligioso;

                }
                if (ale == 8)
                {
                    pctInicio2.Image = Properties.Resources._69_brazalete_perlasmascristal;

                }
                if (ale == 9)
                {
                    pctInicio2.Image = Properties.Resources._70_brazalete_hilopurpura;

                }
                if (ale == 10)
                {
                    pctInicio2.Image = Properties.Resources._71_brazalete_shingekinokiojin;

                }
                if (ale == 11)
                {
                    pctInicio2.Image = Properties.Resources._72_brazalete_bleach;

                }
                if (ale == 12)
                {
                    pctInicio2.Image = Properties.Resources._73_brazalete_fearytail;

                }
                if (ale == 13)
                {
                    pctInicio2.Image = Properties.Resources._74_brazalete_notamusical;

                }
                if (ale == 14)
                {
                    pctInicio2.Image = Properties.Resources._75_brazalete_conjuntohilos;

                }
                if (ale == 15)
                {
                    pctInicio2.Image = Properties.Resources._76_brazalete_infinitelovehilo;

                }
                if (ale == 16)
                {
                    pctInicio2.Image = Properties.Resources._77_brazalete_infinitelovecristal;

                }


            }
        }

        private void tmrMenuprincipalLlavero_Tick(object sender, EventArgs e)
        {
            Random objAlea = new Random();
            int ale = objAlea.Next(0, 21);

            for (int i = 0; i <= ale; i++)
            {
                if (ale == 0)
                {
                    pctInicio3.Image = Properties.Resources._39_llavero_cajadevelocidadesnegro;

                }
                if (ale == 1)
                {
                    pctInicio3.Image = Properties.Resources._39_llavero_cajadevelocidadesnegro;

                }
                if (ale == 2)
                {
                    pctInicio3.Image = Properties.Resources._40_llavero_cajadevelocidadesazul;

                }
                if (ale == 3)
                {
                    pctInicio3.Image = Properties.Resources._41_llavero_mecanicomensajepapa;

                }
                if (ale == 4)
                {
                    pctInicio3.Image = Properties.Resources._42_llavero_mecanicomartillo;

                }
                if (ale == 5)
                {
                    pctInicio3.Image = Properties.Resources._43_llavero_mecanicollaveinglesa;

                }
                if (ale == 6)
                {
                    pctInicio3.Image = Properties.Resources._44_llavero_mecanicadesarmador;

                }
                if (ale == 7)
                {
                    pctInicio3.Image = Properties.Resources._45_llavero_strongisbeautiful;

                }
                if (ale == 8)
                {
                    pctInicio3.Image = Properties.Resources._46_llavero_Ican;

                }
                if (ale == 9)
                {
                    pctInicio3.Image = Properties.Resources._47_llavero_mevsme;

                }
                if (ale == 10)
                {
                    pctInicio3.Image = Properties.Resources._48_llavero_parejanotamusical;

                }
                if (ale == 11)
                {
                    pctInicio3.Image = Properties.Resources._49_llavero_flechaycorazon;

                }
                if (ale == 12)
                {
                    pctInicio3.Image = Properties.Resources._50_llavero_gatoblack;

                }
                if (ale == 13)
                {
                    pctInicio3.Image = Properties.Resources._51_llavero_blancocafe;

                }
                if (ale == 14)
                {
                    pctInicio3.Image = Properties.Resources._52_llavero_gatoblanco;

                }
                if (ale == 15)
                {
                    pctInicio3.Image = Properties.Resources._53_llavero_parejadoblecorazon;

                }
                if (ale == 16)
                {
                    pctInicio3.Image = Properties.Resources._54_llavero_religiosoblack;

                }
                if (ale == 17)
                {
                    pctInicio3.Image = Properties.Resources._55_llavero_motocicleta;

                }
                if (ale == 18)
                {
                    pctInicio3.Image = Properties.Resources._56_llavero_parejacorazonyllave;

                }
                if (ale == 19)
                {
                    pctInicio3.Image = Properties.Resources._57_llavero_parejamensajelove;

                }
                if (ale == 20)
                {
                    pctInicio3.Image = Properties.Resources._58_llavero_parejaestilista;

                }
                if (ale == 21)
                {
                    pctInicio3.Image = Properties.Resources._59_llavero_parejabalonytaco;

                }

            }
        }

        private void pctConfrguracion_Click(object sender, EventArgs e)
        {
            Configuracion ObjetoConfiguracion = new Configuracion();
            ObjetoConfiguracion.Show();
            
        }

        private void pctConfrguracion_Click_1(object sender, EventArgs e)
        {
            Configuracion objllamar = new Configuracion();
            objllamar.Show();
            this.Hide();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
 
            pnlDesplegable.Height = 555;
            pnlDesplegable.Width = 40;

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void btnMenuDesplegable_Click(object sender, EventArgs e)
        {
            
            if (pnlDesplegable.Height== 555 && pnlDesplegable.Width== 144)
            {
                pnlDesplegable.Height = 555;
                pnlDesplegable.Width = 40;
            }
            else
            {
                pnlDesplegable.Height = 555;
                pnlDesplegable.Width = 144;
            }


        }

        private void pnlDesplegable_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pctFavoritos_Click(object sender, EventArgs e)
        {
            Favoritos objLlamar = new Favoritos();
            objLlamar.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pctCategoria_Click(object sender, EventArgs e)
        {
            CatCollar ObjetoCategoria = new CatCollar();
            ObjetoCategoria.Show();
            this.Hide();

        }

        private void pctCuenta_Click(object sender, EventArgs e)
        {
            Sign_up objLlamarRegistrarse = new Sign_up();
            objLlamarRegistrarse.Show();
            this.Hide();
        }

        private void lblCuentaIniciada_Click(object sender, EventArgs e)
        {

        }

        private void cmbUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btnContrasena_Click(object sender, EventArgs e)
        {
            
        }

        private void pctSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void Pctinicio_Click(object sender, EventArgs e)
        {
            tbControlMenu.SelectedIndex = 0;
        }
    }
    }
    


