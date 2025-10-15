using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SistemaVentasDatos.Modelos
{
    public class Producto
    {
        public int IdProducto { get; set; }
        public string Nombre { get; set; }
        public string SKU { get; set; }
        public decimal Precio { get; set; }
        public decimal Costo { get; set; }
        public int Stock { get; set; }
        public string Categoria { get; set; }

        public int ProveedorId { get; set; }
        public Proveedor Proveedor { get; set; }

        public List<DetalleOrden> DetallesOrden { get; set; }
    }
}