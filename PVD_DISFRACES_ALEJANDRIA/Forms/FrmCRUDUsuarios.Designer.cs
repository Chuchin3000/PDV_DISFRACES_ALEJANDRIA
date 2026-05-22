namespace PVD_DISFRACES_ALEJANDRIA.Forms
{
    partial class FrmCRUDUsuarios
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
            panelSuperior = new Panel();
            lblTitulo = new Label();
            groupBoxDatos = new GroupBox();
            cboRol = new ComboBox();
            txtContrasena = new TextBox();
            txtUsuario = new TextBox();
            txtIdUsuario = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panelBotones = new Panel();
            btnEliminar = new Button();
            btnActualizar = new Button();
            btnAgregar = new Button();
            btnListar = new Button();
            dgvUsuarios = new DataGridView();
            panelSuperior.SuspendLayout();
            groupBoxDatos.SuspendLayout();
            panelBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // panelSuperior
            // 
            panelSuperior.BackColor = Color.FromArgb(52, 152, 219);
            panelSuperior.Controls.Add(lblTitulo);
            panelSuperior.Dock = DockStyle.Top;
            panelSuperior.Location = new Point(0, 0);
            panelSuperior.Name = "panelSuperior";
            panelSuperior.Size = new Size(1029, 93);
            panelSuperior.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(34, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "👤 Gestión de Usuarios";
            // 
            // groupBoxDatos
            // 
            groupBoxDatos.Controls.Add(cboRol);
            groupBoxDatos.Controls.Add(txtContrasena);
            groupBoxDatos.Controls.Add(txtUsuario);
            groupBoxDatos.Controls.Add(txtIdUsuario);
            groupBoxDatos.Controls.Add(label4);
            groupBoxDatos.Controls.Add(label3);
            groupBoxDatos.Controls.Add(label2);
            groupBoxDatos.Controls.Add(label1);
            groupBoxDatos.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBoxDatos.Location = new Point(34, 120);
            groupBoxDatos.Name = "groupBoxDatos";
            groupBoxDatos.Padding = new Padding(3, 4, 3, 4);
            groupBoxDatos.Size = new Size(960, 187);
            groupBoxDatos.TabIndex = 1;
            groupBoxDatos.TabStop = false;
            groupBoxDatos.Text = "Datos del Usuario";
            // 
            // label1 — ID
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(23, 64);
            label1.Name = "label1";
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // txtIdUsuario
            // 
            txtIdUsuario.Font = new Font("Segoe UI", 10F);
            txtIdUsuario.Location = new Point(149, 60);
            txtIdUsuario.Name = "txtIdUsuario";
            txtIdUsuario.ReadOnly = true;
            txtIdUsuario.Size = new Size(114, 30);
            txtIdUsuario.TabIndex = 4;
            // 
            // label2 — Usuario
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(23, 124);
            label2.Name = "label2";
            label2.TabIndex = 1;
            label2.Text = "Usuario:";
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Segoe UI", 10F);
            txtUsuario.Location = new Point(149, 120);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(285, 30);
            txtUsuario.TabIndex = 5;
            // 
            // label3 — Contraseña
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(514, 64);
            label3.Name = "label3";
            label3.TabIndex = 2;
            label3.Text = "Contraseña:";
            // 
            // txtContrasena
            // 
            txtContrasena.Font = new Font("Segoe UI", 10F);
            txtContrasena.Location = new Point(640, 60);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.PasswordChar = '*';
            txtContrasena.Size = new Size(285, 30);
            txtContrasena.TabIndex = 6;
            // 
            // label4 — Rol
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(514, 124);
            label4.Name = "label4";
            label4.TabIndex = 3;
            label4.Text = "Rol:";
            // 
            // cboRol
            // 
            cboRol.Font = new Font("Segoe UI", 10F);
            cboRol.FormattingEnabled = true;
            cboRol.Location = new Point(640, 120);
            cboRol.Name = "cboRol";
            cboRol.Size = new Size(285, 31);
            cboRol.TabIndex = 7;
            // 
            // panelBotones
            // 
            panelBotones.Controls.Add(btnEliminar);
            panelBotones.Controls.Add(btnActualizar);
            panelBotones.Controls.Add(btnAgregar);
            panelBotones.Controls.Add(btnListar);
            panelBotones.Location = new Point(34, 327);
            panelBotones.Name = "panelBotones";
            panelBotones.Size = new Size(960, 80);
            panelBotones.TabIndex = 2;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(46, 204, 113);
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(171, 13);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(149, 53);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "➕ Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.FromArgb(241, 196, 15);
            btnActualizar.FlatAppearance.BorderSize = 0;
            btnActualizar.FlatStyle = FlatStyle.Flat;
            btnActualizar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnActualizar.ForeColor = Color.White;
            btnActualizar.Location = new Point(343, 13);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(149, 53);
            btnActualizar.TabIndex = 2;
            btnActualizar.Text = "✏️ Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(231, 76, 60);
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(514, 13);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(149, 53);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "🗑️ Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnListar
            // 
            btnListar.BackColor = Color.FromArgb(52, 152, 219);
            btnListar.FlatAppearance.BorderSize = 0;
            btnListar.FlatStyle = FlatStyle.Flat;
            btnListar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnListar.ForeColor = Color.White;
            btnListar.Location = new Point(686, 13);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(149, 53);
            btnListar.TabIndex = 0;
            btnListar.Text = "🔄 Listar";
            btnListar.UseVisualStyleBackColor = false;
            btnListar.Click += btnListar_Click;
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.BackgroundColor = Color.White;
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Location = new Point(34, 427);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.RowHeadersWidth = 51;
            dgvUsuarios.RowTemplate.Height = 25;
            dgvUsuarios.Size = new Size(422, 373);
            dgvUsuarios.TabIndex = 3;
            dgvUsuarios.CellClick += dgvUsuarios_CellClick;
            // 
            // FrmCRUDUsuarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 827);
            Controls.Add(dgvUsuarios);
            Controls.Add(panelBotones);
            Controls.Add(groupBoxDatos);
            Controls.Add(panelSuperior);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FrmCRUDUsuarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión de Usuarios - Disfraces Alejandría";
            Load += FrmCRUDUsuarios_Load;  // ✅ nombre del handler actualizado
            panelSuperior.ResumeLayout(false);
            panelSuperior.PerformLayout();
            groupBoxDatos.ResumeLayout(false);
            groupBoxDatos.PerformLayout();
            panelBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSuperior;
        private Label lblTitulo;
        private GroupBox groupBoxDatos;
        private ComboBox cboRol;
        private TextBox txtContrasena;
        private TextBox txtUsuario;
        private TextBox txtIdUsuario;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panelBotones;
        private Button btnEliminar;
        private Button btnActualizar;
        private Button btnAgregar;
        private Button btnListar;
        private DataGridView dgvUsuarios;
    }
}