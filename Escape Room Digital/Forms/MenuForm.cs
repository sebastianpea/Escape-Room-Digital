using Escape_Room_Digital.UserControls;
using System.Drawing.Text;

namespace Escape_Room_Digital
{
    public partial class MenuForm : Form
    {
        private ConfiguracionUserControl configuracionUserControl;
        private JugarUserControl jugarUserControl;
        private AdministradorUserControl administradorUserControl;
        public MenuForm()
        {
        InitializeComponent();

            configuracionUserControl = new ConfiguracionUserControl();
            jugarUserControl = new JugarUserControl();
            administradorUserControl = new AdministradorUserControl();

            configuracionUserControl.Dock = DockStyle.Fill;
            jugarUserControl.Dock = DockStyle.Fill;
            administradorUserControl.Dock = DockStyle.Fill;

            this.Controls.Add(configuracionUserControl);
            this.Controls.Add(jugarUserControl);
            this.Controls.Add(administradorUserControl);

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
