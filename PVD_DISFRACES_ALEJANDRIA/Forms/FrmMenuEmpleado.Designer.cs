namespace PVD_DISFRACES_ALEJANDRIA.Forms
{
    partial class FrmMenuEmpleado
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
            lblTitulo = new Label();
            btnVentas = new Button();
            btnReportes = new Button();
            btnInventarioEmpleado = new Button();
            btnCerrarSesion = new Button();
            panelContenido = new Panel();
            lblBienvenida = new Label();
            lblSubtitulo = new Label();
            panelMenu.SuspendLayout();
            panelContenido.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(30, 30, 30);
            panelMenu.Controls.Add(btnInventarioEmpleado);
            panelMenu.Controls.Add(btnReportes);
            panelMenu.Controls.Add(btnVentas);
            panelMenu.Controls.Add(lblTitulo);
            panelMenu.Controls.Add(btnCerrarSesion);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(260, 700);
            panelMenu.TabIndex = 1;
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
            lblTitulo.Text = "🧑‍💼 Empleado";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnVentas
            // 
            btnVentas.BackColor = Color.FromArgb(50, 50, 50);
            btnVentas.Dock = DockStyle.Top;
            btnVentas.FlatAppearance.BorderSize = 0;
            btnVentas.FlatStyle = FlatStyle.Flat;
            btnVentas.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnVentas.ForeColor = Color.White;
            btnVentas.Location = new Point(0, 100);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(260, 55);
            btnVentas.TabIndex = 1;
            btnVentas.Text = "   💵  Ventas";
            btnVentas.UseVisualStyleBackColor = false;
            btnVentas.Click += btnVentas_Click;
            // 
            // btnReportes
            // 
            btnReportes.BackColor = Color.FromArgb(50, 50, 50);
            btnReportes.Dock = DockStyle.Top;
            btnReportes.FlatAppearance.BorderSize = 0;
            btnReportes.FlatStyle = FlatStyle.Flat;
            btnReportes.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnReportes.ForeColor = Color.White;
            btnReportes.Location = new Point(0, 155);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(260, 55);
            btnReportes.TabIndex = 2;
            btnReportes.Text = "   📊  Reportes";
            btnReportes.UseVisualStyleBackColor = false;
            btnReportes.Click += btnReportes_Click;
            // 
            // btnInventarioEmpleado
            // 
            btnInventarioEmpleado.BackColor = Color.FromArgb(50, 50, 50);
            btnInventarioEmpleado.Dock = DockStyle.Top;
            btnInventarioEmpleado.FlatAppearance.BorderSize = 0;
            btnInventarioEmpleado.FlatStyle = FlatStyle.Flat;
            btnInventarioEmpleado.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnInventarioEmpleado.ForeColor = Color.White;
            btnInventarioEmpleado.Location = new Point(0, 210);
            btnInventarioEmpleado.Name = "btnInventarioEmpleado";
            btnInventarioEmpleado.Size = new Size(260, 55);
            btnInventarioEmpleado.TabIndex = 3;
            btnInventarioEmpleado.Text = "   📦  Inventario";
            btnInventarioEmpleado.UseVisualStyleBackColor = false;
            btnInventarioEmpleado.Click += btnInventarioEmpleado_Click;
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
            btnCerrarSesion.TabIndex = 4;
            btnCerrarSesion.Text = "   ⬅  Cerrar Sesión";
            btnCerrarSesion.UseVisualStyleBackColor = false;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
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
            lblBienvenida.Location = new Point(190, 270);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.TabIndex = 1;
            lblBienvenida.Text = "Bienvenido al Sistema de Ventas";
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Segoe UI", 13F, FontStyle.Regular);
            lblSubtitulo.ForeColor = Color.FromArgb(120, 120, 120);
            lblSubtitulo.Location = new Point(290, 325);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.TabIndex = 2;
            lblSubtitulo.Text = "Selecciona una opción del menú lateral";
            // 
            // FrmMenuEmpleado
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1200, 700);
            Controls.Add(panelContenido);
            Controls.Add(panelMenu);
            MinimumSize = new Size(900, 600);
            Name = "FrmMenuEmpleado";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menú Empleado - Disfraces Alejandría";
            panelMenu.ResumeLayout(false);
            panelContenido.ResumeLayout(false);
            panelContenido.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Label lblTitulo;
        private Button btnVentas;
        private Button btnReportes;
        private Button btnInventarioEmpleado;
        private Button btnCerrarSesion;
        private Panel panelContenido;
        private Label lblBienvenida;
        private Label lblSubtitulo;
    }
}