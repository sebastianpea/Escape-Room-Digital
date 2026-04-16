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
            RegistrarHoverBotones(
    btnVolver, btnOkTurtle, btnSiGhost, btnNoGhost,
    btnSiShortSkeleton, btnNoShortSkeleton, btnSiNerd, btnNoNerd,
    btnSiJester, btnNoJester, btnOkNerd, btnOkJester,
    btnOkGhost, btnOkShortSkeleton, btnContinuarTurtle
);
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
                        MostrarDialogoNPC(pnlDialogoNerd, lblDialogoNerd, btnSiNerd, btnNoNerd, btnOkNerd,
                            objetoCercano.TextoDialogo, EstadoDeJuego.NivelNerdCompletado);
                    else if (objetoCercano is NPC_Jester)
                        MostrarDialogoNPC(pnlDialogoJester, lblDialogoJester, btnSiJester, btnNoJester, btnOkJester,
                            objetoCercano.TextoDialogo, EstadoDeJuego.NivelJesterCompletado);
                    else if (objetoCercano is NPC_Ghost)
                        MostrarDialogoNPC(pnlDialogoGhost, lblDialogoGhost, btnSiGhost, btnNoGhost, btnOkGhost,
                            objetoCercano.TextoDialogo, EstadoDeJuego.NivelGhostCompletado);
                    else if (objetoCercano is NPC_ShortSkeleton)
                        MostrarDialogoNPC(pnlDialogoShortSkeleton, lblDialogoShortSkeleton, btnSiShortSkeleton, btnNoShortSkeleton, btnOkShortSkeleton,
                            objetoCercano.TextoDialogo, EstadoDeJuego.NivelShortSkeletonCompletado);
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
            CerrarDialogo(pnlDialogoNerd, btnNoNerd);
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
            CerrarDialogo(pnlDialogoJester, btnNoJester);
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
            CerrarDialogo(pnlDialogoGhost, btnNoGhost);
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
            CerrarDialogo(pnlDialogoShortSkeleton, btnNoShortSkeleton);
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
            DibujarBorde(e, pnlDialogoJester);
        }

        private void pnlDialogoGhost_Paint(object sender, PaintEventArgs e)
        {
            DibujarBorde(e, pnlDialogoGhost);
        }

        private void pnlDialogoShortSkeleton_Paint(object sender, PaintEventArgs e)
        {
            DibujarBorde(e, pnlDialogoShortSkeleton);
        }

        private void pnlDialogoNerd_Paint(object sender, PaintEventArgs e)
        {
            DibujarBorde(e, pnlDialogoNerd);
        }

        private void pnlTurtle_Paint(object sender, PaintEventArgs e)
        {
            DibujarBorde(e, pnlTurtle);
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
        private void btnOkNerd_Click(object sender, EventArgs e)
        {
            CerrarDialogo(pnlDialogoNerd, btnOkNerd);
        }
        private void btnOkGhost_Click(object sender, EventArgs e)
        {
            CerrarDialogo(pnlDialogoGhost, btnOkGhost);
        }
        private void btnOkJester_Click(object sender, EventArgs e)
        {
            CerrarDialogo(pnlDialogoJester, btnOkJester);
        }

        private void btnOkShortSkeleton_Click(object sender, EventArgs e)
        {
            CerrarDialogo(pnlDialogoShortSkeleton, btnOkShortSkeleton);
        }

        private void btnContinuarTurtle_Click(object sender, EventArgs e)
        {
            _form.MostrarUserControl(new CreditosUserControl());
        }
        private void DibujarBorde(PaintEventArgs e, Panel panel)
        {
            int grosor = 3;
            using (Pen pen = new Pen(Color.White, grosor))
            {
                int offset = grosor / 2;
                e.Graphics.DrawRectangle(pen, offset, offset,
                    panel.ClientSize.Width - grosor,
                    panel.ClientSize.Height - grosor);
            }
        }
        private void RegistrarHoverBotones(params Button[] botones)
        {
            foreach (var btn in botones)
            {
                btn.MouseEnter += (s, e) => btn.ForeColor = Color.Yellow;
                btn.MouseLeave += (s, e) => btn.ForeColor = Color.White;
            }
        }
        private void MostrarDialogoNPC(Panel panel, Label label, Button btnSi, Button btnNo, Button btnOk, string textoDialogo, bool nivelCompletado)
        {
            if (nivelCompletado)
            {
                label.Text = "Ya has completado este nivel.\n¡Intenta con otro personaje!";
                btnSi.Visible = false;
                btnNo.Visible = false;
                btnOk.Visible = true;
            }
            else
            {
                label.Text = textoDialogo;
                btnSi.Visible = true;
                btnNo.Visible = true;
                btnOk.Visible = false;
            }
            panel.Visible = true;
            panel.BringToFront();
        }
        private void CerrarDialogo(Panel panel, Button btnOk)
        {
            panel.Visible = false;
            btnOk.TabStop = false;
            _form.Select();
        }

    }
}
