namespace SistemasPedidos
{
    partial class ProductosForm
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
            btnAgregarProducto = new Button();
            btnEliminarProducto = new Button();
            lbNombreProducto = new Label();
            lbPrecio = new Label();
            lbCantidad = new Label();
            txtNombreProducto = new TextBox();
            txtPrecio = new TextBox();
            txtCantidad = new TextBox();
            lstProductos = new ListBox();
            btnCerrarFormulario = new Button();
            listBoxProductos = new ListBox();
            SuspendLayout();
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.Location = new Point(57, 171);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(127, 28);
            btnAgregarProducto.TabIndex = 0;
            btnAgregarProducto.Text = "Agregar Producto";
            btnAgregarProducto.UseVisualStyleBackColor = true;
            btnAgregarProducto.Click += btnAgregarProducto_Click;
            // 
            // btnEliminarProducto
            // 
            btnEliminarProducto.Location = new Point(332, 171);
            btnEliminarProducto.Name = "btnEliminarProducto";
            btnEliminarProducto.Size = new Size(127, 28);
            btnEliminarProducto.TabIndex = 1;
            btnEliminarProducto.Text = "Eliminar Producto";
            btnEliminarProducto.UseVisualStyleBackColor = true;
            btnEliminarProducto.Click += btnEliminarProducto_Click;
            // 
            // lbNombreProducto
            // 
            lbNombreProducto.AutoSize = true;
            lbNombreProducto.Location = new Point(57, 57);
            lbNombreProducto.Name = "lbNombreProducto";
            lbNombreProducto.Size = new Size(122, 15);
            lbNombreProducto.TabIndex = 2;
            lbNombreProducto.Text = "Nombre del Producto";
            // 
            // lbPrecio
            // 
            lbPrecio.AutoSize = true;
            lbPrecio.Location = new Point(57, 84);
            lbPrecio.Name = "lbPrecio";
            lbPrecio.Size = new Size(40, 15);
            lbPrecio.TabIndex = 3;
            lbPrecio.Text = "Precio";
            // 
            // lbCantidad
            // 
            lbCantidad.AutoSize = true;
            lbCantidad.Location = new Point(57, 115);
            lbCantidad.Name = "lbCantidad";
            lbCantidad.Size = new Size(55, 15);
            lbCantidad.TabIndex = 4;
            lbCantidad.Text = "Cantidad";
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.Location = new Point(234, 57);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new Size(139, 23);
            txtNombreProducto.TabIndex = 5;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(234, 86);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(139, 23);
            txtPrecio.TabIndex = 6;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(234, 115);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(139, 23);
            txtCantidad.TabIndex = 7;
            // 
            // lstProductos
            // 
            lstProductos.FormattingEnabled = true;
            lstProductos.ItemHeight = 15;
            lstProductos.Location = new Point(1150, 476);
            lstProductos.Name = "lstProductos";
            lstProductos.Size = new Size(402, 94);
            lstProductos.TabIndex = 8;
            // 
            // btnCerrarFormulario
            // 
            btnCerrarFormulario.Location = new Point(332, 389);
            btnCerrarFormulario.Name = "btnCerrarFormulario";
            btnCerrarFormulario.Size = new Size(108, 23);
            btnCerrarFormulario.TabIndex = 9;
            btnCerrarFormulario.Text = "Cerrar";
            btnCerrarFormulario.UseVisualStyleBackColor = true;
            btnCerrarFormulario.Click += btnCerrarFormulario_Click;
            // 
            // listBoxProductos
            // 
            listBoxProductos.FormattingEnabled = true;
            listBoxProductos.ItemHeight = 15;
            listBoxProductos.Location = new Point(72, 240);
            listBoxProductos.Name = "listBoxProductos";
            listBoxProductos.Size = new Size(348, 94);
            listBoxProductos.TabIndex = 10;
            // 
            // ProductosForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(501, 450);
            Controls.Add(listBoxProductos);
            Controls.Add(btnCerrarFormulario);
            Controls.Add(lstProductos);
            Controls.Add(txtCantidad);
            Controls.Add(txtPrecio);
            Controls.Add(txtNombreProducto);
            Controls.Add(lbCantidad);
            Controls.Add(lbPrecio);
            Controls.Add(lbNombreProducto);
            Controls.Add(btnEliminarProducto);
            Controls.Add(btnAgregarProducto);
            Name = "ProductosForm";
            Text = "Gestionar Productos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregarProducto;
        private Button btnEliminarProducto;
        private Label lbNombreProducto;
        private Label lbPrecio;
        private Label lbCantidad;
        private TextBox txtNombreProducto;
        private TextBox txtPrecio;
        private TextBox txtCantidad;
        private ListBox lstProductos;
        private Button btnCerrarFormulario;
        private ListBox listBoxProductos;
    }
}