using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeVentas.Models
{
    public class DetalleOrden
    {
        [Key]
        public int DetalleOrdenId { get; set; }
        public int OrdenId { get; set; }
        public int ProductoId { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public string Nombre { get; set; }

        

        [NotMapped]
        public decimal Subtotal => Cantidad * PrecioUnitario;
    }


}

