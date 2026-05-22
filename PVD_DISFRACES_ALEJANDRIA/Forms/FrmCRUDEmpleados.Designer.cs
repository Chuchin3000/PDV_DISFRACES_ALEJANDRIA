namespace PVD_DISFRACES_ALEJANDRIA.Forms
{
    partial class FrmCRUDEmpleados
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
            txtDireccion = new TextBox();
            txtTelefono = new TextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panelBotones = new Panel();
            btnCancelar = new Button();
            btnGuardar = new Button();
            btnEliminar = new Button();
            btnEditar = new Button();
            btnAgregar = new Button();
            dgvEmpleados = new DataGridView();
            panelSuperior.SuspendLayout();
            groupBoxDatos.SuspendLayout();
            panelBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).BeginInit();
            SuspendLayout();
            // 
            // panelSuperior
            // 
            panelSuperior.BackColor = Color.FromArgb(155, 89, 182);
            panelSuperior.Controls.Add(lblTitulo);
            panelSuperior.Dock = DockStyle.Top;
            panelSuperior.Location = new Point(0, 0);
            panelSuperior.Name = "panelSuperior";
            panelSuperior.Size = new Size(900, 70);
            panelSuperior.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(30, 15);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "👥 Gestión de Empleados";
            // 
            // groupBoxDatos
            // 
            groupBoxDatos.Controls.Add(txtDireccion);
            groupBoxDatos.Controls.Add(txtTelefono);
            groupBoxDatos.Controls.Add(txtApellido);
            groupBoxDatos.Controls.Add(txtNombre);
            groupBoxDatos.Controls.Add(label4);
            groupBoxDatos.Controls.Add(label3);
            groupBoxDatos.Controls.Add(label2);
            groupBoxDatos.Controls.Add(label1);
            groupBoxDatos.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBoxDatos.Location = new Point(30, 90);
            groupBoxDatos.Name = "groupBoxDatos";
            groupBoxDatos.Size = new Size(840, 140);
            groupBoxDatos.TabIndex = 1;
            groupBoxDatos.TabStop = false;
            groupBoxDatos.Text = "Datos del Empleado";
            // 
            // label1 — Nombre
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(20, 48);
            label1.Name = "label1";
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 10F);
            txtNombre.Location = new Point(100, 45);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(280, 25);
            txtNombre.TabIndex = 4;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // label2 — Apellido
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(20, 93);
            label2.Name = "label2";
            label2.TabIndex = 1;
            label2.Text = "Apellido:";
            // 
            // txtApellido
            // 
            txtApellido.Font = new Font("Segoe UI", 10F);
            txtApellido.Location = new Point(100, 90);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(280, 25);
            txtApellido.TabIndex = 5;
            txtApellido.TextChanged += txtApellido_TextChanged;
            // 
            // label3 — Teléfono
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(420, 48);
            label3.Name = "label3";
            label3.TabIndex = 2;
            label3.Text = "Teléfono:";
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Segoe UI", 10F);
            txtTelefono.Location = new Point(530, 45);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(200, 25);
            txtTelefono.TabIndex = 6;
            txtTelefono.TextChanged += txtTelefono_TextChanged;
            // 
            // label4 — Dirección
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(420, 93);
            label4.Name = "label4";
            label4.TabIndex = 3;
            label4.Text = "Dirección:";
            // 
            // txtDireccion
            // 
            txtDireccion.Font = new Font("Segoe UI", 10F);
            txtDireccion.Location = new Point(530, 90);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(280, 25);
            txtDireccion.TabIndex = 7;
            txtDireccion.TextChanged += txtDireccion_TextChanged;
            // 
            // panelBotones
            // 
            panelBotones.Controls.Add(btnCancelar);
            panelBotones.Controls.Add(btnGuardar);
            panelBotones.Controls.Add(btnEliminar);
            panelBotones.Controls.Add(btnEditar);
            panelBotones.Controls.Add(btnAgregar);
            panelBotones.Location = new Point(30, 245);
            panelBotones.Name = "panelBotones";
            panelBotones.Size = new Size(840, 60);
            panelBotones.TabIndex = 2;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(46, 204, 113);
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(10, 10);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(130, 40);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "➕ Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.FromArgb(241, 196, 15);
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnEditar.ForeColor = Color.White;
            btnEditar.Location = new Point(170, 10);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(130, 40);
            btnEditar.TabIndex = 1;
            btnEditar.Text = "✏️ Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(231, 76, 60);
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(330, 10);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(130, 40);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "🗑️ Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(52, 152, 219);
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(520, 10);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(130, 40);
            btnGuardar.TabIndex = 3;
            btnGuardar.Text = "💾 Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(149, 165, 166);
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(680, 10);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(130, 40);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "❌ Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // dgvEmpleados
            // 
            dgvEmpleados.BackgroundColor = Color.White;
            dgvEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmpleados.Location = new Point(30, 320);
            dgvEmpleados.Name = "dgvEmpleados";
            dgvEmpleados.RowHeadersWidth = 51;
            dgvEmpleados.RowTemplate.Height = 25;
            dgvEmpleados.Size = new Size(840, 280);
            dgvEmpleados.TabIndex = 3;
            dgvEmpleados.CellContentClick += dgvEmpleados_CellContentClick;
            // 
            // FrmCRUDEmpleados
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 620);
            Controls.Add(dgvEmpleados);
            Controls.Add(panelBotones);
            Controls.Add(groupBoxDatos);
            Controls.Add(panelSuperior);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FrmCRUDEmpleados";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión de Empleados - Disfraces Alejandría";
            panelSuperior.ResumeLayout(false);
            panelSuperior.PerformLayout();
            groupBoxDatos.ResumeLayout(false);
            groupBoxDatos.PerformLayout();
            panelBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSuperior;
        private Label lblTitulo;
        private GroupBox groupBoxDatos;
        private TextBox txtDireccion;
        private TextBox txtTelefono;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panelBotones;
        private Button btnCancelar;
        private Button btnGuardar;
        private Button btnEliminar;
        private Button btnEditar;
        private Button btnAgregar;
        private DataGridView dgvEmpleados;
    }
}