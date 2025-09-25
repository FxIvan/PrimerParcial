using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PrimerParcial.Cliente;

namespace PrimerParcial
{
    public partial class Form1 : Form
    {

        private readonly GimnasioManager _manager = new GimnasioManager();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // ---------- BOTONES DE CLIENTE ----------
        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                // Validaciones básicas
                if (!int.TryParse(txtNumeroDeSocio.Text.Trim(), out int nro)) throw new Exception("N° de socio inválido.");
                if (string.IsNullOrWhiteSpace(txtNombre.Text)) throw new Exception("Ingrese nombre.");
                if (string.IsNullOrWhiteSpace(txtApellido.Text)) throw new Exception("Ingrese apellido.");
                if (string.IsNullOrWhiteSpace(txtDNI.Text)) throw new Exception("Ingrese DNI.");
                if (!decimal.TryParse(txtCuota.Text.Trim(), out decimal cuota)) throw new Exception("Cuota inválida.");
                if (cmbTipoDeCliente.SelectedItem == null) throw new Exception("Seleccione tipo de cliente.");

                var tipoCliente = cmbTipoDeCliente.SelectedItem?.ToString();

                Cliente cliente;
                switch (tipoCliente)
                {
                    case "Principiante":
                        cliente = new ClientePrincipiante();
                        break;
                    case "Intermedio":
                        cliente = new ClienteIntermedio();
                        break;
                    case "Avanzado":
                        cliente = new ClienteAvanzado();
                        break;
                    default:
                        throw new Exception("Tipo de cliente inválido");
                }

                cliente.NumeroDeSocio = nro;
                cliente.Nombre = txtNombre.Text.Trim();
                cliente.Apellido = txtApellido.Text.Trim();
                cliente.DNI = txtDNI.Text.Trim();
                cliente.Cuota = cuota;

                _manager.AgregarCliente(cliente);

                RefrescarGrillasDesdeDatos();
                LimpiarCamposCliente();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo agregar el cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificarCliente_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtNumeroDeSocio.Text.Trim(), out int nro)) throw new Exception("N° de socio inválido.");
                if (string.IsNullOrWhiteSpace(txtNombre.Text)) throw new Exception("Ingrese nombre.");
                if (string.IsNullOrWhiteSpace(txtApellido.Text)) throw new Exception("Ingrese apellido.");
                if (string.IsNullOrWhiteSpace(txtDNI.Text)) throw new Exception("Ingrese DNI.");
                if (!decimal.TryParse(txtCuota.Text.Trim(), out decimal cuota)) throw new Exception("Cuota inválida.");
                if (cmbTipoDeCliente.SelectedItem == null) throw new Exception("Seleccione tipo de cliente.");

                var tipoCliente = cmbTipoDeCliente.SelectedItem?.ToString();
                Cliente nuevo;
                switch (tipoCliente)
                {
                    case "Principiante":
                        nuevo = new ClientePrincipiante();
                        break;
                    case "Intermedio":
                        nuevo = new ClienteIntermedio();
                        break;
                    case "Avanzado":
                        nuevo = new ClienteAvanzado();
                        break;
                    default:
                        throw new Exception("Tipo de cliente inválido");
                }

                nuevo.NumeroDeSocio = nro;
                nuevo.Nombre = txtNombre.Text.Trim();
                nuevo.Apellido = txtApellido.Text.Trim();
                nuevo.DNI = txtDNI.Text.Trim();
                nuevo.Cuota = cuota;

                _manager.ModificarCliente(nro, nuevo);

                RefrescarGrillasDesdeDatos();
                LimpiarCamposCliente();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo modificar el cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminarCliente_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtNumeroDeSocio.Text.Trim(), out int nro)) throw new Exception("N° de socio inválido.");
                _manager.EliminarCliente(nro);
                RefrescarGrillasDesdeDatos();
                LimpiarCamposCliente();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo eliminar el cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ---------- BOTONES DE MEMBRESIA ----------
        private void btnAsignarMembresia_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtNumeroDeSocio.Text.Trim(), out int nroSocio)) throw new Exception("Seleccione o ingrese N° de socio.");
                string codigo = txtCodigoDeLaMembresia.Text.Trim();
                if (!decimal.TryParse(txtImporteDescuento.Text.Trim(), out decimal importe)) throw new Exception("Importe inválido.");
                DateTime fecha = dtpFechaOtorgamiento.Value.Date;

                // Validar codigo
                if (!Membresia.ValidarCodigo(codigo, fecha, out string error))
                    throw new Exception("Código inválido: " + error);

                // Intento crear y asignar (el manager disparará evento si excede)
                _manager.CrearYAsignarMembresiaACliente(codigo, fecha, importe, nroSocio);

                // Si llegamos acá y la membresía fue agregada (buscar en el repositorio)
                var mem = _manager.Membresias.FirstOrDefault(m => m.Codigo == codigo);
                if (mem != null)
                {
                    RefrescarGrillasDesdeDatos();
                    LimpiarCamposMembresia();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo asignar la membresía: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnQuitarMembresia_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtNumeroDeSocio.Text.Trim(), out int nroSocio)) throw new Exception("Seleccione o ingrese N° de socio.");
                _manager.QuitarMembresiaDeCliente(nroSocio);
                RefrescarGrillasDesdeDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo quitar la membresía: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ---------- OTROS BOTONES ----------
        private void btnRefrescarDatos_Click(object sender, EventArgs e)
        {
            RefrescarGrillasDesdeDatos();
        }

        private void btnMostrarTodo_Click_1(object sender, EventArgs e)
        {
            RefrescarGrillasDesdeDatos(); // ya muestra todo en nuestras grillas
        }

        // ---------- AYUDANTES ----------
        private void RefrescarGrillasDesdeDatos()
        {
            // Grilla 1: Clientes
            dgrGrilla1.Rows.Clear();
            foreach (var c in _manager.Clientes.OrderBy(x => x.NumeroDeSocio))
            {
                dgrGrilla1.Rows.Add(c.NumeroDeSocio, c.Nombre, c.Apellido, c.DNI, c.Cuota);
            }

            // Grilla 2: Membresias (mostramos todas las creadas en repositorio)
            dgrGrilla2.Rows.Clear();
            foreach (var m in _manager.Membresias)
            {
                dgrGrilla2.Rows.Add(m.Codigo, m.FechaOtorgamiento.ToString("dd/MM/yyyy"), m.Importe);
            }

            // Grilla 3: Resumen por cliente
            dgrResumen.Rows.Clear();
            foreach (var c in _manager.Clientes.OrderBy(x => x.NumeroDeSocio))
            {
                string tieneMembresia = c.Membresia != null ? c.Membresia.Codigo : "";
                decimal importeMembresia = c.Membresia?.Importe ?? 0m;
                decimal importeDescuentoTipo = c.ImporteDescuentoPorTipo();
                decimal neto = c.CalcularNeto();

                dgrResumen.Rows.Add(
                    c.NumeroDeSocio,
                    c.Nombre,
                    c.Apellido,
                    c.DNI,
                    c.Cuota,
                    Math.Round(importeDescuentoTipo, 2),
                    Math.Round(importeMembresia, 2),
                    tieneMembresia,
                    Math.Round(neto, 2)
                );
            }
        }

        private void LimpiarCamposCliente()
        {
            txtNumeroDeSocio.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDNI.Text = "";
            txtCuota.Text = "";
            cmbTipoDeCliente.SelectedIndex = 0;
        }

        private void LimpiarCamposMembresia()
        {
            txtCodigoDeLaMembresia.Text = "";
            txtImporteDescuento.Text = "";
            dtpFechaOtorgamiento.Value = DateTime.Today;
        }

        // Cuando el usuario haga clic en una fila de dgrGrilla1, cargo los campos para modificar rápido
        private void dgrGrilla1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0) return;
                var row = dgrGrilla1.Rows[e.RowIndex];
                txtNumeroDeSocio.Text = row.Cells["NroDeSocio"].Value?.ToString();
                txtNombre.Text = row.Cells["Nombre"].Value?.ToString();
                txtApellido.Text = row.Cells["Apellido"].Value?.ToString();
                txtDNI.Text = row.Cells["DNI"].Value?.ToString();
                txtCuota.Text = row.Cells["Cuota"].Value?.ToString();

                // Seleccionar tipo de cliente basado en lista _manager.Clientes
                if (int.TryParse(txtNumeroDeSocio.Text, out int nro))
                {
                    var cli = _manager.Clientes.FirstOrDefault(c => c.NumeroDeSocio == nro);
                    if (cli != null)
                    {
                        if (cli is ClientePrincipiante) cmbTipoDeCliente.SelectedItem = "Principiante";
                        else if (cli is ClienteIntermedio) cmbTipoDeCliente.SelectedItem = "Intermedio";
                        else if (cli is ClienteAvanzado) cmbTipoDeCliente.SelectedItem = "Avanzado";

                        // Si tiene membresía, mostrar sus datos
                        if (cli.Membresia != null)
                        {
                            txtCodigoDeLaMembresia.Text = cli.Membresia.Codigo;
                            txtImporteDescuento.Text = cli.Membresia.Importe.ToString();
                            dtpFechaOtorgamiento.Value = cli.Membresia.FechaOtorgamiento;
                        }
                        else
                        {
                            LimpiarCamposMembresia();
                        }
                    }
                }
            }
            catch
            {
                
            }
        }
    }
}
