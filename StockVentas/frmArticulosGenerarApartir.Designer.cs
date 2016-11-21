namespace StockVentas
{
    partial class frmArticulosGenerarApartir
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnColor = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.txtHasta = new System.Windows.Forms.TextBox();
            this.txtDesde = new System.Windows.Forms.TextBox();
            this.grpIncrementar = new System.Windows.Forms.GroupBox();
            this.rd2 = new System.Windows.Forms.RadioButton();
            this.rd1 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lstColores = new System.Windows.Forms.ListBox();
            this.cmbArticulo = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdAmericano = new System.Windows.Forms.RadioButton();
            this.rdNumerico = new System.Windows.Forms.RadioButton();
            this.cmbTalleHasta = new System.Windows.Forms.ComboBox();
            this.cmbTalleDesde = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            this.grpIncrementar.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSalir);
            this.groupBox2.Controls.Add(this.btnColor);
            this.groupBox2.Controls.Add(this.btnGrabar);
            this.groupBox2.Location = new System.Drawing.Point(365, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(156, 389);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::StockVentas.Properties.Resources.salir;
            this.btnSalir.Location = new System.Drawing.Point(13, 150);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(130, 54);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = " Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnColor
            // 
            this.btnColor.Image = global::StockVentas.Properties.Resources.add_color;
            this.btnColor.Location = new System.Drawing.Point(13, 87);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(130, 54);
            this.btnColor.TabIndex = 1;
            this.btnColor.Text = "Agregar color";
            this.btnColor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Image = global::StockVentas.Properties.Resources.grabar;
            this.btnGrabar.Location = new System.Drawing.Point(13, 24);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(130, 54);
            this.btnGrabar.TabIndex = 0;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // txtHasta
            // 
            this.txtHasta.Location = new System.Drawing.Point(92, 356);
            this.txtHasta.Name = "txtHasta";
            this.txtHasta.Size = new System.Drawing.Size(226, 20);
            this.txtHasta.TabIndex = 6;
            // 
            // txtDesde
            // 
            this.txtDesde.Location = new System.Drawing.Point(92, 330);
            this.txtDesde.Name = "txtDesde";
            this.txtDesde.Size = new System.Drawing.Size(226, 20);
            this.txtDesde.TabIndex = 5;
            // 
            // grpIncrementar
            // 
            this.grpIncrementar.Controls.Add(this.rd2);
            this.grpIncrementar.Controls.Add(this.rd1);
            this.grpIncrementar.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.grpIncrementar.Location = new System.Drawing.Point(18, 259);
            this.grpIncrementar.Name = "grpIncrementar";
            this.grpIncrementar.Size = new System.Drawing.Size(301, 65);
            this.grpIncrementar.TabIndex = 4;
            this.grpIncrementar.TabStop = false;
            this.grpIncrementar.Text = "Valor a incrementar por talle";
            // 
            // rd2
            // 
            this.rd2.AutoSize = true;
            this.rd2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rd2.Location = new System.Drawing.Point(12, 39);
            this.rd2.Name = "rd2";
            this.rd2.Size = new System.Drawing.Size(31, 17);
            this.rd2.TabIndex = 1;
            this.rd2.TabStop = true;
            this.rd2.Text = "2";
            this.rd2.UseVisualStyleBackColor = true;
            // 
            // rd1
            // 
            this.rd1.AutoSize = true;
            this.rd1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rd1.Location = new System.Drawing.Point(12, 16);
            this.rd1.Name = "rd1";
            this.rd1.Size = new System.Drawing.Size(31, 17);
            this.rd1.TabIndex = 0;
            this.rd1.TabStop = true;
            this.rd1.Text = "1";
            this.rd1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(14, 356);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 15);
            this.label4.TabIndex = 63;
            this.label4.Text = "Hasta talle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(14, 330);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 15);
            this.label2.TabIndex = 62;
            this.label2.Text = "Desde talle";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(15, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 61;
            this.label1.Text = "Colores";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(15, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 15);
            this.label3.TabIndex = 53;
            this.label3.Text = "Artículo";
            // 
            // lstColores
            // 
            this.lstColores.FormattingEnabled = true;
            this.lstColores.Location = new System.Drawing.Point(93, 46);
            this.lstColores.Name = "lstColores";
            this.lstColores.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstColores.Size = new System.Drawing.Size(225, 134);
            this.lstColores.Sorted = true;
            this.lstColores.TabIndex = 2;
            // 
            // cmbArticulo
            // 
            this.cmbArticulo.FormattingEnabled = true;
            this.cmbArticulo.Location = new System.Drawing.Point(93, 19);
            this.cmbArticulo.Name = "cmbArticulo";
            this.cmbArticulo.Size = new System.Drawing.Size(226, 21);
            this.cmbArticulo.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdAmericano);
            this.groupBox3.Controls.Add(this.rdNumerico);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox3.Location = new System.Drawing.Point(19, 186);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(300, 67);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sistema de talles";
            // 
            // rdAmericano
            // 
            this.rdAmericano.AutoSize = true;
            this.rdAmericano.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdAmericano.Location = new System.Drawing.Point(7, 43);
            this.rdAmericano.Name = "rdAmericano";
            this.rdAmericano.Size = new System.Drawing.Size(75, 17);
            this.rdAmericano.TabIndex = 1;
            this.rdAmericano.Text = "Americano";
            this.rdAmericano.UseVisualStyleBackColor = true;
            this.rdAmericano.Click += new System.EventHandler(this.rdAmericano_Click);
            // 
            // rdNumerico
            // 
            this.rdNumerico.AutoSize = true;
            this.rdNumerico.Checked = true;
            this.rdNumerico.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdNumerico.Location = new System.Drawing.Point(7, 20);
            this.rdNumerico.Name = "rdNumerico";
            this.rdNumerico.Size = new System.Drawing.Size(70, 17);
            this.rdNumerico.TabIndex = 0;
            this.rdNumerico.TabStop = true;
            this.rdNumerico.Text = "Numérico";
            this.rdNumerico.UseVisualStyleBackColor = true;
            this.rdNumerico.Click += new System.EventHandler(this.rdNumerico_Click);
            // 
            // cmbTalleHasta
            // 
            this.cmbTalleHasta.FormattingEnabled = true;
            this.cmbTalleHasta.Location = new System.Drawing.Point(17, 108);
            this.cmbTalleHasta.Name = "cmbTalleHasta";
            this.cmbTalleHasta.Size = new System.Drawing.Size(70, 21);
            this.cmbTalleHasta.TabIndex = 6;
            this.cmbTalleHasta.Visible = false;
            // 
            // cmbTalleDesde
            // 
            this.cmbTalleDesde.FormattingEnabled = true;
            this.cmbTalleDesde.Location = new System.Drawing.Point(17, 76);
            this.cmbTalleDesde.Name = "cmbTalleDesde";
            this.cmbTalleDesde.Size = new System.Drawing.Size(70, 21);
            this.cmbTalleDesde.TabIndex = 5;
            this.cmbTalleDesde.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbTalleHasta);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmbTalleDesde);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lstColores);
            this.groupBox1.Controls.Add(this.grpIncrementar);
            this.groupBox1.Controls.Add(this.txtDesde);
            this.groupBox1.Controls.Add(this.txtHasta);
            this.groupBox1.Controls.Add(this.cmbArticulo);
            this.groupBox1.Location = new System.Drawing.Point(12, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(339, 389);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // frmArticulosGenerarApartir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 408);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmArticulosGenerarApartir";
            this.Text = "Generar artículos desde uno existente.";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmArticulosGenerarApartir_FormClosing);
            this.Load += new System.EventHandler(this.frmArticulosGenerarApartir_Load);
            this.groupBox2.ResumeLayout(false);
            this.grpIncrementar.ResumeLayout(false);
            this.grpIncrementar.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.TextBox txtHasta;
        private System.Windows.Forms.TextBox txtDesde;
        private System.Windows.Forms.GroupBox grpIncrementar;
        private System.Windows.Forms.RadioButton rd2;
        private System.Windows.Forms.RadioButton rd1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstColores;
        private System.Windows.Forms.ComboBox cmbArticulo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdAmericano;
        private System.Windows.Forms.RadioButton rdNumerico;
        private System.Windows.Forms.ComboBox cmbTalleHasta;
        private System.Windows.Forms.ComboBox cmbTalleDesde;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}