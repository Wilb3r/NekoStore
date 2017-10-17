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
    public partial class Favoritos : Form
    {
                MySqlConnection Con = null;
                Conexion obj = new Conexion();
        public Favoritos()
        {
            InitializeComponent();
        }

        private void Favoritos_Load(object sender, EventArgs e)
        {
   
                try
                {

                    Con = obj.openBd();

                    DataSet ds = new DataSet();
                    MySqlDataAdapter da = new MySqlDataAdapter("select distinct usuario.usuarioo from favoritos inner join usuario on usuario.idUsuario= favoritos.idUsuario", Con);
                    da.Fill(ds, "usuario");
                    cmbUsuarios.DataSource = ds.Tables[0].DefaultView;
                    cmbUsuarios.ValueMember = "usuarioo";

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
