namespace ParkPrirode.Forme
{
    partial class IzmeniLokalniNazivBiljkeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IzmeniLokalniNazivBiljkeForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxId = new System.Windows.Forms.TextBox();
            this.txtBoxLokalniNaziv = new System.Windows.Forms.TextBox();
            this.cmdIzmeni = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id biljke";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lokalni naziv biljke";
            // 
            // txtBoxId
            // 
            this.txtBoxId.Location = new System.Drawing.Point(187, 52);
            this.txtBoxId.Name = "txtBoxId";
            this.txtBoxId.Size = new System.Drawing.Size(145, 22);
            this.txtBoxId.TabIndex = 2;
            // 
            // txtBoxLokalniNaziv
            // 
            this.txtBoxLokalniNaziv.Location = new System.Drawing.Point(187, 97);
            this.txtBoxLokalniNaziv.Name = "txtBoxLokalniNaziv";
            this.txtBoxLokalniNaziv.Size = new System.Drawing.Size(145, 22);
            this.txtBoxLokalniNaziv.TabIndex = 3;
            // 
            // cmdIzmeni
            // 
            this.cmdIzmeni.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmdIzmeni.Location = new System.Drawing.Point(119, 147);
            this.cmdIzmeni.Name = "cmdIzmeni";
            this.cmdIzmeni.Size = new System.Drawing.Size(136, 40);
            this.cmdIzmeni.TabIndex = 4;
            this.cmdIzmeni.Text = "Izmeni";
            this.cmdIzmeni.UseVisualStyleBackColor = false;
            this.cmdIzmeni.Click += new System.EventHandler(this.cmdIzmeni_Click);
            // 
            // IzmeniLokalniNazivBiljkeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(382, 228);
            this.Controls.Add(this.cmdIzmeni);
            this.Controls.Add(this.txtBoxLokalniNaziv);
            this.Controls.Add(this.txtBoxId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "IzmeniLokalniNazivBiljkeForm";
            this.Text = "Izmeni lokalni naziv biljke";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxId;
        private System.Windows.Forms.TextBox txtBoxLokalniNaziv;
        private System.Windows.Forms.Button cmdIzmeni;
    }
}