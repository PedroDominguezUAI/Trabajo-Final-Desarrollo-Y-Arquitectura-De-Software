using BLL;
using Entity;
using Entity.EFModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UI
{
    public partial class ABMUsuario : Form
    {
        public ABMUsuario()
        {
            InitializeComponent();
        }

        UsuarioBusiness uBusieness = new UsuarioBusiness();

        private void ABMUsuario_Load(object sender, EventArgs e)
        {
            try
            {
                UiTheme.AplicarTema(this, "ABM Usuario");
                dataGridView1.CellClick += dataGridView1_CellClick;
                button3.Enabled = false;
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
                dataGridView1.DataSource = uBusieness.getAll();

                if (dataGridView1.Columns["Password"] != null)
                    dataGridView1.Columns["Password"].Visible = false;
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
                UsuarioEntity usuario = new UsuarioEntity();
                TipoUsuarioEntity tipoUsuario = new TipoUsuarioEntity();
                usuario.NombreUsuario = textBox1.Text;
                usuario.Password = textBox2.Text;
                string RepetirContraseña = textBox3.Text;
                usuario.Nombre = textBox4.Text;
                usuario.Apellido = textBox5.Text;
                usuario.Dni = textBox6.Text;
                usuario.Email = textBox7.Text;
                tipoUsuario.IdTipo = 2;
                usuario.TipoUsuario = tipoUsuario;

                uBusieness.agregarUsuario(usuario, RepetirContraseña);

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
                textBox7.Clear();

                MessageBox.Show("Se ha agregado correctamente el usuario a la tabla.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                var confirmar = MessageBox.Show($"¿Seguro que desea eliminar el usuario ID {idEliminar}?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmar != DialogResult.Yes) return;

                uBusieness.eliminarUsuario(idEliminar);
                Actualizar();
                textBox8.Clear();
                textBox13.Clear();
                button3.Enabled = false;
                MessageBox.Show("Usuario eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(textBox13.Text, out int idModificar))
                {
                    UsuarioEntity usuarioAModificar = new UsuarioEntity
                    {
                        IdUsuario = idModificar,
                        NombreUsuario = textBox15.Text,
                        Password = textBox14.Text,
                        Nombre = textBox12.Text,
                        Email = textBox9.Text,
                        Apellido = textBox11.Text,
                        Dni = textBox10.Text
                    };
                    uBusieness.modificarUsuario(usuarioAModificar);
                    MessageBox.Show("Usuario modificado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    textBox15.Clear();
                    textBox14.Clear();
                    textBox12.Clear();
                    textBox9.Clear();
                    textBox11.Clear();
                    textBox10.Clear();
                    textBox13.Clear();
                    button3.Enabled = false;
                    Actualizar();
                }
                else
                {
                    MessageBox.Show("Debe buscar y cargar un usuario válido primero.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(textBox13.Text, out int idBuscado))
                {
                    UsuarioEntity usuarioAModificar = uBusieness.buscarID(idBuscado);

                    if (usuarioAModificar != null)
                    {
                        textBox15.Text = usuarioAModificar.NombreUsuario;
                        textBox14.Text = usuarioAModificar.Password;
                        textBox12.Text = usuarioAModificar.Nombre;
                        textBox9.Text = usuarioAModificar.Email;
                        textBox11.Text = usuarioAModificar.Apellido;
                        textBox10.Text = usuarioAModificar.Dni;
                        button3.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("No se encontró ningún usuario con ese ID.", "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese un número de ID válido.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar buscar el usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Actualizar();
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

        private void textBox6_TextChanged(object sender, EventArgs e) { }
        private void label8_Click(object sender, EventArgs e) { }
    }
}