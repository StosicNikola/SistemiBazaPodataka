namespace ParkPrirode.Forme
{
    partial class HranilistaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HranilistaForm));
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtImeOblati = new System.Windows.Forms.TextBox();
            this.cmdUcirajZivotinje = new System.Windows.Forms.Button();
            this.cmdDodajHraniliste = new System.Windows.Forms.Button();
            this.cmdIzmeniHraniliste = new System.Windows.Forms.Button();
            this.cmdObrisiHraniliste = new System.Windows.Forms.Button();
            this.cmdNazad = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(29, 41);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(578, 240);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            this.columnHeader1.Width = 33;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Pocetak rada";
            this.columnHeader2.Width = 94;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Zavrsetak rada";
            this.columnHeader3.Width = 107;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Aktivno";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Broj zivotinja";
            this.columnHeader5.Width = 92;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Location = new System.Drawing.Point(31, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(638, 306);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista hranilista oblasti";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ime oblasti:";
            // 
            // txtImeOblati
            // 
            this.txtImeOblati.Location = new System.Drawing.Point(147, 30);
            this.txtImeOblati.Name = "txtImeOblati";
            this.txtImeOblati.Size = new System.Drawing.Size(185, 22);
            this.txtImeOblati.TabIndex = 3;
            this.txtImeOblati.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmdUcirajZivotinje
            // 
            this.cmdUcirajZivotinje.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmdUcirajZivotinje.Location = new System.Drawing.Point(720, 83);
            this.cmdUcirajZivotinje.Name = "cmdUcirajZivotinje";
            this.cmdUcirajZivotinje.Size = new System.Drawing.Size(180, 46);
            this.cmdUcirajZivotinje.TabIndex = 4;
            this.cmdUcirajZivotinje.Text = "Ucitaj primecene zivotinje";
            this.cmdUcirajZivotinje.UseVisualStyleBackColor = false;
            this.cmdUcirajZivotinje.Click += new System.EventHandler(this.cmdUcirajZivotinje_Click);
            // 
            // cmdDodajHraniliste
            // 
            this.cmdDodajHraniliste.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmdDodajHraniliste.Location = new System.Drawing.Point(720, 148);
            this.cmdDodajHraniliste.Name = "cmdDodajHraniliste";
            this.cmdDodajHraniliste.Size = new System.Drawing.Size(180, 46);
            this.cmdDodajHraniliste.TabIndex = 5;
            this.cmdDodajHraniliste.Text = "Dodaj hraniliste";
            this.cmdDodajHraniliste.UseVisualStyleBackColor = false;
            this.cmdDodajHraniliste.Click += new System.EventHandler(this.cmdDodajHraniliste_Click);
            // 
            // cmdIzmeniHraniliste
            // 
            this.cmdIzmeniHraniliste.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmdIzmeniHraniliste.Location = new System.Drawing.Point(720, 213);
            this.cmdIzmeniHraniliste.Name = "cmdIzmeniHraniliste";
            this.cmdIzmeniHraniliste.Size = new System.Drawing.Size(180, 46);
            this.cmdIzmeniHraniliste.TabIndex = 6;
            this.cmdIzmeniHraniliste.Text = "Izmeni hraniliste";
            this.cmdIzmeniHraniliste.UseVisualStyleBackColor = false;
            this.cmdIzmeniHraniliste.Click += new System.EventHandler(this.cmdIzmeniHraniliste_Click);
            // 
            // cmdObrisiHraniliste
            // 
            this.cmdObrisiHraniliste.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmdObrisiHraniliste.Location = new System.Drawing.Point(720, 277);
            this.cmdObrisiHraniliste.Name = "cmdObrisiHraniliste";
            this.cmdObrisiHraniliste.Size = new System.Drawing.Size(180, 46);
            this.cmdObrisiHraniliste.TabIndex = 7;
            this.cmdObrisiHraniliste.Text = "Obrisi hraniliste";
            this.cmdObrisiHraniliste.UseVisualStyleBackColor = false;
            this.cmdObrisiHraniliste.Click += new System.EventHandler(this.cmdObrisiHraniliste_Click);
            // 
            // cmdNazad
            // 
            this.cmdNazad.BackColor = System.Drawing.SystemColors.Info;
            this.cmdNazad.Location = new System.Drawing.Point(720, 343);
            this.cmdNazad.Name = "cmdNazad";
            this.cmdNazad.Size = new System.Drawing.Size(180, 46);
            this.cmdNazad.TabIndex = 8;
            this.cmdNazad.Text = "<- Nazad";
            this.cmdNazad.UseVisualStyleBackColor = false;
            this.cmdNazad.Click += new System.EventHandler(this.cmdNazad_Click);
            // 
            // HranilistaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(934, 430);
            this.Controls.Add(this.cmdNazad);
            this.Controls.Add(this.cmdObrisiHraniliste);
            this.Controls.Add(this.cmdIzmeniHraniliste);
            this.Controls.Add(this.cmdDodajHraniliste);
            this.Controls.Add(this.cmdUcirajZivotinje);
            this.Controls.Add(this.txtImeOblati);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HranilistaForm";
            this.Text = "Hranilista";
            this.Load += new System.EventHandler(this.HranilistaForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.TextBox txtImeOblati;
        private System.Windows.Forms.Button cmdUcirajZivotinje;
        private System.Windows.Forms.Button cmdDodajHraniliste;
        private System.Windows.Forms.Button cmdIzmeniHraniliste;
        private System.Windows.Forms.Button cmdObrisiHraniliste;
        private System.Windows.Forms.Button cmdNazad;
    }
}