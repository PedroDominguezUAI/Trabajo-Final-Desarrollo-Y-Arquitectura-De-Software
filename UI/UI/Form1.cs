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
        }

        EntradaBusiness entradaBusiness = new EntradaBusiness();
        UsuarioBusiness usuarioBusiness = new UsuarioBusiness();
        EventoBusiness eventoBusiness = new EventoBusiness();

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                UiTheme.AplicarTema(this, "ABM Entrada");
                dataGridView1.CellClick += dataGridView1_CellClick;

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

        private void dataGridView1_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridView1.Rows[e.RowIndex].Cells[0].Value != null)
            {
                string id = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString()!;
                txtIdModificar.Text = id;
                txtIdEliminar.Text = id;
                btnBuscarEntrada_Click(sender!, EventArgs.Empty);
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
                entrada.Evento = (EventoEntity)comboEventoAgregar.SelectedItem!;
                entrada.Usuario = usuarioBusiness.buscarID(Convert.ToInt32(comboUsuarioAgregar.SelectedValue));
                entrada.Sector = comboSectorAgregar.Text;
                entrada.Asiento = txtAsientoAgregar.Text;
                entrada.Precio = Convert.ToDecimal(txtPrecioAgregar.Text);
                entradaBusiness.AgregarEntradaBLL(entrada);
                Actualizar();
                txtAsientoAgregar.Clear();
                txtPrecioAgregar.Clear();
                MessageBox.Show("Entrada agregada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                if (!int.TryParse(txtIdModificar.Text, out int IdSearch))
                {
                    MessageBox.Show("Ingrese un ID numérico válido.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                EntradaEntity entrada = entradaBusiness.ObtenerIdEntradaBLL(IdSearch);
                if (entrada == null)
                {
                    MessageBox.Show("No se encontró ninguna entrada con ese ID.", "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (entrada.Evento != null)
                    comboEventoModificar.SelectedValue = entrada.Evento.IdEvento;

                if (entrada.Usuario != null)
                    comboUsuarioModificar.SelectedValue = entrada.Usuario.IdUsuario;
                else
                    comboUsuarioModificar.SelectedIndex = -1;

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
                if (!int.TryParse(txtIdModificar.Text, out int idModificar))
                {
                    MessageBox.Show("Ingrese un ID numérico válido.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                EntradaEntity entrada = new EntradaEntity();
                entrada.IdEntrada = idModificar;
                entrada.Evento = (EventoEntity)comboEventoModificar.SelectedItem!;
                entrada.Usuario = usuarioBusiness.buscarID(Convert.ToInt32(comboUsuarioModificar.SelectedValue));
                entrada.Sector = comboSectorModificar.Text;
                entrada.Asiento = txtAsientoModificar.Text;
                entrada.Precio = Convert.ToDecimal(txtPrecioModificar.Text);
                entradaBusiness.ModificarEntradaBLL(entrada);
                Actualizar();
                MessageBox.Show("Entrada actualizada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                if (!int.TryParse(txtIdEliminar.Text, out int IdEliminar))
                {
                    MessageBox.Show("Ingrese un ID numérico válido.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var confirmar = MessageBox.Show($"¿Seguro que desea eliminar la entrada ID {IdEliminar}?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmar != DialogResult.Yes) return;

                entradaBusiness.EliminarIDBLL(IdEliminar);
                Actualizar();
                txtIdEliminar.Clear();
                txtIdModificar.Clear();
                MessageBox.Show("Entrada eliminada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void linkVolver_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Actualizar();
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
    }
}