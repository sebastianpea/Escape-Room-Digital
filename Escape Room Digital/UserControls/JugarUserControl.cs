using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace Escape_Room_Digital.UserControls
{
    public partial class JugarUserControl : UserControl, IControlConMovimiento
    {
        private Form1 _form;
        private int frameActual = 0;
        private Image[] framesActuales;
        private Image[] framesAnimacionAbajo;
        private Image[] framesAnimacionArriba;
        private Image[] framesAnimacionDerecha;
        private Image[] framesAnimacionIzquierda;
        private List<ObjetoInteractuable> objetos;
        private ObjetoInteractuable objetoCercano = null;

        public void SetForm(Form1 form)
        {
            _form = form;
            objetos = new List<ObjetoInteractuable>
            {
                new NPC_Nerd(pbNerd, this),
                new NPC_Jester(pbJester, this),
                new NPC_Ghost(pbGhost, this),
                new NPC_ShortSkeleton(pbShortSkeleton, this),
                new NPC_Turtle(pbTurtle, this)
            };

            if (EstadoDeJuego.HabloConLaTortuga == true)
            {
                lblMision.Visible = false;
            }
        }

        public JugarUserControl()
        {
            InitializeComponent();
            btnVolver.TabStop = false;
            btnSiNerd.TabStop = false;
            btnNoNerd.TabStop = false;
            btnSiJester.TabStop = false;
            btnNoJester.TabStop = false;
            btnSiGhost.TabStop = false;
            btnNoGhost.TabStop = false;
            btnSiShortSkeleton.TabStop = false;
            btnNoShortSkeleton.TabStop = false;

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
                    if (objetoCercano is NPC_Nerd)
                        if (EstadoDeJuego.NivelNerdCompletado == true)
                        {
                            lblDialogoNerd.Text = "Ya has completado este nivel.\n¡Intenta con otro personaje!";
                            btnSiNerd.Visible = false;
                            btnNoNerd.Visible = false;
                            btnOkNerd.Visible = true;
                            pnlDialogoNerd.Visible = true;
                            pnlDialogoNerd.BringToFront();
                        }

                        else
                        {
                            lblDialogoNerd.Text = objetoCercano.TextoDialogo;
                            pnlDialogoNerd.Visible = true;
                            pnlDialogoNerd.BringToFront();
                        }
                    else if (objetoCercano is NPC_Jester)
                        if (EstadoDeJuego.NivelJesterCompletado == true)
                        {
                            lblDialogoJester.Text = "Ya has completado este nivel.\n¡Intenta con otro personaje!";
                            btnSiJester.Visible = false;
                            btnNoJester.Visible = false;
                            btnOkJester.Visible = true;
                            pnlDialogoJester.Visible = true;
                            pnlDialogoJester.BringToFront();
                        }
                        else
                        {
                            lblDialogoJester.Text = objetoCercano.TextoDialogo;
                            pnlDialogoJester.Visible = true;
                            pnlDialogoJester.BringToFront();
                        }
                    else if (objetoCercano is NPC_Ghost)
                        if (EstadoDeJuego.NivelGhostCompletado == true)
                        {
                            lblDialogoGhost.Text = "Ya has completado este nivel.\n¡Intenta con otro personaje!";
                            btnSiGhost.Visible = false;
                            btnNoGhost.Visible = false;
                            btnOkGhost.Visible = true;
                            pnlDialogoGhost.Visible = true;
                            pnlDialogoGhost.BringToFront();
                        }
                        else
                        {
                            lblDialogoGhost.Text = objetoCercano.TextoDialogo;
                            pnlDialogoGhost.Visible = true;
                            pnlDialogoGhost.BringToFront();
                        }
                    else if (objetoCercano is NPC_ShortSkeleton)
                        if (EstadoDeJuego.NivelShortSkeletonCompletado == true)
                        {
                            lblDialogoShortSkeleton.Text = "Ya has completado este nivel.\n¡Intenta con otro personaje!";
                            btnSiShortSkeleton.Visible = false;
                            btnNoShortSkeleton.Visible = false;
                            btnOkShortSkeleton.Visible = true;
                            pnlDialogoShortSkeleton.Visible = true;
                            pnlDialogoShortSkeleton.BringToFront();
                        }
                        else
                        {
                            lblDialogoShortSkeleton.Text = objetoCercano.TextoDialogo;
                            pnlDialogoShortSkeleton.Visible = true;
                            pnlDialogoShortSkeleton.BringToFront();
                        }
                    else if (objetoCercano is NPC_Turtle)
                    {
                        if (EstadoDeJuego.cantidadNivelesCompletados >= 4)
                        {
                            pnlTurtle.Visible = true;

                            lblTurtle.Text = "¡Has completado el juego! Gracias por \njugar.";
                            btnOkTurtle.Visible = false;
                            btnContinuarTurtle.Visible = true;

                        }
                        else
                        {
                            if (EstadoDeJuego.HabloConLaTortuga == false)
                            {
                                lblTurtle.Text = objetoCercano.TextoDialogo;
                                pnlTurtle.Visible = true;
                                EstadoDeJuego.HabloConLaTortuga = true;
                                lblMision.Visible = false;
                                pnlTurtle.BringToFront();
                            }
                            else
                            {
                                pnlTurtle.Visible = true;
                                lblTurtle.Text = "Completa los Acertijos y Rompecabezas \nde mis compañeros y podrás escapar, \nasi que, adelante amigo!";
                                lblMision.Visible = false;
                                lblTurtle.BringToFront();
                            }
                        }
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
                if (framesActuales != null)
                    pbJugador.Image = framesActuales[0];
            }
        }

        // Nerd
        private void btnSiNerd_Click(object sender, EventArgs e)
        {
            pnlDialogoNerd.Visible = false;
            var nerd = new NerdUserControl();
            nerd.SetForm(_form);
            _form.MostrarUserControl(nerd);
        }
        private void btnNoNerd_Click(object sender, EventArgs e)
        {
            pnlDialogoNerd.Visible = false;
            btnNoNerd.TabStop = false;
            _form.Select();

        }

        // Jester
        private void btnSiJester_Click(object sender, EventArgs e)
        {
            pnlDialogoJester.Visible = false;
            var jester = new JesterUserControl();
            jester.SetForm(_form);
            _form.MostrarUserControl(jester);
        }
        private void btnNoJester_Click(object sender, EventArgs e)
        {
            pnlDialogoJester.Visible = false;
            btnNoJester.TabStop = false;
            _form.Select();
        }

        // Ghost
        private void btnSiGhost_Click(object sender, EventArgs e)
        {
            pnlDialogoGhost.Visible = false;
            var ghost = new GhostUserControl();
            ghost.SetForm(_form);
            _form.MostrarUserControl(ghost);
        }
        private void btnNoGhost_Click(object sender, EventArgs e)
        {
            pnlDialogoGhost.Visible = false;
            btnNoGhost.TabStop = false;
            _form.Select();
        }

        // ShortSkeleton
        private void btnSiShortSkeleton_Click(object sender, EventArgs e)
        {
            pnlDialogoShortSkeleton.Visible = false;
            var shortSkeleton = new ShortSkeletonUserControl();
            shortSkeleton.SetForm(_form);
            _form.MostrarUserControl(shortSkeleton);
        }
        private void btnNoShortSkeleton_Click(object sender, EventArgs e)
        {
            pnlDialogoShortSkeleton.Visible = false;
            btnNoShortSkeleton.TabStop = false;
            _form.Select();
        }

        public void btnVolver_Click(object sender, EventArgs e)
        {
            _form.MostrarUserControl(new MenuUserControl());
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

        private void VerificarProximidad()
        {

            objetoCercano = null;
            pbNerdCloud.Visible = false;
            pbGhostCloud.Visible = false;
            pbJesterCloud.Visible = false;
            pbShortSkeletonCloud.Visible = false;
            pbTurtleCloud.Visible = false;
            foreach (var obj in objetos)
            {
                if (obj.EstaCerca(pbJugador))
                {
                    objetoCercano = obj;
                    if (obj is NPC_Nerd)
                    {
                        pbNerdCloud.Visible = true;
                    }
                    else if (obj is NPC_Ghost)
                    {
                        pbGhostCloud.Visible = true;
                    }
                    else if (obj is NPC_Jester)
                    {
                        pbJesterCloud.Visible = true;
                    }
                    else if (obj is NPC_ShortSkeleton)
                    {
                        pbShortSkeletonCloud.Visible = true;
                    }
                    else if (obj is NPC_Turtle)
                    {
                        pbTurtleCloud.Visible = true;
                    }
                    break;
                }
            }
        }

        private void timerAnimacion_Tick(object sender, EventArgs e)
        {
            frameActual++;
            if (frameActual >= framesActuales.Length)
                frameActual = 0;
            pbJugador.Image = framesActuales[frameActual];
        }

        private void pnlDialogoJester_Paint(object sender, PaintEventArgs e)
        {
            int grosor = 3;
            Color colorBorde = Color.White;

            using (Pen pen = new Pen(colorBorde, grosor))
            {
                int offset = grosor / 2;
                e.Graphics.DrawRectangle(pen,
                    offset,
                    offset,
                    pnlDialogoJester.ClientSize.Width - grosor,
                    pnlDialogoJester.ClientSize.Height - grosor);
            }
        }

        private void pnlDialogoGhost_Paint(object sender, PaintEventArgs e)
        {
            int grosor = 3;
            Color colorBorde = Color.White;

            using (Pen pen = new Pen(colorBorde, grosor))
            {
                int offset = grosor / 2;
                e.Graphics.DrawRectangle(pen,
                    offset,
                    offset,
                    pnlDialogoGhost.ClientSize.Width - grosor,
                    pnlDialogoGhost.ClientSize.Height - grosor);
            }
        }

        private void pnlDialogoShortSkeleton_Paint(object sender, PaintEventArgs e)
        {
            int grosor = 3;
            Color colorBorde = Color.White;

            using (Pen pen = new Pen(colorBorde, grosor))
            {
                int offset = grosor / 2;
                e.Graphics.DrawRectangle(pen,
                    offset,
                    offset,
                    pnlDialogoShortSkeleton.ClientSize.Width - grosor,
                    pnlDialogoShortSkeleton.ClientSize.Height - grosor);
            }
        }

        private void pnlDialogoNerd_Paint(object sender, PaintEventArgs e)
        {
            int grosor = 3;
            Color colorBorde = Color.White;

            using (Pen pen = new Pen(colorBorde, grosor))
            {
                int offset = grosor / 2;
                e.Graphics.DrawRectangle(pen,
                    offset,
                    offset,
                    pnlDialogoNerd.ClientSize.Width - grosor,
                    pnlDialogoNerd.ClientSize.Height - grosor);
            }
        }

        private void pnlTurtle_Paint(object sender, PaintEventArgs e)
        {
            int grosor = 3;
            Color colorBorde = Color.White;

            using (Pen pen = new Pen(colorBorde, grosor))
            {
                int offset = grosor / 2;
                e.Graphics.DrawRectangle(pen,
                    offset,
                    offset,
                    pnlTurtle.ClientSize.Width - grosor,
                    pnlTurtle.ClientSize.Height - grosor);
            }
        }

        private void btnOkTurtle_Click(object sender, EventArgs e)
        {
            switch (EstadoDeJuego.VecesPresionado)
            {
                case 0:
                    lblTurtle.Text = "Hemos estado aqui por miles de años, \ny no hemos podido salir, somos muy viejos \npara entender estos rompecabezas";
                    break;
                case 1:
                    lblTurtle.Text = "Pero ahora que tu estas aqui, puedes \nliberarnos de esta mazmorra";
                    break;
                case 2:
                    lblTurtle.Text = "Si quieres salir, debes completar los\nacertijos y rompecabezas con mis \ncompañeros, solo asi podremos escapar \njuntos";
                    break;
                case 3:
                    lblTurtle.Text = "Completa los Acertijos y Rompecabezas \ncon nuestros compañeros y podrás escapar, \nasi que, adelante amigo!";
                    break;
                case 4:
                    pnlTurtle.Visible = false;
                    break;
                default:
                    pnlTurtle.Visible = false;
                    break;
            }
            EstadoDeJuego.VecesPresionado++;

        }

        private void btnVolver_MouseEnter(object sender, EventArgs e)
        {
            btnVolver.ForeColor = Color.Yellow;
        }

        private void btnVolver_MouseLeave(object sender, EventArgs e)
        {
            btnVolver.ForeColor = Color.White;
        }

        private void btnOkTurtle_MouseEnter(object sender, EventArgs e)
        {
            btnOkTurtle.ForeColor = Color.Yellow;
        }

        private void btnOkTurtle_MouseLeave(object sender, EventArgs e)
        {
            btnOkTurtle.ForeColor = Color.White;
        }

        private void btnSiGhost_MouseEnter(object sender, EventArgs e)
        {
            btnSiGhost.ForeColor = Color.Yellow;
        }

        private void btnSiGhost_MouseLeave(object sender, EventArgs e)
        {
            btnSiGhost.ForeColor = Color.White;
        }

        private void btnNoGhost_MouseEnter(object sender, EventArgs e)
        {
            btnNoGhost.ForeColor = Color.Yellow;
        }

        private void btnNoGhost_MouseLeave(object sender, EventArgs e)
        {
            btnNoGhost.ForeColor = Color.White;
        }

        private void btnSiShortSkeleton_MouseEnter(object sender, EventArgs e)
        {
            btnSiShortSkeleton.ForeColor = Color.Yellow;
        }

        private void btnSiShortSkeleton_MouseLeave(object sender, EventArgs e)
        {
            btnSiShortSkeleton.ForeColor = Color.White;
        }

        private void btnNoShortSkeleton_MouseEnter(object sender, EventArgs e)
        {
            btnNoShortSkeleton.ForeColor = Color.Yellow;
        }

        private void btnNoShortSkeleton_MouseLeave(object sender, EventArgs e)
        {
            btnNoShortSkeleton.ForeColor = Color.White;
        }

        private void btnSiNerd_MouseEnter(object sender, EventArgs e)
        {
            btnSiNerd.ForeColor = Color.Yellow;
        }

        private void btnSiNerd_MouseLeave(object sender, EventArgs e)
        {
            btnSiNerd.ForeColor = Color.White;
        }

        private void btnNoNerd_MouseEnter(object sender, EventArgs e)
        {
            btnNoNerd.ForeColor = Color.Yellow;
        }

        private void btnNoNerd_MouseLeave(object sender, EventArgs e)
        {
            btnNoNerd.ForeColor = Color.White;
        }

        private void btnSiJester_MouseEnter(object sender, EventArgs e)
        {
            btnSiJester.ForeColor = Color.Yellow;
        }

        private void btnSiJester_MouseLeave(object sender, EventArgs e)
        {
            btnSiJester.ForeColor = Color.White;
        }

        private void btnNoJester_MouseEnter(object sender, EventArgs e)
        {
            btnNoJester.ForeColor = Color.Yellow;
        }

        private void btnNoJester_MouseLeave(object sender, EventArgs e)
        {
            btnNoJester.ForeColor = Color.White;
        }

        private void btnOkNerd_Click(object sender, EventArgs e)
        {
            pnlDialogoNerd.Visible = false;
            btnOkNerd.TabStop = false;
            _form.Select();
        }

        private void btnOkNerd_MouseEnter(object sender, EventArgs e)
        {
            btnOkNerd.ForeColor = Color.Yellow;
        }

        private void btnOkNerd_MouseLeave(object sender, EventArgs e)
        {
            btnOkNerd.ForeColor = Color.White;
        }

        private void btnJesterOk_MouseEnter(object sender, EventArgs e)
        {
            btnOkJester.ForeColor = Color.Yellow;
        }

        private void btnJesterOk_MouseLeave(object sender, EventArgs e)
        {
            btnOkJester.ForeColor = Color.White;
        }

        private void btnOkGhost_MouseEnter(object sender, EventArgs e)
        {
            btnOkGhost.ForeColor = Color.Yellow;
        }

        private void btnOkGhost_MouseLeave(object sender, EventArgs e)
        {
            btnOkGhost.ForeColor = Color.White;
        }

        private void btnOkShortSkeleton_MouseEnter(object sender, EventArgs e)
        {
            btnOkShortSkeleton.ForeColor = Color.Yellow;
        }

        private void btnOkShortSkeleton_MouseLeave(object sender, EventArgs e)
        {
            btnOkShortSkeleton.ForeColor = Color.White;
        }

        private void btnOkGhost_Click(object sender, EventArgs e)
        {
            pnlDialogoGhost.Visible = false;
            btnOkGhost.TabStop = false;
            _form.Select();
        }
        private void btnOkJester_Click(object sender, EventArgs e)
        {
            pnlDialogoJester.Visible = false;
            btnOkJester.TabStop = false;
            _form.Select();
        }

        private void btnOkShortSkeleton_Click(object sender, EventArgs e)
        {
            pnlDialogoShortSkeleton.Visible = false;
            btnOkShortSkeleton.TabStop = false;
            _form.Select();
        }

        private void btnContinuarTurtle_Click(object sender, EventArgs e)
        {
            _form.MostrarUserControl(new CreditosUserControl());
        }

        private void btnContinuarTurtle_MouseEnter(object sender, EventArgs e)
        {
            btnContinuarTurtle.ForeColor = Color.Yellow;
        }

        private void btnContinuarTurtle_MouseLeave(object sender, EventArgs e)
        {
            btnContinuarTurtle.ForeColor = Color.White;
        }
    }
}
