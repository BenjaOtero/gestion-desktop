namespace StockVentas.Mercado_Libre
{
    partial class frmPublicar_2
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
            this.grpBotones = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.grpCampos = new System.Windows.Forms.GroupBox();
            this.grpEntrega = new System.Windows.Forms.GroupBox();
            this.chkRetirarEnPersona = new System.Windows.Forms.CheckBox();
            this.chkEnvios = new System.Windows.Forms.CheckBox();
            this.grpIncluirMercadoEnvios = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rdEnvioGratis = new System.Windows.Forms.RadioButton();
            this.rdPagaEnvioComprador = new System.Windows.Forms.RadioButton();
            this.grpGarantia = new System.Windows.Forms.GroupBox();
            this.rdSinGarantia = new System.Windows.Forms.RadioButton();
            this.rdConGarantia = new System.Windows.Forms.RadioButton();
            this.grpMediosPago = new System.Windows.Forms.GroupBox();
            this.rdMercadoPagoPersona = new System.Windows.Forms.RadioButton();
            this.rdSoloMercadoPago = new System.Windows.Forms.RadioButton();
            this.grpCondicionProducto = new System.Windows.Forms.GroupBox();
            this.rdUsado = new System.Windows.Forms.RadioButton();
            this.rdNuevo = new System.Windows.Forms.RadioButton();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lb3 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpBotones.SuspendLayout();
            this.grpCampos.SuspendLayout();
            this.grpEntrega.SuspendLayout();
            this.grpIncluirMercadoEnvios.SuspendLayout();
            this.grpGarantia.SuspendLayout();
            this.grpMediosPago.SuspendLayout();
            this.grpCondicionProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBotones
            // 
            this.grpBotones.Controls.Add(this.btnSalir);
            this.grpBotones.Controls.Add(this.btnGrabar);
            this.grpBotones.Location = new System.Drawing.Point(25, 470);
            this.grpBotones.Name = "grpBotones";
            this.grpBotones.Size = new System.Drawing.Size(352, 68);
            this.grpBotones.TabIndex = 8;
            this.grpBotones.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalir.Image = global::StockVentas.Properties.Resources.salir;
            this.btnSalir.Location = new System.Drawing.Point(185, 16);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(151, 44);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = " Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Image = global::StockVentas.Properties.Resources.grabar;
            this.btnGrabar.Location = new System.Drawing.Point(16, 16);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(151, 44);
            this.btnGrabar.TabIndex = 4;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // grpCampos
            // 
            this.grpCampos.Controls.Add(this.grpEntrega);
            this.grpCampos.Controls.Add(this.grpBotones);
            this.grpCampos.Controls.Add(this.grpGarantia);
            this.grpCampos.Controls.Add(this.grpMediosPago);
            this.grpCampos.Controls.Add(this.grpCondicionProducto);
            this.grpCampos.Controls.Add(this.txtPrecio);
            this.grpCampos.Controls.Add(this.lb3);
            this.grpCampos.Controls.Add(this.txtDescripcion);
            this.grpCampos.Controls.Add(this.label2);
            this.grpCampos.Controls.Add(this.txtTitulo);
            this.grpCampos.Controls.Add(this.label1);
            this.grpCampos.Location = new System.Drawing.Point(12, 12);
            this.grpCampos.Name = "grpCampos";
            this.grpCampos.Size = new System.Drawing.Size(404, 551);
            this.grpCampos.TabIndex = 0;
            this.grpCampos.TabStop = false;
            // 
            // grpEntrega
            // 
            this.grpEntrega.Controls.Add(this.chkRetirarEnPersona);
            this.grpEntrega.Controls.Add(this.chkEnvios);
            this.grpEntrega.Controls.Add(this.grpIncluirMercadoEnvios);
            this.grpEntrega.Location = new System.Drawing.Point(25, 178);
            this.grpEntrega.Name = "grpEntrega";
            this.grpEntrega.Size = new System.Drawing.Size(352, 147);
            this.grpEntrega.TabIndex = 5;
            this.grpEntrega.TabStop = false;
            this.grpEntrega.Text = "Formas de entrega";
            // 
            // chkRetirarEnPersona
            // 
            this.chkRetirarEnPersona.AutoSize = true;
            this.chkRetirarEnPersona.Location = new System.Drawing.Point(14, 118);
            this.chkRetirarEnPersona.Name = "chkRetirarEnPersona";
            this.chkRetirarEnPersona.Size = new System.Drawing.Size(199, 17);
            this.chkRetirarEnPersona.TabIndex = 2;
            this.chkRetirarEnPersona.Text = "También se puede retirar en persona";
            this.chkRetirarEnPersona.UseVisualStyleBackColor = true;
            // 
            // chkEnvios
            // 
            this.chkEnvios.AutoSize = true;
            this.chkEnvios.Location = new System.Drawing.Point(7, 19);
            this.chkEnvios.Name = "chkEnvios";
            this.chkEnvios.Size = new System.Drawing.Size(114, 17);
            this.chkEnvios.TabIndex = 1;
            this.chkEnvios.Text = "Se realizan envíos";
            this.chkEnvios.UseVisualStyleBackColor = true;
            this.chkEnvios.Click += new System.EventHandler(this.chkEnvios_Click);
            // 
            // grpIncluirMercadoEnvios
            // 
            this.grpIncluirMercadoEnvios.Controls.Add(this.label4);
            this.grpIncluirMercadoEnvios.Controls.Add(this.rdEnvioGratis);
            this.grpIncluirMercadoEnvios.Controls.Add(this.rdPagaEnvioComprador);
            this.grpIncluirMercadoEnvios.Enabled = false;
            this.grpIncluirMercadoEnvios.Location = new System.Drawing.Point(7, 42);
            this.grpIncluirMercadoEnvios.Name = "grpIncluirMercadoEnvios";
            this.grpIncluirMercadoEnvios.Size = new System.Drawing.Size(330, 70);
            this.grpIncluirMercadoEnvios.TabIndex = 2;
            this.grpIncluirMercadoEnvios.TabStop = false;
            this.grpIncluirMercadoEnvios.Text = "Incluir Mercado Envíos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(85, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "(a cargo del vendedor)";
            // 
            // rdEnvioGratis
            // 
            this.rdEnvioGratis.AutoSize = true;
            this.rdEnvioGratis.Location = new System.Drawing.Point(7, 44);
            this.rdEnvioGratis.Name = "rdEnvioGratis";
            this.rdEnvioGratis.Size = new System.Drawing.Size(82, 17);
            this.rdEnvioGratis.TabIndex = 1;
            this.rdEnvioGratis.Text = "Envío gratis";
            this.rdEnvioGratis.UseVisualStyleBackColor = true;
            // 
            // rdPagaEnvioComprador
            // 
            this.rdPagaEnvioComprador.AutoSize = true;
            this.rdPagaEnvioComprador.Checked = true;
            this.rdPagaEnvioComprador.Location = new System.Drawing.Point(7, 20);
            this.rdPagaEnvioComprador.Name = "rdPagaEnvioComprador";
            this.rdPagaEnvioComprador.Size = new System.Drawing.Size(163, 17);
            this.rdPagaEnvioComprador.TabIndex = 0;
            this.rdPagaEnvioComprador.TabStop = true;
            this.rdPagaEnvioComprador.Text = "Envío a cargo del comprador";
            this.rdPagaEnvioComprador.UseVisualStyleBackColor = true;
            // 
            // grpGarantia
            // 
            this.grpGarantia.Controls.Add(this.rdSinGarantia);
            this.grpGarantia.Controls.Add(this.rdConGarantia);
            this.grpGarantia.Location = new System.Drawing.Point(25, 402);
            this.grpGarantia.Name = "grpGarantia";
            this.grpGarantia.Size = new System.Drawing.Size(352, 64);
            this.grpGarantia.TabIndex = 7;
            this.grpGarantia.TabStop = false;
            this.grpGarantia.Text = "Garantía";
            // 
            // rdSinGarantia
            // 
            this.rdSinGarantia.AutoSize = true;
            this.rdSinGarantia.Checked = true;
            this.rdSinGarantia.Location = new System.Drawing.Point(7, 40);
            this.rdSinGarantia.Name = "rdSinGarantia";
            this.rdSinGarantia.Size = new System.Drawing.Size(83, 17);
            this.rdSinGarantia.TabIndex = 1;
            this.rdSinGarantia.TabStop = true;
            this.rdSinGarantia.Text = "Sin garantía";
            this.rdSinGarantia.UseVisualStyleBackColor = true;
            // 
            // rdConGarantia
            // 
            this.rdConGarantia.AutoCheck = false;
            this.rdConGarantia.AutoSize = true;
            this.rdConGarantia.Location = new System.Drawing.Point(7, 20);
            this.rdConGarantia.Name = "rdConGarantia";
            this.rdConGarantia.Size = new System.Drawing.Size(87, 17);
            this.rdConGarantia.TabIndex = 0;
            this.rdConGarantia.TabStop = true;
            this.rdConGarantia.Text = "Con garantía";
            this.rdConGarantia.UseVisualStyleBackColor = true;
            // 
            // grpMediosPago
            // 
            this.grpMediosPago.Controls.Add(this.rdMercadoPagoPersona);
            this.grpMediosPago.Controls.Add(this.rdSoloMercadoPago);
            this.grpMediosPago.Location = new System.Drawing.Point(25, 332);
            this.grpMediosPago.Name = "grpMediosPago";
            this.grpMediosPago.Size = new System.Drawing.Size(352, 64);
            this.grpMediosPago.TabIndex = 6;
            this.grpMediosPago.TabStop = false;
            this.grpMediosPago.Text = "Medios de pago";
            // 
            // rdMercadoPagoPersona
            // 
            this.rdMercadoPagoPersona.AutoSize = true;
            this.rdMercadoPagoPersona.Enabled = false;
            this.rdMercadoPagoPersona.Location = new System.Drawing.Point(7, 42);
            this.rdMercadoPagoPersona.Name = "rdMercadoPagoPersona";
            this.rdMercadoPagoPersona.Size = new System.Drawing.Size(279, 17);
            this.rdMercadoPagoPersona.TabIndex = 1;
            this.rdMercadoPagoPersona.Text = "Aceptar pagos por Mercado Pago y cobro en persona";
            this.rdMercadoPagoPersona.UseVisualStyleBackColor = true;
            // 
            // rdSoloMercadoPago
            // 
            this.rdSoloMercadoPago.AutoSize = true;
            this.rdSoloMercadoPago.Checked = true;
            this.rdSoloMercadoPago.Location = new System.Drawing.Point(7, 20);
            this.rdSoloMercadoPago.Name = "rdSoloMercadoPago";
            this.rdSoloMercadoPago.Size = new System.Drawing.Size(207, 17);
            this.rdSoloMercadoPago.TabIndex = 0;
            this.rdSoloMercadoPago.TabStop = true;
            this.rdSoloMercadoPago.Text = "Aceptar pagos solo por Mercado Pago";
            this.rdSoloMercadoPago.UseVisualStyleBackColor = true;
            // 
            // grpCondicionProducto
            // 
            this.grpCondicionProducto.Controls.Add(this.rdUsado);
            this.grpCondicionProducto.Controls.Add(this.rdNuevo);
            this.grpCondicionProducto.Location = new System.Drawing.Point(25, 101);
            this.grpCondicionProducto.Name = "grpCondicionProducto";
            this.grpCondicionProducto.Size = new System.Drawing.Size(352, 70);
            this.grpCondicionProducto.TabIndex = 4;
            this.grpCondicionProducto.TabStop = false;
            this.grpCondicionProducto.Text = "Condición del producto";
            // 
            // rdUsado
            // 
            this.rdUsado.AutoSize = true;
            this.rdUsado.Location = new System.Drawing.Point(7, 44);
            this.rdUsado.Name = "rdUsado";
            this.rdUsado.Size = new System.Drawing.Size(56, 17);
            this.rdUsado.TabIndex = 1;
            this.rdUsado.Text = "Usado";
            this.rdUsado.UseVisualStyleBackColor = true;
            // 
            // rdNuevo
            // 
            this.rdNuevo.AutoSize = true;
            this.rdNuevo.Checked = true;
            this.rdNuevo.Location = new System.Drawing.Point(7, 20);
            this.rdNuevo.Name = "rdNuevo";
            this.rdNuevo.Size = new System.Drawing.Size(57, 17);
            this.rdNuevo.TabIndex = 1;
            this.rdNuevo.TabStop = true;
            this.rdNuevo.Text = "Nuevo";
            this.rdNuevo.UseVisualStyleBackColor = true;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(91, 71);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(286, 20);
            this.txtPrecio.TabIndex = 3;
            // 
            // lb3
            // 
            this.lb3.AutoSize = true;
            this.lb3.Location = new System.Drawing.Point(22, 74);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(37, 13);
            this.lb3.TabIndex = 3;
            this.lb3.Text = "Precio";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(91, 45);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(286, 20);
            this.txtDescripcion.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Descripción";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(91, 19);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(286, 20);
            this.txtTitulo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Título";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmPublicar_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.CancelButton = this.btnSalir;
            this.ClientSize = new System.Drawing.Size(428, 576);
            this.Controls.Add(this.grpCampos);
            this.MaximizeBox = false;
            this.Name = "frmPublicar_2";
            this.Text = "Publicar en Mercado Libre";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmArticulosPrecios_FormClosing);
            this.Load += new System.EventHandler(this.frmPublicar_2_Load);
            this.grpBotones.ResumeLayout(false);
            this.grpCampos.ResumeLayout(false);
            this.grpCampos.PerformLayout();
            this.grpEntrega.ResumeLayout(false);
            this.grpEntrega.PerformLayout();
            this.grpIncluirMercadoEnvios.ResumeLayout(false);
            this.grpIncluirMercadoEnvios.PerformLayout();
            this.grpGarantia.ResumeLayout(false);
            this.grpGarantia.PerformLayout();
            this.grpMediosPago.ResumeLayout(false);
            this.grpMediosPago.PerformLayout();
            this.grpCondicionProducto.ResumeLayout(false);
            this.grpCondicionProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grpBotones;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.GroupBox grpCampos;
        private System.Windows.Forms.Label lb3;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpCondicionProducto;
        private System.Windows.Forms.RadioButton rdUsado;
        private System.Windows.Forms.RadioButton rdNuevo;
        private System.Windows.Forms.GroupBox grpEntrega;
        private System.Windows.Forms.CheckBox chkRetirarEnPersona;
        private System.Windows.Forms.CheckBox chkEnvios;
        private System.Windows.Forms.GroupBox grpIncluirMercadoEnvios;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rdEnvioGratis;
        private System.Windows.Forms.RadioButton rdPagaEnvioComprador;
        private System.Windows.Forms.GroupBox grpGarantia;
        private System.Windows.Forms.RadioButton rdSinGarantia;
        private System.Windows.Forms.RadioButton rdConGarantia;
        private System.Windows.Forms.GroupBox grpMediosPago;
        private System.Windows.Forms.RadioButton rdMercadoPagoPersona;
        private System.Windows.Forms.RadioButton rdSoloMercadoPago;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txtPrecio;
    }
}