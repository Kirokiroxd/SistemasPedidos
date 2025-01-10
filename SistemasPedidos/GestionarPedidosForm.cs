using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasPedidos
{
    public partial class GestionarPedidosForm : Form
    {
        private List<Pedido> pedidos = new List<Pedido>(); 

        public GestionarPedidosForm()
        {
            InitializeComponent();
        }
        private void CargarPedidos()
        {
            dgvPedidos.DataSource = null;
            dgvPedidos.DataSource = pedidos;
        }
        private void btnAgregarPedido_Click(object sender, EventArgs e)
        {
           
            Pedido nuevoPedido = new Pedido(
                pedidos.Count + 1, 
                txtCliente.Text,    
                txtProducto.Text,   
                DateTime.Now,       
                "Pendiente"         
            );

            pedidos.Add(nuevoPedido);  
            CargarPedidos();          
        }
        private void btnModificarPedido_Click(object sender, EventArgs e)
        {
            if (dgvPedidos.SelectedRows.Count > 0)
            {
               
                var pedidoSeleccionado = (Pedido)dgvPedidos.SelectedRows[0].DataBoundItem;

                
                pedidoSeleccionado.Cliente = txtCliente.Text;
                pedidoSeleccionado.Producto = txtProducto.Text;
    

                CargarPedidos();  
            }
        }
        private void btnEliminarPedido_Click(object sender, EventArgs e)
        {
            if (dgvPedidos.SelectedRows.Count > 0)
            {
                
                var pedidoSeleccionado = (Pedido)dgvPedidos.SelectedRows[0].DataBoundItem;

                
                pedidos.Remove(pedidoSeleccionado);

                CargarPedidos();  
            }
        }

    }
}