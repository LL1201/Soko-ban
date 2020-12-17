namespace Soko_ban
{
    partial class frmLivello
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
            this.tmrTempo = new System.Windows.Forms.Timer(this.components);
            this.pnlRisultato = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTempoRisultato = new System.Windows.Forms.Label();
            this.lblSpinteRisultato = new System.Windows.Forms.Label();
            this.lblMosseRisultato = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnContinua = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.barrasotto = new System.Windows.Forms.StatusStrip();
            this.lblLivello = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblMosse = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblPushes = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTempo = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlRisultato.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.barrasotto.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmrTempo
            // 
            this.tmrTempo.Interval = 1000;
            this.tmrTempo.Tick += new System.EventHandler(this.tmrTempo_Tick);
            // 
            // pnlRisultato
            // 
            this.pnlRisultato.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pnlRisultato.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.pnlRisultato.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlRisultato.Controls.Add(this.groupBox1);
            this.pnlRisultato.Controls.Add(this.btnContinua);
            this.pnlRisultato.Controls.Add(this.label1);
            this.pnlRisultato.Location = new System.Drawing.Point(335, 0);
            this.pnlRisultato.Margin = new System.Windows.Forms.Padding(4);
            this.pnlRisultato.Name = "pnlRisultato";
            this.pnlRisultato.Size = new System.Drawing.Size(1650, 799);
            this.pnlRisultato.TabIndex = 1;
            this.pnlRisultato.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTempoRisultato);
            this.groupBox1.Controls.Add(this.lblSpinteRisultato);
            this.groupBox1.Controls.Add(this.lblMosseRisultato);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(217, 128);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(519, 257);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Statistiche";
            // 
            // lblTempoRisultato
            // 
            this.lblTempoRisultato.AutoSize = true;
            this.lblTempoRisultato.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempoRisultato.Location = new System.Drawing.Point(369, 177);
            this.lblTempoRisultato.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTempoRisultato.Name = "lblTempoRisultato";
            this.lblTempoRisultato.Size = new System.Drawing.Size(95, 36);
            this.lblTempoRisultato.TabIndex = 12;
            this.lblTempoRisultato.Text = "label9";
            // 
            // lblSpinteRisultato
            // 
            this.lblSpinteRisultato.AutoSize = true;
            this.lblSpinteRisultato.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpinteRisultato.Location = new System.Drawing.Point(369, 108);
            this.lblSpinteRisultato.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSpinteRisultato.Name = "lblSpinteRisultato";
            this.lblSpinteRisultato.Size = new System.Drawing.Size(95, 36);
            this.lblSpinteRisultato.TabIndex = 11;
            this.lblSpinteRisultato.Text = "label8";
            // 
            // lblMosseRisultato
            // 
            this.lblMosseRisultato.AutoSize = true;
            this.lblMosseRisultato.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMosseRisultato.Location = new System.Drawing.Point(369, 41);
            this.lblMosseRisultato.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMosseRisultato.Name = "lblMosseRisultato";
            this.lblMosseRisultato.Size = new System.Drawing.Size(95, 36);
            this.lblMosseRisultato.TabIndex = 10;
            this.lblMosseRisultato.Text = "label7";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(44, 177);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(250, 36);
            this.label6.TabIndex = 9;
            this.label6.Text = "Tempo impiegato:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(44, 108);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 36);
            this.label5.TabIndex = 8;
            this.label5.Text = "Spinte: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 41);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 36);
            this.label3.TabIndex = 7;
            this.label3.Text = "Mosse: ";
            // 
            // btnContinua
            // 
            this.btnContinua.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinua.Location = new System.Drawing.Point(300, 393);
            this.btnContinua.Margin = new System.Windows.Forms.Padding(4);
            this.btnContinua.Name = "btnContinua";
            this.btnContinua.Size = new System.Drawing.Size(373, 85);
            this.btnContinua.TabIndex = 7;
            this.btnContinua.Text = "CONTINUA";
            this.btnContinua.UseVisualStyleBackColor = true;
            this.btnContinua.Click += new System.EventHandler(this.btnContinua_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(497, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(481, 91);
            this.label1.TabIndex = 0;
            this.label1.Text = "HAI VINTO!!";
            // 
            // barrasotto
            // 
            this.barrasotto.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.barrasotto.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblLivello,
            this.toolStripStatusLabel2,
            this.lblMosse,
            this.toolStripStatusLabel3,
            this.lblPushes,
            this.toolStripStatusLabel4,
            this.lblTempo});
            this.barrasotto.Location = new System.Drawing.Point(0, 577);
            this.barrasotto.Name = "barrasotto";
            this.barrasotto.Size = new System.Drawing.Size(1596, 47);
            this.barrasotto.TabIndex = 2;
            this.barrasotto.Text = "statusStrip1";
            // 
            // lblLivello
            // 
            this.lblLivello.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLivello.Name = "lblLivello";
            this.lblLivello.Size = new System.Drawing.Size(297, 41);
            this.lblLivello.Text = "toolStripStatusLabel1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(112, 41);
            this.toolStripStatusLabel2.Text = "Mosse:";
            // 
            // lblMosse
            // 
            this.lblMosse.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMosse.Name = "lblMosse";
            this.lblMosse.Size = new System.Drawing.Size(297, 41);
            this.lblMosse.Text = "toolStripStatusLabel1";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(109, 41);
            this.toolStripStatusLabel3.Text = "Spinte:";
            // 
            // lblPushes
            // 
            this.lblPushes.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPushes.Name = "lblPushes";
            this.lblPushes.Size = new System.Drawing.Size(297, 41);
            this.lblPushes.Text = "toolStripStatusLabel2";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(116, 41);
            this.toolStripStatusLabel4.Text = "Tempo:";
            // 
            // lblTempo
            // 
            this.lblTempo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempo.Name = "lblTempo";
            this.lblTempo.Size = new System.Drawing.Size(128, 41);
            this.lblTempo.Text = "00:00:00";
            // 
            // frmLivello
            // 
            this.AcceptButton = this.btnContinua;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1596, 624);
            this.Controls.Add(this.barrasotto);
            this.Controls.Add(this.pnlRisultato);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmLivello";
            this.Text = "Livello";
            this.Load += new System.EventHandler(this.Livello_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.pnlRisultato.ResumeLayout(false);
            this.pnlRisultato.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.barrasotto.ResumeLayout(false);
            this.barrasotto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer tmrTempo;
        private System.Windows.Forms.Panel pnlRisultato;
        private System.Windows.Forms.Button btnContinua;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTempoRisultato;
        private System.Windows.Forms.Label lblSpinteRisultato;
        private System.Windows.Forms.Label lblMosseRisultato;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.StatusStrip barrasotto;
        private System.Windows.Forms.ToolStripStatusLabel lblMosse;
        private System.Windows.Forms.ToolStripStatusLabel lblPushes;
        private System.Windows.Forms.ToolStripStatusLabel lblLivello;
        private System.Windows.Forms.ToolStripStatusLabel lblTempo;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
    }
}

