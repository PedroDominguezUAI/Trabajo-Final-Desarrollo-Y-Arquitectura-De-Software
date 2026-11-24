using BLL;
using Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace UI
{
    public partial class PantallaCliente : Form
    {
        private readonly UsuarioEntity? _clienteActual;
        private readonly EntradaBusiness entradaBusiness = new EntradaBusiness();
        private readonly EventoBusiness eventoBusiness = new EventoBusiness();

        public PantallaCliente()
        {
            InitializeComponent();
        }

        public PantallaCliente(UsuarioEntity cliente) : this()
        {
            _clienteActual = cliente;
        }

        private void PantallaCliente_Load(object sender, EventArgs e)
        {
            try
            {
                UiTheme.AplicarTema(this, "Portal Cliente");

                if (_clienteActual != null)
                {
                    lblBienvenida.Text = $"SAC · Bienvenido, {_clienteActual.Nombre} {_clienteActual.Apellido}";
                    lblBienvenida.ForeColor = Color.FromArgb(56, 189, 248);
                }

                List<EventoEntity> eventos = eventoBusiness.ObtenerTodos();
                comboEvento.DataSource = eventos;
                comboEvento.DisplayMember = "NombreEvento";
                comboEvento.ValueMember = "IdEvento";

                if (comboSector.Items.Count > 0)
                    comboSector.SelectedIndex = 0;

                ActualizarMisEntradas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el portal: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizarMisEntradas()
        {
            try
            {
                var todas = entradaBusiness.getAll();
                if (_clienteActual != null)
                {
                    dataGridView1.DataSource = todas
                        .Where(x => x.Usuario != null && x.Usuario.IdUsuario == _clienteActual.IdUsuario)
                        .ToList();
                }
                else
                {
                    dataGridView1.DataSource = todas;
                }

                if (dataGridView1.Columns["Usuario"] != null)
                    dataGridView1.Columns["Usuario"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboEvento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboEvento.SelectedItem is EventoEntity ev)
            {
                string nombreEstadio = ev.Estadio != null ? ev.Estadio.Nombre : "Sin asignar";
                lblInfoEvento.Text = $"Estadio: {nombreEstadio}  |  Fecha: {ev.FechaEvento:dd/MM/yyyy HH:mm}";
            }
        }

        private void comboSector_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sector = comboSector.Text.ToLower();
            decimal precio = 15000m;

            if (sector.Contains("campo"))
                precio = 35000m;
            else if (sector.Contains("baja"))
                precio = 28000m;
            else if (sector.Contains("media"))
                precio = 20000m;

            txtPrecio.Text = precio.ToString("0");
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            try
            {
                if (_clienteActual == null)
                {
                    MessageBox.Show("No se detectó un cliente logueado.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (comboEvento.SelectedItem is not EventoEntity eventoSeleccionado)
                {
                    MessageBox.Show("Seleccione un evento.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtAsiento.Text))
                {
                    MessageBox.Show("Ingrese el asiento deseado (ej: A-15).", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                EntradaEntity nuevaEntrada = new EntradaEntity
                {
                    Evento = eventoSeleccionado,
                    Usuario = _clienteActual,
                    Sector = comboSector.Text,
                    Asiento = txtAsiento.Text.Trim(),
                    Precio = Convert.ToDecimal(txtPrecio.Text)
                };

                entradaBusiness.AgregarEntradaBLL(nuevaEntrada);
                ActualizarMisEntradas();
                txtAsiento.Clear();
                MessageBox.Show("¡Entrada adquirida con éxito!", "Compra confirmada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo completar la compra: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkCerrarSesion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LogIn login = new LogIn();
            this.Hide();
            login.Show();
            login.FormClosed += (s, args) => this.Close();
        }
    }
}