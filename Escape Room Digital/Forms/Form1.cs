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
        }
    }
}
