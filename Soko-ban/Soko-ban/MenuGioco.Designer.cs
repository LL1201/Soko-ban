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
            this.txtLevel = new System.Windows.Forms.TextBox();
            this.btnAvvia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtLevel
            // 
            this.txtLevel.Location = new System.Drawing.Point(254, 160);
            this.txtLevel.Name = "txtLevel";
            this.txtLevel.Size = new System.Drawing.Size(133, 20);
            this.txtLevel.TabIndex = 0;
            // 
            // btnAvvia
            // 
            this.btnAvvia.Location = new System.Drawing.Point(444, 173);
            this.btnAvvia.Name = "btnAvvia";
            this.btnAvvia.Size = new System.Drawing.Size(75, 23);
            this.btnAvvia.TabIndex = 1;
            this.btnAvvia.Text = "Avvia";
            this.btnAvvia.UseVisualStyleBackColor = true;
            this.btnAvvia.Click += new System.EventHandler(this.btnAvvia_Click);
            // 
            // MenuGioco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAvvia);
            this.Controls.Add(this.txtLevel);
            this.Name = "MenuGioco";
            this.Text = "MenuGioco";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLevel;
        private System.Windows.Forms.Button btnAvvia;
    }
}