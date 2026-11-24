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
    public partial class ABMEstadio : Form
    {
        public ABMEstadio()
        {
            InitializeComponent();
        }

        EstadioBusiness eBusiness = new EstadioBusiness();

        private void ABMEstadio_Load(object sender, EventArgs e)
        {
            UiTheme.AplicarTema(this, "ABM Estadio");
            dataGridView1.CellClick += dataGridView1_CellClick;
            Actualizar();
        }

        private void dataGridView1_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridView1.Rows[e.RowIndex].Cells[0].Value != null)
            {
                string id = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString()!;
                textBox13.Text = id;
                textBox8.Text = id;
                button4_Click(sender!, EventArgs.Empty);
            }
        }

        public void Actualizar()
        {
            try
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = eBusiness.getAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                EstadioEntity estadioAlta = new EstadioEntity();
                estadioAlta.Nombre = textBox1.Text;
                estadioAlta.Direccion = textBox2.Text;
                estadioAlta.Capacidad = Convert.ToInt32(textBox3.Text);
                eBusiness.AgregarEstadio(estadioAlta);
                MessageBox.Show("Estadio agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                Actualizar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(textBox8.Text, out int idEliminar))
                {
                    MessageBox.Show("Ingrese un ID numérico válido.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var confirmar = MessageBox.Show($"¿Seguro que desea eliminar el estadio ID {idEliminar}?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmar != DialogResult.Yes) return;

                eBusiness.EliminarID(idEliminar);
                Actualizar();
                textBox8.Clear();
                textBox13.Clear();
                MessageBox.Show("Estadio eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(textBox13.Text, out int idBuscado))
                {
                    EstadioEntity estadioModificar = eBusiness.ObtenerIdEstadio(idBuscado);

                    if (estadioModificar != null)
                    {
                        textBox15.Text = estadioModificar.Nombre;
                        textBox14.Text = estadioModificar.Direccion;
                        textBox12.Text = estadioModificar.Capacidad.ToString();
                    }
                    else
                    {
                        MessageBox.Show("No se encontró ningún estadio con ese ID.", "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese un número de ID válido.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar buscar el estadio: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(textBox13.Text, out int idModificar))
                {
                    EstadioEntity estadioModificar = new EstadioEntity
                    {
                        IdEstadio = idModificar,
                        Nombre = textBox15.Text,
                        Direccion = textBox14.Text,
                        Capacidad = Convert.ToInt32(textBox12.Text)
                    };
                    eBusiness.ModificarEstadio(estadioModificar);
                    MessageBox.Show("Estadio modificado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Actualizar();
                }
                else
                {
                    MessageBox.Show("Debe buscar y cargar un estadio válido primero.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Actualizar();
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
            try
            {
                ABMEvento formAbrir = new ABMEvento();
                this.Hide();
                formAbrir.Show();
                formAbrir.FormClosed += (s, args) => this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}