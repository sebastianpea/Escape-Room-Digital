using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Escape_Room_Digital.UserControls
{
    public partial class GhostUserControl : AcertijoUserControl, IControlConMovimiento
    {
        private int frameActual = 0;
        private Image[] framesActuales;
        private Image[] framesAnimacionAbajo;
        private Image[] framesAnimacionArriba;
        private Image[] framesAnimacionDerecha;
        private Image[] framesAnimacionIzquierda;
        private List<ObjetoInteractuable> objetos;
        private ObjetoInteractuable objetoCercano = null;
        int segundosRestantes = 60;
        int cantidadDeIntentos = 2;
        public new void SetForm(Form1 form)
        {
            _form = form;
            timerCronometro.Start();
            objetos = new List<ObjetoInteractuable>
    {
        new ObjetoInteractuable_Jeringa(pbNeedle, this),
        new ObjetoInteractuable_Piano(pbPiano, this),
        new ObjetoInteractuable_Libro(pbBook, this),
        new ObjetoInteractuable_Mapa(pbMap, this),
        new ObjetoInteractuable_Reloj(pbClock, this)
    };

        }


        public GhostUserControl()
        {
            InitializeComponent();
            btnVolver.TabStop = false;
            btnSiBook.TabStop = false;
            btnNoBook.TabStop = false;
            btnSiNeedle.TabStop = false;
            btnNoNeedle.TabStop = false;
            btnSiClock.TabStop = false;
            btnNoClock.TabStop = false;
            btnSiMap.TabStop = false;
            btnNoMap.TabStop = false;
            btnSiPiano.TabStop = false;
            btnNoPiano.TabStop = false;
            lblIntentos.Text = $"Intentos: {cantidadDeIntentos}";
            pbTiempo.Minimum = 0;
            pbTiempo.Maximum = 60;
            pbTiempo.Value = 60;

            framesAnimacionAbajo = new Image[]
            {
                Properties.Resources.SkeletonWalk3,
                Properties.Resources.SkeletonWalk1,
                Properties.Resources.SkeletonWalk4,
                Properties.Resources.SkeletonWalk2
            };
            framesAnimacionArriba = new Image[]
            {
                Properties.Resources.SkeletonUpWalk,
                Properties.Resources.SkeletonUpWalk2,
                Properties.Resources.SkeletonUpWalk3,
                Properties.Resources.SkeletonUpWalk1
            };
            framesAnimacionDerecha = new Image[]
            {
                Properties.Resources.SkeletonRightWalk,
                Properties.Resources.SkeletonRightWalk2,
                Properties.Resources.SkeletonRightWalk3,
                Properties.Resources.SkeletonRightWalk1
            };
            framesAnimacionIzquierda = new Image[]
            {
                Properties.Resources.SkeletonLeftWalk1,
                Properties.Resources.SkeletonLeftWalk2,
                Properties.Resources.SkeletonLeftWalk4,
                Properties.Resources.SkeletonLeftWalk3
            };

            framesActuales = framesAnimacionAbajo;
            pbJugador.Image = framesActuales[0];
        }

        private void CambiarFramesAnimacion(Image[] frames)
        {
            if (framesActuales != frames)
            {
                framesActuales = frames;
                frameActual = 0;
                pbJugador.Image = framesActuales[0];
            }
            timerAnimacion.Start();
        }
        public void DetenerMovimiento()
        {
            timerMoverArriba.Stop();
            timerMoverAbajo.Stop();
            timerMoverIzquierda.Stop();
            timerMoverDerecha.Stop();
            timerAnimacion.Stop();
            if (framesActuales != null)
            {
                frameActual = 0;
                pbJugador.Image = framesActuales[0];
            }
        }

        public void HabilitarTeclas(Keys tecla, bool presionada)
        {
            if (presionada)
            {
                if (tecla == Keys.Space && objetoCercano != null)
                {
                    DetenerMovimiento();
                    if (objetoCercano is ObjetoInteractuable_Jeringa)
                    {
                        lblNeedle.Text = objetoCercano.TextoDialogo;
                        pnlNeedle.Visible = true;
                    }
                    else if (objetoCercano is ObjetoInteractuable_Piano)
                    {
                        lblPiano.Text = objetoCercano.TextoDialogo;
                        pnlPiano.Visible = true;
                    }
                    else if (objetoCercano is ObjetoInteractuable_Libro)
                    {
                        lblBook.Text = objetoCercano.TextoDialogo;
                        pnlBook.Visible = true;
                    }
                    else if (objetoCercano is ObjetoInteractuable_Mapa)
                    {
                        lblDialogoMap.Text = objetoCercano.TextoDialogo;
                        pnlMap.Visible = true;
                    }
                    else if (objetoCercano is ObjetoInteractuable_Reloj)
                    {
                        lblClock.Text = objetoCercano.TextoDialogo;
                        pnlClock.Visible = true;
                    }
                    return;
                }
                if (tecla == Keys.W) { timerMoverArriba.Start(); CambiarFramesAnimacion(framesAnimacionArriba); }
                else if (tecla == Keys.A) { timerMoverIzquierda.Start(); CambiarFramesAnimacion(framesAnimacionIzquierda); }
                else if (tecla == Keys.S) { timerMoverAbajo.Start(); CambiarFramesAnimacion(framesAnimacionAbajo); }
                else if (tecla == Keys.D) { timerMoverDerecha.Start(); CambiarFramesAnimacion(framesAnimacionDerecha); }
            }
            else
            {
                timerMoverArriba.Stop();
                timerMoverAbajo.Stop();
                timerMoverIzquierda.Stop();
                timerMoverDerecha.Stop();
                timerAnimacion.Stop();
                frameActual = 0;
                pbJugador.Image = framesActuales[0];
            }
        }

        private void VerificarProximidad()
        {
            objetoCercano = null;
            pbPianoCloud.Visible = false;
            pbNeedleCloud.Visible = false;
            pbBookCloud.Visible = false;
            pbClockCloud.Visible = false;
            pbMapCloud.Visible = false;
            foreach (var obj in objetos)
            {
                if (obj.EstaCerca(pbJugador))
                {
                    objetoCercano = obj;
                    if (obj is ObjetoInteractuable_Libro)
                    {
                        pbBookCloud.Visible = true;
                    }
                    else if (obj is ObjetoInteractuable_Jeringa)
                    {
                        pbNeedleCloud.Visible = true;
                    }
                    else if (obj is ObjetoInteractuable_Mapa)
                    {
                        pbMapCloud.Visible = true;
                    }
                    else if (obj is ObjetoInteractuable_Reloj)
                    {
                        pbClockCloud.Visible = true;
                    }
                    else if (obj is ObjetoInteractuable_Piano)
                    {
                        pbPianoCloud.Visible = true;
                    }
                    break;
                }
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            _form.MostrarUserControl(new JugarUserControl());
        }

        private void timerMoverDerecha_Tick(object sender, EventArgs e)
        {
            if (pbJugador.Right < this.ClientSize.Width)
                pbJugador.Left += 5;
            VerificarProximidad();
        }

        private void timerMoverArriba_Tick(object sender, EventArgs e)
        {
            if (pbJugador.Top > 0)
                pbJugador.Top -= 5;
            VerificarProximidad();

        }

        private void timerMoverIzquierda_Tick(object sender, EventArgs e)
        {
            if (pbJugador.Left > 0)
                pbJugador.Left -= 5;
            VerificarProximidad();
        }

        private void timerMoverAbajo_Tick(object sender, EventArgs e)
        {
            if (pbJugador.Bottom < this.ClientSize.Height)
                pbJugador.Top += 5;
            VerificarProximidad();
        }

        private void timerAnimacion_Tick(object sender, EventArgs e)
        {
            frameActual++;
            if (frameActual >= framesActuales.Length)
                frameActual = 0;
            pbJugador.Image = framesActuales[frameActual];
        }

        private void timerCronometro_Tick(object sender, EventArgs e)
        {
            if (segundosRestantes > 0)
            {
                segundosRestantes--;
                if (segundosRestantes < pbTiempo.Maximum)
                {
                    pbTiempo.Value = segundosRestantes + 1;
                    pbTiempo.Value = segundosRestantes;
                }
                else
                {
                    pbTiempo.Value = segundosRestantes;
                }
                lblCronometro.Text = string.Format("00:00:{0:00}", segundosRestantes);
            }
            else
            {
                timerCronometro.Stop();
                DetenerMovimiento();
                lblFail.Text = "Oh no... Perdiste, adios\r\na nuestra libertad\r\nOh no...\r\n";
                pnlFail.Visible = true;
                btnFailContinuar.Visible = true;
            }
        }
        protected override void AlResolver()
        {
            EstadoDeJuego.TiempoRestanteGhost = segundosRestantes;
            EstadoDeJuego.NivelGhostCompletado = true;
            EstadoDeJuego.cantidadNivelesCompletados++;
        }

        private void btnSiMap_Click(object sender, EventArgs e)
        {
            lblFail.Text = "Wow, en serio lo lograste, \nfelicidades y todo eso...";
            pnlFail.Visible = true;
            btnSeguir.Visible = true;
            btnIntentar.Visible = false;
            btnFailContinuar.Visible = false;
            timerCronometro.Stop();
            AlResolver();
        }

        private void btnNoMap_Click(object sender, EventArgs e)
        {
            pnlMap.Visible = false;
            objetoCercano = null;
            VerificarProximidad();
            _form.Focus();
        }

        private void btnSiNeedle_Click(object sender, EventArgs e)
        {
            pnlFail.Visible = true;
            btnIntentar.Visible = true;
            btnFailContinuar.Visible = false;
            pnlNeedle.Visible = false;
            lblIntentos.Text = $"Intentos: {--cantidadDeIntentos}";
            VerificarIntentos();
            objetoCercano = null;
            VerificarProximidad();
            _form.Focus();
        }

        private void btnNoNeedle_Click(object sender, EventArgs e)
        {
            pnlNeedle.Visible = false;
            objetoCercano = null;
            VerificarProximidad();
            _form.Focus();
        }

        private void btnSiPiano_Click(object sender, EventArgs e)
        {
            pnlFail.Visible = true;
            btnIntentar.Visible = true;
            btnFailContinuar.Visible = false;
            pnlNeedle.Visible = false;
            pnlPiano.Visible = false;
            lblIntentos.Text = $"Intentos: {--cantidadDeIntentos}";
            VerificarIntentos();
            objetoCercano = null;
            VerificarProximidad();
            _form.Focus();
        }

        private void btnNoPiano_Click(object sender, EventArgs e)
        {
            pnlPiano.Visible = false;
            objetoCercano = null;
            VerificarProximidad();
            _form.Focus();
        }

        private void btnSiBook_Click(object sender, EventArgs e)
        {
            pnlFail.Visible = true;
            btnIntentar.Visible = true;
            btnFailContinuar.Visible = false;
            pnlNeedle.Visible = false;
            pnlBook.Visible = false;
            lblIntentos.Text = $"Intentos: {--cantidadDeIntentos}";
            VerificarIntentos();
            objetoCercano = null;
            VerificarProximidad();
            _form.Focus();
        }

        private void btnNoBook_Click(object sender, EventArgs e)
        {
            pnlBook.Visible = false;
            objetoCercano = null;
            VerificarProximidad();
            _form.Focus();
        }

        private void btnNoClock_Click(object sender, EventArgs e)
        {
            pnlClock.Visible = false;
            objetoCercano = null;
            VerificarProximidad();
            _form.Focus();
        }

        private void btnSiClock_Click(object sender, EventArgs e)
        {
            pnlFail.Visible = true;
            btnIntentar.Visible = true;
            btnFailContinuar.Visible = false;
            pnlNeedle.Visible = false;
            pnlClock.Visible = false;
            lblIntentos.Text = $"Intentos: {--cantidadDeIntentos}";
            VerificarIntentos();
            objetoCercano = null;
            VerificarProximidad();
            _form.Focus();
        }

        private void VerificarIntentos()
        {
            if (cantidadDeIntentos <= 0)
            {
                timerCronometro.Stop();
                DetenerMovimiento();
                lblFail.Text = "Oh no... Perdiste, adios\r\na nuestra libertad\r\nOh no...\r\n";
                pnlFail.Visible = true;
                btnFailContinuar.Visible = true;
                btnIntentar.Visible = false;
            }
        }

        private void btnSiClock_MouseEnter(object sender, EventArgs e)
        {
            btnSiClock.ForeColor = Color.Yellow;
        }

        private void btnSiClock_MouseLeave(object sender, EventArgs e)
        {
            btnSiClock.ForeColor = Color.White;
        }

        private void btnSiBook_MouseEnter(object sender, EventArgs e)
        {
            btnSiBook.ForeColor = Color.Yellow;
        }
        private void btnSiBook_MouseLeave(object sender, EventArgs e)
        {
            btnSiBook.ForeColor = Color.White;
        }
        private void btnNoBook_MouseEnter(object sender, EventArgs e)
        {
            btnNoBook.ForeColor = Color.Yellow;
        }
        private void btnNoBook_MouseLeave(object sender, EventArgs e)
        {
            btnNoBook.ForeColor = Color.White;
        }

        private void btnNoClock_MouseEnter(object sender, EventArgs e)
        {
            btnNoClock.ForeColor = Color.Yellow;
        }

        private void btnNoClock_MouseLeave(object sender, EventArgs e)
        {
            btnNoClock.ForeColor = Color.White;
        }

        private void btnNoNeedle_MouseEnter(object sender, EventArgs e)
        {
            btnNoNeedle.ForeColor = Color.Yellow;
        }

        private void btnNoNeedle_MouseLeave(object sender, EventArgs e)
        {
            btnNoNeedle.ForeColor = Color.White;
        }

        private void btnSiNeedle_MouseEnter(object sender, EventArgs e)
        {
            btnSiNeedle.ForeColor = Color.Yellow;
        }

        private void btnSiNeedle_MouseLeave(object sender, EventArgs e)
        {
            btnSiNeedle.ForeColor = Color.White;
        }

        private void btnNoMap_MouseEnter(object sender, EventArgs e)
        {
            btnNoMap.ForeColor = Color.Yellow;
        }

        private void btnNoMap_MouseLeave(object sender, EventArgs e)
        {
            btnNoMap.ForeColor = Color.White;
        }

        private void btnSiMap_MouseEnter(object sender, EventArgs e)
        {
            btnSiMap.ForeColor = Color.Yellow;
        }

        private void btnSiMap_MouseLeave(object sender, EventArgs e)
        {
            btnSiMap.ForeColor = Color.White;
        }

        private void btnNoPiano_MouseEnter(object sender, EventArgs e)
        {
            btnNoPiano.ForeColor = Color.Yellow;
        }

        private void btnNoPiano_MouseLeave(object sender, EventArgs e)
        {
            btnNoPiano.ForeColor = Color.White;
        }

        private void btnSiPiano_MouseEnter(object sender, EventArgs e)
        {
            btnSiPiano.ForeColor = Color.Yellow;
        }

        private void btnSiPiano_MouseLeave(object sender, EventArgs e)
        {
            btnSiPiano.ForeColor = Color.White;
        }

        private void pnlClock_Paint(object sender, PaintEventArgs e)
        {
            int grosor = 3;
            Color colorBorde = Color.White;

            using (Pen pen = new Pen(colorBorde, grosor))
            {
                int offset = grosor / 2;
                e.Graphics.DrawRectangle(pen,
                    offset,
                    offset,
                    pnlClock.ClientSize.Width - grosor,
                    pnlClock.ClientSize.Height - grosor);
            }
        }

        private void pnlBook_Paint(object sender, PaintEventArgs e)
        {
            int grosor = 3;
            Color colorBorde = Color.White;

            using (Pen pen = new Pen(colorBorde, grosor))
            {
                int offset = grosor / 2;
                e.Graphics.DrawRectangle(pen,
                    offset,
                    offset,
                    pnlBook.ClientSize.Width - grosor,
                    pnlBook.ClientSize.Height - grosor);
            }
        }

        private void pnlPiano_Paint(object sender, PaintEventArgs e)
        {
            int grosor = 3;
            Color colorBorde = Color.White;

            using (Pen pen = new Pen(colorBorde, grosor))
            {
                int offset = grosor / 2;
                e.Graphics.DrawRectangle(pen,
                    offset,
                    offset,
                    pnlPiano.ClientSize.Width - grosor,
                    pnlPiano.ClientSize.Height - grosor);
            }
        }

        private void pnlNeedle_Paint(object sender, PaintEventArgs e)
        {
            int grosor = 3;
            Color colorBorde = Color.White;

            using (Pen pen = new Pen(colorBorde, grosor))
            {
                int offset = grosor / 2;
                e.Graphics.DrawRectangle(pen,
                    offset,
                    offset,
                    pnlNeedle.ClientSize.Width - grosor,
                    pnlNeedle.ClientSize.Height - grosor);
            }
        }

        private void pnlMap_Paint(object sender, PaintEventArgs e)
        {
            int grosor = 3;
            Color colorBorde = Color.White;

            using (Pen pen = new Pen(colorBorde, grosor))
            {
                int offset = grosor / 2;
                e.Graphics.DrawRectangle(pen,
                    offset,
                    offset,
                    pnlMap.ClientSize.Width - grosor,
                    pnlMap.ClientSize.Height - grosor);
            }
        }

        private void btnFailContinuar_Click(object sender, EventArgs e)
        {
            _form.MostrarUserControl(new MenuUserControl());
        }

        private void pnlFail_Paint(object sender, PaintEventArgs e)
        {
            int grosor = 3;
            Color colorBorde = Color.White;

            using (Pen pen = new Pen(colorBorde, grosor))
            {
                int offset = grosor / 2;
                e.Graphics.DrawRectangle(pen,
                    offset,
                    offset,
                    pnlFail.ClientSize.Width - grosor,
                    pnlFail.ClientSize.Height - grosor);
            }
        }

        private void btnIntentar_Click(object sender, EventArgs e)
        {
            pnlFail.Visible = false;
        }

        private void btnSeguir_Click(object sender, EventArgs e)
        {
            _form.MostrarUserControl(new JugarUserControl());
        }

        private void btnFailContinuar_MouseEnter(object sender, EventArgs e)
        {
            btnFailContinuar.ForeColor = Color.Yellow;
        }

        private void btnFailContinuar_MouseLeave(object sender, EventArgs e)
        {
            btnFailContinuar.ForeColor = Color.White;
        }

        private void btnIntentar_MouseEnter(object sender, EventArgs e)
        {
            btnIntentar.ForeColor = Color.Yellow;
        }

        private void btnIntentar_MouseLeave(object sender, EventArgs e)
        {
            btnIntentar.ForeColor = Color.White;
        }

        private void btnSeguir_MouseEnter(object sender, EventArgs e)
        {
            btnSeguir.ForeColor = Color.Yellow;
        }

        private void btnSeguir_MouseLeave(object sender, EventArgs e)
        {
            btnSeguir.ForeColor = Color.White;
        }

        private void btnVolver_MouseEnter(object sender, EventArgs e)
        {
            btnVolver.ForeColor = Color.Yellow;
        }

        private void btnVolver_MouseLeave(object sender, EventArgs e)
        {
            btnVolver.ForeColor = Color.White;
        }
    }
}