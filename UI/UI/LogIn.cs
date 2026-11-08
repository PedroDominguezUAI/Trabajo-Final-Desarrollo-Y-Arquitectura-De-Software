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
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }
        UsuarioBusiness uBusieness = new UsuarioBusiness();

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                UsuarioEntity usuarioLogueado = uBusieness.LogIn(textBox1.Text, textBox2.Text);

                if (usuarioLogueado != null)
                { 
                    if (usuarioLogueado.TipoUsuario.Descripcion == "Admin")
                    { 
                        MessageBox.Show($"Bienvenido Administrador {usuarioLogueado.Nombre}");
                        Form1 form1 = new Form1();
                        form1.FormClosed += (s, args) => this.Close();
                        form1.Show();
                    }
                    else if (usuarioLogueado.TipoUsuario.Descripcion == "Cliente")
                    {
                        PantallaCliente form2 = new PantallaCliente();
                        form2.FormClosed += (s, args) => this.Close();
                        form2.Show();
                        MessageBox.Show($"Bienvenido Cliente {usuarioLogueado.Nombre}");
                    }

                    this.Hide(); 
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos.", "Error de acceso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar iniciar sesión: " + ex.Message);
            }
        }
    }
}
