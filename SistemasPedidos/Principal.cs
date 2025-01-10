namespace SistemasPedidos
{
    public partial class Principal : Form
    {
        public Principal()
        {

            
            InitializeComponent();
         }

        
        private void btnGestionarClientes_Click(object sender, EventArgs e)
        {
           
            ClientesForm clientesForm = new ClientesForm();

           
            clientesForm.Show();
        }
       
        private void btnGestionarProductos_Click(object sender, EventArgs e)
        {
            
            ProductosForm productosForm = new ProductosForm();

           
            productosForm.Show();
        }
        private void btnGestionarPedidos_Click(object sender, EventArgs e)
        {
            
            GestionarPedidosForm gestionarPedidos = new GestionarPedidosForm();

           
            gestionarPedidos.Show();
        }
        private List<Pedido> pedidos = new List<Pedido>();


        private void btnVerPedidos_Click(object sender, EventArgs e)
        {
            // Asegúrate de que 'pedidos' está disponible en este contexto
            VerPedidosForm verPedidosForm = new VerPedidosForm(pedidos);
            verPedidosForm.Show();
        }


    }
}

