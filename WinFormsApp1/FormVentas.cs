using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using SistemaDeVentas.Data;
using SistemaDeVentas.Models;

namespace WinFormsApp1
{
    public partial class FormVentas : Form
    {
        public FormVentas()
        {
            InitializeComponent();

        }
        private readonly ApplicationDbContext _context = new ApplicationDbContext();
        private void FormVentas_Load(object sender, EventArgs e)
        {
            cmbClientes.DataSource = _context.Cliente.ToList();
            cmbClientes.DisplayMember = "NombreCompleto";
            cmbClientes.ValueMember = "IdCliente";

            cmbProductos.DataSource = _context.Producto.ToList();
            cmbProductos.DisplayMember = "Nombre";
            cmbProductos.ValueMember = "ProductoId";

            dgvDetalles.AutoGenerateColumns = false;
            dgvDetalles.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Producto", DataPropertyName = "Nombre" });
            dgvDetalles.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Cantidad", DataPropertyName = "Cantidad" });
            dgvDetalles.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Precio", DataPropertyName = "PrecioUnitario" });
            dgvDetalles.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Subtotal", DataPropertyName = "Subtotal" });
        }

        private List<DetalleOrden> detalles = new List<DetalleOrden>();

        private void btnAgregarDetalle_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtCantidad.Text, out int cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Ingresá una cantidad válida.");
                return;
            }

            var producto = cmbProductos.SelectedItem as Producto;
            if (producto == null) return;

            detalles.Add(new DetalleOrden
            {
                ProductoId = producto.ProductoId,
                Nombre = producto.Nombre,
                Cantidad = cantidad,
                PrecioUnitario = producto.Precio
            });

            dgvDetalles.DataSource = null;
            dgvDetalles.DataSource = detalles;

            lblTotal.Text = $"Total: ${detalles.Sum(d => d.Subtotal):0.00}";


        }

        private void btnConfirmarVenta_Click(object sender, EventArgs e)
        {
            if (cmbClientes.SelectedItem == null || detalles.Count == 0)
            {
                MessageBox.Show("Seleccioná un cliente y agregá al menos un producto.");
                return;
            }

            var cliente = cmbClientes.SelectedItem as Cliente;
            if (cliente == null)
            {
                MessageBox.Show("Cliente inválido.");
                return;
            }

            foreach (var detalle in detalles)
            {
                var producto = _context.Producto.Find(detalle.ProductoId);
                if (producto == null || detalle.Cantidad > producto.Stock)
                {
                    MessageBox.Show($"Stock insuficiente para '{producto?.Nombre}'.");
                    return;
                }
            }

            var orden = new Orden
            {
                Fecha = DateTime.Now,
                IdCliente = cliente.IdCliente,
                Estado = "Pendiente",
                DetallesOrden = new List<DetalleOrden>()
            };

            foreach (var d in detalles)
            {
                orden.DetallesOrden.Add(new DetalleOrden
                {
                    ProductoId = d.ProductoId,
                    Cantidad = d.Cantidad,
                    PrecioUnitario = d.PrecioUnitario,
                    Nombre = d.Nombre
                });
            }

            foreach (var detalle in orden.DetallesOrden)
            {
                var producto = _context.Producto.Find(detalle.ProductoId);
                if (producto != null)
                {
                    producto.Stock -= detalle.Cantidad;
                }
            }

            _context.Orden.Add(orden);
            _context.SaveChanges();

            detalles.Clear();
            dgvDetalles.DataSource = null;
            lblTotal.Text = "Total: $0.00";
            MessageBox.Show("Venta registrada correctamente.");
        }
            










        private void volverAlmenu_Click(object sender, EventArgs e)
        {
            MenuPrincipal form = new MenuPrincipal();
            form.ShowDialog();
            this.Hide();
        }

        private void cmbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

