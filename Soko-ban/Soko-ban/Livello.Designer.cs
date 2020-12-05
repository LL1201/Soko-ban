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
            this.pnlCampoGioco = new System.Windows.Forms.Panel();
            this.pnlRisultato = new System.Windows.Forms.Panel();
            this.lblTempoRisultato = new System.Windows.Forms.Label();
            this.lblSpinteRisultato = new System.Windows.Forms.Label();
            this.lblMosseRisultato = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTempo = new System.Windows.Forms.Label();
            this.lblPushes = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblMosse = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblLivello = new System.Windows.Forms.Label();
            this.tmrTempo = new System.Windows.Forms.Timer(this.components);
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.pnlCampoGioco.SuspendLayout();
            this.pnlRisultato.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCampoGioco
            // 
            this.pnlCampoGioco.Controls.Add(this.pnlRisultato);
            this.pnlCampoGioco.Location = new System.Drawing.Point(12, 12);
            this.pnlCampoGioco.Name = "pnlCampoGioco";
            this.pnlCampoGioco.Size = new System.Drawing.Size(737, 416);
            this.pnlCampoGioco.TabIndex = 0;
            // 
            // pnlRisultato
            // 
            this.pnlRisultato.Controls.Add(this.dataGrid);
            this.pnlRisultato.Controls.Add(this.lblTempoRisultato);
            this.pnlRisultato.Controls.Add(this.lblSpinteRisultato);
            this.pnlRisultato.Controls.Add(this.lblMosseRisultato);
            this.pnlRisultato.Controls.Add(this.label6);
            this.pnlRisultato.Controls.Add(this.label5);
            this.pnlRisultato.Controls.Add(this.label3);
            this.pnlRisultato.Controls.Add(this.label1);
            this.pnlRisultato.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRisultato.Location = new System.Drawing.Point(0, 0);
            this.pnlRisultato.Name = "pnlRisultato";
            this.pnlRisultato.Size = new System.Drawing.Size(737, 416);
            this.pnlRisultato.TabIndex = 0;
            this.pnlRisultato.Visible = false;
            // 
            // lblTempoRisultato
            // 
            this.lblTempoRisultato.AutoSize = true;
            this.lblTempoRisultato.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempoRisultato.Location = new System.Drawing.Point(294, 217);
            this.lblTempoRisultato.Name = "lblTempoRisultato";
            this.lblTempoRisultato.Size = new System.Drawing.Size(79, 29);
            this.lblTempoRisultato.TabIndex = 6;
            this.lblTempoRisultato.Text = "label9";
            // 
            // lblSpinteRisultato
            // 
            this.lblSpinteRisultato.AutoSize = true;
            this.lblSpinteRisultato.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpinteRisultato.Location = new System.Drawing.Point(294, 170);
            this.lblSpinteRisultato.Name = "lblSpinteRisultato";
            this.lblSpinteRisultato.Size = new System.Drawing.Size(79, 29);
            this.lblSpinteRisultato.TabIndex = 5;
            this.lblSpinteRisultato.Text = "label8";
            // 
            // lblMosseRisultato
            // 
            this.lblMosseRisultato.AutoSize = true;
            this.lblMosseRisultato.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMosseRisultato.Location = new System.Drawing.Point(294, 126);
            this.lblMosseRisultato.Name = "lblMosseRisultato";
            this.lblMosseRisultato.Size = new System.Drawing.Size(79, 29);
            this.lblMosseRisultato.TabIndex = 4;
            this.lblMosseRisultato.Text = "label7";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(50, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(210, 29);
            this.label6.TabIndex = 3;
            this.label6.Text = "Tempo impiegato:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(50, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 29);
            this.label5.TabIndex = 2;
            this.label5.Text = "Spinte: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mosse: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(388, 73);
            this.label1.TabIndex = 0;
            this.label1.Text = "HAI VINTO!!";
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
            this.lblTempo.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblTempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempo.Location = new System.Drawing.Point(690, 0);
            this.lblTempo.Name = "lblTempo";
            this.lblTempo.Size = new System.Drawing.Size(103, 29);
            this.lblTempo.TabIndex = 6;
            this.lblTempo.Text = "00:00:00";
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
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(420, 141);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(240, 150);
            this.dataGrid.TabIndex = 7;
            // 
            // frmLivello
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(793, 484);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlCampoGioco);
            this.KeyPreview = true;
            this.Name = "frmLivello";
            this.Text = "Livello";
            this.Load += new System.EventHandler(this.Livello_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.pnlCampoGioco.ResumeLayout(false);
            this.pnlRisultato.ResumeLayout(false);
            this.pnlRisultato.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
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
        private System.Windows.Forms.Panel pnlRisultato;
        private System.Windows.Forms.Label lblTempoRisultato;
        private System.Windows.Forms.Label lblSpinteRisultato;
        private System.Windows.Forms.Label lblMosseRisultato;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGrid;
    }
}

