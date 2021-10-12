namespace ParkPrirode.Forme
{
    partial class DodajZemljuForm1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DodajZemljuForm1));
            this.label1 = new System.Windows.Forms.Label();
            this.tbxImePtice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtZemlja = new System.Windows.Forms.TextBox();
            this.cmdDodajZemlju = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime ptice:";
            // 
            // tbxImePtice
            // 
            this.tbxImePtice.Location = new System.Drawing.Point(132, 45);
            this.tbxImePtice.Name = "tbxImePtice";
            this.tbxImePtice.Size = new System.Drawing.Size(150, 22);
            this.tbxImePtice.TabIndex = 1;
            this.tbxImePtice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Zemlja:";
            // 
            // txtZemlja
            // 
            this.txtZemlja.Location = new System.Drawing.Point(132, 90);
            this.txtZemlja.Name = "txtZemlja";
            this.txtZemlja.Size = new System.Drawing.Size(150, 22);
            this.txtZemlja.TabIndex = 3;
            // 
            // cmdDodajZemlju
            // 
            this.cmdDodajZemlju.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmdDodajZemlju.Location = new System.Drawing.Point(76, 148);
            this.cmdDodajZemlju.Name = "cmdDodajZemlju";
            this.cmdDodajZemlju.Size = new System.Drawing.Size(167, 37);
            this.cmdDodajZemlju.TabIndex = 4;
            this.cmdDodajZemlju.Text = "Dodaj zemlju";
            this.cmdDodajZemlju.UseVisualStyleBackColor = false;
            this.cmdDodajZemlju.Click += new System.EventHandler(this.cmdDodajZemlju_Click);
            // 
            // DodajZemljuForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(325, 214);
            this.Controls.Add(this.cmdDodajZemlju);
            this.Controls.Add(this.txtZemlja);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxImePtice);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DodajZemljuForm1";
            this.Text = "Dodaj zemlju ";
            this.Load += new System.EventHandler(this.DodajZemljuForm1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxImePtice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtZemlja;
        private System.Windows.Forms.Button cmdDodajZemlju;
    }
}