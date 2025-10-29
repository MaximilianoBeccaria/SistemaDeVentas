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
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(209, 30);
            label1.Name = "label1";
            label1.Size = new Size(204, 25);
            label1.TabIndex = 0;
            label1.Text = "Gestión de Productos";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(91, 89);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 1;
            label2.Text = "Nombre:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(91, 149);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 2;
            label3.Text = "Categoría:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(91, 202);
            label4.Name = "label4";
            label4.Size = new Size(53, 20);
            label4.TabIndex = 3;
            label4.Text = "Precio:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(91, 255);
            label5.Name = "label5";
            label5.Size = new Size(48, 20);
            label5.TabIndex = 4;
            label5.Text = "Stock:";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(218, 86);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(162, 27);
            txtNombre.TabIndex = 5;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // txtCategoria
            // 
            txtCategoria.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCategoria.Location = new Point(218, 146);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(162, 27);
            txtCategoria.TabIndex = 6;
            txtCategoria.TextChanged += textBox2_TextChanged;
            // 
            // txtPrecio
            // 
            txtPrecio.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrecio.Location = new Point(218, 199);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(162, 27);
            txtPrecio.TabIndex = 7;
            // 
            // txtStock
            // 
            txtStock.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStock.Location = new Point(218, 252);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(162, 27);
            txtStock.TabIndex = 8;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = SystemColors.GradientActiveCaption;
            btnEliminar.Location = new Point(477, 202);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(102, 33);
            btnEliminar.TabIndex = 9;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = SystemColors.GradientActiveCaption;
            btnModificar.Location = new Point(477, 149);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(102, 33);
            btnModificar.TabIndex = 10;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += button2_Click;
            // 
            // btnListar
            // 
            btnListar.BackColor = SystemColors.GradientActiveCaption;
            btnListar.Location = new Point(477, 255);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(102, 32);
            btnListar.TabIndex = 11;
            btnListar.Text = "Listar";
            btnListar.UseVisualStyleBackColor = false;
            btnListar.Click += btnListar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = SystemColors.GradientActiveCaption;
            btnAgregar.Location = new Point(477, 84);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(102, 33);
            btnAgregar.TabIndex = 12;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // dgvProductos
            // 
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Columns.AddRange(new DataGridViewColumn[] { colId, colNombre, colCategoria, colPrecio, colStock });
            dgvProductos.Location = new Point(79, 310);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.Size = new Size(543, 191);
            dgvProductos.TabIndex = 13;
            dgvProductos.CellClick += dgvProductos_CellClick;
            dgvProductos.CellContentClick += dgvProductos_CellContentClick;
            dgvProductos.SelectionChanged += dgvProductos_SelectionChanged;
            // 
            // colId
            // 
            colId.DataPropertyName = "ProductoId";
            colId.HeaderText = "ID";
            colId.Name = "colId";
            // 
            // colNombre
            // 
            colNombre.DataPropertyName = "Nombre";
            colNombre.HeaderText = "Nombre";
            colNombre.Name = "colNombre";
            // 
            // colCategoria
            // 
            colCategoria.DataPropertyName = "Categoria";
            colCategoria.HeaderText = "Categoría";
            colCategoria.Name = "colCategoria";
            // 
            // colPrecio
            // 
            colPrecio.DataPropertyName = "Precio";
            colPrecio.HeaderText = "Precio";
            colPrecio.Name = "colPrecio";
            // 
            // colStock
            // 
            colStock.DataPropertyName = "Stock";
            colStock.HeaderText = "Stock";
            colStock.Name = "colStock";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(749, 533);
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
    }
}
