namespace ParkPrirode.Forme
{
    partial class DodajOblastForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtImeOblasti = new System.Windows.Forms.TextBox();
            this.txtPovrsina = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmdDodajOblast = new System.Windows.Forms.Button();
            this.cmdNazad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime oblasti:";
            // 
            // txtImeOblasti
            // 
            this.txtImeOblasti.Location = new System.Drawing.Point(166, 36);
            this.txtImeOblasti.Name = "txtImeOblasti";
            this.txtImeOblasti.Size = new System.Drawing.Size(182, 22);
            this.txtImeOblasti.TabIndex = 1;
            // 
            // txtPovrsina
            // 
            this.txtPovrsina.Location = new System.Drawing.Point(166, 77);
            this.txtPovrsina.Name = "txtPovrsina";
            this.txtPovrsina.Size = new System.Drawing.Size(182, 22);
            this.txtPovrsina.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Povrsina:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(166, 120);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(182, 24);
            this.comboBox1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tip zastite:";
            // 
            // cmdDodajOblast
            // 
            this.cmdDodajOblast.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmdDodajOblast.Location = new System.Drawing.Point(41, 175);
            this.cmdDodajOblast.Name = "cmdDodajOblast";
            this.cmdDodajOblast.Size = new System.Drawing.Size(142, 41);
            this.cmdDodajOblast.TabIndex = 7;
            this.cmdDodajOblast.Text = "Dodaj oblast";
            this.cmdDodajOblast.UseVisualStyleBackColor = false;
            this.cmdDodajOblast.Click += new System.EventHandler(this.cmdDodajOblast_Click);
            // 
            // cmdNazad
            // 
            this.cmdNazad.BackColor = System.Drawing.SystemColors.Info;
            this.cmdNazad.Location = new System.Drawing.Point(206, 175);
            this.cmdNazad.Name = "cmdNazad";
            this.cmdNazad.Size = new System.Drawing.Size(142, 41);
            this.cmdNazad.TabIndex = 8;
            this.cmdNazad.Text = "<- Nazad";
            this.cmdNazad.UseVisualStyleBackColor = false;
            this.cmdNazad.Click += new System.EventHandler(this.cmdNazad_Click);
            // 
            // DodajOblastForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(392, 240);
            this.Controls.Add(this.cmdNazad);
            this.Controls.Add(this.cmdDodajOblast);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtPovrsina);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtImeOblasti);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "DodajOblastForm";
            this.Text = "Dodaj oblast";
            this.Load += new System.EventHandler(this.DodajOblastForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtImeOblasti;
        private System.Windows.Forms.TextBox txtPovrsina;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cmdDodajOblast;
        private System.Windows.Forms.Button cmdNazad;
    }
}