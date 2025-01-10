namespace SistemasPedidos
{
    using System.Configuration;
    using System.Data;
    using Microsoft.Data.SqlClient;
    public partial class ClientesForm : Form
    {
        public ClientesForm()
        {
            InitializeComponent();

        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtCorreo.Text) ||
                string.IsNullOrWhiteSpace(txtTelefono.Text) ||
                string.IsNullOrWhiteSpace(txtDireccion.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = BDGeneral.ObtenerConexion())
                {
                    string query = "INSERT INTO Clientes (Nombre, Correo, Telefono, Direccion) VALUES (@Nombre, @Correo, @Telefono, @Direccion)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {

                        cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                        cmd.Parameters.AddWithValue("@Correo", txtCorreo.Text);
                        cmd.Parameters.AddWithValue("@Telefono", txtTelefono.Text);
                        cmd.Parameters.AddWithValue("@Direccion", txtDireccion.Text);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Cliente agregado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                txtNombre.Clear();
                txtCorreo.Clear();
                txtTelefono.Clear();
                txtDireccion.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtCorreo.Text) ||
                string.IsNullOrWhiteSpace(txtTelefono.Text) ||
                string.IsNullOrWhiteSpace(txtDireccion.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
       
            string datosCliente = $"Nombre: {txtNombre.Text}, Correo: {txtCorreo.Text}, Teléfono: {txtTelefono.Text}, Dirección: {txtDireccion.Text}";

            listBoxClientes.Items.Add(datosCliente);

 
            txtNombre.Clear();
            txtCorreo.Clear();
            txtTelefono.Clear();
            txtDireccion.Clear();

            txtNombre.Focus();
        }



        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {

            if (listBoxClientes.SelectedItem != null)
            {
 
                DialogResult result = MessageBox.Show("¿Está seguro de que desea eliminar este cliente?",
                    "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {

                    listBoxClientes.Items.Remove(listBoxClientes.SelectedItem);
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un cliente para eliminar.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnCerrarFormulario_Click(object sender, EventArgs e)
        {
 
            this.Close();
        }
    }
}