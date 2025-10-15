using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentasDatos.Modelos
{
    public class Cliente
    {
        [Key]
        public int IdCliente { get; set; }
        public string NombreCompleto { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public List<Orden> Ordenes { get; set; }
    }
}