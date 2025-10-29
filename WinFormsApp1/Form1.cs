using SistemaDeVentas;
using SistemaDeVentas.Models;
using SistemaDeVentas.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Windows.Forms;




namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private readonly ApplicationDbContext _context;

        public Form1()
        {
            InitializeComponent();
            _context = new ApplicationDbContext();
            CargarProductos();
        }
        private void CargarProductos()
        {
            dgvProductos.DataSource = _context.Producto
             .Select(p => new
             {
                 ProductoId = p.ProductoId, // mantener exacto
                 p.Nombre,
                 p.Categoria,
                 p.Precio,
                 p.Stock,
                 Proveedor = p.Proveedor != null ? p.Proveedor.Nombre : "Sin proveedor"
             })
             .ToList();

            // Ocultar ProductoId para que no se vea
            if (dgvProductos.Columns.Contains("ProductoId"))
                dgvProductos.Columns["ProductoId"].Visible = false;
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvProductos.CurrentRow == null)
                {
                    MessageBox.Show("Seleccioná un producto primero.");
                    return;
                }

                if (!dgvProductos.Columns.Contains("ProductoId"))
                {
                    MessageBox.Show("No se encontró la columna ProductoId en la grilla.");
                    return;
                }

                int productoId = (int)dgvProductos.CurrentRow.Cells["ProductoId"].Value;
                var producto = _context.Producto.Find(productoId);
                if (producto == null)
                {
                    MessageBox.Show("Producto no encontrado.");
                    return;
                }

                if (!decimal.TryParse(txtPrecio.Text, out decimal precio))
                {
                    MessageBox.Show("Ingresá un valor válido para el precio.");
                    return;
                }

                if (!int.TryParse(txtStock.Text, out int stock))
                {
                    MessageBox.Show("Ingresá un valor válido para el stock.");
                    return;
                }

                // Actualizar campos
                producto.Nombre = txtNombre.Text;
                producto.Categoria = txtCategoria.Text;
                producto.Precio = precio;
                producto.Stock = stock;

                _context.SaveChanges();

                CargarProductos();
                MessageBox.Show("Producto modificado correctamente.");
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar producto: " + ex.Message);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                    string.IsNullOrWhiteSpace(txtCategoria.Text) ||
                    string.IsNullOrWhiteSpace(txtPrecio.Text) ||
                    string.IsNullOrWhiteSpace(txtStock.Text))
                {
                    MessageBox.Show("Completá todos los campos antes de agregar el producto.");
                    return;
                }

                if (!decimal.TryParse(txtPrecio.Text, out decimal precio))
                {
                    MessageBox.Show("Ingresá un valor válido para el precio.");
                    return;
                }

                if (!int.TryParse(txtStock.Text, out int stock))
                {
                    MessageBox.Show("Ingresá un valor válido para el stock.");
                    return;
                }

                var producto = new Producto
                {
                    Nombre = txtNombre.Text,
                    Categoria = txtCategoria.Text,
                    Precio = precio,
                    Stock = stock
                };

                // Asignar proveedor automáticamente
                var proveedor = _context.Proveedor.FirstOrDefault();
                if (proveedor == null)
                {
                    MessageBox.Show("No hay proveedores registrados. Primero agregá uno.");
                    return;
                }
                producto.ProveedorId = proveedor.ProveedorId;

                _context.Producto.Add(producto);
                _context.SaveChanges();

                CargarProductos();
                MessageBox.Show("Producto agregado correctamente.");
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar producto: " + ex.Message);
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            try
            {
                CargarProductos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar productos: " + ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvProductos.CurrentRow == null || dgvProductos.CurrentRow.IsNewRow)
                {
                    MessageBox.Show("Seleccioná un producto válido para eliminar.");
                    return;
                }

                var producto = dgvProductos.CurrentRow.DataBoundItem as Producto;
                if (producto == null || producto.ProductoId <= 0)
                {
                    MessageBox.Show("El producto seleccionado no tiene Id válido.");
                    return;
                }

                var confirm = MessageBox.Show(
                    $"¿Estás seguro de que querés eliminar '{producto.Nombre}'?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (confirm == DialogResult.Yes)
                {
                    var prod = new Producto { ProductoId = producto.ProductoId };
                    _context.Producto.Attach(prod);
                    _context.Producto.Remove(prod);
                    _context.SaveChanges();

                    CargarProductos();
                    MessageBox.Show("Producto eliminado correctamente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar producto: " + ex.Message);
            }
        }
        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtCategoria.Clear();
            txtPrecio.Clear();
            txtStock.Clear();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProductos.CurrentRow != null)
            {
                txtNombre.Text = dgvProductos.CurrentRow.Cells["Nombre"].Value.ToString();
                txtCategoria.Text = dgvProductos.CurrentRow.Cells["Categoria"].Value.ToString();
                txtPrecio.Text = dgvProductos.CurrentRow.Cells["Precio"].Value.ToString();
                txtStock.Text = dgvProductos.CurrentRow.Cells["Stock"].Value.ToString();
            }
        }

        private void dgvProductos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvProductos.CurrentRow == null) return;

            if (!dgvProductos.Columns.Contains("ProductoId")) return;

            int productoId = (int)dgvProductos.CurrentRow.Cells["ProductoId"].Value;
            var producto = _context.Producto.Find(productoId);
            if (producto == null) return;

            txtNombre.Text = producto.Nombre;
            txtCategoria.Text = producto.Categoria;
            txtPrecio.Text = producto.Precio.ToString();
            txtStock.Text = producto.Stock.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
