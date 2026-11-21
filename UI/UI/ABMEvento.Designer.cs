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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(884, 26);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(438, 509);
            dataGridView1.TabIndex = 1;
            // 
            // txtNombreAgregar
            // 
            txtNombreAgregar.AutoSize = true;
            txtNombreAgregar.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            txtNombreAgregar.Location = new Point(25, 123);
            txtNombreAgregar.Name = "txtNombreAgregar";
            txtNombreAgregar.Size = new Size(281, 20);
            txtNombreAgregar.TabIndex = 33;
            txtNombreAgregar.Text = "Nombre del Evento que desea agregar :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(25, 72);
            label1.Name = "label1";
            label1.Size = new Size(174, 30);
            label1.TabIndex = 34;
            label1.Text = "Agregar Eventos";
            // 
            // txtEventoAgregar
            // 
            txtEventoAgregar.Location = new Point(25, 158);
            txtEventoAgregar.Name = "txtEventoAgregar";
            txtEventoAgregar.Size = new Size(244, 23);
            txtEventoAgregar.TabIndex = 35;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label2.Location = new Point(25, 200);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 36;
            label2.Text = "Fecha :";
            // 
            // dtpFechaAgregar
            // 
            dtpFechaAgregar.CustomFormat = "dd/MM/yyyy HH:mm";
            dtpFechaAgregar.Format = DateTimePickerFormat.Custom;
            dtpFechaAgregar.Location = new Point(25, 239);
            dtpFechaAgregar.Name = "dtpFechaAgregar";
            dtpFechaAgregar.Size = new Size(231, 23);
            dtpFechaAgregar.TabIndex = 37;
            // 
            // comboEstadioAgregar
            // 
            comboEstadioAgregar.DropDownStyle = ComboBoxStyle.DropDownList;
            comboEstadioAgregar.FormattingEnabled = true;
            comboEstadioAgregar.Location = new Point(25, 311);
            comboEstadioAgregar.Name = "comboEstadioAgregar";
            comboEstadioAgregar.Size = new Size(244, 23);
            comboEstadioAgregar.TabIndex = 38;
            // 
            // btnAgregarEvento
            // 
            btnAgregarEvento.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregarEvento.Location = new Point(48, 369);
            btnAgregarEvento.Name = "btnAgregarEvento";
            btnAgregarEvento.Size = new Size(208, 41);
            btnAgregarEvento.TabIndex = 39;
            btnAgregarEvento.Text = "Agregar Evento";
            btnAgregarEvento.UseVisualStyleBackColor = true;
            btnAgregarEvento.Click += btnAgregarEvento_Click;
            // 
            // btnBuscarEvento
            // 
            btnBuscarEvento.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscarEvento.Location = new Point(363, 159);
            btnBuscarEvento.Name = "btnBuscarEvento";
            btnBuscarEvento.Size = new Size(199, 35);
            btnBuscarEvento.TabIndex = 43;
            btnBuscarEvento.Text = "Buscar evento";
            btnBuscarEvento.UseVisualStyleBackColor = true;
            btnBuscarEvento.Click += btnBuscarEvento_Click;
            // 
            // txtIdEvento
            // 
            txtIdEvento.Location = new Point(340, 131);
            txtIdEvento.Name = "txtIdEvento";
            txtIdEvento.Size = new Size(244, 23);
            txtIdEvento.TabIndex = 42;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label8.Location = new Point(340, 105);
            label8.Name = "label8";
            label8.Size = new Size(238, 20);
            label8.TabIndex = 41;
            label8.Text = "ID de evento que desea modificar";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label7.Location = new Point(340, 72);
            label7.Name = "label7";
            label7.Size = new Size(181, 30);
            label7.TabIndex = 40;
            label7.Text = "Modificar Evento";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(363, 457);
            button1.Name = "button1";
            button1.Size = new Size(208, 41);
            button1.TabIndex = 48;
            button1.Text = "Modificar Evento";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(340, 399);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(244, 23);
            comboBox1.TabIndex = 47;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dd/MM/yyyy HH:mm";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(340, 327);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(231, 23);
            dateTimePicker1.TabIndex = 46;
            // 
            // txtNombreModificar
            // 
            txtNombreModificar.Location = new Point(340, 246);
            txtNombreModificar.Name = "txtNombreModificar";
            txtNombreModificar.Size = new Size(244, 23);
            txtNombreModificar.TabIndex = 45;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label3.Location = new Point(340, 211);
            label3.Name = "label3";
            label3.Size = new Size(141, 20);
            label3.TabIndex = 44;
            label3.Text = "Modificar nombre :";
            // 
            // btnEleminarEvento
            // 
            btnEleminarEvento.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEleminarEvento.Location = new Point(655, 177);
            btnEleminarEvento.Name = "btnEleminarEvento";
            btnEleminarEvento.Size = new Size(185, 37);
            btnEleminarEvento.TabIndex = 52;
            btnEleminarEvento.Text = "Eliminar evento";
            btnEleminarEvento.UseVisualStyleBackColor = true;
            btnEleminarEvento.Click += btnEleminarEvento_Click;
            // 
            // txtIdEliminarEvento
            // 
            txtIdEliminarEvento.Location = new Point(624, 148);
            txtIdEliminarEvento.Name = "txtIdEliminarEvento";
            txtIdEliminarEvento.Size = new Size(244, 23);
            txtIdEliminarEvento.TabIndex = 51;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label15.Location = new Point(624, 122);
            label15.Name = "label15";
            label15.Size = new Size(233, 20);
            label15.TabIndex = 50;
            label15.Text = "ID del evento que desea Eliminar";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label14.Location = new Point(624, 82);
            label14.Name = "label14";
            label14.Size = new Size(166, 30);
            label14.TabIndex = 49;
            label14.Text = "Eliminar Evento";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label4.Location = new Point(25, 278);
            label4.Name = "label4";
            label4.Size = new Size(148, 20);
            label4.TabIndex = 53;
            label4.Text = "Seleccionar estadio :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label5.Location = new Point(340, 292);
            label5.Name = "label5";
            label5.Size = new Size(124, 20);
            label5.TabIndex = 54;
            label5.Text = "Modificar fecha :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label6.Location = new Point(340, 369);
            label6.Name = "label6";
            label6.Size = new Size(136, 20);
            label6.TabIndex = 55;
            label6.Text = "Modificar Estadio :";
            // 
            // linkVolver
            // 
            linkVolver.AutoSize = true;
            linkVolver.Location = new Point(45, 20);
            linkVolver.Name = "linkVolver";
            linkVolver.Size = new Size(91, 15);
            linkVolver.TabIndex = 56;
            linkVolver.TabStop = true;
            linkVolver.Text = "Volver a Entrada";
            linkVolver.LinkClicked += linkVolver_LinkClicked;
            // 
            // ABMEvento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1334, 577);
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
    }
}