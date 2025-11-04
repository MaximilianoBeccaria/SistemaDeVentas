namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtNombre = new TextBox();
            txtCategoria = new TextBox();
            txtPrecio = new TextBox();
            txtStock = new TextBox();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnListar = new Button();
            btnAgregar = new Button();
            dgvProductos = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colNombre = new DataGridViewTextBoxColumn();
            colCategoria = new DataGridViewTextBoxColumn();
            colPrecio = new DataGridViewTextBoxColumn();
            colStock = new DataGridViewTextBoxColumn();
            label6 = new Label();
            button1 = new Button();
            SKUProducto = new TextBox();
            label7 = new Label();
            cmbProveedores = new ComboBox();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(236, 28);
            label1.Name = "label1";
            label1.Size = new Size(362, 46);
            label1.TabIndex = 0;
            label1.Text = "Gestión de Productos";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label2.Location = new Point(92, 182);
            label2.Name = "label2";
            label2.Size = new Size(94, 25);
            label2.TabIndex = 1;
            label2.Text = "Nombre:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label3.Location = new Point(92, 234);
            label3.Name = "label3";
            label3.Size = new Size(113, 25);
            label3.TabIndex = 2;
            label3.Text = "Categoría:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label4.Location = new Point(92, 291);
            label4.Name = "label4";
            label4.Size = new Size(80, 25);
            label4.TabIndex = 3;
            label4.Text = "Precio:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label5.Location = new Point(92, 344);
            label5.Name = "label5";
            label5.Size = new Size(74, 25);
            label5.TabIndex = 4;
            label5.Text = "Stock:";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(206, 175);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(185, 32);
            txtNombre.TabIndex = 5;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // txtCategoria
            // 
            txtCategoria.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCategoria.Location = new Point(206, 227);
            txtCategoria.Margin = new Padding(3, 4, 3, 4);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(185, 32);
            txtCategoria.TabIndex = 6;
            txtCategoria.TextChanged += textBox2_TextChanged;
            // 
            // txtPrecio
            // 
            txtPrecio.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrecio.Location = new Point(206, 284);
            txtPrecio.Margin = new Padding(3, 4, 3, 4);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(185, 32);
            txtPrecio.TabIndex = 7;
            // 
            // txtStock
            // 
            txtStock.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStock.Location = new Point(206, 337);
            txtStock.Margin = new Padding(3, 4, 3, 4);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(185, 32);
            txtStock.TabIndex = 8;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = SystemColors.GradientActiveCaption;
            btnEliminar.Location = new Point(637, 227);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(117, 44);
            btnEliminar.TabIndex = 9;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = SystemColors.GradientActiveCaption;
            btnModificar.Location = new Point(637, 175);
            btnModificar.Margin = new Padding(3, 4, 3, 4);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(117, 44);
            btnModificar.TabIndex = 10;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += button2_Click;
            // 
            // btnListar
            // 
            btnListar.BackColor = SystemColors.GradientActiveCaption;
            btnListar.Location = new Point(637, 279);
            btnListar.Margin = new Padding(3, 4, 3, 4);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(117, 43);
            btnListar.TabIndex = 11;
            btnListar.Text = "Listar";
            btnListar.UseVisualStyleBackColor = false;
            btnListar.Click += btnListar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = SystemColors.GradientActiveCaption;
            btnAgregar.Location = new Point(637, 123);
            btnAgregar.Margin = new Padding(3, 4, 3, 4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(117, 44);
            btnAgregar.TabIndex = 12;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // dgvProductos
            // 
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Columns.AddRange(new DataGridViewColumn[] { colId, colNombre, colCategoria, colPrecio, colStock });
            dgvProductos.Location = new Point(90, 413);
            dgvProductos.Margin = new Padding(3, 4, 3, 4);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.RowHeadersWidth = 51;
            dgvProductos.Size = new Size(677, 255);
            dgvProductos.TabIndex = 13;
            dgvProductos.CellClick += dgvProductos_CellClick;
            dgvProductos.CellContentClick += dgvProductos_CellContentClick;
            dgvProductos.SelectionChanged += dgvProductos_SelectionChanged;
            // 
            // colId
            // 
            colId.DataPropertyName = "ProductoId";
            colId.HeaderText = "ID";
            colId.MinimumWidth = 6;
            colId.Name = "colId";
            colId.Width = 125;
            // 
            // colNombre
            // 
            colNombre.DataPropertyName = "Nombre";
            colNombre.HeaderText = "Nombre";
            colNombre.MinimumWidth = 6;
            colNombre.Name = "colNombre";
            colNombre.Width = 125;
            // 
            // colCategoria
            // 
            colCategoria.DataPropertyName = "Categoria";
            colCategoria.HeaderText = "Categoría";
            colCategoria.MinimumWidth = 6;
            colCategoria.Name = "colCategoria";
            colCategoria.Width = 125;
            // 
            // colPrecio
            // 
            colPrecio.DataPropertyName = "Precio";
            colPrecio.HeaderText = "Precio";
            colPrecio.MinimumWidth = 6;
            colPrecio.Name = "colPrecio";
            colPrecio.Width = 125;
            // 
            // colStock
            // 
            colStock.DataPropertyName = "Stock";
            colStock.HeaderText = "Stock";
            colStock.MinimumWidth = 6;
            colStock.Name = "colStock";
            colStock.Width = 125;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(862, 40);
            label6.Name = "label6";
            label6.Size = new Size(0, 32);
            label6.TabIndex = 14;
            label6.Click += label6_Click;
            // 
            // button1
            // 
            button1.Location = new Point(12, 699);
            button1.Name = "button1";
            button1.Size = new Size(161, 29);
            button1.TabIndex = 15;
            button1.Text = "Volver al Menu";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // SKUProducto
            // 
            SKUProducto.Location = new Point(206, 123);
            SKUProducto.Name = "SKUProducto";
            SKUProducto.Size = new Size(185, 27);
            SKUProducto.TabIndex = 16;
            SKUProducto.TextChanged += SKUProducto_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label7.Location = new Point(92, 122);
            label7.Name = "label7";
            label7.Size = new Size(81, 25);
            label7.TabIndex = 17;
            label7.Text = "Codigo";
            // 
            // cmbProveedores
            // 
            cmbProveedores.FormattingEnabled = true;
            cmbProveedores.Location = new Point(412, 175);
            cmbProveedores.Name = "cmbProveedores";
            cmbProveedores.Size = new Size(207, 28);
            cmbProveedores.TabIndex = 18;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label8.Location = new Point(456, 147);
            label8.Name = "label8";
            label8.Size = new Size(111, 25);
            label8.TabIndex = 19;
            label8.Text = "Proveedor";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(852, 750);
            Controls.Add(label8);
            Controls.Add(cmbProveedores);
            Controls.Add(label7);
            Controls.Add(SKUProducto);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(dgvProductos);
            Controls.Add(btnAgregar);
            Controls.Add(btnListar);
            Controls.Add(btnModificar);
            Controls.Add(btnEliminar);
            Controls.Add(txtStock);
            Controls.Add(txtPrecio);
            Controls.Add(txtCategoria);
            Controls.Add(txtNombre);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtNombre;
        private TextBox txtCategoria;
        private TextBox txtPrecio;
        private TextBox txtStock;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnListar;
        private Button btnAgregar;
        private DataGridView dgvProductos;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colNombre;
        private DataGridViewTextBoxColumn colCategoria;
        private DataGridViewTextBoxColumn colPrecio;
        private DataGridViewTextBoxColumn colStock;
        private Label label6;
        private Button button1;
        private TextBox SKUProducto;
        private Label label7;
        private ComboBox cmbProveedores;
        private Label label8;
    }
}
