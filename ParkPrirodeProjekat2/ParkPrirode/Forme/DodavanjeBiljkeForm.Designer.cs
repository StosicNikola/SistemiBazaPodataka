namespace ParkPrirode.Forme
{
    partial class DodavanjeBiljkeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DodavanjeBiljkeForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numBrojOdluke = new System.Windows.Forms.NumericUpDown();
            this.txtBoxLatinskiNaziv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ckbZasticen = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdNazad = new System.Windows.Forms.Button();
            this.cmdSacuvaj = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBrojOdluke)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numBrojOdluke);
            this.groupBox1.Controls.Add(this.txtBoxLatinskiNaziv);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ckbZasticen);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(24, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 199);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Biljka";
            // 
            // numBrojOdluke
            // 
            this.numBrojOdluke.Location = new System.Drawing.Point(166, 141);
            this.numBrojOdluke.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numBrojOdluke.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numBrojOdluke.Name = "numBrojOdluke";
            this.numBrojOdluke.Size = new System.Drawing.Size(136, 22);
            this.numBrojOdluke.TabIndex = 4;
            this.numBrojOdluke.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numBrojOdluke.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // txtBoxLatinskiNaziv
            // 
            this.txtBoxLatinskiNaziv.Location = new System.Drawing.Point(166, 42);
            this.txtBoxLatinskiNaziv.Name = "txtBoxLatinskiNaziv";
            this.txtBoxLatinskiNaziv.Size = new System.Drawing.Size(136, 22);
            this.txtBoxLatinskiNaziv.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Broj odluke:";
            // 
            // ckbZasticen
            // 
            this.ckbZasticen.AutoSize = true;
            this.ckbZasticen.Location = new System.Drawing.Point(23, 92);
            this.ckbZasticen.Name = "ckbZasticen";
            this.ckbZasticen.Size = new System.Drawing.Size(92, 21);
            this.ckbZasticen.TabIndex = 1;
            this.ckbZasticen.Text = "Zasticena";
            this.ckbZasticen.UseVisualStyleBackColor = true;
            this.ckbZasticen.CheckedChanged += new System.EventHandler(this.ckbZasticen_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Latinski naziv: ";
            // 
            // cmdNazad
            // 
            this.cmdNazad.BackColor = System.Drawing.SystemColors.Info;
            this.cmdNazad.Location = new System.Drawing.Point(47, 283);
            this.cmdNazad.Name = "cmdNazad";
            this.cmdNazad.Size = new System.Drawing.Size(114, 40);
            this.cmdNazad.TabIndex = 1;
            this.cmdNazad.Text = "<- Nazad";
            this.cmdNazad.UseVisualStyleBackColor = false;
            this.cmdNazad.Click += new System.EventHandler(this.cmdNazad_Click);
            // 
            // cmdSacuvaj
            // 
            this.cmdSacuvaj.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmdSacuvaj.Location = new System.Drawing.Point(212, 283);
            this.cmdSacuvaj.Name = "cmdSacuvaj";
            this.cmdSacuvaj.Size = new System.Drawing.Size(114, 40);
            this.cmdSacuvaj.TabIndex = 2;
            this.cmdSacuvaj.Text = "Sacuvaj";
            this.cmdSacuvaj.UseVisualStyleBackColor = false;
            this.cmdSacuvaj.Click += new System.EventHandler(this.cmdSacuvaj_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(387, 51);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(265, 199);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id oblasti";
            this.columnHeader1.Width = 58;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ime";
            this.columnHeader2.Width = 128;
            // 
            // DodavanjeBiljkeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(677, 371);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.cmdSacuvaj);
            this.Controls.Add(this.cmdNazad);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DodavanjeBiljkeForm";
            this.Text = "Dodavanje biljke";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBrojOdluke)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ckbZasticen;
        private System.Windows.Forms.TextBox txtBoxLatinskiNaziv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cmdNazad;
        private System.Windows.Forms.Button cmdSacuvaj;
        private System.Windows.Forms.NumericUpDown numBrojOdluke;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}