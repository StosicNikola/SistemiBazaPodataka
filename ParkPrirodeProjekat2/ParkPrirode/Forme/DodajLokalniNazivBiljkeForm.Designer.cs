namespace ParkPrirode.Forme
{
    partial class DodajLokalniNazivBiljkeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DodajLokalniNazivBiljkeForm));
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxBiljka = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxLokalniNaziv = new System.Windows.Forms.TextBox();
            this.cmdDodaj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id biljke: ";
            // 
            // txtBoxBiljka
            // 
            this.txtBoxBiljka.Location = new System.Drawing.Point(150, 47);
            this.txtBoxBiljka.Name = "txtBoxBiljka";
            this.txtBoxBiljka.Size = new System.Drawing.Size(150, 22);
            this.txtBoxBiljka.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lokalni naziv: ";
            // 
            // txtBoxLokalniNaziv
            // 
            this.txtBoxLokalniNaziv.Location = new System.Drawing.Point(150, 90);
            this.txtBoxLokalniNaziv.Name = "txtBoxLokalniNaziv";
            this.txtBoxLokalniNaziv.Size = new System.Drawing.Size(150, 22);
            this.txtBoxLokalniNaziv.TabIndex = 3;
            // 
            // cmdDodaj
            // 
            this.cmdDodaj.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmdDodaj.Location = new System.Drawing.Point(116, 135);
            this.cmdDodaj.Name = "cmdDodaj";
            this.cmdDodaj.Size = new System.Drawing.Size(115, 36);
            this.cmdDodaj.TabIndex = 4;
            this.cmdDodaj.Text = "Dodaj ";
            this.cmdDodaj.UseVisualStyleBackColor = false;
            this.cmdDodaj.Click += new System.EventHandler(this.cmdDodaj_Click);
            // 
            // DodajLokalniNazivBiljkeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(343, 215);
            this.Controls.Add(this.cmdDodaj);
            this.Controls.Add(this.txtBoxLokalniNaziv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxBiljka);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DodajLokalniNazivBiljkeForm";
            this.Text = "Dodaj Lokalni Naziv Biljke";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxBiljka;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxLokalniNaziv;
        private System.Windows.Forms.Button cmdDodaj;
    }
}