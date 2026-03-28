using Escape_Room_Digital.UserControls;
using System.Drawing.Text;

namespace Escape_Room_Digital
{
    public partial class Form1 : Form
    {
        private ConfiguracionUserControl configuracionUserControl;
        private JugarUserControl jugarUserControl;
        private AdministradorUserControl administradorUserControl;
        private MenuUserControl menuUserControl;
        public Form1()
        {
        InitializeComponent();

            configuracionUserControl = new ConfiguracionUserControl();
            jugarUserControl = new JugarUserControl();
            administradorUserControl = new AdministradorUserControl();
            menuUserControl = new MenuUserControl();

            configuracionUserControl.Dock = DockStyle.Fill;
            jugarUserControl.Dock = DockStyle.Fill;
            administradorUserControl.Dock = DockStyle.Fill;
            menuUserControl.Dock = DockStyle.Fill;

            this.Controls.Add(configuracionUserControl);
            this.Controls.Add(jugarUserControl);
            this.Controls.Add(administradorUserControl);
            this.Controls.Add(menuUserControl);

            MostrarPanel(menuUserControl);
        }
        private void MostrarPanel (UserControl panelActivo)
        {
            menuUserControl.Visible = false;
            jugarUserControl.Visible = false;
            administradorUserControl.Visible = false;
            configuracionUserControl.Visible = false;

            panelActivo.Visible = true;
            panelActivo.BringToFront();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
