namespace SistemasPedidos
{
    partial class Principal
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
            GestionarClientes = new Button();
            btnGestionarProductos = new Button();
            RealizarPedidos = new Button();
            Pedidos = new Button();
            SuspendLayout();
            // 
            // GestionarClientes
            // 
            GestionarClientes.ForeColor = SystemColors.ActiveCaptionText;
            GestionarClientes.Location = new Point(56, 71);
            GestionarClientes.Name = "GestionarClientes";
            GestionarClientes.Size = new Size(217, 30);
            GestionarClientes.TabIndex = 0;
            GestionarClientes.Text = "Gestionar Clientes";
            GestionarClientes.UseVisualStyleBackColor = true;
            GestionarClientes.Click += btnGestionarClientes_Click;
            // 
            // btnGestionarProductos
            // 
            btnGestionarProductos.Location = new Point(56, 128);
            btnGestionarProductos.Name = "btnGestionarProductos";
            btnGestionarProductos.Size = new Size(217, 29);
            btnGestionarProductos.TabIndex = 1;
            btnGestionarProductos.Text = "Gestionar Productos";
            btnGestionarProductos.UseVisualStyleBackColor = true;
            btnGestionarProductos.Click += btnGestionarProductos_Click;
            // 
            // RealizarPedidos
            // 
            RealizarPedidos.Location = new Point(56, 182);
            RealizarPedidos.Name = "RealizarPedidos";
            RealizarPedidos.Size = new Size(217, 30);
            RealizarPedidos.TabIndex = 2;
            RealizarPedidos.Text = "Gestionar Pedidos";
            RealizarPedidos.UseVisualStyleBackColor = true;
            RealizarPedidos.Click += btnGestionarPedidos_Click;
            // 
            // Pedidos
            // 
            Pedidos.Location = new Point(56, 234);
            Pedidos.Name = "Pedidos";
            Pedidos.Size = new Size(217, 30);
            Pedidos.TabIndex = 3;
            Pedidos.Text = "Ver Pedidos";
            Pedidos.UseVisualStyleBackColor = true;
            Pedidos.Click += btnVerPedidos_Click;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(341, 335);
            Controls.Add(Pedidos);
            Controls.Add(RealizarPedidos);
            Controls.Add(btnGestionarProductos);
            Controls.Add(GestionarClientes);
            Name = "Principal";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Gestion de Pedidos";
            ResumeLayout(false);
        }

        #endregion

        private Button GestionarClientes;
        private Button btnGestionarProductos;
        private Button RealizarPedidos;
        private Button Pedidos;
        
        

        
    }
}
