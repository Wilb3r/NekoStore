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

namespace NekoStoreb
{
    public partial class FormularioAgregar : Form
    {

        Capturar objCapturar = new Capturar();
        Consultas objConsultas = new Consultas();
        public FormularioAgregar()
        {
            InitializeComponent();
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            
            Conexion obj = new Conexion();
            
            try
            {
                objCapturar.capturarNombreProducto = txtNombreAgregar.Text;
                objCapturar.capturarPrecioProducto = txtPrecioAgregar.Text;
                objCapturar.capturarCategoriaProducto = txtCategoriaAgregar.Text;
                objCapturar.capturarMaterialProducto = txtMaterialAgregar.Text;

                objConsultas.agregarProducto(objCapturar);
                MessageBox.Show("El producto se ha agregado correctamente");

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
    }
}
