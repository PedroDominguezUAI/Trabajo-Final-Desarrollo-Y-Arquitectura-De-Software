using BLL;
using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UI
{
    public partial class ABMEstadio : Form
    {
        public ABMEstadio()
        {
            InitializeComponent();
            UiTheme.AplicarEstiloNavLink(this);
        }
        EstadioBusiness eBusiness = new EstadioBusiness();

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //ESTADIO
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

        private void linkVolver_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //ENTRADA
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
            //USUARIO
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
            //EVENTO
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

        private void ABMEstadio_Load(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ALTA
            try
            {
                EstadioEntity estadioAlta = new EstadioEntity();
                estadioAlta.Nombre = textBox1.Text;
                estadioAlta.Direccion = textBox2.Text;
                estadioAlta.Capacidad = Convert.ToInt32(textBox3.Text);
                eBusiness.AgregarEstadio(estadioAlta);
                MessageBox.Show("Estadio Dado de Alta");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                Actualizar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
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
                throw;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Baja
            try
            {
                eBusiness.EliminarID(Convert.ToInt32(textBox8.Text));
                Actualizar();
                MessageBox.Show("Estadio Eliminado");
                textBox8.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Buscar para llenar
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
            //Modificar
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
    }
}
