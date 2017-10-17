namespace NekoStoreb
{
    partial class FormularioBuscar
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pctBuscarBD = new System.Windows.Forms.PictureBox();
            this.lstId = new System.Windows.Forms.ListBox();
            this.lstMaterial = new System.Windows.Forms.ListBox();
            this.lstCategoria = new System.Windows.Forms.ListBox();
            this.lstPrecio = new System.Windows.Forms.ListBox();
            this.lstNombre = new System.Windows.Forms.ListBox();
            this.cmbMostrarCategorias = new System.Windows.Forms.ComboBox();
            this.cmbBusquedaporCategoria = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBuscarBD)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pctBuscarBD);
            this.groupBox1.Controls.Add(this.lstId);
            this.groupBox1.Controls.Add(this.lstMaterial);
            this.groupBox1.Controls.Add(this.lstCategoria);
            this.groupBox1.Controls.Add(this.lstPrecio);
            this.groupBox1.Controls.Add(this.lstNombre);
            this.groupBox1.Controls.Add(this.cmbMostrarCategorias);
            this.groupBox1.Controls.Add(this.cmbBusquedaporCategoria);
            this.groupBox1.Location = new System.Drawing.Point(29, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(383, 307);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // pctBuscarBD
            // 
            this.pctBuscarBD.Location = new System.Drawing.Point(6, 150);
            this.pctBuscarBD.Name = "pctBuscarBD";
            this.pctBuscarBD.Size = new System.Drawing.Size(100, 93);
            this.pctBuscarBD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctBuscarBD.TabIndex = 25;
            this.pctBuscarBD.TabStop = false;
            // 
            // lstId
            // 
            this.lstId.FormattingEnabled = true;
            this.lstId.Location = new System.Drawing.Point(138, 270);
            this.lstId.Name = "lstId";
            this.lstId.Size = new System.Drawing.Size(120, 17);
            this.lstId.TabIndex = 24;
            // 
            // lstMaterial
            // 
            this.lstMaterial.FormattingEnabled = true;
            this.lstMaterial.Location = new System.Drawing.Point(138, 247);
            this.lstMaterial.Name = "lstMaterial";
            this.lstMaterial.Size = new System.Drawing.Size(120, 17);
            this.lstMaterial.TabIndex = 23;
            // 
            // lstCategoria
            // 
            this.lstCategoria.FormattingEnabled = true;
            this.lstCategoria.Location = new System.Drawing.Point(138, 212);
            this.lstCategoria.Name = "lstCategoria";
            this.lstCategoria.Size = new System.Drawing.Size(120, 17);
            this.lstCategoria.TabIndex = 22;
            // 
            // lstPrecio
            // 
            this.lstPrecio.FormattingEnabled = true;
            this.lstPrecio.Location = new System.Drawing.Point(138, 183);
            this.lstPrecio.Name = "lstPrecio";
            this.lstPrecio.Size = new System.Drawing.Size(142, 17);
            this.lstPrecio.TabIndex = 21;
            // 
            // lstNombre
            // 
            this.lstNombre.BackColor = System.Drawing.Color.White;
            this.lstNombre.FormattingEnabled = true;
            this.lstNombre.Location = new System.Drawing.Point(138, 139);
            this.lstNombre.Name = "lstNombre";
            this.lstNombre.Size = new System.Drawing.Size(239, 17);
            this.lstNombre.TabIndex = 20;
            // 
            // cmbMostrarCategorias
            // 
            this.cmbMostrarCategorias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMostrarCategorias.FormattingEnabled = true;
            this.cmbMostrarCategorias.Location = new System.Drawing.Point(30, 96);
            this.cmbMostrarCategorias.Name = "cmbMostrarCategorias";
            this.cmbMostrarCategorias.Size = new System.Drawing.Size(239, 21);
            this.cmbMostrarCategorias.TabIndex = 19;
            this.cmbMostrarCategorias.SelectedIndexChanged += new System.EventHandler(this.cmbMostrarCategorias_SelectedIndexChanged);
            // 
            // cmbBusquedaporCategoria
            // 
            this.cmbBusquedaporCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBusquedaporCategoria.FormattingEnabled = true;
            this.cmbBusquedaporCategoria.Items.AddRange(new object[] {
            "Collares y pendientes",
            "llaveros",
            "brazalates"});
            this.cmbBusquedaporCategoria.Location = new System.Drawing.Point(74, 32);
            this.cmbBusquedaporCategoria.Name = "cmbBusquedaporCategoria";
            this.cmbBusquedaporCategoria.Size = new System.Drawing.Size(121, 21);
            this.cmbBusquedaporCategoria.TabIndex = 18;
            this.cmbBusquedaporCategoria.SelectedIndexChanged += new System.EventHandler(this.cmbBusquedaporCategoria_SelectedIndexChanged);
            // 
            // FormularioBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 374);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormularioBuscar";
            this.Text = "FormularioBuscar";
            this.Load += new System.EventHandler(this.FormularioBuscar_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctBuscarBD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbBusquedaporCategoria;
        private System.Windows.Forms.ComboBox cmbMostrarCategorias;
        private System.Windows.Forms.ListBox lstNombre;
        private System.Windows.Forms.ListBox lstPrecio;
        private System.Windows.Forms.ListBox lstCategoria;
        private System.Windows.Forms.ListBox lstMaterial;
        private System.Windows.Forms.ListBox lstId;
        private System.Windows.Forms.PictureBox pctBuscarBD;
    }
}