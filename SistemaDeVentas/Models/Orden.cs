using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeVentas.Models
{
    public class Orden
    {
        [Key]
        public int OrdenId { get; set; }
        public DateTime Fecha { get; set; }
        public int IdCliente { get; set; }
        public string Estado { get; set; }


        public List<DetalleOrden> DetallesOrden { get; set; } = new();
    }

}





