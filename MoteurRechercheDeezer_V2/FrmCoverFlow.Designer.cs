namespace ZiKnCo_MoteurRechercheDeezer
{
    partial class FrmCoverFlow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCoverFlow));
            this.iC3DAlbums = new CDI.IndexCard3D.IC3D();
            this.lblTitre = new System.Windows.Forms.Label();
            this.lblXsurY = new System.Windows.Forms.Label();
            this.lstTitres = new System.Windows.Forms.ListBox();
            this.panListeTitres = new System.Windows.Forms.Panel();
            this.lblTitres = new System.Windows.Forms.Label();
            this.wmpLecteur = new AxWMPLib.AxWindowsMediaPlayer();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.panListeTitres.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wmpLecteur)).BeginInit();
            this.SuspendLayout();
            // 
            // iC3DAlbums
            // 
            this.iC3DAlbums.DisplayCards = 8;
            this.iC3DAlbums.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iC3DAlbums.Location = new System.Drawing.Point(1, 1);
            this.iC3DAlbums.Name = "iC3DAlbums";
            this.iC3DAlbums.Size = new System.Drawing.Size(582, 259);
            this.iC3DAlbums.TabIndex = 0;
            this.iC3DAlbums.RenderText += new CDI.IndexCard3D.IC3D.RenderTextHander(this.iC3DAlbums_RenderText);
            this.iC3DAlbums.IndexCardChanged += new CDI.IndexCard3D.IC3D.IndexCardChangedHander(this.iC3DAlbums_IndexCardChanged);
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblTitre.Location = new System.Drawing.Point(-2, 291);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(50, 17);
            this.lblTitre.TabIndex = 2;
            this.lblTitre.Text = "Titres";
            // 
            // lblXsurY
            // 
            this.lblXsurY.AutoSize = true;
            this.lblXsurY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXsurY.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblXsurY.Location = new System.Drawing.Point(528, 292);
            this.lblXsurY.Name = "lblXsurY";
            this.lblXsurY.Size = new System.Drawing.Size(55, 16);
            this.lblXsurY.TabIndex = 3;
            this.lblXsurY.Text = "X sur Y";
            this.lblXsurY.Click += new System.EventHandler(this.lblXsurY_Click);
            this.lblXsurY.MouseHover += new System.EventHandler(this.lblXsurY_MouseHover);
            // 
            // lstTitres
            // 
            this.lstTitres.FormattingEnabled = true;
            this.lstTitres.Location = new System.Drawing.Point(9, 21);
            this.lstTitres.Name = "lstTitres";
            this.lstTitres.Size = new System.Drawing.Size(120, 251);
            this.lstTitres.TabIndex = 5;
            this.lstTitres.Click += new System.EventHandler(this.lstTitres_Click);
            this.lstTitres.MouseLeave += new System.EventHandler(this.lstTitres_MouseLeave);
            // 
            // panListeTitres
            // 
            this.panListeTitres.Controls.Add(this.lblTitres);
            this.panListeTitres.Controls.Add(this.lstTitres);
            this.panListeTitres.ForeColor = System.Drawing.Color.SteelBlue;
            this.panListeTitres.Location = new System.Drawing.Point(451, 1);
            this.panListeTitres.Name = "panListeTitres";
            this.panListeTitres.Size = new System.Drawing.Size(132, 280);
            this.panListeTitres.TabIndex = 6;
            // 
            // lblTitres
            // 
            this.lblTitres.AutoSize = true;
            this.lblTitres.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitres.Location = new System.Drawing.Point(19, 5);
            this.lblTitres.Name = "lblTitres";
            this.lblTitres.Size = new System.Drawing.Size(102, 13);
            this.lblTitres.TabIndex = 6;
            this.lblTitres.Text = "Titres de l’Album";
            // 
            // wmpLecteur
            // 
            this.wmpLecteur.Enabled = true;
            this.wmpLecteur.Location = new System.Drawing.Point(1, 311);
            this.wmpLecteur.Name = "wmpLecteur";
            this.wmpLecteur.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmpLecteur.OcxState")));
            this.wmpLecteur.Size = new System.Drawing.Size(590, 45);
            this.wmpLecteur.TabIndex = 4;
            this.wmpLecteur.CurrentItemChange += new AxWMPLib._WMPOCXEvents_CurrentItemChangeEventHandler(this.wmpLecteur_CurrentItemChange);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // FrmCoverFlow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.panListeTitres);
            this.Controls.Add(this.wmpLecteur);
            this.Controls.Add(this.lblXsurY);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.iC3DAlbums);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCoverFlow";
            this.Text = "ZiK\'nCo : Affichage \"Cover Flow\"";
            this.Load += new System.EventHandler(this.FrmCoverFlow_Load);
            this.panListeTitres.ResumeLayout(false);
            this.panListeTitres.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wmpLecteur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CDI.IndexCard3D.IC3D iC3DAlbums;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label lblXsurY;
        private AxWMPLib.AxWindowsMediaPlayer wmpLecteur;
        private System.Windows.Forms.ListBox lstTitres;
        private System.Windows.Forms.Panel panListeTitres;
        private System.Windows.Forms.Label lblTitres;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}