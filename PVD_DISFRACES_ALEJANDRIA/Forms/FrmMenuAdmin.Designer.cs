namespace PVD_DISFRACES_ALEJANDRIA.Forms
{
    partial class FrmMenuAdmin
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
            btnProductos = new Button();
            btnEmpleados = new Button();
            btnVentas = new Button();
            btnPedidoTraje = new Button();
            btnReportes = new Button();
            btnAuditoria = new Button();
            btnCerrarSesion = new Button();
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            label2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnProductos
            // 
            btnProductos.BackColor = Color.Lime;
            btnProductos.FlatStyle = FlatStyle.Popup;
            btnProductos.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProductos.ForeColor = Color.White;
            btnProductos.Location = new Point(363, 209);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(175, 75);
            btnProductos.TabIndex = 0;
            btnProductos.Text = "Productos";
            btnProductos.UseVisualStyleBackColor = false;
            // 
            // btnEmpleados
            // 
            btnEmpleados.BackColor = Color.FromArgb(192, 0, 192);
            btnEmpleados.FlatStyle = FlatStyle.Popup;
            btnEmpleados.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEmpleados.ForeColor = Color.White;
            btnEmpleados.Location = new Point(612, 209);
            btnEmpleados.Name = "btnEmpleados";
            btnEmpleados.Size = new Size(175, 75);
            btnEmpleados.TabIndex = 1;
            btnEmpleados.Text = "Empleados";
            btnEmpleados.UseVisualStyleBackColor = false;
            // 
            // btnVentas
            // 
            btnVentas.BackColor = Color.FromArgb(255, 128, 0);
            btnVentas.FlatStyle = FlatStyle.Popup;
            btnVentas.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVentas.ForeColor = Color.White;
            btnVentas.Location = new Point(866, 209);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(175, 75);
            btnVentas.TabIndex = 2;
            btnVentas.Text = "Ventas";
            btnVentas.UseVisualStyleBackColor = false;
            // 
            // btnPedidoTraje
            // 
            btnPedidoTraje.BackColor = SystemColors.HotTrack;
            btnPedidoTraje.FlatStyle = FlatStyle.Popup;
            btnPedidoTraje.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPedidoTraje.ForeColor = Color.White;
            btnPedidoTraje.Location = new Point(363, 338);
            btnPedidoTraje.Name = "btnPedidoTraje";
            btnPedidoTraje.Size = new Size(175, 75);
            btnPedidoTraje.TabIndex = 3;
            btnPedidoTraje.Text = "Pedido Traje";
            btnPedidoTraje.UseVisualStyleBackColor = false;
            // 
            // btnReportes
            // 
            btnReportes.BackColor = Color.FromArgb(0, 0, 192);
            btnReportes.FlatStyle = FlatStyle.Popup;
            btnReportes.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReportes.ForeColor = Color.White;
            btnReportes.Location = new Point(612, 338);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(175, 75);
            btnReportes.TabIndex = 4;
            btnReportes.Text = "Reportes";
            btnReportes.UseVisualStyleBackColor = false;
            // 
            // btnAuditoria
            // 
            btnAuditoria.BackColor = Color.Red;
            btnAuditoria.FlatStyle = FlatStyle.Popup;
            btnAuditoria.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAuditoria.ForeColor = Color.White;
            btnAuditoria.Location = new Point(866, 338);
            btnAuditoria.Name = "btnAuditoria";
            btnAuditoria.Size = new Size(175, 75);
            btnAuditoria.TabIndex = 5;
            btnAuditoria.Text = "Auditoria";
            btnAuditoria.UseVisualStyleBackColor = false;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.BackColor = Color.FromArgb(0, 0, 64);
            btnCerrarSesion.FlatStyle = FlatStyle.Popup;
            btnCerrarSesion.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCerrarSesion.ForeColor = Color.White;
            btnCerrarSesion.Location = new Point(612, 460);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(175, 75);
            btnCerrarSesion.TabIndex = 6;
            btnCerrarSesion.Text = "Cerrar Sesión";
            btnCerrarSesion.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Navy;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-3, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1424, 138);
            panel1.TabIndex = 7;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(110, 38);
            label1.Name = "label1";
            label1.Size = new Size(559, 50);
            label1.TabIndex = 0;
            label1.Text = "Sistema de Tienda de Disfraces";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Navy;
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 637);
            panel2.Name = "panel2";
            panel2.Size = new Size(1419, 56);
            panel2.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(458, 18);
            label2.Name = "label2";
            label2.Size = new Size(445, 20);
            label2.TabIndex = 0;
            label2.Text = "2026 Punto de Venta  - Sistema de Gestión de Tienda de Disfraces";
            // 
            // FrmMenuAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1419, 693);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btnCerrarSesion);
            Controls.Add(btnAuditoria);
            Controls.Add(btnReportes);
            Controls.Add(btnPedidoTraje);
            Controls.Add(btnVentas);
            Controls.Add(btnEmpleados);
            Controls.Add(btnProductos);
            Name = "FrmMenuAdmin";
            Text = "FrmMenuAdmin";
            Load += FrmMenuAdmin_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnProductos;
        private Button btnEmpleados;
        private Button btnVentas;
        private Button btnPedidoTraje;
        private Button btnReportes;
        private Button btnAuditoria;
        private Button btnCerrarSesion;
        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label2;
    }
}