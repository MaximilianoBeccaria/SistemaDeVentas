namespace SistemaVentaProductos.WinForms
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
            btnAgregar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnListar = new Button();
            dgvProductos = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(117, 9);
            label1.Name = "label1";
            label1.Size = new Size(192, 25);
            label1.TabIndex = 0;
            label1.Text = "Gestión de Productos";
            label1.Click += this.label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(117, 45);
            label2.Name = "label2";
            label2.Size = new Size(62, 19);
            label2.TabIndex = 1;
            label2.Text = "Nombre:";
            label2.Click += this.label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(117, 74);
            label3.Name = "label3";
            label3.Size = new Size(71, 19);
            label3.TabIndex = 2;
            label3.Text = "Categoría:";
            label3.Click += this.label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(117, 100);
            label4.Name = "label4";
            label4.Size = new Size(49, 19);
            label4.TabIndex = 3;
            label4.Text = "Precio:";
            label4.Click += this.label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(117, 129);
            label5.Name = "label5";
            label5.Size = new Size(45, 19);
            label5.TabIndex = 4;
            label5.Text = "Stock:";
            label5.Click += this.label5_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(269, 41);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 5;
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(269, 70);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(100, 23);
            txtCategoria.TabIndex = 6;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(269, 99);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(100, 23);
            txtPrecio.TabIndex = 7;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(269, 128);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(100, 23);
            txtStock.TabIndex = 8;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(113, 166);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 9;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(210, 166);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 23);
            btnModificar.TabIndex = 10;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(316, 166);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 11;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += this.button3_Click;
            // 
            // btnListar
            // 
            btnListar.Location = new Point(416, 166);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(75, 23);
            btnListar.TabIndex = 12;
            btnListar.Text = "Listar";
            btnListar.UseVisualStyleBackColor = true;
            // 
            // dgvProductos
            // 
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Columns.AddRange(new DataGridViewColumn[] { colId });
            dgvProductos.Location = new Point(117, 224);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.Size = new Size(574, 214);
            dgvProductos.TabIndex = 13;
            // 
            // colId
            // 
            colId.DataPropertyName = "Id";
            colId.HeaderText = "ID";
            colId.Name = "colId";
            colId.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvProductos);
            Controls.Add(btnListar);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
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
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnListar;
        private DataGridView dgvProductos;
        private DataGridViewTextBoxColumn colId;
    }
}
