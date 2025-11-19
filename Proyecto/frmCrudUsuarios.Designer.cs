namespace Proyecto
{
    partial class frmCrudUsuarios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelBotones = new System.Windows.Forms.Panel();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.panelFormulario = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.cbxRol = new System.Windows.Forms.ComboBox();
            this.txtcontrasenia = new System.Windows.Forms.TextBox();
            this.txtApellidoMaterno = new System.Windows.Forms.TextBox();
            this.txtApellidoPaterno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFechaRegistro = new System.Windows.Forms.DateTimePicker();
            this.lblMaterno = new System.Windows.Forms.Label();
            this.lblPaterno = new System.Windows.Forms.Label();
            this.lblRol = new System.Windows.Forms.Label();
            this.lblContrasena = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.lblIdUsuario = new System.Windows.Forms.Label();
            this.txtIdUsuario = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.errNombre = new System.Windows.Forms.ErrorProvider(this.components);
            this.errApellidoPaterno = new System.Windows.Forms.ErrorProvider(this.components);
            this.errApellidoMaterno = new System.Windows.Forms.ErrorProvider(this.components);
            this.errCorreo = new System.Windows.Forms.ErrorProvider(this.components);
            this.errUsuario = new System.Windows.Forms.ErrorProvider(this.components);
            this.errContrasena = new System.Windows.Forms.ErrorProvider(this.components);
            this.errRol = new System.Windows.Forms.ErrorProvider(this.components);
            this.erroNombreUsuario = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.panelFormulario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errApellidoPaterno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errApellidoMaterno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errCorreo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errContrasena)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errRol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erroNombreUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTitulo.Location = new System.Drawing.Point(11, 28);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(222, 30);
            this.lblTitulo.TabIndex = 19;
            this.lblTitulo.Text = "GESTIÓN USUARIOS";
            // 
            // panelBotones
            // 
            this.panelBotones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panelBotones.BackColor = System.Drawing.Color.Transparent;
            this.panelBotones.Controls.Add(this.btnNuevo);
            this.panelBotones.Controls.Add(this.btnGuardar);
            this.panelBotones.Controls.Add(this.btnEliminar);
            this.panelBotones.Controls.Add(this.btnEditar);
            this.panelBotones.Location = new System.Drawing.Point(106, 575);
            this.panelBotones.Margin = new System.Windows.Forms.Padding(2);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Size = new System.Drawing.Size(718, 42);
            this.panelBotones.TabIndex = 18;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.Location = new System.Drawing.Point(8, 3);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(2);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(159, 37);
            this.btnNuevo.TabIndex = 11;
            this.btnNuevo.Text = "NUEVO";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(212, 3);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(142, 37);
            this.btnGuardar.TabIndex = 12;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(560, 3);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(152, 37);
            this.btnEliminar.TabIndex = 14;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(391, 3);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(134, 37);
            this.btnEditar.TabIndex = 13;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsuarios.BackgroundColor = System.Drawing.Color.White;
            this.dgvUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUsuarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvUsuarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUsuarios.ColumnHeadersHeight = 40;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUsuarios.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUsuarios.EnableHeadersVisualStyles = false;
            this.dgvUsuarios.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dgvUsuarios.Location = new System.Drawing.Point(248, 72);
            this.dgvUsuarios.Margin = new System.Windows.Forms.Padding(2);
            this.dgvUsuarios.Name = "dgvUsuarios";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsuarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvUsuarios.RowHeadersWidth = 30;
            this.dgvUsuarios.RowTemplate.Height = 35;
            this.dgvUsuarios.Size = new System.Drawing.Size(653, 489);
            this.dgvUsuarios.TabIndex = 17;
            this.dgvUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellClick);
            this.dgvUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellContentClick);
            this.dgvUsuarios.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellDoubleClick);
            this.dgvUsuarios.DoubleClick += new System.EventHandler(this.dgvUsuarios_DoubleClick);
            // 
            // panelFormulario
            // 
            this.panelFormulario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelFormulario.BackColor = System.Drawing.Color.White;
            this.panelFormulario.Controls.Add(this.label2);
            this.panelFormulario.Controls.Add(this.txtUsuario);
            this.panelFormulario.Controls.Add(this.cbxRol);
            this.panelFormulario.Controls.Add(this.txtcontrasenia);
            this.panelFormulario.Controls.Add(this.txtApellidoMaterno);
            this.panelFormulario.Controls.Add(this.txtApellidoPaterno);
            this.panelFormulario.Controls.Add(this.label1);
            this.panelFormulario.Controls.Add(this.dtpFechaRegistro);
            this.panelFormulario.Controls.Add(this.lblMaterno);
            this.panelFormulario.Controls.Add(this.lblPaterno);
            this.panelFormulario.Controls.Add(this.lblRol);
            this.panelFormulario.Controls.Add(this.lblContrasena);
            this.panelFormulario.Controls.Add(this.lblCorreo);
            this.panelFormulario.Controls.Add(this.lblNombreUsuario);
            this.panelFormulario.Controls.Add(this.lblIdUsuario);
            this.panelFormulario.Controls.Add(this.txtIdUsuario);
            this.panelFormulario.Controls.Add(this.txtNombre);
            this.panelFormulario.Controls.Add(this.txtCorreo);
            this.panelFormulario.Location = new System.Drawing.Point(9, 72);
            this.panelFormulario.Margin = new System.Windows.Forms.Padding(2);
            this.panelFormulario.Name = "panelFormulario";
            this.panelFormulario.Size = new System.Drawing.Size(225, 489);
            this.panelFormulario.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(16, 365);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 15);
            this.label2.TabIndex = 27;
            this.label2.Text = "Nombre de Usuario";
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsuario.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtUsuario.Location = new System.Drawing.Point(16, 381);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(196, 25);
            this.txtUsuario.TabIndex = 9;
            this.txtUsuario.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
            // 
            // cbxRol
            // 
            this.cbxRol.FormattingEnabled = true;
            this.cbxRol.Location = new System.Drawing.Point(16, 341);
            this.cbxRol.Name = "cbxRol";
            this.cbxRol.Size = new System.Drawing.Size(196, 21);
            this.cbxRol.TabIndex = 8;
            this.cbxRol.SelectedIndexChanged += new System.EventHandler(this.cbxRol_SelectedIndexChanged);
            // 
            // txtcontrasenia
            // 
            this.txtcontrasenia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.txtcontrasenia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcontrasenia.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtcontrasenia.Location = new System.Drawing.Point(16, 288);
            this.txtcontrasenia.Margin = new System.Windows.Forms.Padding(2);
            this.txtcontrasenia.Name = "txtcontrasenia";
            this.txtcontrasenia.Size = new System.Drawing.Size(196, 25);
            this.txtcontrasenia.TabIndex = 7;
            this.txtcontrasenia.TextChanged += new System.EventHandler(this.txtcontrasenia_TextChanged);
            // 
            // txtApellidoMaterno
            // 
            this.txtApellidoMaterno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.txtApellidoMaterno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtApellidoMaterno.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtApellidoMaterno.Location = new System.Drawing.Point(16, 189);
            this.txtApellidoMaterno.Margin = new System.Windows.Forms.Padding(2);
            this.txtApellidoMaterno.Name = "txtApellidoMaterno";
            this.txtApellidoMaterno.Size = new System.Drawing.Size(196, 25);
            this.txtApellidoMaterno.TabIndex = 5;
            this.txtApellidoMaterno.TextChanged += new System.EventHandler(this.txtApellidoMaterno_TextChanged);
            // 
            // txtApellidoPaterno
            // 
            this.txtApellidoPaterno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.txtApellidoPaterno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtApellidoPaterno.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtApellidoPaterno.Location = new System.Drawing.Point(16, 128);
            this.txtApellidoPaterno.Margin = new System.Windows.Forms.Padding(2);
            this.txtApellidoPaterno.Name = "txtApellidoPaterno";
            this.txtApellidoPaterno.Size = new System.Drawing.Size(196, 25);
            this.txtApellidoPaterno.TabIndex = 4;
            this.txtApellidoPaterno.TextChanged += new System.EventHandler(this.txtApellidoPaterno_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(16, 408);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 15);
            this.label1.TabIndex = 21;
            this.label1.Text = "Fecha de registro:";
            // 
            // dtpFechaRegistro
            // 
            this.dtpFechaRegistro.Location = new System.Drawing.Point(16, 426);
            this.dtpFechaRegistro.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFechaRegistro.Name = "dtpFechaRegistro";
            this.dtpFechaRegistro.Size = new System.Drawing.Size(196, 20);
            this.dtpFechaRegistro.TabIndex = 10;
            // 
            // lblMaterno
            // 
            this.lblMaterno.AutoSize = true;
            this.lblMaterno.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblMaterno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblMaterno.Location = new System.Drawing.Point(16, 165);
            this.lblMaterno.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaterno.Name = "lblMaterno";
            this.lblMaterno.Size = new System.Drawing.Size(106, 15);
            this.lblMaterno.TabIndex = 16;
            this.lblMaterno.Text = "Apellido Materno:";
            // 
            // lblPaterno
            // 
            this.lblPaterno.AutoSize = true;
            this.lblPaterno.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPaterno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPaterno.Location = new System.Drawing.Point(16, 111);
            this.lblPaterno.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPaterno.Name = "lblPaterno";
            this.lblPaterno.Size = new System.Drawing.Size(102, 15);
            this.lblPaterno.TabIndex = 14;
            this.lblPaterno.Text = "Apellido paterno:";
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblRol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblRol.Location = new System.Drawing.Point(16, 315);
            this.lblRol.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(28, 15);
            this.lblRol.TabIndex = 12;
            this.lblRol.Text = "Rol:";
            // 
            // lblContrasena
            // 
            this.lblContrasena.AutoSize = true;
            this.lblContrasena.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblContrasena.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblContrasena.Location = new System.Drawing.Point(16, 266);
            this.lblContrasena.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblContrasena.Name = "lblContrasena";
            this.lblContrasena.Size = new System.Drawing.Size(72, 15);
            this.lblContrasena.TabIndex = 11;
            this.lblContrasena.Text = "Contraseña:";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCorreo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCorreo.Location = new System.Drawing.Point(16, 216);
            this.lblCorreo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(48, 15);
            this.lblCorreo.TabIndex = 10;
            this.lblCorreo.Text = "Correo:";
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblNombreUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblNombreUsuario.Location = new System.Drawing.Point(16, 65);
            this.lblNombreUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(56, 15);
            this.lblNombreUsuario.TabIndex = 9;
            this.lblNombreUsuario.Text = "Nombre:";
            // 
            // lblIdUsuario
            // 
            this.lblIdUsuario.AutoSize = true;
            this.lblIdUsuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblIdUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblIdUsuario.Location = new System.Drawing.Point(16, 16);
            this.lblIdUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIdUsuario.Name = "lblIdUsuario";
            this.lblIdUsuario.Size = new System.Drawing.Size(68, 15);
            this.lblIdUsuario.TabIndex = 8;
            this.lblIdUsuario.Text = "ID Usuario:";
            // 
            // txtIdUsuario
            // 
            this.txtIdUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.txtIdUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdUsuario.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtIdUsuario.Location = new System.Drawing.Point(16, 32);
            this.txtIdUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.txtIdUsuario.Name = "txtIdUsuario";
            this.txtIdUsuario.ReadOnly = true;
            this.txtIdUsuario.Size = new System.Drawing.Size(196, 25);
            this.txtIdUsuario.TabIndex = 2;
            this.txtIdUsuario.TextChanged += new System.EventHandler(this.txtIdUsuario_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNombre.Location = new System.Drawing.Point(16, 81);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(196, 25);
            this.txtNombre.TabIndex = 3;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // txtCorreo
            // 
            this.txtCorreo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.txtCorreo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCorreo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtCorreo.Location = new System.Drawing.Point(16, 232);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(2);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(196, 25);
            this.txtCorreo.TabIndex = 6;
            this.txtCorreo.TextChanged += new System.EventHandler(this.txtCorreo_TextChanged);
            // 
            // errNombre
            // 
            this.errNombre.ContainerControl = this;
            // 
            // errApellidoPaterno
            // 
            this.errApellidoPaterno.ContainerControl = this;
            // 
            // errApellidoMaterno
            // 
            this.errApellidoMaterno.ContainerControl = this;
            // 
            // errCorreo
            // 
            this.errCorreo.ContainerControl = this;
            // 
            // errUsuario
            // 
            this.errUsuario.ContainerControl = this;
            // 
            // errContrasena
            // 
            this.errContrasena.ContainerControl = this;
            // 
            // errRol
            // 
            this.errRol.ContainerControl = this;
            // 
            // erroNombreUsuario
            // 
            this.erroNombreUsuario.ContainerControl = this;
            // 
            // frmCrudUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 634);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.panelBotones);
            this.Controls.Add(this.dgvUsuarios);
            this.Controls.Add(this.panelFormulario);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmCrudUsuarios";
            this.Text = "frmCrudUsuarios";
            this.Load += new System.EventHandler(this.frmCrudUsuarios_Load);
            this.panelBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.panelFormulario.ResumeLayout(false);
            this.panelFormulario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errApellidoPaterno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errApellidoMaterno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errCorreo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errContrasena)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errRol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erroNombreUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panelBotones;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.Panel panelFormulario;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.Label lblContrasena;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.Label lblIdUsuario;
        private System.Windows.Forms.TextBox txtIdUsuario;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label lblMaterno;
        private System.Windows.Forms.Label lblPaterno;
        private System.Windows.Forms.DateTimePicker dtpFechaRegistro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtApellidoMaterno;
        private System.Windows.Forms.TextBox txtApellidoPaterno;
        private System.Windows.Forms.TextBox txtcontrasenia;
        private System.Windows.Forms.ComboBox cbxRol;
        private System.Windows.Forms.ErrorProvider errNombre;
        private System.Windows.Forms.ErrorProvider errApellidoPaterno;
        private System.Windows.Forms.ErrorProvider errApellidoMaterno;
        private System.Windows.Forms.ErrorProvider errCorreo;
        private System.Windows.Forms.ErrorProvider errUsuario;
        private System.Windows.Forms.ErrorProvider errContrasena;
        private System.Windows.Forms.ErrorProvider errRol;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.ErrorProvider erroNombreUsuario;
    }
}