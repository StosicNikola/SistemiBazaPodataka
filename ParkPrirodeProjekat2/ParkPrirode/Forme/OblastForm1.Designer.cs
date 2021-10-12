namespace ParkPrirode.Forme
{
    partial class OblastForm1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OblastForm1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmdUcitajSelaOblasti = new System.Windows.Forms.Button();
            this.cmdIzmeniOblast = new System.Windows.Forms.Button();
            this.cmdObrisiOblat = new System.Windows.Forms.Button();
            this.cmdDodajOblast = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmdUcitajHranilista = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cmdUcitajZaposljene = new System.Windows.Forms.Button();
            this.cmdNazad = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Location = new System.Drawing.Point(26, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1047, 682);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista oblasti";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(154, 42);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(225, 24);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Filtriraj oblasti:";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(19, 84);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1002, 550);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 35;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ime oblasti";
            this.columnHeader2.Width = 110;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Povrsina (m2)";
            this.columnHeader3.Width = 89;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Broj sela";
            this.columnHeader4.Width = 62;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Broj zivotinja";
            this.columnHeader5.Width = 83;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Broj biljaka";
            this.columnHeader6.Width = 72;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Broj radnika";
            this.columnHeader7.Width = 87;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Broj hranilista";
            this.columnHeader8.Width = 86;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Tip zastite";
            this.columnHeader9.Width = 130;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmdUcitajSelaOblasti);
            this.groupBox2.Controls.Add(this.cmdIzmeniOblast);
            this.groupBox2.Controls.Add(this.cmdObrisiOblat);
            this.groupBox2.Controls.Add(this.cmdDodajOblast);
            this.groupBox2.Location = new System.Drawing.Point(1105, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(258, 333);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Podaci o oblastima";
            // 
            // cmdUcitajSelaOblasti
            // 
            this.cmdUcitajSelaOblasti.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmdUcitajSelaOblasti.Location = new System.Drawing.Point(25, 42);
            this.cmdUcitajSelaOblasti.Name = "cmdUcitajSelaOblasti";
            this.cmdUcitajSelaOblasti.Size = new System.Drawing.Size(209, 51);
            this.cmdUcitajSelaOblasti.TabIndex = 3;
            this.cmdUcitajSelaOblasti.Text = "Ucitaj sela oblasti";
            this.cmdUcitajSelaOblasti.UseVisualStyleBackColor = false;
            this.cmdUcitajSelaOblasti.Click += new System.EventHandler(this.cmdUcitajSelaOblasti_Click);
            // 
            // cmdIzmeniOblast
            // 
            this.cmdIzmeniOblast.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmdIzmeniOblast.Location = new System.Drawing.Point(25, 247);
            this.cmdIzmeniOblast.Name = "cmdIzmeniOblast";
            this.cmdIzmeniOblast.Size = new System.Drawing.Size(209, 51);
            this.cmdIzmeniOblast.TabIndex = 2;
            this.cmdIzmeniOblast.Text = "Izmeni oblast";
            this.cmdIzmeniOblast.UseVisualStyleBackColor = false;
            this.cmdIzmeniOblast.Click += new System.EventHandler(this.cmdIzmeniOblast_Click);
            // 
            // cmdObrisiOblat
            // 
            this.cmdObrisiOblat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmdObrisiOblat.Location = new System.Drawing.Point(25, 179);
            this.cmdObrisiOblat.Name = "cmdObrisiOblat";
            this.cmdObrisiOblat.Size = new System.Drawing.Size(209, 51);
            this.cmdObrisiOblat.TabIndex = 1;
            this.cmdObrisiOblat.Text = "Obrisi oblast";
            this.cmdObrisiOblat.UseVisualStyleBackColor = false;
            this.cmdObrisiOblat.Click += new System.EventHandler(this.cmdObrisiOblat_Click);
            // 
            // cmdDodajOblast
            // 
            this.cmdDodajOblast.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmdDodajOblast.Location = new System.Drawing.Point(25, 112);
            this.cmdDodajOblast.Name = "cmdDodajOblast";
            this.cmdDodajOblast.Size = new System.Drawing.Size(209, 51);
            this.cmdDodajOblast.TabIndex = 0;
            this.cmdDodajOblast.Text = "Dodaj oblast";
            this.cmdDodajOblast.UseVisualStyleBackColor = false;
            this.cmdDodajOblast.Click += new System.EventHandler(this.cmdDodajOblast_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmdUcitajHranilista);
            this.groupBox3.Location = new System.Drawing.Point(1105, 380);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(258, 115);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Hranilista";
            // 
            // cmdUcitajHranilista
            // 
            this.cmdUcitajHranilista.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmdUcitajHranilista.Location = new System.Drawing.Point(25, 36);
            this.cmdUcitajHranilista.Name = "cmdUcitajHranilista";
            this.cmdUcitajHranilista.Size = new System.Drawing.Size(209, 51);
            this.cmdUcitajHranilista.TabIndex = 3;
            this.cmdUcitajHranilista.Text = "Ucitaj hranilista";
            this.cmdUcitajHranilista.UseVisualStyleBackColor = false;
            this.cmdUcitajHranilista.Click += new System.EventHandler(this.cmdUcitajHranilista_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cmdUcitajZaposljene);
            this.groupBox4.Location = new System.Drawing.Point(1105, 516);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(258, 115);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Zaposleni";
            // 
            // cmdUcitajZaposljene
            // 
            this.cmdUcitajZaposljene.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmdUcitajZaposljene.Location = new System.Drawing.Point(25, 35);
            this.cmdUcitajZaposljene.Name = "cmdUcitajZaposljene";
            this.cmdUcitajZaposljene.Size = new System.Drawing.Size(209, 51);
            this.cmdUcitajZaposljene.TabIndex = 3;
            this.cmdUcitajZaposljene.Text = "Zaposleni";
            this.cmdUcitajZaposljene.UseVisualStyleBackColor = false;
            this.cmdUcitajZaposljene.Click += new System.EventHandler(this.cmdUcitajZaposljene_Click);
            // 
            // cmdNazad
            // 
            this.cmdNazad.BackColor = System.Drawing.SystemColors.Info;
            this.cmdNazad.Location = new System.Drawing.Point(1130, 656);
            this.cmdNazad.Name = "cmdNazad";
            this.cmdNazad.Size = new System.Drawing.Size(209, 51);
            this.cmdNazad.TabIndex = 4;
            this.cmdNazad.Text = "<- Nazad";
            this.cmdNazad.UseVisualStyleBackColor = false;
            this.cmdNazad.Click += new System.EventHandler(this.cmdNazad_Click);
            // 
            // OblastForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1429, 743);
            this.Controls.Add(this.cmdNazad);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OblastForm1";
            this.Text = "LISTA OBLASTI";
            this.Load += new System.EventHandler(this.OblastForm1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button cmdDodajOblast;
        private System.Windows.Forms.Button cmdObrisiOblat;
        private System.Windows.Forms.Button cmdIzmeniOblast;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdUcitajHranilista;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button cmdUcitajZaposljene;
        private System.Windows.Forms.Button cmdNazad;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.Button cmdUcitajSelaOblasti;
    }
}