namespace UI
{
    partial class Form1
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
            linkVolver = new LinkLabel();
            linkLabel1 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            linkLabel3 = new LinkLabel();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnAgregarEntrada = new Button();
            label7 = new Label();
            txtIdModificar = new TextBox();
            label8 = new Label();
            btnBuscarEntrada = new Button();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            btnModificarEntrada = new Button();
            label14 = new Label();
            button1 = new Button();
            txtIdEliminar = new TextBox();
            label15 = new Label();
            comboEventoAgregar = new ComboBox();
            comboUsuarioAgregar = new ComboBox();
            comboSectorAgregar = new ComboBox();
            txtAsientoAgregar = new TextBox();
            txtPrecioAgregar = new TextBox();
            comboUsuarioModificar = new ComboBox();
            comboSectorModificar = new ComboBox();
            txtAsientoModificar = new TextBox();
            txtPrecioModificar = new TextBox();
            comboEventoModificar = new ComboBox();
            linkCerrarSesion = new LinkLabel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 41, 59);
            panel1.Controls.Add(linkCerrarSesion);
            panel1.Controls.Add(linkVolver);
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(linkLabel2);
            panel1.Controls.Add(linkLabel3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1463, 60);
            panel1.TabIndex = 64;
            // 
            // linkVolver
            // 
            linkVolver.AutoSize = true;
            linkVolver.BackColor = Color.Transparent;
            linkVolver.LinkColor = SystemColors.ControlLightLight;
            linkVolver.Location = new Point(34, 19);
            linkVolver.Name = "linkVolver";
            linkVolver.Size = new Size(96, 20);
            linkVolver.TabIndex = 60;
            linkVolver.TabStop = true;
            linkVolver.Text = "ABM Entrada";
            linkVolver.LinkClicked += linkVolver_LinkClicked;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.Transparent;
            linkLabel1.LinkColor = SystemColors.ControlLightLight;
            linkLabel1.Location = new Point(189, 19);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(95, 20);
            linkLabel1.TabIndex = 2;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "ABM Usuario";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.BackColor = Color.Transparent;
            linkLabel2.LinkColor = SystemColors.ControlLightLight;
            linkLabel2.Location = new Point(343, 19);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(90, 20);
            linkLabel2.TabIndex = 35;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "ABM Evento";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // linkLabel3
            // 
            linkLabel3.AutoSize = true;
            linkLabel3.BackColor = Color.Transparent;
            linkLabel3.LinkColor = SystemColors.ControlLightLight;
            linkLabel3.Location = new Point(491, 19);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(94, 20);
            linkLabel3.TabIndex = 63;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "ABM Estadio";
            linkLabel3.LinkClicked += linkLabel3_LinkClicked;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(886, 100);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(549, 773);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.Location = new Point(27, 100);
            label1.Name = "label1";
            label1.Size = new Size(206, 35);
            label1.TabIndex = 3;
            label1.Text = "Agregar Entrada";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 149);
            label2.Name = "label2";
            label2.Size = new Size(137, 20);
            label2.TabIndex = 4;
            label2.Text = "Seleccionar evento:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 224);
            label3.Name = "label3";
            label3.Size = new Size(140, 20);
            label3.TabIndex = 5;
            label3.Text = "Seleccionar usuario:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 299);
            label4.Name = "label4";
            label4.Size = new Size(132, 20);
            label4.TabIndex = 6;
            label4.Text = "Seleccionar sector:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 373);
            label5.Name = "label5";
            label5.Size = new Size(118, 20);
            label5.TabIndex = 7;
            label5.Text = "Agregar asiento:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(27, 448);
            label6.Name = "label6";
            label6.Size = new Size(112, 20);
            label6.TabIndex = 8;
            label6.Text = "Agregar precio:";
            // 
            // btnAgregarEntrada
            // 
            btnAgregarEntrada.Location = new Point(27, 640);
            btnAgregarEntrada.Margin = new Padding(3, 4, 3, 4);
            btnAgregarEntrada.Name = "btnAgregarEntrada";
            btnAgregarEntrada.Size = new Size(251, 53);
            btnAgregarEntrada.TabIndex = 9;
            btnAgregarEntrada.Text = "Agregar Entrada";
            btnAgregarEntrada.UseVisualStyleBackColor = true;
            btnAgregarEntrada.Click += btnAgregarEntrada_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label7.Location = new Point(314, 100);
            label7.Name = "label7";
            label7.Size = new Size(224, 35);
            label7.TabIndex = 15;
            label7.Text = "Modificar Entrada";
            // 
            // txtIdModificar
            // 
            txtIdModificar.Location = new Point(314, 176);
            txtIdModificar.Margin = new Padding(3, 4, 3, 4);
            txtIdModificar.Name = "txtIdModificar";
            txtIdModificar.Size = new Size(251, 27);
            txtIdModificar.TabIndex = 18;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(314, 149);
            label8.Name = "label8";
            label8.Size = new Size(183, 20);
            label8.TabIndex = 17;
            label8.Text = "ID de entrada a modificar:";
            // 
            // btnBuscarEntrada
            // 
            btnBuscarEntrada.Location = new Point(314, 220);
            btnBuscarEntrada.Margin = new Padding(3, 4, 3, 4);
            btnBuscarEntrada.Name = "btnBuscarEntrada";
            btnBuscarEntrada.Size = new Size(251, 48);
            btnBuscarEntrada.TabIndex = 19;
            btnBuscarEntrada.Text = "Buscar Entrada";
            btnBuscarEntrada.UseVisualStyleBackColor = true;
            btnBuscarEntrada.Click += btnBuscarEntrada_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(314, 549);
            label9.Name = "label9";
            label9.Size = new Size(122, 20);
            label9.TabIndex = 24;
            label9.Text = "Modificar precio:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(314, 483);
            label10.Name = "label10";
            label10.Size = new Size(128, 20);
            label10.TabIndex = 23;
            label10.Text = "Modificar asiento:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(314, 416);
            label11.Name = "label11";
            label11.Size = new Size(120, 20);
            label11.TabIndex = 22;
            label11.Text = "Modificar sector:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(314, 349);
            label12.Name = "label12";
            label12.Size = new Size(128, 20);
            label12.TabIndex = 21;
            label12.Text = "Modificar usuario:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(314, 283);
            label13.Name = "label13";
            label13.Size = new Size(125, 20);
            label13.TabIndex = 20;
            label13.Text = "Modificar evento:";
            // 
            // btnModificarEntrada
            // 
            btnModificarEntrada.Location = new Point(314, 640);
            btnModificarEntrada.Margin = new Padding(3, 4, 3, 4);
            btnModificarEntrada.Name = "btnModificarEntrada";
            btnModificarEntrada.Size = new Size(251, 53);
            btnModificarEntrada.TabIndex = 30;
            btnModificarEntrada.Text = "Modificar Entrada";
            btnModificarEntrada.UseVisualStyleBackColor = true;
            btnModificarEntrada.Click += btnModificarEntrada_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label14.Location = new Point(601, 100);
            label14.Name = "label14";
            label14.Size = new Size(206, 35);
            label14.TabIndex = 31;
            label14.Text = "Eliminar Entrada";
            // 
            // button1
            // 
            button1.Location = new Point(601, 220);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(251, 48);
            button1.TabIndex = 34;
            button1.Text = "Eliminar Entrada";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtIdEliminar
            // 
            txtIdEliminar.Location = new Point(601, 176);
            txtIdEliminar.Margin = new Padding(3, 4, 3, 4);
            txtIdEliminar.Name = "txtIdEliminar";
            txtIdEliminar.Size = new Size(251, 27);
            txtIdEliminar.TabIndex = 33;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(601, 149);
            label15.Name = "label15";
            label15.Size = new Size(173, 20);
            label15.TabIndex = 32;
            label15.Text = "ID de entrada a eliminar:";
            // 
            // comboEventoAgregar
            // 
            comboEventoAgregar.DropDownStyle = ComboBoxStyle.DropDownList;
            comboEventoAgregar.FormattingEnabled = true;
            comboEventoAgregar.Location = new Point(27, 176);
            comboEventoAgregar.Margin = new Padding(3, 4, 3, 4);
            comboEventoAgregar.Name = "comboEventoAgregar";
            comboEventoAgregar.Size = new Size(251, 28);
            comboEventoAgregar.TabIndex = 10;
            // 
            // comboUsuarioAgregar
            // 
            comboUsuarioAgregar.DropDownStyle = ComboBoxStyle.DropDownList;
            comboUsuarioAgregar.FormattingEnabled = true;
            comboUsuarioAgregar.Location = new Point(27, 251);
            comboUsuarioAgregar.Margin = new Padding(3, 4, 3, 4);
            comboUsuarioAgregar.Name = "comboUsuarioAgregar";
            comboUsuarioAgregar.Size = new Size(251, 28);
            comboUsuarioAgregar.TabIndex = 11;
            // 
            // comboSectorAgregar
            // 
            comboSectorAgregar.DropDownStyle = ComboBoxStyle.DropDownList;
            comboSectorAgregar.FormattingEnabled = true;
            comboSectorAgregar.Items.AddRange(new object[] { "Platea alta sur", "Platea media sur", "Platea baja sur", "Platea alta norte", "Platea media norte", "Platea baja norte", "Campo" });
            comboSectorAgregar.Location = new Point(27, 325);
            comboSectorAgregar.Margin = new Padding(3, 4, 3, 4);
            comboSectorAgregar.Name = "comboSectorAgregar";
            comboSectorAgregar.Size = new Size(251, 28);
            comboSectorAgregar.TabIndex = 12;
            // 
            // txtAsientoAgregar
            // 
            txtAsientoAgregar.Location = new Point(27, 400);
            txtAsientoAgregar.Margin = new Padding(3, 4, 3, 4);
            txtAsientoAgregar.Name = "txtAsientoAgregar";
            txtAsientoAgregar.Size = new Size(251, 27);
            txtAsientoAgregar.TabIndex = 13;
            // 
            // txtPrecioAgregar
            // 
            txtPrecioAgregar.Location = new Point(27, 475);
            txtPrecioAgregar.Margin = new Padding(3, 4, 3, 4);
            txtPrecioAgregar.Name = "txtPrecioAgregar";
            txtPrecioAgregar.Size = new Size(251, 27);
            txtPrecioAgregar.TabIndex = 16;
            // 
            // comboUsuarioModificar
            // 
            comboUsuarioModificar.DropDownStyle = ComboBoxStyle.DropDownList;
            comboUsuarioModificar.FormattingEnabled = true;
            comboUsuarioModificar.Location = new Point(314, 373);
            comboUsuarioModificar.Margin = new Padding(3, 4, 3, 4);
            comboUsuarioModificar.Name = "comboUsuarioModificar";
            comboUsuarioModificar.Size = new Size(251, 28);
            comboUsuarioModificar.TabIndex = 26;
            // 
            // comboSectorModificar
            // 
            comboSectorModificar.DropDownStyle = ComboBoxStyle.DropDownList;
            comboSectorModificar.FormattingEnabled = true;
            comboSectorModificar.Items.AddRange(new object[] { "Platea alta sur", "Platea media sur", "Platea baja sur", "Platea alta norte", "Platea media norte", "Platea baja norte", "Campo" });
            comboSectorModificar.Location = new Point(314, 440);
            comboSectorModificar.Margin = new Padding(3, 4, 3, 4);
            comboSectorModificar.Name = "comboSectorModificar";
            comboSectorModificar.Size = new Size(251, 28);
            comboSectorModificar.TabIndex = 27;
            // 
            // txtAsientoModificar
            // 
            txtAsientoModificar.Location = new Point(314, 507);
            txtAsientoModificar.Margin = new Padding(3, 4, 3, 4);
            txtAsientoModificar.Name = "txtAsientoModificar";
            txtAsientoModificar.Size = new Size(251, 27);
            txtAsientoModificar.TabIndex = 28;
            // 
            // txtPrecioModificar
            // 
            txtPrecioModificar.Location = new Point(314, 573);
            txtPrecioModificar.Margin = new Padding(3, 4, 3, 4);
            txtPrecioModificar.Name = "txtPrecioModificar";
            txtPrecioModificar.Size = new Size(251, 27);
            txtPrecioModificar.TabIndex = 29;
            // 
            // comboEventoModificar
            // 
            comboEventoModificar.DropDownStyle = ComboBoxStyle.DropDownList;
            comboEventoModificar.FormattingEnabled = true;
            comboEventoModificar.Location = new Point(314, 307);
            comboEventoModificar.Margin = new Padding(3, 4, 3, 4);
            comboEventoModificar.Name = "comboEventoModificar";
            comboEventoModificar.Size = new Size(251, 28);
            comboEventoModificar.TabIndex = 25;
            // 
            // linkCerrarSesion
            // 
            linkCerrarSesion.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            linkCerrarSesion.AutoSize = true;
            linkCerrarSesion.BackColor = Color.Transparent;
            linkCerrarSesion.LinkColor = Color.FromArgb(226, 232, 240);
            linkCerrarSesion.Location = new Point(1339, 19);
            linkCerrarSesion.Name = "linkCerrarSesion";
            linkCerrarSesion.Size = new Size(96, 20);
            linkCerrarSesion.TabIndex = 64;
            linkCerrarSesion.TabStop = true;
            linkCerrarSesion.Text = "Cerrar Sesión";
            linkCerrarSesion.LinkClicked += linkCerrarSesion_LinkClicked;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1463, 907);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(txtIdEliminar);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(btnModificarEntrada);
            Controls.Add(txtPrecioModificar);
            Controls.Add(txtAsientoModificar);
            Controls.Add(comboSectorModificar);
            Controls.Add(comboUsuarioModificar);
            Controls.Add(comboEventoModificar);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(label13);
            Controls.Add(btnBuscarEntrada);
            Controls.Add(txtIdModificar);
            Controls.Add(label8);
            Controls.Add(txtPrecioAgregar);
            Controls.Add(label7);
            Controls.Add(txtAsientoAgregar);
            Controls.Add(comboSectorAgregar);
            Controls.Add(comboUsuarioAgregar);
            Controls.Add(comboEventoAgregar);
            Controls.Add(btnAgregarEntrada);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView1;
        private LinkLabel linkLabel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnAgregarEntrada;
        private Label label7;
        private TextBox txtIdModificar;
        private Label label8;
        private Button btnBuscarEntrada;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Button btnModificarEntrada;
        private Label label14;
        private Button button1;
        private TextBox txtIdEliminar;
        private Label label15;
        private ComboBox comboEventoAgregar;
        private ComboBox comboUsuarioAgregar;
        private ComboBox comboSectorAgregar;
        private TextBox txtAsientoAgregar;
        private TextBox txtPrecioAgregar;
        private ComboBox comboUsuarioModificar;
        private ComboBox comboSectorModificar;
        private TextBox txtAsientoModificar;
        private TextBox txtPrecioModificar;
        private ComboBox comboEventoModificar;
        private LinkLabel linkLabel2;
        private LinkLabel linkLabel3;
        private LinkLabel linkVolver;
        private LinkLabel linkCerrarSesion;
    }
}