using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NekoStoreb
{
    public partial class Configuracion : Form
    {
        public Configuracion()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FormularioLimpiar ObjetoLimpiar = new FormularioLimpiar();
            ObjetoLimpiar.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FormularioBuscar ObjetoBuscar = new FormularioBuscar();
            ObjetoBuscar.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            FormularioModificar ObjetoModificar = new FormularioModificar();
            ObjetoModificar.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            FormularioAgregar ObjetoAgregar = new FormularioAgregar();
            ObjetoAgregar.Show();
        }
    }
}
