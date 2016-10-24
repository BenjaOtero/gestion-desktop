namespace StockVentas
{
    partial class frmArticulosAgrupar
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
            this.components = new System.ComponentModel.Container();
            this.dgvDatosOrigen = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvDatosDestino = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnBuscarOrigen = new System.Windows.Forms.Button();
            this.txtParametrosOrigen = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdDescripcionOrigen = new System.Windows.Forms.RadioButton();
            this.rdArticuloOrigen = new System.Windows.Forms.RadioButton();
            this.lblLinea = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.btnAgrupar = new System.Windows.Forms.Button();
            this.btnBuscarDestino = new System.Windows.Forms.Button();
            this.txtParametrosDestino = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdDescripcionDestino = new System.Windows.Forms.RadioButton();
            this.rdArticuloDestino = new System.Windows.Forms.RadioButton();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosOrigen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosDestino)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDatosOrigen
            // 
            this.dgvDatosOrigen.AllowUserToAddRows = false;
            this.dgvDatosOrigen.AllowUserToDeleteRows = false;
            this.dgvDatosOrigen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosOrigen.Location = new System.Drawing.Point(12, 24);
            this.dgvDatosOrigen.Name = "dgvDatosOrigen";
            this.dgvDatosOrigen.Size = new System.Drawing.Size(869, 282);
            this.dgvDatosOrigen.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(13, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seleccione los artículos a agrupar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(13, 334);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Seleccione un articulo de destino";
            // 
            // dgvDatosDestino
            // 
            this.dgvDatosDestino.AllowUserToAddRows = false;
            this.dgvDatosDestino.AllowUserToDeleteRows = false;
            this.dgvDatosDestino.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosDestino.Location = new System.Drawing.Point(13, 361);
            this.dgvDatosDestino.Name = "dgvDatosDestino";
            this.dgvDatosDestino.Size = new System.Drawing.Size(868, 264);
            this.dgvDatosDestino.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSalir);
            this.groupBox1.Controls.Add(this.btnBuscarOrigen);
            this.groupBox1.Controls.Add(this.txtParametrosOrigen);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Location = new System.Drawing.Point(893, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(173, 215);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar";
            // 
            // btnSalir
            // 
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSalir.Image = global::StockVentas.Properties.Resources.salir;
            this.btnSalir.Location = new System.Drawing.Point(10, 101);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(147, 40);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = " Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnBuscarOrigen
            // 
            this.btnBuscarOrigen.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBuscarOrigen.Image = global::StockVentas.Properties.Resources.buscar;
            this.btnBuscarOrigen.Location = new System.Drawing.Point(10, 55);
            this.btnBuscarOrigen.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.btnBuscarOrigen.Name = "btnBuscarOrigen";
            this.btnBuscarOrigen.Size = new System.Drawing.Size(147, 40);
            this.btnBuscarOrigen.TabIndex = 0;
            this.btnBuscarOrigen.Text = "Buscar";
            this.btnBuscarOrigen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscarOrigen.UseVisualStyleBackColor = true;
            this.btnBuscarOrigen.Click += new System.EventHandler(this.btnBuscarOrigen_Click);
            // 
            // txtParametrosOrigen
            // 
            this.txtParametrosOrigen.Location = new System.Drawing.Point(5, 20);
            this.txtParametrosOrigen.Name = "txtParametrosOrigen";
            this.txtParametrosOrigen.Size = new System.Drawing.Size(161, 20);
            this.txtParametrosOrigen.TabIndex = 0;
            this.txtParametrosOrigen.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtParametrosOrigen_KeyDown);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdDescripcionOrigen);
            this.groupBox3.Controls.Add(this.rdArticuloOrigen);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox3.Location = new System.Drawing.Point(893, 24);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(173, 61);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Buscar por:";
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
            // lblLinea
            // 
            this.lblLinea.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLinea.Location = new System.Drawing.Point(9, 319);
            this.lblLinea.Name = "lblLinea";
            this.lblLinea.Size = new System.Drawing.Size(1057, 10);
            this.lblLinea.TabIndex = 2;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnGenerar);
            this.groupBox4.Controls.Add(this.btnAgrupar);
            this.groupBox4.Controls.Add(this.btnBuscarDestino);
            this.groupBox4.Controls.Add(this.txtParametrosDestino);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox4.Location = new System.Drawing.Point(896, 426);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(173, 199);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Buscar";
            // 
            // btnGenerar
            // 
            this.btnGenerar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGenerar.Image = global::StockVentas.Properties.Resources.generar;
            this.btnGenerar.Location = new System.Drawing.Point(13, 146);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(147, 40);
            this.btnGenerar.TabIndex = 1;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // btnAgrupar
            // 
            this.btnAgrupar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAgrupar.Image = global::StockVentas.Properties.Resources.agrupar;
            this.btnAgrupar.Location = new System.Drawing.Point(13, 99);
            this.btnAgrupar.Name = "btnAgrupar";
            this.btnAgrupar.Size = new System.Drawing.Size(147, 40);
            this.btnAgrupar.TabIndex = 6;
            this.btnAgrupar.Text = "Agrupar";
            this.btnAgrupar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgrupar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgrupar.UseVisualStyleBackColor = true;
            this.btnAgrupar.Click += new System.EventHandler(this.btnAgrupar_Click);
            // 
            // btnBuscarDestino
            // 
            this.btnBuscarDestino.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBuscarDestino.Image = global::StockVentas.Properties.Resources.buscar;
            this.btnBuscarDestino.Location = new System.Drawing.Point(13, 53);
            this.btnBuscarDestino.Name = "btnBuscarDestino";
            this.btnBuscarDestino.Size = new System.Drawing.Size(147, 40);
            this.btnBuscarDestino.TabIndex = 8;
            this.btnBuscarDestino.Text = "Buscar destino";
            this.btnBuscarDestino.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscarDestino.UseVisualStyleBackColor = true;
            this.btnBuscarDestino.Click += new System.EventHandler(this.btnBuscarDestino_Click);
            // 
            // txtParametrosDestino
            // 
            this.txtParametrosDestino.Location = new System.Drawing.Point(5, 20);
            this.txtParametrosDestino.Name = "txtParametrosDestino";
            this.txtParametrosDestino.Size = new System.Drawing.Size(161, 20);
            this.txtParametrosDestino.TabIndex = 0;
            this.txtParametrosDestino.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtParametrosDestino_KeyDown);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdDescripcionDestino);
            this.groupBox2.Controls.Add(this.rdArticuloDestino);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox2.Location = new System.Drawing.Point(896, 359);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(173, 61);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buscar por:";
            // 
            // rdDescripcionDestino
            // 
            this.rdDescripcionDestino.AutoSize = true;
            this.rdDescripcionDestino.Checked = true;
            this.rdDescripcionDestino.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdDescripcionDestino.Location = new System.Drawing.Point(14, 38);
            this.rdDescripcionDestino.Name = "rdDescripcionDestino";
            this.rdDescripcionDestino.Size = new System.Drawing.Size(81, 17);
            this.rdDescripcionDestino.TabIndex = 0;
            this.rdDescripcionDestino.TabStop = true;
            this.rdDescripcionDestino.Text = "Descripción";
            this.rdDescripcionDestino.UseVisualStyleBackColor = true;
            // 
            // rdArticuloDestino
            // 
            this.rdArticuloDestino.AutoSize = true;
            this.rdArticuloDestino.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdArticuloDestino.Location = new System.Drawing.Point(14, 18);
            this.rdArticuloDestino.Name = "rdArticuloDestino";
            this.rdArticuloDestino.Size = new System.Drawing.Size(62, 17);
            this.rdArticuloDestino.TabIndex = 0;
            this.rdArticuloDestino.Text = "Artículo";
            this.rdArticuloDestino.UseVisualStyleBackColor = true;
            // 
            // frmArticulosAgrupar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 639);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.lblLinea);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDatosDestino);
            this.Controls.Add(this.dgvDatosOrigen);
            this.MaximizeBox = false;
            this.Name = "frmArticulosAgrupar";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agrupar artículos";
            this.Load += new System.EventHandler(this.frmArticulosAgrupar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosOrigen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosDestino)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDatosOrigen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvDatosDestino;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtParametrosOrigen;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdDescripcionOrigen;
        private System.Windows.Forms.RadioButton rdArticuloOrigen;
        private System.Windows.Forms.Button btnBuscarOrigen;
        private System.Windows.Forms.Label lblLinea;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnAgrupar;
        private System.Windows.Forms.Button btnBuscarDestino;
        private System.Windows.Forms.TextBox txtParametrosDestino;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdDescripcionDestino;
        private System.Windows.Forms.RadioButton rdArticuloDestino;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}