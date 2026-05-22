namespace PVD_DISFRACES_ALEJANDRIA.Forms
{
    partial class FrmMenuAdmin
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            panelMenu = new Panel();
            btnCerrarSesion = new Button();
            btnAuditoria = new Button();
            btnReportes = new Button();
            btnPedidoTraje = new Button();
            btnVentas = new Button();
            btnEmpleados = new Button();
            btnUsuarios = new Button();
            btnProductos = new Button();
            lblTitulo = new Label();
            panelContenido = new Panel();
            lblSubtitulo = new Label();
            lblBienvenida = new Label();
            panelMenu.SuspendLayout();
            panelContenido.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(30, 30, 30);
            panelMenu.Controls.Add(btnAuditoria);
            panelMenu.Controls.Add(btnUsuarios);
            panelMenu.Controls.Add(btnReportes);
            panelMenu.Controls.Add(btnPedidoTraje);
            panelMenu.Controls.Add(btnVentas);
            panelMenu.Controls.Add(btnEmpleados);
            panelMenu.Controls.Add(btnProductos);
            panelMenu.Controls.Add(lblTitulo);
            panelMenu.Controls.Add(btnCerrarSesion);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(260, 700);
            panelMenu.TabIndex = 1;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.BackColor = Color.FromArgb(70, 70, 70);
            btnCerrarSesion.Dock = DockStyle.Bottom;
            btnCerrarSesion.FlatAppearance.BorderSize = 0;
            btnCerrarSesion.FlatStyle = FlatStyle.Flat;
            btnCerrarSesion.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnCerrarSesion.ForeColor = Color.White;
            btnCerrarSesion.Location = new Point(0, 645);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(260, 55);
            btnCerrarSesion.TabIndex = 7;
            btnCerrarSesion.Text = "   ⬅  Cerrar Sesión";
            btnCerrarSesion.UseVisualStyleBackColor = false;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.Dock = DockStyle.Top;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(260, 100);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "🎭 Admin";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnProductos
            // 
            btnProductos.BackColor = Color.FromArgb(50, 50, 50);
            btnProductos.Dock = DockStyle.Top;
            btnProductos.FlatAppearance.BorderSize = 0;
            btnProductos.FlatStyle = FlatStyle.Flat;
            btnProductos.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnProductos.ForeColor = Color.White;
            btnProductos.Location = new Point(0, 100);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(260, 55);
            btnProductos.TabIndex = 1;
            btnProductos.Text = "   📦  Productos";
            btnProductos.UseVisualStyleBackColor = false;
            btnProductos.Click += btnProductos_Click;
            // 
            // btnEmpleados
            // 
            btnEmpleados.BackColor = Color.FromArgb(50, 50, 50);
            btnEmpleados.Dock = DockStyle.Top;
            btnEmpleados.FlatAppearance.BorderSize = 0;
            btnEmpleados.FlatStyle = FlatStyle.Flat;
            btnEmpleados.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnEmpleados.ForeColor = Color.White;
            btnEmpleados.Location = new Point(0, 155);
            btnEmpleados.Name = "btnEmpleados";
            btnEmpleados.Size = new Size(260, 55);
            btnEmpleados.TabIndex = 2;
            btnEmpleados.Text = "   👥  Empleados";
            btnEmpleados.UseVisualStyleBackColor = false;
            btnEmpleados.Click += btnEmpleados_Click;
            // 
            // btnVentas
            // 
            btnVentas.BackColor = Color.FromArgb(50, 50, 50);
            btnVentas.Dock = DockStyle.Top;
            btnVentas.FlatAppearance.BorderSize = 0;
            btnVentas.FlatStyle = FlatStyle.Flat;
            btnVentas.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnVentas.ForeColor = Color.White;
            btnVentas.Location = new Point(0, 210);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(260, 55);
            btnVentas.TabIndex = 3;
            btnVentas.Text = "   💰  Ventas";
            btnVentas.UseVisualStyleBackColor = false;
            btnVentas.Click += btnVentas_Click;
            // 
            // btnPedidoTraje
            // 
            btnPedidoTraje.BackColor = Color.FromArgb(50, 50, 50);
            btnPedidoTraje.Dock = DockStyle.Top;
            btnPedidoTraje.FlatAppearance.BorderSize = 0;
            btnPedidoTraje.FlatStyle = FlatStyle.Flat;
            btnPedidoTraje.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnPedidoTraje.ForeColor = Color.White;
            btnPedidoTraje.Location = new Point(0, 265);
            btnPedidoTraje.Name = "btnPedidoTraje";
            btnPedidoTraje.Size = new Size(260, 55);
            btnPedidoTraje.TabIndex = 4;
            btnPedidoTraje.Text = "   🎭  Pedido Traje";
            btnPedidoTraje.UseVisualStyleBackColor = false;
            // 
            // btnReportes
            // 
            btnReportes.BackColor = Color.FromArgb(50, 50, 50);
            btnReportes.Dock = DockStyle.Top;
            btnReportes.FlatAppearance.BorderSize = 0;
            btnReportes.FlatStyle = FlatStyle.Flat;
            btnReportes.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnReportes.ForeColor = Color.White;
            btnReportes.Location = new Point(0, 320);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(260, 55);
            btnReportes.TabIndex = 5;
            btnReportes.Text = "   📊  Reportes";
            btnReportes.UseVisualStyleBackColor = false;
            btnReportes.Click += btnReportes_Click;
            // 
            // btnAuditoria
            // 
            btnAuditoria.BackColor = Color.FromArgb(50, 50, 50);
            btnAuditoria.Dock = DockStyle.Top;
            btnAuditoria.FlatAppearance.BorderSize = 0;
            btnAuditoria.FlatStyle = FlatStyle.Flat;
            btnAuditoria.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnAuditoria.ForeColor = Color.White;
            btnAuditoria.Location = new Point(0, 375);
            btnAuditoria.Name = "btnAuditoria";
            btnAuditoria.Size = new Size(260, 55);
            btnAuditoria.TabIndex = 6;
            btnAuditoria.Text = "   🔍  Auditoria";
            btnAuditoria.UseVisualStyleBackColor = false;
            btnAuditoria.Click += btnAuditoria_Click;
            // 
            // btnUsuarios  ← CORREGIDO
            // 
            btnUsuarios.BackColor = Color.FromArgb(50, 50, 50);
            btnUsuarios.Dock = DockStyle.Top;
            btnUsuarios.FlatAppearance.BorderSize = 0;
            btnUsuarios.FlatStyle = FlatStyle.Flat;
            btnUsuarios.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnUsuarios.ForeColor = Color.White;
            btnUsuarios.Location = new Point(0, 430);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(260, 55);
            btnUsuarios.TabIndex = 8;
            btnUsuarios.Text = "   👤  Usuarios";
            btnUsuarios.UseVisualStyleBackColor = false;
            btnUsuarios.Click += btnUsuarios_Click_1;
            // 
            // panelContenido
            // 
            panelContenido.BackColor = Color.WhiteSmoke;
            panelContenido.Controls.Add(lblSubtitulo);
            panelContenido.Controls.Add(lblBienvenida);
            panelContenido.Dock = DockStyle.Fill;
            panelContenido.Location = new Point(260, 0);
            panelContenido.Name = "panelContenido";
            panelContenido.Size = new Size(940, 700);
            panelContenido.TabIndex = 0;
            // 
            // lblBienvenida
            // 
            lblBienvenida.AutoSize = true;
            lblBienvenida.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblBienvenida.ForeColor = Color.FromArgb(40, 40, 40);
            lblBienvenida.Location = new Point(160, 270);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(635, 46);
            lblBienvenida.TabIndex = 1;
            lblBienvenida.Text = "Bienvenido al Panel de Administración";
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Segoe UI", 13F);
            lblSubtitulo.ForeColor = Color.FromArgb(120, 120, 120);
            lblSubtitulo.Location = new Point(270, 325);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(390, 30);
            lblSubtitulo.TabIndex = 2;
            lblSubtitulo.Text = "Selecciona una opción del menú lateral";
            // 
            // FrmMenuAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1200, 700);
            Controls.Add(panelContenido);
            Controls.Add(panelMenu);
            MinimumSize = new Size(900, 600);
            Name = "FrmMenuAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menú Administrador - Disfraces Alejandría";
            Load += FrmMenuAdmin_Load;
            panelMenu.ResumeLayout(false);
            panelContenido.ResumeLayout(false);
            panelContenido.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Label lblTitulo;
        private Button btnProductos;
        private Button btnEmpleados;
        private Button btnVentas;
        private Button btnPedidoTraje;
        private Button btnReportes;
        private Button btnAuditoria;
        private Button btnUsuarios;
        private Button btnCerrarSesion;
        private Panel panelContenido;
        private Label lblBienvenida;
        private Label lblSubtitulo;
    }
}