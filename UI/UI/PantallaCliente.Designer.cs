namespace UI
{
    partial class PantallaCliente
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            panel1 = new Panel();
            lblBienvenida = new Label();
            linkCerrarSesion = new LinkLabel();
            lblTituloCompra = new Label();
            lblEvento = new Label();
            comboEvento = new ComboBox();
            lblInfoEvento = new Label();
            lblSector = new Label();
            comboSector = new ComboBox();
            lblAsiento = new Label();
            txtAsiento = new TextBox();
            lblPrecio = new Label();
            txtPrecio = new TextBox();
            btnComprar = new Button();
            lblTituloTabla = new Label();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 41, 59);
            panel1.Controls.Add(lblBienvenida);
            panel1.Controls.Add(linkCerrarSesion);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1463, 60);
            panel1.TabIndex = 0;
            // 
            // lblBienvenida
            // 
            lblBienvenida.AutoSize = true;
            lblBienvenida.BackColor = Color.Transparent;
            lblBienvenida.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            lblBienvenida.ForeColor = Color.FromArgb(56, 189, 248);
            lblBienvenida.Location = new Point(27, 17);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(202, 25);
            lblBienvenida.TabIndex = 0;
            lblBienvenida.Text = "Portal de Cliente · SAC";
            // 
            // linkCerrarSesion
            // 
            linkCerrarSesion.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            linkCerrarSesion.AutoSize = true;
            linkCerrarSesion.BackColor = Color.Transparent;
            linkCerrarSesion.LinkColor = Color.FromArgb(226, 232, 240);
            linkCerrarSesion.Location = new Point(1338, 19);
            linkCerrarSesion.Name = "linkCerrarSesion";
            linkCerrarSesion.Size = new Size(96, 20);
            linkCerrarSesion.TabIndex = 1;
            linkCerrarSesion.TabStop = true;
            linkCerrarSesion.Text = "Cerrar Sesión";
            linkCerrarSesion.LinkClicked += linkCerrarSesion_LinkClicked;
            // 
            // lblTituloCompra
            // 
            lblTituloCompra.AutoSize = true;
            lblTituloCompra.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblTituloCompra.Location = new Point(27, 100);
            lblTituloCompra.Name = "lblTituloCompra";
            lblTituloCompra.Size = new Size(214, 35);
            lblTituloCompra.TabIndex = 1;
            lblTituloCompra.Text = "Comprar Entrada";
            lblTituloCompra.Visible = false;
            // 
            // lblEvento
            // 
            lblEvento.AutoSize = true;
            lblEvento.Location = new Point(27, 157);
            lblEvento.Name = "lblEvento";
            lblEvento.Size = new Size(137, 20);
            lblEvento.TabIndex = 2;
            lblEvento.Text = "Seleccionar Evento:";
            lblEvento.Visible = false;
            // 
            // comboEvento
            // 
            comboEvento.DropDownStyle = ComboBoxStyle.DropDownList;
            comboEvento.FormattingEnabled = true;
            comboEvento.Location = new Point(27, 184);
            comboEvento.Margin = new Padding(3, 4, 3, 4);
            comboEvento.Name = "comboEvento";
            comboEvento.Size = new Size(331, 28);
            comboEvento.TabIndex = 3;
            comboEvento.Visible = false;
            comboEvento.SelectedIndexChanged += comboEvento_SelectedIndexChanged;
            // 
            // lblInfoEvento
            // 
            lblInfoEvento.AutoSize = true;
            lblInfoEvento.ForeColor = Color.FromArgb(71, 85, 105);
            lblInfoEvento.Location = new Point(27, 224);
            lblInfoEvento.Name = "lblInfoEvento";
            lblInfoEvento.Size = new Size(134, 20);
            lblInfoEvento.TabIndex = 4;
            lblInfoEvento.Text = "Estadio: - | Fecha: -";
            lblInfoEvento.Visible = false;
            // 
            // lblSector
            // 
            lblSector.AutoSize = true;
            lblSector.Location = new Point(27, 272);
            lblSector.Name = "lblSector";
            lblSector.Size = new Size(134, 20);
            lblSector.TabIndex = 5;
            lblSector.Text = "Seleccionar Sector:";
            lblSector.Visible = false;
            // 
            // comboSector
            // 
            comboSector.DropDownStyle = ComboBoxStyle.DropDownList;
            comboSector.FormattingEnabled = true;
            comboSector.Items.AddRange(new object[] { "Campo", "Platea baja sur", "Platea baja norte", "Platea media sur", "Platea media norte", "Platea alta sur", "Platea alta norte" });
            comboSector.Location = new Point(27, 299);
            comboSector.Margin = new Padding(3, 4, 3, 4);
            comboSector.Name = "comboSector";
            comboSector.Size = new Size(331, 28);
            comboSector.TabIndex = 6;
            comboSector.Visible = false;
            comboSector.SelectedIndexChanged += comboSector_SelectedIndexChanged;
            // 
            // lblAsiento
            // 
            lblAsiento.AutoSize = true;
            lblAsiento.Location = new Point(27, 355);
            lblAsiento.Name = "lblAsiento";
            lblAsiento.Size = new Size(123, 20);
            lblAsiento.TabIndex = 7;
            lblAsiento.Text = "Asiento deseado:";
            lblAsiento.Visible = false;
            // 
            // txtAsiento
            // 
            txtAsiento.Location = new Point(27, 381);
            txtAsiento.Margin = new Padding(3, 4, 3, 4);
            txtAsiento.Name = "txtAsiento";
            txtAsiento.PlaceholderText = "Ej: A-15";
            txtAsiento.Size = new Size(331, 27);
            txtAsiento.TabIndex = 8;
            txtAsiento.Visible = false;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(27, 437);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(145, 20);
            lblPrecio.TabIndex = 9;
            lblPrecio.Text = "Precio de la entrada:";
            lblPrecio.Visible = false;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(27, 464);
            txtPrecio.Margin = new Padding(3, 4, 3, 4);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.ReadOnly = true;
            txtPrecio.Size = new Size(331, 27);
            txtPrecio.TabIndex = 10;
            txtPrecio.Visible = false;
            // 
            // btnComprar
            // 
            btnComprar.Location = new Point(27, 540);
            btnComprar.Margin = new Padding(3, 4, 3, 4);
            btnComprar.Name = "btnComprar";
            btnComprar.Size = new Size(331, 59);
            btnComprar.TabIndex = 11;
            btnComprar.Text = "Agregar / Comprar Entrada";
            btnComprar.UseVisualStyleBackColor = true;
            btnComprar.Visible = false;
            btnComprar.Click += btnComprar_Click;
            // 
            // lblTituloTabla
            // 
            lblTituloTabla.AutoSize = true;
            lblTituloTabla.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblTituloTabla.Location = new Point(411, 100);
            lblTituloTabla.Name = "lblTituloTabla";
            lblTituloTabla.Size = new Size(164, 35);
            lblTituloTabla.TabIndex = 12;
            lblTituloTabla.Text = "Mis Entradas";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(411, 157);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1023, 713);
            dataGridView1.TabIndex = 13;
            // 
            // PantallaCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1463, 907);
            Controls.Add(dataGridView1);
            Controls.Add(lblTituloTabla);
            Controls.Add(btnComprar);
            Controls.Add(txtPrecio);
            Controls.Add(lblPrecio);
            Controls.Add(txtAsiento);
            Controls.Add(lblAsiento);
            Controls.Add(comboSector);
            Controls.Add(lblSector);
            Controls.Add(lblInfoEvento);
            Controls.Add(comboEvento);
            Controls.Add(lblEvento);
            Controls.Add(lblTituloCompra);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "PantallaCliente";
            Text = "PantallaCliente";
            Load += PantallaCliente_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lblBienvenida;
        private LinkLabel linkCerrarSesion;
        private Label lblTituloCompra;
        private Label lblEvento;
        private ComboBox comboEvento;
        private Label lblInfoEvento;
        private Label lblSector;
        private ComboBox comboSector;
        private Label lblAsiento;
        private TextBox txtAsiento;
        private Label lblPrecio;
        private TextBox txtPrecio;
        private Button btnComprar;
        private Label lblTituloTabla;
        private DataGridView dataGridView1;
    }
}