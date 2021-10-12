namespace ParkPrirode.Forme
{
    partial class RadnikForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RadnikForm));
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cmdUcitajDodatnoOSR = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmdDodajRadnika = new System.Windows.Forms.Button();
            this.cmdObrisiRadnika = new System.Windows.Forms.Button();
            this.cmdIzmeniRadnika = new System.Windows.Forms.Button();
            this.cmdNazad = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
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
            this.columnHeader8});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(39, 87);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1003, 308);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id radnika";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ime";
            this.columnHeader2.Width = 89;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Prezime";
            this.columnHeader3.Width = 82;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Adresa";
            this.columnHeader4.Width = 102;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Maticni broj";
            this.columnHeader5.Width = 118;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Tip posla";
            this.columnHeader6.Width = 90;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Oblast ";
            this.columnHeader7.Width = 103;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Povrsina ";
            this.columnHeader8.Width = 118;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Location = new System.Drawing.Point(28, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1087, 432);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Radnici parka";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Filtriraj radnike:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(147, 40);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(225, 24);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cmdUcitajDodatnoOSR
            // 
            this.cmdUcitajDodatnoOSR.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmdUcitajDodatnoOSR.Location = new System.Drawing.Point(50, 53);
            this.cmdUcitajDodatnoOSR.Name = "cmdUcitajDodatnoOSR";
            this.cmdUcitajDodatnoOSR.Size = new System.Drawing.Size(180, 43);
            this.cmdUcitajDodatnoOSR.TabIndex = 2;
            this.cmdUcitajDodatnoOSR.Text = "Ucitaj";
            this.cmdUcitajDodatnoOSR.UseVisualStyleBackColor = false;
            this.cmdUcitajDodatnoOSR.Click += new System.EventHandler(this.cmdUcitajDodatnoOSR_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmdUcitajDodatnoOSR);
            this.groupBox2.Location = new System.Drawing.Point(1151, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(273, 116);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dodatni podaci o stalno zaposljenom radniku";
            // 
            // cmdDodajRadnika
            // 
            this.cmdDodajRadnika.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmdDodajRadnika.Location = new System.Drawing.Point(1176, 199);
            this.cmdDodajRadnika.Name = "cmdDodajRadnika";
            this.cmdDodajRadnika.Size = new System.Drawing.Size(225, 46);
            this.cmdDodajRadnika.TabIndex = 4;
            this.cmdDodajRadnika.Text = "Dodaj radnika";
            this.cmdDodajRadnika.UseVisualStyleBackColor = false;
            this.cmdDodajRadnika.Click += new System.EventHandler(this.cmdDodajRadnika_Click);
            // 
            // cmdObrisiRadnika
            // 
            this.cmdObrisiRadnika.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmdObrisiRadnika.Location = new System.Drawing.Point(1176, 272);
            this.cmdObrisiRadnika.Name = "cmdObrisiRadnika";
            this.cmdObrisiRadnika.Size = new System.Drawing.Size(225, 46);
            this.cmdObrisiRadnika.TabIndex = 5;
            this.cmdObrisiRadnika.Text = "Obrisi radnika";
            this.cmdObrisiRadnika.UseVisualStyleBackColor = false;
            this.cmdObrisiRadnika.Click += new System.EventHandler(this.cmdObrisiRadnika_Click);
            // 
            // cmdIzmeniRadnika
            // 
            this.cmdIzmeniRadnika.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmdIzmeniRadnika.Location = new System.Drawing.Point(1176, 346);
            this.cmdIzmeniRadnika.Name = "cmdIzmeniRadnika";
            this.cmdIzmeniRadnika.Size = new System.Drawing.Size(225, 46);
            this.cmdIzmeniRadnika.TabIndex = 6;
            this.cmdIzmeniRadnika.Text = "Izmeni radnika";
            this.cmdIzmeniRadnika.UseVisualStyleBackColor = false;
            this.cmdIzmeniRadnika.Click += new System.EventHandler(this.cmdIzmeniRadnika_Click);
            // 
            // cmdNazad
            // 
            this.cmdNazad.BackColor = System.Drawing.SystemColors.Info;
            this.cmdNazad.Location = new System.Drawing.Point(1176, 418);
            this.cmdNazad.Name = "cmdNazad";
            this.cmdNazad.Size = new System.Drawing.Size(225, 46);
            this.cmdNazad.TabIndex = 7;
            this.cmdNazad.Text = "<- Nazad";
            this.cmdNazad.UseVisualStyleBackColor = false;
            this.cmdNazad.Click += new System.EventHandler(this.cmdNazad_Click);
            // 
            // RadnikForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1457, 498);
            this.Controls.Add(this.cmdNazad);
            this.Controls.Add(this.cmdIzmeniRadnika);
            this.Controls.Add(this.cmdObrisiRadnika);
            this.Controls.Add(this.cmdDodajRadnika);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RadnikForm";
            this.Text = "Zaposljeni u parku prirode";
            this.Load += new System.EventHandler(this.RadnikForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button cmdUcitajDodatnoOSR;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdDodajRadnika;
        private System.Windows.Forms.Button cmdObrisiRadnika;
        private System.Windows.Forms.Button cmdIzmeniRadnika;
        private System.Windows.Forms.Button cmdNazad;
    }
}