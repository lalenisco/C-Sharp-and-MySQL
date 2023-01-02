using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crud_Tienda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                String codigo = txt_Codigo.Text;
                String nombre = txt_Nombre.Text;
                String descripcion = txt_Descripcion.Text;
                double precio_publico = double.Parse(txt_Precio.Text);
                int existencias = int.Parse(txt_Existencias.Text);

                if (codigo != "" && nombre != "" && descripcion != "" && precio_publico > 0 && existencias > 0)
                {
                             

                string sql = "INSERT INTO productos (codigo, nombre, descripcion, precio_publico," +
                    "existencias) VALUES ('" + codigo + "', '" + nombre + "', " +
                    "'" + descripcion + "', '" + precio_publico + "' , '" + existencias + "')";

                MySqlConnection conexionBD = Conexion.conexion();
                conexionBD.Open();

                try
                {
                    MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Registro Guardado");
                    limpiar();
                }
                catch (MySqlException ex)
                {

                    MessageBox.Show("Error al guardar:" + ex.Message);
                }
                finally
                { conexionBD.Close(); }
                }
                else
                {
                    MessageBox.Show("Debe completar todos los campos");
                }
            } catch (FormatException fex) {
                MessageBox.Show("Datos incorrectos:" + fex.Message);
            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            String codigo = txt_Codigo.Text;
            MySqlDataReader reader = null;

            string sql = " SELECT id, codigo, nombre, descripcion, precio_publico, existencias FROM productos WHERE codigo LIKE '"+ codigo+"' LIMIT 1 ";
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                reader = comando.ExecuteReader();
                if(reader.HasRows)
                {
                    while (reader.Read())
                    {
                        txtId.Text = reader.GetString(0);
                        txt_Codigo.Text = reader.GetString(1);
                        txt_Nombre.Text = reader.GetString(2);
                        txt_Descripcion.Text = reader.GetString(3);
                        txt_Precio.Text = reader.GetString(4);
                        txt_Existencias.Text = reader.GetString(5);
                    }
                }else
                {
                    MessageBox.Show("No se encontraron registros");
                }
            }
            catch (MySqlException ex)
            {

                MessageBox.Show("Error al buscar" + ex.Message);
            }
            finally { conexionBD.Close(); }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            String id = txtId.Text;
            String codigo = txt_Codigo.Text;
            String nombre = txt_Nombre.Text;
            String descripcion = txt_Descripcion.Text;
            double precio_publico = double.Parse(txt_Precio.Text);
            int existencias = int.Parse(txt_Existencias.Text);


            string sql = "UPDATE productos SET codigo = '"+codigo+"', nombre = '"+ nombre +"', descripcion = '"+ descripcion + "', precio_publico= '"+ precio_publico +"', existencias = '" + existencias + "' WHERE id = '"+id+"'"; 
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                comando.ExecuteNonQuery();
                MessageBox.Show("Registro Actualizado");
                limpiar();
            }
            catch (MySqlException ex)
            {

                MessageBox.Show("Error al modificar:" + ex.Message);
            }
            finally
            { conexionBD.Close(); }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            String id = txtId.Text;
            
            string sql = "DELETE FROM productos WHERE id = '" + id + "'";
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                comando.ExecuteNonQuery();
                MessageBox.Show("Registro Eliminado");
                limpiar();
            }
            catch (MySqlException ex)
            {

                MessageBox.Show("Error al Eliminar:" + ex.Message);
            }
            finally
            { conexionBD.Close(); }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void limpiar()
        {
            txtId.Text = "";
            txt_Codigo.Text = "";
            txt_Nombre.Text = "";
            txt_Descripcion.Text = "";
            txt_Precio.Text = "";
            txt_Existencias.Text = "";

        }
    }
}
