namespace ParkPrirode.Forme
{
    partial class DodajSeloForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DodajSeloForm));
            this.txtImeSela = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdDodajSelo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtImeSela
            // 
            this.txtImeSela.Location = new System.Drawing.Point(126, 37);
            this.txtImeSela.Name = "txtImeSela";
            this.txtImeSela.Size = new System.Drawing.Size(153, 22);
            this.txtImeSela.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ime sela:";
            // 
            // cmdDodajSelo
            // 
            this.cmdDodajSelo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmdDodajSelo.Location = new System.Drawing.Point(104, 84);
            this.cmdDodajSelo.Name = "cmdDodajSelo";
            this.cmdDodajSelo.Size = new System.Drawing.Size(122, 35);
            this.cmdDodajSelo.TabIndex = 2;
            this.cmdDodajSelo.Text = "Dodaj selo";
            this.cmdDodajSelo.UseVisualStyleBackColor = false;
            this.cmdDodajSelo.Click += new System.EventHandler(this.cmdDodajSelo_Click);
            // 
            // DodajSeloForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(329, 149);
            this.Controls.Add(this.cmdDodajSelo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtImeSela);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DodajSeloForm";
            this.Text = "Dodaj selo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtImeSela;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdDodajSelo;
    }
}