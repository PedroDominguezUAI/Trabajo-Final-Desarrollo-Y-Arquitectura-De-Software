using System.Drawing;
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
    }
}