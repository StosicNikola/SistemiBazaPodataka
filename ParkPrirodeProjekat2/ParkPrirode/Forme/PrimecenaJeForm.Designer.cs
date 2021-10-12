namespace ParkPrirode.Forme
{
    partial class PrimecenaJeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrimecenaJeForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtImeOblasti = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdHranilista = new System.Windows.Forms.TextBox();
            this.cmdDodajZivotinjuUHraniliste = new System.Windows.Forms.Button();
            this.cmdObrisiZivotinjuIzHranilista = new System.Windows.Forms.Button();
            this.cmdIzmeniZivotinju = new System.Windows.Forms.Button();
            this.cmdNazad = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Location = new System.Drawing.Point(27, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(647, 321);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista zivotinja primecenih kod hranilista";
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
            this.listView1.Location = new System.Drawing.Point(32, 41);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(579, 244);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            this.columnHeader1.Width = 36;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Serijski broj";
            this.columnHeader2.Width = 84;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Latinski naziv";
            this.columnHeader3.Width = 108;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Lokalni naziv";
            this.columnHeader4.Width = 91;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Primecena je";
            this.columnHeader5.Width = 98;
            // 
            // txtImeOblasti
            // 
            this.txtImeOblasti.Location = new System.Drawing.Point(122, 36);
            this.txtImeOblasti.Name = "txtImeOblasti";
            this.txtImeOblasti.Size = new System.Drawing.Size(187, 22);
            this.txtImeOblasti.TabIndex = 2;
            this.txtImeOblasti.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ime oblasti:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(340, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Id hranilista:";
            // 
            // txtIdHranilista
            // 
            this.txtIdHranilista.Location = new System.Drawing.Point(430, 38);
            this.txtIdHranilista.Name = "txtIdHranilista";
            this.txtIdHranilista.Size = new System.Drawing.Size(44, 22);
            this.txtIdHranilista.TabIndex = 4;
            this.txtIdHranilista.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmdDodajZivotinjuUHraniliste
            // 
            this.cmdDodajZivotinjuUHraniliste.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmdDodajZivotinjuUHraniliste.Location = new System.Drawing.Point(720, 88);
            this.cmdDodajZivotinjuUHraniliste.Name = "cmdDodajZivotinjuUHraniliste";
            this.cmdDodajZivotinjuUHraniliste.Size = new System.Drawing.Size(171, 56);
            this.cmdDodajZivotinjuUHraniliste.TabIndex = 6;
            this.cmdDodajZivotinjuUHraniliste.Text = "Dodaj zivotinju";
            this.cmdDodajZivotinjuUHraniliste.UseVisualStyleBackColor = false;
            this.cmdDodajZivotinjuUHraniliste.Click += new System.EventHandler(this.cmdDodajZivotinjuUHraniliste_Click);
            // 
            // cmdObrisiZivotinjuIzHranilista
            // 
            this.cmdObrisiZivotinjuIzHranilista.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmdObrisiZivotinjuIzHranilista.Location = new System.Drawing.Point(720, 173);
            this.cmdObrisiZivotinjuIzHranilista.Name = "cmdObrisiZivotinjuIzHranilista";
            this.cmdObrisiZivotinjuIzHranilista.Size = new System.Drawing.Size(171, 56);
            this.cmdObrisiZivotinjuIzHranilista.TabIndex = 7;
            this.cmdObrisiZivotinjuIzHranilista.Text = "Obrisi zivotinju";
            this.cmdObrisiZivotinjuIzHranilista.UseVisualStyleBackColor = false;
            this.cmdObrisiZivotinjuIzHranilista.Click += new System.EventHandler(this.cmdObrisiZivotinjuIzHranilista_Click);
            // 
            // cmdIzmeniZivotinju
            // 
            this.cmdIzmeniZivotinju.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmdIzmeniZivotinju.Location = new System.Drawing.Point(720, 258);
            this.cmdIzmeniZivotinju.Name = "cmdIzmeniZivotinju";
            this.cmdIzmeniZivotinju.Size = new System.Drawing.Size(171, 56);
            this.cmdIzmeniZivotinju.TabIndex = 8;
            this.cmdIzmeniZivotinju.Text = "Izmeni datum ";
            this.cmdIzmeniZivotinju.UseVisualStyleBackColor = false;
            this.cmdIzmeniZivotinju.Click += new System.EventHandler(this.cmdIzmeniZivotinju_Click);
            // 
            // cmdNazad
            // 
            this.cmdNazad.BackColor = System.Drawing.SystemColors.Info;
            this.cmdNazad.Location = new System.Drawing.Point(720, 344);
            this.cmdNazad.Name = "cmdNazad";
            this.cmdNazad.Size = new System.Drawing.Size(171, 56);
            this.cmdNazad.TabIndex = 9;
            this.cmdNazad.Text = "<- Nazad";
            this.cmdNazad.UseVisualStyleBackColor = false;
            this.cmdNazad.Click += new System.EventHandler(this.cmdNazad_Click);
            // 
            // PrimecenaJeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(938, 443);
            this.Controls.Add(this.cmdNazad);
            this.Controls.Add(this.cmdIzmeniZivotinju);
            this.Controls.Add(this.cmdObrisiZivotinjuIzHranilista);
            this.Controls.Add(this.cmdDodajZivotinjuUHraniliste);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIdHranilista);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtImeOblasti);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PrimecenaJeForm";
            this.Text = "Zivotinje";
            this.Load += new System.EventHandler(this.PrimecenaJeForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox txtImeOblasti;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdHranilista;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button cmdDodajZivotinjuUHraniliste;
        private System.Windows.Forms.Button cmdObrisiZivotinjuIzHranilista;
        private System.Windows.Forms.Button cmdIzmeniZivotinju;
        private System.Windows.Forms.Button cmdNazad;
    }
}