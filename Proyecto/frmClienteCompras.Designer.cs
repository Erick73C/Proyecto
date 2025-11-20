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
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscarProducto = new System.Windows.Forms.TextBox();
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
            this.errBuscarProducto = new System.Windows.Forms.ErrorProvider(this.components);
            this.errCantidad = new System.Windows.Forms.ErrorProvider(this.components);
            this.errProducto = new System.Windows.Forms.ErrorProvider(this.components);
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.panelFormulario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrito)).BeginInit();
            this.panelCarrito.SuspendLayout();
            this.panelTicket.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errBuscarProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // panelFormulario
            // 
            this.panelFormulario.BackColor = System.Drawing.Color.White;
            this.panelFormulario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFormulario.Controls.Add(this.label1);
            this.panelFormulario.Controls.Add(this.txtBuscarProducto);
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
            this.panelFormulario.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(150, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Buscar Producto";
            // 
            // txtBuscarProducto
            // 
            this.txtBuscarProducto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtBuscarProducto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtBuscarProducto.Location = new System.Drawing.Point(143, 40);
            this.txtBuscarProducto.Name = "txtBuscarProducto";
            this.txtBuscarProducto.Size = new System.Drawing.Size(152, 20);
            this.txtBuscarProducto.TabIndex = 0;
            this.txtBuscarProducto.TextChanged += new System.EventHandler(this.txtBuscarProducto_TextChanged);
            // 
            // btnAgregarCarrito
            // 
            this.btnAgregarCarrito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnAgregarCarrito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarCarrito.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAgregarCarrito.ForeColor = System.Drawing.Color.White;
            this.btnAgregarCarrito.Location = new System.Drawing.Point(15, 190);
            this.btnAgregarCarrito.Name = "btnAgregarCarrito";
            this.btnAgregarCarrito.Size = new System.Drawing.Size(235, 35);
            this.btnAgregarCarrito.TabIndex = 3;
            this.btnAgregarCarrito.Text = "AGREGAR AL CARRITO";
            this.btnAgregarCarrito.UseVisualStyleBackColor = false;
            this.btnAgregarCarrito.Click += new System.EventHandler(this.btnAgregarCarrito_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(150, 145);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(65, 20);
            this.txtCantidad.TabIndex = 2;
            this.txtCantidad.Text = "1";
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCantidad.Location = new System.Drawing.Point(150, 125);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(75, 20);
            this.lblCantidad.TabIndex = 2;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // txtPrecioUnitario
            // 
            this.txtPrecioUnitario.Location = new System.Drawing.Point(150, 90);
            this.txtPrecioUnitario.Name = "txtPrecioUnitario";
            this.txtPrecioUnitario.Size = new System.Drawing.Size(100, 20);
            this.txtPrecioUnitario.TabIndex = 33;
            this.txtPrecioUnitario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioUnitario_KeyPress);
            // 
            // lblPrecioUnitario
            // 
            this.lblPrecioUnitario.AutoSize = true;
            this.lblPrecioUnitario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPrecioUnitario.Location = new System.Drawing.Point(150, 70);
            this.lblPrecioUnitario.Name = "lblPrecioUnitario";
            this.lblPrecioUnitario.Size = new System.Drawing.Size(117, 20);
            this.lblPrecioUnitario.TabIndex = 4;
            this.lblPrecioUnitario.Text = "Precio Unitario:";
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(15, 145);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(200, 20);
            this.txtNombreProducto.TabIndex = 34;
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.AutoSize = true;
            this.lblNombreProducto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblNombreProducto.Location = new System.Drawing.Point(15, 125);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(139, 20);
            this.lblNombreProducto.TabIndex = 6;
            this.lblNombreProducto.Text = "Nombre Producto:";
            // 
            // txtIdProducto
            // 
            this.txtIdProducto.Location = new System.Drawing.Point(15, 90);
            this.txtIdProducto.Name = "txtIdProducto";
            this.txtIdProducto.Size = new System.Drawing.Size(100, 20);
            this.txtIdProducto.TabIndex = 1;
            this.txtIdProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdProducto_KeyPress);
            // 
            // lblIdProducto
            // 
            this.lblIdProducto.AutoSize = true;
            this.lblIdProducto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblIdProducto.Location = new System.Drawing.Point(15, 70);
            this.lblIdProducto.Name = "lblIdProducto";
            this.lblIdProducto.Size = new System.Drawing.Size(97, 20);
            this.lblIdProducto.TabIndex = 8;
            this.lblIdProducto.Text = "ID Producto:";
            // 
            // txtIdUsuario
            // 
            this.txtIdUsuario.BackColor = System.Drawing.SystemColors.Control;
            this.txtIdUsuario.Location = new System.Drawing.Point(15, 35);
            this.txtIdUsuario.Name = "txtIdUsuario";
            this.txtIdUsuario.ReadOnly = true;
            this.txtIdUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtIdUsuario.TabIndex = 9;
            // 
            // lblIdUsuario
            // 
            this.lblIdUsuario.AutoSize = true;
            this.lblIdUsuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblIdUsuario.Location = new System.Drawing.Point(15, 15);
            this.lblIdUsuario.Name = "lblIdUsuario";
            this.lblIdUsuario.Size = new System.Drawing.Size(87, 20);
            this.lblIdUsuario.TabIndex = 10;
            this.lblIdUsuario.Text = "ID Usuario:";
            // 
            // dgvCarrito
            // 
            this.dgvCarrito.ColumnHeadersHeight = 29;
            this.dgvCarrito.Location = new System.Drawing.Point(15, 40);
            this.dgvCarrito.Name = "dgvCarrito";
            this.dgvCarrito.ReadOnly = true;
            this.dgvCarrito.RowHeadersWidth = 51;
            this.dgvCarrito.Size = new System.Drawing.Size(420, 150);
            this.dgvCarrito.TabIndex = 6;
            // 
            // panelCarrito
            // 
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
            this.panelCarrito.TabIndex = 3;
            // 
            // btnVaciarCarrito
            // 
            this.btnVaciarCarrito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnVaciarCarrito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVaciarCarrito.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnVaciarCarrito.ForeColor = System.Drawing.Color.White;
            this.btnVaciarCarrito.Location = new System.Drawing.Point(325, 200);
            this.btnVaciarCarrito.Name = "btnVaciarCarrito";
            this.btnVaciarCarrito.Size = new System.Drawing.Size(110, 35);
            this.btnVaciarCarrito.TabIndex = 0;
            this.btnVaciarCarrito.Text = "VACIAR CARRITO";
            this.btnVaciarCarrito.UseVisualStyleBackColor = false;
            this.btnVaciarCarrito.Click += new System.EventHandler(this.btnVaciarCarrito_Click);
            // 
            // btnEliminarItem
            // 
            this.btnEliminarItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnEliminarItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnEliminarItem.ForeColor = System.Drawing.Color.White;
            this.btnEliminarItem.Location = new System.Drawing.Point(200, 200);
            this.btnEliminarItem.Name = "btnEliminarItem";
            this.btnEliminarItem.Size = new System.Drawing.Size(110, 35);
            this.btnEliminarItem.TabIndex = 1;
            this.btnEliminarItem.Text = "ELIMINAR ITEM";
            this.btnEliminarItem.UseVisualStyleBackColor = false;
            this.btnEliminarItem.Click += new System.EventHandler(this.btnEliminarItem_Click);
            // 
            // txtTotalCompra
            // 
            this.txtTotalCompra.BackColor = System.Drawing.SystemColors.Control;
            this.txtTotalCompra.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.txtTotalCompra.ForeColor = System.Drawing.Color.Green;
            this.txtTotalCompra.Location = new System.Drawing.Point(60, 207);
            this.txtTotalCompra.Name = "txtTotalCompra";
            this.txtTotalCompra.ReadOnly = true;
            this.txtTotalCompra.Size = new System.Drawing.Size(100, 30);
            this.txtTotalCompra.TabIndex = 2;
            // 
            // lblTotalCompra
            // 
            this.lblTotalCompra.AutoSize = true;
            this.lblTotalCompra.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTotalCompra.Location = new System.Drawing.Point(15, 210);
            this.lblTotalCompra.Name = "lblTotalCompra";
            this.lblTotalCompra.Size = new System.Drawing.Size(48, 20);
            this.lblTotalCompra.TabIndex = 3;
            this.lblTotalCompra.Text = "Total:";
            // 
            // lblCantidadItems
            // 
            this.lblCantidadItems.AutoSize = true;
            this.lblCantidadItems.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblCantidadItems.Location = new System.Drawing.Point(100, 20);
            this.lblCantidadItems.Name = "lblCantidadItems";
            this.lblCantidadItems.Size = new System.Drawing.Size(136, 20);
            this.lblCantidadItems.TabIndex = 4;
            this.lblCantidadItems.Text = "0 items en el carrito";
            // 
            // lblCarrito
            // 
            this.lblCarrito.AutoSize = true;
            this.lblCarrito.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblCarrito.Location = new System.Drawing.Point(15, 15);
            this.lblCarrito.Name = "lblCarrito";
            this.lblCarrito.Size = new System.Drawing.Size(82, 28);
            this.lblCarrito.TabIndex = 5;
            this.lblCarrito.Text = "Carrito:";
            // 
            // panelTicket
            // 
            this.panelTicket.BackColor = System.Drawing.Color.White;
            this.panelTicket.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTicket.Controls.Add(this.btnImprimirTicket);
            this.panelTicket.Controls.Add(this.txtTicket);
            this.panelTicket.Controls.Add(this.lblTicket);
            this.panelTicket.Location = new System.Drawing.Point(12, 310);
            this.panelTicket.Name = "panelTicket";
            this.panelTicket.Size = new System.Drawing.Size(763, 200);
            this.panelTicket.TabIndex = 2;
            // 
            // btnImprimirTicket
            // 
            this.btnImprimirTicket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnImprimirTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimirTicket.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnImprimirTicket.ForeColor = System.Drawing.Color.White;
            this.btnImprimirTicket.Location = new System.Drawing.Point(630, 40);
            this.btnImprimirTicket.Name = "btnImprimirTicket";
            this.btnImprimirTicket.Size = new System.Drawing.Size(120, 35);
            this.btnImprimirTicket.TabIndex = 0;
            this.btnImprimirTicket.Text = "IMPRIMIR TICKET";
            this.btnImprimirTicket.UseVisualStyleBackColor = false;
            this.btnImprimirTicket.Click += new System.EventHandler(this.btnImprimirTicket_Click);
            // 
            // txtTicket
            // 
            this.txtTicket.Location = new System.Drawing.Point(15, 40);
            this.txtTicket.Multiline = true;
            this.txtTicket.Name = "txtTicket";
            this.txtTicket.ReadOnly = true;
            this.txtTicket.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTicket.Size = new System.Drawing.Size(600, 145);
            this.txtTicket.TabIndex = 1;
            // 
            // lblTicket
            // 
            this.lblTicket.AutoSize = true;
            this.lblTicket.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTicket.Location = new System.Drawing.Point(15, 15);
            this.lblTicket.Name = "lblTicket";
            this.lblTicket.Size = new System.Drawing.Size(75, 28);
            this.lblTicket.TabIndex = 2;
            this.lblTicket.Text = "Ticket:";
            // 
            // btnFinalizarCompra
            // 
            this.btnFinalizarCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.btnFinalizarCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizarCompra.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnFinalizarCompra.ForeColor = System.Drawing.Color.White;
            this.btnFinalizarCompra.Location = new System.Drawing.Point(325, 520);
            this.btnFinalizarCompra.Name = "btnFinalizarCompra";
            this.btnFinalizarCompra.Size = new System.Drawing.Size(200, 45);
            this.btnFinalizarCompra.TabIndex = 4;
            this.btnFinalizarCompra.Text = "FINALIZAR COMPRA";
            this.btnFinalizarCompra.UseVisualStyleBackColor = false;
            this.btnFinalizarCompra.Click += new System.EventHandler(this.btnFinalizarCompra_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(294, 37);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "COMPRAS - CLIENTES";
            // 
            // errBuscarProducto
            // 
            this.errBuscarProducto.ContainerControl = this;
            // 
            // errCantidad
            // 
            this.errCantidad.ContainerControl = this;
            // 
            // errProducto
            // 
            this.errProducto.ContainerControl = this;
            // 
            // dgvProductos
            // 
            this.dgvProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductos.BackgroundColor = System.Drawing.Color.White;
            this.dgvProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProductos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProductos.ColumnHeadersHeight = 40;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProductos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProductos.EnableHeadersVisualStyles = false;
            this.dgvProductos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dgvProductos.Location = new System.Drawing.Point(791, 45);
            this.dgvProductos.Margin = new System.Windows.Forms.Padding(2);
            this.dgvProductos.Name = "dgvProductos";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProductos.RowHeadersWidth = 30;
            this.dgvProductos.RowTemplate.Height = 35;
            this.dgvProductos.Size = new System.Drawing.Size(478, 465);
            this.dgvProductos.TabIndex = 14;
            this.dgvProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellContentClick);
            // 
            // frmClienteCompras
            // 
            this.ClientSize = new System.Drawing.Size(1293, 580);
            this.Controls.Add(this.dgvProductos);
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
            ((System.ComponentModel.ISupportInitialize)(this.errBuscarProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Label label1;
        private TextBox txtBuscarProducto;
        private ErrorProvider errBuscarProducto;
        private ErrorProvider errCantidad;
        private ErrorProvider errProducto;
        private DataGridView dgvProductos;
    }
}