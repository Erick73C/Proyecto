using System.Windows.Forms;

namespace Proyecto
{
    partial class frmClienteCompras
    {
        private System.ComponentModel.IContainer components = null;
        private Panel panelFormulario;
        private Label lblIdUsuario;
        private TextBox txtIdUsuario;
        private Label lblIdProducto;
        private TextBox txtIdProducto;
        private Label lblNombreProducto;
        private TextBox txtNombreProducto;
        private Label lblPrecioUnitario;
        private TextBox txtPrecioUnitario;
        private Label lblCantidad;
        private TextBox txtCantidad;
        private Button btnAgregarCarrito;
        private DataGridView dgvCarrito;
        private Label lblCarrito;
        private Label lblTotalCompra;
        private TextBox txtTotalCompra;
        private Button btnEliminarItem;
        private Button btnVaciarCarrito;
        private Button btnFinalizarCompra;
        private Label lblTitulo;
        private Label lblCantidadItems;
        private TextBox txtTicket;
        private Label lblTicket;
        private Button btnImprimirTicket;
        private Panel panelCarrito;
        private Panel panelTicket;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelFormulario = new System.Windows.Forms.Panel();
            this.btnAgregarCarrito = new System.Windows.Forms.Button();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtPrecioUnitario = new System.Windows.Forms.TextBox();
            this.lblPrecioUnitario = new System.Windows.Forms.Label();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.lblNombreProducto = new System.Windows.Forms.Label();
            this.txtIdProducto = new System.Windows.Forms.TextBox();
            this.lblIdProducto = new System.Windows.Forms.Label();
            this.txtIdUsuario = new System.Windows.Forms.TextBox();
            this.lblIdUsuario = new System.Windows.Forms.Label();
            this.dgvCarrito = new System.Windows.Forms.DataGridView();
            this.panelCarrito = new System.Windows.Forms.Panel();
            this.btnVaciarCarrito = new System.Windows.Forms.Button();
            this.btnEliminarItem = new System.Windows.Forms.Button();
            this.txtTotalCompra = new System.Windows.Forms.TextBox();
            this.lblTotalCompra = new System.Windows.Forms.Label();
            this.lblCantidadItems = new System.Windows.Forms.Label();
            this.lblCarrito = new System.Windows.Forms.Label();
            this.panelTicket = new System.Windows.Forms.Panel();
            this.btnImprimirTicket = new System.Windows.Forms.Button();
            this.txtTicket = new System.Windows.Forms.TextBox();
            this.lblTicket = new System.Windows.Forms.Label();
            this.btnFinalizarCompra = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();

            // panelFormulario
            this.panelFormulario.BackColor = System.Drawing.Color.White;
            this.panelFormulario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFormulario.Controls.Add(this.btnAgregarCarrito);
            this.panelFormulario.Controls.Add(this.txtCantidad);
            this.panelFormulario.Controls.Add(this.lblCantidad);
            this.panelFormulario.Controls.Add(this.txtPrecioUnitario);
            this.panelFormulario.Controls.Add(this.lblPrecioUnitario);
            this.panelFormulario.Controls.Add(this.txtNombreProducto);
            this.panelFormulario.Controls.Add(this.lblNombreProducto);
            this.panelFormulario.Controls.Add(this.txtIdProducto);
            this.panelFormulario.Controls.Add(this.lblIdProducto);
            this.panelFormulario.Controls.Add(this.txtIdUsuario);
            this.panelFormulario.Controls.Add(this.lblIdUsuario);
            this.panelFormulario.Location = new System.Drawing.Point(12, 45);
            this.panelFormulario.Name = "panelFormulario";
            this.panelFormulario.Size = new System.Drawing.Size(300, 250);

            // lblIdUsuario
            this.lblIdUsuario.AutoSize = true;
            this.lblIdUsuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblIdUsuario.Location = new System.Drawing.Point(15, 15);
            this.lblIdUsuario.Name = "lblIdUsuario";
            this.lblIdUsuario.Size = new System.Drawing.Size(70, 15);
            this.lblIdUsuario.Text = "ID Usuario:";

            // txtIdUsuario
            this.txtIdUsuario.BackColor = System.Drawing.SystemColors.Control;
            this.txtIdUsuario.Location = new System.Drawing.Point(15, 35);
            this.txtIdUsuario.Name = "txtIdUsuario";
            this.txtIdUsuario.ReadOnly = true;
            this.txtIdUsuario.Size = new System.Drawing.Size(100, 23);

            // lblIdProducto
            this.lblIdProducto.AutoSize = true;
            this.lblIdProducto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblIdProducto.Location = new System.Drawing.Point(15, 70);
            this.lblIdProducto.Name = "lblIdProducto";
            this.lblIdProducto.Size = new System.Drawing.Size(78, 15);
            this.lblIdProducto.Text = "ID Producto:";

            // txtIdProducto
            this.txtIdProducto.Location = new System.Drawing.Point(15, 90);
            this.txtIdProducto.Name = "txtIdProducto";
            this.txtIdProducto.Size = new System.Drawing.Size(100, 23);
            this.txtIdProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdProducto_KeyPress);

            // lblNombreProducto
            this.lblNombreProducto.AutoSize = true;
            this.lblNombreProducto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblNombreProducto.Location = new System.Drawing.Point(15, 125);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(110, 15);
            this.lblNombreProducto.Text = "Nombre Producto:";

            // txtNombreProducto
            this.txtNombreProducto.Location = new System.Drawing.Point(15, 145);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(200, 23);

            // lblPrecioUnitario
            this.lblPrecioUnitario.AutoSize = true;
            this.lblPrecioUnitario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPrecioUnitario.Location = new System.Drawing.Point(150, 70);
            this.lblPrecioUnitario.Name = "lblPrecioUnitario";
            this.lblPrecioUnitario.Size = new System.Drawing.Size(93, 15);
            this.lblPrecioUnitario.Text = "Precio Unitario:";

            // txtPrecioUnitario
            this.txtPrecioUnitario.Location = new System.Drawing.Point(150, 90);
            this.txtPrecioUnitario.Name = "txtPrecioUnitario";
            this.txtPrecioUnitario.Size = new System.Drawing.Size(100, 23);
            this.txtPrecioUnitario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioUnitario_KeyPress);

            // lblCantidad
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCantidad.Location = new System.Drawing.Point(150, 125);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(61, 15);
            this.lblCantidad.Text = "Cantidad:";

            // txtCantidad
            this.txtCantidad.Location = new System.Drawing.Point(150, 145);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Text = "1";
            this.txtCantidad.Size = new System.Drawing.Size(65, 23);
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);

            // btnAgregarCarrito
            this.btnAgregarCarrito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnAgregarCarrito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarCarrito.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAgregarCarrito.ForeColor = System.Drawing.Color.White;
            this.btnAgregarCarrito.Location = new System.Drawing.Point(15, 190);
            this.btnAgregarCarrito.Name = "btnAgregarCarrito";
            this.btnAgregarCarrito.Size = new System.Drawing.Size(235, 35);
            this.btnAgregarCarrito.Text = "AGREGAR AL CARRITO";
            this.btnAgregarCarrito.Click += new System.EventHandler(this.btnAgregarCarrito_Click);

            // panelCarrito
            this.panelCarrito.BackColor = System.Drawing.Color.White;
            this.panelCarrito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCarrito.Controls.Add(this.btnVaciarCarrito);
            this.panelCarrito.Controls.Add(this.btnEliminarItem);
            this.panelCarrito.Controls.Add(this.txtTotalCompra);
            this.panelCarrito.Controls.Add(this.lblTotalCompra);
            this.panelCarrito.Controls.Add(this.lblCantidadItems);
            this.panelCarrito.Controls.Add(this.lblCarrito);
            this.panelCarrito.Controls.Add(this.dgvCarrito);
            this.panelCarrito.Location = new System.Drawing.Point(325, 45);
            this.panelCarrito.Name = "panelCarrito";
            this.panelCarrito.Size = new System.Drawing.Size(450, 300);

            // dgvCarrito
            this.dgvCarrito.Location = new System.Drawing.Point(15, 40);
            this.dgvCarrito.Name = "dgvCarrito";
            this.dgvCarrito.Size = new System.Drawing.Size(420, 150);
            this.dgvCarrito.ReadOnly = true;

            // lblCarrito
            this.lblCarrito.AutoSize = true;
            this.lblCarrito.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblCarrito.Location = new System.Drawing.Point(15, 15);
            this.lblCarrito.Name = "lblCarrito";
            this.lblCarrito.Size = new System.Drawing.Size(67, 21);
            this.lblCarrito.Text = "Carrito:";

            // lblCantidadItems
            this.lblCantidadItems.AutoSize = true;
            this.lblCantidadItems.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblCantidadItems.Location = new System.Drawing.Point(100, 20);
            this.lblCantidadItems.Name = "lblCantidadItems";
            this.lblCantidadItems.Size = new System.Drawing.Size(120, 15);
            this.lblCantidadItems.Text = "0 items en el carrito";

            // lblTotalCompra
            this.lblTotalCompra.AutoSize = true;
            this.lblTotalCompra.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTotalCompra.Location = new System.Drawing.Point(15, 210);
            this.lblTotalCompra.Name = "lblTotalCompra";
            this.lblTotalCompra.Size = new System.Drawing.Size(39, 15);
            this.lblTotalCompra.Text = "Total:";

            // txtTotalCompra
            this.txtTotalCompra.BackColor = System.Drawing.SystemColors.Control;
            this.txtTotalCompra.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.txtTotalCompra.ForeColor = System.Drawing.Color.Green;
            this.txtTotalCompra.Location = new System.Drawing.Point(60, 207);
            this.txtTotalCompra.Name = "txtTotalCompra";
            this.txtTotalCompra.ReadOnly = true;
            this.txtTotalCompra.Size = new System.Drawing.Size(100, 25);

            // btnEliminarItem
            this.btnEliminarItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnEliminarItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnEliminarItem.ForeColor = System.Drawing.Color.White;
            this.btnEliminarItem.Location = new System.Drawing.Point(200, 200);
            this.btnEliminarItem.Name = "btnEliminarItem";
            this.btnEliminarItem.Size = new System.Drawing.Size(110, 35);
            this.btnEliminarItem.Text = "ELIMINAR ITEM";
            this.btnEliminarItem.Click += new System.EventHandler(this.btnEliminarItem_Click);

            // btnVaciarCarrito
            this.btnVaciarCarrito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnVaciarCarrito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVaciarCarrito.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnVaciarCarrito.ForeColor = System.Drawing.Color.White;
            this.btnVaciarCarrito.Location = new System.Drawing.Point(325, 200);
            this.btnVaciarCarrito.Name = "btnVaciarCarrito";
            this.btnVaciarCarrito.Size = new System.Drawing.Size(110, 35);
            this.btnVaciarCarrito.Text = "VACIAR CARRITO";
            this.btnVaciarCarrito.Click += new System.EventHandler(this.btnVaciarCarrito_Click);

            // panelTicket
            this.panelTicket.BackColor = System.Drawing.Color.White;
            this.panelTicket.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTicket.Controls.Add(this.btnImprimirTicket);
            this.panelTicket.Controls.Add(this.txtTicket);
            this.panelTicket.Controls.Add(this.lblTicket);
            this.panelTicket.Location = new System.Drawing.Point(12, 310);
            this.panelTicket.Name = "panelTicket";
            this.panelTicket.Size = new System.Drawing.Size(763, 200);

            // lblTicket
            this.lblTicket.AutoSize = true;
            this.lblTicket.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTicket.Location = new System.Drawing.Point(15, 15);
            this.lblTicket.Name = "lblTicket";
            this.lblTicket.Size = new System.Drawing.Size(58, 21);
            this.lblTicket.Text = "Ticket:";

            // txtTicket
            this.txtTicket.Location = new System.Drawing.Point(15, 40);
            this.txtTicket.Multiline = true;
            this.txtTicket.Name = "txtTicket";
            this.txtTicket.ReadOnly = true;
            this.txtTicket.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTicket.Size = new System.Drawing.Size(600, 145);

            // btnImprimirTicket
            this.btnImprimirTicket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnImprimirTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimirTicket.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnImprimirTicket.ForeColor = System.Drawing.Color.White;
            this.btnImprimirTicket.Location = new System.Drawing.Point(630, 40);
            this.btnImprimirTicket.Name = "btnImprimirTicket";
            this.btnImprimirTicket.Size = new System.Drawing.Size(120, 35);
            this.btnImprimirTicket.Text = "IMPRIMIR TICKET";
            this.btnImprimirTicket.Click += new System.EventHandler(this.btnImprimirTicket_Click);

            // btnFinalizarCompra
            this.btnFinalizarCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.btnFinalizarCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizarCompra.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnFinalizarCompra.ForeColor = System.Drawing.Color.White;
            this.btnFinalizarCompra.Location = new System.Drawing.Point(325, 520);
            this.btnFinalizarCompra.Name = "btnFinalizarCompra";
            this.btnFinalizarCompra.Size = new System.Drawing.Size(200, 45);
            this.btnFinalizarCompra.Text = "FINALIZAR COMPRA";
            this.btnFinalizarCompra.Click += new System.EventHandler(this.btnFinalizarCompra_Click);

            // lblTitulo
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(234, 30);
            this.lblTitulo.Text = "COMPRAS - CLIENTES";

            // Form
            this.ClientSize = new System.Drawing.Size(800, 580);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnFinalizarCompra);
            this.Controls.Add(this.panelTicket);
            this.Controls.Add(this.panelCarrito);
            this.Controls.Add(this.panelFormulario);
            this.Name = "frmClienteCompras";
            this.Text = "Sistema de Compras - Clientes";
            this.Load += new System.EventHandler(this.frmClienteCompras_Load);

            this.panelFormulario.ResumeLayout(false);
            this.panelFormulario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrito)).EndInit();
            this.panelCarrito.ResumeLayout(false);
            this.panelCarrito.PerformLayout();
            this.panelTicket.ResumeLayout(false);
            this.panelTicket.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}