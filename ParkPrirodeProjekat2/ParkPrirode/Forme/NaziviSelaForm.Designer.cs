namespace ParkPrirode.Forme
{
    partial class NaziviSelaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NaziviSelaForm));
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmdDodajSelo = new System.Windows.Forms.Button();
            this.cmdObrisiSelo = new System.Windows.Forms.Button();
            this.cmdNazad = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtImeOblasti = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(23, 74);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(234, 173);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Naziv sela";
            this.columnHeader1.Width = 117;
            // 
            // cmdDodajSelo
            // 
            this.cmdDodajSelo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmdDodajSelo.Location = new System.Drawing.Point(287, 74);
            this.cmdDodajSelo.Name = "cmdDodajSelo";
            this.cmdDodajSelo.Size = new System.Drawing.Size(134, 41);
            this.cmdDodajSelo.TabIndex = 1;
            this.cmdDodajSelo.Text = "Dodaj selo";
            this.cmdDodajSelo.UseVisualStyleBackColor = false;
            this.cmdDodajSelo.Click += new System.EventHandler(this.cmdDodajSelo_Click);
            // 
            // cmdObrisiSelo
            // 
            this.cmdObrisiSelo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmdObrisiSelo.Location = new System.Drawing.Point(287, 140);
            this.cmdObrisiSelo.Name = "cmdObrisiSelo";
            this.cmdObrisiSelo.Size = new System.Drawing.Size(134, 41);
            this.cmdObrisiSelo.TabIndex = 2;
            this.cmdObrisiSelo.Text = "Obrisi selo";
            this.cmdObrisiSelo.UseVisualStyleBackColor = false;
            this.cmdObrisiSelo.Click += new System.EventHandler(this.cmdObrisiSelo_Click);
            // 
            // cmdNazad
            // 
            this.cmdNazad.BackColor = System.Drawing.SystemColors.Info;
            this.cmdNazad.Location = new System.Drawing.Point(287, 206);
            this.cmdNazad.Name = "cmdNazad";
            this.cmdNazad.Size = new System.Drawing.Size(134, 41);
            this.cmdNazad.TabIndex = 3;
            this.cmdNazad.Text = "<- Nazad";
            this.cmdNazad.UseVisualStyleBackColor = false;
            this.cmdNazad.Click += new System.EventHandler(this.cmdNazad_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ime oblasti:";
            // 
            // txtImeOblasti
            // 
            this.txtImeOblasti.Location = new System.Drawing.Point(122, 31);
            this.txtImeOblasti.Name = "txtImeOblasti";
            this.txtImeOblasti.Size = new System.Drawing.Size(135, 22);
            this.txtImeOblasti.TabIndex = 5;
            // 
            // NaziviSelaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(449, 283);
            this.Controls.Add(this.txtImeOblasti);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdNazad);
            this.Controls.Add(this.cmdObrisiSelo);
            this.Controls.Add(this.cmdDodajSelo);
            this.Controls.Add(this.listView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NaziviSelaForm";
            this.Text = "Lista sela";
            this.Load += new System.EventHandler(this.NaziviSelaForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button cmdDodajSelo;
        private System.Windows.Forms.Button cmdObrisiSelo;
        private System.Windows.Forms.Button cmdNazad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtImeOblasti;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}