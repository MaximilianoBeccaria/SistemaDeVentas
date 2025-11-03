using SistemaDeVentas.Data;
using SistemaDeVentas.Models;
using System;
using System.Linq;
using System.Windows.Forms;
using Menu_de_Gestion;



namespace WinFormsApp1
{
    public partial class FormProveedor : Form
    {
        private readonly ApplicationDbContext _context;

        public FormProveedor()
        {
            InitializeComponent();
            _context = new ApplicationDbContext();

        }


        private void FormProveedores_Load(object sender, EventArgs e)
        {
            CargarProveedores();
        }

        private void CargarProveedores()
        {
            dgvProveedores.DataSource = _context.Proveedor
                .Select(p => new
                {
                    p.ProveedorId,
                    p.Nombre,
                    p.Contacto,
                    p.Direccion

                })
                .ToList();

          
        }


        private void LimpiarCampos()
        {
            NombreProveedor.Clear();
            ContactoProveedor.Clear();
            DireccionProveedor.Clear();
        }





        private void NombreProveedor_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var menu = new MenuPrincipal();
            menu.Show();
            this.Close();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NombreProveedor.Text) ||
               string.IsNullOrWhiteSpace(ContactoProveedor.Text) ||
               string.IsNullOrWhiteSpace(DireccionProveedor.Text))
            {
                MessageBox.Show("Completá todos los campos.");
                return;

            }
            var proveedor = new Proveedor
            {
                Nombre = NombreProveedor.Text,
                Contacto = ContactoProveedor.Text,
                Direccion = DireccionProveedor.Text
            };

            _context.Proveedor.Add(proveedor);
            _context.SaveChanges();

            CargarProveedores();
            LimpiarCampos();
            MessageBox.Show("Proveedor agregado correctamente.");
        }

        private void ModificarProveedores_Click(object sender, EventArgs e)
        {
            if (dgvProveedores.CurrentRow == null)
            {
                MessageBox.Show("Seleccioná un proveedor.");
                return;
            }

            int ProveedorId = (int)dgvProveedores.CurrentRow.Cells["ProveedorId"].Value;
            var proveedor = _context.Proveedor.Find(ProveedorId);
            if (proveedor == null) return;

            proveedor.Nombre = NombreProveedor.Text;
            proveedor.Contacto = ContactoProveedor.Text;
            proveedor.Direccion = DireccionProveedor.Text;

            _context.SaveChanges();
            CargarProveedores();
            LimpiarCampos();
            MessageBox.Show("Proveedor modificado correctamente.");
        }

        private void EliminarProveedores_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvProveedores.CurrentRow == null) return;

                int proveedorId = (int)dgvProveedores.CurrentRow.Cells["ProveedorId"].Value;
                var proveedor = _context.Proveedor.Find(proveedorId);
                if (proveedor == null) return;

                _context.Proveedor.Remove(proveedor);
                _context.SaveChanges();

                CargarProveedores();
                LimpiarCampos();
                MessageBox.Show("Proveedor eliminado.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar proveedor: " + (ex.InnerException?.Message ?? ex.Message));
            }
        }


            
        


        private void dgvProveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormProveedor_Load(object sender, EventArgs e)
        {
           
        }

        private void FormProveedor_Load_1(object sender, EventArgs e)
        {
            CargarProveedores();
        }
    }
}


//SOLUCIONAR ERROR DE ELIMINAR PROVEEDOR Y DE MODIFICAR
