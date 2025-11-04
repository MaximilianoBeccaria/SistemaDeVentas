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
        }

        private void CargarProveedores()
        {
            dgvProveedores.DataSource = _context.Proveedor.ToList();
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
        }  //Ir al Menu


        private void btnAgregar_Click(object sender, EventArgs e)
        {
           
            if (string.IsNullOrWhiteSpace(NombreProveedor.Text) ||
                string.IsNullOrWhiteSpace(ContactoProveedor.Text) ||
                string.IsNullOrWhiteSpace(DireccionProveedor.Text))
            {
                MessageBox.Show("Completá todos los campos.");
                return;
            }

            
            if (NombreProveedor.Text.Any(char.IsDigit))
            {
                MessageBox.Show("El nombre del proveedor no debe contener números.");
                return;
            }

            
            if (!ContactoProveedor.Text.All(char.IsDigit))
            {
                MessageBox.Show("El contacto debe contener solo números.");
                return;
            }

            
            if (DireccionProveedor.Text.Length < 5)
            {
                MessageBox.Show("La dirección debe tener al menos 5 caracteres.");
                return;
            }

           
            var proveedor = new Proveedor
            {
                Nombre = NombreProveedor.Text.Trim(),
                Contacto = ContactoProveedor.Text.Trim(),
                Direccion = DireccionProveedor.Text.Trim()
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

            var proveedor = dgvProveedores.CurrentRow.DataBoundItem as Proveedor;
            if (proveedor == null)
            {
                MessageBox.Show("No se pudo obtener el proveedor.");
                return;
            }

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
                if (dgvProveedores.CurrentRow == null)
                {
                    MessageBox.Show("Seleccioná un proveedor.");
                    return;
                }

                var proveedor = dgvProveedores.CurrentRow.DataBoundItem as Proveedor;
                if (proveedor == null)
                {
                    MessageBox.Show("No se pudo obtener el proveedor seleccionado.");
                    return;
                }

                _context.Proveedor.Remove(proveedor);
                _context.SaveChanges();

                CargarProveedores();
                LimpiarCampos();
                MessageBox.Show("Proveedor eliminado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar proveedor: " + (ex.InnerException?.Message ?? ex.Message));
            }
        }







        private void dgvProveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProveedores.CurrentRow != null)
            {
                NombreProveedor.Text = dgvProveedores.CurrentRow.Cells["Nombre"].Value.ToString();
                ContactoProveedor.Text = dgvProveedores.CurrentRow.Cells["Contacto"].Value.ToString();
                DireccionProveedor.Text = dgvProveedores.CurrentRow.Cells["Direccion"].Value.ToString();
            }
        }

        private void FormProveedor_Load(object sender, EventArgs e)
        {

        }

        private void FormProveedor_Load_1(object sender, EventArgs e)
        {
            CargarProveedores();
        }

        private void dgvProveedores_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
          
            }
        }

    }




//SOLUCIONAR ERROR DE ELIMINAR PROVEEDOR Y DE MODIFICAR
