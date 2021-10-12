namespace ParkPrirode.Forme
{
    partial class DodajZivotinjuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DodajZivotinjuForm));
            this.cmdDodajZivotinju = new System.Windows.Forms.Button();
            this.cmdNazad = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.numSerijskiBroj = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLatinskiNaziv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLokalniNaziv = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmdObrisiZemlju = new System.Windows.Forms.Button();
            this.cmdDodajZemlju = new System.Windows.Forms.Button();
            this.txtZemlja = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ckbPticaSelica = new System.Windows.Forms.CheckBox();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSerijskiBroj)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdDodajZivotinju
            // 
            this.cmdDodajZivotinju.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmdDodajZivotinju.Location = new System.Drawing.Point(443, 473);
            this.cmdDodajZivotinju.Name = "cmdDodajZivotinju";
            this.cmdDodajZivotinju.Size = new System.Drawing.Size(152, 41);
            this.cmdDodajZivotinju.TabIndex = 28;
            this.cmdDodajZivotinju.Text = "Dodaj zivotinju";
            this.cmdDodajZivotinju.UseVisualStyleBackColor = false;
            this.cmdDodajZivotinju.Click += new System.EventHandler(this.cmdDodajZivotinju_Click);
            // 
            // cmdNazad
            // 
            this.cmdNazad.BackColor = System.Drawing.SystemColors.Info;
            this.cmdNazad.Location = new System.Drawing.Point(253, 473);
            this.cmdNazad.Name = "cmdNazad";
            this.cmdNazad.Size = new System.Drawing.Size(152, 41);
            this.cmdNazad.TabIndex = 27;
            this.cmdNazad.Text = "<- Nazad";
            this.cmdNazad.UseVisualStyleBackColor = false;
            this.cmdNazad.Click += new System.EventHandler(this.cmdNazad_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(472, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(253, 17);
            this.label8.TabIndex = 26;
            this.label8.Text = "U koju oblast zelis da zivotinja pripada:";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(475, 55);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(338, 155);
            this.listView1.TabIndex = 25;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id oblasti";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ime";
            this.columnHeader2.Width = 105;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tip zastite";
            this.columnHeader3.Width = 142;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.numSerijskiBroj);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtLatinskiNaziv);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtLokalniNaziv);
            this.groupBox3.Location = new System.Drawing.Point(28, 35);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(408, 175);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Osnovne informacije o zivotinji";
            // 
            // numSerijskiBroj
            // 
            this.numSerijskiBroj.Location = new System.Drawing.Point(197, 41);
            this.numSerijskiBroj.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numSerijskiBroj.Minimum = new decimal(new int[] {
            1030,
            0,
            0,
            0});
            this.numSerijskiBroj.Name = "numSerijskiBroj";
            this.numSerijskiBroj.Size = new System.Drawing.Size(137, 22);
            this.numSerijskiBroj.TabIndex = 8;
            this.numSerijskiBroj.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numSerijskiBroj.Value = new decimal(new int[] {
            1030,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Serijski broj prstena:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Latinski naziv:";
            // 
            // txtLatinskiNaziv
            // 
            this.txtLatinskiNaziv.Location = new System.Drawing.Point(197, 80);
            this.txtLatinskiNaziv.Name = "txtLatinskiNaziv";
            this.txtLatinskiNaziv.Size = new System.Drawing.Size(137, 22);
            this.txtLatinskiNaziv.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Lokalni naziv:";
            // 
            // txtLokalniNaziv
            // 
            this.txtLokalniNaziv.Location = new System.Drawing.Point(197, 125);
            this.txtLokalniNaziv.Name = "txtLokalniNaziv";
            this.txtLokalniNaziv.Size = new System.Drawing.Size(137, 22);
            this.txtLokalniNaziv.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmdObrisiZemlju);
            this.groupBox2.Controls.Add(this.cmdDodajZemlju);
            this.groupBox2.Controls.Add(this.txtZemlja);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(28, 280);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(408, 147);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dodatni podaci o ptici selici";
            // 
            // cmdObrisiZemlju
            // 
            this.cmdObrisiZemlju.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmdObrisiZemlju.Location = new System.Drawing.Point(217, 93);
            this.cmdObrisiZemlju.Name = "cmdObrisiZemlju";
            this.cmdObrisiZemlju.Size = new System.Drawing.Size(145, 37);
            this.cmdObrisiZemlju.TabIndex = 12;
            this.cmdObrisiZemlju.Text = "Obrisi zemlju";
            this.cmdObrisiZemlju.UseVisualStyleBackColor = false;
            this.cmdObrisiZemlju.Click += new System.EventHandler(this.cmdObrisiZemlju_Click);
            // 
            // cmdDodajZemlju
            // 
            this.cmdDodajZemlju.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmdDodajZemlju.Location = new System.Drawing.Point(49, 93);
            this.cmdDodajZemlju.Name = "cmdDodajZemlju";
            this.cmdDodajZemlju.Size = new System.Drawing.Size(145, 37);
            this.cmdDodajZemlju.TabIndex = 11;
            this.cmdDodajZemlju.Text = "Dodaj zemlju";
            this.cmdDodajZemlju.UseVisualStyleBackColor = false;
            this.cmdDodajZemlju.Click += new System.EventHandler(this.cmdDodajZemlju_Click);
            // 
            // txtZemlja
            // 
            this.txtZemlja.Location = new System.Drawing.Point(225, 42);
            this.txtZemlja.Name = "txtZemlja";
            this.txtZemlja.Size = new System.Drawing.Size(137, 22);
            this.txtZemlja.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "Zemlja kroz koju prolazi:";
            // 
            // ckbPticaSelica
            // 
            this.ckbPticaSelica.AutoSize = true;
            this.ckbPticaSelica.Location = new System.Drawing.Point(28, 233);
            this.ckbPticaSelica.Name = "ckbPticaSelica";
            this.ckbPticaSelica.Size = new System.Drawing.Size(101, 21);
            this.ckbPticaSelica.TabIndex = 22;
            this.ckbPticaSelica.Text = "Ptica selica";
            this.ckbPticaSelica.UseVisualStyleBackColor = true;
            this.ckbPticaSelica.CheckedChanged += new System.EventHandler(this.ckbPticaSelica_CheckedChanged);
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4});
            this.listView2.FullRowSelect = true;
            this.listView2.GridLines = true;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(475, 300);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(338, 127);
            this.listView2.TabIndex = 29;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Zemlja";
            this.columnHeader4.Width = 207;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(472, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 17);
            this.label4.TabIndex = 30;
            this.label4.Text = "Lista zemlji kroz koje prolazi";
            // 
            // DodajZivotinjuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(848, 546);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.cmdDodajZivotinju);
            this.Controls.Add(this.cmdNazad);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.ckbPticaSelica);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DodajZivotinjuForm";
            this.Text = "Dodaj zivotinju";
            this.Load += new System.EventHandler(this.DodajZivotinjuForm_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSerijskiBroj)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdDodajZivotinju;
        private System.Windows.Forms.Button cmdNazad;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLatinskiNaziv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLokalniNaziv;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtZemlja;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox ckbPticaSelica;
        private System.Windows.Forms.NumericUpDown numSerijskiBroj;
        private System.Windows.Forms.Button cmdDodajZemlju;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cmdObrisiZemlju;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}