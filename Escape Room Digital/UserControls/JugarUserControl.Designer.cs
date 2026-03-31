namespace Escape_Room_Digital.UserControls
{
    partial class JugarUserControl
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btnVolver = new Button();
            pbJugador = new PictureBox();
            timerMoverDerecha = new System.Windows.Forms.Timer(components);
            timerMoverAbajo = new System.Windows.Forms.Timer(components);
            timerMoverIzquierda = new System.Windows.Forms.Timer(components);
            timerMoverArriba = new System.Windows.Forms.Timer(components);
            timerAnimacion = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pbJugador).BeginInit();
            SuspendLayout();
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(1653, 17);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(187, 78);
            btnVolver.TabIndex = 0;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // pbJugador
            // 
            pbJugador.Image = Properties.Resources.SkeletonWalk3;
            pbJugador.Location = new Point(856, 497);
            pbJugador.Name = "pbJugador";
            pbJugador.Size = new Size(50, 75);
            pbJugador.SizeMode = PictureBoxSizeMode.Zoom;
            pbJugador.TabIndex = 1;
            pbJugador.TabStop = false;
            // 
            // timerMoverDerecha
            // 
            timerMoverDerecha.Interval = 5;
            timerMoverDerecha.Tick += timerMoverDerecha_Tick;
            // 
            // timerMoverAbajo
            // 
            timerMoverAbajo.Interval = 5;
            timerMoverAbajo.Tick += timerMoverAbajo_Tick;
            // 
            // timerMoverIzquierda
            // 
            timerMoverIzquierda.Interval = 5;
            timerMoverIzquierda.Tick += timerMoverIzquierda_Tick;
            // 
            // timerMoverArriba
            // 
            timerMoverArriba.Interval = 5;
            timerMoverArriba.Tick += timerMoverArriba_Tick;
            // 
            // timerAnimacion
            // 
            timerAnimacion.Interval = 200;
            timerAnimacion.Tick += timerAnimacion_Tick;
            // 
            // JugarUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            Controls.Add(pbJugador);
            Controls.Add(btnVolver);
            Font = new Font("Determination Mono Web", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 2, 3, 2);
            Name = "JugarUserControl";
            Size = new Size(1920, 1080);
            ((System.ComponentModel.ISupportInitialize)pbJugador).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnVolver;
        private PictureBox pbJugador;
        private System.Windows.Forms.Timer timerMoverDerecha;
        private System.Windows.Forms.Timer timerMoverAbajo;
        private System.Windows.Forms.Timer timerMoverIzquierda;
        private System.Windows.Forms.Timer timerMoverArriba;
        private System.Windows.Forms.Timer timerAnimacion;
    }
}
