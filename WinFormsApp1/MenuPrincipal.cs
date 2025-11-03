using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Menu_de_Gestion;

namespace WinFormsApp1
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void BtnProductos_Click(object sender, EventArgs e)
        {

            Form1 form = new Form1();
            form.ShowDialog();
            this.Hide();
        }
        private void btnClientes_Click(object sender, EventArgs e)
        {
            FormClientes form = new FormClientes();
            form.ShowDialog();
            this.Hide();
        }

        private void btnProveedor_Click(object sender, EventArgs e)
        {
            FormProveedor form = new FormProveedor();
            form.ShowDialog();
            this.Hide();
        }
    }







}
