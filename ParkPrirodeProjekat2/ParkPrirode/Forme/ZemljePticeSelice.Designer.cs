namespace ParkPrirode.Forme
{
    partial class ZemljePticeSeliceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZemljePticeSeliceForm));
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtImePtice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdDodajZemlju = new System.Windows.Forms.Button();
            this.cmdObrisiZemlju = new System.Windows.Forms.Button();
            this.cmdNazad = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(15, 49);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(250, 197);
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
            this.columnHeader2.Text = "Zemlja";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Location = new System.Drawing.Point(26, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(285, 281);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Zemlje kroz koje prolazi ptica selica";
            // 
            // txtImePtice
            // 
            this.txtImePtice.Location = new System.Drawing.Point(125, 37);
            this.txtImePtice.Name = "txtImePtice";
            this.txtImePtice.Size = new System.Drawing.Size(186, 22);
            this.txtImePtice.TabIndex = 2;
            this.txtImePtice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ime ptice:";
            // 
            // cmdDodajZemlju
            // 
            this.cmdDodajZemlju.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmdDodajZemlju.Location = new System.Drawing.Point(26, 386);
            this.cmdDodajZemlju.Name = "cmdDodajZemlju";
            this.cmdDodajZemlju.Size = new System.Drawing.Size(130, 47);
            this.cmdDodajZemlju.TabIndex = 4;
            this.cmdDodajZemlju.Text = "Dodaj zemlju";
            this.cmdDodajZemlju.UseVisualStyleBackColor = false;
            this.cmdDodajZemlju.Click += new System.EventHandler(this.cmdDodajZemlju_Click);
            // 
            // cmdObrisiZemlju
            // 
            this.cmdObrisiZemlju.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmdObrisiZemlju.Location = new System.Drawing.Point(181, 386);
            this.cmdObrisiZemlju.Name = "cmdObrisiZemlju";
            this.cmdObrisiZemlju.Size = new System.Drawing.Size(130, 47);
            this.cmdObrisiZemlju.TabIndex = 5;
            this.cmdObrisiZemlju.Text = "Obrisi zemlju";
            this.cmdObrisiZemlju.UseVisualStyleBackColor = false;
            this.cmdObrisiZemlju.Click += new System.EventHandler(this.cmdObrisiZemlju_Click);
            // 
            // cmdNazad
            // 
            this.cmdNazad.BackColor = System.Drawing.SystemColors.Info;
            this.cmdNazad.Location = new System.Drawing.Point(96, 453);
            this.cmdNazad.Name = "cmdNazad";
            this.cmdNazad.Size = new System.Drawing.Size(130, 38);
            this.cmdNazad.TabIndex = 6;
            this.cmdNazad.Text = "<- Nazad";
            this.cmdNazad.UseVisualStyleBackColor = false;
            this.cmdNazad.Click += new System.EventHandler(this.cmdNazad_Click);
            // 
            // ZemljePticeSeliceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(335, 514);
            this.Controls.Add(this.cmdNazad);
            this.Controls.Add(this.cmdObrisiZemlju);
            this.Controls.Add(this.cmdDodajZemlju);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtImePtice);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ZemljePticeSeliceForm";
            this.Text = "Z E M LJ E";
            this.Load += new System.EventHandler(this.ZemljePticeSeliceForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtImePtice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdDodajZemlju;
        private System.Windows.Forms.Button cmdObrisiZemlju;
        private System.Windows.Forms.Button cmdNazad;
    }
}