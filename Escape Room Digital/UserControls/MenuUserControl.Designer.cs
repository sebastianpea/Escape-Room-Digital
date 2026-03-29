namespace Escape_Room_Digital.UserControls
{
    partial class MenuUserControl
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
            label1 = new Label();
            btnJugar = new Button();
            btnConfiguración = new Button();
            btnSalir = new Button();
            btnAdministrador = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(555, 187);
            label1.Name = "label1";
            label1.Size = new Size(142, 15);
            label1.TabIndex = 0;
            label1.Text = "Escape Room Digital";
            // 
            // btnJugar
            // 
            btnJugar.Location = new Point(586, 314);
            btnJugar.Name = "btnJugar";
            btnJugar.Size = new Size(94, 29);
            btnJugar.TabIndex = 1;
            btnJugar.Text = "Jugar";
            btnJugar.UseVisualStyleBackColor = true;
            // 
            // btnConfiguración
            // 
            btnConfiguración.Location = new Point(555, 379);
            btnConfiguración.Name = "btnConfiguración";
            btnConfiguración.Size = new Size(151, 29);
            btnConfiguración.TabIndex = 2;
            btnConfiguración.Text = "Configuración";
            btnConfiguración.UseVisualStyleBackColor = true;
            btnConfiguración.Click += btnConfiguración_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(20, 27);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 38);
            btnSalir.TabIndex = 3;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnAdministrador
            // 
            btnAdministrador.Location = new Point(1170, 514);
            btnAdministrador.Name = "btnAdministrador";
            btnAdministrador.Size = new Size(94, 29);
            btnAdministrador.TabIndex = 4;
            btnAdministrador.Text = "Administrador";
            btnAdministrador.UseVisualStyleBackColor = true;
            btnAdministrador.Click += btnAdministrador_Click;
            // 
            // MenuUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            Controls.Add(btnAdministrador);
            Controls.Add(btnSalir);
            Controls.Add(btnConfiguración);
            Controls.Add(btnJugar);
            Controls.Add(label1);
            Font = new Font("Determination Mono Web", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MenuUserControl";
            Size = new Size(1290, 574);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnJugar;
        private Button btnConfiguración;
        private Button btnSalir;
        private Button btnAdministrador;
    }
}
