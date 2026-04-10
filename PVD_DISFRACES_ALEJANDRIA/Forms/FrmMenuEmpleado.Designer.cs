namespace PVD_DISFRACES_ALEJANDRIA.Forms
{
    partial class FrmMenuEmpleado
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
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            label2 = new Label();
            btnVentas = new Button();
            btnReportes = new Button();
            btnInventarioEmpleado = new Button();
            btnCerrarSesion = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Navy;
            panel1.Controls.Add(label1);
            panel1.Cursor = Cursors.SizeNESW;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1419, 138);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(89, 48);
            label1.Name = "label1";
            label1.Size = new Size(583, 50);
            label1.TabIndex = 0;
            label1.Text = "Bienvenido al Sistema de Ventas";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Navy;
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 637);
            panel2.Name = "panel2";
            panel2.Size = new Size(1419, 56);
            panel2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(458, 18);
            label2.Name = "label2";
            label2.Size = new Size(441, 20);
            label2.TabIndex = 0;
            label2.Text = "2026 Punto de Venta - Sistema de Gestión de Tienda de Disfraces";
            // 
            // btnVentas
            // 
            btnVentas.BackColor = Color.Lime;
            btnVentas.FlatStyle = FlatStyle.Popup;
            btnVentas.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVentas.Location = new Point(378, 234);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(175, 75);
            btnVentas.TabIndex = 2;
            btnVentas.Text = "Ventas";
            btnVentas.UseVisualStyleBackColor = false;
            // 
            // btnReportes
            // 
            btnReportes.BackColor = Color.Fuchsia;
            btnReportes.FlatStyle = FlatStyle.Popup;
            btnReportes.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReportes.Location = new Point(627, 234);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(175, 75);
            btnReportes.TabIndex = 3;
            btnReportes.Text = "Reportes";
            btnReportes.UseVisualStyleBackColor = false;
            // 
            // btnInventarioEmpleado
            // 
            btnInventarioEmpleado.BackColor = Color.FromArgb(255, 128, 0);
            btnInventarioEmpleado.FlatStyle = FlatStyle.Popup;
            btnInventarioEmpleado.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInventarioEmpleado.Location = new Point(884, 234);
            btnInventarioEmpleado.Name = "btnInventarioEmpleado";
            btnInventarioEmpleado.Size = new Size(175, 75);
            btnInventarioEmpleado.TabIndex = 4;
            btnInventarioEmpleado.Text = "Inventario";
            btnInventarioEmpleado.UseVisualStyleBackColor = false;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.BackColor = Color.Red;
            btnCerrarSesion.FlatStyle = FlatStyle.Popup;
            btnCerrarSesion.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCerrarSesion.Location = new Point(627, 369);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(175, 75);
            btnCerrarSesion.TabIndex = 5;
            btnCerrarSesion.Text = "Cerrar Sesión";
            btnCerrarSesion.UseVisualStyleBackColor = false;
            // 
            // FrmMenuEmpleado
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1419, 693);
            Controls.Add(btnCerrarSesion);
            Controls.Add(btnInventarioEmpleado);
            Controls.Add(btnReportes);
            Controls.Add(btnVentas);
            Controls.Add(panel2);
            Controls.Add(panel1);
            ForeColor = Color.White;
            Name = "FrmMenuEmpleado";
            Text = "FrmMenuEmpleado";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private Button btnVentas;
        private Button btnReportes;
        private Button btnInventarioEmpleado;
        private Button btnCerrarSesion;
    }
}