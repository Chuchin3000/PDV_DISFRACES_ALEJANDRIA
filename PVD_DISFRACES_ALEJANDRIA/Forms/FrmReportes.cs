using PVD_DISFRACES_ALEJANDRIA.DAO;
using PVD_DISFRACES_ALEJANDRIA.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PVD_DISFRACES_ALEJANDRIA.Forms
{
    /// <summary>
    /// Clase que representa el formulario de reportes.
    /// </summary>
    public partial class FrmReportes : Form
    {
        private readonly ReporteDAO reporteDAO;
        private readonly BindingList<ReporteProductoVendido> listaProductos;
        private readonly BindingList<ReporteVentasPorEmpleado> listaEmpleados;

        public FrmReportes()
        {
            InitializeComponent();
            reporteDAO = new ReporteDAO();
            listaProductos = new BindingList<ReporteProductoVendido>();
            listaEmpleados = new BindingList<ReporteVentasPorEmpleado>();

            // Configuración inicial
            ConfigurarGridProductos();
            ConfigurarGridEmpleados();
            ConfigurarFechas();
        }

        /// <summary>
        /// Configura los controles de fecha con valores iniciales
        /// </summary>
        private void ConfigurarFechas()
        {
            // Pestaña productos
            dtpInicioProductos.Value = DateTime.Now.AddMonths(-1);
            dtpFinProductos.Value = DateTime.Now;
            dtpInicioProductos.MaxDate = DateTime.Now;
            dtpFinProductos.MaxDate = DateTime.Now;

            // Pestaña empleados — nombres sin 's', igual que el Designer
            dtpInicioEmpleado.Value = DateTime.Now.AddMonths(-1);
            dtpFinEmpleado.Value = DateTime.Now;
            dtpInicioEmpleado.MaxDate = DateTime.Now;
            dtpFinEmpleado.MaxDate = DateTime.Now;
        }

        /// <summary>
        /// Configura el DataGridView de productos
        /// </summary>
        private void ConfigurarGridProductos()
        {
            dgvProductos.ReadOnly = true;
            dgvProductos.AllowUserToAddRows = false;
            dgvProductos.AllowUserToDeleteRows = false;
            dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductos.AutoGenerateColumns = false;
            dgvProductos.Columns.Clear();

            dgvProductos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Codigo",
                DataPropertyName = "Codigo",
                HeaderText = "CODIGO",
                Width = 120
            });

            dgvProductos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Nombre",
                DataPropertyName = "Nombre",
                HeaderText = "TÍTULO",
                Width = 250
            });

            dgvProductos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Descripcion",
                DataPropertyName = "Descripcion",
                HeaderText = "DESCRIPCIÓN",
                Width = 200
            });

            dgvProductos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Costo",
                DataPropertyName = "Costo",
                HeaderText = "COSTO",
                Width = 100,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "C2" }
            });

            dgvProductos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "UnidadesVendidas",
                DataPropertyName = "UnidadesVendidas",
                HeaderText = "UNIDADES VENDIDAS",
                Width = 150
            });

            dgvProductos.DataSource = listaProductos;
        }

        /// <summary>
        /// Configura el DataGridView de empleados
        /// </summary>
        private void ConfigurarGridEmpleados()
        {
            dgvEmpleados.ReadOnly = true;
            dgvEmpleados.AllowUserToAddRows = false;
            dgvEmpleados.AllowUserToDeleteRows = false;
            dgvEmpleados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmpleados.AutoGenerateColumns = false;
            dgvEmpleados.Columns.Clear();

            dgvEmpleados.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Clave",
                DataPropertyName = "Clave",
                HeaderText = "ID USUARIO",
                Width = 100
            });

            dgvEmpleados.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Nombre",
                DataPropertyName = "Nombre",
                HeaderText = "NOMBRE DE USUARIO",
                Width = 220
            });

            dgvEmpleados.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "MontoVendido",
                DataPropertyName = "MontoVendido",
                HeaderText = "MONTO VENDIDO",
                Width = 150,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "C2" }
            });

            dgvEmpleados.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "NumeroVentas",
                DataPropertyName = "NumeroVentas",
                HeaderText = "# VENTAS",
                Width = 100
            });

            dgvEmpleados.DataSource = listaEmpleados;
        }

        /// <summary>
        /// Genera el reporte de productos vendidos (registrado en el Designer)
        /// </summary>
        private void btnGenerarReporteProductos_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime fechaInicio = dtpInicioProductos.Value.Date;
                DateTime fechaFin = dtpFinProductos.Value.Date;

                if (fechaInicio > fechaFin)
                {
                    MessageBox.Show("La fecha de inicio no puede ser mayor a la fecha fin",
                        "Rango de fechas inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Cursor = Cursors.WaitCursor;
                lblEstadoProductos.Text = "Generando reporte...";
                lblEstadoProductos.ForeColor = System.Drawing.Color.Blue;

                var productos = reporteDAO.ObtenerReporteProductosVendidos(fechaInicio, fechaFin);

                listaProductos.Clear();
                foreach (var producto in productos)
                    listaProductos.Add(producto);

                int totalUnidades = productos.Sum(p => p.UnidadesVendidas);
                decimal totalVentas = productos.Sum(p => p.TotalVendido);

                lblEstadoProductos.Text = $"Productos encontrados: {productos.Count} | " +
                                          $"Total unidades: {totalUnidades} | " +
                                          $"Total ventas: {totalVentas:C2}";
                lblEstadoProductos.ForeColor = System.Drawing.Color.Green;

                if (productos.Count == 0)
                    MessageBox.Show("No se encontraron ventas en el rango seleccionado",
                        "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                lblEstadoProductos.Text = "Error al generar reporte";
                lblEstadoProductos.ForeColor = System.Drawing.Color.Red;
                MessageBox.Show($"Error al generar reporte de productos:\n{ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        /// <summary>
        /// Genera el reporte de ventas por empleado (registrado en el Designer)
        /// </summary>
        private void btnGenerarReporteEmpleados_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime fechaInicio = dtpInicioEmpleado.Value.Date;
                DateTime fechaFin = dtpFinEmpleado.Value.Date;

                if (fechaInicio > fechaFin)
                {
                    MessageBox.Show("La fecha de inicio no puede ser mayor a la fecha fin",
                        "Rango de fechas inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Cursor = Cursors.WaitCursor;
                lblEstadoEmpleados.Text = "Generando reporte...";
                lblEstadoEmpleados.ForeColor = System.Drawing.Color.Blue;

                var empleados = reporteDAO.ObtenerReporteVentasPorEmpleado(fechaInicio, fechaFin);

                listaEmpleados.Clear();
                foreach (var empleado in empleados)
                    listaEmpleados.Add(empleado);

                decimal totalVentas = empleados.Sum(e => e.MontoVendido);
                int totalOperaciones = empleados.Sum(e => e.NumeroVentas);

                lblEstadoEmpleados.Text = $"Usuarios con ventas: {empleados.Count} | " +
                                          $"Total ventas: {totalVentas:C2} | " +
                                          $"Total operaciones: {totalOperaciones}";
                lblEstadoEmpleados.ForeColor = System.Drawing.Color.Green;

                if (empleados.Count == 0)
                    MessageBox.Show("No se encontraron ventas en el rango seleccionado",
                        "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                lblEstadoEmpleados.Text = "Error al generar reporte";
                lblEstadoEmpleados.ForeColor = System.Drawing.Color.Red;
                MessageBox.Show($"Error al generar reporte de empleados:\n{ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        // Eventos ValueChanged de los DateTimePicker — requeridos por el Designer
        private void dtpInicioProductos_ValueChanged(object sender, EventArgs e) { }
        private void dtpFinProductos_ValueChanged(object sender, EventArgs e) { }
        private void dtpInicioEmpleado_ValueChanged(object sender, EventArgs e) { }
        private void dtpFinEmpleado_ValueChanged(object sender, EventArgs e) { }

        // Eventos CellContentClick de los DataGridView — requeridos por el Designer
        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void dgvEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
    }
}
