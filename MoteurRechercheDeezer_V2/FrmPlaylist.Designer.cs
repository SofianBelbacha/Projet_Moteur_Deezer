namespace ZiKnCo_MoteurRechercheDeezer
{
    partial class FrmPlaylist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPlaylist));
            this.lblTitres = new System.Windows.Forms.Label();
            this.lstGauche = new System.Windows.Forms.ListBox();
            this.lstDroite = new System.Windows.Forms.ListBox();
            this.lblMorcauxChoisis = new System.Windows.Forms.Label();
            this.btnVersDroiteUN = new System.Windows.Forms.Button();
            this.btnVersDroiteTous = new System.Windows.Forms.Button();
            this.btnVersGaucheUn = new System.Windows.Forms.Button();
            this.btnVersGaucheTous = new System.Windows.Forms.Button();
            this.btnEcouterExtraitV3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitres
            // 
            this.lblTitres.AutoSize = true;
            this.lblTitres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitres.Location = new System.Drawing.Point(26, 33);
            this.lblTitres.Name = "lblTitres";
            this.lblTitres.Size = new System.Drawing.Size(124, 16);
            this.lblTitres.TabIndex = 0;
            this.lblTitres.Text = "Morcaux de l\'Album";
            // 
            // lstGauche
            // 
            this.lstGauche.FormattingEnabled = true;
            this.lstGauche.Location = new System.Drawing.Point(29, 75);
            this.lstGauche.Name = "lstGauche";
            this.lstGauche.Size = new System.Drawing.Size(250, 264);
            this.lstGauche.TabIndex = 1;
            this.lstGauche.SelectedIndexChanged += new System.EventHandler(this.lstGauche_SelectedIndexChanged);
            // 
            // lstDroite
            // 
            this.lstDroite.FormattingEnabled = true;
            this.lstDroite.Location = new System.Drawing.Point(481, 75);
            this.lstDroite.Name = "lstDroite";
            this.lstDroite.Size = new System.Drawing.Size(278, 264);
            this.lstDroite.TabIndex = 2;
            this.lstDroite.SelectedIndexChanged += new System.EventHandler(this.lstDroite_SelectedIndexChanged);
            // 
            // lblMorcauxChoisis
            // 
            this.lblMorcauxChoisis.AutoSize = true;
            this.lblMorcauxChoisis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMorcauxChoisis.Location = new System.Drawing.Point(478, 33);
            this.lblMorcauxChoisis.Name = "lblMorcauxChoisis";
            this.lblMorcauxChoisis.Size = new System.Drawing.Size(159, 16);
            this.lblMorcauxChoisis.TabIndex = 3;
            this.lblMorcauxChoisis.Text = "Morcaux Choisis (Playlist)";
            // 
            // btnVersDroiteUN
            // 
            this.btnVersDroiteUN.Location = new System.Drawing.Point(335, 89);
            this.btnVersDroiteUN.Name = "btnVersDroiteUN";
            this.btnVersDroiteUN.Size = new System.Drawing.Size(75, 23);
            this.btnVersDroiteUN.TabIndex = 4;
            this.btnVersDroiteUN.Text = "> Un";
            this.btnVersDroiteUN.UseVisualStyleBackColor = true;
            // 
            // btnVersDroiteTous
            // 
            this.btnVersDroiteTous.Location = new System.Drawing.Point(335, 130);
            this.btnVersDroiteTous.Name = "btnVersDroiteTous";
            this.btnVersDroiteTous.Size = new System.Drawing.Size(75, 23);
            this.btnVersDroiteTous.TabIndex = 5;
            this.btnVersDroiteTous.Text = ">> Tous";
            this.btnVersDroiteTous.UseVisualStyleBackColor = true;
            this.btnVersDroiteTous.Click += new System.EventHandler(this.btnVersDroiteTous_Click);
            // 
            // btnVersGaucheUn
            // 
            this.btnVersGaucheUn.Location = new System.Drawing.Point(335, 216);
            this.btnVersGaucheUn.Name = "btnVersGaucheUn";
            this.btnVersGaucheUn.Size = new System.Drawing.Size(75, 23);
            this.btnVersGaucheUn.TabIndex = 6;
            this.btnVersGaucheUn.Text = "< Un";
            this.btnVersGaucheUn.UseVisualStyleBackColor = true;
            // 
            // btnVersGaucheTous
            // 
            this.btnVersGaucheTous.Location = new System.Drawing.Point(335, 259);
            this.btnVersGaucheTous.Name = "btnVersGaucheTous";
            this.btnVersGaucheTous.Size = new System.Drawing.Size(75, 23);
            this.btnVersGaucheTous.TabIndex = 7;
            this.btnVersGaucheTous.Text = "<< Tous";
            this.btnVersGaucheTous.UseVisualStyleBackColor = true;
            this.btnVersGaucheTous.Click += new System.EventHandler(this.btnVersGaucheTous_Click);
            // 
            // btnEcouterExtraitV3
            // 
            this.btnEcouterExtraitV3.Location = new System.Drawing.Point(550, 376);
            this.btnEcouterExtraitV3.Name = "btnEcouterExtraitV3";
            this.btnEcouterExtraitV3.Size = new System.Drawing.Size(209, 32);
            this.btnEcouterExtraitV3.TabIndex = 8;
            this.btnEcouterExtraitV3.Text = "Jouer les Extraits";
            this.btnEcouterExtraitV3.UseVisualStyleBackColor = true;
            this.btnEcouterExtraitV3.Click += new System.EventHandler(this.btnEcouterExtraitV3_Click);
            // 
            // FrmPlaylist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEcouterExtraitV3);
            this.Controls.Add(this.btnVersGaucheTous);
            this.Controls.Add(this.btnVersGaucheUn);
            this.Controls.Add(this.btnVersDroiteTous);
            this.Controls.Add(this.btnVersDroiteUN);
            this.Controls.Add(this.lblMorcauxChoisis);
            this.Controls.Add(this.lstDroite);
            this.Controls.Add(this.lstGauche);
            this.Controls.Add(this.lblTitres);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPlaylist";
            this.Text = "PLAYLIST des Extraits de l\'Album...";
            this.Load += new System.EventHandler(this.FrmPlaylist_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitres;
        private System.Windows.Forms.ListBox lstDroite;
        private System.Windows.Forms.Label lblMorcauxChoisis;
        private System.Windows.Forms.Button btnVersDroiteUN;
        private System.Windows.Forms.Button btnVersDroiteTous;
        private System.Windows.Forms.Button btnVersGaucheUn;
        private System.Windows.Forms.Button btnVersGaucheTous;
        private System.Windows.Forms.Button btnEcouterExtraitV3;
        public System.Windows.Forms.ListBox lstGauche;
    }
}