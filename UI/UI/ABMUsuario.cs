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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 formAbrir = new Form1();
            this.Hide();
            formAbrir.Show();
            formAbrir.FormClosed += (s, args) => this.Close();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UsuarioEntity usuario = new UsuarioEntity();
            TipoUsuarioEntity tipoUsuario = new TipoUsuarioEntity();
            usuario.NombreUsuario = textBox1.Text;
            usuario.Password = textBox2.Text;
            usuario.Nombre = textBox4.Text;
            usuario.Apellido = textBox5.Text;
            usuario.Dni = textBox6.Text;
            usuario.Email = textBox7.Text;
            tipoUsuario.IdTipo = 2;
            usuario.TipoUsuario = tipoUsuario;
            uBusieness.agregarUsuario(usuario);
            Actualizar();

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void ABMUsuario_Load(object sender, EventArgs e)
        {
            try
            {
                Actualizar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void Actualizar()
        {
            try
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = uBusieness.getAll();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                uBusieness.eliminarUsuario(Convert.ToInt32(textBox8.Text));
                Actualizar();
                MessageBox.Show("Usuario Eliminado");
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
    }
}
