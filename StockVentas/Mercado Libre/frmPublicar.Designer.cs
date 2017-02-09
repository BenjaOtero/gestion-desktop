namespace StockVentas.Mercado_Libre
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
            this.lstSubcategorias = new System.Windows.Forms.ListBox();
            this.lstCategoriasRopa = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnAceptarCategoria = new System.Windows.Forms.Button();
            this.btnCreateJson = new System.Windows.Forms.Button();
            this.btnAccessToken = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstSubcategorias
            // 
            this.lstSubcategorias.FormattingEnabled = true;
            this.lstSubcategorias.Location = new System.Drawing.Point(197, 100);
            this.lstSubcategorias.Name = "lstSubcategorias";
            this.lstSubcategorias.Size = new System.Drawing.Size(179, 160);
            this.lstSubcategorias.TabIndex = 16;
            // 
            // lstCategoriasRopa
            // 
            this.lstCategoriasRopa.FormattingEnabled = true;
            this.lstCategoriasRopa.Location = new System.Drawing.Point(12, 100);
            this.lstCategoriasRopa.Name = "lstCategoriasRopa";
            this.lstCategoriasRopa.Size = new System.Drawing.Size(179, 160);
            this.lstCategoriasRopa.TabIndex = 17;
            this.lstCategoriasRopa.DoubleClick += new System.EventHandler(this.lstCategories_DoubleClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(163, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(327, 20);
            this.textBox1.TabIndex = 15;
            // 
            // btnAceptarCategoria
            // 
            this.btnAceptarCategoria.AllowDrop = true;
            this.btnAceptarCategoria.Location = new System.Drawing.Point(33, 266);
            this.btnAceptarCategoria.Name = "btnAceptarCategoria";
            this.btnAceptarCategoria.Size = new System.Drawing.Size(129, 23);
            this.btnAceptarCategoria.TabIndex = 11;
            this.btnAceptarCategoria.Text = "Continuar";
            this.btnAceptarCategoria.UseVisualStyleBackColor = true;
            // 
            // btnCreateJson
            // 
            this.btnCreateJson.AllowDrop = true;
            this.btnCreateJson.Location = new System.Drawing.Point(927, 12);
            this.btnCreateJson.Name = "btnCreateJson";
            this.btnCreateJson.Size = new System.Drawing.Size(129, 23);
            this.btnCreateJson.TabIndex = 12;
            this.btnCreateJson.Text = "Create Json";
            this.btnCreateJson.UseVisualStyleBackColor = true;
            // 
            // btnAccessToken
            // 
            this.btnAccessToken.AllowDrop = true;
            this.btnAccessToken.Location = new System.Drawing.Point(12, 41);
            this.btnAccessToken.Name = "btnAccessToken";
            this.btnAccessToken.Size = new System.Drawing.Size(129, 23);
            this.btnAccessToken.TabIndex = 13;
            this.btnAccessToken.Text = "Token Mercado Libre";
            this.btnAccessToken.UseVisualStyleBackColor = true;
            this.btnAccessToken.Click += new System.EventHandler(this.btnAccessToken_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.AllowDrop = true;
            this.btnLogin.Location = new System.Drawing.Point(12, 12);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(129, 23);
            this.btnLogin.TabIndex = 14;
            this.btnLogin.Text = "Login Mercado Libre";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Categorías";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Subcategorías";
            // 
            // frmPublicar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 771);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstSubcategorias);
            this.Controls.Add(this.lstCategoriasRopa);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnAceptarCategoria);
            this.Controls.Add(this.btnCreateJson);
            this.Controls.Add(this.btnAccessToken);
            this.Controls.Add(this.btnLogin);
            this.Name = "frmPublicar";
            this.Text = "frmPublicar";
            this.Load += new System.EventHandler(this.frmPublicar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstSubcategorias;
        private System.Windows.Forms.ListBox lstCategoriasRopa;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnAceptarCategoria;
        private System.Windows.Forms.Button btnCreateJson;
        private System.Windows.Forms.Button btnAccessToken;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}