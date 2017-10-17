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
   public  class Consultas: Conexion
    {
        MySqlConnection Con = null;
        MySqlCommand comand = null;
       public void agregarProducto(Capturar producto)
       {

           try
           {

               Con = openBd();
               comand = Con.CreateCommand();
               comand.CommandText = "INSERT INTO producto(id, nombre, precio, categoria, material) "
                   + "VALUES (null, @nombre, @precio, @categoria, @material)";
               comand.Prepare();
               comand.Parameters.AddWithValue("@nombre", producto.capturarNombreProducto);
               comand.Parameters.AddWithValue("@precio", producto.capturarPrecioProducto);
               comand.Parameters.AddWithValue("@categoria", producto.capturarCategoriaProducto);
               comand.Parameters.AddWithValue("@material", producto.capturarMaterialProducto);


               comand.ExecuteNonQuery();
           }
           catch (Exception ex)
           {

               MessageBox.Show("El error es " + ex);
           }
           finally
           {
               closeBd();
           }
       }

       public void agregarUsuario(Capturar usuario)
       {
           try
           {

               Con = openBd();
               comand = Con.CreateCommand();
               comand.CommandText = "INSERT INTO usuario(idUsuario, usuarioo, contraseña, direccion) "
                   + "VALUES (null, @nombre, @precio, @categoria)";
               comand.Prepare();
               comand.Parameters.AddWithValue("@nombre", usuario.capturarUsuario);
               comand.Parameters.AddWithValue("@precio", usuario.capturarContraseña);
               comand.Parameters.AddWithValue("@categoria", usuario.capturarDireccion);


               comand.ExecuteNonQuery();
           }
           catch (Exception ex)
           {

               MessageBox.Show("El error es " + ex);
           }
           finally
           {
               closeBd();
           }


       }

        public void agregarFavorito(Capturar favorito)
        {
            try
            {

                Con = openBd();
                comand = Con.CreateCommand();

                comand.CommandText = "INSERT INTO favoritos(id, nombre, precio, categoria, material, idUsuario) "
                    + "VALUES (null, @nombre, @precio, @categoria, @material, @idUsuario)";
                comand.Prepare();
                comand.Parameters.AddWithValue("@nombre", favorito.capturarNombreProducto);
                comand.Parameters.AddWithValue("@precio", favorito.capturarPrecioProducto);
                comand.Parameters.AddWithValue("@categoria", favorito.capturarCategoriaProducto);
                comand.Parameters.AddWithValue("@material", favorito.capturarMaterialProducto);
                comand.Parameters.AddWithValue("@idUsuario", favorito.capturarNombreUsuario );



                comand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                MessageBox.Show("El error es " + ex);
            }
            finally
            {
                closeBd();
            }
        }
        /*
       public bool iniciarSesion(Capturar iniciar)
       {
          bool iniciarUsu=false;
           try
           {

               Con = openBd();
               
               MySqlCommand cmd = new MySqlCommand("SELECT * FROM usuario WHERE usuarioo='" + iniciar.capturarIniciarUsuario + "'AND contraseña='" + iniciar.capturarIniciarContraseña+ "' ", Con); //Realizamos una selecion de la tabla usuarios.
               MySqlDataReader leer = cmd.ExecuteReader();

               if(leer.Read())
               {
                   iniciarUsu = true;
               }

               else
               {
                   iniciarUsu = false;

               }
           }
           catch (Exception ex)
           {
               MessageBox.Show("No se puede Listar " + ex);
           }
           finally
           {
               closeBd();
           }
           return iniciarUsu;
       }
       */


       public void Iniciar()
        {

           
        }
           
       }
    }

