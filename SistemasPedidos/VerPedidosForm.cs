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
 
        public partial class VerPedidosForm : Form
        {
            private List<Pedido> pedidos; 

            public VerPedidosForm(List<Pedido> pedidos)
            {
                InitializeComponent();
                this.pedidos = pedidos;
            }

            private void VerPedidosForm_Load(object sender, EventArgs e)
            {
       
                dgvPedidos.DataSource = pedidos;
            }
        }
    
}
