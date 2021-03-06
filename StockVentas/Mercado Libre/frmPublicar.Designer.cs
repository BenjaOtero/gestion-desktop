﻿namespace StockVentas.Mercado_Libre
{
    partial class frmPublicar
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
            this.lstSubcategorias1 = new System.Windows.Forms.ListBox();
            this.lstCategoriasRopa = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstSubcategorias2 = new System.Windows.Forms.ListBox();
            this.lstSubcategorias3 = new System.Windows.Forms.ListBox();
            this.lstSubcategorias4 = new System.Windows.Forms.ListBox();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.rdDescripcionOrigen = new System.Windows.Forms.RadioButton();
            this.rdArticuloOrigen = new System.Windows.Forms.RadioButton();
            this.txtParametros = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstSubcategorias1
            // 
            this.lstSubcategorias1.FormattingEnabled = true;
            this.lstSubcategorias1.Location = new System.Drawing.Point(241, 28);
            this.lstSubcategorias1.Name = "lstSubcategorias1";
            this.lstSubcategorias1.Size = new System.Drawing.Size(223, 134);
            this.lstSubcategorias1.TabIndex = 16;
            this.lstSubcategorias1.DoubleClick += new System.EventHandler(this.lstSubcategorias1_DoubleClick);
            // 
            // lstCategoriasRopa
            // 
            this.lstCategoriasRopa.FormattingEnabled = true;
            this.lstCategoriasRopa.Location = new System.Drawing.Point(10, 28);
            this.lstCategoriasRopa.Name = "lstCategoriasRopa";
            this.lstCategoriasRopa.Size = new System.Drawing.Size(223, 134);
            this.lstCategoriasRopa.TabIndex = 17;
            this.lstCategoriasRopa.DoubleClick += new System.EventHandler(this.lstCategories_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Categorías";
            // 
            // lstSubcategorias2
            // 
            this.lstSubcategorias2.FormattingEnabled = true;
            this.lstSubcategorias2.Location = new System.Drawing.Point(472, 28);
            this.lstSubcategorias2.Name = "lstSubcategorias2";
            this.lstSubcategorias2.Size = new System.Drawing.Size(223, 134);
            this.lstSubcategorias2.TabIndex = 16;
            this.lstSubcategorias2.DoubleClick += new System.EventHandler(this.lstSubcategorias2_DoubleClick);
            // 
            // lstSubcategorias3
            // 
            this.lstSubcategorias3.FormattingEnabled = true;
            this.lstSubcategorias3.Location = new System.Drawing.Point(703, 28);
            this.lstSubcategorias3.Name = "lstSubcategorias3";
            this.lstSubcategorias3.Size = new System.Drawing.Size(223, 134);
            this.lstSubcategorias3.TabIndex = 16;
            this.lstSubcategorias3.DoubleClick += new System.EventHandler(this.lstSubcategorias3_DoubleClick);
            // 
            // lstSubcategorias4
            // 
            this.lstSubcategorias4.FormattingEnabled = true;
            this.lstSubcategorias4.Location = new System.Drawing.Point(934, 28);
            this.lstSubcategorias4.Name = "lstSubcategorias4";
            this.lstSubcategorias4.Size = new System.Drawing.Size(219, 134);
            this.lstSubcategorias4.TabIndex = 16;
            this.lstSubcategorias4.DoubleClick += new System.EventHandler(this.lstSubcategorias4_DoubleClick);
            // 
            // btnContinuar
            // 
            this.btnContinuar.AllowDrop = true;
            this.btnContinuar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnContinuar.Location = new System.Drawing.Point(13, 275);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(208, 39);
            this.btnContinuar.TabIndex = 12;
            this.btnContinuar.Text = "Continuar";
            this.btnContinuar.UseVisualStyleBackColor = true;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnBuscar);
            this.groupBox3.Controls.Add(this.rdDescripcionOrigen);
            this.groupBox3.Controls.Add(this.rdArticuloOrigen);
            this.groupBox3.Controls.Add(this.txtParametros);
            this.groupBox3.Controls.Add(this.btnContinuar);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox3.Location = new System.Drawing.Point(10, 180);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(234, 320);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Buscar por:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBuscar.Image = global::StockVentas.Properties.Resources.lupa1;
            this.btnBuscar.Location = new System.Drawing.Point(202, 61);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(23, 21);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // rdDescripcionOrigen
            // 
            this.rdDescripcionOrigen.AutoSize = true;
            this.rdDescripcionOrigen.Checked = true;
            this.rdDescripcionOrigen.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdDescripcionOrigen.Location = new System.Drawing.Point(14, 38);
            this.rdDescripcionOrigen.Name = "rdDescripcionOrigen";
            this.rdDescripcionOrigen.Size = new System.Drawing.Size(81, 17);
            this.rdDescripcionOrigen.TabIndex = 0;
            this.rdDescripcionOrigen.TabStop = true;
            this.rdDescripcionOrigen.Text = "Descripción";
            this.rdDescripcionOrigen.UseVisualStyleBackColor = true;
            // 
            // rdArticuloOrigen
            // 
            this.rdArticuloOrigen.AutoSize = true;
            this.rdArticuloOrigen.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdArticuloOrigen.Location = new System.Drawing.Point(14, 18);
            this.rdArticuloOrigen.Name = "rdArticuloOrigen";
            this.rdArticuloOrigen.Size = new System.Drawing.Size(62, 17);
            this.rdArticuloOrigen.TabIndex = 0;
            this.rdArticuloOrigen.Text = "Artículo";
            this.rdArticuloOrigen.UseVisualStyleBackColor = true;
            // 
            // txtParametros
            // 
            this.txtParametros.Location = new System.Drawing.Point(6, 61);
            this.txtParametros.Name = "txtParametros";
            this.txtParametros.Size = new System.Drawing.Size(219, 20);
            this.txtParametros.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(260, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Seleccione los productos para publicar";
            // 
            // frmPublicar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 514);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstSubcategorias4);
            this.Controls.Add(this.lstSubcategorias3);
            this.Controls.Add(this.lstSubcategorias2);
            this.Controls.Add(this.lstSubcategorias1);
            this.Controls.Add(this.lstCategoriasRopa);
            this.Name = "frmPublicar";
            this.Text = "Publicar productos Mercado Libre";
            this.Load += new System.EventHandler(this.frmPublicar_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstSubcategorias1;
        private System.Windows.Forms.ListBox lstCategoriasRopa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstSubcategorias2;
        private System.Windows.Forms.ListBox lstSubcategorias3;
        private System.Windows.Forms.ListBox lstSubcategorias4;
        private System.Windows.Forms.Button btnContinuar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.RadioButton rdDescripcionOrigen;
        private System.Windows.Forms.RadioButton rdArticuloOrigen;
        private System.Windows.Forms.TextBox txtParametros;
        private System.Windows.Forms.Label label3;
    }
}