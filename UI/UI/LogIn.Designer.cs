namespace UI
{
    partial class LogIn
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
            panelHeader = new Panel();
            lblBrand = new Label();
            panelCard = new Panel();
            label1 = new Label();
            lblSubtitulo = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            button1 = new Button();
            panelHeader.SuspendLayout();
            panelCard.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(30, 41, 59);
            panelHeader.Controls.Add(lblBrand);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(760, 48);
            panelHeader.TabIndex = 0;
            // 
            // lblBrand
            // 
            lblBrand.AutoSize = true;
            lblBrand.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            lblBrand.ForeColor = Color.White;
            lblBrand.Location = new Point(24, 14);
            lblBrand.Name = "lblBrand";
            lblBrand.Size = new Size(215, 19);
            lblBrand.TabIndex = 0;
            lblBrand.Text = "SAC · Sistema de Entradas";
            // 
            // panelCard
            // 
            panelCard.BackColor = Color.White;
            panelCard.Controls.Add(label1);
            panelCard.Controls.Add(lblSubtitulo);
            panelCard.Controls.Add(label2);
            panelCard.Controls.Add(textBox1);
            panelCard.Controls.Add(label3);
            panelCard.Controls.Add(textBox2);
            panelCard.Controls.Add(button1);
            panelCard.Location = new Point(160, 82);
            panelCard.Name = "panelCard";
            panelCard.Size = new Size(440, 330);
            panelCard.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.Location = new Point(40, 28);
            label1.Name = "label1";
            label1.Size = new Size(165, 30);
            label1.TabIndex = 7;
            label1.Text = "Iniciar Sesión";
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.ForeColor = Color.FromArgb(100, 116, 139);
            lblSubtitulo.Location = new Point(42, 62);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(340, 15);
            lblSubtitulo.TabIndex = 13;
            lblSubtitulo.Text = "Gestión de entradas, clientes, eventos y estadios";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 102);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 9;
            label2.Text = "Usuario:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 10F);
            textBox1.Location = new Point(42, 122);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Usuario123";
            textBox1.Size = new Size(356, 25);
            textBox1.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 166);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 11;
            label3.Text = "Contraseña:";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 10F);
            textBox2.Location = new Point(42, 186);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.PlaceholderText = "••••••••••••";
            textBox2.Size = new Size(356, 25);
            textBox2.TabIndex = 10;
            // 
            // button1
            // 
            button1.Location = new Point(42, 240);
            button1.Name = "button1";
            button1.Size = new Size(356, 44);
            button1.TabIndex = 12;
            button1.Text = "Iniciar Sesión";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // LogIn
            // 
            AcceptButton = button1;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(760, 455);
            Controls.Add(panelCard);
            Controls.Add(panelHeader);
            Name = "LogIn";
            Text = "LogIn";
            Load += LogIn_Load;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelCard.ResumeLayout(false);
            panelCard.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label lblBrand;
        private Panel panelCard;
        private Label lblSubtitulo;
        private Button button1;
        private Label label3;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
    }
}