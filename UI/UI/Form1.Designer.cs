namespace UI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            linkLabel1 = new LinkLabel();
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(808, 89);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(487, 484);
            dataGridView1.TabIndex = 0;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(1219, 37);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(76, 15);
            linkLabel1.TabIndex = 2;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "ABM Usuario";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 89);
            label1.Name = "label1";
            label1.Size = new Size(182, 30);
            label1.TabIndex = 3;
            label1.Text = "Agregar entradas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label2.Location = new Point(12, 131);
            label2.Name = "label2";
            label2.Size = new Size(138, 20);
            label2.TabIndex = 4;
            label2.Text = "Seleccionar evento";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label3.Location = new Point(12, 191);
            label3.Name = "label3";
            label3.Size = new Size(142, 20);
            label3.TabIndex = 5;
            label3.Text = "Seleccionar usuario";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label4.Location = new Point(12, 252);
            label4.Name = "label4";
            label4.Size = new Size(132, 20);
            label4.TabIndex = 6;
            label4.Text = "Seleccionar sector";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label5.Location = new Point(12, 312);
            label5.Name = "label5";
            label5.Size = new Size(118, 20);
            label5.TabIndex = 7;
            label5.Text = "Agregar asiento";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label6.Location = new Point(12, 376);
            label6.Name = "label6";
            label6.Size = new Size(112, 20);
            label6.TabIndex = 8;
            label6.Text = "Agregar precio";
            // 
            // btnAgregarEntrada
            // 
            btnAgregarEntrada.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregarEntrada.Location = new Point(33, 428);
            btnAgregarEntrada.Name = "btnAgregarEntrada";
            btnAgregarEntrada.Size = new Size(208, 41);
            btnAgregarEntrada.TabIndex = 9;
            btnAgregarEntrada.Text = "Agregar entrada";
            btnAgregarEntrada.UseVisualStyleBackColor = true;
            btnAgregarEntrada.Click += btnAgregarEntrada_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label7.Location = new Point(280, 89);
            label7.Name = "label7";
            label7.Size = new Size(198, 30);
            label7.TabIndex = 15;
            label7.Text = "Modificar entradas";
            // 
            // txtIdModificar
            // 
            txtIdModificar.Location = new Point(280, 148);
            txtIdModificar.Name = "txtIdModificar";
            txtIdModificar.Size = new Size(244, 23);
            txtIdModificar.TabIndex = 18;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label8.Location = new Point(280, 122);
            label8.Name = "label8";
            label8.Size = new Size(244, 20);
            label8.TabIndex = 17;
            label8.Text = "ID de entrada que desea modificar";
            // 
            // btnBuscarEntrada
            // 
            btnBuscarEntrada.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscarEntrada.Location = new Point(303, 176);
            btnBuscarEntrada.Name = "btnBuscarEntrada";
            btnBuscarEntrada.Size = new Size(199, 35);
            btnBuscarEntrada.TabIndex = 19;
            btnBuscarEntrada.Text = "Buscar entrada";
            btnBuscarEntrada.UseVisualStyleBackColor = true;
            btnBuscarEntrada.Click += btnBuscarEntrada_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label9.Location = new Point(280, 462);
            label9.Name = "label9";
            label9.Size = new Size(122, 20);
            label9.TabIndex = 24;
            label9.Text = "Modificar precio";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label10.Location = new Point(280, 398);
            label10.Name = "label10";
            label10.Size = new Size(128, 20);
            label10.TabIndex = 23;
            label10.Text = "Modificar asiento";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label11.Location = new Point(280, 338);
            label11.Name = "label11";
            label11.Size = new Size(120, 20);
            label11.TabIndex = 22;
            label11.Text = "Modificar sector";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label12.Location = new Point(280, 277);
            label12.Name = "label12";
            label12.Size = new Size(130, 20);
            label12.TabIndex = 21;
            label12.Text = "Modificar usuario";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label13.Location = new Point(280, 217);
            label13.Name = "label13";
            label13.Size = new Size(126, 20);
            label13.TabIndex = 20;
            label13.Text = "Modificar evento";
            // 
            // btnModificarEntrada
            // 
            btnModificarEntrada.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnModificarEntrada.Location = new Point(293, 514);
            btnModificarEntrada.Name = "btnModificarEntrada";
            btnModificarEntrada.Size = new Size(218, 47);
            btnModificarEntrada.TabIndex = 30;
            btnModificarEntrada.Text = "Modificar entrada";
            btnModificarEntrada.UseVisualStyleBackColor = true;
            btnModificarEntrada.Click += btnModificarEntrada_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label14.Location = new Point(546, 91);
            label14.Name = "label14";
            label14.Size = new Size(183, 30);
            label14.TabIndex = 31;
            label14.Text = "Eliminar entradas";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(577, 186);
            button1.Name = "button1";
            button1.Size = new Size(185, 37);
            button1.TabIndex = 34;
            button1.Text = "Eliminar entrada";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtIdEliminar
            // 
            txtIdEliminar.Location = new Point(546, 157);
            txtIdEliminar.Name = "txtIdEliminar";
            txtIdEliminar.Size = new Size(244, 23);
            txtIdEliminar.TabIndex = 33;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label15.Location = new Point(546, 131);
            label15.Name = "label15";
            label15.Size = new Size(235, 20);
            label15.TabIndex = 32;
            label15.Text = "ID de entrada que desea Eliminar";
            // 
            // comboEventoAgregar
            // 
            comboEventoAgregar.FormattingEnabled = true;
            comboEventoAgregar.Items.AddRange(new object[] { "nicki minaj", "nicki nicole", "sabrina carpenter" });
            comboEventoAgregar.Location = new Point(12, 153);
            comboEventoAgregar.Name = "comboEventoAgregar";
            comboEventoAgregar.Size = new Size(244, 23);
            comboEventoAgregar.TabIndex = 10;
            // 
            // comboUsuarioAgregar
            // 
            comboUsuarioAgregar.FormattingEnabled = true;
            comboUsuarioAgregar.Location = new Point(12, 214);
            comboUsuarioAgregar.Name = "comboUsuarioAgregar";
            comboUsuarioAgregar.Size = new Size(244, 23);
            comboUsuarioAgregar.TabIndex = 11;
            // 
            // comboSectorAgregar
            // 
            comboSectorAgregar.FormattingEnabled = true;
            comboSectorAgregar.Items.AddRange(new object[] { "Platea alta sur", "Platea media sur", "Platea alta sur", "Platea alta norte", "Platea media norte", "Platea alta norte", "Campo" });
            comboSectorAgregar.Location = new Point(12, 274);
            comboSectorAgregar.Name = "comboSectorAgregar";
            comboSectorAgregar.Size = new Size(244, 23);
            comboSectorAgregar.TabIndex = 12;
            // 
            // txtAsientoAgregar
            // 
            txtAsientoAgregar.Location = new Point(12, 338);
            txtAsientoAgregar.Name = "txtAsientoAgregar";
            txtAsientoAgregar.Size = new Size(244, 23);
            txtAsientoAgregar.TabIndex = 13;
            // 
            // txtPrecioAgregar
            // 
            txtPrecioAgregar.Location = new Point(12, 399);
            txtPrecioAgregar.Name = "txtPrecioAgregar";
            txtPrecioAgregar.Size = new Size(244, 23);
            txtPrecioAgregar.TabIndex = 16;
            // 
            // comboUsuarioModificar
            // 
            comboUsuarioModificar.FormattingEnabled = true;
            comboUsuarioModificar.Location = new Point(280, 300);
            comboUsuarioModificar.Name = "comboUsuarioModificar";
            comboUsuarioModificar.Size = new Size(244, 23);
            comboUsuarioModificar.TabIndex = 26;
            // 
            // comboSectorModificar
            // 
            comboSectorModificar.FormattingEnabled = true;
            comboSectorModificar.Items.AddRange(new object[] { "Platea alta sur", "Platea media sur", "Platea alta sur", "Platea alta norte", "Platea media norte", "Platea alta norte", "Campo" });
            comboSectorModificar.Location = new Point(280, 360);
            comboSectorModificar.Name = "comboSectorModificar";
            comboSectorModificar.Size = new Size(244, 23);
            comboSectorModificar.TabIndex = 27;
            // 
            // txtAsientoModificar
            // 
            txtAsientoModificar.Location = new Point(280, 424);
            txtAsientoModificar.Name = "txtAsientoModificar";
            txtAsientoModificar.Size = new Size(244, 23);
            txtAsientoModificar.TabIndex = 28;
            // 
            // txtPrecioModificar
            // 
            txtPrecioModificar.Location = new Point(280, 485);
            txtPrecioModificar.Name = "txtPrecioModificar";
            txtPrecioModificar.Size = new Size(244, 23);
            txtPrecioModificar.TabIndex = 29;
            // 
            // comboEventoModificar
            // 
            comboEventoModificar.FormattingEnabled = true;
            comboEventoModificar.Location = new Point(280, 239);
            comboEventoModificar.Name = "comboEventoModificar";
            comboEventoModificar.Size = new Size(244, 23);
            comboEventoModificar.TabIndex = 25;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1309, 582);
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
            Controls.Add(linkLabel1);
            Controls.Add(dataGridView1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

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
    }
}
