using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentasDatos.Modelos
{
    public class DetalleOrden
    {
        public int IdDetalleOrden { get; set; }
        public int OrdenId { get; set; }
        public int ProductoId { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal Subtotal { get; set; }

        public Orden Orden { get; set; }
        public Producto Producto { get; set; }
    }
}
