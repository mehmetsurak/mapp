namespace Gazi.KazanMyo.MarketApp
{
    partial class frmUrunBul
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
            this.UrunArama = new System.Windows.Forms.GroupBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.txtUrunAd = new System.Windows.Forms.TextBox();
            this.lblUrunNo = new System.Windows.Forms.Label();
            this.UrunArama.SuspendLayout();
            this.SuspendLayout();
            // 
            // UrunArama
            // 
            this.UrunArama.Controls.Add(this.btnAra);
            this.UrunArama.Controls.Add(this.txtUrunAd);
            this.UrunArama.Controls.Add(this.lblUrunNo);
            this.UrunArama.Location = new System.Drawing.Point(12, 57);
            this.UrunArama.Name = "UrunArama";
            this.UrunArama.Size = new System.Drawing.Size(263, 139);
            this.UrunArama.TabIndex = 0;
            this.UrunArama.TabStop = false;
            this.UrunArama.Text = "Ürün Arama Ekranı";
            this.UrunArama.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(65, 103);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(84, 23);
            this.btnAra.TabIndex = 2;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // txtUrunAd
            // 
            this.txtUrunAd.Location = new System.Drawing.Point(65, 77);
            this.txtUrunAd.Name = "txtUrunAd";
            this.txtUrunAd.Size = new System.Drawing.Size(84, 20);
            this.txtUrunAd.TabIndex = 1;
            // 
            // lblUrunNo
            // 
            this.lblUrunNo.AutoSize = true;
            this.lblUrunNo.Location = new System.Drawing.Point(62, 60);
            this.lblUrunNo.Name = "lblUrunNo";
            this.lblUrunNo.Size = new System.Drawing.Size(87, 13);
            this.lblUrunNo.TabIndex = 0;
            this.lblUrunNo.Text = "Ürün Adını Giriniz";
            // 
            // frmUrunBul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 300);
            this.Controls.Add(this.UrunArama);
            this.Name = "frmUrunBul";
            this.Text = "frmUrunBul";
            this.UrunArama.ResumeLayout(false);
            this.UrunArama.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox UrunArama;
        private System.Windows.Forms.Label lblUrunNo;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.TextBox txtUrunAd;
    }
}