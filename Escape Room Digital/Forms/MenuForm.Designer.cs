namespace Escape_Room_Digital
{
    partial class MenuForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSalir = new Button();
            btnConfiguracion = new Button();
            btnIniciar = new Button();
            btnAdministrador = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(23, 28);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(65, 61);
            btnSalir.TabIndex = 0;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnConfiguracion
            // 
            btnConfiguracion.Anchor = AnchorStyles.Bottom;
            btnConfiguracion.Location = new Point(595, 554);
            btnConfiguracion.Name = "btnConfiguracion";
            btnConfiguracion.Size = new Size(158, 24);
            btnConfiguracion.TabIndex = 1;
            btnConfiguracion.Text = "Configuración";
            btnConfiguracion.UseVisualStyleBackColor = true;
            // 
            // btnIniciar
            // 
            btnIniciar.Anchor = AnchorStyles.Bottom;
            btnIniciar.Location = new Point(630, 492);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(94, 24);
            btnIniciar.TabIndex = 2;
            btnIniciar.Text = "Iniciar";
            btnIniciar.UseVisualStyleBackColor = true;
            // 
            // btnAdministrador
            // 
            btnAdministrador.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAdministrador.Location = new Point(1232, 698);
            btnAdministrador.Name = "btnAdministrador";
            btnAdministrador.Size = new Size(108, 58);
            btnAdministrador.TabIndex = 3;
            btnAdministrador.Text = "Administrador";
            btnAdministrador.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(513, 199);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 4;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(595, 240);
            label2.Name = "label2";
            label2.Size = new Size(142, 15);
            label2.TabIndex = 5;
            label2.Text = "Escape Room Digital";
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1463, 862);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAdministrador);
            Controls.Add(btnIniciar);
            Controls.Add(btnConfiguracion);
            Controls.Add(btnSalir);
            Font = new Font("Determination Mono Web", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "MenuForm";
            Text = "Form1";
            TopMost = true;
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSalir;
        private Button btnConfiguracion;
        private Button btnIniciar;
        private Button btnAdministrador;
        private Label label1;
        private Label label2;
    }
}
