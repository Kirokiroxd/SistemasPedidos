using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using Microsoft.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasPedidos
{
    public partial class ProductosForm : Form
    {
        public ProductosForm()
        {
            InitializeComponent();
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
       
            if (string.IsNullOrWhiteSpace(txtNombreProducto.Text) ||
                string.IsNullOrWhiteSpace(txtCantidad.Text) ||
                string.IsNullOrWhiteSpace(txtPrecio.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
     
                using (SqlConnection conn = BDGeneral.ObtenerConexion())
                {
                    string query = "INSERT INTO Productos (Nombre, Cantidad, Precio) VALUES (@Nombre, @Cantidad, @Precio)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
    
                        cmd.Parameters.AddWithValue("@Nombre", txtNombreProducto.Text);
                        cmd.Parameters.AddWithValue("@Cantidad", txtCantidad.Text);
                        cmd.Parameters.AddWithValue("@Precio", txtPrecio.Text);

      
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Producto agregado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

  
                string datosProducto = $"Nombre: {txtNombreProducto.Text}, Cantidad: {txtCantidad.Text}, Precio: {txtPrecio.Text}";


                listBoxProductos.Items.Add(datosProducto);

 
                txtNombreProducto.Clear();
                txtCantidad.Clear();
                txtPrecio.Clear();


                txtNombreProducto.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            if (listBoxProductos.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione un producto para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            string productoSeleccionado = listBoxProductos.SelectedItem.ToString();

           
            string nombreProducto = productoSeleccionado.Split('-')[0].Trim();

            try
            {
  
                using (SqlConnection conn = BDGeneral.ObtenerConexion())
                {
                    string query = "DELETE FROM Productos WHERE Nombre = @Nombre";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
   
                        cmd.Parameters.AddWithValue("@Nombre", nombreProducto);

    
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Producto eliminado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

 
                listBoxProductos.Items.Remove(listBoxProductos.SelectedItem);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnCerrarFormulario_Click(object sender, EventArgs e)
        {

            this.Close();
        }
    }

}
