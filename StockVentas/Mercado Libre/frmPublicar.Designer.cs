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
            this.lstChildren = new System.Windows.Forms.ListBox();
            this.lstCategories = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnAceptarCategoria = new System.Windows.Forms.Button();
            this.btnCreateJson = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnMercadoLibre = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstChildren
            // 
            this.lstChildren.FormattingEnabled = true;
            this.lstChildren.Location = new System.Drawing.Point(197, 133);
            this.lstChildren.Name = "lstChildren";
            this.lstChildren.Size = new System.Drawing.Size(179, 160);
            this.lstChildren.TabIndex = 16;
            // 
            // lstCategories
            // 
            this.lstCategories.FormattingEnabled = true;
            this.lstCategories.Location = new System.Drawing.Point(12, 133);
            this.lstCategories.Name = "lstCategories";
            this.lstCategories.Size = new System.Drawing.Size(179, 160);
            this.lstCategories.TabIndex = 17;
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
            this.btnAceptarCategoria.Location = new System.Drawing.Point(33, 299);
            this.btnAceptarCategoria.Name = "btnAceptarCategoria";
            this.btnAceptarCategoria.Size = new System.Drawing.Size(129, 23);
            this.btnAceptarCategoria.TabIndex = 11;
            this.btnAceptarCategoria.Text = "Continuar";
            this.btnAceptarCategoria.UseVisualStyleBackColor = true;
            // 
            // btnCreateJson
            // 
            this.btnCreateJson.AllowDrop = true;
            this.btnCreateJson.Location = new System.Drawing.Point(12, 70);
            this.btnCreateJson.Name = "btnCreateJson";
            this.btnCreateJson.Size = new System.Drawing.Size(129, 23);
            this.btnCreateJson.TabIndex = 12;
            this.btnCreateJson.Text = "Create Json";
            this.btnCreateJson.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.AllowDrop = true;
            this.button4.Location = new System.Drawing.Point(12, 41);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(129, 23);
            this.button4.TabIndex = 13;
            this.button4.Text = "Token Mercado Libre";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btnMercadoLibre
            // 
            this.btnMercadoLibre.AllowDrop = true;
            this.btnMercadoLibre.Location = new System.Drawing.Point(12, 12);
            this.btnMercadoLibre.Name = "btnMercadoLibre";
            this.btnMercadoLibre.Size = new System.Drawing.Size(129, 23);
            this.btnMercadoLibre.TabIndex = 14;
            this.btnMercadoLibre.Text = "Login Mercado Libre";
            this.btnMercadoLibre.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Categorías";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 114);
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
            this.Controls.Add(this.lstChildren);
            this.Controls.Add(this.lstCategories);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnAceptarCategoria);
            this.Controls.Add(this.btnCreateJson);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnMercadoLibre);
            this.Name = "frmPublicar";
            this.Text = "frmPublicar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstChildren;
        private System.Windows.Forms.ListBox lstCategories;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnAceptarCategoria;
        private System.Windows.Forms.Button btnCreateJson;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnMercadoLibre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}