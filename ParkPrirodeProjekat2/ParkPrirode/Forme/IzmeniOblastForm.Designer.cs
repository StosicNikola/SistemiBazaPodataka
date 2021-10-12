namespace ParkPrirode.Forme
{
    partial class IzmeniOblastForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IzmeniOblastForm));
            this.cmdNazad = new System.Windows.Forms.Button();
            this.cmdDodajOblast = new System.Windows.Forms.Button();
            this.txtPovrsina = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtImeOblasti = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmdNazad
            // 
            this.cmdNazad.BackColor = System.Drawing.SystemColors.Info;
            this.cmdNazad.Location = new System.Drawing.Point(199, 133);
            this.cmdNazad.Name = "cmdNazad";
            this.cmdNazad.Size = new System.Drawing.Size(142, 41);
            this.cmdNazad.TabIndex = 16;
            this.cmdNazad.Text = "<- Nazad";
            this.cmdNazad.UseVisualStyleBackColor = false;
            this.cmdNazad.Click += new System.EventHandler(this.cmdNazad_Click);
            // 
            // cmdDodajOblast
            // 
            this.cmdDodajOblast.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmdDodajOblast.Location = new System.Drawing.Point(34, 133);
            this.cmdDodajOblast.Name = "cmdDodajOblast";
            this.cmdDodajOblast.Size = new System.Drawing.Size(142, 41);
            this.cmdDodajOblast.TabIndex = 15;
            this.cmdDodajOblast.Text = " Sacuvaj izmene";
            this.cmdDodajOblast.UseVisualStyleBackColor = false;
            this.cmdDodajOblast.Click += new System.EventHandler(this.cmdDodajOblast_Click);
            // 
            // txtPovrsina
            // 
            this.txtPovrsina.Location = new System.Drawing.Point(159, 81);
            this.txtPovrsina.Name = "txtPovrsina";
            this.txtPovrsina.Size = new System.Drawing.Size(182, 22);
            this.txtPovrsina.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Povrsina:";
            // 
            // txtImeOblasti
            // 
            this.txtImeOblasti.Location = new System.Drawing.Point(159, 40);
            this.txtImeOblasti.Name = "txtImeOblasti";
            this.txtImeOblasti.Size = new System.Drawing.Size(182, 22);
            this.txtImeOblasti.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ime oblasti:";
            // 
            // IzmeniOblastForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(370, 196);
            this.Controls.Add(this.cmdNazad);
            this.Controls.Add(this.cmdDodajOblast);
            this.Controls.Add(this.txtPovrsina);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtImeOblasti);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "IzmeniOblastForm";
            this.Text = "Izmeni oblast";
            this.Load += new System.EventHandler(this.IzmeniOblastForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdNazad;
        private System.Windows.Forms.Button cmdDodajOblast;
        private System.Windows.Forms.TextBox txtPovrsina;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtImeOblasti;
        private System.Windows.Forms.Label label1;
    }
}