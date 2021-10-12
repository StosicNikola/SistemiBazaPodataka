namespace ParkPrirode.Forme
{
    partial class ZivotinjeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZivotinjeForm));
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmdIzmeniZivotinju = new System.Windows.Forms.Button();
            this.cmdObrisiZivotinju = new System.Windows.Forms.Button();
            this.cmdDodajZivotinju = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmdZemlje = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUkupanBrojZivotinja = new System.Windows.Forms.TextBox();
            this.cmdNazad = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Location = new System.Drawing.Point(26, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(810, 584);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista zivotinja";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(164, 44);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(225, 24);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Filtriraj zivotinje:";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(29, 91);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(736, 457);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Serijski broj";
            this.columnHeader2.Width = 86;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Latinski naziv";
            this.columnHeader3.Width = 117;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Lokalni naziv";
            this.columnHeader4.Width = 101;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Ptica selica";
            this.columnHeader5.Width = 89;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Broj oblasti";
            this.columnHeader6.Width = 89;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmdIzmeniZivotinju);
            this.groupBox2.Controls.Add(this.cmdObrisiZivotinju);
            this.groupBox2.Controls.Add(this.cmdDodajZivotinju);
            this.groupBox2.Location = new System.Drawing.Point(871, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(262, 244);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Podaci o zivotinjama";
            // 
            // cmdIzmeniZivotinju
            // 
            this.cmdIzmeniZivotinju.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmdIzmeniZivotinju.Location = new System.Drawing.Point(28, 168);
            this.cmdIzmeniZivotinju.Name = "cmdIzmeniZivotinju";
            this.cmdIzmeniZivotinju.Size = new System.Drawing.Size(207, 39);
            this.cmdIzmeniZivotinju.TabIndex = 2;
            this.cmdIzmeniZivotinju.Text = "Izmeni zivotinju";
            this.cmdIzmeniZivotinju.UseVisualStyleBackColor = false;
            this.cmdIzmeniZivotinju.Click += new System.EventHandler(this.cmdIzmeniZivotinju_Click);
            // 
            // cmdObrisiZivotinju
            // 
            this.cmdObrisiZivotinju.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmdObrisiZivotinju.Location = new System.Drawing.Point(28, 108);
            this.cmdObrisiZivotinju.Name = "cmdObrisiZivotinju";
            this.cmdObrisiZivotinju.Size = new System.Drawing.Size(207, 39);
            this.cmdObrisiZivotinju.TabIndex = 1;
            this.cmdObrisiZivotinju.Text = "Obrisi zivotinju";
            this.cmdObrisiZivotinju.UseVisualStyleBackColor = false;
            this.cmdObrisiZivotinju.Click += new System.EventHandler(this.cmdObrisiZivotinju_Click);
            // 
            // cmdDodajZivotinju
            // 
            this.cmdDodajZivotinju.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmdDodajZivotinju.Location = new System.Drawing.Point(27, 47);
            this.cmdDodajZivotinju.Name = "cmdDodajZivotinju";
            this.cmdDodajZivotinju.Size = new System.Drawing.Size(207, 39);
            this.cmdDodajZivotinju.TabIndex = 0;
            this.cmdDodajZivotinju.Text = "Dodaj zivotinju";
            this.cmdDodajZivotinju.UseVisualStyleBackColor = false;
            this.cmdDodajZivotinju.Click += new System.EventHandler(this.cmdDodajZivotinju_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.cmdZemlje);
            this.groupBox3.Location = new System.Drawing.Point(871, 301);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(262, 154);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ptice selice";
            // 
            // cmdZemlje
            // 
            this.cmdZemlje.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmdZemlje.Location = new System.Drawing.Point(28, 79);
            this.cmdZemlje.Name = "cmdZemlje";
            this.cmdZemlje.Size = new System.Drawing.Size(207, 39);
            this.cmdZemlje.TabIndex = 3;
            this.cmdZemlje.Text = "Zemlje";
            this.cmdZemlje.UseVisualStyleBackColor = false;
            this.cmdZemlje.Click += new System.EventHandler(this.cmdZemlje_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Zemlje kroz koje prolazi ptica";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(923, 480);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ukupan broj zivotinja";
            // 
            // txtUkupanBrojZivotinja
            // 
            this.txtUkupanBrojZivotinja.Location = new System.Drawing.Point(926, 512);
            this.txtUkupanBrojZivotinja.Name = "txtUkupanBrojZivotinja";
            this.txtUkupanBrojZivotinja.Size = new System.Drawing.Size(151, 22);
            this.txtUkupanBrojZivotinja.TabIndex = 4;
            this.txtUkupanBrojZivotinja.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmdNazad
            // 
            this.cmdNazad.BackColor = System.Drawing.SystemColors.Info;
            this.cmdNazad.Location = new System.Drawing.Point(899, 586);
            this.cmdNazad.Name = "cmdNazad";
            this.cmdNazad.Size = new System.Drawing.Size(207, 39);
            this.cmdNazad.TabIndex = 5;
            this.cmdNazad.Text = "<- Nazad";
            this.cmdNazad.UseVisualStyleBackColor = false;
            this.cmdNazad.Click += new System.EventHandler(this.cmdNazad_Click);
            // 
            // ZivotinjeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1158, 674);
            this.Controls.Add(this.cmdNazad);
            this.Controls.Add(this.txtUkupanBrojZivotinja);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ZivotinjeForm";
            this.Text = "Z I V O T I NJ E";
            this.Load += new System.EventHandler(this.ZivotinjeForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button cmdIzmeniZivotinju;
        private System.Windows.Forms.Button cmdObrisiZivotinju;
        private System.Windows.Forms.Button cmdDodajZivotinju;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button cmdZemlje;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUkupanBrojZivotinja;
        private System.Windows.Forms.Button cmdNazad;
    }
}