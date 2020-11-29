namespace Soko_ban
{
    partial class MenuGioco
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuGioco));
            this.btnLiv1 = new System.Windows.Forms.Button();
            this.btnLiv2 = new System.Windows.Forms.Button();
            this.lblSceltaLivello = new System.Windows.Forms.Label();
            this.pcbLogo = new System.Windows.Forms.PictureBox();
            this.pnlScelta = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).BeginInit();
            this.pnlScelta.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLiv1
            // 
            this.btnLiv1.Location = new System.Drawing.Point(125, 20);
            this.btnLiv1.Name = "btnLiv1";
            this.btnLiv1.Size = new System.Drawing.Size(75, 23);
            this.btnLiv1.TabIndex = 2;
            this.btnLiv1.Text = "Livello 1";
            this.btnLiv1.UseVisualStyleBackColor = true;
            this.btnLiv1.Click += new System.EventHandler(this.btnLiv1_Click);
            // 
            // btnLiv2
            // 
            this.btnLiv2.Location = new System.Drawing.Point(206, 20);
            this.btnLiv2.Name = "btnLiv2";
            this.btnLiv2.Size = new System.Drawing.Size(75, 23);
            this.btnLiv2.TabIndex = 3;
            this.btnLiv2.Text = "Livello 2";
            this.btnLiv2.UseVisualStyleBackColor = true;
            this.btnLiv2.Click += new System.EventHandler(this.btnLiv2_Click);
            // 
            // lblSceltaLivello
            // 
            this.lblSceltaLivello.AutoSize = true;
            this.lblSceltaLivello.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSceltaLivello.Location = new System.Drawing.Point(12, 23);
            this.lblSceltaLivello.Name = "lblSceltaLivello";
            this.lblSceltaLivello.Size = new System.Drawing.Size(107, 20);
            this.lblSceltaLivello.TabIndex = 5;
            this.lblSceltaLivello.Text = "Scegli il livello ";
            // 
            // pcbLogo
            // 
            this.pcbLogo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pcbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pcbLogo.Image")));
            this.pcbLogo.Location = new System.Drawing.Point(0, -2);
            this.pcbLogo.Name = "pcbLogo";
            this.pcbLogo.Size = new System.Drawing.Size(800, 405);
            this.pcbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbLogo.TabIndex = 6;
            this.pcbLogo.TabStop = false;
            // 
            // pnlScelta
            // 
            this.pnlScelta.Controls.Add(this.lblSceltaLivello);
            this.pnlScelta.Controls.Add(this.btnLiv1);
            this.pnlScelta.Controls.Add(this.btnLiv2);
            this.pnlScelta.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlScelta.Location = new System.Drawing.Point(0, 398);
            this.pnlScelta.Name = "pnlScelta";
            this.pnlScelta.Size = new System.Drawing.Size(800, 52);
            this.pnlScelta.TabIndex = 7;
            // 
            // MenuGioco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlScelta);
            this.Controls.Add(this.pcbLogo);
            this.Name = "MenuGioco";
            this.Text = "MENU";
            this.Load += new System.EventHandler(this.MenuGioco_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).EndInit();
            this.pnlScelta.ResumeLayout(false);
            this.pnlScelta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnLiv1;
        private System.Windows.Forms.Button btnLiv2;
        private System.Windows.Forms.Label lblSceltaLivello;
        private System.Windows.Forms.PictureBox pcbLogo;
        private System.Windows.Forms.Panel pnlScelta;
    }
}