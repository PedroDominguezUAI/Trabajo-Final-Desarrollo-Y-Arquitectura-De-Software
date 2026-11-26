namespace UI
{
    partial class ABMUsuario
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
            linkCerrarSesion = new LinkLabel();
            linkLabel1 = new LinkLabel();
            linkLabel4 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            linkLabel3 = new LinkLabel();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            textBox5 = new TextBox();
            label5 = new Label();
            textBox6 = new TextBox();
            label6 = new Label();
            textBox7 = new TextBox();
            label7 = new Label();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            label9 = new Label();
            label10 = new Label();
            button2 = new Button();
            textBox8 = new TextBox();
            label11 = new Label();
            label12 = new Label();
            button3 = new Button();
            textBox9 = new TextBox();
            label13 = new Label();
            textBox10 = new TextBox();
            label14 = new Label();
            textBox11 = new TextBox();
            label15 = new Label();
            textBox12 = new TextBox();
            label16 = new Label();
            textBox14 = new TextBox();
            label18 = new Label();
            textBox15 = new TextBox();
            label19 = new Label();
            button4 = new Button();
            textBox13 = new TextBox();
            label17 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 41, 59);
            panel1.Controls.Add(linkCerrarSesion);
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(linkLabel4);
            panel1.Controls.Add(linkLabel2);
            panel1.Controls.Add(linkLabel3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1280, 45);
            panel1.TabIndex = 64;
            // 
            // linkCerrarSesion
            // 
            linkCerrarSesion.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            linkCerrarSesion.AutoSize = true;
            linkCerrarSesion.BackColor = Color.Transparent;
            linkCerrarSesion.LinkColor = Color.FromArgb(226, 232, 240);
            linkCerrarSesion.Location = new Point(1186, 14);
            linkCerrarSesion.Name = "linkCerrarSesion";
            linkCerrarSesion.Size = new Size(76, 15);
            linkCerrarSesion.TabIndex = 64;
            linkCerrarSesion.TabStop = true;
            linkCerrarSesion.Text = "Cerrar Sesión";
            linkCerrarSesion.LinkClicked += linkCerrarSesion_LinkClicked;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.Transparent;
            linkLabel1.LinkColor = SystemColors.ControlLightLight;
            linkLabel1.Location = new Point(30, 14);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(76, 15);
            linkLabel1.TabIndex = 0;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "ABM Entrada";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // linkLabel4
            // 
            linkLabel4.AutoSize = true;
            linkLabel4.BackColor = Color.Transparent;
            linkLabel4.LinkColor = SystemColors.ControlLightLight;
            linkLabel4.Location = new Point(165, 14);
            linkLabel4.Name = "linkLabel4";
            linkLabel4.Size = new Size(76, 15);
            linkLabel4.TabIndex = 61;
            linkLabel4.TabStop = true;
            linkLabel4.Text = "ABM Usuario";
            linkLabel4.LinkClicked += linkLabel4_LinkClicked;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.BackColor = Color.Transparent;
            linkLabel2.LinkColor = SystemColors.ControlLightLight;
            linkLabel2.Location = new Point(300, 14);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(72, 15);
            linkLabel2.TabIndex = 62;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 112);
            label1.Name = "label1";
            label1.Size = new Size(97, 15);
            label1.TabIndex = 1;
            label1.Text = "Nombre Usuario:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(24, 132);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(105, 23);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(24, 188);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(105, 23);
            textBox2.TabIndex = 4;
            textBox2.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 168);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 3;
            label2.Text = "Password:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(24, 244);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(105, 23);
            textBox3.TabIndex = 6;
            textBox3.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 224);
            label3.Name = "label3";
            label3.Size = new Size(100, 15);
            label3.TabIndex = 5;
            label3.Text = "Repetir Password:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(24, 300);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(220, 23);
            textBox4.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 280);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 7;
            label4.Text = "Nombre:";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(139, 188);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(105, 23);
            textBox5.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(139, 168);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 9;
            label5.Text = "Apellido:";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(139, 244);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(105, 23);
            textBox6.TabIndex = 12;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(139, 224);
            label6.Name = "label6";
            label6.Size = new Size(30, 15);
            label6.TabIndex = 11;
            label6.Text = "DNI:";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(139, 132);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(105, 23);
            textBox7.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(139, 112);
            label7.Name = "label7";
            label7.Size = new Size(39, 15);
            label7.TabIndex = 13;
            label7.Text = "Email:";
            // 
            // button1
            // 
            button1.Location = new Point(24, 480);
            button1.Name = "button1";
            button1.Size = new Size(220, 40);
            button1.TabIndex = 15;
            button1.Text = "Agregar Usuario";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(775, 75);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(480, 580);
            dataGridView1.TabIndex = 16;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label9.Location = new Point(24, 75);
            label9.Name = "label9";
            label9.Size = new Size(166, 28);
            label9.TabIndex = 18;
            label9.Text = "Agregar Usuario";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label10.Location = new Point(526, 75);
            label10.Name = "label10";
            label10.Size = new Size(168, 28);
            label10.TabIndex = 19;
            label10.Text = "Eliminar Usuario";
            // 
            // button2
            // 
            button2.Location = new Point(526, 165);
            button2.Name = "button2";
            button2.Size = new Size(220, 36);
            button2.TabIndex = 22;
            button2.Text = "Eliminar Usuario";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(526, 132);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(220, 23);
            textBox8.TabIndex = 21;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(526, 112);
            label11.Name = "label11";
            label11.Size = new Size(134, 15);
            label11.TabIndex = 20;
            label11.Text = "ID de usuario a eliminar:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label12.Location = new Point(275, 75);
            label12.Name = "label12";
            label12.Size = new Size(182, 28);
            label12.TabIndex = 38;
            label12.Text = "Modificar Usuario";
            // 
            // button3
            // 
            button3.Location = new Point(275, 480);
            button3.Name = "button3";
            button3.Size = new Size(220, 40);
            button3.TabIndex = 37;
            button3.Text = "Modificar Usuario";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(390, 230);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(105, 23);
            textBox9.TabIndex = 36;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(390, 212);
            label13.Name = "label13";
            label13.Size = new Size(39, 15);
            label13.TabIndex = 35;
            label13.Text = "Email:";
            // 
            // textBox10
            // 
            textBox10.Location = new Point(390, 342);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(105, 23);
            textBox10.TabIndex = 34;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(390, 324);
            label14.Name = "label14";
            label14.Size = new Size(30, 15);
            label14.TabIndex = 33;
            label14.Text = "DNI:";
            // 
            // textBox11
            // 
            textBox11.Location = new Point(390, 286);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(105, 23);
            textBox11.TabIndex = 32;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(390, 268);
            label15.Name = "label15";
            label15.Size = new Size(54, 15);
            label15.TabIndex = 31;
            label15.Text = "Apellido:";
            // 
            // textBox12
            // 
            textBox12.Location = new Point(275, 342);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(105, 23);
            textBox12.TabIndex = 30;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(275, 324);
            label16.Name = "label16";
            label16.Size = new Size(54, 15);
            label16.TabIndex = 29;
            label16.Text = "Nombre:";
            // 
            // textBox14
            // 
            textBox14.Location = new Point(275, 286);
            textBox14.Name = "textBox14";
            textBox14.Size = new Size(105, 23);
            textBox14.TabIndex = 26;
            textBox14.UseSystemPasswordChar = true;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(275, 268);
            label18.Name = "label18";
            label18.Size = new Size(60, 15);
            label18.TabIndex = 25;
            label18.Text = "Password:";
            // 
            // textBox15
            // 
            textBox15.Location = new Point(275, 230);
            textBox15.Name = "textBox15";
            textBox15.Size = new Size(105, 23);
            textBox15.TabIndex = 24;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(275, 212);
            label19.Name = "label19";
            label19.Size = new Size(97, 15);
            label19.TabIndex = 23;
            label19.Text = "Nombre Usuario:";
            // 
            // button4
            // 
            button4.Location = new Point(275, 165);
            button4.Name = "button4";
            button4.Size = new Size(220, 36);
            button4.TabIndex = 41;
            button4.Text = "Buscar Usuario";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // textBox13
            // 
            textBox13.Location = new Point(275, 132);
            textBox13.Name = "textBox13";
            textBox13.Size = new Size(220, 23);
            textBox13.TabIndex = 40;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(275, 112);
            label17.Name = "label17";
            label17.Size = new Size(142, 15);
            label17.TabIndex = 39;
            label17.Text = "ID de usuario a modificar:";
            // 
            // ABMUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 680);
            Controls.Add(panel1);
            Controls.Add(button4);
            Controls.Add(textBox13);
            Controls.Add(label17);
            Controls.Add(label12);
            Controls.Add(button3);
            Controls.Add(textBox9);
            Controls.Add(label13);
            Controls.Add(textBox10);
            Controls.Add(label14);
            Controls.Add(textBox11);
            Controls.Add(label15);
            Controls.Add(textBox12);
            Controls.Add(label16);
            Controls.Add(textBox14);
            Controls.Add(label18);
            Controls.Add(textBox15);
            Controls.Add(label19);
            Controls.Add(button2);
            Controls.Add(textBox8);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(textBox7);
            Controls.Add(label7);
            Controls.Add(textBox6);
            Controls.Add(label6);
            Controls.Add(textBox5);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "ABMUsuario";
            Text = "ABMUsuario";
            Load += ABMUsuario_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private LinkLabel linkLabel1;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox4;
        private Label label4;
        private TextBox textBox5;
        private Label label5;
        private TextBox textBox6;
        private Label label6;
        private TextBox textBox7;
        private Label label7;
        private Button button1;
        private DataGridView dataGridView1;
        private Label label9;
        private Label label10;
        private Button button2;
        private TextBox textBox8;
        private Label label11;
        private Label label12;
        private Button button3;
        private TextBox textBox9;
        private Label label13;
        private TextBox textBox10;
        private Label label14;
        private TextBox textBox11;
        private Label label15;
        private TextBox textBox12;
        private Label label16;
        private TextBox textBox14;
        private Label label18;
        private TextBox textBox15;
        private Label label19;
        private Button button4;
        private TextBox textBox13;
        private Label label17;
        private LinkLabel linkLabel3;
        private LinkLabel linkLabel2;
        private LinkLabel linkLabel4;
        private LinkLabel linkCerrarSesion;
    }
}