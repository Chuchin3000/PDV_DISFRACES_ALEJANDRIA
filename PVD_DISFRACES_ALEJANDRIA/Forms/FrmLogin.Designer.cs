namespace PVD_DISFRACES_ALEJANDRIA.Forms
{
    partial class FrmLogin
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
            panelCard = new Panel();
            lblIcon = new Label();
            labelTitle = new Label();
            lblUsuario = new Label();
            txtUsuario = new TextBox();
            lblContraseña = new Label();
            txtContraseña = new TextBox();
            btnIngresar = new Button();
            btnProbarConexion = new Button();
            panelCard.SuspendLayout();
            SuspendLayout();
            // 
            // panelCard
            // 
            panelCard.Anchor = AnchorStyles.None;
            panelCard.BackColor = Color.White;
            panelCard.BorderStyle = BorderStyle.FixedSingle;
            panelCard.Controls.Add(lblIcon);
            panelCard.Controls.Add(labelTitle);
            panelCard.Controls.Add(lblUsuario);
            panelCard.Controls.Add(txtUsuario);
            panelCard.Controls.Add(lblContraseña);
            panelCard.Controls.Add(txtContraseña);
            panelCard.Controls.Add(btnIngresar);
            panelCard.Controls.Add(btnProbarConexion);
            panelCard.Location = new Point(130, 60);
            panelCard.Name = "panelCard";
            panelCard.Padding = new Padding(20);
            panelCard.Size = new Size(340, 401);
            panelCard.TabIndex = 0;
            // 
            // lblIcon
            // 
            lblIcon.AutoSize = true;
            lblIcon.Font = new Font("Segoe UI Emoji", 28F);
            lblIcon.Location = new Point(145, 20);
            lblIcon.Name = "lblIcon";
            lblIcon.Size = new Size(50, 50);
            lblIcon.TabIndex = 0;
            lblIcon.Text = "👤";
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            labelTitle.ForeColor = Color.FromArgb(40, 40, 40);
            labelTitle.Location = new Point(30, 82);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(270, 40);
            labelTitle.TabIndex = 1;
            labelTitle.Text = "Inicio de Sesión";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 10F);
            lblUsuario.ForeColor = Color.FromArgb(80, 80, 80);
            lblUsuario.Location = new Point(30, 140);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(68, 23);
            lblUsuario.TabIndex = 2;
            lblUsuario.Text = "Usuario";
            lblUsuario.Click += lblUsuario_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.BorderStyle = BorderStyle.FixedSingle;
            txtUsuario.Font = new Font("Segoe UI", 10F);
            txtUsuario.Location = new Point(30, 165);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(280, 27);
            txtUsuario.TabIndex = 0;
            txtUsuario.TextChanged += txtUsuario_TextChanged;
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Font = new Font("Segoe UI", 10F);
            lblContraseña.ForeColor = Color.FromArgb(80, 80, 80);
            lblContraseña.Location = new Point(30, 210);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(97, 23);
            lblContraseña.TabIndex = 3;
            lblContraseña.Text = "Contraseña";
            lblContraseña.Click += lblContraseña_Click;
            // 
            // txtContraseña
            // 
            txtContraseña.BorderStyle = BorderStyle.FixedSingle;
            txtContraseña.Font = new Font("Segoe UI", 10F);
            txtContraseña.Location = new Point(30, 235);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '*';
            txtContraseña.Size = new Size(280, 27);
            txtContraseña.TabIndex = 1;
            txtContraseña.TextChanged += txtContraseña_TextChanged;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.FromArgb(46, 139, 87);
            btnIngresar.FlatAppearance.BorderSize = 0;
            btnIngresar.FlatStyle = FlatStyle.Flat;
            btnIngresar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnIngresar.ForeColor = Color.White;
            btnIngresar.Location = new Point(30, 290);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(280, 40);
            btnIngresar.TabIndex = 2;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // btnProbarConexion
            // 
            btnProbarConexion.BackColor = Color.LightGray;
            btnProbarConexion.FlatStyle = FlatStyle.Flat;
            btnProbarConexion.Font = new Font("Segoe UI", 9F);
            btnProbarConexion.Location = new Point(95, 340);
            btnProbarConexion.Name = "btnProbarConexion";
            btnProbarConexion.Size = new Size(150, 30);
            btnProbarConexion.TabIndex = 3;
            btnProbarConexion.Text = "Probar Conexión";
            btnProbarConexion.UseVisualStyleBackColor = false;
            btnProbarConexion.Click += btnProbarConexion_Click;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 240, 240);
            ClientSize = new Size(600, 520);
            Controls.Add(panelCard);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio de Sesión - Disfraces Alejandría";
            panelCard.ResumeLayout(false);
            panelCard.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelCard;
        private Label lblIcon;
        private Label labelTitle;
        private Label lblUsuario;
        private TextBox txtUsuario;
        private Label lblContraseña;
        private TextBox txtContraseña;
        private Button btnIngresar;
        private Button btnProbarConexion;
    }
}