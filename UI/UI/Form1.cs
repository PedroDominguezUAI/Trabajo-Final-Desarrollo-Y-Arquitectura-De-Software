using BLL;

namespace UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        EntradaBusiness entradaBusiness = new EntradaBusiness();

        private void Form1_Load(object sender, EventArgs e)
        {
            try { Actualizar(); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        public void Actualizar()
        {
            try {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = entradaBusiness.getAll();
            } 
            catch (Exception ex) { 
                MessageBox.Show(ex.Message); 
            }
        }
    }
}
