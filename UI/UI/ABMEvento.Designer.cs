namespace UI
{
    partial class ABMEvento
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
            txtEventoAgregar = new TextBox();
            label3 = new Label();
            dtpFechaAgregar = new DateTimePicker();
            label4 = new Label();
            comboEstadioAgregar = new ComboBox();
            btnAgregarEvento = new Button();
            label7 = new Label();
            label8 = new Label();
            txtIdEvento = new TextBox();
            btnBuscarEvento = new Button();
            label5 = new Label();
            txtNombreModificar = new TextBox();
            label6 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label9 = new Label();
            comboBox1 = new ComboBox();
            button1 = new Button();
            label14 = new Label();
            label15 = new Label();
            txtIdEliminarEvento = new TextBox();
            btnEleminarEvento = new Button();
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
            panel1.TabIndex = 104;
            // 
            // linkVolver
            // 
            linkVolver.AutoSize = true;
            linkVolver.BackColor = Color.Transparent;
            linkVolver.LinkColor = SystemColors.ControlLightLight;
            linkVolver.Location = new Point(30, 14);
            linkVolver.Name = "linkVolver";
            linkVolver.Size = new Size(76, 15);
            linkVolver.TabIndex = 56;
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
            linkLabel1.TabIndex = 57;
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
            linkLabel2.TabIndex = 58;
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
            linkLabel3.TabIndex = 59;
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
            dataGridView1.TabIndex = 105;
            // 
            // label1 (Título Agregar)
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.Location = new Point(24, 75);
            label1.Name = "label1";
            label1.Size = new Size(165, 28);
            label1.TabIndex = 103;
            label1.Text = "Agregar Evento";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 112);
            label2.Name = "label2";
            label2.Size = new Size(115, 15);
            label2.TabIndex = 106;
            label2.Text = "Nombre del Evento:";
            // 
            // txtEventoAgregar
            // 
            txtEventoAgregar.Location = new Point(24, 132);
            txtEventoAgregar.Name = "txtEventoAgregar";
            txtEventoAgregar.Size = new Size(220, 23);
            txtEventoAgregar.TabIndex = 107;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 168);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 108;
            label3.Text = "Fecha:";
            // 
            // dtpFechaAgregar
            // 
            dtpFechaAgregar.CustomFormat = "dd/MM/yyyy HH:mm";
            dtpFechaAgregar.Format = DateTimePickerFormat.Custom;
            dtpFechaAgregar.Location = new Point(24, 188);
            dtpFechaAgregar.Name = "dtpFechaAgregar";
            dtpFechaAgregar.Size = new Size(220, 23);
            dtpFechaAgregar.TabIndex = 109;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 224);
            label4.Name = "label4";
            label4.Size = new Size(115, 15);
            label4.TabIndex = 110;
            label4.Text = "Seleccionar estadio:";
            // 
            // comboEstadioAgregar
            // 
            comboEstadioAgregar.DropDownStyle = ComboBoxStyle.DropDownList;
            comboEstadioAgregar.FormattingEnabled = true;
            comboEstadioAgregar.Location = new Point(24, 244);
            comboEstadioAgregar.Name = "comboEstadioAgregar";
            comboEstadioAgregar.Size = new Size(220, 23);
            comboEstadioAgregar.TabIndex = 111;
            // 
            // btnAgregarEvento
            // 
            btnAgregarEvento.Location = new Point(24, 480);
            btnAgregarEvento.Name = "btnAgregarEvento";
            btnAgregarEvento.Size = new Size(220, 40);
            btnAgregarEvento.TabIndex = 112;
            btnAgregarEvento.Text = "Agregar Evento";
            btnAgregarEvento.UseVisualStyleBackColor = true;
            btnAgregarEvento.Click += btnAgregarEvento_Click;
            // 
            // label7 (Título Modificar)
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label7.Location = new Point(275, 75);
            label7.Name = "label7";
            label7.Size = new Size(181, 28);
            label7.TabIndex = 117;
            label7.Text = "Modificar Evento";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(275, 112);
            label8.Name = "label8";
            label8.Size = new Size(140, 15);
            label8.TabIndex = 118;
            label8.Text = "ID de evento a modificar:";
            // 
            // txtIdEvento
            // 
            txtIdEvento.Location = new Point(275, 132);
            txtIdEvento.Name = "txtIdEvento";
            txtIdEvento.Size = new Size(220, 23);
            txtIdEvento.TabIndex = 119;
            // 
            // btnBuscarEvento
            // 
            btnBuscarEvento.Location = new Point(275, 165);
            btnBuscarEvento.Name = "btnBuscarEvento";
            btnBuscarEvento.Size = new Size(220, 36);
            btnBuscarEvento.TabIndex = 120;
            btnBuscarEvento.Text = "Buscar Evento";
            btnBuscarEvento.UseVisualStyleBackColor = true;
            btnBuscarEvento.Click += btnBuscarEvento_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(275, 212);
            label5.Name = "label5";
            label5.Size = new Size(110, 15);
            label5.TabIndex = 121;
            label5.Text = "Modificar nombre:";
            // 
            // txtNombreModificar
            // 
            txtNombreModificar.Location = new Point(275, 230);
            txtNombreModificar.Name = "txtNombreModificar";
            txtNombreModificar.Size = new Size(220, 23);
            txtNombreModificar.TabIndex = 122;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(275, 268);
            label6.Name = "label6";
            label6.Size = new Size(96, 15);
            label6.TabIndex = 123;
            label6.Text = "Modificar fecha:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dd/MM/yyyy HH:mm";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(275, 286);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(220, 23);
            dateTimePicker1.TabIndex = 124;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(275, 324);
            label9.Name = "label9";
            label9.Size = new Size(105, 15);
            label9.TabIndex = 125;
            label9.Text = "Modificar Estadio:";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(275, 342);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(220, 23);
            comboBox1.TabIndex = 126;
            // 
            // button1
            // 
            button1.Location = new Point(275, 480);
            button1.Name = "button1";
            button1.Size = new Size(220, 40);
            button1.TabIndex = 127;
            button1.Text = "Modificar Evento";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label14 (Título Eliminar)
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label14.Location = new Point(526, 75);
            label14.Name = "label14";
            label14.Size = new Size(166, 28);
            label14.TabIndex = 113;
            label14.Text = "Eliminar Evento";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(526, 112);
            label15.Name = "label15";
            label15.Size = new Size(135, 15);
            label15.TabIndex = 114;
            label15.Text = "ID de evento a eliminar:";
            // 
            // txtIdEliminarEvento
            // 
            txtIdEliminarEvento.Location = new Point(526, 132);
            txtIdEliminarEvento.Name = "txtIdEliminarEvento";
            txtIdEliminarEvento.Size = new Size(220, 23);
            txtIdEliminarEvento.TabIndex = 115;
            // 
            // btnEleminarEvento
            // 
            btnEleminarEvento.Location = new Point(526, 165);
            btnEleminarEvento.Name = "btnEleminarEvento";
            btnEleminarEvento.Size = new Size(220, 36);
            btnEleminarEvento.TabIndex = 116;
            btnEleminarEvento.Text = "Eliminar Evento";
            btnEleminarEvento.UseVisualStyleBackColor = true;
            btnEleminarEvento.Click += btnEleminarEvento_Click;
            // 
            // ABMEvento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 680);
            Controls.Add(btnEleminarEvento);
            Controls.Add(txtIdEliminarEvento);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(label9);
            Controls.Add(dateTimePicker1);
            Controls.Add(label6);
            Controls.Add(txtNombreModificar);
            Controls.Add(label5);
            Controls.Add(btnBuscarEvento);
            Controls.Add(txtIdEvento);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(btnAgregarEvento);
            Controls.Add(comboEstadioAgregar);
            Controls.Add(label4);
            Controls.Add(dtpFechaAgregar);
            Controls.Add(label3);
            Controls.Add(txtEventoAgregar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "ABMEvento";
            Text = "ABMEvento";
            Load += ABMEvento_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private LinkLabel linkVolver;
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
        private LinkLabel linkLabel3;
        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private TextBox txtEventoAgregar;
        private Label label3;
        private DateTimePicker dtpFechaAgregar;
        private Label label4;
        private ComboBox comboEstadioAgregar;
        private Button btnAgregarEvento;
        private Label label7;
        private Label label8;
        private TextBox txtIdEvento;
        private Button btnBuscarEvento;
        private Label label5;
        private TextBox txtNombreModificar;
        private Label label6;
        private DateTimePicker dateTimePicker1;
        private Label label9;
        private ComboBox comboBox1;
        private Button button1;
        private Label label14;
        private Label label15;
        private TextBox txtIdEliminarEvento;
        private Button btnEleminarEvento;
    }
}