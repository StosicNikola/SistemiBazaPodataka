namespace ParkPrirode.Forme
{
    partial class BiljkaForm1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BiljkaForm1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmdLokalniNazivBiljke = new System.Windows.Forms.Button();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmdDodajLokalniNaziv = new System.Windows.Forms.Button();
            this.cmdObrisiLokalniNaziv = new System.Windows.Forms.Button();
            this.cmdIzmeniLokalniNaziv = new System.Windows.Forms.Button();
            this.cmdUcitajZaticeneBiljke = new System.Windows.Forms.Button();
            this.cmdDodajBiljku = new System.Windows.Forms.Button();
            this.cmdObrisiBiljku = new System.Windows.Forms.Button();
            this.cmdIzmeniBiljku = new System.Windows.Forms.Button();
            this.cmdZastitiBiljku = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmdZastitiBiljku);
            this.groupBox1.Controls.Add(this.cmdIzmeniBiljku);
            this.groupBox1.Controls.Add(this.cmdObrisiBiljku);
            this.groupBox1.Controls.Add(this.cmdDodajBiljku);
            this.groupBox1.Controls.Add(this.cmdUcitajZaticeneBiljke);
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Location = new System.Drawing.Point(39, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(553, 302);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista biljaka";
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
            this.listView1.Location = new System.Drawing.Point(23, 36);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(360, 241);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id biljke";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Latinski naziv";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 179;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Zasticena";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 104;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmdIzmeniLokalniNaziv);
            this.groupBox2.Controls.Add(this.cmdObrisiLokalniNaziv);
            this.groupBox2.Controls.Add(this.cmdDodajLokalniNaziv);
            this.groupBox2.Controls.Add(this.listView2);
            this.groupBox2.Controls.Add(this.cmdLokalniNazivBiljke);
            this.groupBox2.Location = new System.Drawing.Point(626, 43);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(300, 302);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lokalni naziv biljke";
            // 
            // cmdLokalniNazivBiljke
            // 
            this.cmdLokalniNazivBiljke.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmdLokalniNazivBiljke.Location = new System.Drawing.Point(55, 36);
            this.cmdLokalniNazivBiljke.Name = "cmdLokalniNazivBiljke";
            this.cmdLokalniNazivBiljke.Size = new System.Drawing.Size(197, 32);
            this.cmdLokalniNazivBiljke.TabIndex = 0;
            this.cmdLokalniNazivBiljke.Text = "Ucitaj nazive";
            this.cmdLokalniNazivBiljke.UseVisualStyleBackColor = false;
            this.cmdLokalniNazivBiljke.Click += new System.EventHandler(this.cmdLokalniNazivBiljke_Click);
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5});
            this.listView2.FullRowSelect = true;
            this.listView2.GridLines = true;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(16, 87);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(266, 123);
            this.listView2.TabIndex = 1;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Id biljke";
            this.columnHeader4.Width = 77;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Lokalni naziv";
            this.columnHeader5.Width = 118;
            // 
            // cmdDodajLokalniNaziv
            // 
            this.cmdDodajLokalniNaziv.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmdDodajLokalniNaziv.Location = new System.Drawing.Point(16, 227);
            this.cmdDodajLokalniNaziv.Name = "cmdDodajLokalniNaziv";
            this.cmdDodajLokalniNaziv.Size = new System.Drawing.Size(83, 34);
            this.cmdDodajLokalniNaziv.TabIndex = 2;
            this.cmdDodajLokalniNaziv.Text = "Dodaj";
            this.cmdDodajLokalniNaziv.UseVisualStyleBackColor = false;
            this.cmdDodajLokalniNaziv.Click += new System.EventHandler(this.cmdDodajLokalniNaziv_Click);
            // 
            // cmdObrisiLokalniNaziv
            // 
            this.cmdObrisiLokalniNaziv.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmdObrisiLokalniNaziv.Location = new System.Drawing.Point(114, 227);
            this.cmdObrisiLokalniNaziv.Name = "cmdObrisiLokalniNaziv";
            this.cmdObrisiLokalniNaziv.Size = new System.Drawing.Size(75, 34);
            this.cmdObrisiLokalniNaziv.TabIndex = 3;
            this.cmdObrisiLokalniNaziv.Text = "Obrisi";
            this.cmdObrisiLokalniNaziv.UseVisualStyleBackColor = false;
            this.cmdObrisiLokalniNaziv.Click += new System.EventHandler(this.cmdObrisiLokalniNaziv_Click);
            // 
            // cmdIzmeniLokalniNaziv
            // 
            this.cmdIzmeniLokalniNaziv.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmdIzmeniLokalniNaziv.Location = new System.Drawing.Point(207, 227);
            this.cmdIzmeniLokalniNaziv.Name = "cmdIzmeniLokalniNaziv";
            this.cmdIzmeniLokalniNaziv.Size = new System.Drawing.Size(75, 34);
            this.cmdIzmeniLokalniNaziv.TabIndex = 4;
            this.cmdIzmeniLokalniNaziv.Text = "Izmeni";
            this.cmdIzmeniLokalniNaziv.UseVisualStyleBackColor = false;
            this.cmdIzmeniLokalniNaziv.Click += new System.EventHandler(this.cmdIzmeniLokalniNaziv_Click);
            // 
            // cmdUcitajZaticeneBiljke
            // 
            this.cmdUcitajZaticeneBiljke.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmdUcitajZaticeneBiljke.Location = new System.Drawing.Point(406, 36);
            this.cmdUcitajZaticeneBiljke.Name = "cmdUcitajZaticeneBiljke";
            this.cmdUcitajZaticeneBiljke.Size = new System.Drawing.Size(120, 32);
            this.cmdUcitajZaticeneBiljke.TabIndex = 1;
            this.cmdUcitajZaticeneBiljke.Text = "Zasticene biljke";
            this.cmdUcitajZaticeneBiljke.UseVisualStyleBackColor = false;
            this.cmdUcitajZaticeneBiljke.Click += new System.EventHandler(this.cmdUcitajZaticeneBiljke_Click);
            // 
            // cmdDodajBiljku
            // 
            this.cmdDodajBiljku.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmdDodajBiljku.Location = new System.Drawing.Point(406, 140);
            this.cmdDodajBiljku.Name = "cmdDodajBiljku";
            this.cmdDodajBiljku.Size = new System.Drawing.Size(120, 32);
            this.cmdDodajBiljku.TabIndex = 2;
            this.cmdDodajBiljku.Text = "Dodaj biljku";
            this.cmdDodajBiljku.UseVisualStyleBackColor = false;
            this.cmdDodajBiljku.Click += new System.EventHandler(this.cmdDodajBiljku_Click);
            // 
            // cmdObrisiBiljku
            // 
            this.cmdObrisiBiljku.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmdObrisiBiljku.Location = new System.Drawing.Point(406, 191);
            this.cmdObrisiBiljku.Name = "cmdObrisiBiljku";
            this.cmdObrisiBiljku.Size = new System.Drawing.Size(120, 32);
            this.cmdObrisiBiljku.TabIndex = 3;
            this.cmdObrisiBiljku.Text = "Obrisi biljku";
            this.cmdObrisiBiljku.UseVisualStyleBackColor = false;
            this.cmdObrisiBiljku.Click += new System.EventHandler(this.cmdObrisiBiljku_Click);
            // 
            // cmdIzmeniBiljku
            // 
            this.cmdIzmeniBiljku.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmdIzmeniBiljku.Location = new System.Drawing.Point(406, 245);
            this.cmdIzmeniBiljku.Name = "cmdIzmeniBiljku";
            this.cmdIzmeniBiljku.Size = new System.Drawing.Size(120, 32);
            this.cmdIzmeniBiljku.TabIndex = 4;
            this.cmdIzmeniBiljku.Text = "Izmeni biljku";
            this.cmdIzmeniBiljku.UseVisualStyleBackColor = false;
            this.cmdIzmeniBiljku.Click += new System.EventHandler(this.cmdIzmeniBiljku_Click);
            // 
            // cmdZastitiBiljku
            // 
            this.cmdZastitiBiljku.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmdZastitiBiljku.Location = new System.Drawing.Point(406, 87);
            this.cmdZastitiBiljku.Name = "cmdZastitiBiljku";
            this.cmdZastitiBiljku.Size = new System.Drawing.Size(120, 32);
            this.cmdZastitiBiljku.TabIndex = 5;
            this.cmdZastitiBiljku.Text = "Zastiti biljku";
            this.cmdZastitiBiljku.UseVisualStyleBackColor = false;
            this.cmdZastitiBiljku.Click += new System.EventHandler(this.cmdZastitiBiljku_Click);
            // 
            // BiljkaForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(974, 385);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BiljkaForm1";
            this.Text = "Biljni svet";
            this.Load += new System.EventHandler(this.BiljkaForm1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button cmdLokalniNazivBiljke;
        private System.Windows.Forms.Button cmdIzmeniLokalniNaziv;
        private System.Windows.Forms.Button cmdObrisiLokalniNaziv;
        private System.Windows.Forms.Button cmdDodajLokalniNaziv;
        private System.Windows.Forms.Button cmdIzmeniBiljku;
        private System.Windows.Forms.Button cmdObrisiBiljku;
        private System.Windows.Forms.Button cmdDodajBiljku;
        private System.Windows.Forms.Button cmdUcitajZaticeneBiljke;
        private System.Windows.Forms.Button cmdZastitiBiljku;
    }
}