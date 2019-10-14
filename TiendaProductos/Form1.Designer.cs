namespace TiendaProductos
{
    partial class Form1
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.ptbArmaBlanca = new System.Windows.Forms.PictureBox();
            this.btnComprarArmaBlanca = new System.Windows.Forms.Button();
            this.ptbArmaFuego = new System.Windows.Forms.PictureBox();
            this.btnComprarArmaFuego = new System.Windows.Forms.Button();
            this.ptbArmaLazer = new System.Windows.Forms.PictureBox();
            this.btnArmaLazer = new System.Windows.Forms.Button();
            this.lstbProductosSelect = new System.Windows.Forms.ListBox();
            this.lbArmaBlanca = new System.Windows.Forms.Label();
            this.lbArmaFuego = new System.Windows.Forms.Label();
            this.lbArmaLazer = new System.Windows.Forms.Label();
            this.lbCosto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptbArmaBlanca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbArmaFuego)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbArmaLazer)).BeginInit();
            this.SuspendLayout();
            // 
            // ptbArmaBlanca
            // 
            this.ptbArmaBlanca.Location = new System.Drawing.Point(30, 45);
            this.ptbArmaBlanca.Name = "ptbArmaBlanca";
            this.ptbArmaBlanca.Size = new System.Drawing.Size(121, 96);
            this.ptbArmaBlanca.TabIndex = 0;
            this.ptbArmaBlanca.TabStop = false;
            // 
            // btnComprarArmaBlanca
            // 
            this.btnComprarArmaBlanca.Location = new System.Drawing.Point(54, 165);
            this.btnComprarArmaBlanca.Name = "btnComprarArmaBlanca";
            this.btnComprarArmaBlanca.Size = new System.Drawing.Size(75, 23);
            this.btnComprarArmaBlanca.TabIndex = 1;
            this.btnComprarArmaBlanca.Text = "Comprar";
            this.btnComprarArmaBlanca.UseVisualStyleBackColor = true;
            this.btnComprarArmaBlanca.Click += new System.EventHandler(this.BtnComprarArmaBlanca_Click);
            // 
            // ptbArmaFuego
            // 
            this.ptbArmaFuego.Location = new System.Drawing.Point(207, 45);
            this.ptbArmaFuego.Name = "ptbArmaFuego";
            this.ptbArmaFuego.Size = new System.Drawing.Size(121, 96);
            this.ptbArmaFuego.TabIndex = 0;
            this.ptbArmaFuego.TabStop = false;
            // 
            // btnComprarArmaFuego
            // 
            this.btnComprarArmaFuego.Location = new System.Drawing.Point(231, 165);
            this.btnComprarArmaFuego.Name = "btnComprarArmaFuego";
            this.btnComprarArmaFuego.Size = new System.Drawing.Size(75, 23);
            this.btnComprarArmaFuego.TabIndex = 1;
            this.btnComprarArmaFuego.Text = "Comprar";
            this.btnComprarArmaFuego.UseVisualStyleBackColor = true;
            this.btnComprarArmaFuego.Click += new System.EventHandler(this.BtnComprarArmaBlanca_Click);
            // 
            // ptbArmaLazer
            // 
            this.ptbArmaLazer.Location = new System.Drawing.Point(389, 45);
            this.ptbArmaLazer.Name = "ptbArmaLazer";
            this.ptbArmaLazer.Size = new System.Drawing.Size(121, 96);
            this.ptbArmaLazer.TabIndex = 0;
            this.ptbArmaLazer.TabStop = false;
            // 
            // btnArmaLazer
            // 
            this.btnArmaLazer.Location = new System.Drawing.Point(413, 165);
            this.btnArmaLazer.Name = "btnArmaLazer";
            this.btnArmaLazer.Size = new System.Drawing.Size(75, 23);
            this.btnArmaLazer.TabIndex = 1;
            this.btnArmaLazer.Text = "Comprar";
            this.btnArmaLazer.UseVisualStyleBackColor = true;
            this.btnArmaLazer.Click += new System.EventHandler(this.BtnComprarArmaBlanca_Click);
            // 
            // lstbProductosSelect
            // 
            this.lstbProductosSelect.FormattingEnabled = true;
            this.lstbProductosSelect.Location = new System.Drawing.Point(599, 47);
            this.lstbProductosSelect.Name = "lstbProductosSelect";
            this.lstbProductosSelect.Size = new System.Drawing.Size(119, 121);
            this.lstbProductosSelect.TabIndex = 2;
            // 
            // lbArmaBlanca
            // 
            this.lbArmaBlanca.AutoSize = true;
            this.lbArmaBlanca.Location = new System.Drawing.Point(68, 218);
            this.lbArmaBlanca.Name = "lbArmaBlanca";
            this.lbArmaBlanca.Size = new System.Drawing.Size(35, 13);
            this.lbArmaBlanca.TabIndex = 3;
            this.lbArmaBlanca.Text = "label1";
            this.lbArmaBlanca.Visible = false;
            // 
            // lbArmaFuego
            // 
            this.lbArmaFuego.AutoSize = true;
            this.lbArmaFuego.Location = new System.Drawing.Point(249, 218);
            this.lbArmaFuego.Name = "lbArmaFuego";
            this.lbArmaFuego.Size = new System.Drawing.Size(35, 13);
            this.lbArmaFuego.TabIndex = 3;
            this.lbArmaFuego.Text = "label1";
            this.lbArmaFuego.Visible = false;
            // 
            // lbArmaLazer
            // 
            this.lbArmaLazer.AutoSize = true;
            this.lbArmaLazer.Location = new System.Drawing.Point(433, 218);
            this.lbArmaLazer.Name = "lbArmaLazer";
            this.lbArmaLazer.Size = new System.Drawing.Size(35, 13);
            this.lbArmaLazer.TabIndex = 3;
            this.lbArmaLazer.Text = "label1";
            this.lbArmaLazer.Visible = false;
            // 
            // lbCosto
            // 
            this.lbCosto.AutoSize = true;
            this.lbCosto.Location = new System.Drawing.Point(639, 188);
            this.lbCosto.Name = "lbCosto";
            this.lbCosto.Size = new System.Drawing.Size(19, 13);
            this.lbCosto.TabIndex = 4;
            this.lbCosto.Text = "$0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 298);
            this.Controls.Add(this.lbCosto);
            this.Controls.Add(this.lbArmaLazer);
            this.Controls.Add(this.lbArmaFuego);
            this.Controls.Add(this.lbArmaBlanca);
            this.Controls.Add(this.lstbProductosSelect);
            this.Controls.Add(this.btnArmaLazer);
            this.Controls.Add(this.btnComprarArmaFuego);
            this.Controls.Add(this.btnComprarArmaBlanca);
            this.Controls.Add(this.ptbArmaLazer);
            this.Controls.Add(this.ptbArmaFuego);
            this.Controls.Add(this.ptbArmaBlanca);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ptbArmaBlanca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbArmaFuego)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbArmaLazer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbArmaBlanca;
        private System.Windows.Forms.Button btnComprarArmaBlanca;
        private System.Windows.Forms.PictureBox ptbArmaFuego;
        private System.Windows.Forms.Button btnComprarArmaFuego;
        private System.Windows.Forms.PictureBox ptbArmaLazer;
        private System.Windows.Forms.Button btnArmaLazer;
        private System.Windows.Forms.ListBox lstbProductosSelect;
        private System.Windows.Forms.Label lbArmaBlanca;
        private System.Windows.Forms.Label lbArmaFuego;
        private System.Windows.Forms.Label lbArmaLazer;
        private System.Windows.Forms.Label lbCosto;
    }
}

