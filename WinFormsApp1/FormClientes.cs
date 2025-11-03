using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using SistemaDeVentas.Data;
using SistemaDeVentas.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using WinFormsApp1;
 
namespace Menu_de_Gestion
{
    public partial class FormClientes : Form
    {
        public FormClientes()
        {

            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void GuardarCliente_Click(object sender, EventArgs e)
        {



            bool datosVacio = false;
            while (datosVacio == false)
            {
                string nombreCliente = NombreCliente.Text;
                if (string.IsNullOrEmpty(nombreCliente))
                {
                    MessageBox.Show("Algunos de los campos estan vacios.");
                    datosVacio = true;
                }


                int dniParse;
                string dniCliente = DniCliente.Text;
                if (string.IsNullOrEmpty(dniCliente))
                {
                    MessageBox.Show("Algunos de los campos estan vacios.");
                    datosVacio = true;
                }
                else
                {
                    if (!int.TryParse(dniCliente, out dniParse))
                    {
                        MessageBox.Show("El DNI debe ser un número válido.");
                        break;
                    }
                    else
                    {
                        if (dniParse <= 0)
                        {
                            MessageBox.Show("El DNI debe ser un número positivo.");
                            break;
                        }
                        else
                        {
                            if (dniCliente.Length != 8)
                            {
                                MessageBox.Show("El DNI debe tener 8 dígitos.");
                                break;
                            }
                            else
                            {
                                dniCliente = dniParse.ToString();
                            }
                        }
                    }



                    // Crear instancia del cliente
                    var cliente = new Cliente
                    {
                        NombreCompleto = NombreCliente.Text,
                        Dni = DniCliente.Text,
                        Email = DireccionCliente.Text,
                        Telefono = TelefonoCliente.Text
                    };

                    // Guardar en la base de datos

                    using var db = new ApplicationDbContext();
                    db.Clientes.Add(cliente);
                    db.SaveChanges();

                    // Actualizar el DataGridView
                    dgvClientes.DataSource = db.Clientes.ToList();

                    // Limpiar campos
                    NombreCliente.Clear();
                    DniCliente.Clear();
                    DireccionCliente.Clear();
                    TelefonoCliente.Clear();

                    MessageBox.Show("Cliente guardado correctamente.");
                }



            }



        }




//ACTUALIZAR LISTA AL CARGAR EL FORM
        private void CargarClientes()
        {
            using var db = new ApplicationDbContext();
            dgvClientes.DataSource = db.Clientes.ToList();
            
        }
        private void FormClientes_Load(object sender, EventArgs e)
        {

          

        }


        private void Modificar_Cliente_Click(object sender, EventArgs e)
        {
            if (dgvClientes.CurrentRow?.DataBoundItem is Cliente clienteSeleccionado)
            {
                using var db = new ApplicationDbContext();
                var clienteDb = db.Clientes.Find(clienteSeleccionado.IdCliente);

                if (clienteDb != null)
                {
                    // Actualizar los datos con lo que está en los TextBox
                    clienteDb.NombreCompleto = NombreCliente.Text;
                    clienteDb.Dni = DniCliente.Text;
                    clienteDb.Email = DireccionCliente.Text;
                    clienteDb.Telefono = TelefonoCliente.Text;

                    db.SaveChanges();

                    // Refrescar el DataGridView
                    dgvClientes.DataSource = db.Clientes.ToList();

                    MessageBox.Show("Cliente modificado correctamente.");
                }
            }
            else
            {
                MessageBox.Show("Seleccioná un cliente para modificar.");
            }
        } 


        
        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvClientes.CurrentRow?.DataBoundItem is Cliente cliente)
            {
                NombreCliente.Text = cliente.NombreCompleto;
                DniCliente.Text = cliente.Dni;
                DireccionCliente.Text = cliente.Email;
                TelefonoCliente.Text = cliente.Telefono;
            }
        }


        private void Eliminar_Cliente_Click(object sender, EventArgs e)
        {
            if (dgvClientes.CurrentRow?.DataBoundItem is Cliente cliente)
            {
                var confirm = MessageBox.Show($"¿Eliminar este cliente?",
                                              "Confirmar eliminación",
                                              MessageBoxButtons.YesNo,
                                              MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    using var db = new ApplicationDbContext();
                    var clienteDb = db.Clientes.Find(cliente.IdCliente);
                    if (clienteDb != null)
                    {
                        db.Clientes.Remove(clienteDb);
                        db.SaveChanges();
                        dgvClientes.DataSource = db.Clientes.ToList();
                        MessageBox.Show("Cliente eliminado correctamente.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccioná un cliente para eliminar.");
            }
        }



        private void DniCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal(); // Crear instancia del formulario principal
            menu.Show();                              // Mostrar el menú
            this.Close();



        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }


        private void FormClientes_Load_1(object sender, EventArgs e)
        {
            CargarClientes();
            Modificar_Cliente.Enabled = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    
            
        
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
        }


        private void LimpiarFormulario()
        {
            NombreCliente.Clear();
            DniCliente.Clear();
            DireccionCliente.Clear();
            TelefonoCliente.Clear();
            Eliminar_Cliente.Enabled = false;
        }

        private void NombreCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void Actualizarbtn_Click(object sender, EventArgs e)
        {


        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

        }
    }
}
