namespace SistemasPedidos
{
    partial class ClientesForm
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
            btnAgregarCliente = new Button();
            btnEliminarCliente = new Button();
            btnCerrarFormulario = new Button();
            txtCorreo = new TextBox();
            txtTelefono = new TextBox();
            txtDireccion = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtNombre = new TextBox();
            listBoxClientes = new ListBox();
            SuspendLayout();
            // 
            // btnAgregarCliente
            // 
            btnAgregarCliente.Location = new Point(42, 177);
            btnAgregarCliente.Name = "btnAgregarCliente";
            btnAgregarCliente.Size = new Size(142, 23);
            btnAgregarCliente.TabIndex = 0;
            btnAgregarCliente.Text = "Agregar Cliente";
            btnAgregarCliente.UseVisualStyleBackColor = true;
            btnAgregarCliente.Click += btnAgregarCliente_Click;
            // 
            // btnEliminarCliente
            // 
            btnEliminarCliente.Location = new Point(434, 177);
            btnEliminarCliente.Name = "btnEliminarCliente";
            btnEliminarCliente.Size = new Size(135, 26);
            btnEliminarCliente.TabIndex = 2;
            btnEliminarCliente.Text = "Eliminar Cliente";
            btnEliminarCliente.UseVisualStyleBackColor = true;
            btnEliminarCliente.Click += btnEliminarCliente_Click;
            // 
            // btnCerrarFormulario
            // 
            btnCerrarFormulario.Location = new Point(494, 414);
            btnCerrarFormulario.Name = "btnCerrarFormulario";
            btnCerrarFormulario.Size = new Size(75, 23);
            btnCerrarFormulario.TabIndex = 3;
            btnCerrarFormulario.Text = "Cerrar";
            btnCerrarFormulario.UseVisualStyleBackColor = true;
            btnCerrarFormulario.Click += btnCerrarFormulario_Click;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(209, 64);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(200, 23);
            txtCorreo.TabIndex = 5;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(209, 93);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(200, 23);
            txtTelefono.TabIndex = 6;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(209, 122);
            txtDireccion.Multiline = true;
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(200, 52);
            txtDireccion.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Lavender;
            label1.Location = new Point(111, 35);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 9;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Lavender;
            label2.Location = new Point(111, 64);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 10;
            label2.Text = "Correo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Lavender;
            label3.Location = new Point(111, 93);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 11;
            label3.Text = "Telefono";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Lavender;
            label4.Location = new Point(111, 122);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 12;
            label4.Text = "Dirreciòn";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(209, 35);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(200, 23);
            txtNombre.TabIndex = 13;
            // 
            // listBoxClientes
            // 
            listBoxClientes.FormattingEnabled = true;
            listBoxClientes.ItemHeight = 15;
            listBoxClientes.Location = new Point(75, 238);
            listBoxClientes.Name = "listBoxClientes";
            listBoxClientes.Size = new Size(426, 94);
            listBoxClientes.TabIndex = 14;
            // 
            // ClientesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(609, 450);
            Controls.Add(listBoxClientes);
            Controls.Add(txtNombre);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtDireccion);
            Controls.Add(txtTelefono);
            Controls.Add(txtCorreo);
            Controls.Add(btnCerrarFormulario);
            Controls.Add(btnEliminarCliente);
            Controls.Add(btnAgregarCliente);
            Name = "ClientesForm";
            Text = "Gestor de Clientes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregarCliente;
        private Button btnEliminarCliente;
        private Button btnCerrarFormulario;
        private TextBox txtCorreo;
        private TextBox txtTelefono;
        private TextBox txtDireccion;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtNombre;
        private ListBox listBoxClientes;
    }
}