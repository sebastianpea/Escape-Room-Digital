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
            pbTurtle = new PictureBox();
            pbNerd = new PictureBox();
            pbShortSkeleton = new PictureBox();
            pbGhost = new PictureBox();
            pbJester = new PictureBox();
            pnlDialogoNerd = new Panel();
            btnOkNerd = new Button();
            pictureBox4 = new PictureBox();
            btnNoNerd = new Button();
            btnSiNerd = new Button();
            lblDialogoNerd = new Label();
            pnlDialogoShortSkeleton = new Panel();
            btnOkShortSkeleton = new Button();
            pictureBox1 = new PictureBox();
            btnNoShortSkeleton = new Button();
            btnSiShortSkeleton = new Button();
            lblDialogoShortSkeleton = new Label();
            pnlDialogoGhost = new Panel();
            btnOkGhost = new Button();
            pictureBox3 = new PictureBox();
            btnNoGhost = new Button();
            btnSiGhost = new Button();
            lblDialogoGhost = new Label();
            pnlDialogoJester = new Panel();
            btnOkJester = new Button();
            pictureBox2 = new PictureBox();
            btnNoJester = new Button();
            btnSiJester = new Button();
            lblDialogoJester = new Label();
            pbNerdCloud = new PictureBox();
            pbTurtleCloud = new PictureBox();
            pbGhostCloud = new PictureBox();
            pbJesterCloud = new PictureBox();
            pbShortSkeletonCloud = new PictureBox();
            pnlTurtle = new Panel();
            btnContinuarTurtle = new Button();
            pbTurtlePanel = new PictureBox();
            btnOkTurtle = new Button();
            lblTurtle = new Label();
            lblMision = new Label();
            ((System.ComponentModel.ISupportInitialize)pbJugador).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbTurtle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbNerd).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbShortSkeleton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbGhost).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbJester).BeginInit();
            pnlDialogoNerd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            pnlDialogoShortSkeleton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlDialogoGhost.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            pnlDialogoJester.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbNerdCloud).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbTurtleCloud).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbGhostCloud).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbJesterCloud).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbShortSkeletonCloud).BeginInit();
            pnlTurtle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbTurtlePanel).BeginInit();
            SuspendLayout();
            // 
            // btnVolver
            // 
            btnVolver.BackColor = SystemColors.ActiveCaptionText;
            btnVolver.ForeColor = SystemColors.ButtonHighlight;
            btnVolver.Location = new Point(1653, 17);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(187, 78);
            btnVolver.TabIndex = 0;
            btnVolver.TabStop = false;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // pbJugador
            // 
            pbJugador.BackColor = Color.Transparent;
            pbJugador.Image = Properties.Resources.SkeletonWalk3;
            pbJugador.Location = new Point(910, 750);
            pbJugador.Name = "pbJugador";
            pbJugador.Size = new Size(131, 156);
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
            // pbTurtle
            // 
            pbTurtle.BackColor = Color.Transparent;
            pbTurtle.Image = Properties.Resources.TurtleIdle1;
            pbTurtle.Location = new Point(914, 237);
            pbTurtle.Name = "pbTurtle";
            pbTurtle.Size = new Size(127, 167);
            pbTurtle.SizeMode = PictureBoxSizeMode.Zoom;
            pbTurtle.TabIndex = 2;
            pbTurtle.TabStop = false;
            // 
            // pbNerd
            // 
            pbNerd.BackColor = Color.Transparent;
            pbNerd.Image = Properties.Resources.NerdImage;
            pbNerd.Location = new Point(266, 713);
            pbNerd.Name = "pbNerd";
            pbNerd.Size = new Size(131, 168);
            pbNerd.SizeMode = PictureBoxSizeMode.Zoom;
            pbNerd.TabIndex = 3;
            pbNerd.TabStop = false;
            // 
            // pbShortSkeleton
            // 
            pbShortSkeleton.BackColor = Color.Transparent;
            pbShortSkeleton.Image = Properties.Resources.ShortSkeletonImage;
            pbShortSkeleton.Location = new Point(297, 304);
            pbShortSkeleton.Name = "pbShortSkeleton";
            pbShortSkeleton.Size = new Size(132, 160);
            pbShortSkeleton.SizeMode = PictureBoxSizeMode.Zoom;
            pbShortSkeleton.TabIndex = 4;
            pbShortSkeleton.TabStop = false;
            // 
            // pbGhost
            // 
            pbGhost.BackColor = Color.Transparent;
            pbGhost.Image = Properties.Resources.GhostImage;
            pbGhost.Location = new Point(1533, 740);
            pbGhost.Name = "pbGhost";
            pbGhost.Size = new Size(146, 172);
            pbGhost.SizeMode = PictureBoxSizeMode.Zoom;
            pbGhost.TabIndex = 5;
            pbGhost.TabStop = false;
            // 
            // pbJester
            // 
            pbJester.BackColor = Color.Transparent;
            pbJester.Image = Properties.Resources.ClownImage;
            pbJester.Location = new Point(1568, 304);
            pbJester.Name = "pbJester";
            pbJester.Size = new Size(146, 149);
            pbJester.SizeMode = PictureBoxSizeMode.Zoom;
            pbJester.TabIndex = 6;
            pbJester.TabStop = false;
            // 
            // pnlDialogoNerd
            // 
            pnlDialogoNerd.Controls.Add(btnOkNerd);
            pnlDialogoNerd.Controls.Add(pictureBox4);
            pnlDialogoNerd.Controls.Add(btnNoNerd);
            pnlDialogoNerd.Controls.Add(btnSiNerd);
            pnlDialogoNerd.Controls.Add(lblDialogoNerd);
            pnlDialogoNerd.Location = new Point(562, 740);
            pnlDialogoNerd.Margin = new Padding(3, 3, 3, 20);
            pnlDialogoNerd.Name = "pnlDialogoNerd";
            pnlDialogoNerd.Size = new Size(781, 294);
            pnlDialogoNerd.TabIndex = 7;
            pnlDialogoNerd.Visible = false;
            pnlDialogoNerd.Paint += pnlDialogoNerd_Paint;
            // 
            // btnOkNerd
            // 
            btnOkNerd.BackColor = SystemColors.ActiveCaptionText;
            btnOkNerd.ForeColor = SystemColors.ButtonHighlight;
            btnOkNerd.Location = new Point(335, 173);
            btnOkNerd.Name = "btnOkNerd";
            btnOkNerd.Size = new Size(150, 57);
            btnOkNerd.TabIndex = 17;
            btnOkNerd.Text = "Ok";
            btnOkNerd.UseVisualStyleBackColor = false;
            btnOkNerd.Visible = false;
            btnOkNerd.Click += btnOkNerd_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Image = Properties.Resources.NerdImage;
            pictureBox4.Location = new Point(59, 20);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(115, 147);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 16;
            pictureBox4.TabStop = false;
            // 
            // btnNoNerd
            // 
            btnNoNerd.BackColor = SystemColors.ActiveCaptionText;
            btnNoNerd.ForeColor = SystemColors.ButtonHighlight;
            btnNoNerd.Location = new Point(500, 173);
            btnNoNerd.Name = "btnNoNerd";
            btnNoNerd.Size = new Size(150, 57);
            btnNoNerd.TabIndex = 2;
            btnNoNerd.Text = "No";
            btnNoNerd.UseVisualStyleBackColor = false;
            btnNoNerd.Click += btnNoNerd_Click;
            // 
            // btnSiNerd
            // 
            btnSiNerd.BackColor = SystemColors.ActiveCaptionText;
            btnSiNerd.ForeColor = SystemColors.ButtonHighlight;
            btnSiNerd.Location = new Point(170, 173);
            btnSiNerd.Name = "btnSiNerd";
            btnSiNerd.Size = new Size(150, 57);
            btnSiNerd.TabIndex = 1;
            btnSiNerd.Text = "Si";
            btnSiNerd.UseVisualStyleBackColor = false;
            btnSiNerd.Click += btnSiNerd_Click;
            // 
            // lblDialogoNerd
            // 
            lblDialogoNerd.AutoSize = true;
            lblDialogoNerd.Font = new Font("Determination Mono Web", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDialogoNerd.ForeColor = SystemColors.ButtonFace;
            lblDialogoNerd.Location = new Point(223, 30);
            lblDialogoNerd.Name = "lblDialogoNerd";
            lblDialogoNerd.Size = new Size(103, 30);
            lblDialogoNerd.TabIndex = 0;
            lblDialogoNerd.Text = "label1";
            // 
            // pnlDialogoShortSkeleton
            // 
            pnlDialogoShortSkeleton.Controls.Add(btnOkShortSkeleton);
            pnlDialogoShortSkeleton.Controls.Add(pictureBox1);
            pnlDialogoShortSkeleton.Controls.Add(btnNoShortSkeleton);
            pnlDialogoShortSkeleton.Controls.Add(btnSiShortSkeleton);
            pnlDialogoShortSkeleton.Controls.Add(lblDialogoShortSkeleton);
            pnlDialogoShortSkeleton.Location = new Point(562, 740);
            pnlDialogoShortSkeleton.Margin = new Padding(3, 3, 3, 20);
            pnlDialogoShortSkeleton.Name = "pnlDialogoShortSkeleton";
            pnlDialogoShortSkeleton.Size = new Size(843, 294);
            pnlDialogoShortSkeleton.TabIndex = 10;
            pnlDialogoShortSkeleton.Visible = false;
            pnlDialogoShortSkeleton.Paint += pnlDialogoShortSkeleton_Paint;
            // 
            // btnOkShortSkeleton
            // 
            btnOkShortSkeleton.BackColor = SystemColors.ActiveCaptionText;
            btnOkShortSkeleton.ForeColor = SystemColors.ButtonHighlight;
            btnOkShortSkeleton.Location = new Point(331, 211);
            btnOkShortSkeleton.Name = "btnOkShortSkeleton";
            btnOkShortSkeleton.Size = new Size(150, 57);
            btnOkShortSkeleton.TabIndex = 19;
            btnOkShortSkeleton.Text = "Ok";
            btnOkShortSkeleton.UseVisualStyleBackColor = false;
            btnOkShortSkeleton.Visible = false;
            btnOkShortSkeleton.Click += btnOkShortSkeleton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.ShortSkeletonImage;
            pictureBox1.Location = new Point(109, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(121, 152);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // btnNoShortSkeleton
            // 
            btnNoShortSkeleton.BackColor = SystemColors.ActiveCaptionText;
            btnNoShortSkeleton.ForeColor = SystemColors.ButtonHighlight;
            btnNoShortSkeleton.Location = new Point(526, 211);
            btnNoShortSkeleton.Name = "btnNoShortSkeleton";
            btnNoShortSkeleton.Size = new Size(150, 57);
            btnNoShortSkeleton.TabIndex = 2;
            btnNoShortSkeleton.Text = "No";
            btnNoShortSkeleton.UseVisualStyleBackColor = false;
            btnNoShortSkeleton.Click += btnNoShortSkeleton_Click;
            // 
            // btnSiShortSkeleton
            // 
            btnSiShortSkeleton.BackColor = SystemColors.ActiveCaptionText;
            btnSiShortSkeleton.ForeColor = SystemColors.ButtonHighlight;
            btnSiShortSkeleton.Location = new Point(144, 211);
            btnSiShortSkeleton.Name = "btnSiShortSkeleton";
            btnSiShortSkeleton.Size = new Size(141, 57);
            btnSiShortSkeleton.TabIndex = 1;
            btnSiShortSkeleton.Text = "Si";
            btnSiShortSkeleton.UseVisualStyleBackColor = false;
            btnSiShortSkeleton.Click += btnSiShortSkeleton_Click;
            // 
            // lblDialogoShortSkeleton
            // 
            lblDialogoShortSkeleton.AutoSize = true;
            lblDialogoShortSkeleton.Font = new Font("Determination Mono Web", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDialogoShortSkeleton.ForeColor = SystemColors.ButtonFace;
            lblDialogoShortSkeleton.Location = new Point(249, 48);
            lblDialogoShortSkeleton.Name = "lblDialogoShortSkeleton";
            lblDialogoShortSkeleton.Size = new Size(103, 30);
            lblDialogoShortSkeleton.TabIndex = 0;
            lblDialogoShortSkeleton.Text = "label1";
            // 
            // pnlDialogoGhost
            // 
            pnlDialogoGhost.Controls.Add(btnOkGhost);
            pnlDialogoGhost.Controls.Add(pictureBox3);
            pnlDialogoGhost.Controls.Add(btnNoGhost);
            pnlDialogoGhost.Controls.Add(btnSiGhost);
            pnlDialogoGhost.Controls.Add(lblDialogoGhost);
            pnlDialogoGhost.Location = new Point(562, 740);
            pnlDialogoGhost.Margin = new Padding(3, 3, 3, 20);
            pnlDialogoGhost.Name = "pnlDialogoGhost";
            pnlDialogoGhost.Size = new Size(837, 286);
            pnlDialogoGhost.TabIndex = 8;
            pnlDialogoGhost.Visible = false;
            pnlDialogoGhost.Paint += pnlDialogoGhost_Paint;
            // 
            // btnOkGhost
            // 
            btnOkGhost.BackColor = SystemColors.ActiveCaptionText;
            btnOkGhost.ForeColor = SystemColors.ButtonHighlight;
            btnOkGhost.Location = new Point(355, 179);
            btnOkGhost.Name = "btnOkGhost";
            btnOkGhost.Size = new Size(150, 57);
            btnOkGhost.TabIndex = 20;
            btnOkGhost.Text = "Ok";
            btnOkGhost.UseVisualStyleBackColor = false;
            btnOkGhost.Visible = false;
            btnOkGhost.Click += btnOkGhost_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = Properties.Resources.GhostImage;
            pictureBox3.Location = new Point(34, 10);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(157, 163);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 16;
            pictureBox3.TabStop = false;
            // 
            // btnNoGhost
            // 
            btnNoGhost.BackColor = SystemColors.ActiveCaptionText;
            btnNoGhost.ForeColor = SystemColors.ButtonFace;
            btnNoGhost.Location = new Point(524, 179);
            btnNoGhost.Name = "btnNoGhost";
            btnNoGhost.Size = new Size(149, 57);
            btnNoGhost.TabIndex = 2;
            btnNoGhost.Text = "No";
            btnNoGhost.UseVisualStyleBackColor = false;
            btnNoGhost.Click += btnNoGhost_Click;
            // 
            // btnSiGhost
            // 
            btnSiGhost.BackColor = SystemColors.ActiveCaptionText;
            btnSiGhost.ForeColor = SystemColors.ButtonHighlight;
            btnSiGhost.Location = new Point(187, 179);
            btnSiGhost.Name = "btnSiGhost";
            btnSiGhost.Size = new Size(149, 57);
            btnSiGhost.TabIndex = 1;
            btnSiGhost.Text = "Si";
            btnSiGhost.UseVisualStyleBackColor = false;
            btnSiGhost.Click += btnSiGhost_Click;
            // 
            // lblDialogoGhost
            // 
            lblDialogoGhost.AutoSize = true;
            lblDialogoGhost.Font = new Font("Determination Mono Web", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDialogoGhost.ForeColor = SystemColors.ButtonFace;
            lblDialogoGhost.Location = new Point(239, 29);
            lblDialogoGhost.Name = "lblDialogoGhost";
            lblDialogoGhost.Size = new Size(103, 30);
            lblDialogoGhost.TabIndex = 0;
            lblDialogoGhost.Text = "label1";
            // 
            // pnlDialogoJester
            // 
            pnlDialogoJester.BackColor = SystemColors.ActiveCaptionText;
            pnlDialogoJester.BorderStyle = BorderStyle.FixedSingle;
            pnlDialogoJester.Controls.Add(btnOkJester);
            pnlDialogoJester.Controls.Add(pictureBox2);
            pnlDialogoJester.Controls.Add(btnNoJester);
            pnlDialogoJester.Controls.Add(btnSiJester);
            pnlDialogoJester.Controls.Add(lblDialogoJester);
            pnlDialogoJester.Location = new Point(562, 740);
            pnlDialogoJester.Margin = new Padding(3, 3, 3, 20);
            pnlDialogoJester.Name = "pnlDialogoJester";
            pnlDialogoJester.Size = new Size(843, 294);
            pnlDialogoJester.TabIndex = 9;
            pnlDialogoJester.Visible = false;
            pnlDialogoJester.Paint += pnlDialogoJester_Paint;
            // 
            // btnOkJester
            // 
            btnOkJester.BackColor = SystemColors.ActiveCaptionText;
            btnOkJester.ForeColor = SystemColors.ButtonHighlight;
            btnOkJester.Location = new Point(366, 204);
            btnOkJester.Name = "btnOkJester";
            btnOkJester.Size = new Size(150, 57);
            btnOkJester.TabIndex = 18;
            btnOkJester.Text = "Ok";
            btnOkJester.UseVisualStyleBackColor = false;
            btnOkJester.Visible = false;
            btnOkJester.Click += btnOkJester_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.ClownImage;
            pictureBox2.Location = new Point(110, 19);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(157, 152);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            // 
            // btnNoJester
            // 
            btnNoJester.BackColor = SystemColors.ActiveCaptionText;
            btnNoJester.ForeColor = SystemColors.ButtonHighlight;
            btnNoJester.Location = new Point(546, 204);
            btnNoJester.Name = "btnNoJester";
            btnNoJester.Size = new Size(150, 57);
            btnNoJester.TabIndex = 2;
            btnNoJester.Text = "No";
            btnNoJester.UseVisualStyleBackColor = false;
            btnNoJester.Click += btnNoJester_Click;
            // 
            // btnSiJester
            // 
            btnSiJester.BackColor = SystemColors.ActiveCaptionText;
            btnSiJester.ForeColor = SystemColors.ButtonHighlight;
            btnSiJester.Location = new Point(174, 204);
            btnSiJester.Name = "btnSiJester";
            btnSiJester.Size = new Size(150, 57);
            btnSiJester.TabIndex = 1;
            btnSiJester.Text = "Si";
            btnSiJester.UseVisualStyleBackColor = false;
            btnSiJester.Click += btnSiJester_Click;
            // 
            // lblDialogoJester
            // 
            lblDialogoJester.AutoSize = true;
            lblDialogoJester.Font = new Font("Determination Mono Web", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDialogoJester.ForeColor = SystemColors.ButtonFace;
            lblDialogoJester.Location = new Point(285, 43);
            lblDialogoJester.Name = "lblDialogoJester";
            lblDialogoJester.Size = new Size(103, 30);
            lblDialogoJester.TabIndex = 0;
            lblDialogoJester.Text = "label1";
            // 
            // pbNerdCloud
            // 
            pbNerdCloud.BackColor = Color.Transparent;
            pbNerdCloud.Image = Properties.Resources.InteractionCloudImage;
            pbNerdCloud.Location = new Point(288, 615);
            pbNerdCloud.Name = "pbNerdCloud";
            pbNerdCloud.Size = new Size(75, 80);
            pbNerdCloud.SizeMode = PictureBoxSizeMode.Zoom;
            pbNerdCloud.TabIndex = 11;
            pbNerdCloud.TabStop = false;
            pbNerdCloud.Visible = false;
            // 
            // pbTurtleCloud
            // 
            pbTurtleCloud.BackColor = Color.Transparent;
            pbTurtleCloud.Image = Properties.Resources.InteractionCloudImage;
            pbTurtleCloud.Location = new Point(925, 140);
            pbTurtleCloud.Name = "pbTurtleCloud";
            pbTurtleCloud.Size = new Size(97, 69);
            pbTurtleCloud.SizeMode = PictureBoxSizeMode.Zoom;
            pbTurtleCloud.TabIndex = 12;
            pbTurtleCloud.TabStop = false;
            pbTurtleCloud.Visible = false;
            // 
            // pbGhostCloud
            // 
            pbGhostCloud.BackColor = Color.Transparent;
            pbGhostCloud.Image = Properties.Resources.InteractionCloudImage;
            pbGhostCloud.Location = new Point(1568, 648);
            pbGhostCloud.Name = "pbGhostCloud";
            pbGhostCloud.Size = new Size(78, 86);
            pbGhostCloud.SizeMode = PictureBoxSizeMode.Zoom;
            pbGhostCloud.TabIndex = 13;
            pbGhostCloud.TabStop = false;
            pbGhostCloud.Visible = false;
            // 
            // pbJesterCloud
            // 
            pbJesterCloud.BackColor = Color.Transparent;
            pbJesterCloud.Image = Properties.Resources.InteractionCloudImage;
            pbJesterCloud.Location = new Point(1615, 224);
            pbJesterCloud.Name = "pbJesterCloud";
            pbJesterCloud.Size = new Size(70, 70);
            pbJesterCloud.SizeMode = PictureBoxSizeMode.Zoom;
            pbJesterCloud.TabIndex = 14;
            pbJesterCloud.TabStop = false;
            pbJesterCloud.Visible = false;
            // 
            // pbShortSkeletonCloud
            // 
            pbShortSkeletonCloud.BackColor = Color.Transparent;
            pbShortSkeletonCloud.Image = Properties.Resources.InteractionCloudImage;
            pbShortSkeletonCloud.Location = new Point(322, 221);
            pbShortSkeletonCloud.Name = "pbShortSkeletonCloud";
            pbShortSkeletonCloud.Size = new Size(75, 74);
            pbShortSkeletonCloud.SizeMode = PictureBoxSizeMode.Zoom;
            pbShortSkeletonCloud.TabIndex = 15;
            pbShortSkeletonCloud.TabStop = false;
            pbShortSkeletonCloud.Visible = false;
            // 
            // pnlTurtle
            // 
            pnlTurtle.Controls.Add(btnContinuarTurtle);
            pnlTurtle.Controls.Add(pbTurtlePanel);
            pnlTurtle.Controls.Add(btnOkTurtle);
            pnlTurtle.Controls.Add(lblTurtle);
            pnlTurtle.Location = new Point(562, 740);
            pnlTurtle.Margin = new Padding(3, 3, 3, 20);
            pnlTurtle.Name = "pnlTurtle";
            pnlTurtle.Size = new Size(837, 286);
            pnlTurtle.TabIndex = 17;
            pnlTurtle.Visible = false;
            pnlTurtle.Paint += pnlTurtle_Paint;
            // 
            // btnContinuarTurtle
            // 
            btnContinuarTurtle.BackColor = SystemColors.ActiveCaptionText;
            btnContinuarTurtle.ForeColor = SystemColors.ButtonHighlight;
            btnContinuarTurtle.Location = new Point(342, 192);
            btnContinuarTurtle.Name = "btnContinuarTurtle";
            btnContinuarTurtle.Size = new Size(173, 57);
            btnContinuarTurtle.TabIndex = 19;
            btnContinuarTurtle.Text = "Continuar";
            btnContinuarTurtle.UseVisualStyleBackColor = false;
            btnContinuarTurtle.Visible = false;
            btnContinuarTurtle.Click += btnContinuarTurtle_Click;
            // 
            // pbTurtlePanel
            // 
            pbTurtlePanel.BackColor = Color.Transparent;
            pbTurtlePanel.Image = Properties.Resources.TurtleIdle1;
            pbTurtlePanel.Location = new Point(54, 32);
            pbTurtlePanel.Name = "pbTurtlePanel";
            pbTurtlePanel.Size = new Size(127, 167);
            pbTurtlePanel.SizeMode = PictureBoxSizeMode.Zoom;
            pbTurtlePanel.TabIndex = 18;
            pbTurtlePanel.TabStop = false;
            // 
            // btnOkTurtle
            // 
            btnOkTurtle.BackColor = SystemColors.ActiveCaptionText;
            btnOkTurtle.ForeColor = SystemColors.ButtonHighlight;
            btnOkTurtle.Location = new Point(348, 192);
            btnOkTurtle.Name = "btnOkTurtle";
            btnOkTurtle.Size = new Size(149, 57);
            btnOkTurtle.TabIndex = 1;
            btnOkTurtle.Text = "OK";
            btnOkTurtle.UseVisualStyleBackColor = false;
            btnOkTurtle.Click += btnOkTurtle_Click;
            // 
            // lblTurtle
            // 
            lblTurtle.AutoSize = true;
            lblTurtle.Font = new Font("Determination Mono Web", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTurtle.ForeColor = SystemColors.ButtonFace;
            lblTurtle.Location = new Point(187, 32);
            lblTurtle.Name = "lblTurtle";
            lblTurtle.Size = new Size(103, 30);
            lblTurtle.TabIndex = 0;
            lblTurtle.Text = "label1";
            // 
            // lblMision
            // 
            lblMision.AutoSize = true;
            lblMision.Font = new Font("Determination Mono Web", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMision.ForeColor = SystemColors.ButtonFace;
            lblMision.Location = new Point(32, 19);
            lblMision.Name = "lblMision";
            lblMision.Size = new Size(417, 76);
            lblMision.TabIndex = 18;
            lblMision.Text = "Objetivos:\r\n*Habla con la Tortuga ";
            // 
            // JugarUserControl
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImage = Properties.Resources.BackgroundGame;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(lblMision);
            Controls.Add(pnlTurtle);
            Controls.Add(pbShortSkeletonCloud);
            Controls.Add(pbJesterCloud);
            Controls.Add(pnlDialogoGhost);
            Controls.Add(pnlDialogoJester);
            Controls.Add(pnlDialogoShortSkeleton);
            Controls.Add(pbGhostCloud);
            Controls.Add(pbTurtle);
            Controls.Add(pbTurtleCloud);
            Controls.Add(pbNerdCloud);
            Controls.Add(pnlDialogoNerd);
            Controls.Add(pbJugador);
            Controls.Add(pbJester);
            Controls.Add(pbGhost);
            Controls.Add(pbShortSkeleton);
            Controls.Add(pbNerd);
            Controls.Add(btnVolver);
            DoubleBuffered = true;
            Font = new Font("Determination Mono Web", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 2, 3, 2);
            Name = "JugarUserControl";
            Size = new Size(1920, 1080);
            ((System.ComponentModel.ISupportInitialize)pbJugador).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbTurtle).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbNerd).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbShortSkeleton).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbGhost).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbJester).EndInit();
            pnlDialogoNerd.ResumeLayout(false);
            pnlDialogoNerd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            pnlDialogoShortSkeleton.ResumeLayout(false);
            pnlDialogoShortSkeleton.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlDialogoGhost.ResumeLayout(false);
            pnlDialogoGhost.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            pnlDialogoJester.ResumeLayout(false);
            pnlDialogoJester.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbNerdCloud).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbTurtleCloud).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbGhostCloud).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbJesterCloud).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbShortSkeletonCloud).EndInit();
            pnlTurtle.ResumeLayout(false);
            pnlTurtle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbTurtlePanel).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVolver;
        private PictureBox pbJugador;
        private System.Windows.Forms.Timer timerMoverDerecha;
        private System.Windows.Forms.Timer timerMoverAbajo;
        private System.Windows.Forms.Timer timerMoverIzquierda;
        private System.Windows.Forms.Timer timerMoverArriba;
        private System.Windows.Forms.Timer timerAnimacion;
        private PictureBox pbTurtle;
        private PictureBox pbNerd;
        private PictureBox pbShortSkeleton;
        private PictureBox pbGhost;
        private PictureBox pbJester;
        private Panel pnlDialogoNerd;
        private Button btnNoNerd;
        private Button btnSiNerd;
        private Label lblDialogoNerd;
        private Panel pnlDialogoGhost;
        private Panel pnlDialogoJester;
        private Button btnNoJester;
        private Button btnSiJester;
        private Label lblDialogoJester;
        private Button btnNoGhost;
        private Button btnSiGhost;
        private Label lblDialogoGhost;
        private Panel pnlDialogoShortSkeleton;
        private Button btnNoShortSkeleton;
        private Button btnSiShortSkeleton;
        private Label lblDialogoShortSkeleton;
        private PictureBox pbNerdCloud;
        private PictureBox pbTurtleCloud;
        private PictureBox pbGhostCloud;
        private PictureBox pbJesterCloud;
        private PictureBox pbShortSkeletonCloud;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Panel pnlTurtle;
        private Button btnOkTurtle;
        private Label lblTurtle;
        private PictureBox pbTurtlePanel;
        private Label lblMision;
        private Button btnOkNerd;
        private Button btnOkShortSkeleton;
        private Button btnOkGhost;
        private Button btnOkJester;
        private Button btnContinuarTurtle;
    }
}
