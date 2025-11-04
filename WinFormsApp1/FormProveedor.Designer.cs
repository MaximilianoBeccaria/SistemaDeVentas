namespace WinFormsApp1
{
    partial class FormProveedor
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
            components = new System.ComponentModel.Container();
            NombreProveedor = new TextBox();
            ContactoProveedor = new TextBox();
            DireccionProveedor = new TextBox();
            btnAgregar = new Button();
            dgvProveedores = new DataGridView();
            proveedorIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            contactoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            direccionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            proveedorBindingSource = new BindingSource(components);
            ModificarProveedores = new Button();
            EliminarProveedores = new Button();
            button1 = new Button();
            sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProveedores).BeginInit();
            ((System.ComponentModel.ISupportInitialize)proveedorBindingSource).BeginInit();
            SuspendLayout();
            // 
            // NombreProveedor
            // 
            NombreProveedor.Location = new Point(161, 97);
            NombreProveedor.Name = "NombreProveedor";
            NombreProveedor.Size = new Size(336, 27);
            NombreProveedor.TabIndex = 1;
            NombreProveedor.TextChanged += NombreProveedor_TextChanged;
            // 
            // ContactoProveedor
            // 
            ContactoProveedor.Location = new Point(163, 142);
            ContactoProveedor.Name = "ContactoProveedor";
            ContactoProveedor.Size = new Size(334, 27);
            ContactoProveedor.TabIndex = 2;
            // 
            // DireccionProveedor
            // 
            DireccionProveedor.Location = new Point(164, 186);
            DireccionProveedor.Name = "DireccionProveedor";
            DireccionProveedor.Size = new Size(333, 27);
            DireccionProveedor.TabIndex = 3;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(534, 97);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 4;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // dgvProveedores
            // 
            dgvProveedores.AutoGenerateColumns = false;
            dgvProveedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProveedores.Columns.AddRange(new DataGridViewColumn[] { proveedorIdDataGridViewTextBoxColumn, nombreDataGridViewTextBoxColumn, contactoDataGridViewTextBoxColumn, direccionDataGridViewTextBoxColumn });
            dgvProveedores.DataSource = proveedorBindingSource;
            dgvProveedores.GridColor = SystemColors.WindowText;
            dgvProveedores.Location = new Point(103, 253);
            dgvProveedores.Name = "dgvProveedores";
            dgvProveedores.RowHeadersWidth = 51;
            dgvProveedores.Size = new Size(553, 188);
            dgvProveedores.TabIndex = 5;
            dgvProveedores.CellClick += dgvProveedores_CellContentClick;
            dgvProveedores.CellContentClick += dgvProveedores_CellContentClick_1;
            // 
            // proveedorIdDataGridViewTextBoxColumn
            // 
            proveedorIdDataGridViewTextBoxColumn.DataPropertyName = "ProveedorId";
            proveedorIdDataGridViewTextBoxColumn.HeaderText = "ProveedorId";
            proveedorIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            proveedorIdDataGridViewTextBoxColumn.Name = "proveedorIdDataGridViewTextBoxColumn";
            proveedorIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            nombreDataGridViewTextBoxColumn.MinimumWidth = 6;
            nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            nombreDataGridViewTextBoxColumn.Width = 125;
            // 
            // contactoDataGridViewTextBoxColumn
            // 
            contactoDataGridViewTextBoxColumn.DataPropertyName = "Contacto";
            contactoDataGridViewTextBoxColumn.HeaderText = "Contacto";
            contactoDataGridViewTextBoxColumn.MinimumWidth = 6;
            contactoDataGridViewTextBoxColumn.Name = "contactoDataGridViewTextBoxColumn";
            contactoDataGridViewTextBoxColumn.Width = 125;
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            direccionDataGridViewTextBoxColumn.DataPropertyName = "Direccion";
            direccionDataGridViewTextBoxColumn.HeaderText = "Direccion";
            direccionDataGridViewTextBoxColumn.MinimumWidth = 6;
            direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            direccionDataGridViewTextBoxColumn.Width = 125;
            // 
            // proveedorBindingSource
            // 
            proveedorBindingSource.DataSource = typeof(SistemaDeVentas.Models.Proveedor);
            // 
            // ModificarProveedores
            // 
            ModificarProveedores.Location = new Point(533, 131);
            ModificarProveedores.Name = "ModificarProveedores";
            ModificarProveedores.Size = new Size(94, 29);
            ModificarProveedores.TabIndex = 6;
            ModificarProveedores.Text = "Modificar";
            ModificarProveedores.UseVisualStyleBackColor = true;
            ModificarProveedores.Click += ModificarProveedores_Click;
            // 
            // EliminarProveedores
            // 
            EliminarProveedores.Location = new Point(534, 166);
            EliminarProveedores.Name = "EliminarProveedores";
            EliminarProveedores.Size = new Size(94, 29);
            EliminarProveedores.TabIndex = 7;
            EliminarProveedores.Text = "Eliminar";
            EliminarProveedores.UseVisualStyleBackColor = true;
            EliminarProveedores.Click += EliminarProveedores_Click;
            // 
            // button1
            // 
            button1.Location = new Point(10, 475);
            button1.Name = "button1";
            button1.Size = new Size(159, 29);
            button1.TabIndex = 8;
            button1.Text = "Volver al Menu";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 97);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 9;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(72, 145);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 10;
            label2.Text = "Contacto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(72, 193);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 11;
            label3.Text = "Direccion";
            // 
            // FormProveedor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 795);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(EliminarProveedores);
            Controls.Add(ModificarProveedores);
            Controls.Add(dgvProveedores);
            Controls.Add(btnAgregar);
            Controls.Add(DireccionProveedor);
            Controls.Add(ContactoProveedor);
            Controls.Add(NombreProveedor);
            Name = "FormProveedor";
            Text = "FormProveedor";
            Load += FormProveedor_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgvProveedores).EndInit();
            ((System.ComponentModel.ISupportInitialize)proveedorBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox NombreProveedor;
        private TextBox ContactoProveedor;
        private TextBox DireccionProveedor;
        private Button btnAgregar;
        private DataGridView dgvProveedores;
        private DataGridViewTextBoxColumn proveedorIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn contactoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private BindingSource proveedorBindingSource;
        private Button ModificarProveedores;
        private Button EliminarProveedores;
        private Button button1;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}