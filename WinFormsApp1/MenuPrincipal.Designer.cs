namespace WinFormsApp1
{
    partial class MenuPrincipal : Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BtnProductos = new Button();
            label1 = new Label();
            btnClientes = new Button();
            btnProveedor = new Button();
            btnDetalleOrden = new Button();
            SuspendLayout();
            // 
            // BtnProductos
            // 
            BtnProductos.Location = new Point(188, 105);
            BtnProductos.Name = "BtnProductos";
            BtnProductos.Size = new Size(412, 50);
            BtnProductos.TabIndex = 0;
            BtnProductos.Text = "Productos";
            BtnProductos.UseVisualStyleBackColor = true;
            BtnProductos.Click += BtnProductos_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(47, 30);
            label1.Name = "label1";
            label1.Size = new Size(696, 46);
            label1.TabIndex = 1;
            label1.Text = "Sistema de Venta de Productos Tecnologicois";
            // 
            // btnClientes
            // 
            btnClientes.Location = new Point(188, 179);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(412, 50);
            btnClientes.TabIndex = 2;
            btnClientes.Text = "Clientes";
            btnClientes.UseVisualStyleBackColor = true;
            btnClientes.Click += btnClientes_Click;
            // 
            // btnProveedor
            // 
            btnProveedor.Location = new Point(188, 245);
            btnProveedor.Name = "btnProveedor";
            btnProveedor.Size = new Size(413, 50);
            btnProveedor.TabIndex = 3;
            btnProveedor.Text = "Proveedores";
            btnProveedor.UseVisualStyleBackColor = true;
            btnProveedor.Click += btnProveedor_Click;
            // 
            // btnDetalleOrden
            // 
            btnDetalleOrden.Location = new Point(187, 315);
            btnDetalleOrden.Name = "btnDetalleOrden";
            btnDetalleOrden.Size = new Size(413, 50);
            btnDetalleOrden.TabIndex = 4;
            btnDetalleOrden.Text = "Detalle de orden";
            btnDetalleOrden.UseVisualStyleBackColor = true;
            btnDetalleOrden.Click += btnDetalleOrden_Click;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDetalleOrden);
            Controls.Add(btnProveedor);
            Controls.Add(btnClientes);
            Controls.Add(label1);
            Controls.Add(BtnProductos);
            Name = "MenuPrincipal";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnProductos;
        private Label label1;
        private Button btnClientes;
        private Button btnProveedor;
        private Button btnDetalleOrden;
    }
}