using Escape_Room_Digital.UserControls;
using System.Drawing.Text;

namespace Escape_Room_Digital
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MostrarUserControl(new MenuUserControl());
            this.KeyPreview = true;
            this.Focus();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.Controls[0] is JugarUserControl jugar)
            {
                jugar.HabilitarTeclas(e.KeyCode, true);
            }

        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (this.Controls[0] is JugarUserControl jugar)
            {
                jugar.HabilitarTeclas(e.KeyCode, false);
            }
        }
        public void MostrarUserControl(UserControl userControl)
        {
            this.Controls.Clear();

            if (userControl is MenuUserControl menuUserControl)
            {
                menuUserControl.SetForm(this);
            }
            else if (userControl is JugarUserControl jugarUserControl)
            {
                jugarUserControl.SetForm(this);
            }
            else if (userControl is ConfiguracionUserControl configuracionUserControl)
            {
                configuracionUserControl.SetForm(this);
            }
            else if (userControl is AdministradorUserControl administradorUserControl)
            {
                administradorUserControl.SetForm(this);
            }
            userControl.Dock = DockStyle.Fill;
            this.Controls.Add(userControl);
            this.Focus();
        }


    }
}
