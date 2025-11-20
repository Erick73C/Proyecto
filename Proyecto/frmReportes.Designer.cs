namespace Proyecto
{
    partial class frmReportes
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelFormulario = new System.Windows.Forms.Panel();
            this.cmbTipoReporte = new System.Windows.Forms.ComboBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblIdProducto = new System.Windows.Forms.Label();
            this.lblIdUsuario = new System.Windows.Forms.Label();
            this.lblIdReporte = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtIdProducto = new System.Windows.Forms.TextBox();
            this.txtIdUsuario = new System.Windows.Forms.TextBox();
            this.txtIdReporte = new System.Windows.Forms.TextBox();
            this.dgvReportes = new System.Windows.Forms.DataGridView();
            this.panelBotones = new System.Windows.Forms.Panel();
            this.btnMostrarTodos = new System.Windows.Forms.Button();
            this.btnBuscarPorTipo = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.errIdUsuario = new System.Windows.Forms.ErrorProvider(this.components);
            this.errIdProducto = new System.Windows.Forms.ErrorProvider(this.components);
            this.errCantidad = new System.Windows.Forms.ErrorProvider(this.components);
            this.errTotal = new System.Windows.Forms.ErrorProvider(this.components);
            this.errTipoReporte = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnBuscarporID = new System.Windows.Forms.Button();
            this.btnBuscarPorProducto = new System.Windows.Forms.Button();
            this.btnBucarPorReporte = new System.Windows.Forms.Button();
            this.panelFormulario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportes)).BeginInit();
            this.panelBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errIdUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errIdProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errTipoReporte)).BeginInit();
            this.SuspendLayout();
            // 
            // panelFormulario
            // 
            this.panelFormulario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelFormulario.BackColor = System.Drawing.Color.White;
            this.panelFormulario.Controls.Add(this.cmbTipoReporte);
            this.panelFormulario.Controls.Add(this.lblTotal);
            this.panelFormulario.Controls.Add(this.lblCantidad);
            this.panelFormulario.Controls.Add(this.lblIdProducto);
            this.panelFormulario.Controls.Add(this.lblIdUsuario);
            this.panelFormulario.Controls.Add(this.lblIdReporte);
            this.panelFormulario.Controls.Add(this.txtTotal);
            this.panelFormulario.Controls.Add(this.txtIdProducto);
            this.panelFormulario.Controls.Add(this.txtIdUsuario);
            this.panelFormulario.Controls.Add(this.txtIdReporte);
            this.panelFormulario.Location = new System.Drawing.Point(7, 52);
            this.panelFormulario.Margin = new System.Windows.Forms.Padding(2);
            this.panelFormulario.Name = "panelFormulario";
            this.panelFormulario.Size = new System.Drawing.Size(281, 293);
            this.panelFormulario.TabIndex = 12;
            // 
            // cmbTipoReporte
            // 
            this.cmbTipoReporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.cmbTipoReporte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoReporte.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbTipoReporte.FormattingEnabled = true;
            this.cmbTipoReporte.Location = new System.Drawing.Point(16, 179);
            this.cmbTipoReporte.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTipoReporte.Name = "cmbTipoReporte";
            this.cmbTipoReporte.Size = new System.Drawing.Size(196, 31);
            this.cmbTipoReporte.TabIndex = 3;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTotal.Location = new System.Drawing.Point(16, 211);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(48, 20);
            this.lblTotal.TabIndex = 12;
            this.lblTotal.Text = "Total:";
            this.lblTotal.Visible = false;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCantidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCantidad.Location = new System.Drawing.Point(16, 162);
            this.lblCantidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(44, 20);
            this.lblCantidad.TabIndex = 11;
            this.lblCantidad.Text = "Tipo:";
            // 
            // lblIdProducto
            // 
            this.lblIdProducto.AutoSize = true;
            this.lblIdProducto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblIdProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblIdProducto.Location = new System.Drawing.Point(16, 65);
            this.lblIdProducto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIdProducto.Name = "lblIdProducto";
            this.lblIdProducto.Size = new System.Drawing.Size(97, 20);
            this.lblIdProducto.TabIndex = 9;
            this.lblIdProducto.Text = "ID Producto:";
            // 
            // lblIdUsuario
            // 
            this.lblIdUsuario.AutoSize = true;
            this.lblIdUsuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblIdUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblIdUsuario.Location = new System.Drawing.Point(16, 16);
            this.lblIdUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIdUsuario.Name = "lblIdUsuario";
            this.lblIdUsuario.Size = new System.Drawing.Size(87, 20);
            this.lblIdUsuario.TabIndex = 8;
            this.lblIdUsuario.Text = "ID Usuario:";
            // 
            // lblIdReporte
            // 
            this.lblIdReporte.AutoSize = true;
            this.lblIdReporte.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblIdReporte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblIdReporte.Location = new System.Drawing.Point(16, 114);
            this.lblIdReporte.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIdReporte.Name = "lblIdReporte";
            this.lblIdReporte.Size = new System.Drawing.Size(89, 20);
            this.lblIdReporte.TabIndex = 7;
            this.lblIdReporte.Text = "ID Reporte:";
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotal.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTotal.Location = new System.Drawing.Point(16, 228);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(196, 30);
            this.txtTotal.TabIndex = 4;
            this.txtTotal.Visible = false;
            this.txtTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTotal_KeyPress);
            // 
            // txtIdProducto
            // 
            this.txtIdProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.txtIdProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdProducto.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtIdProducto.Location = new System.Drawing.Point(16, 81);
            this.txtIdProducto.Margin = new System.Windows.Forms.Padding(2);
            this.txtIdProducto.Name = "txtIdProducto";
            this.txtIdProducto.Size = new System.Drawing.Size(196, 30);
            this.txtIdProducto.TabIndex = 1;
            this.txtIdProducto.TextChanged += new System.EventHandler(this.txtIdProducto_TextChanged);
            this.txtIdProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdProducto_KeyPress);
            // 
            // txtIdUsuario
            // 
            this.txtIdUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.txtIdUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdUsuario.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtIdUsuario.Location = new System.Drawing.Point(16, 32);
            this.txtIdUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.txtIdUsuario.Name = "txtIdUsuario";
            this.txtIdUsuario.Size = new System.Drawing.Size(196, 30);
            this.txtIdUsuario.TabIndex = 0;
            this.txtIdUsuario.TextChanged += new System.EventHandler(this.txtIdUsuario_TextChanged);
            this.txtIdUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdUsuario_KeyPress);
            // 
            // txtIdReporte
            // 
            this.txtIdReporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.txtIdReporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdReporte.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtIdReporte.Location = new System.Drawing.Point(16, 130);
            this.txtIdReporte.Margin = new System.Windows.Forms.Padding(2);
            this.txtIdReporte.Name = "txtIdReporte";
            this.txtIdReporte.Size = new System.Drawing.Size(196, 30);
            this.txtIdReporte.TabIndex = 5;
            this.txtIdReporte.TextChanged += new System.EventHandler(this.txtIdReporte_TextChanged);
            this.txtIdReporte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdReporte_KeyPress);
            // 
            // dgvReportes
            // 
            this.dgvReportes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvReportes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReportes.BackgroundColor = System.Drawing.Color.White;
            this.dgvReportes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvReportes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvReportes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReportes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dgvReportes.ColumnHeadersHeight = 40;
            this.dgvReportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle20.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReportes.DefaultCellStyle = dataGridViewCellStyle20;
            this.dgvReportes.EnableHeadersVisualStyles = false;
            this.dgvReportes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dgvReportes.Location = new System.Drawing.Point(245, 52);
            this.dgvReportes.Margin = new System.Windows.Forms.Padding(2);
            this.dgvReportes.Name = "dgvReportes";
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle21.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReportes.RowHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.dgvReportes.RowHeadersWidth = 30;
            this.dgvReportes.RowTemplate.Height = 35;
            this.dgvReportes.Size = new System.Drawing.Size(561, 300);
            this.dgvReportes.TabIndex = 13;
            this.dgvReportes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReportes_CellClick);
            // 
            // panelBotones
            // 
            this.panelBotones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panelBotones.BackColor = System.Drawing.Color.Transparent;
            this.panelBotones.Controls.Add(this.btnBucarPorReporte);
            this.panelBotones.Controls.Add(this.btnBuscarPorProducto);
            this.panelBotones.Controls.Add(this.btnMostrarTodos);
            this.panelBotones.Controls.Add(this.btnBuscarporID);
            this.panelBotones.Controls.Add(this.btnBuscarPorTipo);
            this.panelBotones.Controls.Add(this.btnLimpiar);
            this.panelBotones.Controls.Add(this.btnEliminar);
            this.panelBotones.Controls.Add(this.btnGuardar);
            this.panelBotones.Location = new System.Drawing.Point(7, 366);
            this.panelBotones.Margin = new System.Windows.Forms.Padding(2);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Size = new System.Drawing.Size(717, 88);
            this.panelBotones.TabIndex = 14;
            // 
            // btnMostrarTodos
            // 
            this.btnMostrarTodos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnMostrarTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarTodos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnMostrarTodos.ForeColor = System.Drawing.Color.White;
            this.btnMostrarTodos.Location = new System.Drawing.Point(562, 2);
            this.btnMostrarTodos.Margin = new System.Windows.Forms.Padding(2);
            this.btnMostrarTodos.Name = "btnMostrarTodos";
            this.btnMostrarTodos.Size = new System.Drawing.Size(152, 37);
            this.btnMostrarTodos.TabIndex = 4;
            this.btnMostrarTodos.Text = "MOSTRAR TODOS";
            this.btnMostrarTodos.UseVisualStyleBackColor = false;
            this.btnMostrarTodos.Click += new System.EventHandler(this.btnMostrarTodos_Click);
            // 
            // btnBuscarPorTipo
            // 
            this.btnBuscarPorTipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.btnBuscarPorTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarPorTipo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnBuscarPorTipo.ForeColor = System.Drawing.Color.White;
            this.btnBuscarPorTipo.Location = new System.Drawing.Point(392, 2);
            this.btnBuscarPorTipo.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscarPorTipo.Name = "btnBuscarPorTipo";
            this.btnBuscarPorTipo.Size = new System.Drawing.Size(152, 37);
            this.btnBuscarPorTipo.TabIndex = 3;
            this.btnBuscarPorTipo.Text = "BUSCAR POR TIPO";
            this.btnBuscarPorTipo.UseVisualStyleBackColor = false;
            this.btnBuscarPorTipo.Click += new System.EventHandler(this.btnBuscarPorTipo_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(214, 2);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(142, 37);
            this.btnLimpiar.TabIndex = 1;
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(2, 2);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(159, 37);
            this.btnEliminar.TabIndex = 0;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(2, 2);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(159, 37);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTitulo.Location = new System.Drawing.Point(9, 7);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(269, 37);
            this.lblTitulo.TabIndex = 15;
            this.lblTitulo.Text = "GESTIÓN REPORTES";
            // 
            // errIdUsuario
            // 
            this.errIdUsuario.ContainerControl = this;
            // 
            // errIdProducto
            // 
            this.errIdProducto.ContainerControl = this;
            // 
            // errCantidad
            // 
            this.errCantidad.ContainerControl = this;
            // 
            // errTotal
            // 
            this.errTotal.ContainerControl = this;
            // 
            // errTipoReporte
            // 
            this.errTipoReporte.ContainerControl = this;
            // 
            // btnBuscarporID
            // 
            this.btnBuscarporID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnBuscarporID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarporID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnBuscarporID.ForeColor = System.Drawing.Color.White;
            this.btnBuscarporID.Location = new System.Drawing.Point(4, 51);
            this.btnBuscarporID.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscarporID.Name = "btnBuscarporID";
            this.btnBuscarporID.Size = new System.Drawing.Size(221, 37);
            this.btnBuscarporID.TabIndex = 5;
            this.btnBuscarporID.Text = "BUSCAR POR ID USUARIO";
            this.btnBuscarporID.UseVisualStyleBackColor = false;
            this.btnBuscarporID.Click += new System.EventHandler(this.btnBuscarporID_Click);
            // 
            // btnBuscarPorProducto
            // 
            this.btnBuscarPorProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnBuscarPorProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarPorProducto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnBuscarPorProducto.ForeColor = System.Drawing.Color.White;
            this.btnBuscarPorProducto.Location = new System.Drawing.Point(263, 51);
            this.btnBuscarPorProducto.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscarPorProducto.Name = "btnBuscarPorProducto";
            this.btnBuscarPorProducto.Size = new System.Drawing.Size(216, 37);
            this.btnBuscarPorProducto.TabIndex = 16;
            this.btnBuscarPorProducto.Text = "BUSCAR POR ID PRODUCTO";
            this.btnBuscarPorProducto.UseVisualStyleBackColor = false;
            this.btnBuscarPorProducto.Click += new System.EventHandler(this.btnBuscarPorProducto_Click);
            // 
            // btnBucarPorReporte
            // 
            this.btnBucarPorReporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnBucarPorReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBucarPorReporte.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnBucarPorReporte.ForeColor = System.Drawing.Color.White;
            this.btnBucarPorReporte.Location = new System.Drawing.Point(498, 51);
            this.btnBucarPorReporte.Margin = new System.Windows.Forms.Padding(2);
            this.btnBucarPorReporte.Name = "btnBucarPorReporte";
            this.btnBucarPorReporte.Size = new System.Drawing.Size(216, 37);
            this.btnBucarPorReporte.TabIndex = 17;
            this.btnBucarPorReporte.Text = "BUSCAR POR ID REPORTE";
            this.btnBucarPorReporte.UseVisualStyleBackColor = false;
            this.btnBucarPorReporte.Click += new System.EventHandler(this.btnBucarPorReporte_Click);
            // 
            // frmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 465);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.panelBotones);
            this.Controls.Add(this.dgvReportes);
            this.Controls.Add(this.panelFormulario);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmReportes";
            this.Text = "Gestión de Reportes";
            this.Load += new System.EventHandler(this.frmReportes_Load);
            this.panelFormulario.ResumeLayout(false);
            this.panelFormulario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportes)).EndInit();
            this.panelBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errIdUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errIdProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errTipoReporte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelFormulario;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblIdProducto;
        private System.Windows.Forms.Label lblIdUsuario;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtIdProducto;
        private System.Windows.Forms.TextBox txtIdUsuario;
        private System.Windows.Forms.DataGridView dgvReportes;
        private System.Windows.Forms.Panel panelBotones;
        private System.Windows.Forms.Button btnMostrarTodos;
        private System.Windows.Forms.Button btnBuscarPorTipo;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ErrorProvider errIdUsuario;
        private System.Windows.Forms.ErrorProvider errIdProducto;
        private System.Windows.Forms.ErrorProvider errCantidad;
        private System.Windows.Forms.ErrorProvider errTotal;
        private System.Windows.Forms.ErrorProvider errTipoReporte;
        private System.Windows.Forms.ComboBox cmbTipoReporte;
        private System.Windows.Forms.Label lblIdReporte;
        private System.Windows.Forms.TextBox txtIdReporte;
        private System.Windows.Forms.Button btnBuscarporID;
        private System.Windows.Forms.Button btnBuscarPorProducto;
        private System.Windows.Forms.Button btnBucarPorReporte;
    }
}