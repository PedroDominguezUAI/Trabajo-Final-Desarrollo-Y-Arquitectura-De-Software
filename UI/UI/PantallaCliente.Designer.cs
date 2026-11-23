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
            panel1.Name = "panel1";
            panel1.Size = new Size(1280, 45);
            panel1.TabIndex = 0;
            // 
            // lblBienvenida
            // 
            lblBienvenida.AutoSize = true;
            lblBienvenida.BackColor = Color.Transparent;
            lblBienvenida.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            lblBienvenida.ForeColor = Color.FromArgb(56, 189, 248);
            lblBienvenida.Location = new Point(24, 13);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(165, 19);
            lblBienvenida.TabIndex = 0;
            lblBienvenida.Text = "Portal de Cliente · SAC";
            // 
            // linkCerrarSesion
            // 
            linkCerrarSesion.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            linkCerrarSesion.AutoSize = true;
            linkCerrarSesion.BackColor = Color.Transparent;
            linkCerrarSesion.LinkColor = Color.FromArgb(226, 232, 240);
            linkCerrarSesion.Location = new Point(1150, 14);
            linkCerrarSesion.Name = "linkCerrarSesion";
            linkCerrarSesion.Size = new Size(95, 15);
            linkCerrarSesion.TabIndex = 1;
            linkCerrarSesion.TabStop = true;
            linkCerrarSesion.Text = "Cerrar Sesión";
            linkCerrarSesion.LinkClicked += linkCerrarSesion_LinkClicked;
            // 
            // lblTituloCompra
            // 
            lblTituloCompra.AutoSize = true;
            lblTituloCompra.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblTituloCompra.Location = new Point(24, 75);
            lblTituloCompra.Name = "lblTituloCompra";
            lblTituloCompra.Size = new Size(195, 28);
            lblTituloCompra.TabIndex = 1;
            lblTituloCompra.Text = "Comprar Entrada";
            // 
            // lblEvento
            // 
            lblEvento.AutoSize = true;
            lblEvento.Location = new Point(24, 118);
            lblEvento.Name = "lblEvento";
            lblEvento.Size = new Size(115, 15);
            lblEvento.TabIndex = 2;
            lblEvento.Text = "Seleccionar Evento:";
            // 
            // comboEvento
            // 
            comboEvento.DropDownStyle = ComboBoxStyle.DropDownList;
            comboEvento.FormattingEnabled = true;
            comboEvento.Location = new Point(24, 138);
            comboEvento.Name = "comboEvento";
            comboEvento.Size = new Size(290, 23);
            comboEvento.TabIndex = 3;
            comboEvento.SelectedIndexChanged += comboEvento_SelectedIndexChanged;
            // 
            // lblInfoEvento
            // 
            lblInfoEvento.AutoSize = true;
            lblInfoEvento.ForeColor = Color.FromArgb(71, 85, 105);
            lblInfoEvento.Location = new Point(24, 168);
            lblInfoEvento.Name = "lblInfoEvento";
            lblInfoEvento.Size = new Size(180, 15);
            lblInfoEvento.TabIndex = 4;
            lblInfoEvento.Text = "Estadio: - | Fecha: -";
            // 
            // lblSector
            // 
            lblSector.AutoSize = true;
            lblSector.Location = new Point(24, 204);
            lblSector.Name = "lblSector";
            lblSector.Size = new Size(112, 15);
            lblSector.TabIndex = 5;
            lblSector.Text = "Seleccionar Sector:";
            // 
            // comboSector
            // 
            comboSector.DropDownStyle = ComboBoxStyle.DropDownList;
            comboSector.FormattingEnabled = true;
            comboSector.Items.AddRange(new object[] { "Campo", "Platea baja sur", "Platea baja norte", "Platea media sur", "Platea media norte", "Platea alta sur", "Platea alta norte" });
            comboSector.Location = new Point(24, 224);
            comboSector.Name = "comboSector";
            comboSector.Size = new Size(290, 23);
            comboSector.TabIndex = 6;
            comboSector.SelectedIndexChanged += comboSector_SelectedIndexChanged;
            // 
            // lblAsiento
            // 
            lblAsiento.AutoSize = true;
            lblAsiento.Location = new Point(24, 266);
            lblAsiento.Name = "lblAsiento";
            lblAsiento.Size = new Size(95, 15);
            lblAsiento.TabIndex = 7;
            lblAsiento.Text = "Asiento deseado:";
            // 
            // txtAsiento
            // 
            txtAsiento.Location = new Point(24, 286);
            txtAsiento.Name = "txtAsiento";
            txtAsiento.PlaceholderText = "Ej: A-15";
            txtAsiento.Size = new Size(290, 23);
            txtAsiento.TabIndex = 8;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(24, 328);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(115, 15);
            lblPrecio.TabIndex = 9;
            lblPrecio.Text = "Precio de la entrada:";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(24, 348);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.ReadOnly = true;
            txtPrecio.Size = new Size(290, 23);
            txtPrecio.TabIndex = 10;
            // 
            // btnComprar
            // 
            btnComprar.Location = new Point(24, 405);
            btnComprar.Name = "btnComprar";
            btnComprar.Size = new Size(290, 44);
            btnComprar.TabIndex = 11;
            btnComprar.Text = "Agregar / Comprar Entrada";
            btnComprar.UseVisualStyleBackColor = true;
            btnComprar.Click += btnComprar_Click;
            // 
            // lblTituloTabla
            // 
            lblTituloTabla.AutoSize = true;
            lblTituloTabla.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblTituloTabla.Location = new Point(360, 75);
            lblTituloTabla.Name = "lblTituloTabla";
            lblTituloTabla.Size = new Size(150, 28);
            lblTituloTabla.TabIndex = 12;
            lblTituloTabla.Text = "Mis Entradas";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(360, 118);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(895, 535);
            dataGridView1.TabIndex = 13;
            // 
            // PantallaCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 680);
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