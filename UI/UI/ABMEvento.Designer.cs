namespace UI
{
    partial class ABMEvento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            txtNombreAgregar = new Label();
            label1 = new Label();
            txtEventoAgregar = new TextBox();
            label2 = new Label();
            dtpFechaAgregar = new DateTimePicker();
            comboEstadioAgregar = new ComboBox();
            btnAgregarEvento = new Button();
            btnBuscarEvento = new Button();
            txtIdEvento = new TextBox();
            label8 = new Label();
            label7 = new Label();
            button1 = new Button();
            comboBox1 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            txtNombreModificar = new TextBox();
            label3 = new Label();
            btnEleminarEvento = new Button();
            txtIdEliminarEvento = new TextBox();
            label15 = new Label();
            label14 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            linkVolver = new LinkLabel();
            linkLabel2 = new LinkLabel();
            linkLabel1 = new LinkLabel();
            linkLabel3 = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(1010, 35);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(501, 679);
            dataGridView1.TabIndex = 1;
            // 
            // txtNombreAgregar
            // 
            txtNombreAgregar.AutoSize = true;
            txtNombreAgregar.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            txtNombreAgregar.Location = new Point(29, 164);
            txtNombreAgregar.Name = "txtNombreAgregar";
            txtNombreAgregar.Size = new Size(350, 25);
            txtNombreAgregar.TabIndex = 33;
            txtNombreAgregar.Text = "Nombre del Evento que desea agregar :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(29, 96);
            label1.Name = "label1";
            label1.Size = new Size(229, 37);
            label1.TabIndex = 34;
            label1.Text = "Agregar Eventos";
            // 
            // txtEventoAgregar
            // 
            txtEventoAgregar.Location = new Point(29, 211);
            txtEventoAgregar.Margin = new Padding(3, 4, 3, 4);
            txtEventoAgregar.Name = "txtEventoAgregar";
            txtEventoAgregar.Size = new Size(278, 27);
            txtEventoAgregar.TabIndex = 35;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label2.Location = new Point(29, 267);
            label2.Name = "label2";
            label2.Size = new Size(72, 25);
            label2.TabIndex = 36;
            label2.Text = "Fecha :";
            // 
            // dtpFechaAgregar
            // 
            dtpFechaAgregar.CustomFormat = "dd/MM/yyyy HH:mm";
            dtpFechaAgregar.Format = DateTimePickerFormat.Custom;
            dtpFechaAgregar.Location = new Point(29, 319);
            dtpFechaAgregar.Margin = new Padding(3, 4, 3, 4);
            dtpFechaAgregar.Name = "dtpFechaAgregar";
            dtpFechaAgregar.Size = new Size(263, 27);
            dtpFechaAgregar.TabIndex = 37;
            // 
            // comboEstadioAgregar
            // 
            comboEstadioAgregar.DropDownStyle = ComboBoxStyle.DropDownList;
            comboEstadioAgregar.FormattingEnabled = true;
            comboEstadioAgregar.Location = new Point(29, 415);
            comboEstadioAgregar.Margin = new Padding(3, 4, 3, 4);
            comboEstadioAgregar.Name = "comboEstadioAgregar";
            comboEstadioAgregar.Size = new Size(278, 28);
            comboEstadioAgregar.TabIndex = 38;
            // 
            // btnAgregarEvento
            // 
            btnAgregarEvento.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregarEvento.Location = new Point(55, 492);
            btnAgregarEvento.Margin = new Padding(3, 4, 3, 4);
            btnAgregarEvento.Name = "btnAgregarEvento";
            btnAgregarEvento.Size = new Size(238, 55);
            btnAgregarEvento.TabIndex = 39;
            btnAgregarEvento.Text = "Agregar Evento";
            btnAgregarEvento.UseVisualStyleBackColor = true;
            btnAgregarEvento.Click += btnAgregarEvento_Click;
            // 
            // btnBuscarEvento
            // 
            btnBuscarEvento.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscarEvento.Location = new Point(415, 212);
            btnBuscarEvento.Margin = new Padding(3, 4, 3, 4);
            btnBuscarEvento.Name = "btnBuscarEvento";
            btnBuscarEvento.Size = new Size(227, 47);
            btnBuscarEvento.TabIndex = 43;
            btnBuscarEvento.Text = "Buscar evento";
            btnBuscarEvento.UseVisualStyleBackColor = true;
            btnBuscarEvento.Click += btnBuscarEvento_Click;
            // 
            // txtIdEvento
            // 
            txtIdEvento.Location = new Point(389, 175);
            txtIdEvento.Margin = new Padding(3, 4, 3, 4);
            txtIdEvento.Name = "txtIdEvento";
            txtIdEvento.Size = new Size(278, 27);
            txtIdEvento.TabIndex = 42;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label8.Location = new Point(389, 140);
            label8.Name = "label8";
            label8.Size = new Size(300, 25);
            label8.TabIndex = 41;
            label8.Text = "ID de evento que desea modificar";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label7.Location = new Point(389, 96);
            label7.Name = "label7";
            label7.Size = new Size(237, 37);
            label7.TabIndex = 40;
            label7.Text = "Modificar Evento";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(415, 609);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(238, 55);
            button1.TabIndex = 48;
            button1.Text = "Modificar Evento";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(389, 532);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(278, 28);
            comboBox1.TabIndex = 47;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dd/MM/yyyy HH:mm";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(389, 436);
            dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(263, 27);
            dateTimePicker1.TabIndex = 46;
            // 
            // txtNombreModificar
            // 
            txtNombreModificar.Location = new Point(389, 328);
            txtNombreModificar.Margin = new Padding(3, 4, 3, 4);
            txtNombreModificar.Name = "txtNombreModificar";
            txtNombreModificar.Size = new Size(278, 27);
            txtNombreModificar.TabIndex = 45;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label3.Location = new Point(389, 281);
            label3.Name = "label3";
            label3.Size = new Size(177, 25);
            label3.TabIndex = 44;
            label3.Text = "Modificar nombre :";
            // 
            // btnEleminarEvento
            // 
            btnEleminarEvento.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEleminarEvento.Location = new Point(749, 236);
            btnEleminarEvento.Margin = new Padding(3, 4, 3, 4);
            btnEleminarEvento.Name = "btnEleminarEvento";
            btnEleminarEvento.Size = new Size(211, 49);
            btnEleminarEvento.TabIndex = 52;
            btnEleminarEvento.Text = "Eliminar evento";
            btnEleminarEvento.UseVisualStyleBackColor = true;
            btnEleminarEvento.Click += btnEleminarEvento_Click;
            // 
            // txtIdEliminarEvento
            // 
            txtIdEliminarEvento.Location = new Point(713, 197);
            txtIdEliminarEvento.Margin = new Padding(3, 4, 3, 4);
            txtIdEliminarEvento.Name = "txtIdEliminarEvento";
            txtIdEliminarEvento.Size = new Size(278, 27);
            txtIdEliminarEvento.TabIndex = 51;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label15.Location = new Point(713, 163);
            label15.Name = "label15";
            label15.Size = new Size(293, 25);
            label15.TabIndex = 50;
            label15.Text = "ID del evento que desea Eliminar";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label14.Location = new Point(713, 109);
            label14.Name = "label14";
            label14.Size = new Size(217, 37);
            label14.TabIndex = 49;
            label14.Text = "Eliminar Evento";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label4.Location = new Point(29, 371);
            label4.Name = "label4";
            label4.Size = new Size(186, 25);
            label4.TabIndex = 53;
            label4.Text = "Seleccionar estadio :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label5.Location = new Point(389, 389);
            label5.Name = "label5";
            label5.Size = new Size(157, 25);
            label5.TabIndex = 54;
            label5.Text = "Modificar fecha :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label6.Location = new Point(389, 492);
            label6.Name = "label6";
            label6.Size = new Size(172, 25);
            label6.TabIndex = 55;
            label6.Text = "Modificar Estadio :";
            // 
            // linkVolver
            // 
            linkVolver.AutoSize = true;
            linkVolver.Location = new Point(51, 27);
            linkVolver.Name = "linkVolver";
            linkVolver.Size = new Size(96, 20);
            linkVolver.TabIndex = 56;
            linkVolver.TabStop = true;
            linkVolver.Text = "ABM Entrada";
            linkVolver.LinkClicked += linkVolver_LinkClicked;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Location = new Point(365, 27);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(90, 20);
            linkLabel2.TabIndex = 58;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "ABM Evento";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(212, 27);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(95, 20);
            linkLabel1.TabIndex = 57;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "ABM Usuario";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // linkLabel3
            // 
            linkLabel3.AutoSize = true;
            linkLabel3.Location = new Point(510, 27);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(94, 20);
            linkLabel3.TabIndex = 59;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "ABM Estadio";
            linkLabel3.LinkClicked += linkLabel3_LinkClicked;
            // 
            // ABMEvento
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1525, 769);
            Controls.Add(linkLabel3);
            Controls.Add(linkLabel2);
            Controls.Add(linkLabel1);
            Controls.Add(linkVolver);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btnEleminarEvento);
            Controls.Add(txtIdEliminarEvento);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(txtNombreModificar);
            Controls.Add(label3);
            Controls.Add(btnBuscarEvento);
            Controls.Add(txtIdEvento);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(btnAgregarEvento);
            Controls.Add(comboEstadioAgregar);
            Controls.Add(dtpFechaAgregar);
            Controls.Add(label2);
            Controls.Add(txtEventoAgregar);
            Controls.Add(label1);
            Controls.Add(txtNombreAgregar);
            Controls.Add(dataGridView1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ABMEvento";
            Text = "ABMEvento";
            Load += ABMEvento_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView1;
        private Label txtNombreAgregar;
        private Label label1;
        private TextBox txtEventoAgregar;
        private Label label2;
        private DateTimePicker dtpFechaAgregar;
        private ComboBox comboEstadioAgregar;
        private Button btnAgregarEvento;
        private Button btnBuscarEvento;
        private TextBox txtIdEvento;
        private Label label8;
        private Label label7;
        private Button button1;
        private ComboBox comboBox1;
        private DateTimePicker dateTimePicker1;
        private TextBox txtNombreModificar;
        private Label label3;
        private Button btnEleminarEvento;
        private TextBox txtIdEliminarEvento;
        private Label label15;
        private Label label14;
        private Label label4;
        private Label label5;
        private Label label6;
        private LinkLabel linkVolver;
        private LinkLabel linkLabel2;
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel3;
    }
}