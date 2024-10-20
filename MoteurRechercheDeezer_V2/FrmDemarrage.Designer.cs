namespace ZiKnCo_MoteurRechercheDeezer
{
    partial class FrmDemarrage
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDemarrage));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fichierToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lecteurMultimediaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.aProposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rechercheToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rechercheDAlbumsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblArtisteRecherche = new System.Windows.Forms.Label();
            this.txtArtisteRecherche = new System.Windows.Forms.TextBox();
            this.btnRechercher = new System.Windows.Forms.Button();
            this.lblArtisteTrouve = new System.Windows.Forms.Label();
            this.lblArtisteNom = new System.Windows.Forms.Label();
            this.lblLien = new System.Windows.Forms.Label();
            this.lklDeezerLien = new System.Windows.Forms.LinkLabel();
            this.discographie = new System.Windows.Forms.TabControl();
            this.tbpArtiste = new System.Windows.Forms.TabPage();
            this.grbArtisteInfos = new System.Windows.Forms.GroupBox();
            this.picIpod = new System.Windows.Forms.PictureBox();
            this.lstArtistes = new System.Windows.Forms.ListBox();
            this.btnEcouterExtraits = new System.Windows.Forms.Button();
            this.picArtiste = new System.Windows.Forms.PictureBox();
            this.tbpDiscographie = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.wbExtrait = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstTitres = new System.Windows.Forms.ListBox();
            this.picAlbum = new System.Windows.Forms.PictureBox();
            this.lstAlbums = new System.Windows.Forms.ListBox();
            this.tbpRadio = new System.Windows.Forms.TabPage();
            this.wbRadio = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.lblMessage = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.erp = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTipAppli = new System.Windows.Forms.ToolTip(this.components);
            this.notifyIconEtat = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStripNotifications = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ouvrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masquerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.picDeezer = new System.Windows.Forms.PictureBox();
            this.picBanniere = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.discographie.SuspendLayout();
            this.tbpArtiste.SuspendLayout();
            this.grbArtisteInfos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIpod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picArtiste)).BeginInit();
            this.tbpDiscographie.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wbExtrait)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAlbum)).BeginInit();
            this.tbpRadio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wbRadio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.contextMenuStripNotifications.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDeezer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBanniere)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.fichierToolStripMenuItem1,
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.rechercheToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(610, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitterToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "&Fichier";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.quitterToolStripMenuItem.Text = "&Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // fichierToolStripMenuItem1
            // 
            this.fichierToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lecteurMultimediaToolStripMenuItem});
            this.fichierToolStripMenuItem1.Name = "fichierToolStripMenuItem1";
            this.fichierToolStripMenuItem1.Size = new System.Drawing.Size(45, 20);
            this.fichierToolStripMenuItem1.Text = "&Outil";
            // 
            // lecteurMultimediaToolStripMenuItem
            // 
            this.lecteurMultimediaToolStripMenuItem.Name = "lecteurMultimediaToolStripMenuItem";
            this.lecteurMultimediaToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.lecteurMultimediaToolStripMenuItem.Text = "&Lecteur Multimedia";
            this.lecteurMultimediaToolStripMenuItem.Click += new System.EventHandler(this.lecteurMultimediaToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(19, 20);
            this.toolStripMenuItem1.Text = "&";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aProposToolStripMenuItem});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(24, 20);
            this.toolStripMenuItem2.Text = "?";
            // 
            // aProposToolStripMenuItem
            // 
            this.aProposToolStripMenuItem.Name = "aProposToolStripMenuItem";
            this.aProposToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.aProposToolStripMenuItem.Text = "A &Propos";
            this.aProposToolStripMenuItem.Click += new System.EventHandler(this.aProposToolStripMenuItem_Click);
            // 
            // rechercheToolStripMenuItem
            // 
            this.rechercheToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rechercheDAlbumsToolStripMenuItem});
            this.rechercheToolStripMenuItem.Name = "rechercheToolStripMenuItem";
            this.rechercheToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.rechercheToolStripMenuItem.Text = "&Recherche";
            // 
            // rechercheDAlbumsToolStripMenuItem
            // 
            this.rechercheDAlbumsToolStripMenuItem.Name = "rechercheDAlbumsToolStripMenuItem";
            this.rechercheDAlbumsToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.rechercheDAlbumsToolStripMenuItem.Text = "Recherche d’&Albums";
            this.rechercheDAlbumsToolStripMenuItem.Click += new System.EventHandler(this.rechercheDAlbumsToolStripMenuItem_Click);
            // 
            // lblArtisteRecherche
            // 
            this.lblArtisteRecherche.AutoSize = true;
            this.lblArtisteRecherche.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblArtisteRecherche.ForeColor = System.Drawing.Color.White;
            this.lblArtisteRecherche.Location = new System.Drawing.Point(12, 169);
            this.lblArtisteRecherche.Name = "lblArtisteRecherche";
            this.lblArtisteRecherche.Size = new System.Drawing.Size(104, 15);
            this.lblArtisteRecherche.TabIndex = 3;
            this.lblArtisteRecherche.Text = "Artiste recherché :";
            // 
            // txtArtisteRecherche
            // 
            this.txtArtisteRecherche.Location = new System.Drawing.Point(122, 164);
            this.txtArtisteRecherche.Name = "txtArtisteRecherche";
            this.txtArtisteRecherche.Size = new System.Drawing.Size(217, 20);
            this.txtArtisteRecherche.TabIndex = 4;
            this.txtArtisteRecherche.TextChanged += new System.EventHandler(this.txtArtisteRecherche_TextChanged);
            this.txtArtisteRecherche.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtArtisteRecherche_KeyPress);
            // 
            // btnRechercher
            // 
            this.btnRechercher.Location = new System.Drawing.Point(355, 162);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(41, 23);
            this.btnRechercher.TabIndex = 5;
            this.btnRechercher.Text = "GO !";
            this.btnRechercher.UseVisualStyleBackColor = true;
            this.btnRechercher.Click += new System.EventHandler(this.btnRechercher_Click);
            // 
            // lblArtisteTrouve
            // 
            this.lblArtisteTrouve.AutoSize = true;
            this.lblArtisteTrouve.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblArtisteTrouve.Location = new System.Drawing.Point(7, 16);
            this.lblArtisteTrouve.Name = "lblArtisteTrouve";
            this.lblArtisteTrouve.Size = new System.Drawing.Size(122, 18);
            this.lblArtisteTrouve.TabIndex = 0;
            this.lblArtisteTrouve.Text = " Artistes trouvés: ";
            // 
            // lblArtisteNom
            // 
            this.lblArtisteNom.AutoSize = true;
            this.lblArtisteNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblArtisteNom.Location = new System.Drawing.Point(331, 16);
            this.lblArtisteNom.Name = "lblArtisteNom";
            this.lblArtisteNom.Size = new System.Drawing.Size(59, 25);
            this.lblArtisteNom.TabIndex = 1;
            this.lblArtisteNom.Text = "NOM";
            // 
            // lblLien
            // 
            this.lblLien.AutoSize = true;
            this.lblLien.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblLien.Location = new System.Drawing.Point(403, 16);
            this.lblLien.Name = "lblLien";
            this.lblLien.Size = new System.Drawing.Size(130, 18);
            this.lblLien.TabIndex = 2;
            this.lblLien.Text = "Lien Direct Deezer";
            // 
            // lklDeezerLien
            // 
            this.lklDeezerLien.AutoSize = true;
            this.lklDeezerLien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lklDeezerLien.Location = new System.Drawing.Point(333, 162);
            this.lklDeezerLien.Name = "lklDeezerLien";
            this.lklDeezerLien.Size = new System.Drawing.Size(115, 16);
            this.lklDeezerLien.TabIndex = 4;
            this.lklDeezerLien.TabStop = true;
            this.lklDeezerLien.Text = "Lien direct Deezer";
            this.lklDeezerLien.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklDeezerLien_LinkClicked);
            // 
            // discographie
            // 
            this.discographie.Controls.Add(this.tbpArtiste);
            this.discographie.Controls.Add(this.tbpDiscographie);
            this.discographie.Controls.Add(this.tbpRadio);
            this.discographie.Location = new System.Drawing.Point(15, 206);
            this.discographie.Name = "discographie";
            this.discographie.SelectedIndex = 0;
            this.discographie.Size = new System.Drawing.Size(553, 213);
            this.discographie.TabIndex = 6;
            this.discographie.TabStop = false;
            // 
            // tbpArtiste
            // 
            this.tbpArtiste.Controls.Add(this.grbArtisteInfos);
            this.tbpArtiste.Location = new System.Drawing.Point(4, 22);
            this.tbpArtiste.Name = "tbpArtiste";
            this.tbpArtiste.Padding = new System.Windows.Forms.Padding(3);
            this.tbpArtiste.Size = new System.Drawing.Size(545, 187);
            this.tbpArtiste.TabIndex = 0;
            this.tbpArtiste.Text = "Infos Artiste";
            this.tbpArtiste.UseVisualStyleBackColor = true;
            // 
            // grbArtisteInfos
            // 
            this.grbArtisteInfos.Controls.Add(this.picIpod);
            this.grbArtisteInfos.Controls.Add(this.lstArtistes);
            this.grbArtisteInfos.Controls.Add(this.btnEcouterExtraits);
            this.grbArtisteInfos.Controls.Add(this.picArtiste);
            this.grbArtisteInfos.Controls.Add(this.lblArtisteNom);
            this.grbArtisteInfos.Controls.Add(this.lklDeezerLien);
            this.grbArtisteInfos.Controls.Add(this.lblArtisteTrouve);
            this.grbArtisteInfos.Controls.Add(this.lblLien);
            this.grbArtisteInfos.Location = new System.Drawing.Point(0, 6);
            this.grbArtisteInfos.Name = "grbArtisteInfos";
            this.grbArtisteInfos.Size = new System.Drawing.Size(539, 178);
            this.grbArtisteInfos.TabIndex = 6;
            this.grbArtisteInfos.TabStop = false;
            this.grbArtisteInfos.Text = "Information Deezer";
            this.grbArtisteInfos.Visible = false;
            // 
            // picIpod
            // 
            this.picIpod.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picIpod.Image = global::ZiKnCo_MoteurRechercheDeezer.Properties.Resources.ipod;
            this.picIpod.Location = new System.Drawing.Point(189, 149);
            this.picIpod.Name = "picIpod";
            this.picIpod.Size = new System.Drawing.Size(60, 29);
            this.picIpod.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIpod.TabIndex = 8;
            this.picIpod.TabStop = false;
            this.toolTipAppli.SetToolTip(this.picIpod, ": Accès au COVER FLOW (type IPOD...)");
            this.picIpod.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lstArtistes
            // 
            this.lstArtistes.FormattingEnabled = true;
            this.lstArtistes.Location = new System.Drawing.Point(10, 38);
            this.lstArtistes.Name = "lstArtistes";
            this.lstArtistes.Size = new System.Drawing.Size(215, 108);
            this.lstArtistes.TabIndex = 7;
            this.lstArtistes.SelectedIndexChanged += new System.EventHandler(this.lstArtistes_SelectedIndexChanged);
            // 
            // btnEcouterExtraits
            // 
            this.btnEcouterExtraits.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnEcouterExtraits.Location = new System.Drawing.Point(9, 149);
            this.btnEcouterExtraits.Name = "btnEcouterExtraits";
            this.btnEcouterExtraits.Size = new System.Drawing.Size(174, 23);
            this.btnEcouterExtraits.TabIndex = 6;
            this.btnEcouterExtraits.Text = "&Ecouter tous les extraits musicaux...";
            this.btnEcouterExtraits.UseVisualStyleBackColor = true;
            this.btnEcouterExtraits.Click += new System.EventHandler(this.btnEcouterExtraits_Click);
            // 
            // picArtiste
            // 
            this.picArtiste.Location = new System.Drawing.Point(336, 44);
            this.picArtiste.Name = "picArtiste";
            this.picArtiste.Size = new System.Drawing.Size(119, 115);
            this.picArtiste.TabIndex = 5;
            this.picArtiste.TabStop = false;
            // 
            // tbpDiscographie
            // 
            this.tbpDiscographie.Controls.Add(this.panel1);
            this.tbpDiscographie.Location = new System.Drawing.Point(4, 22);
            this.tbpDiscographie.Name = "tbpDiscographie";
            this.tbpDiscographie.Padding = new System.Windows.Forms.Padding(3);
            this.tbpDiscographie.Size = new System.Drawing.Size(545, 187);
            this.tbpDiscographie.TabIndex = 2;
            this.tbpDiscographie.Text = "Discographie";
            this.tbpDiscographie.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.wbExtrait);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lstTitres);
            this.panel1.Controls.Add(this.picAlbum);
            this.panel1.Controls.Add(this.lstAlbums);
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(516, 180);
            this.panel1.TabIndex = 4;
            // 
            // wbExtrait
            // 
            this.wbExtrait.AllowExternalDrop = true;
            this.wbExtrait.CreationProperties = null;
            this.wbExtrait.DefaultBackgroundColor = System.Drawing.Color.White;
            this.wbExtrait.Location = new System.Drawing.Point(7, 108);
            this.wbExtrait.Name = "wbExtrait";
            this.wbExtrait.Size = new System.Drawing.Size(509, 69);
            this.wbExtrait.TabIndex = 7;
            this.wbExtrait.ZoomFactor = 1D;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(355, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Titres...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Albums :";
            // 
            // lstTitres
            // 
            this.lstTitres.FormattingEnabled = true;
            this.lstTitres.Location = new System.Drawing.Point(355, 18);
            this.lstTitres.Name = "lstTitres";
            this.lstTitres.Size = new System.Drawing.Size(147, 82);
            this.lstTitres.TabIndex = 4;
            this.lstTitres.SelectedIndexChanged += new System.EventHandler(this.lstTitres_SelectedIndexChanged);
            // 
            // picAlbum
            // 
            this.picAlbum.Location = new System.Drawing.Point(1, 18);
            this.picAlbum.Name = "picAlbum";
            this.picAlbum.Size = new System.Drawing.Size(114, 84);
            this.picAlbum.TabIndex = 0;
            this.picAlbum.TabStop = false;
            // 
            // lstAlbums
            // 
            this.lstAlbums.FormattingEnabled = true;
            this.lstAlbums.Location = new System.Drawing.Point(126, 20);
            this.lstAlbums.Name = "lstAlbums";
            this.lstAlbums.Size = new System.Drawing.Size(207, 82);
            this.lstAlbums.TabIndex = 5;
            this.lstAlbums.SelectedIndexChanged += new System.EventHandler(this.lstAlbums_SelectedIndexChanged);
            this.lstAlbums.DoubleClick += new System.EventHandler(this.lstAlbums_DoubleClick);
            // 
            // tbpRadio
            // 
            this.tbpRadio.Controls.Add(this.wbRadio);
            this.tbpRadio.Location = new System.Drawing.Point(4, 22);
            this.tbpRadio.Name = "tbpRadio";
            this.tbpRadio.Padding = new System.Windows.Forms.Padding(3);
            this.tbpRadio.Size = new System.Drawing.Size(545, 187);
            this.tbpRadio.TabIndex = 1;
            this.tbpRadio.Text = "Radio Artiste";
            this.tbpRadio.UseVisualStyleBackColor = true;
            // 
            // wbRadio
            // 
            this.wbRadio.AllowExternalDrop = true;
            this.wbRadio.CreationProperties = null;
            this.wbRadio.DefaultBackgroundColor = System.Drawing.Color.White;
            this.wbRadio.Location = new System.Drawing.Point(0, 36);
            this.wbRadio.Name = "wbRadio";
            this.wbRadio.Size = new System.Drawing.Size(533, 90);
            this.wbRadio.TabIndex = 1;
            this.wbRadio.ZoomFactor = 1D;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblMessage.Location = new System.Drawing.Point(119, 190);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 13);
            this.lblMessage.TabIndex = 7;
            // 
            // erp
            // 
            this.erp.ContainerControl = this;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // toolTipAppli
            // 
            this.toolTipAppli.IsBalloon = true;
            this.toolTipAppli.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipAppli.ToolTipTitle = "Pour info :";
            // 
            // notifyIconEtat
            // 
            this.notifyIconEtat.ContextMenuStrip = this.contextMenuStripNotifications;
            this.notifyIconEtat.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconEtat.Icon")));
            this.notifyIconEtat.Text = "ZiK\'nCo - Moteur de recherche DEEZER";
            this.notifyIconEtat.Visible = true;
            // 
            // contextMenuStripNotifications
            // 
            this.contextMenuStripNotifications.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ouvrirToolStripMenuItem,
            this.masquerToolStripMenuItem,
            this.quitterToolStripMenuItem1});
            this.contextMenuStripNotifications.Name = "contextMenuStrip1";
            this.contextMenuStripNotifications.Size = new System.Drawing.Size(121, 70);
            // 
            // ouvrirToolStripMenuItem
            // 
            this.ouvrirToolStripMenuItem.Image = global::ZiKnCo_MoteurRechercheDeezer.Properties.Resources.On;
            this.ouvrirToolStripMenuItem.Name = "ouvrirToolStripMenuItem";
            this.ouvrirToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.ouvrirToolStripMenuItem.Text = "Ouvrir";
            this.ouvrirToolStripMenuItem.Click += new System.EventHandler(this.ouvrirToolStripMenuItem_Click);
            // 
            // masquerToolStripMenuItem
            // 
            this.masquerToolStripMenuItem.Image = global::ZiKnCo_MoteurRechercheDeezer.Properties.Resources.MasqueZ;
            this.masquerToolStripMenuItem.Name = "masquerToolStripMenuItem";
            this.masquerToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.masquerToolStripMenuItem.Text = "Masquer";
            this.masquerToolStripMenuItem.Click += new System.EventHandler(this.masquerToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem1
            // 
            this.quitterToolStripMenuItem1.Image = global::ZiKnCo_MoteurRechercheDeezer.Properties.Resources.Off;
            this.quitterToolStripMenuItem1.Name = "quitterToolStripMenuItem1";
            this.quitterToolStripMenuItem1.Size = new System.Drawing.Size(120, 22);
            this.quitterToolStripMenuItem1.Text = "Quitter";
            this.quitterToolStripMenuItem1.Click += new System.EventHandler(this.quitterToolStripMenuItem1_Click);
            // 
            // picDeezer
            // 
            this.picDeezer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picDeezer.BackgroundImage")));
            this.picDeezer.Location = new System.Drawing.Point(441, 151);
            this.picDeezer.Name = "picDeezer";
            this.picDeezer.Size = new System.Drawing.Size(127, 54);
            this.picDeezer.TabIndex = 2;
            this.picDeezer.TabStop = false;
            this.picDeezer.Click += new System.EventHandler(this.picDeezer_Click);
            // 
            // picBanniere
            // 
            this.picBanniere.BackColor = System.Drawing.Color.White;
            this.picBanniere.Image = ((System.Drawing.Image)(resources.GetObject("picBanniere.Image")));
            this.picBanniere.Location = new System.Drawing.Point(12, 37);
            this.picBanniere.Name = "picBanniere";
            this.picBanniere.Size = new System.Drawing.Size(580, 77);
            this.picBanniere.TabIndex = 1;
            this.picBanniere.TabStop = false;
            // 
            // FrmDemarrage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.ClientSize = new System.Drawing.Size(610, 487);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.discographie);
            this.Controls.Add(this.btnRechercher);
            this.Controls.Add(this.txtArtisteRecherche);
            this.Controls.Add(this.lblArtisteRecherche);
            this.Controls.Add(this.picDeezer);
            this.Controls.Add(this.picBanniere);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmDemarrage";
            this.Text = "Moteur de recherche DEEZER:Version1";
            this.Activated += new System.EventHandler(this.FrmDemarrage_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmDemarrage_FormClosing);
            this.Load += new System.EventHandler(this.FrmDemarrage_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.discographie.ResumeLayout(false);
            this.tbpArtiste.ResumeLayout(false);
            this.grbArtisteInfos.ResumeLayout(false);
            this.grbArtisteInfos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIpod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picArtiste)).EndInit();
            this.tbpDiscographie.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wbExtrait)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAlbum)).EndInit();
            this.tbpRadio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.wbRadio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.contextMenuStripNotifications.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picDeezer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBanniere)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lecteurMultimediaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem aProposToolStripMenuItem;
        private System.Windows.Forms.PictureBox picBanniere;
        private System.Windows.Forms.PictureBox picDeezer;
        private System.Windows.Forms.Label lblArtisteRecherche;
        private System.Windows.Forms.TextBox txtArtisteRecherche;
        private System.Windows.Forms.Button btnRechercher;
        private System.Windows.Forms.Label lblArtisteTrouve;
        private System.Windows.Forms.Label lblArtisteNom;
        private System.Windows.Forms.Label lblLien;
        private System.Windows.Forms.LinkLabel lklDeezerLien;
        private System.Windows.Forms.PictureBox picArtiste;
        private System.Windows.Forms.TabControl discographie;
        private System.Windows.Forms.TabPage tbpArtiste;
        private System.Windows.Forms.TabPage tbpRadio;
        private System.Windows.Forms.GroupBox grbArtisteInfos;
        private System.Windows.Forms.ListBox lstArtistes;
        private System.Windows.Forms.Button btnEcouterExtraits;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.TabPage tbpDiscographie;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picAlbum;
        private System.Windows.Forms.ListBox lstTitres;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox lstAlbums;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider erp;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Microsoft.Web.WebView2.WinForms.WebView2 wbExtrait;
        private Microsoft.Web.WebView2.WinForms.WebView2 wbRadio;
        private System.Windows.Forms.ToolStripMenuItem rechercheToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rechercheDAlbumsToolStripMenuItem;
        private System.Windows.Forms.PictureBox picIpod;
        private System.Windows.Forms.ToolTip toolTipAppli;
        private System.Windows.Forms.NotifyIcon notifyIconEtat;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripNotifications;
        private System.Windows.Forms.ToolStripMenuItem ouvrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masquerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem1;
    }
}

