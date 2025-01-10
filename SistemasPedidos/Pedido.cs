using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasPedidos
{
    public class Pedido
    {
        public int Id { get; set; }
        public string Cliente { get; set; }
        public string Producto { get; set; }
        public DateTime Fecha { get; set; }
        public string Estado { get; set; }

        public Pedido(int id, string cliente, string producto, DateTime fecha, string estado)
        {
            Id = id;
            Cliente = cliente;
            Producto = producto;
            Fecha = fecha;
            Estado = estado;
        }
    }

}
