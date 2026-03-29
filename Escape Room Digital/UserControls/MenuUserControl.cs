using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escape_Room_Digital.UserControls
{
    public partial class MenuUserControl : UserControl
    {
        private Form1 _form;
        public void SetForm(Form1 form)
        {
            _form = form;
        }

        public MenuUserControl()
        {
            InitializeComponent();
        }
        private void btnJugar_Click(object sender, EventArgs e)
        {
            _form.MostrarUserControl(new JugarUserControl());
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnConfiguración_Click(object sender, EventArgs e)
        {
            _form.MostrarUserControl(new AdministradorUserControl());
        }

        private void btnAdministrador_Click(object sender, EventArgs e)
        {
            _form.MostrarUserControl(new AdministradorUserControl());
        }
    }
}
