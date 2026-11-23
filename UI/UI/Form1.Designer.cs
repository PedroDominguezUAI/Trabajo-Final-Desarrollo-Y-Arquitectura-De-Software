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
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 41, 59);
            panel1.Controls.Add(linkVolver);
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(linkLabel2);
            panel1.Controls.Add(linkLabel3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1280, 45);
            panel1.TabIndex = 64;
            // 
            // linkVolver
            // 
            linkVolver.AutoSize = true;
            linkVolver.BackColor = Color.Transparent;
            linkVolver.LinkColor = SystemColors.ControlLightLight;
            linkVolver.Location = new Point(30, 14);
            linkVolver.Name = "linkVolver";
            linkVolver.Size = new Size(76, 15);
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
            linkLabel1.Location = new Point(165, 14);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(76, 15);
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
            linkLabel2.Location = new Point(300, 14);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(72, 15);
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
            linkLabel3.Location = new Point(430, 14);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(74, 15);
            linkLabel3.TabIndex = 63;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "ABM Estadio";
            linkLabel3.LinkClicked += linkLabel3_LinkClicked;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(775, 75);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(480, 580);
            dataGridView1.TabIndex = 0;
            // 
            // label1 (Título Agregar)
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.Location = new Point(24, 75);
            label1.Name = "label1";
            label1.Size = new Size(180, 28);
            label1.TabIndex = 3;
            label1.Text = "Agregar Entrada";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 112);
            label2.Name = "label2";
            label2.Size = new Size(115, 15);
            label2.TabIndex = 4;
            label2.Text = "Seleccionar evento:";
            // 
            // comboEventoAgregar
            // 
            comboEventoAgregar.DropDownStyle = ComboBoxStyle.DropDownList;
            comboEventoAgregar.FormattingEnabled = true;
            comboEventoAgregar.Location = new Point(24, 132);
            comboEventoAgregar.Name = "comboEventoAgregar";
            comboEventoAgregar.Size = new Size(220, 23);
            comboEventoAgregar.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 168);
            label3.Name = "label3";
            label3.Size = new Size(120, 15);
            label3.TabIndex = 5;
            label3.Text = "Seleccionar usuario:";
            // 
            // comboUsuarioAgregar
            // 
            comboUsuarioAgregar.DropDownStyle = ComboBoxStyle.DropDownList;
            comboUsuarioAgregar.FormattingEnabled = true;
            comboUsuarioAgregar.Location = new Point(24, 188);
            comboUsuarioAgregar.Name = "comboUsuarioAgregar";
            comboUsuarioAgregar.Size = new Size(220, 23);
            comboUsuarioAgregar.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 224);
            label4.Name = "label4";
            label4.Size = new Size(112, 15);
            label4.TabIndex = 6;
            label4.Text = "Seleccionar sector:";
            // 
            // comboSectorAgregar
            // 
            comboSectorAgregar.DropDownStyle = ComboBoxStyle.DropDownList;
            comboSectorAgregar.FormattingEnabled = true;
            comboSectorAgregar.Items.AddRange(new object[] { "Platea alta sur", "Platea media sur", "Platea baja sur", "Platea alta norte", "Platea media norte", "Platea baja norte", "Campo" });
            comboSectorAgregar.Location = new Point(24, 244);
            comboSectorAgregar.Name = "comboSectorAgregar";
            comboSectorAgregar.Size = new Size(220, 23);
            comboSectorAgregar.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 280);
            label5.Name = "label5";
            label5.Size = new Size(98, 15);
            label5.TabIndex = 7;
            label5.Text = "Agregar asiento:";
            // 
            // txtAsientoAgregar
            // 
            txtAsientoAgregar.Location = new Point(24, 300);
            txtAsientoAgregar.Name = "txtAsientoAgregar";
            txtAsientoAgregar.Size = new Size(220, 23);
            txtAsientoAgregar.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(24, 336);
            label6.Name = "label6";
            label6.Size = new Size(92, 15);
            label6.TabIndex = 8;
            label6.Text = "Agregar precio:";
            // 
            // txtPrecioAgregar
            // 
            txtPrecioAgregar.Location = new Point(24, 356);
            txtPrecioAgregar.Name = "txtPrecioAgregar";
            txtPrecioAgregar.Size = new Size(220, 23);
            txtPrecioAgregar.TabIndex = 16;
            // 
            // btnAgregarEntrada
            // 
            btnAgregarEntrada.Location = new Point(24, 480);
            btnAgregarEntrada.Name = "btnAgregarEntrada";
            btnAgregarEntrada.Size = new Size(220, 40);
            btnAgregarEntrada.TabIndex = 9;
            btnAgregarEntrada.Text = "Agregar Entrada";
            btnAgregarEntrada.UseVisualStyleBackColor = true;
            btnAgregarEntrada.Click += btnAgregarEntrada_Click;
            // 
            // label7 (Título Modificar)
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label7.Location = new Point(275, 75);
            label7.Name = "label7";
            label7.Size = new Size(190, 28);
            label7.TabIndex = 15;
            label7.Text = "Modificar Entrada";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(275, 112);
            label8.Name = "label8";
            label8.Size = new Size(150, 15);
            label8.TabIndex = 17;
            label8.Text = "ID de entrada a modificar:";
            // 
            // txtIdModificar
            // 
            txtIdModificar.Location = new Point(275, 132);
            txtIdModificar.Name = "txtIdModificar";
            txtIdModificar.Size = new Size(220, 23);
            txtIdModificar.TabIndex = 18;
            // 
            // btnBuscarEntrada
            // 
            btnBuscarEntrada.Location = new Point(275, 165);
            btnBuscarEntrada.Name = "btnBuscarEntrada";
            btnBuscarEntrada.Size = new Size(220, 36);
            btnBuscarEntrada.TabIndex = 19;
            btnBuscarEntrada.Text = "Buscar Entrada";
            btnBuscarEntrada.UseVisualStyleBackColor = true;
            btnBuscarEntrada.Click += btnBuscarEntrada_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(275, 212);
            label13.Name = "label13";
            label13.Size = new Size(105, 15);
            label13.TabIndex = 20;
            label13.Text = "Modificar evento:";
            // 
            // comboEventoModificar
            // 
            comboEventoModificar.DropDownStyle = ComboBoxStyle.DropDownList;
            comboEventoModificar.FormattingEnabled = true;
            comboEventoModificar.Location = new Point(275, 230);
            comboEventoModificar.Name = "comboEventoModificar";
            comboEventoModificar.Size = new Size(220, 23);
            comboEventoModificar.TabIndex = 25;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(275, 262);
            label12.Name = "label12";
            label12.Size = new Size(108, 15);
            label12.TabIndex = 21;
            label12.Text = "Modificar usuario:";
            // 
            // comboUsuarioModificar
            // 
            comboUsuarioModificar.DropDownStyle = ComboBoxStyle.DropDownList;
            comboUsuarioModificar.FormattingEnabled = true;
            comboUsuarioModificar.Location = new Point(275, 280);
            comboUsuarioModificar.Name = "comboUsuarioModificar";
            comboUsuarioModificar.Size = new Size(220, 23);
            comboUsuarioModificar.TabIndex = 26;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(275, 312);
            label11.Name = "label11";
            label11.Size = new Size(100, 15);
            label11.TabIndex = 22;
            label11.Text = "Modificar sector:";
            // 
            // comboSectorModificar
            // 
            comboSectorModificar.DropDownStyle = ComboBoxStyle.DropDownList;
            comboSectorModificar.FormattingEnabled = true;
            comboSectorModificar.Items.AddRange(new object[] { "Platea alta sur", "Platea media sur", "Platea baja sur", "Platea alta norte", "Platea media norte", "Platea baja norte", "Campo" });
            comboSectorModificar.Location = new Point(275, 330);
            comboSectorModificar.Name = "comboSectorModificar";
            comboSectorModificar.Size = new Size(220, 23);
            comboSectorModificar.TabIndex = 27;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(275, 362);
            label10.Name = "label10";
            label10.Size = new Size(106, 15);
            label10.TabIndex = 23;
            label10.Text = "Modificar asiento:";
            // 
            // txtAsientoModificar
            // 
            txtAsientoModificar.Location = new Point(275, 380);
            txtAsientoModificar.Name = "txtAsientoModificar";
            txtAsientoModificar.Size = new Size(220, 23);
            txtAsientoModificar.TabIndex = 28;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(275, 412);
            label9.Name = "label9";
            label9.Size = new Size(100, 15);
            label9.TabIndex = 24;
            label9.Text = "Modificar precio:";
            // 
            // txtPrecioModificar
            // 
            txtPrecioModificar.Location = new Point(275, 430);
            txtPrecioModificar.Name = "txtPrecioModificar";
            txtPrecioModificar.Size = new Size(220, 23);
            txtPrecioModificar.TabIndex = 29;
            // 
            // btnModificarEntrada
            // 
            btnModificarEntrada.Location = new Point(275, 480);
            btnModificarEntrada.Name = "btnModificarEntrada";
            btnModificarEntrada.Size = new Size(220, 40);
            btnModificarEntrada.TabIndex = 30;
            btnModificarEntrada.Text = "Modificar Entrada";
            btnModificarEntrada.UseVisualStyleBackColor = true;
            btnModificarEntrada.Click += btnModificarEntrada_Click;
            // 
            // label14 (Título Eliminar)
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label14.Location = new Point(526, 75);
            label14.Name = "label14";
            label14.Size = new Size(180, 28);
            label14.TabIndex = 31;
            label14.Text = "Eliminar Entrada";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(526, 112);
            label15.Name = "label15";
            label15.Size = new Size(145, 15);
            label15.TabIndex = 32;
            label15.Text = "ID de entrada a eliminar:";
            // 
            // txtIdEliminar
            // 
            txtIdEliminar.Location = new Point(526, 132);
            txtIdEliminar.Name = "txtIdEliminar";
            txtIdEliminar.Size = new Size(220, 23);
            txtIdEliminar.TabIndex = 33;
            // 
            // button1
            // 
            button1.Location = new Point(526, 165);
            button1.Name = "button1";
            button1.Size = new Size(220, 36);
            button1.TabIndex = 34;
            button1.Text = "Eliminar Entrada";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 680);
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
    }
}