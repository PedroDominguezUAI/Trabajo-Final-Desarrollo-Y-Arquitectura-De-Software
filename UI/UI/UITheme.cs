using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace UI
{
    public static class UiTheme
    {
        public static void AplicarEstiloNavLink(Control contenedor)
        {
            foreach (Control ctrl in contenedor.Controls)
            {
                if (ctrl is LinkLabel link)
                {
                    link.LinkBehavior = LinkBehavior.NeverUnderline;
                    link.LinkColor = Color.FromArgb(30, 41, 59);
                    link.VisitedLinkColor = Color.FromArgb(30, 41, 59);
                    link.ActiveLinkColor = Color.FromArgb(15, 23, 42);
                    link.ForeColor = link.LinkColor;
                    link.Cursor = Cursors.Hand;
                    link.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
                }

                if (ctrl.HasChildren)
                {
                    AplicarEstiloNavLink(ctrl);
                }
            }
        }

        public static void AplicarTema(Form form, string vistaActiva = "")
        {
            Color fondoApp = Color.FromArgb(241, 245, 249);
            Color navbarColor = Color.FromArgb(30, 41, 59);
            Color textoOscuro = Color.FromArgb(30, 41, 59);

            form.BackColor = fondoApp;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimumSize = new Size(1280, 680);
            form.WindowState = FormWindowState.Maximized;

            if (!string.IsNullOrEmpty(vistaActiva))
                form.Text = $"Sistema de Entradas - {vistaActiva}";

            foreach (Control ctrl in form.Controls)
            {
                // 1. Barra superior oscura
                if (ctrl is Panel pnl && pnl.Dock == DockStyle.Top)
                {
                    pnl.BackColor = navbarColor;
                    foreach (Control hijo in pnl.Controls)
                    {
                        if (hijo is LinkLabel link)
                        {
                            bool esActiva = link.Text.Equals(vistaActiva, StringComparison.OrdinalIgnoreCase);
                            link.LinkBehavior = LinkBehavior.NeverUnderline;
                            link.BackColor = Color.Transparent;
                            link.LinkColor = esActiva ? Color.FromArgb(56, 189, 248) : Color.FromArgb(226, 232, 240);
                            link.VisitedLinkColor = link.LinkColor;
                            link.ActiveLinkColor = Color.White;
                            link.Cursor = Cursors.Hand;
                            link.Font = new Font("Segoe UI", 10.5F, esActiva ? FontStyle.Bold : FontStyle.Regular);
                        }
                    }
                }

                // 2. Títulos y labels
                if (ctrl is Label lbl && !(ctrl is LinkLabel))
                {
                    lbl.ForeColor = textoOscuro;
                    if (lbl.Font.Size >= 14)
                        lbl.Font = new Font("Segoe UI", 14.5F, FontStyle.Bold);
                    else
                        lbl.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
                }

                // 3. Botones con bordes redondeados y hover
                if (ctrl is Button btn)
                {
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.ForeColor = Color.White;
                    btn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
                    btn.Cursor = Cursors.Hand;

                    string texto = btn.Text.ToLower();
                    Color baseColor = Color.FromArgb(37, 99, 235);
                    Color hoverColor = Color.FromArgb(29, 78, 216);

                    if (texto.Contains("agregar") || texto.Contains("alta"))
                    {
                        baseColor = Color.FromArgb(16, 185, 129);
                        hoverColor = Color.FromArgb(5, 150, 105);
                    }
                    else if (texto.Contains("eliminar") || texto.Contains("baja"))
                    {
                        baseColor = Color.FromArgb(239, 68, 68);
                        hoverColor = Color.FromArgb(220, 38, 38);
                    }
                    else if (texto.Contains("buscar"))
                    {
                        baseColor = Color.FromArgb(71, 85, 105);
                        hoverColor = Color.FromArgb(51, 65, 85);
                    }

                    btn.BackColor = baseColor;
                    btn.MouseEnter += (s, e) => btn.BackColor = hoverColor;
                    btn.MouseLeave += (s, e) => btn.BackColor = baseColor;
                    RedondearControl(btn, 10);
                    btn.Resize += (s, e) => RedondearControl(btn, 10);
                }

                // 4. DataGridView responsive y estilizado
                if (ctrl is DataGridView dgv)
                {
                    dgv.Width = form.ClientSize.Width - dgv.Left - 24;
                    dgv.Height = form.ClientSize.Height - dgv.Top - 24;
                    dgv.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
                    dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgv.BackgroundColor = Color.White;
                    dgv.BorderStyle = BorderStyle.None;
                    dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
                    dgv.GridColor = Color.FromArgb(226, 232, 240);
                    dgv.RowHeadersVisible = false;
                    dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    dgv.EnableHeadersVisualStyles = false;
                    dgv.RowTemplate.Height = 34;

                    dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
                    dgv.ColumnHeadersHeight = 40;
                    dgv.ColumnHeadersDefaultCellStyle.BackColor = navbarColor;
                    dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                    dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);

                    dgv.DefaultCellStyle.BackColor = Color.White;
                    dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 250, 252);
                    dgv.DefaultCellStyle.ForeColor = textoOscuro;
                    dgv.DefaultCellStyle.Font = new Font("Segoe UI", 9.5F);
                    dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(219, 234, 254);
                    dgv.DefaultCellStyle.SelectionForeColor = textoOscuro;

                    dgv.DataBindingComplete += (s, e) =>
                    {
                        if (dgv.Columns.Count > 0 && dgv.Columns[0].Name.StartsWith("Id", StringComparison.OrdinalIgnoreCase))
                        {
                            dgv.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                            dgv.Columns[0].Width = 85;
                        }
                    };
                }
            }
        }

        private static void RedondearControl(Control ctrl, int radio)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radio, radio, 180, 90);
            path.AddArc(ctrl.Width - radio, 0, radio, radio, 270, 90);
            path.AddArc(ctrl.Width - radio, ctrl.Height - radio, radio, radio, 0, 90);
            path.AddArc(0, ctrl.Height - radio, radio, radio, 90, 90);
            path.CloseAllFigures();
            ctrl.Region = new Region(path);
        }

        public static void AplicarTemaLogin(Form form)
        {
            Color fondoApp = Color.FromArgb(241, 245, 249);
            Color navbarColor = Color.FromArgb(30, 41, 59);
            Color textoOscuro = Color.FromArgb(30, 41, 59);
            Color primario = Color.FromArgb(37, 99, 235);
            Color primarioHover = Color.FromArgb(29, 78, 216);

            form.BackColor = fondoApp;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.FormBorderStyle = FormBorderStyle.FixedSingle;
            form.MaximizeBox = false;
            form.Text = "Sistema de Entradas - Iniciar Sesión";

            foreach (Control ctrl in form.Controls)
            {
                if (ctrl is Panel pnl)
                {
                    if (pnl.Dock == DockStyle.Top)
                    {
                        pnl.BackColor = navbarColor;
                        foreach (Control hijo in pnl.Controls)
                            if (hijo is Label lblHeader)
                                lblHeader.ForeColor = Color.White;
                    }
                    else
                    {
                        pnl.BackColor = Color.White;
                        RedondearControl(pnl, 14);

                        foreach (Control hijo in pnl.Controls)
                        {
                            if (hijo is Label lbl)
                            {
                                lbl.ForeColor = textoOscuro;
                                if (lbl.Font.Size >= 14)
                                    lbl.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
                                else
                                    lbl.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
                            }

                            if (hijo is Button btn)
                            {
                                btn.FlatStyle = FlatStyle.Flat;
                                btn.FlatAppearance.BorderSize = 0;
                                btn.BackColor = primario;
                                btn.ForeColor = Color.White;
                                btn.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
                                btn.Cursor = Cursors.Hand;
                                btn.MouseEnter += (s, e) => btn.BackColor = primarioHover;
                                btn.MouseLeave += (s, e) => btn.BackColor = primario;
                                RedondearControl(btn, 10);
                            }
                        }
                    }
                }
            }
        }
    }
}