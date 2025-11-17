namespace Proyecto
{
    partial class frmMenu
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
            this.btnCrud1 = new System.Windows.Forms.Button();
            this.btnCrud2 = new System.Windows.Forms.Button();
            this.btnCrud3 = new System.Windows.Forms.Button();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.lblTituloMenu = new System.Windows.Forms.Label();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.pnlMenu.SuspendLayout();
            this.pnlContenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCrud1
            // 
            this.btnCrud1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnCrud1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrud1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCrud1.ForeColor = System.Drawing.Color.White;
            this.btnCrud1.Location = new System.Drawing.Point(10, 100);
            this.btnCrud1.Margin = new System.Windows.Forms.Padding(4);
            this.btnCrud1.Name = "btnCrud1";
            this.btnCrud1.Size = new System.Drawing.Size(180, 45);
            this.btnCrud1.TabIndex = 0;
            this.btnCrud1.Text = "Gestión Usuarios";
            this.btnCrud1.UseVisualStyleBackColor = false;
            this.btnCrud1.Click += new System.EventHandler(this.btnCrud1_Click);
            this.btnCrud1.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.btnCrud1.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // btnCrud2
            // 
            this.btnCrud2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnCrud2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrud2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCrud2.ForeColor = System.Drawing.Color.White;
            this.btnCrud2.Location = new System.Drawing.Point(10, 160);
            this.btnCrud2.Margin = new System.Windows.Forms.Padding(4);
            this.btnCrud2.Name = "btnCrud2";
            this.btnCrud2.Size = new System.Drawing.Size(180, 45);
            this.btnCrud2.TabIndex = 1;
            this.btnCrud2.Text = "Gestión Productos";
            this.btnCrud2.UseVisualStyleBackColor = false;
            this.btnCrud2.Click += new System.EventHandler(this.btnCrud2_Click);
            this.btnCrud2.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.btnCrud2.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // btnCrud3
            // 
            this.btnCrud3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnCrud3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrud3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCrud3.ForeColor = System.Drawing.Color.White;
            this.btnCrud3.Location = new System.Drawing.Point(10, 220);
            this.btnCrud3.Margin = new System.Windows.Forms.Padding(4);
            this.btnCrud3.Name = "btnCrud3";
            this.btnCrud3.Size = new System.Drawing.Size(180, 45);
            this.btnCrud3.TabIndex = 2;
            this.btnCrud3.Text = "Gestión Ventas";
            this.btnCrud3.UseVisualStyleBackColor = false;
            this.btnCrud3.Click += new System.EventHandler(this.btnCrud3_Click);
            this.btnCrud3.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.btnCrud3.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.pnlMenu.Controls.Add(this.btnCerrarSesion);
            this.pnlMenu.Controls.Add(this.lblTituloMenu);
            this.pnlMenu.Controls.Add(this.btnCrud1);
            this.pnlMenu.Controls.Add(this.btnCrud3);
            this.pnlMenu.Controls.Add(this.btnCrud2);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(194, 611);
            this.pnlMenu.TabIndex = 3;
            this.pnlMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMenu_Paint);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.White;
            this.btnCerrarSesion.Location = new System.Drawing.Point(10, 550);
            this.btnCerrarSesion.Margin = new System.Windows.Forms.Padding(4);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(180, 40);
            this.btnCerrarSesion.TabIndex = 4;
            this.btnCerrarSesion.Text = "Cerrar Sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            this.btnCerrarSesion.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.btnCerrarSesion.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // lblTituloMenu
            // 
            this.lblTituloMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTituloMenu.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTituloMenu.ForeColor = System.Drawing.Color.White;
            this.lblTituloMenu.Location = new System.Drawing.Point(0, 0);
            this.lblTituloMenu.Name = "lblTituloMenu";
            this.lblTituloMenu.Size = new System.Drawing.Size(194, 80);
            this.lblTituloMenu.TabIndex = 3;
            this.lblTituloMenu.Text = "SISTEMA";
            this.lblTituloMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.pnlContenedor.Controls.Add(this.lblNombreUsuario);
            this.pnlContenedor.Controls.Add(this.lblBienvenida);
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedor.Location = new System.Drawing.Point(194, 0);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(1029, 611);
            this.pnlContenedor.TabIndex = 5;
            this.pnlContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlContenedor_Paint_1);
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBienvenida.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblBienvenida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblBienvenida.Location = new System.Drawing.Point(3, 160);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(1023, 100);
            this.lblBienvenida.TabIndex = 0;
            this.lblBienvenida.Text = "BIENVENIDO AL SISTEMA";
            this.lblBienvenida.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblNombreUsuario.Location = new System.Drawing.Point(3, 255);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(1023, 100);
            this.lblNombreUsuario.TabIndex = 1;
            this.lblNombreUsuario.Text = "CARGANDO NOMBRE.....";
            this.lblNombreUsuario.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblNombreUsuario.Click += new System.EventHandler(this.lblNombreUsuario_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1223, 611);
            this.Controls.Add(this.pnlContenedor);
            this.Controls.Add(this.pnlMenu);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.pnlMenu.ResumeLayout(false);
            this.pnlContenedor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCrud1;
        private System.Windows.Forms.Button btnCrud2;
        private System.Windows.Forms.Button btnCrud3;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Label lblTituloMenu;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Panel pnlContenedor;
        private System.Windows.Forms.Label lblBienvenida;
        private System.Windows.Forms.Label lblNombreUsuario;
    }
}