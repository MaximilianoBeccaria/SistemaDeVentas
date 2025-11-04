using SistemaDeVentas;
using SistemaDeVentas.Models;
using SistemaDeVentas.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Windows.Forms;
using Menu_de_Gestion;




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
                 p.SKU,
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

                int productoId = (int)dgvProductos.CurrentRow.Cells["ProductoId"].Value;
                var producto = _context.Producto.Find(productoId);
                if (producto == null)
                {
                    MessageBox.Show("Producto no encontrado.");
                    return;
                }

                if (!decimal.TryParse(txtPrecio.Text, out decimal precio) ||
                    !int.TryParse(txtStock.Text, out int stock))
                {
                    MessageBox.Show("Precio o stock inválido.");
                    return;
                }

                producto.Nombre = txtNombre.Text;
                producto.Categoria = txtCategoria.Text;
                producto.Precio = precio;
                producto.Stock = stock;
                producto.SKU = SKUProducto.Text;

                _context.SaveChanges();
                CargarProductos();
                LimpiarCampos();
                MessageBox.Show("Producto modificado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar producto: " + (ex.InnerException?.Message ?? ex.Message));
            }
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar campos vacíos
                if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                    string.IsNullOrWhiteSpace(txtCategoria.Text) ||
                    string.IsNullOrWhiteSpace(txtPrecio.Text) ||
                    string.IsNullOrWhiteSpace(txtStock.Text) ||
                    string.IsNullOrWhiteSpace(SKUProducto.Text))
                {
                    MessageBox.Show("Completá todos los campos, incluido el SKU.");
                    return;
                }

               
                if (txtNombre.Text.Any(char.IsDigit))  // Validar que el nombre no contenga números
                {
                    MessageBox.Show("El nombre del producto no debe contener números.");
                    return;
                }

                
                if (txtCategoria.Text.Any(char.IsDigit))// Validar que la categoría no contenga números
                {
                    MessageBox.Show("La categoría no debe contener números.");
                    return;
                }

               
                if (!decimal.TryParse(txtPrecio.Text, out decimal precio) || precio <= 0) // Validar precio decimal positivo
                {
                    MessageBox.Show("Ingresá un precio válido y mayor a cero.");
                    return;
                }

             
                if (!int.TryParse(txtStock.Text, out int stock) || stock < 0)   // Validar stock entero positivo
                {
                    MessageBox.Show("Ingresá un stock válido (número entero positivo).");
                    return;
                }

                
                if (SKUProducto.Text.Length < 4 || !SKUProducto.Text.All(char.IsLetterOrDigit)) // Validar formato de SKU 
                {
                    MessageBox.Show("El SKU debe tener al menos 4 caracteres alfanuméricos.");
                    return;
                }


                var producto = new Producto
                {
                    Nombre = txtNombre.Text.Trim(),
                    Categoria = txtCategoria.Text.Trim(),
                    Precio = precio,
                    Stock = stock,
                    SKU = SKUProducto.Text.Trim(),
                    ProveedorId = (int)cmbProveedores.SelectedValue
                };


                _context.Producto.Add(producto);
                _context.SaveChanges();

                CargarProductos();
                LimpiarCampos();
                MessageBox.Show("Producto agregado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar producto: " + (ex.InnerException?.Message ?? ex.Message));
            }
        }


        private void btnListar_Click(object sender, EventArgs e)
        {
            CargarProductos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvProductos.CurrentRow == null)
                {
                    MessageBox.Show("Seleccioná un producto válido para eliminar.");
                    return;
                }

                int productoId = (int)dgvProductos.CurrentRow.Cells["ProductoId"].Value;
                var producto = _context.Producto.Find(productoId);
                if (producto == null)
                {
                    MessageBox.Show("Producto no encontrado.");
                    return;
                }

                var confirm = MessageBox.Show($"¿Eliminar '{producto.Nombre}'?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirm == DialogResult.Yes)
                {
                    _context.Producto.Remove(producto);
                    _context.SaveChanges();
                    CargarProductos();
                    LimpiarCampos();
                    MessageBox.Show("Producto eliminado correctamente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar producto: " + (ex.InnerException?.Message ?? ex.Message));
            }
        }


        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtCategoria.Clear();
            txtPrecio.Clear();
            txtStock.Clear();
            SKUProducto.Clear();
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

                txtCategoria.Text = dgvProductos.CurrentRow.Cells["Categoria"].Value.ToString();
                txtPrecio.Text = dgvProductos.CurrentRow.Cells["Precio"].Value.ToString();
                txtStock.Text = dgvProductos.CurrentRow.Cells["Stock"].Value.ToString();
                SKUProducto.Text = dgvProductos.CurrentRow.Cells["SKU"].Value.ToString();
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


            CargarProductos();

            var proveedores = _context.Proveedor
       .Select(p => new
       {
           p.ProveedorId,
           p.Nombre
       })
       .ToList();

            cmbProveedores.DataSource = proveedores;
            cmbProveedores.DisplayMember = "Nombre";       
            cmbProveedores.ValueMember = "ProveedorId";   
        }

        


        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuPrincipal form = new MenuPrincipal();
            form.Show();
            this.Hide();
        }

        private void SKUProducto_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
