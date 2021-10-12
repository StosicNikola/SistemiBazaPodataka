namespace ParkPrirode.Forme
{
    partial class IzmeniBiljkuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IzmeniBiljkuForm));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.cmdDodajOblast = new System.Windows.Forms.Button();
            this.cmdObrisiOblast = new System.Windows.Forms.Button();
            this.cmdPromeniLatinskiNaziv = new System.Windows.Forms.Button();
            this.cmdNazad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(144, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(174, 22);
            this.textBox1.TabIndex = 0;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(31, 150);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(320, 104);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id oblasti";
            this.columnHeader1.Width = 82;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ime";
            this.columnHeader2.Width = 180;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Latinski naziv: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pripada oblastima:";
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.listView2.FullRowSelect = true;
            this.listView2.GridLines = true;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(31, 313);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(320, 157);
            this.listView2.TabIndex = 4;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Id oblasti";
            this.columnHeader3.Width = 84;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Ime";
            this.columnHeader4.Width = 178;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ostale oblasti:";
            // 
            // cmdDodajOblast
            // 
            this.cmdDodajOblast.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmdDodajOblast.Location = new System.Drawing.Point(31, 496);
            this.cmdDodajOblast.Name = "cmdDodajOblast";
            this.cmdDodajOblast.Size = new System.Drawing.Size(153, 39);
            this.cmdDodajOblast.TabIndex = 6;
            this.cmdDodajOblast.Text = "Dodaj oblast";
            this.cmdDodajOblast.UseVisualStyleBackColor = false;
            this.cmdDodajOblast.Click += new System.EventHandler(this.cmdDodajOblast_Click);
            // 
            // cmdObrisiOblast
            // 
            this.cmdObrisiOblast.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmdObrisiOblast.Location = new System.Drawing.Point(198, 496);
            this.cmdObrisiOblast.Name = "cmdObrisiOblast";
            this.cmdObrisiOblast.Size = new System.Drawing.Size(153, 39);
            this.cmdObrisiOblast.TabIndex = 7;
            this.cmdObrisiOblast.Text = "Obrisi oblast";
            this.cmdObrisiOblast.UseVisualStyleBackColor = false;
            this.cmdObrisiOblast.Click += new System.EventHandler(this.cmdObrisiOblast_Click);
            // 
            // cmdPromeniLatinskiNaziv
            // 
            this.cmdPromeniLatinskiNaziv.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmdPromeniLatinskiNaziv.Location = new System.Drawing.Point(31, 59);
            this.cmdPromeniLatinskiNaziv.Name = "cmdPromeniLatinskiNaziv";
            this.cmdPromeniLatinskiNaziv.Size = new System.Drawing.Size(287, 27);
            this.cmdPromeniLatinskiNaziv.TabIndex = 8;
            this.cmdPromeniLatinskiNaziv.Text = "Promeni latinski naziv";
            this.cmdPromeniLatinskiNaziv.UseVisualStyleBackColor = false;
            this.cmdPromeniLatinskiNaziv.Click += new System.EventHandler(this.cmdPromeniLatinskiNaziv_Click);
            // 
            // cmdNazad
            // 
            this.cmdNazad.BackColor = System.Drawing.SystemColors.Info;
            this.cmdNazad.Location = new System.Drawing.Point(119, 563);
            this.cmdNazad.Name = "cmdNazad";
            this.cmdNazad.Size = new System.Drawing.Size(131, 39);
            this.cmdNazad.TabIndex = 9;
            this.cmdNazad.Text = "<- Nazad";
            this.cmdNazad.UseVisualStyleBackColor = false;
            this.cmdNazad.Click += new System.EventHandler(this.cmdNazad_Click);
            // 
            // IzmeniBiljkuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(379, 634);
            this.Controls.Add(this.cmdNazad);
            this.Controls.Add(this.cmdPromeniLatinskiNaziv);
            this.Controls.Add(this.cmdObrisiOblast);
            this.Controls.Add(this.cmdDodajOblast);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "IzmeniBiljkuForm";
            this.Text = "Izmeni biljku";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cmdDodajOblast;
        private System.Windows.Forms.Button cmdObrisiOblast;
        private System.Windows.Forms.Button cmdPromeniLatinskiNaziv;
        private System.Windows.Forms.Button cmdNazad;
    }
}