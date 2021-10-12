namespace ParkPrirode.Forme
{
    partial class IzmeniZivotinjuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IzmeniZivotinjuForm));
            this.cmdDodajOblast = new System.Windows.Forms.Button();
            this.cmdNazad = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.numSerijskiBroj = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLatinskiNaziv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLokalniNaziv = new System.Windows.Forms.TextBox();
            this.ckbPticaSelica = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmdIzmeniZivotinju = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmdObrisiOblast = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSerijskiBroj)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdDodajOblast
            // 
            this.cmdDodajOblast.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmdDodajOblast.Location = new System.Drawing.Point(19, 31);
            this.cmdDodajOblast.Name = "cmdDodajOblast";
            this.cmdDodajOblast.Size = new System.Drawing.Size(152, 41);
            this.cmdDodajOblast.TabIndex = 37;
            this.cmdDodajOblast.Text = "Dodoj novu oblast";
            this.cmdDodajOblast.UseVisualStyleBackColor = false;
            this.cmdDodajOblast.Click += new System.EventHandler(this.cmdDodajOblast_Click);
            // 
            // cmdNazad
            // 
            this.cmdNazad.BackColor = System.Drawing.SystemColors.Info;
            this.cmdNazad.Location = new System.Drawing.Point(874, 283);
            this.cmdNazad.Name = "cmdNazad";
            this.cmdNazad.Size = new System.Drawing.Size(152, 41);
            this.cmdNazad.TabIndex = 36;
            this.cmdNazad.Text = "<- Nazad";
            this.cmdNazad.UseVisualStyleBackColor = false;
            this.cmdNazad.Click += new System.EventHandler(this.cmdNazad_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(474, 58);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(272, 199);
            this.listView1.TabIndex = 34;
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.numSerijskiBroj);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtId);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtLatinskiNaziv);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtLokalniNaziv);
            this.groupBox3.Controls.Add(this.ckbPticaSelica);
            this.groupBox3.Location = new System.Drawing.Point(30, 37);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(408, 229);
            this.groupBox3.TabIndex = 33;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Osnovne informacije o zivotinji";
            // 
            // numSerijskiBroj
            // 
            this.numSerijskiBroj.Location = new System.Drawing.Point(197, 68);
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
            this.label1.Location = new System.Drawing.Point(33, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Serijski broj prstena:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "Id:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(197, 31);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(137, 22);
            this.txtId.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Latinski naziv:";
            // 
            // txtLatinskiNaziv
            // 
            this.txtLatinskiNaziv.Location = new System.Drawing.Point(197, 110);
            this.txtLatinskiNaziv.Name = "txtLatinskiNaziv";
            this.txtLatinskiNaziv.Size = new System.Drawing.Size(137, 22);
            this.txtLatinskiNaziv.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Lokalni naziv:";
            // 
            // txtLokalniNaziv
            // 
            this.txtLokalniNaziv.Location = new System.Drawing.Point(197, 155);
            this.txtLokalniNaziv.Name = "txtLokalniNaziv";
            this.txtLokalniNaziv.Size = new System.Drawing.Size(137, 22);
            this.txtLokalniNaziv.TabIndex = 5;
            // 
            // ckbPticaSelica
            // 
            this.ckbPticaSelica.AutoSize = true;
            this.ckbPticaSelica.Location = new System.Drawing.Point(123, 199);
            this.ckbPticaSelica.Name = "ckbPticaSelica";
            this.ckbPticaSelica.Size = new System.Drawing.Size(101, 21);
            this.ckbPticaSelica.TabIndex = 31;
            this.ckbPticaSelica.Text = "Ptica selica";
            this.ckbPticaSelica.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(809, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 17);
            this.label8.TabIndex = 39;
            this.label8.Text = "Ostale oblasti:";
            // 
            // cmdIzmeniZivotinju
            // 
            this.cmdIzmeniZivotinju.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmdIzmeniZivotinju.Location = new System.Drawing.Point(539, 283);
            this.cmdIzmeniZivotinju.Name = "cmdIzmeniZivotinju";
            this.cmdIzmeniZivotinju.Size = new System.Drawing.Size(152, 41);
            this.cmdIzmeniZivotinju.TabIndex = 40;
            this.cmdIzmeniZivotinju.Text = "Sacuvaj izmene";
            this.cmdIzmeniZivotinju.UseVisualStyleBackColor = false;
            this.cmdIzmeniZivotinju.Click += new System.EventHandler(this.cmdIzmeniZivotinju_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(471, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 17);
            this.label4.TabIndex = 41;
            this.label4.Text = "Oblasti kojoj zivotinja pripada:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(767, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 17);
            this.label5.TabIndex = 42;
            this.label5.Text = "<-";
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.listView2.FullRowSelect = true;
            this.listView2.GridLines = true;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(811, 58);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(272, 199);
            this.listView2.TabIndex = 43;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Id oblasti";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Ime";
            this.columnHeader4.Width = 105;
            // 
            // cmdObrisiOblast
            // 
            this.cmdObrisiOblast.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmdObrisiOblast.Location = new System.Drawing.Point(19, 86);
            this.cmdObrisiOblast.Name = "cmdObrisiOblast";
            this.cmdObrisiOblast.Size = new System.Drawing.Size(152, 41);
            this.cmdObrisiOblast.TabIndex = 44;
            this.cmdObrisiOblast.Text = "Izbaci oblast";
            this.cmdObrisiOblast.UseVisualStyleBackColor = false;
            this.cmdObrisiOblast.Click += new System.EventHandler(this.cmdObrisiOblast_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmdDodajOblast);
            this.groupBox1.Controls.Add(this.cmdObrisiOblast);
            this.groupBox1.Location = new System.Drawing.Point(1117, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(195, 148);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Oblasti";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(497, 335);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(560, 17);
            this.label6.TabIndex = 46;
            this.label6.Text = "Sve sto se promeni u formi a zelite da sacuvate i u bazi pritisnite dugme sacuvaj" +
    " izmene";
            // 
            // IzmeniZivotinjuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1580, 361);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmdIzmeniZivotinju);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmdNazad);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "IzmeniZivotinjuForm";
            this.Text = "Izmeni zivotinju";
            this.Load += new System.EventHandler(this.IzmeniZivotinjuForm_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSerijskiBroj)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cmdDodajOblast;
        private System.Windows.Forms.Button cmdNazad;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown numSerijskiBroj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLatinskiNaziv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLokalniNaziv;
        private System.Windows.Forms.CheckBox ckbPticaSelica;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button cmdIzmeniZivotinju;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button cmdObrisiOblast;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
    }
}