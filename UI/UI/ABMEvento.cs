using BLL;
using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UI
{
    public partial class ABMEvento : Form
    {
        EventoBusiness eventoBusiness = new EventoBusiness();

        public ABMEvento()
        {
            InitializeComponent();
        }

        private void ABMEvento_Load(object sender, EventArgs e)
        {
            try
            {
                UiTheme.AplicarTema(this, "ABM Evento");
                dataGridView1.CellClick += dataGridView1_CellClick;

                List<EstadioEntity> estadios = eventoBusiness.ObtenerEstadios();

                comboEstadioAgregar.DataSource = new List<EstadioEntity>(estadios);
                comboEstadioAgregar.DisplayMember = "Nombre";
                comboEstadioAgregar.ValueMember = "IdEstadio";

                comboBox1.DataSource = new List<EstadioEntity>(estadios);
                comboBox1.DisplayMember = "Nombre";
                comboBox1.ValueMember = "IdEstadio";

                button1.Enabled = false;

                Actualizar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridView1.Rows[e.RowIndex].Cells[0].Value != null)
            {
                string id = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString()!;
                txtIdEvento.Text = id;
                txtIdEliminarEvento.Text = id;
                btnBuscarEvento_Click(sender!, EventArgs.Empty);
            }
        }

        public void Actualizar()
        {
            try
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = eventoBusiness.ObtenerTodos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAgregarEvento_Click(object sender, EventArgs e)
        {
            try
            {
                EventoEntity evento = new EventoEntity();
                evento.NombreEvento = txtEventoAgregar.Text;
                evento.FechaEvento = dtpFechaAgregar.Value;
                evento.Estadio = (EstadioEntity)comboEstadioAgregar.SelectedItem!;

                eventoBusiness.Guardar(evento);
                Actualizar();
                txtEventoAgregar.Clear();
                MessageBox.Show("Evento agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBuscarEvento_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtIdEvento.Text, out int idBuscado))
                {
                    MessageBox.Show("Ingrese un ID numérico válido.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                EventoEntity evento = eventoBusiness.ObtenerPorId(idBuscado);
                if (evento != null)
                {
                    txtNombreModificar.Text = evento.NombreEvento;
                    dateTimePicker1.Value = evento.FechaEvento;
                    if (evento.Estadio != null)
                        comboBox1.SelectedValue = evento.Estadio.IdEstadio;
                    txtIdEvento.ReadOnly = true;
                    button1.Enabled = true;
                }
                else
                {
                    MessageBox.Show("No se encontró ningún evento con ese ID.", "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtIdEvento.Text, out int idModificar))
                {
                    MessageBox.Show("Ingrese un ID numérico válido.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                EventoEntity evento = new EventoEntity();
                evento.IdEvento = idModificar;
                evento.NombreEvento = txtNombreModificar.Text;
                evento.FechaEvento = dateTimePicker1.Value;
                evento.Estadio = (EstadioEntity)comboBox1.SelectedItem!;

                eventoBusiness.Modificar(evento);
                Actualizar();
                button1.Enabled = false;
                txtNombreModificar.Clear();
                txtIdEvento.Clear();
                txtIdEvento.ReadOnly = false;
                MessageBox.Show("Evento modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEleminarEvento_Click(object sender, EventArgs e)
        {
            try
            {

                if (!int.TryParse(txtIdEliminarEvento.Text, out int idEliminar))
                {
                    MessageBox.Show("Ingrese un ID numérico válido.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var confirmar = MessageBox.Show($"¿Seguro que desea eliminar el evento ID {idEliminar}?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmar != DialogResult.Yes) return;

                eventoBusiness.Eliminar(idEliminar);
                Actualizar();
                txtIdEliminarEvento.Clear();
                txtIdEvento.Clear();
                MessageBox.Show("Evento eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void linkVolver_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Form1 formAbrir = new Form1();
                this.Hide();
                formAbrir.Show();
                formAbrir.FormClosed += (s, args) => this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                ABMEstadio formAbrir = new ABMEstadio();
                this.Hide();
                formAbrir.Show();
                formAbrir.FormClosed += (s, args) => this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                ABMUsuario formAbrir = new ABMUsuario();
                this.Hide();
                formAbrir.Show();
                formAbrir.FormClosed += (s, args) => this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Actualizar();
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