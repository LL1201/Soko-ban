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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLivello));
            this.tmrTempo = new System.Windows.Forms.Timer(this.components);
            this.barrasotto = new System.Windows.Forms.StatusStrip();
            this.lblLivello = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblMosse = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblPushes = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTempo = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusBar = new System.Windows.Forms.ToolStripProgressBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.chiudiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.ricaricaLivelloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.manualeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.btnContinua = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTempoRisultato = new System.Windows.Forms.Label();
            this.lblSpinteRisultato = new System.Windows.Forms.Label();
            this.lblMosseRisultato = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlRisultato = new System.Windows.Forms.Panel();
            this.barrasotto.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnlRisultato.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmrTempo
            // 
            this.tmrTempo.Interval = 1000;
            this.tmrTempo.Tick += new System.EventHandler(this.tmrTempo_Tick);
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
            this.lblTempo,
            this.toolStripStatusLabel1,
            this.statusBar});
            this.barrasotto.Location = new System.Drawing.Point(0, 472);
            this.barrasotto.Name = "barrasotto";
            this.barrasotto.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.barrasotto.Size = new System.Drawing.Size(1350, 35);
            this.barrasotto.TabIndex = 2;
            this.barrasotto.Text = "statusStrip1";
            // 
            // lblLivello
            // 
            this.lblLivello.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLivello.Name = "lblLivello";
            this.lblLivello.Size = new System.Drawing.Size(206, 34);
            this.lblLivello.Text = "toolStripStatusLabel1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(78, 34);
            this.toolStripStatusLabel2.Text = "Mosse:";
            // 
            // lblMosse
            // 
            this.lblMosse.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMosse.Name = "lblMosse";
            this.lblMosse.Size = new System.Drawing.Size(206, 34);
            this.lblMosse.Text = "toolStripStatusLabel1";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(76, 34);
            this.toolStripStatusLabel3.Text = "Spinte:";
            // 
            // lblPushes
            // 
            this.lblPushes.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPushes.Name = "lblPushes";
            this.lblPushes.Size = new System.Drawing.Size(206, 34);
            this.lblPushes.Text = "toolStripStatusLabel2";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(80, 34);
            this.toolStripStatusLabel4.Text = "Tempo:";
            // 
            // lblTempo
            // 
            this.lblTempo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempo.Name = "lblTempo";
            this.lblTempo.Size = new System.Drawing.Size(89, 34);
            this.lblTempo.Text = "00:00:00";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(76, 34);
            this.toolStripStatusLabel1.Text = "Livello:";
            // 
            // statusBar
            // 
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(65, 29);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3,
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem4});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1350, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem3.Image")));
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(28, 20);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chiudiToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItem1.Text = "File";
            // 
            // chiudiToolStripMenuItem
            // 
            this.chiudiToolStripMenuItem.Name = "chiudiToolStripMenuItem";
            this.chiudiToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.chiudiToolStripMenuItem.Text = "Chiudi";
            this.chiudiToolStripMenuItem.Click += new System.EventHandler(this.chiudiToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ricaricaLivelloToolStripMenuItem});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(60, 20);
            this.toolStripMenuItem2.Text = "Ricarica";
            // 
            // ricaricaLivelloToolStripMenuItem
            // 
            this.ricaricaLivelloToolStripMenuItem.Name = "ricaricaLivelloToolStripMenuItem";
            this.ricaricaLivelloToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ricaricaLivelloToolStripMenuItem.Text = "Ricarica livello";
            this.ricaricaLivelloToolStripMenuItem.Click += new System.EventHandler(this.ricaricaToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manualeToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(24, 20);
            this.toolStripMenuItem4.Text = "?";
            // 
            // manualeToolStripMenuItem
            // 
            this.manualeToolStripMenuItem.Name = "manualeToolStripMenuItem";
            this.manualeToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.manualeToolStripMenuItem.Text = "Manuale";
            this.manualeToolStripMenuItem.Click += new System.EventHandler(this.manualeToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(424, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(592, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "LIVELLO SUPERATO!";
            // 
            // btnContinua
            // 
            this.btnContinua.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinua.Location = new System.Drawing.Point(517, 319);
            this.btnContinua.Name = "btnContinua";
            this.btnContinua.Size = new System.Drawing.Size(389, 69);
            this.btnContinua.TabIndex = 7;
            this.btnContinua.Text = "CONTINUA";
            this.btnContinua.UseVisualStyleBackColor = true;
            this.btnContinua.Click += new System.EventHandler(this.btnContinua_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lblTempoRisultato);
            this.groupBox1.Controls.Add(this.lblSpinteRisultato);
            this.groupBox1.Controls.Add(this.lblMosseRisultato);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(518, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 209);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Statistiche";
            // 
            // lblTempoRisultato
            // 
            this.lblTempoRisultato.AutoSize = true;
            this.lblTempoRisultato.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempoRisultato.Location = new System.Drawing.Point(277, 144);
            this.lblTempoRisultato.Name = "lblTempoRisultato";
            this.lblTempoRisultato.Size = new System.Drawing.Size(79, 29);
            this.lblTempoRisultato.TabIndex = 12;
            this.lblTempoRisultato.Text = "label9";
            // 
            // lblSpinteRisultato
            // 
            this.lblSpinteRisultato.AutoSize = true;
            this.lblSpinteRisultato.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpinteRisultato.Location = new System.Drawing.Point(277, 88);
            this.lblSpinteRisultato.Name = "lblSpinteRisultato";
            this.lblSpinteRisultato.Size = new System.Drawing.Size(79, 29);
            this.lblSpinteRisultato.TabIndex = 11;
            this.lblSpinteRisultato.Text = "label8";
            // 
            // lblMosseRisultato
            // 
            this.lblMosseRisultato.AutoSize = true;
            this.lblMosseRisultato.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMosseRisultato.Location = new System.Drawing.Point(277, 33);
            this.lblMosseRisultato.Name = "lblMosseRisultato";
            this.lblMosseRisultato.Size = new System.Drawing.Size(79, 29);
            this.lblMosseRisultato.TabIndex = 10;
            this.lblMosseRisultato.Text = "label7";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(33, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(210, 29);
            this.label6.TabIndex = 9;
            this.label6.Text = "Tempo impiegato:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 29);
            this.label5.TabIndex = 8;
            this.label5.Text = "Spinte: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "Mosse: ";
            // 
            // pnlRisultato
            // 
            this.pnlRisultato.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlRisultato.AutoSize = true;
            this.pnlRisultato.BackColor = System.Drawing.Color.White;
            this.pnlRisultato.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlRisultato.Controls.Add(this.groupBox1);
            this.pnlRisultato.Controls.Add(this.btnContinua);
            this.pnlRisultato.Controls.Add(this.label1);
            this.pnlRisultato.Location = new System.Drawing.Point(0, 27);
            this.pnlRisultato.Margin = new System.Windows.Forms.Padding(4);
            this.pnlRisultato.Name = "pnlRisultato";
            this.pnlRisultato.Padding = new System.Windows.Forms.Padding(1);
            this.pnlRisultato.Size = new System.Drawing.Size(1351, 480);
            this.pnlRisultato.TabIndex = 1;
            this.pnlRisultato.Visible = false;
            // 
            // frmLivello
            // 
            this.AcceptButton = this.btnContinua;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1350, 507);
            this.Controls.Add(this.barrasotto);
            this.Controls.Add(this.pnlRisultato);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmLivello";
            this.Text = "Livello";
            this.Load += new System.EventHandler(this.Livello_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.barrasotto.ResumeLayout(false);
            this.barrasotto.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlRisultato.ResumeLayout(false);
            this.pnlRisultato.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer tmrTempo;
        private System.Windows.Forms.StatusStrip barrasotto;
        private System.Windows.Forms.ToolStripStatusLabel lblMosse;
        private System.Windows.Forms.ToolStripStatusLabel lblPushes;
        private System.Windows.Forms.ToolStripStatusLabel lblLivello;
        private System.Windows.Forms.ToolStripStatusLabel lblTempo;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripProgressBar statusBar;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem ricaricaLivelloToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnContinua;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTempoRisultato;
        private System.Windows.Forms.Label lblSpinteRisultato;
        private System.Windows.Forms.Label lblMosseRisultato;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlRisultato;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem chiudiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem manualeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

