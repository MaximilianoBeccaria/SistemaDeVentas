namespace WinFormsApp1
{
    partial class FormVentas
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
            cmbClientes = new ComboBox();
            cmbProductos = new ComboBox();
            btnAgregarDetalle = new Button();
            dgvDetalles = new DataGridView();
            txtCantidad = new TextBox();
            lblTotal = new Label();
            btnConfirmarVenta = new Button();
            volverAlmenu = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDetalles).BeginInit();
            SuspendLayout();
            // 
            // cmbClientes
            // 
            cmbClientes.FormattingEnabled = true;
            cmbClientes.Location = new Point(128, 95);
            cmbClientes.Name = "cmbClientes";
            cmbClientes.Size = new Size(209, 28);
            cmbClientes.TabIndex = 0;
            cmbClientes.SelectedIndexChanged += cmbClientes_SelectedIndexChanged;
            // 
            // cmbProductos
            // 
            cmbProductos.FormattingEnabled = true;
            cmbProductos.Location = new Point(128, 143);
            cmbProductos.Name = "cmbProductos";
            cmbProductos.Size = new Size(209, 28);
            cmbProductos.TabIndex = 1;
            // 
            // btnAgregarDetalle
            // 
            btnAgregarDetalle.Location = new Point(128, 190);
            btnAgregarDetalle.Name = "btnAgregarDetalle";
            btnAgregarDetalle.Size = new Size(209, 33);
            btnAgregarDetalle.TabIndex = 3;
            btnAgregarDetalle.Text = "Agregar";
            btnAgregarDetalle.UseVisualStyleBackColor = true;
            btnAgregarDetalle.Click += btnAgregarDetalle_Click;
            // 
            // dgvDetalles
            // 
            dgvDetalles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalles.Location = new Point(128, 247);
            dgvDetalles.Name = "dgvDetalles";
            dgvDetalles.RowHeadersWidth = 51;
            dgvDetalles.Size = new Size(507, 178);
            dgvDetalles.TabIndex = 4;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(439, 96);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(106, 27);
            txtCantidad.TabIndex = 5;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(439, 167);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(42, 20);
            lblTotal.TabIndex = 6;
            lblTotal.Text = "Total";
            // 
            // btnConfirmarVenta
            // 
            btnConfirmarVenta.Location = new Point(439, 190);
            btnConfirmarVenta.Name = "btnConfirmarVenta";
            btnConfirmarVenta.Size = new Size(179, 33);
            btnConfirmarVenta.TabIndex = 7;
            btnConfirmarVenta.Text = "Confirmar Venta";
            btnConfirmarVenta.UseVisualStyleBackColor = true;
            btnConfirmarVenta.Click += btnConfirmarVenta_Click;
            // 
            // volverAlmenu
            // 
            volverAlmenu.Location = new Point(12, 454);
            volverAlmenu.Name = "volverAlmenu";
            volverAlmenu.Size = new Size(142, 29);
            volverAlmenu.TabIndex = 8;
            volverAlmenu.Text = "Volver al menu";
            volverAlmenu.UseVisualStyleBackColor = true;
            volverAlmenu.Click += volverAlmenu_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 25F);
            label1.Location = new Point(175, 9);
            label1.Name = "label1";
            label1.Size = new Size(370, 57);
            label1.TabIndex = 9;
            label1.Text = "DETALLE ORDEN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 103);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 10;
            label2.Text = "Cliente";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 146);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 11;
            label3.Text = "Producto";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(364, 100);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 12;
            label4.Text = "Cantidad";
            // 
            // FormVentas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 490);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(volverAlmenu);
            Controls.Add(btnConfirmarVenta);
            Controls.Add(lblTotal);
            Controls.Add(txtCantidad);
            Controls.Add(dgvDetalles);
            Controls.Add(btnAgregarDetalle);
            Controls.Add(cmbProductos);
            Controls.Add(cmbClientes);
            Name = "FormVentas";
            Text = "Form2";
            Load += FormVentas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDetalles).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbClientes;
        private ComboBox cmbProductos;
        private Button btnAgregarDetalle;
        private DataGridView dgvDetalles;
        private TextBox txtCantidad;
        private Label lblTotal;
        private Button btnConfirmarVenta;
        private Button volverAlmenu;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}