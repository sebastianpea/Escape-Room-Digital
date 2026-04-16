using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escape_Room_Digital.UserControls
{
    public partial class NerdUserControl : AcertijoUserControl
    {
        int segundosRestantes = 60;

        public NerdUserControl()
        {
            InitializeComponent();
            timerCronómetro.Start();
            _acertijo = new AcertijoTexto(
                "Un león se esconde en una de tres habitaciones.. \nSabiendo que solamente una de esas afirmaciones es verdadera, ¿en cuál habitación está el león?(1,2 o 3)",
                "3", 0
            );
            lblAcertijo.Text = _acertijo.Pregunta;
            lblIntentos.Text = $"Intentos: {_acertijo.Intentos}";
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            timerCronómetro.Stop();
            Validar(txtRespuesta.Text);
            lblIntentos.Text = $"Intentos: {_acertijo.Intentos}";
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            timerCronómetro.Stop();
            _form.MostrarUserControl(new JugarUserControl());
        }

        private void timerCronómetro_Tick(object sender, EventArgs e)
        {
            if (segundosRestantes > 0)
            {
                segundosRestantes--;
                pbTiempo.Value = segundosRestantes;
                pbTiempo.Value = segundosRestantes + 1;
                pbTiempo.Value = segundosRestantes;
                lblCronómetro.Text = string.Format("00:00:{0:00}", segundosRestantes);
            }
            else
            {
                timerCronómetro.Stop();
                pnlNerdIncorrecto.Visible = true;
            }
        }
        protected override void AlCorrecto()
        {
            timerCronómetro.Stop();
            pnlNerd.Visible = true;
        }
        protected override void AlIncorrecto()
        {
            timerCronómetro.Stop();
            pnlNerdIncorrecto.Visible = true;
        }
        protected override void AlResolver()
        {
            timerCronómetro.Stop();
            EstadoDeJuego.TiempoRestanteNerd = segundosRestantes;
            EstadoDeJuego.NivelNerdCompletado = true;
            EstadoDeJuego.cantidadNivelesCompletados++;
            _form.MostrarUserControl(new JugarUserControl());
        }

        private void btnContinuarRight_Click(object sender, EventArgs e)
        {
            AlResolver();
        }

        private void pnlNerd_Paint(object sender, PaintEventArgs e)
        {
            int grosor = 3;
            Color colorBorde = Color.White;

            using (Pen pen = new Pen(colorBorde, grosor))
            {
                int offset = grosor / 2;
                e.Graphics.DrawRectangle(pen,
                    offset,
                    offset,
                    pnlNerd.ClientSize.Width - grosor,
                    pnlNerd.ClientSize.Height - grosor);
            }
        }

        private void btnContinuarFail_Click(object sender, EventArgs e)
        {
            timerCronómetro.Stop();
            _form.MostrarUserControl(new MenuUserControl());
        }

        private void pnlNerdIncorrecto_Paint(object sender, PaintEventArgs e)
        {
            int grosor = 3;
            Color colorBorde = Color.White;

            using (Pen pen = new Pen(colorBorde, grosor))
            {
                int offset = grosor / 2;
                e.Graphics.DrawRectangle(pen,
                    offset,
                    offset,
                    pnlNerdIncorrecto.ClientSize.Width - grosor,
                    pnlNerdIncorrecto.ClientSize.Height - grosor);
            }
        }

        private void btnValidar_MouseEnter(object sender, EventArgs e)
        {
            btnValidar.ForeColor = Color.Yellow;
        }

        private void btnValidar_MouseLeave(object sender, EventArgs e)
        {
            btnValidar.ForeColor = Color.White;
        }

        private void btnContinuarRight_MouseEnter(object sender, EventArgs e)
        {
            btnContinuarRight.ForeColor = Color.Yellow;
        }

        private void btnContinuarRight_MouseLeave(object sender, EventArgs e)
        {
            btnContinuarRight.ForeColor = Color.White;
        }

        private void btnContinuarFail_MouseEnter(object sender, EventArgs e)
        {
            btnContinuarFail.ForeColor = Color.Yellow;
        }

        private void btnContinuarFail_MouseLeave(object sender, EventArgs e)
        {
            btnContinuarFail.ForeColor = Color.White;
        }

        private void btnVolver_MouseEnter(object sender, EventArgs e)
        {
            btnVolver.ForeColor= Color.Yellow;
        }

        private void btnVolver_MouseLeave(object sender, EventArgs e)
        {
            btnVolver.ForeColor = Color.White;
        }
    }
}