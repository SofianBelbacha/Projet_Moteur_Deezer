namespace ZiKnCo_MoteurRechercheDeezer
{
    partial class FrmRechercheAlbum
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRechercheAlbum));
            this.lblRecherche2 = new System.Windows.Forms.Label();
            this.txtAlbumRecherche = new System.Windows.Forms.TextBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.grbAlbum = new System.Windows.Forms.GroupBox();
            this.webExtraits = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.btnEcouterAlbums = new System.Windows.Forms.Button();
            this.lklDeezerlien2 = new System.Windows.Forms.LinkLabel();
            this.lblPictureTitre2 = new System.Windows.Forms.Label();
            this.lblPictureTitre = new System.Windows.Forms.Label();
            this.picArtistes2 = new System.Windows.Forms.PictureBox();
            this.picAlbum2 = new System.Windows.Forms.PictureBox();
            this.lstTitres2 = new System.Windows.Forms.ListBox();
            this.lblAlbumTitre = new System.Windows.Forms.Label();
            this.lstAlbums2 = new System.Windows.Forms.ListBox();
            this.lblAlbumTrouvés = new System.Windows.Forms.Label();
            this.lblMessage2 = new System.Windows.Forms.Label();
            this.erp2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.grbCalbum = new System.Windows.Forms.GroupBox();
            this.grbAlbum.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webExtraits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picArtistes2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAlbum2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erp2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRecherche2
            // 
            this.lblRecherche2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecherche2.ForeColor = System.Drawing.Color.White;
            this.lblRecherche2.Location = new System.Drawing.Point(13, 23);
            this.lblRecherche2.Name = "lblRecherche2";
            this.lblRecherche2.Size = new System.Drawing.Size(119, 21);
            this.lblRecherche2.TabIndex = 0;
            this.lblRecherche2.Text = "Album recherché :";
            // 
            // txtAlbumRecherche
            // 
            this.txtAlbumRecherche.Location = new System.Drawing.Point(138, 22);
            this.txtAlbumRecherche.Name = "txtAlbumRecherche";
            this.txtAlbumRecherche.Size = new System.Drawing.Size(171, 20);
            this.txtAlbumRecherche.TabIndex = 1;
            this.txtAlbumRecherche.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAlbumRecherche_KeyPress);
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(347, 22);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(45, 23);
            this.btnEnter.TabIndex = 2;
            this.btnEnter.Text = "GO !";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // grbAlbum
            // 
            this.grbAlbum.BackColor = System.Drawing.Color.White;
            this.grbAlbum.Controls.Add(this.webExtraits);
            this.grbAlbum.Controls.Add(this.btnEcouterAlbums);
            this.grbAlbum.Controls.Add(this.lklDeezerlien2);
            this.grbAlbum.Controls.Add(this.lblPictureTitre2);
            this.grbAlbum.Controls.Add(this.lblPictureTitre);
            this.grbAlbum.Controls.Add(this.picArtistes2);
            this.grbAlbum.Controls.Add(this.picAlbum2);
            this.grbAlbum.Controls.Add(this.lstTitres2);
            this.grbAlbum.Controls.Add(this.lblAlbumTitre);
            this.grbAlbum.Controls.Add(this.lstAlbums2);
            this.grbAlbum.Controls.Add(this.lblAlbumTrouvés);
            this.grbAlbum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.85F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbAlbum.Location = new System.Drawing.Point(31, 64);
            this.grbAlbum.Name = "grbAlbum";
            this.grbAlbum.Size = new System.Drawing.Size(732, 364);
            this.grbAlbum.TabIndex = 3;
            this.grbAlbum.TabStop = false;
            this.grbAlbum.Text = "information DEEZER";
            this.grbAlbum.Visible = false;
            this.grbAlbum.Enter += new System.EventHandler(this.grbAlbum_Enter);
            // 
            // webExtraits
            // 
            this.webExtraits.AllowExternalDrop = true;
            this.webExtraits.CreationProperties = null;
            this.webExtraits.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webExtraits.Location = new System.Drawing.Point(294, 251);
            this.webExtraits.Name = "webExtraits";
            this.webExtraits.Size = new System.Drawing.Size(422, 93);
            this.webExtraits.TabIndex = 10;
            this.webExtraits.ZoomFactor = 1D;
            // 
            // btnEcouterAlbums
            // 
            this.btnEcouterAlbums.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnEcouterAlbums.Location = new System.Drawing.Point(294, 220);
            this.btnEcouterAlbums.Name = "btnEcouterAlbums";
            this.btnEcouterAlbums.Size = new System.Drawing.Size(277, 23);
            this.btnEcouterAlbums.TabIndex = 9;
            this.btnEcouterAlbums.Text = "&Ecouter tous les extraits de l\'album...";
            this.btnEcouterAlbums.UseVisualStyleBackColor = true;
            this.btnEcouterAlbums.Click += new System.EventHandler(this.btnEcouterAlbums_Click);
            // 
            // lklDeezerlien2
            // 
            this.lklDeezerlien2.AutoSize = true;
            this.lklDeezerlien2.Location = new System.Drawing.Point(291, 187);
            this.lklDeezerlien2.Name = "lklDeezerlien2";
            this.lklDeezerlien2.Size = new System.Drawing.Size(108, 15);
            this.lklDeezerlien2.TabIndex = 8;
            this.lklDeezerlien2.TabStop = true;
            this.lklDeezerlien2.Text = "Lien Direct Dezzer";
            this.lklDeezerlien2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklDeezerlien2_LinkClicked);
            // 
            // lblPictureTitre2
            // 
            this.lblPictureTitre2.AutoSize = true;
            this.lblPictureTitre2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPictureTitre2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblPictureTitre2.Location = new System.Drawing.Point(440, 66);
            this.lblPictureTitre2.Name = "lblPictureTitre2";
            this.lblPictureTitre2.Size = new System.Drawing.Size(38, 16);
            this.lblPictureTitre2.TabIndex = 7;
            this.lblPictureTitre2.Text = "NOM";
            // 
            // lblPictureTitre
            // 
            this.lblPictureTitre.AutoSize = true;
            this.lblPictureTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPictureTitre.Location = new System.Drawing.Point(313, 25);
            this.lblPictureTitre.Name = "lblPictureTitre";
            this.lblPictureTitre.Size = new System.Drawing.Size(50, 17);
            this.lblPictureTitre.TabIndex = 6;
            this.lblPictureTitre.Text = "Titres";
            // 
            // picArtistes2
            // 
            this.picArtistes2.Location = new System.Drawing.Point(440, 98);
            this.picArtistes2.Name = "picArtistes2";
            this.picArtistes2.Size = new System.Drawing.Size(84, 75);
            this.picArtistes2.TabIndex = 5;
            this.picArtistes2.TabStop = false;
            // 
            // picAlbum2
            // 
            this.picAlbum2.Location = new System.Drawing.Point(294, 57);
            this.picAlbum2.Name = "picAlbum2";
            this.picAlbum2.Size = new System.Drawing.Size(113, 116);
            this.picAlbum2.TabIndex = 4;
            this.picAlbum2.TabStop = false;
            // 
            // lstTitres2
            // 
            this.lstTitres2.FormattingEnabled = true;
            this.lstTitres2.ItemHeight = 15;
            this.lstTitres2.Location = new System.Drawing.Point(9, 250);
            this.lstTitres2.Name = "lstTitres2";
            this.lstTitres2.Size = new System.Drawing.Size(237, 94);
            this.lstTitres2.TabIndex = 3;
            this.lstTitres2.SelectedIndexChanged += new System.EventHandler(this.lstTitres2_SelectedIndexChanged);
            // 
            // lblAlbumTitre
            // 
            this.lblAlbumTitre.AutoSize = true;
            this.lblAlbumTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlbumTitre.Location = new System.Drawing.Point(12, 220);
            this.lblAlbumTitre.Name = "lblAlbumTitre";
            this.lblAlbumTitre.Size = new System.Drawing.Size(139, 17);
            this.lblAlbumTitre.TabIndex = 2;
            this.lblAlbumTitre.Text = "Titres de l\'album :";
            // 
            // lstAlbums2
            // 
            this.lstAlbums2.FormattingEnabled = true;
            this.lstAlbums2.ItemHeight = 15;
            this.lstAlbums2.Location = new System.Drawing.Point(9, 57);
            this.lstAlbums2.Name = "lstAlbums2";
            this.lstAlbums2.Size = new System.Drawing.Size(251, 154);
            this.lstAlbums2.TabIndex = 1;
            this.lstAlbums2.SelectedIndexChanged += new System.EventHandler(this.lstAlbums2_SelectedIndexChanged);
            // 
            // lblAlbumTrouvés
            // 
            this.lblAlbumTrouvés.AutoSize = true;
            this.lblAlbumTrouvés.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlbumTrouvés.Location = new System.Drawing.Point(6, 37);
            this.lblAlbumTrouvés.Name = "lblAlbumTrouvés";
            this.lblAlbumTrouvés.Size = new System.Drawing.Size(129, 17);
            this.lblAlbumTrouvés.TabIndex = 0;
            this.lblAlbumTrouvés.Text = "Albums trouvés :";
            // 
            // lblMessage2
            // 
            this.lblMessage2.AutoSize = true;
            this.lblMessage2.ForeColor = System.Drawing.Color.Coral;
            this.lblMessage2.Location = new System.Drawing.Point(135, 48);
            this.lblMessage2.Name = "lblMessage2";
            this.lblMessage2.Size = new System.Drawing.Size(0, 13);
            this.lblMessage2.TabIndex = 4;
            // 
            // erp2
            // 
            this.erp2.ContainerControl = this;
            // 
            // grbCalbum
            // 
            this.grbCalbum.BackColor = System.Drawing.Color.White;
            this.grbCalbum.Location = new System.Drawing.Point(31, 64);
            this.grbCalbum.Name = "grbCalbum";
            this.grbCalbum.Size = new System.Drawing.Size(732, 364);
            this.grbCalbum.TabIndex = 11;
            this.grbCalbum.TabStop = false;
            // 
            // FrmRechercheAlbum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(804, 450);
            this.Controls.Add(this.lblMessage2);
            this.Controls.Add(this.grbAlbum);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.txtAlbumRecherche);
            this.Controls.Add(this.lblRecherche2);
            this.Controls.Add(this.grbCalbum);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmRechercheAlbum";
            this.Text = "Recherche d\'Album";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmRechercheAlbum_FormClosing);
            this.Load += new System.EventHandler(this.FrmRechercheAlbum_Load);
            this.grbAlbum.ResumeLayout(false);
            this.grbAlbum.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webExtraits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picArtistes2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAlbum2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erp2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRecherche2;
        private System.Windows.Forms.TextBox txtAlbumRecherche;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.GroupBox grbAlbum;
        private System.Windows.Forms.ListBox lstAlbums2;
        private System.Windows.Forms.Label lblAlbumTrouvés;
        private System.Windows.Forms.ListBox lstTitres2;
        private System.Windows.Forms.Label lblAlbumTitre;
        private System.Windows.Forms.PictureBox picArtistes2;
        private System.Windows.Forms.PictureBox picAlbum2;
        private System.Windows.Forms.LinkLabel lklDeezerlien2;
        private System.Windows.Forms.Label lblPictureTitre2;
        private System.Windows.Forms.Label lblPictureTitre;
        private System.Windows.Forms.Button btnEcouterAlbums;
        private Microsoft.Web.WebView2.WinForms.WebView2 webExtraits;
        private System.Windows.Forms.Label lblMessage2;
        private System.Windows.Forms.ErrorProvider erp2;
        private System.Windows.Forms.GroupBox grbCalbum;
    }
}