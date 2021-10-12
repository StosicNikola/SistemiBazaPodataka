namespace ParkPrirode.Forme
{
    partial class ZatitiBiljkuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZatitiBiljkuForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmdSacuvaj = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtLatinskiNaziv = new System.Windows.Forms.TextBox();
            this.numBrojOdluke = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numBrojOdluke)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id biljke: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Latinski naziv: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Broj odluke: ";
            // 
            // cmdSacuvaj
            // 
            this.cmdSacuvaj.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmdSacuvaj.Location = new System.Drawing.Point(106, 205);
            this.cmdSacuvaj.Name = "cmdSacuvaj";
            this.cmdSacuvaj.Size = new System.Drawing.Size(105, 32);
            this.cmdSacuvaj.TabIndex = 3;
            this.cmdSacuvaj.Text = "Sacuvaj";
            this.cmdSacuvaj.UseVisualStyleBackColor = false;
            this.cmdSacuvaj.Click += new System.EventHandler(this.cmdSacuvaj_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(152, 65);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(128, 22);
            this.txtId.TabIndex = 4;
            // 
            // txtLatinskiNaziv
            // 
            this.txtLatinskiNaziv.Location = new System.Drawing.Point(152, 102);
            this.txtLatinskiNaziv.Name = "txtLatinskiNaziv";
            this.txtLatinskiNaziv.Size = new System.Drawing.Size(128, 22);
            this.txtLatinskiNaziv.TabIndex = 5;
            // 
            // numBrojOdluke
            // 
            this.numBrojOdluke.Location = new System.Drawing.Point(152, 145);
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
            this.numBrojOdluke.Size = new System.Drawing.Size(128, 22);
            this.numBrojOdluke.TabIndex = 7;
            this.numBrojOdluke.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // ZatitiBiljkuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(328, 265);
            this.Controls.Add(this.numBrojOdluke);
            this.Controls.Add(this.txtLatinskiNaziv);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.cmdSacuvaj);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ZatitiBiljkuForm";
            this.Text = "Zatiti biljku ";
            ((System.ComponentModel.ISupportInitialize)(this.numBrojOdluke)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cmdSacuvaj;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtLatinskiNaziv;
        private System.Windows.Forms.NumericUpDown numBrojOdluke;
    }
}