namespace Menu_de_Gestion
{
    partial class FormClientes
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
            NombreCliente = new TextBox();
            DireccionCliente = new TextBox();
            TelefonoCliente = new TextBox();
            Nombre = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            GuardarCliente = new Button();
            Modificar_Cliente = new Button();
            Eliminar_Cliente = new Button();
            label6 = new Label();
            DniCliente = new TextBox();
            button2 = new Button();
            dgvClientes = new DataGridView();
            idClienteDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dniDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            emailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            telefonoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            clienteBindingSource = new BindingSource(components);
            ordenesBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clienteBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ordenesBindingSource).BeginInit();
            SuspendLayout();
            // 
            // NombreCliente
            // 
            NombreCliente.Location = new Point(32, 137);
            NombreCliente.Margin = new Padding(3, 4, 3, 4);
            NombreCliente.Name = "NombreCliente";
            NombreCliente.Size = new Size(177, 27);
            NombreCliente.TabIndex = 0;
            NombreCliente.TextChanged += NombreCliente_TextChanged;
            // 
            // DireccionCliente
            // 
            DireccionCliente.Location = new Point(32, 251);
            DireccionCliente.Margin = new Padding(3, 4, 3, 4);
            DireccionCliente.Name = "DireccionCliente";
            DireccionCliente.Size = new Size(177, 27);
            DireccionCliente.TabIndex = 2;
            // 
            // TelefonoCliente
            // 
            TelefonoCliente.Location = new Point(32, 306);
            TelefonoCliente.Margin = new Padding(3, 4, 3, 4);
            TelefonoCliente.Name = "TelefonoCliente";
            TelefonoCliente.Size = new Size(177, 27);
            TelefonoCliente.TabIndex = 3;
            // 
            // Nombre
            // 
            Nombre.AutoSize = true;
            Nombre.Location = new Point(49, 113);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(136, 20);
            Nombre.TabIndex = 4;
            Nombre.Text = "Nombre y Apellido";
            Nombre.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(79, 227);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 6;
            label2.Text = "Direccion:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(84, 282);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 7;
            label3.Text = "Telefono:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(44, 46);
            label4.Name = "label4";
            label4.Size = new Size(158, 20);
            label4.TabIndex = 8;
            label4.Text = "REGISTRO DE CLIENTE";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(435, 291);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 9;
            // 
            // GuardarCliente
            // 
            GuardarCliente.BackColor = Color.Lime;
            GuardarCliente.Location = new Point(49, 341);
            GuardarCliente.Margin = new Padding(3, 4, 3, 4);
            GuardarCliente.Name = "GuardarCliente";
            GuardarCliente.Size = new Size(153, 41);
            GuardarCliente.TabIndex = 10;
            GuardarCliente.Text = "Guardar";
            GuardarCliente.UseVisualStyleBackColor = false;
            GuardarCliente.Click += GuardarCliente_Click;
            // 
            // Modificar_Cliente
            // 
            Modificar_Cliente.Location = new Point(316, 81);
            Modificar_Cliente.Margin = new Padding(3, 4, 3, 4);
            Modificar_Cliente.Name = "Modificar_Cliente";
            Modificar_Cliente.Size = new Size(149, 34);
            Modificar_Cliente.TabIndex = 11;
            Modificar_Cliente.Text = "Modificar Cliente";
            Modificar_Cliente.UseVisualStyleBackColor = true;
            Modificar_Cliente.Click += Modificar_Cliente_Click;
            // 
            // Eliminar_Cliente
            // 
            Eliminar_Cliente.Location = new Point(482, 81);
            Eliminar_Cliente.Margin = new Padding(3, 4, 3, 4);
            Eliminar_Cliente.Name = "Eliminar_Cliente";
            Eliminar_Cliente.Size = new Size(144, 34);
            Eliminar_Cliente.TabIndex = 12;
            Eliminar_Cliente.Text = "Eliminar Cliente";
            Eliminar_Cliente.UseVisualStyleBackColor = true;
            Eliminar_Cliente.Click += Eliminar_Cliente_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(97, 172);
            label6.Name = "label6";
            label6.Size = new Size(38, 20);
            label6.TabIndex = 14;
            label6.Text = "DNI:";
            // 
            // DniCliente
            // 
            DniCliente.Location = new Point(32, 196);
            DniCliente.Margin = new Padding(3, 4, 3, 4);
            DniCliente.Name = "DniCliente";
            DniCliente.Size = new Size(177, 27);
            DniCliente.TabIndex = 13;
            DniCliente.TextChanged += DniCliente_TextChanged;
            // 
            // button2
            // 
            button2.Location = new Point(12, 547);
            button2.Name = "button2";
            button2.Size = new Size(117, 41);
            button2.TabIndex = 22;
            button2.Text = "Volver al Menu";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dgvClientes
            // 
            dgvClientes.AutoGenerateColumns = false;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Columns.AddRange(new DataGridViewColumn[] { idClienteDataGridViewTextBoxColumn, dataGridViewTextBoxColumn1, dniDataGridViewTextBoxColumn, emailDataGridViewTextBoxColumn, telefonoDataGridViewTextBoxColumn });
            dgvClientes.DataSource = clienteBindingSource;
            dgvClientes.Location = new Point(245, 152);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.RowHeadersWidth = 51;
            dgvClientes.Size = new Size(657, 257);
            dgvClientes.TabIndex = 23;
            dgvClientes.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // idClienteDataGridViewTextBoxColumn
            // 
            idClienteDataGridViewTextBoxColumn.DataPropertyName = "IdCliente";
            idClienteDataGridViewTextBoxColumn.HeaderText = "IdCliente";
            idClienteDataGridViewTextBoxColumn.MinimumWidth = 6;
            idClienteDataGridViewTextBoxColumn.Name = "idClienteDataGridViewTextBoxColumn";
            idClienteDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "NombreCompleto";
            dataGridViewTextBoxColumn1.HeaderText = "NombreCompleto";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dniDataGridViewTextBoxColumn
            // 
            dniDataGridViewTextBoxColumn.DataPropertyName = "Dni";
            dniDataGridViewTextBoxColumn.HeaderText = "Dni";
            dniDataGridViewTextBoxColumn.MinimumWidth = 6;
            dniDataGridViewTextBoxColumn.Name = "dniDataGridViewTextBoxColumn";
            dniDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            emailDataGridViewTextBoxColumn.HeaderText = "Email";
            emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            telefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono";
            telefonoDataGridViewTextBoxColumn.HeaderText = "Telefono";
            telefonoDataGridViewTextBoxColumn.MinimumWidth = 6;
            telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            telefonoDataGridViewTextBoxColumn.Width = 125;
            // 
            // clienteBindingSource
            // 
            clienteBindingSource.DataSource = typeof(SistemaDeVentas.Models.Cliente);
            // 
            // ordenesBindingSource
            // 
            ordenesBindingSource.DataMember = "Ordenes";
            ordenesBindingSource.DataSource = clienteBindingSource;
            // 
            // FormClientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(dgvClientes);
            Controls.Add(button2);
            Controls.Add(label6);
            Controls.Add(DniCliente);
            Controls.Add(Eliminar_Cliente);
            Controls.Add(Modificar_Cliente);
            Controls.Add(GuardarCliente);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Nombre);
            Controls.Add(TelefonoCliente);
            Controls.Add(DireccionCliente);
            Controls.Add(NombreCliente);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormClientes";
            Text = "FormClientes";
            Load += FormClientes_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ((System.ComponentModel.ISupportInitialize)clienteBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)ordenesBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox NombreCliente;
        private TextBox DireccionCliente;
        private TextBox TelefonoCliente;
        private Label Nombre;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button GuardarCliente;
        private Button Modificar_Cliente;
        private Button Eliminar_Cliente;
        private Label label6;
        private TextBox DniCliente;
        private Button button2;
        private DataGridView dgvClientes;
        private DataGridViewTextBoxColumn nombreCompletoDataGridViewTextBoxColumn;
        private BindingSource clienteBindingSource;
        private DataGridViewTextBoxColumn idClienteDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dniDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private BindingSource ordenesBindingSource;
    }
}