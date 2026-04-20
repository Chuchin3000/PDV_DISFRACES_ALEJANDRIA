namespace PVD_DISFRACES_ALEJANDRIA.Forms
{
    partial class FrmVentas
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel2 = new Panel();
            panelProductos = new Panel();
            label2 = new Label();
            gridProductos = new DataGridView();
            panel3 = new Panel();
            txtIdCategoria = new TextBox();
            label19 = new Label();
            checkDescontinuado = new CheckBox();
            txtCategoria = new TextBox();
            label18 = new Label();
            txtTalla = new TextBox();
            label17 = new Label();
            txtIdProducto = new TextBox();
            label16 = new Label();
            txtProducto = new TextBox();
            label15 = new Label();
            gridCarrito = new DataGridView();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            txtDescuento = new TextBox();
            label10 = new Label();
            txtPrecioPieza = new TextBox();
            label9 = new Label();
            txtEmpleado = new TextBox();
            label8 = new Label();
            txtAbono = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            comboBoxEstado = new ComboBox();
            numericCantidad = new NumericUpDown();
            dateFechaEntrega = new DateTimePicker();
            label4 = new Label();
            label3 = new Label();
            btnAgregarProducto = new Button();
            btnFinalizarVenta = new Button();
            label21 = new Label();
            lblTotal = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridProductos).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridCarrito).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericCantidad).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Navy;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1253, 84);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.regresar;
            pictureBox1.Location = new Point(12, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(47, 45);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(131, 24);
            label1.Name = "label1";
            label1.Size = new Size(209, 34);
            label1.TabIndex = 0;
            label1.Text = "Agregar Venta";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Navy;
            panel2.Location = new Point(0, 79);
            panel2.Name = "panel2";
            panel2.Size = new Size(158, 669);
            panel2.TabIndex = 1;
            // 
            // panelProductos
            // 
            panelProductos.AccessibleDescription = "";
            panelProductos.AccessibleName = "";
            panelProductos.Controls.Add(label2);
            panelProductos.Controls.Add(gridProductos);
            panelProductos.Location = new Point(269, 90);
            panelProductos.Name = "panelProductos";
            panelProductos.Size = new Size(858, 235);
            panelProductos.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(26, 9);
            label2.Name = "label2";
            label2.Size = new Size(182, 19);
            label2.TabIndex = 1;
            label2.Text = "Productos disponibles";
            // 
            // gridProductos
            // 
            gridProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            gridProductos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            gridProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridProductos.Location = new Point(0, 41);
            gridProductos.Name = "gridProductos";
            gridProductos.ReadOnly = true;
            gridProductos.Size = new Size(858, 194);
            gridProductos.TabIndex = 0;
            gridProductos.CellClick += gridProductos_CellClick;
            // 
            // panel3
            // 
            panel3.Controls.Add(txtIdCategoria);
            panel3.Controls.Add(label19);
            panel3.Controls.Add(checkDescontinuado);
            panel3.Controls.Add(txtCategoria);
            panel3.Controls.Add(label18);
            panel3.Controls.Add(txtTalla);
            panel3.Controls.Add(label17);
            panel3.Controls.Add(txtIdProducto);
            panel3.Controls.Add(label16);
            panel3.Controls.Add(txtProducto);
            panel3.Controls.Add(label15);
            panel3.Controls.Add(gridCarrito);
            panel3.Controls.Add(label14);
            panel3.Controls.Add(label13);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(txtDescuento);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(txtPrecioPieza);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(txtEmpleado);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(txtAbono);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(comboBoxEstado);
            panel3.Controls.Add(numericCantidad);
            panel3.Controls.Add(dateFechaEntrega);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(269, 331);
            panel3.Name = "panel3";
            panel3.Size = new Size(858, 372);
            panel3.TabIndex = 3;
            // 
            // txtIdCategoria
            // 
            txtIdCategoria.Location = new Point(561, 16);
            txtIdCategoria.Name = "txtIdCategoria";
            txtIdCategoria.ReadOnly = true;
            txtIdCategoria.Size = new Size(43, 23);
            txtIdCategoria.TabIndex = 34;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(485, 21);
            label19.Name = "label19";
            label19.Size = new Size(72, 15);
            label19.TabIndex = 33;
            label19.Text = "ID Categoria";
            // 
            // checkDescontinuado
            // 
            checkDescontinuado.AutoSize = true;
            checkDescontinuado.Location = new Point(498, 56);
            checkDescontinuado.Name = "checkDescontinuado";
            checkDescontinuado.Size = new Size(106, 19);
            checkDescontinuado.TabIndex = 32;
            checkDescontinuado.Text = "Descontinuado";
            checkDescontinuado.UseVisualStyleBackColor = true;
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(698, 17);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.ReadOnly = true;
            txtCategoria.Size = new Size(144, 23);
            txtCategoria.TabIndex = 30;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(631, 21);
            label18.Name = "label18";
            label18.Size = new Size(58, 15);
            label18.TabIndex = 29;
            label18.Text = "Categoria";
            // 
            // txtTalla
            // 
            txtTalla.Location = new Point(411, 58);
            txtTalla.Name = "txtTalla";
            txtTalla.ReadOnly = true;
            txtTalla.Size = new Size(56, 23);
            txtTalla.TabIndex = 28;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(375, 62);
            label17.Name = "label17";
            label17.Size = new Size(30, 15);
            label17.TabIndex = 27;
            label17.Text = "Talla";
            // 
            // txtIdProducto
            // 
            txtIdProducto.Location = new Point(116, 16);
            txtIdProducto.Name = "txtIdProducto";
            txtIdProducto.ReadOnly = true;
            txtIdProducto.Size = new Size(56, 23);
            txtIdProducto.TabIndex = 26;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(92, 20);
            label16.Name = "label16";
            label16.Size = new Size(18, 15);
            label16.TabIndex = 25;
            label16.Text = "ID";
            // 
            // txtProducto
            // 
            txtProducto.Location = new Point(267, 16);
            txtProducto.Name = "txtProducto";
            txtProducto.ReadOnly = true;
            txtProducto.Size = new Size(200, 23);
            txtProducto.TabIndex = 24;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(205, 20);
            label15.Name = "label15";
            label15.Size = new Size(56, 15);
            label15.TabIndex = 23;
            label15.Text = "Producto";
            // 
            // gridCarrito
            // 
            gridCarrito.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridCarrito.Location = new Point(0, 192);
            gridCarrito.Name = "gridCarrito";
            gridCarrito.ReadOnly = true;
            gridCarrito.Size = new Size(858, 180);
            gridCarrito.TabIndex = 22;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(173, 44);
            label14.Name = "label14";
            label14.Size = new Size(12, 15);
            label14.TabIndex = 21;
            label14.Text = "*";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(18, 40);
            label13.Name = "label13";
            label13.Size = new Size(12, 15);
            label13.TabIndex = 20;
            label13.Text = "*";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(592, 142);
            label12.Name = "label12";
            label12.Size = new Size(12, 15);
            label12.TabIndex = 19;
            label12.Text = "*";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(21, 142);
            label11.Name = "label11";
            label11.Size = new Size(12, 15);
            label11.TabIndex = 18;
            label11.Text = "*";
            // 
            // txtDescuento
            // 
            txtDescuento.Location = new Point(309, 163);
            txtDescuento.Name = "txtDescuento";
            txtDescuento.Size = new Size(87, 23);
            txtDescuento.TabIndex = 17;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(230, 163);
            label10.Name = "label10";
            label10.Size = new Size(63, 15);
            label10.TabIndex = 16;
            label10.Text = "Descuento";
            // 
            // txtPrecioPieza
            // 
            txtPrecioPieza.Location = new Point(270, 58);
            txtPrecioPieza.Name = "txtPrecioPieza";
            txtPrecioPieza.Size = new Size(82, 23);
            txtPrecioPieza.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(173, 61);
            label9.Name = "label9";
            label9.Size = new Size(91, 15);
            label9.TabIndex = 14;
            label9.Text = "Precio por pieza";
            // 
            // txtEmpleado
            // 
            txtEmpleado.Location = new Point(727, 160);
            txtEmpleado.Name = "txtEmpleado";
            txtEmpleado.Size = new Size(115, 23);
            txtEmpleado.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(592, 165);
            label8.Name = "label8";
            label8.Size = new Size(126, 15);
            label8.TabIndex = 12;
            label8.Text = "Empleado que atendio";
            // 
            // txtAbono
            // 
            txtAbono.Location = new Point(478, 163);
            txtAbono.Name = "txtAbono";
            txtAbono.Size = new Size(87, 23);
            txtAbono.TabIndex = 11;
            txtAbono.Visible = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(422, 166);
            label7.Name = "label7";
            label7.Size = new Size(43, 15);
            label7.TabIndex = 10;
            label7.Text = "Abono";
            label7.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 56);
            label6.Name = "label6";
            label6.Size = new Size(55, 15);
            label6.TabIndex = 9;
            label6.Text = "Cantidad";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 160);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 8;
            label5.Text = "Estado";
            // 
            // comboBoxEstado
            // 
            comboBoxEstado.FormattingEnabled = true;
            comboBoxEstado.Items.AddRange(new object[] { "Pagado", "Pendiente", "Abono" });
            comboBoxEstado.Location = new Point(85, 157);
            comboBoxEstado.Name = "comboBoxEstado";
            comboBoxEstado.Size = new Size(123, 23);
            comboBoxEstado.TabIndex = 7;
            // 
            // numericCantidad
            // 
            numericCantidad.Location = new Point(87, 54);
            numericCantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericCantidad.Name = "numericCantidad";
            numericCantidad.Size = new Size(52, 23);
            numericCantidad.TabIndex = 6;
            numericCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // dateFechaEntrega
            // 
            dateFechaEntrega.Location = new Point(354, 113);
            dateFechaEntrega.Name = "dateFechaEntrega";
            dateFechaEntrega.Size = new Size(229, 23);
            dateFechaEntrega.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(238, 119);
            label4.Name = "label4";
            label4.Size = new Size(97, 15);
            label4.TabIndex = 3;
            label4.Text = "Fecha de entrega";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(15, 16);
            label3.Name = "label3";
            label3.Size = new Size(61, 19);
            label3.TabIndex = 2;
            label3.Text = "Carrito";
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.Location = new Point(1133, 331);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(74, 60);
            btnAgregarProducto.TabIndex = 4;
            btnAgregarProducto.Text = "Agregar al carrito";
            btnAgregarProducto.UseVisualStyleBackColor = true;
            btnAgregarProducto.Click += btnAgregarProducto_Click;
            // 
            // btnFinalizarVenta
            // 
            btnFinalizarVenta.Location = new Point(1133, 523);
            btnFinalizarVenta.Name = "btnFinalizarVenta";
            btnFinalizarVenta.Size = new Size(65, 45);
            btnFinalizarVenta.TabIndex = 5;
            btnFinalizarVenta.Text = "Finalizar Venta";
            btnFinalizarVenta.UseVisualStyleBackColor = true;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label21.Location = new Point(1130, 594);
            label21.Name = "label21";
            label21.Size = new Size(43, 15);
            label21.TabIndex = 36;
            label21.Text = "TOTAL";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(1133, 618);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(47, 15);
            lblTotal.TabIndex = 37;
            lblTotal.Text = "--------";
            // 
            // FrmVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1252, 749);
            Controls.Add(lblTotal);
            Controls.Add(btnFinalizarVenta);
            Controls.Add(label21);
            Controls.Add(panel3);
            Controls.Add(panelProductos);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btnAgregarProducto);
            Name = "FrmVentas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmVentas";
            FormClosed += FrmVentas_FormClosed;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelProductos.ResumeLayout(false);
            panelProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridProductos).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridCarrito).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericCantidad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Panel panelProductos;
        private DataGridView gridProductos;
        private Label label2;
        private Panel panel3;
        private Label label3;
        private DateTimePicker dateFechaEntrega;
        private Button btnAgregarProducto;
        private Label label4;
        private Label label5;
        private ComboBox comboBoxEstado;
        private NumericUpDown numericCantidad;
        private TextBox txtEmpleado;
        private Label label8;
        private TextBox txtAbono;
        private Label label7;
        private Label label6;
        private Label label11;
        private TextBox txtDescuento;
        private Label label10;
        private TextBox txtPrecioPieza;
        private Label label9;
        private DataGridView gridCarrito;
        private Label label14;
        private Label label13;
        private Label label12;
        private TextBox txtIdProducto;
        private Label label16;
        private TextBox txtProducto;
        private Label label15;
        private TextBox txtCategoria;
        private Label label18;
        private TextBox txtTalla;
        private Label label17;
        private CheckBox checkDescontinuado;
        private PictureBox pictureBox1;
        private TextBox txtIdCategoria;
        private Label label19;
        private Button btnFinalizarVenta;
        private Label label21;
        private Label lblTotal;
    }
}