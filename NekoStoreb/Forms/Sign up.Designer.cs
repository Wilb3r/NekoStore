namespace NekoStoreb.Forms
{
    partial class Sign_up
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombreRegistrarse = new System.Windows.Forms.TextBox();
            this.txtContraseñaRegistrarse = new System.Windows.Forms.TextBox();
            this.txtUbicacionRegistrarse = new System.Windows.Forms.TextBox();
            this.btnRegistrarse = new System.Windows.Forms.Button();
            this.Registrar = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnIniciarSeccion = new System.Windows.Forms.Button();
            this.txtContraseñaIniciar = new System.Windows.Forms.TextBox();
            this.txtNombreIniciar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Registrar.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(66, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Usuario :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(66, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(66, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ubicacion :";
            // 
            // txtNombreRegistrarse
            // 
            this.txtNombreRegistrarse.Location = new System.Drawing.Point(182, 38);
            this.txtNombreRegistrarse.Name = "txtNombreRegistrarse";
            this.txtNombreRegistrarse.Size = new System.Drawing.Size(136, 20);
            this.txtNombreRegistrarse.TabIndex = 3;
            // 
            // txtContraseñaRegistrarse
            // 
            this.txtContraseñaRegistrarse.Location = new System.Drawing.Point(182, 92);
            this.txtContraseñaRegistrarse.Name = "txtContraseñaRegistrarse";
            this.txtContraseñaRegistrarse.Size = new System.Drawing.Size(136, 20);
            this.txtContraseñaRegistrarse.TabIndex = 4;
            // 
            // txtUbicacionRegistrarse
            // 
            this.txtUbicacionRegistrarse.Location = new System.Drawing.Point(182, 142);
            this.txtUbicacionRegistrarse.Name = "txtUbicacionRegistrarse";
            this.txtUbicacionRegistrarse.Size = new System.Drawing.Size(136, 20);
            this.txtUbicacionRegistrarse.TabIndex = 5;
            // 
            // btnRegistrarse
            // 
            this.btnRegistrarse.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnRegistrarse.BackgroundImage = global::NekoStoreb.Properties.Resources._14674419_fondo_negro_azul_los_colores_oscuros_con_la_vendimia_grunge_textura_de_fondo_manchas_abstractas_y_ma_Foto_de_archivo;
            this.btnRegistrarse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRegistrarse.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarse.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRegistrarse.Location = new System.Drawing.Point(128, 187);
            this.btnRegistrarse.Name = "btnRegistrarse";
            this.btnRegistrarse.Size = new System.Drawing.Size(92, 35);
            this.btnRegistrarse.TabIndex = 6;
            this.btnRegistrarse.Text = "Registrar ";
            this.btnRegistrarse.UseVisualStyleBackColor = false;
            this.btnRegistrarse.Click += new System.EventHandler(this.btnRegistrarse_Click);
            // 
            // Registrar
            // 
            this.Registrar.BackgroundImage = global::NekoStoreb.Properties.Resources._14674419_fondo_negro_azul_los_colores_oscuros_con_la_vendimia_grunge_textura_de_fondo_manchas_abstractas_y_ma_Foto_de_archivo;
            this.Registrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Registrar.Controls.Add(this.txtNombreRegistrarse);
            this.Registrar.Controls.Add(this.btnRegistrarse);
            this.Registrar.Controls.Add(this.label1);
            this.Registrar.Controls.Add(this.txtUbicacionRegistrarse);
            this.Registrar.Controls.Add(this.label2);
            this.Registrar.Controls.Add(this.txtContraseñaRegistrarse);
            this.Registrar.Controls.Add(this.label3);
            this.Registrar.Location = new System.Drawing.Point(28, 132);
            this.Registrar.Name = "Registrar";
            this.Registrar.Size = new System.Drawing.Size(369, 242);
            this.Registrar.TabIndex = 7;
            this.Registrar.TabStop = false;
            this.Registrar.Text = "Registrarse";
            this.Registrar.Enter += new System.EventHandler(this.Registrar_Enter);
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::NekoStoreb.Properties.Resources._14674419_fondo_negro_azul_los_colores_oscuros_con_la_vendimia_grunge_textura_de_fondo_manchas_abstractas_y_ma_Foto_de_archivo;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.btnIniciarSeccion);
            this.groupBox1.Controls.Add(this.txtContraseñaIniciar);
            this.groupBox1.Controls.Add(this.txtNombreIniciar);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(28, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(369, 105);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Iniciar Seccion";
            // 
            // btnIniciarSeccion
            // 
            this.btnIniciarSeccion.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnIniciarSeccion.BackgroundImage = global::NekoStoreb.Properties.Resources._14674419_fondo_negro_azul_los_colores_oscuros_con_la_vendimia_grunge_textura_de_fondo_manchas_abstractas_y_ma_Foto_de_archivo;
            this.btnIniciarSeccion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIniciarSeccion.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarSeccion.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnIniciarSeccion.Location = new System.Drawing.Point(128, 66);
            this.btnIniciarSeccion.Name = "btnIniciarSeccion";
            this.btnIniciarSeccion.Size = new System.Drawing.Size(106, 33);
            this.btnIniciarSeccion.TabIndex = 4;
            this.btnIniciarSeccion.Text = "Entrar";
            this.btnIniciarSeccion.UseVisualStyleBackColor = false;
            this.btnIniciarSeccion.Click += new System.EventHandler(this.btnIniciarSeccion_Click);
            // 
            // txtContraseñaIniciar
            // 
            this.txtContraseñaIniciar.Location = new System.Drawing.Point(252, 30);
            this.txtContraseñaIniciar.Name = "txtContraseñaIniciar";
            this.txtContraseñaIniciar.PasswordChar = '*';
            this.txtContraseñaIniciar.Size = new System.Drawing.Size(100, 20);
            this.txtContraseñaIniciar.TabIndex = 3;
            // 
            // txtNombreIniciar
            // 
            this.txtNombreIniciar.Location = new System.Drawing.Point(73, 30);
            this.txtNombreIniciar.Name = "txtNombreIniciar";
            this.txtNombreIniciar.Size = new System.Drawing.Size(100, 20);
            this.txtNombreIniciar.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(179, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Contraseña :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(17, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nombre :";
            // 
            // Sign_up
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 399);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Registrar);
            this.Name = "Sign_up";
            this.Text = "Sign_up";
            this.Load += new System.EventHandler(this.Sign_up_Load);
            this.Registrar.ResumeLayout(false);
            this.Registrar.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombreRegistrarse;
        private System.Windows.Forms.TextBox txtContraseñaRegistrarse;
        private System.Windows.Forms.TextBox txtUbicacionRegistrarse;
        private System.Windows.Forms.Button btnRegistrarse;
        private System.Windows.Forms.GroupBox Registrar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtContraseñaIniciar;
        private System.Windows.Forms.TextBox txtNombreIniciar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnIniciarSeccion;
    }
}