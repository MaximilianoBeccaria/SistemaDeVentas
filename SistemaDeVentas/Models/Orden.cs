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
        public decimal Total { get; set; }
        public string Estado { get; set; }

        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }

        public List<DetalleOrden> Detalles { get; set; }
    }
}