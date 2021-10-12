namespace ParkPrirode
{
    partial class Form1
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
            this.cmdUcitajOblast = new System.Windows.Forms.Button();
            this.cmdUcitajBiljku = new System.Windows.Forms.Button();
            this.cmdVezaMto1 = new System.Windows.Forms.Button();
            this.cmdLoadZasticenaBiljka = new System.Windows.Forms.Button();
            this.cmdUcitajOblasti = new System.Windows.Forms.Button();
            this.cmdUcitajSela1 = new System.Windows.Forms.Button();
            this.cmdHasManyToManyOB = new System.Windows.Forms.Button();
            this.cmdUcitajZivotinju = new System.Windows.Forms.Button();
            this.cmdUcitajPticuSelicu = new System.Windows.Forms.Button();
            this.cmdZemljePticeSelice = new System.Windows.Forms.Button();
            this.cmdManyToManyOblastZivotinja = new System.Windows.Forms.Button();
            this.cmdUcitajRadnika = new System.Windows.Forms.Button();
            this.cmdRadniciVolonteriStalnoZaposljeni = new System.Windows.Forms.Button();
            this.cmdUcitajRadnikeOblasti1 = new System.Windows.Forms.Button();
            this.cmdUcitajHraniliste = new System.Windows.Forms.Button();
            this.cmdZivotinjaPrimecena = new System.Windows.Forms.Button();
            this.cmdPogledOblasti = new System.Windows.Forms.Button();
            this.cmdPogledajBiljke = new System.Windows.Forms.Button();
            this.cmdUcitajRadnike = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdUcitajOblast
            // 
            this.cmdUcitajOblast.Location = new System.Drawing.Point(28, 38);
            this.cmdUcitajOblast.Name = "cmdUcitajOblast";
            this.cmdUcitajOblast.Size = new System.Drawing.Size(215, 38);
            this.cmdUcitajOblast.TabIndex = 0;
            this.cmdUcitajOblast.Text = "Ucitavanje oblasti";
            this.cmdUcitajOblast.UseVisualStyleBackColor = true;
            this.cmdUcitajOblast.Click += new System.EventHandler(this.cmdUcitajOblast_Click);
            // 
            // cmdUcitajBiljku
            // 
            this.cmdUcitajBiljku.Location = new System.Drawing.Point(28, 82);
            this.cmdUcitajBiljku.Name = "cmdUcitajBiljku";
            this.cmdUcitajBiljku.Size = new System.Drawing.Size(215, 37);
            this.cmdUcitajBiljku.TabIndex = 1;
            this.cmdUcitajBiljku.Text = "Ucitaj biljku";
            this.cmdUcitajBiljku.UseVisualStyleBackColor = true;
            this.cmdUcitajBiljku.Click += new System.EventHandler(this.cmdUcitajBiljku_Click);
            // 
            // cmdVezaMto1
            // 
            this.cmdVezaMto1.Location = new System.Drawing.Point(28, 125);
            this.cmdVezaMto1.Name = "cmdVezaMto1";
            this.cmdVezaMto1.Size = new System.Drawing.Size(215, 40);
            this.cmdVezaMto1.TabIndex = 2;
            this.cmdVezaMto1.Text = "Veza many to one";
            this.cmdVezaMto1.UseVisualStyleBackColor = true;
            this.cmdVezaMto1.Click += new System.EventHandler(this.cmdVezaMto1_Click);
            // 
            // cmdLoadZasticenaBiljka
            // 
            this.cmdLoadZasticenaBiljka.Location = new System.Drawing.Point(28, 171);
            this.cmdLoadZasticenaBiljka.Name = "cmdLoadZasticenaBiljka";
            this.cmdLoadZasticenaBiljka.Size = new System.Drawing.Size(215, 37);
            this.cmdLoadZasticenaBiljka.TabIndex = 3;
            this.cmdLoadZasticenaBiljka.Text = "Zasticena biljka";
            this.cmdLoadZasticenaBiljka.UseVisualStyleBackColor = true;
            this.cmdLoadZasticenaBiljka.Click += new System.EventHandler(this.cmdLoadZasticenaBiljka_Click);
            // 
            // cmdUcitajOblasti
            // 
            this.cmdUcitajOblasti.Location = new System.Drawing.Point(28, 214);
            this.cmdUcitajOblasti.Name = "cmdUcitajOblasti";
            this.cmdUcitajOblasti.Size = new System.Drawing.Size(215, 28);
            this.cmdUcitajOblasti.TabIndex = 4;
            this.cmdUcitajOblasti.Text = "Ucitaj oblasti";
            this.cmdUcitajOblasti.UseVisualStyleBackColor = true;
            this.cmdUcitajOblasti.Click += new System.EventHandler(this.cmdUcitajOblasti_Click);
            // 
            // cmdUcitajSela1
            // 
            this.cmdUcitajSela1.Location = new System.Drawing.Point(28, 248);
            this.cmdUcitajSela1.Name = "cmdUcitajSela1";
            this.cmdUcitajSela1.Size = new System.Drawing.Size(215, 30);
            this.cmdUcitajSela1.TabIndex = 5;
            this.cmdUcitajSela1.Text = "Ucitaj sela oblasti 1";
            this.cmdUcitajSela1.UseVisualStyleBackColor = true;
            this.cmdUcitajSela1.Click += new System.EventHandler(this.cmdUcitajSela1_Click);
            // 
            // cmdHasManyToManyOB
            // 
            this.cmdHasManyToManyOB.Location = new System.Drawing.Point(28, 284);
            this.cmdHasManyToManyOB.Name = "cmdHasManyToManyOB";
            this.cmdHasManyToManyOB.Size = new System.Drawing.Size(215, 32);
            this.cmdHasManyToManyOB.TabIndex = 6;
            this.cmdHasManyToManyOB.Text = "HasManyToManyOblastBiljka";
            this.cmdHasManyToManyOB.UseVisualStyleBackColor = true;
            this.cmdHasManyToManyOB.Click += new System.EventHandler(this.cmdHasManyToManyOB_Click);
            // 
            // cmdUcitajZivotinju
            // 
            this.cmdUcitajZivotinju.Location = new System.Drawing.Point(28, 322);
            this.cmdUcitajZivotinju.Name = "cmdUcitajZivotinju";
            this.cmdUcitajZivotinju.Size = new System.Drawing.Size(215, 31);
            this.cmdUcitajZivotinju.TabIndex = 7;
            this.cmdUcitajZivotinju.Text = "Ucitaj zivotinju ";
            this.cmdUcitajZivotinju.UseVisualStyleBackColor = true;
            this.cmdUcitajZivotinju.Click += new System.EventHandler(this.cmdUcitajZivotinju_Click);
            // 
            // cmdUcitajPticuSelicu
            // 
            this.cmdUcitajPticuSelicu.Location = new System.Drawing.Point(267, 38);
            this.cmdUcitajPticuSelicu.Name = "cmdUcitajPticuSelicu";
            this.cmdUcitajPticuSelicu.Size = new System.Drawing.Size(173, 38);
            this.cmdUcitajPticuSelicu.TabIndex = 8;
            this.cmdUcitajPticuSelicu.Text = "UcitajPticeSelice";
            this.cmdUcitajPticuSelicu.UseVisualStyleBackColor = true;
            this.cmdUcitajPticuSelicu.Click += new System.EventHandler(this.cmdUcitajPticuSelicu_Click);
            // 
            // cmdZemljePticeSelice
            // 
            this.cmdZemljePticeSelice.Location = new System.Drawing.Point(267, 82);
            this.cmdZemljePticeSelice.Name = "cmdZemljePticeSelice";
            this.cmdZemljePticeSelice.Size = new System.Drawing.Size(173, 37);
            this.cmdZemljePticeSelice.TabIndex = 9;
            this.cmdZemljePticeSelice.Text = "Zemlje koje ptica preleti";
            this.cmdZemljePticeSelice.UseVisualStyleBackColor = true;
            this.cmdZemljePticeSelice.Click += new System.EventHandler(this.cmdZemljePticeSelice_Click);
            // 
            // cmdManyToManyOblastZivotinja
            // 
            this.cmdManyToManyOblastZivotinja.Location = new System.Drawing.Point(267, 125);
            this.cmdManyToManyOblastZivotinja.Name = "cmdManyToManyOblastZivotinja";
            this.cmdManyToManyOblastZivotinja.Size = new System.Drawing.Size(173, 40);
            this.cmdManyToManyOblastZivotinja.TabIndex = 10;
            this.cmdManyToManyOblastZivotinja.Text = "ManyToManyOblastZivotinja";
            this.cmdManyToManyOblastZivotinja.UseVisualStyleBackColor = true;
            this.cmdManyToManyOblastZivotinja.Click += new System.EventHandler(this.cmdManyToManyOblastZivotinja_Click);
            // 
            // cmdUcitajRadnika
            // 
            this.cmdUcitajRadnika.Location = new System.Drawing.Point(267, 171);
            this.cmdUcitajRadnika.Name = "cmdUcitajRadnika";
            this.cmdUcitajRadnika.Size = new System.Drawing.Size(173, 37);
            this.cmdUcitajRadnika.TabIndex = 11;
            this.cmdUcitajRadnika.Text = "Ucitaj Radnika";
            this.cmdUcitajRadnika.UseVisualStyleBackColor = true;
            this.cmdUcitajRadnika.Click += new System.EventHandler(this.cmdUcitajRadnika_Click);
            // 
            // cmdRadniciVolonteriStalnoZaposljeni
            // 
            this.cmdRadniciVolonteriStalnoZaposljeni.Location = new System.Drawing.Point(267, 214);
            this.cmdRadniciVolonteriStalnoZaposljeni.Name = "cmdRadniciVolonteriStalnoZaposljeni";
            this.cmdRadniciVolonteriStalnoZaposljeni.Size = new System.Drawing.Size(173, 28);
            this.cmdRadniciVolonteriStalnoZaposljeni.TabIndex = 12;
            this.cmdRadniciVolonteriStalnoZaposljeni.Text = "Ucitaj radnike V SZ";
            this.cmdRadniciVolonteriStalnoZaposljeni.UseVisualStyleBackColor = true;
            this.cmdRadniciVolonteriStalnoZaposljeni.Click += new System.EventHandler(this.cmdRadniciVolonteriStalnoZaposljeni_Click);
            // 
            // cmdUcitajRadnikeOblasti1
            // 
            this.cmdUcitajRadnikeOblasti1.Location = new System.Drawing.Point(267, 248);
            this.cmdUcitajRadnikeOblasti1.Name = "cmdUcitajRadnikeOblasti1";
            this.cmdUcitajRadnikeOblasti1.Size = new System.Drawing.Size(173, 30);
            this.cmdUcitajRadnikeOblasti1.TabIndex = 13;
            this.cmdUcitajRadnikeOblasti1.Text = "UcitajRadnikeOblasti1";
            this.cmdUcitajRadnikeOblasti1.UseVisualStyleBackColor = true;
            this.cmdUcitajRadnikeOblasti1.Click += new System.EventHandler(this.cmdUcitajRadnikeOblasti1_Click);
            // 
            // cmdUcitajHraniliste
            // 
            this.cmdUcitajHraniliste.Location = new System.Drawing.Point(267, 284);
            this.cmdUcitajHraniliste.Name = "cmdUcitajHraniliste";
            this.cmdUcitajHraniliste.Size = new System.Drawing.Size(173, 32);
            this.cmdUcitajHraniliste.TabIndex = 14;
            this.cmdUcitajHraniliste.Text = "UcitajHraniliste";
            this.cmdUcitajHraniliste.UseVisualStyleBackColor = true;
            this.cmdUcitajHraniliste.Click += new System.EventHandler(this.cmdUcitajHraniliste_Click);
            // 
            // cmdZivotinjaPrimecena
            // 
            this.cmdZivotinjaPrimecena.Location = new System.Drawing.Point(267, 322);
            this.cmdZivotinjaPrimecena.Name = "cmdZivotinjaPrimecena";
            this.cmdZivotinjaPrimecena.Size = new System.Drawing.Size(218, 34);
            this.cmdZivotinjaPrimecena.TabIndex = 15;
            this.cmdZivotinjaPrimecena.Text = "UcitajZivotinjuGdeJePrimecena";
            this.cmdZivotinjaPrimecena.UseVisualStyleBackColor = true;
            this.cmdZivotinjaPrimecena.Click += new System.EventHandler(this.cmdZivotinjaPrimecena_Click);
            // 
            // cmdPogledOblasti
            // 
            this.cmdPogledOblasti.Location = new System.Drawing.Point(309, 384);
            this.cmdPogledOblasti.Name = "cmdPogledOblasti";
            this.cmdPogledOblasti.Size = new System.Drawing.Size(117, 30);
            this.cmdPogledOblasti.TabIndex = 16;
            this.cmdPogledOblasti.Text = "Pogled oblasti";
            this.cmdPogledOblasti.UseVisualStyleBackColor = true;
            this.cmdPogledOblasti.Click += new System.EventHandler(this.cmdPogledOblasti_Click);
            // 
            // cmdPogledajBiljke
            // 
            this.cmdPogledajBiljke.Location = new System.Drawing.Point(28, 384);
            this.cmdPogledajBiljke.Name = "cmdPogledajBiljke";
            this.cmdPogledajBiljke.Size = new System.Drawing.Size(198, 30);
            this.cmdPogledajBiljke.TabIndex = 17;
            this.cmdPogledajBiljke.Text = "PogledajBiljke";
            this.cmdPogledajBiljke.UseVisualStyleBackColor = true;
            this.cmdPogledajBiljke.Click += new System.EventHandler(this.cmdPogledajBiljke_Click);
            // 
            // cmdUcitajRadnike
            // 
            this.cmdUcitajRadnike.Location = new System.Drawing.Point(28, 442);
            this.cmdUcitajRadnike.Name = "cmdUcitajRadnike";
            this.cmdUcitajRadnike.Size = new System.Drawing.Size(198, 35);
            this.cmdUcitajRadnike.TabIndex = 18;
            this.cmdUcitajRadnike.Text = "Ucitaj radnike";
            this.cmdUcitajRadnike.UseVisualStyleBackColor = true;
            this.cmdUcitajRadnike.Click += new System.EventHandler(this.cmdUcitajRadnike_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 547);
            this.Controls.Add(this.cmdUcitajRadnike);
            this.Controls.Add(this.cmdPogledajBiljke);
            this.Controls.Add(this.cmdPogledOblasti);
            this.Controls.Add(this.cmdZivotinjaPrimecena);
            this.Controls.Add(this.cmdUcitajHraniliste);
            this.Controls.Add(this.cmdUcitajRadnikeOblasti1);
            this.Controls.Add(this.cmdRadniciVolonteriStalnoZaposljeni);
            this.Controls.Add(this.cmdUcitajRadnika);
            this.Controls.Add(this.cmdManyToManyOblastZivotinja);
            this.Controls.Add(this.cmdZemljePticeSelice);
            this.Controls.Add(this.cmdUcitajPticuSelicu);
            this.Controls.Add(this.cmdUcitajZivotinju);
            this.Controls.Add(this.cmdHasManyToManyOB);
            this.Controls.Add(this.cmdUcitajSela1);
            this.Controls.Add(this.cmdUcitajOblasti);
            this.Controls.Add(this.cmdLoadZasticenaBiljka);
            this.Controls.Add(this.cmdVezaMto1);
            this.Controls.Add(this.cmdUcitajBiljku);
            this.Controls.Add(this.cmdUcitajOblast);
            this.Name = "Form1";
            this.Text = "ParkPrirode";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdUcitajOblast;
        private System.Windows.Forms.Button cmdUcitajBiljku;
        private System.Windows.Forms.Button cmdVezaMto1;
        private System.Windows.Forms.Button cmdLoadZasticenaBiljka;
        private System.Windows.Forms.Button cmdUcitajOblasti;
        private System.Windows.Forms.Button cmdUcitajSela1;
        private System.Windows.Forms.Button cmdHasManyToManyOB;
        private System.Windows.Forms.Button cmdUcitajZivotinju;
        private System.Windows.Forms.Button cmdUcitajPticuSelicu;
        private System.Windows.Forms.Button cmdZemljePticeSelice;
        private System.Windows.Forms.Button cmdManyToManyOblastZivotinja;
        private System.Windows.Forms.Button cmdUcitajRadnika;
        private System.Windows.Forms.Button cmdRadniciVolonteriStalnoZaposljeni;
        private System.Windows.Forms.Button cmdUcitajRadnikeOblasti1;
        private System.Windows.Forms.Button cmdUcitajHraniliste;
        private System.Windows.Forms.Button cmdZivotinjaPrimecena;
        private System.Windows.Forms.Button cmdPogledOblasti;
        private System.Windows.Forms.Button cmdPogledajBiljke;
        private System.Windows.Forms.Button cmdUcitajRadnike;
    }
}

