namespace SistemasPedidos
{
    partial class GestionarPedidosForm
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
            dgvPedidos = new DataGridView();
            btnAgregarPedido = new Button();
            txtCliente = new TextBox();
            txtProducto = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            btnEliminarPedido = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPedidos).BeginInit();
            SuspendLayout();
            // 
            // dgvPedidos
            // 
            dgvPedidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPedidos.Location = new Point(44, 211);
            dgvPedidos.Name = "dgvPedidos";
            dgvPedidos.Size = new Size(522, 162);
            dgvPedidos.TabIndex = 0;
            // 
            // btnAgregarPedido
            // 
            btnAgregarPedido.Location = new Point(44, 164);
            btnAgregarPedido.Name = "btnAgregarPedido";
            btnAgregarPedido.Size = new Size(128, 23);
            btnAgregarPedido.TabIndex = 1;
            btnAgregarPedido.Text = "Agregar Pedido";
            btnAgregarPedido.UseVisualStyleBackColor = true;
            btnAgregarPedido.Click += btnAgregarPedido_Click;
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(157, 62);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(128, 23);
            txtCliente.TabIndex = 2;
            // 
            // txtProducto
            // 
            txtProducto.Location = new Point(157, 91);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(128, 23);
            txtProducto.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Lavender;
            label1.Location = new Point(61, 65);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 4;
            label1.Text = "Cliente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Lavender;
            label2.Location = new Point(61, 99);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 5;
            label2.Text = "Producto";
            // 
            // button1
            // 
            button1.Location = new Point(349, 163);
            button1.Name = "button1";
            button1.Size = new Size(126, 23);
            button1.TabIndex = 6;
            button1.Text = "Modficar Pedido";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnModificarPedido_Click;
            // 
            // btnEliminarPedido
            // 
            btnEliminarPedido.Location = new Point(44, 391);
            btnEliminarPedido.Name = "btnEliminarPedido";
            btnEliminarPedido.Size = new Size(128, 23);
            btnEliminarPedido.TabIndex = 7;
            btnEliminarPedido.Text = "Eliminar";
            btnEliminarPedido.UseVisualStyleBackColor = true;
            btnEliminarPedido.Click += btnEliminarPedido_Click;
            // 
            // GestionarPedidosForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(652, 450);
            Controls.Add(btnEliminarPedido);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtProducto);
            Controls.Add(txtCliente);
            Controls.Add(btnAgregarPedido);
            Controls.Add(dgvPedidos);
            Name = "GestionarPedidosForm";
            Text = "GestionarPedidosForm";
            ((System.ComponentModel.ISupportInitialize)dgvPedidos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPedidos;
        private Button btnAgregarPedido;
        private TextBox txtCliente;
        private TextBox txtProducto;
        private Label label1;
        private Label label2;
        private Button button1;
        private Button btnEliminarPedido;
    }
}