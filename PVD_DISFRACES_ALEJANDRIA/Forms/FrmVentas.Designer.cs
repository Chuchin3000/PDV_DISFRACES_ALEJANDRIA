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
            panelProductos = new Panel();
            label2 = new Label();
            gridProductos = new DataGridView();
            panel3 = new Panel();
            gridCarrito = new DataGridView();
            label3 = new Label();
            lblTotal = new Label();
            txtTalla = new TextBox();
            btnFinalizarVenta = new Button();
            label21 = new Label();
            label17 = new Label();
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
            labelAbono = new Label();
            label6 = new Label();
            label5 = new Label();
            comboBoxEstado = new ComboBox();
            numericCantidad = new NumericUpDown();
            dateFechaEntrega = new DateTimePicker();
            labelFecha = new Label();
            txtIdCategoria = new TextBox();
            label19 = new Label();
            txtCategoria = new TextBox();
            label18 = new Label();
            txtIdProducto = new TextBox();
            label16 = new Label();
            txtProducto = new TextBox();
            label15 = new Label();
            btnAgregarProducto = new Button();
            label20 = new Label();
            panel2 = new Panel();
            panel4 = new Panel();
            label22 = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridProductos).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridCarrito).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericCantidad).BeginInit();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Navy;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1370, 84);
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
            // panelProductos
            // 
            panelProductos.AccessibleDescription = "";
            panelProductos.AccessibleName = "";
            panelProductos.BorderStyle = BorderStyle.FixedSingle;
            panelProductos.Controls.Add(label2);
            panelProductos.Controls.Add(gridProductos);
            panelProductos.Location = new Point(337, 90);
            panelProductos.Name = "panelProductos";
            panelProductos.Size = new Size(859, 235);
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
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(gridCarrito);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(335, 345);
            panel3.Name = "panel3";
            panel3.Size = new Size(860, 236);
            panel3.TabIndex = 3;
            // 
            // gridCarrito
            // 
            gridCarrito.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridCarrito.Location = new Point(0, 55);
            gridCarrito.Name = "gridCarrito";
            gridCarrito.ReadOnly = true;
            gridCarrito.Size = new Size(858, 180);
            gridCarrito.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(28, 20);
            label3.Name = "label3";
            label3.Size = new Size(61, 19);
            label3.TabIndex = 2;
            label3.Text = "Carrito";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(355, 631);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(47, 15);
            lblTotal.TabIndex = 37;
            lblTotal.Text = "--------";
            // 
            // txtTalla
            // 
            txtTalla.Location = new Point(52, 179);
            txtTalla.Name = "txtTalla";
            txtTalla.ReadOnly = true;
            txtTalla.Size = new Size(56, 23);
            txtTalla.TabIndex = 28;
            // 
            // btnFinalizarVenta
            // 
            btnFinalizarVenta.BackColor = Color.LimeGreen;
            btnFinalizarVenta.Cursor = Cursors.Hand;
            btnFinalizarVenta.FlatStyle = FlatStyle.Flat;
            btnFinalizarVenta.Location = new Point(1089, 613);
            btnFinalizarVenta.Name = "btnFinalizarVenta";
            btnFinalizarVenta.Size = new Size(104, 45);
            btnFinalizarVenta.TabIndex = 5;
            btnFinalizarVenta.Text = "Finalizar Venta";
            btnFinalizarVenta.UseVisualStyleBackColor = false;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label21.Location = new Point(352, 607);
            label21.Name = "label21";
            label21.Size = new Size(43, 15);
            label21.TabIndex = 36;
            label21.Text = "TOTAL";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(16, 183);
            label17.Name = "label17";
            label17.Size = new Size(30, 15);
            label17.TabIndex = 27;
            label17.Text = "Talla";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(17, 99);
            label14.Name = "label14";
            label14.Size = new Size(12, 15);
            label14.TabIndex = 21;
            label14.Text = "*";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(19, 54);
            label13.Name = "label13";
            label13.Size = new Size(12, 15);
            label13.TabIndex = 20;
            label13.Text = "*";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(17, 189);
            label12.Name = "label12";
            label12.Size = new Size(12, 15);
            label12.TabIndex = 19;
            label12.Text = "*";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(16, 227);
            label11.Name = "label11";
            label11.Size = new Size(12, 15);
            label11.TabIndex = 18;
            label11.Text = "*";
            // 
            // txtDescuento
            // 
            txtDescuento.Location = new Point(97, 157);
            txtDescuento.Name = "txtDescuento";
            txtDescuento.Size = new Size(45, 23);
            txtDescuento.TabIndex = 17;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(18, 157);
            label10.Name = "label10";
            label10.Size = new Size(63, 15);
            label10.TabIndex = 16;
            label10.Text = "Descuento";
            // 
            // txtPrecioPieza
            // 
            txtPrecioPieza.Location = new Point(114, 113);
            txtPrecioPieza.Name = "txtPrecioPieza";
            txtPrecioPieza.Size = new Size(82, 23);
            txtPrecioPieza.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(17, 116);
            label9.Name = "label9";
            label9.Size = new Size(91, 15);
            label9.TabIndex = 14;
            label9.Text = "Precio por pieza";
            // 
            // txtEmpleado
            // 
            txtEmpleado.Location = new Point(151, 199);
            txtEmpleado.Name = "txtEmpleado";
            txtEmpleado.Size = new Size(115, 23);
            txtEmpleado.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(16, 204);
            label8.Name = "label8";
            label8.Size = new Size(126, 15);
            label8.TabIndex = 12;
            label8.Text = "Empleado que atendio";
            // 
            // txtAbono
            // 
            txtAbono.Location = new Point(770, 642);
            txtAbono.Name = "txtAbono";
            txtAbono.Size = new Size(87, 23);
            txtAbono.TabIndex = 11;
            txtAbono.Visible = false;
            // 
            // labelAbono
            // 
            labelAbono.AutoSize = true;
            labelAbono.Location = new Point(714, 645);
            labelAbono.Name = "labelAbono";
            labelAbono.Size = new Size(43, 15);
            labelAbono.TabIndex = 10;
            labelAbono.Text = "Abono";
            labelAbono.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 70);
            label6.Name = "label6";
            label6.Size = new Size(55, 15);
            label6.TabIndex = 9;
            label6.Text = "Cantidad";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 245);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 8;
            label5.Text = "Estado";
            // 
            // comboBoxEstado
            // 
            comboBoxEstado.FormattingEnabled = true;
            comboBoxEstado.Items.AddRange(new object[] { "Pagado", "Pendiente", "Abono", "Cancelado" });
            comboBoxEstado.Location = new Point(80, 242);
            comboBoxEstado.Name = "comboBoxEstado";
            comboBoxEstado.Size = new Size(123, 23);
            comboBoxEstado.TabIndex = 7;
            comboBoxEstado.SelectedIndexChanged += comboBoxEstado_SelectedIndexChanged;
            // 
            // numericCantidad
            // 
            numericCantidad.Location = new Point(88, 68);
            numericCantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericCantidad.Name = "numericCantidad";
            numericCantidad.Size = new Size(52, 23);
            numericCantidad.TabIndex = 6;
            numericCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // dateFechaEntrega
            // 
            dateFechaEntrega.Location = new Point(830, 601);
            dateFechaEntrega.Name = "dateFechaEntrega";
            dateFechaEntrega.Size = new Size(229, 23);
            dateFechaEntrega.TabIndex = 5;
            dateFechaEntrega.Visible = false;
            // 
            // labelFecha
            // 
            labelFecha.AutoSize = true;
            labelFecha.Location = new Point(714, 607);
            labelFecha.Name = "labelFecha";
            labelFecha.Size = new Size(97, 15);
            labelFecha.TabIndex = 3;
            labelFecha.Text = "Fecha de entrega";
            labelFecha.Visible = false;
            // 
            // txtIdCategoria
            // 
            txtIdCategoria.Location = new Point(97, 109);
            txtIdCategoria.Name = "txtIdCategoria";
            txtIdCategoria.ReadOnly = true;
            txtIdCategoria.Size = new Size(43, 23);
            txtIdCategoria.TabIndex = 34;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(19, 117);
            label19.Name = "label19";
            label19.Size = new Size(72, 15);
            label19.TabIndex = 33;
            label19.Text = "ID Categoria";
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(80, 147);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.ReadOnly = true;
            txtCategoria.Size = new Size(144, 23);
            txtCategoria.TabIndex = 30;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(18, 150);
            label18.Name = "label18";
            label18.Size = new Size(58, 15);
            label18.TabIndex = 29;
            label18.Text = "Categoria";
            // 
            // txtIdProducto
            // 
            txtIdProducto.Location = new Point(42, 51);
            txtIdProducto.Name = "txtIdProducto";
            txtIdProducto.ReadOnly = true;
            txtIdProducto.Size = new Size(56, 23);
            txtIdProducto.TabIndex = 26;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(18, 54);
            label16.Name = "label16";
            label16.Size = new Size(18, 15);
            label16.TabIndex = 25;
            label16.Text = "ID";
            // 
            // txtProducto
            // 
            txtProducto.Location = new Point(77, 80);
            txtProducto.Name = "txtProducto";
            txtProducto.ReadOnly = true;
            txtProducto.Size = new Size(189, 23);
            txtProducto.TabIndex = 24;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(15, 84);
            label15.Name = "label15";
            label15.Size = new Size(56, 15);
            label15.TabIndex = 23;
            label15.Text = "Producto";
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.Cursor = Cursors.Hand;
            btnAgregarProducto.FlatStyle = FlatStyle.Flat;
            btnAgregarProducto.Location = new Point(77, 296);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(122, 60);
            btnAgregarProducto.TabIndex = 4;
            btnAgregarProducto.Text = "Agregar al carrito";
            btnAgregarProducto.UseVisualStyleBackColor = true;
            btnAgregarProducto.Click += btnAgregarProducto_Click;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label20.Location = new Point(15, 19);
            label20.Name = "label20";
            label20.Size = new Size(171, 19);
            label20.TabIndex = 38;
            label20.Text = "Detalles del producto";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label20);
            panel2.Controls.Add(txtTalla);
            panel2.Controls.Add(label15);
            panel2.Controls.Add(txtIdCategoria);
            panel2.Controls.Add(label17);
            panel2.Controls.Add(txtProducto);
            panel2.Controls.Add(label16);
            panel2.Controls.Add(txtIdProducto);
            panel2.Controls.Add(txtCategoria);
            panel2.Controls.Add(label19);
            panel2.Controls.Add(label18);
            panel2.Location = new Point(6, 89);
            panel2.Name = "panel2";
            panel2.Size = new Size(321, 236);
            panel2.TabIndex = 39;
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(label4);
            panel4.Controls.Add(label22);
            panel4.Controls.Add(numericCantidad);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(label13);
            panel4.Controls.Add(label12);
            panel4.Controls.Add(label11);
            panel4.Controls.Add(txtPrecioPieza);
            panel4.Controls.Add(label9);
            panel4.Controls.Add(label14);
            panel4.Controls.Add(txtEmpleado);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(txtDescuento);
            panel4.Controls.Add(btnAgregarProducto);
            panel4.Controls.Add(label10);
            panel4.Controls.Add(comboBoxEstado);
            panel4.Location = new Point(6, 345);
            panel4.Name = "panel4";
            panel4.Size = new Size(321, 377);
            panel4.TabIndex = 40;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label22.Location = new Point(19, 20);
            label22.Name = "label22";
            label22.Size = new Size(140, 19);
            label22.TabIndex = 39;
            label22.Text = "Agregar al carrito";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(142, 160);
            label4.Name = "label4";
            label4.Size = new Size(17, 15);
            label4.TabIndex = 40;
            label4.Text = "%";
            // 
            // FrmVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 749);
            Controls.Add(lblTotal);
            Controls.Add(panel4);
            Controls.Add(btnFinalizarVenta);
            Controls.Add(label21);
            Controls.Add(panel2);
            Controls.Add(txtAbono);
            Controls.Add(labelAbono);
            Controls.Add(panel3);
            Controls.Add(panelProductos);
            Controls.Add(panel1);
            Controls.Add(dateFechaEntrega);
            Controls.Add(labelFecha);
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
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panelProductos;
        private DataGridView gridProductos;
        private Label label2;
        private Panel panel3;
        private Label label3;
        private DateTimePicker dateFechaEntrega;
        private Button btnAgregarProducto;
        private Label labelFecha;
        private Label label5;
        private ComboBox comboBoxEstado;
        private NumericUpDown numericCantidad;
        private TextBox txtEmpleado;
        private Label label8;
        private TextBox txtAbono;
        private Label labelAbono;
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
        private PictureBox pictureBox1;
        private TextBox txtIdCategoria;
        private Label label19;
        private Button btnFinalizarVenta;
        private Label label21;
        private Label lblTotal;
        private Label label20;
        private Panel panel2;
        private Panel panel4;
        private Label label22;
        private Label label4;
    }
}