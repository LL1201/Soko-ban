namespace Soko_ban
{
    partial class Form1
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
            this.btnSchiacciami = new System.Windows.Forms.Button();
            this.btnOpraio = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSchiacciami
            // 
            this.btnSchiacciami.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSchiacciami.Location = new System.Drawing.Point(281, 69);
            this.btnSchiacciami.Name = "btnSchiacciami";
            this.btnSchiacciami.Size = new System.Drawing.Size(209, 83);
            this.btnSchiacciami.TabIndex = 0;
            this.btnSchiacciami.Text = "Schiacciami";
            this.btnSchiacciami.UseVisualStyleBackColor = true;
            this.btnSchiacciami.Click += new System.EventHandler(this.btnSchiacciami_Click);
            // 
            // btnOpraio
            // 
            this.btnOpraio.Location = new System.Drawing.Point(415, 212);
            this.btnOpraio.Name = "btnOpraio";
            this.btnOpraio.Size = new System.Drawing.Size(75, 23);
            this.btnOpraio.TabIndex = 2;
            this.btnOpraio.Text = "sono opraio";
            this.btnOpraio.UseVisualStyleBackColor = true;
            this.btnOpraio.Click += new System.EventHandler(this.btnOpraio_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(281, 212);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "PUTIN";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnOpraio);
            this.Controls.Add(this.btnSchiacciami);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSchiacciami;
        private System.Windows.Forms.Button btnOpraio;
        private System.Windows.Forms.Button button1;
    }
}

