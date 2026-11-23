using BLL;
using Entity;
using Entity.EFModel;

namespace UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            UiTheme.AplicarEstiloNavLink(this);
        }
        EntradaBusiness entradaBusiness = new EntradaBusiness();
        UsuarioBusiness usuarioBusiness = new UsuarioBusiness();

        EventoBusiness eventoBusiness = new EventoBusiness();

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                comboUsuarioAgregar.DataSource = usuarioBusiness.getAll();
                comboUsuarioAgregar.DisplayMember = "NombreUsuario";
                comboUsuarioAgregar.ValueMember = "IdUsuario";
                comboUsuarioModificar.DataSource = usuarioBusiness.getAll();
                comboUsuarioModificar.DisplayMember = "NombreUsuario";
                comboUsuarioModificar.ValueMember = "IdUsuario";

                List<EventoEntity> eventos = eventoBusiness.ObtenerTodos();

                comboEventoAgregar.DataSource = new List<EventoEntity>(eventos);
                comboEventoAgregar.DisplayMember = "NombreEvento";
                comboEventoAgregar.ValueMember = "IdEvento";

                comboEventoModificar.DataSource = new List<EventoEntity>(eventos);
                comboEventoModificar.DisplayMember = "NombreEvento";
                comboEventoModificar.ValueMember = "IdEvento";

                comboSectorAgregar.SelectedIndex = 0;
                comboSectorModificar.SelectedIndex = 0;
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
                dataGridView1.DataSource = entradaBusiness.getAll();
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

        private void btnAgregarEntrada_Click(object sender, EventArgs e)
        {
            try
            {
                EntradaEntity entrada = new EntradaEntity();
                entrada.Evento = (EventoEntity)comboEventoAgregar.SelectedItem;
                entrada.Usuario = usuarioBusiness.buscarID(Convert.ToInt32(comboUsuarioAgregar.SelectedValue));
                entrada.Sector = comboSectorAgregar.Text;
                entrada.Asiento = txtAsientoAgregar.Text;
                entrada.Precio = Convert.ToDecimal(txtPrecioAgregar.Text);
                entradaBusiness.AgregarEntradaBLL(entrada);
                Actualizar();
                MessageBox.Show("Se ha agregado correctamente la entrada", "!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBuscarEntrada_Click(object sender, EventArgs e)
        {
            try
            {
                int IdSearch = Convert.ToInt32(txtIdModificar.Text);
                EntradaEntity entrada = entradaBusiness.ObtenerIdEntradaBLL(IdSearch);

                if (entrada.Evento != null)
                {
                    comboEventoModificar.SelectedValue = entrada.Evento.IdEvento;
                }

                if (entrada.Usuario != null)
                {
                    comboUsuarioModificar.SelectedValue = entrada.Usuario.IdUsuario;
                }
                else
                {
                    comboUsuarioModificar.SelectedIndex = -1;
                }
                comboSectorModificar.Text = entrada.Sector;
                txtAsientoModificar.Text = entrada.Asiento;
                txtPrecioModificar.Text = Convert.ToString(entrada.Precio);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnModificarEntrada_Click(object sender, EventArgs e)
        {
            try
            {
                EntradaEntity entrada = new EntradaEntity();
                entrada.IdEntrada = Convert.ToInt32(txtIdModificar.Text);
                entrada.Evento = (EventoEntity)comboEventoModificar.SelectedItem;
                entrada.Usuario = usuarioBusiness.buscarID(Convert.ToInt32(comboUsuarioModificar.SelectedValue));
                entrada.Sector = comboSectorModificar.Text;
                entrada.Asiento = txtAsientoModificar.Text;
                entrada.Precio = Convert.ToDecimal(txtPrecioModificar.Text);
                entradaBusiness.ModificarEntradaBLL(entrada);
                Actualizar();
                MessageBox.Show("Se ha actualizado correctamente la entrada", "!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                int IdEliminar = Convert.ToInt32(txtIdEliminar.Text);
                entradaBusiness.EliminarIDBLL(IdEliminar);
                Actualizar();
                MessageBox.Show("Se ha eliminado correctamente la entrada", "!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void linkVolver_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Entrada
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
            //Estadio
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
    }
}
