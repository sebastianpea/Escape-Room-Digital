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
            _form.MostrarUserControl(new ConfiguracionUserControl());
        }
        private void btnAdministrador_Click(object sender, EventArgs e)
        {
            _form.MostrarUserControl(new AdministradorUserControl());
        }
        private void btnJugar_MouseEnter(object sender, EventArgs e)
        {
            btnJugar.ForeColor = Color.Yellow;
        }
        private void btnJugar_MouseLeave(object sender, EventArgs e)
        {
            btnJugar.ForeColor = Color.White;
        }
        private void btnConfiguración_MouseEnter(object sender, EventArgs e)
        {
            btnConfiguración.ForeColor = Color.Yellow;
        }
        private void btnConfiguración_MouseLeave(object sender, EventArgs e)
        {
            btnConfiguración.ForeColor = Color.White;
        }

        private void btnSalir_MouseEnter(object sender, EventArgs e)
        {
            btnSalir.ForeColor = Color.Yellow;
        }

        private void btnSalir_MouseLeave(object sender, EventArgs e)
        {
            btnSalir.ForeColor = Color.White;
        }

        private void btnAdministrador_MouseEnter(object sender, EventArgs e)
        {
            btnAdministrador.ForeColor = Color.Yellow;
        }

        private void btnAdministrador_MouseLeave(object sender, EventArgs e)
        {
            btnAdministrador.ForeColor = Color.White;
        }
    }
}
