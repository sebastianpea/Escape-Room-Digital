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
    public partial class ConfiguracionUserControl : UserControl
    {
        private Form1 _form;
        public void SetForm(Form1 form)
        {
            _form = form;
        }
        public ConfiguracionUserControl()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            _form.MostrarUserControl(new MenuUserControl());
        }
    }
}
