namespace ParkPrirode.Forme
{
    partial class RadniciOblastiForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RadniciOblastiForm));
            this.listView1 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtImeOblasti = new System.Windows.Forms.TextBox();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtBrRadnika = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmdDodajRadnika = new System.Windows.Forms.Button();
            this.cmdObrisiRadnika = new System.Windows.Forms.Button();
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
            this.columnHeader5,
            this.columnHeader6});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(30, 47);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(665, 337);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ime oblasti:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Location = new System.Drawing.Point(32, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(721, 414);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista radnika";
            // 
            // txtImeOblasti
            // 
            this.txtImeOblasti.Location = new System.Drawing.Point(144, 42);
            this.txtImeOblasti.Name = "txtImeOblasti";
            this.txtImeOblasti.Size = new System.Drawing.Size(196, 22);
            this.txtImeOblasti.TabIndex = 3;
            this.txtImeOblasti.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id radnika";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ime";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Prezime";
            this.columnHeader3.Width = 74;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Adresa";
            this.columnHeader4.Width = 99;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Maticni broj";
            this.columnHeader5.Width = 115;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Tip posla";
            this.columnHeader6.Width = 97;
            // 
            // txtBrRadnika
            // 
            this.txtBrRadnika.Location = new System.Drawing.Point(508, 42);
            this.txtBrRadnika.Name = "txtBrRadnika";
            this.txtBrRadnika.Size = new System.Drawing.Size(196, 22);
            this.txtBrRadnika.TabIndex = 5;
            this.txtBrRadnika.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(406, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Broj radnika:";
            // 
            // cmdDodajRadnika
            // 
            this.cmdDodajRadnika.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmdDodajRadnika.Location = new System.Drawing.Point(62, 537);
            this.cmdDodajRadnika.Name = "cmdDodajRadnika";
            this.cmdDodajRadnika.Size = new System.Drawing.Size(155, 47);
            this.cmdDodajRadnika.TabIndex = 6;
            this.cmdDodajRadnika.Text = "Dodaj radnika";
            this.cmdDodajRadnika.UseVisualStyleBackColor = false;
            this.cmdDodajRadnika.Click += new System.EventHandler(this.cmdDodajRadnika_Click);
            // 
            // cmdObrisiRadnika
            // 
            this.cmdObrisiRadnika.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmdObrisiRadnika.Location = new System.Drawing.Point(314, 537);
            this.cmdObrisiRadnika.Name = "cmdObrisiRadnika";
            this.cmdObrisiRadnika.Size = new System.Drawing.Size(155, 47);
            this.cmdObrisiRadnika.TabIndex = 7;
            this.cmdObrisiRadnika.Text = "Obrisi radnika";
            this.cmdObrisiRadnika.UseVisualStyleBackColor = false;
            this.cmdObrisiRadnika.Click += new System.EventHandler(this.cmdObrisiRadnika_Click);
            // 
            // cmdNazad
            // 
            this.cmdNazad.BackColor = System.Drawing.SystemColors.Info;
            this.cmdNazad.Location = new System.Drawing.Point(572, 537);
            this.cmdNazad.Name = "cmdNazad";
            this.cmdNazad.Size = new System.Drawing.Size(155, 47);
            this.cmdNazad.TabIndex = 8;
            this.cmdNazad.Text = "<- Nazad";
            this.cmdNazad.UseVisualStyleBackColor = false;
            this.cmdNazad.Click += new System.EventHandler(this.cmdNazad_Click);
            // 
            // RadniciOblastiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(790, 630);
            this.Controls.Add(this.cmdNazad);
            this.Controls.Add(this.cmdObrisiRadnika);
            this.Controls.Add(this.cmdDodajRadnika);
            this.Controls.Add(this.txtBrRadnika);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtImeOblasti);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RadniciOblastiForm";
            this.Text = "Radnici";
            this.Load += new System.EventHandler(this.RadniciOblastiForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtImeOblasti;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.TextBox txtBrRadnika;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cmdDodajRadnika;
        private System.Windows.Forms.Button cmdObrisiRadnika;
        private System.Windows.Forms.Button cmdNazad;
    }
}