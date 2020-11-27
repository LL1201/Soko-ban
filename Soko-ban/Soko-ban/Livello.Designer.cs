namespace Soko_ban
{
    partial class Livello
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlCampoGioco = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTempo = new System.Windows.Forms.Label();
            this.lblPushes = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblMosse = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblLivello = new System.Windows.Forms.Label();
            this.tmrTempo = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCampoGioco
            // 
            this.pnlCampoGioco.Location = new System.Drawing.Point(12, 12);
            this.pnlCampoGioco.Name = "pnlCampoGioco";
            this.pnlCampoGioco.Size = new System.Drawing.Size(737, 416);
            this.pnlCampoGioco.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTempo);
            this.panel1.Controls.Add(this.lblPushes);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblMosse);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblLivello);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 437);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(793, 47);
            this.panel1.TabIndex = 0;
            // 
            // lblTempo
            // 
            this.lblTempo.AutoSize = true;
            this.lblTempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempo.Location = new System.Drawing.Point(627, 9);
            this.lblTempo.Name = "lblTempo";
            this.lblTempo.Size = new System.Drawing.Size(79, 29);
            this.lblTempo.TabIndex = 6;
            this.lblTempo.Text = "label3";
            // 
            // lblPushes
            // 
            this.lblPushes.AutoSize = true;
            this.lblPushes.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPushes.Location = new System.Drawing.Point(498, 9);
            this.lblPushes.Name = "lblPushes";
            this.lblPushes.Size = new System.Drawing.Size(19, 29);
            this.lblPushes.TabIndex = 5;
            this.lblPushes.Text = ".";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(404, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "Spinte:";
            // 
            // lblMosse
            // 
            this.lblMosse.AutoSize = true;
            this.lblMosse.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMosse.Location = new System.Drawing.Point(259, 9);
            this.lblMosse.Name = "lblMosse";
            this.lblMosse.Size = new System.Drawing.Size(19, 29);
            this.lblMosse.TabIndex = 3;
            this.lblMosse.Text = ".";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(172, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mosse:";
            // 
            // lblLivello
            // 
            this.lblLivello.AutoSize = true;
            this.lblLivello.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLivello.Location = new System.Drawing.Point(7, 9);
            this.lblLivello.MaximumSize = new System.Drawing.Size(0, 40);
            this.lblLivello.Name = "lblLivello";
            this.lblLivello.Size = new System.Drawing.Size(0, 29);
            this.lblLivello.TabIndex = 0;
            // 
            // tmrTempo
            // 
            this.tmrTempo.Interval = 1000;
            this.tmrTempo.Tick += new System.EventHandler(this.tmrTempo_Tick);
            // 
            // Livello
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(793, 484);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlCampoGioco);
            this.KeyPreview = true;
            this.Name = "Livello";
            this.Text = "Livello";
            this.Load += new System.EventHandler(this.Livello1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCampoGioco;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblPushes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblMosse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTempo;
        private System.Windows.Forms.Timer tmrTempo;
        private System.Windows.Forms.Label lblLivello;
    }
}

