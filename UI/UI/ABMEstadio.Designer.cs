namespace UI
{
    partial class ABMEstadio
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
            label4 = new Label();
            panel1 = new Panel();
            linkVolver = new LinkLabel();
            linkLabel1 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            linkLabel3 = new LinkLabel();
            dataGridView1 = new DataGridView();
            txtNombreAgregar = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            button1 = new Button();
            label14 = new Label();
            button2 = new Button();
            textBox8 = new TextBox();
            label15 = new Label();
            label7 = new Label();
            label8 = new Label();
            textBox13 = new TextBox();
            button4 = new Button();
            label3 = new Label();
            textBox15 = new TextBox();
            label5 = new Label();
            textBox14 = new TextBox();
            textBox12 = new TextBox();
            label6 = new Label();
            button3 = new Button();
            linkCerrarSesion = new LinkLabel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label4.Location = new Point(27, 100);
            label4.Name = "label4";
            label4.Size = new Size(201, 35);
            label4.TabIndex = 103;
            label4.Text = "Agregar Estadio";
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
            panel1.TabIndex = 104;
            // 
            // linkVolver
            // 
            linkVolver.AutoSize = true;
            linkVolver.BackColor = Color.Transparent;
            linkVolver.LinkColor = SystemColors.ControlLightLight;
            linkVolver.Location = new Point(34, 19);
            linkVolver.Name = "linkVolver";
            linkVolver.Size = new Size(96, 20);
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
            linkLabel1.Location = new Point(189, 19);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(95, 20);
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
            linkLabel2.Location = new Point(343, 19);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(90, 20);
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
            linkLabel3.Location = new Point(491, 19);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(94, 20);
            linkLabel3.TabIndex = 59;
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
            dataGridView1.TabIndex = 105;
            // 
            // txtNombreAgregar
            // 
            txtNombreAgregar.AutoSize = true;
            txtNombreAgregar.Location = new Point(27, 149);
            txtNombreAgregar.Name = "txtNombreAgregar";
            txtNombreAgregar.Size = new Size(145, 20);
            txtNombreAgregar.TabIndex = 106;
            txtNombreAgregar.Text = "Nombre del Estadio:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(27, 176);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(251, 27);
            textBox1.TabIndex = 107;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 224);
            label1.Name = "label1";
            label1.Size = new Size(153, 20);
            label1.TabIndex = 108;
            label1.Text = "Dirección del Estadio:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(27, 251);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(251, 27);
            textBox2.TabIndex = 109;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 299);
            label2.Name = "label2";
            label2.Size = new Size(161, 20);
            label2.TabIndex = 110;
            label2.Text = "Capacidad del Estadio:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(27, 325);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(251, 27);
            textBox3.TabIndex = 111;
            // 
            // button1
            // 
            button1.Location = new Point(27, 640);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(251, 53);
            button1.TabIndex = 112;
            button1.Text = "Agregar Estadio";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label14.Location = new Point(601, 100);
            label14.Name = "label14";
            label14.Size = new Size(201, 35);
            label14.TabIndex = 113;
            label14.Text = "Eliminar Estadio";
            // 
            // button2
            // 
            button2.Location = new Point(601, 220);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(251, 48);
            button2.TabIndex = 116;
            button2.Text = "Eliminar Estadio";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(601, 176);
            textBox8.Margin = new Padding(3, 4, 3, 4);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(251, 27);
            textBox8.TabIndex = 115;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(601, 149);
            label15.Name = "label15";
            label15.Size = new Size(171, 20);
            label15.TabIndex = 114;
            label15.Text = "ID de estadio a eliminar:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label7.Location = new Point(314, 100);
            label7.Name = "label7";
            label7.Size = new Size(219, 35);
            label7.TabIndex = 117;
            label7.Text = "Modificar Estadio";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(314, 149);
            label8.Name = "label8";
            label8.Size = new Size(181, 20);
            label8.TabIndex = 118;
            label8.Text = "ID de estadio a modificar:";
            // 
            // textBox13
            // 
            textBox13.Location = new Point(314, 176);
            textBox13.Margin = new Padding(3, 4, 3, 4);
            textBox13.Name = "textBox13";
            textBox13.Size = new Size(251, 27);
            textBox13.TabIndex = 119;
            // 
            // button4
            // 
            button4.Location = new Point(314, 220);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(251, 48);
            button4.TabIndex = 120;
            button4.Text = "Buscar Estadio";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(314, 283);
            label3.Name = "label3";
            label3.Size = new Size(135, 20);
            label3.TabIndex = 121;
            label3.Text = "Modificar Nombre:";
            // 
            // textBox15
            // 
            textBox15.Location = new Point(314, 307);
            textBox15.Margin = new Padding(3, 4, 3, 4);
            textBox15.Name = "textBox15";
            textBox15.Size = new Size(251, 27);
            textBox15.TabIndex = 122;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(314, 357);
            label5.Name = "label5";
            label5.Size = new Size(143, 20);
            label5.TabIndex = 123;
            label5.Text = "Modificar Dirección:";
            // 
            // textBox14
            // 
            textBox14.Location = new Point(314, 381);
            textBox14.Margin = new Padding(3, 4, 3, 4);
            textBox14.Name = "textBox14";
            textBox14.Size = new Size(251, 27);
            textBox14.TabIndex = 124;
            // 
            // textBox12
            // 
            textBox12.Location = new Point(314, 456);
            textBox12.Margin = new Padding(3, 4, 3, 4);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(251, 27);
            textBox12.TabIndex = 126;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(314, 432);
            label6.Name = "label6";
            label6.Size = new Size(151, 20);
            label6.TabIndex = 125;
            label6.Text = "Modificar Capacidad:";
            // 
            // button3
            // 
            button3.Location = new Point(314, 640);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(251, 53);
            button3.TabIndex = 127;
            button3.Text = "Modificar Estadio";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // linkCerrarSesion
            // 
            linkCerrarSesion.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            linkCerrarSesion.AutoSize = true;
            linkCerrarSesion.BackColor = Color.Transparent;
            linkCerrarSesion.LinkColor = Color.FromArgb(226, 232, 240);
            linkCerrarSesion.Location = new Point(1364, 19);
            linkCerrarSesion.Name = "linkCerrarSesion";
            linkCerrarSesion.Size = new Size(96, 20);
            linkCerrarSesion.TabIndex = 60;
            linkCerrarSesion.TabStop = true;
            linkCerrarSesion.Text = "Cerrar Sesión";
            linkCerrarSesion.LinkClicked += linkCerrarSesion_LinkClicked;
            // 
            // ABMEstadio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1463, 907);
            Controls.Add(button3);
            Controls.Add(textBox12);
            Controls.Add(label6);
            Controls.Add(textBox14);
            Controls.Add(label5);
            Controls.Add(textBox15);
            Controls.Add(label3);
            Controls.Add(button4);
            Controls.Add(textBox13);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(button2);
            Controls.Add(textBox8);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(txtNombreAgregar);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Controls.Add(label4);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ABMEstadio";
            Text = "ABMEstadio";
            Load += ABMEstadio_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Panel panel1;
        private LinkLabel linkVolver;
        private LinkLabel linkLabel3;
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
        private DataGridView dataGridView1;
        private Label txtNombreAgregar;
        private TextBox textBox1;
        private Label label1;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox3;
        private Button button1;
        private Label label14;
        private Button button2;
        private TextBox textBox8;
        private Label label15;
        private Label label7;
        private Label label8;
        private TextBox textBox13;
        private Button button4;
        private Label label3;
        private TextBox textBox15;
        private Label label5;
        private TextBox textBox14;
        private TextBox textBox12;
        private Label label6;
        private Button button3;
        private LinkLabel linkCerrarSesion;
    }
}