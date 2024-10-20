using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Btssio.Musique; 
using Btssio.Deezer; 
using Btssio.Tools;
using System.Diagnostics;
using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;

namespace ZiKnCo_MoteurRechercheDeezer
{


    public partial class FrmDemarrage : Form
    {
        #region champs
        private Artist selectedArtist = new Artist();
        private  Artist selectedArtistDetails = new Artist();
        private List<Album> lesAlbums = new List<Album>();
        private Album selectedAlbum = new Album();
        private Album selectedAlbumDetails = new Album();
        private List<Track> lesTracks = new List<Track>();
        private Track selectedTrack = new Track();

        private const string MESSAGE_RECHERCHE_ARTISTE = "Recherche en cours, veuillez patienter...";
        private const string MESSAGE_SAISIE_ARTISTE = "Veuillez saisir un artiste à rechercher";

        private const string MESSAGE_ARTISTE_INCONNU = "Désolé, l'artiste '#valeur#' est inconnu sur Deezer ...";
        private const string MESSAGE_DISCOGRAPHIE_INDISPONIBLE = "Désolé, la discographie pour '#valeur#' n'est pas disponible...";
        private const string MESSAGE_CONNEXION_INTERNET = "La recherche sur le site DEEZER est impossible";
        private const string TITRE_CONNEXION_INTERNET = "Attention, la connexion Internet est inactive";
        private string message;


        #endregion

        #region Constructeurs
          

        #endregion

        #region Méthode gestionnaire d'évenement

        #region Traitement principal: Clic sur le bouton btnRechercher
        #endregion

        #region Gestion des menus
        #endregion

        #region autres
        #endregion

        #endregion

        #region méthodes
         private void rechercherArtistes()
         {
            if (txtArtisteRecherche.Text == String.Empty)
            {
                erp.SetError(txtArtisteRecherche, MESSAGE_SAISIE_ARTISTE);

            }

            else
            {
                Cursor.Current = Cursors.WaitCursor;
                lblMessage.Text = MESSAGE_RECHERCHE_ARTISTE;
                lblMessage.Refresh();
                txtArtisteRecherche.Clear();

            }
         }
        
        #endregion
        
        
        private async void FrmDemarrage_Load(object sender, EventArgs e)
        {
            if (!NetManager.isConnected())
            {
                System.Media.SystemSounds.Exclamation.Play();
                notifyIconEtat.ShowBalloonTip(500, TITRE_CONNEXION_INTERNET, MESSAGE_CONNEXION_INTERNET, ToolTipIcon.Error);
            }
            else
            {
               var jour = DateTime.Now.ToString("dd/MM/yyyy"); 
               var heure = DateTime.Now.ToString("HH:mm:ss");
               notifyIconEtat.ShowBalloonTip(500, "Bienvenue à vous", "Appli Zikn'Co Deezer lancé le" + jour + " à " + heure, ToolTipIcon.Info);


            }
            await wbRadio.EnsureCoreWebView2Async(null);
            await wbExtrait.EnsureCoreWebView2Async(null);


        }
        public FrmDemarrage()
        {
            InitializeComponent();
        }


        private void btnRechercher_Click(object sender, EventArgs e)
        {
            if (!NetManager.isConnected())
            {
                System.Media.SystemSounds.Exclamation.Play();
                notifyIconEtat.ShowBalloonTip(500, TITRE_CONNEXION_INTERNET, MESSAGE_CONNEXION_INTERNET, ToolTipIcon.Error);
            }
            else
            {
                List<Artist> lesArtistes = new List<Artist>();
                string recherche = txtArtisteRecherche.Text;
                lesArtistes = DeezerApi.getAllArtistsByName(recherche);
                rechercherArtistes();

                if (lesArtistes.Count == 0)
                {
                    message = MESSAGE_ARTISTE_INCONNU.Replace("#valeur#", recherche);
                    lblMessage.Text = message;
                    erp.SetError(txtArtisteRecherche, message);
                }

                else
                {
                    lstArtistes.DataSource = lesArtistes;
                    lstArtistes.DisplayMember = "name";

                    txtArtisteRecherche.Text = string.Empty;

                    erp.SetError(txtArtisteRecherche, String.Empty);
                    lstAlbums.SelectedIndexChanged -= new System.EventHandler(lstAlbums_SelectedIndexChanged);

                    lstAlbums.SelectedIndexChanged += new System.EventHandler(lstAlbums_SelectedIndexChanged);
                    lstAlbums_SelectedIndexChanged(lstAlbums, new EventArgs());
                    lblMessage.Text = string.Empty;
                    grbArtisteInfos.Visible = true;
                    rechercherArtistes();

                }
            }


        }
        private void lklDeezerLien_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(lklDeezerLien.Text);
        }

       
        private void txtArtisteRecherche_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return) btnRechercher.PerformClick();
        }

        private void picDeezer_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.deezer.com/fr/");
        }

        private void FrmDemarrage_Activated(object sender, EventArgs e)
        {
            txtArtisteRecherche.Focus();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

        private void lecteurMultimediaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLecteurMultimedia formulaire = new FrmLecteurMultimedia();
            formulaire.Show();
        }

        private void aProposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmApropos formulaire = new FrmApropos();
            formulaire.ShowDialog();
        }

        private void lstArtistes_SelectedIndexChanged(object sender, EventArgs e)
        {        
            selectedArtist = (Artist)lstArtistes.SelectedItem;
            lblArtisteNom.Text = selectedArtist.name;
            lklDeezerLien.Text = selectedArtist.link;
            picArtiste.ImageLocation = selectedArtist.picture;

            string urlWidget = DeezerPlugin.getUrlPluginRadio(selectedArtist.id);
            urlWidget = urlWidget.Replace("http", "https");
            wbRadio.CoreWebView2.Navigate(urlWidget);

            selectedArtistDetails = DeezerApi.getDetailsArtistById(selectedArtist.id);

            lesAlbums = selectedArtistDetails.getLesAlbums();

            lstAlbums.DataSource = lesAlbums;
            lstAlbums.DisplayMember = "title";
        }        
        
        private void lstAlbums_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedAlbum = (Album)lstAlbums.SelectedItem;
            picAlbum.ImageLocation = selectedAlbum.cover;
            selectedAlbumDetails = DeezerApi.getDetailsAlbumById(selectedAlbum.id);
            lesTracks = selectedAlbumDetails.getLesTracks();
            lstTitres.DataSource = lesTracks;
            lstTitres.DisplayMember = "titre";

        }

        private void btnEcouterExtraits_Click(object sender, EventArgs e)
        {
            Artist selectedArtistDetails = new Artist();
            selectedArtistDetails = DeezerApi.getDetailsArtistById(selectedArtist.id);
            if (selectedArtistDetails.nbAlbums == 0)
            {
                message = MESSAGE_DISCOGRAPHIE_INDISPONIBLE.Replace("#valeur#", selectedArtist.name);
                MessageBox.Show(message, "ZiK'nCo : avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnEcouterExtraits.Enabled = false;
            }
            else
            {
                FrmLecteurMultimedia formulaire = new FrmLecteurMultimedia();
                List<Album> lesAlbums = selectedArtistDetails.getLesAlbums();
                foreach (Album unAlbum in lesAlbums)
                {
                    List<Track> lesTracks = unAlbum.getLesTracks();
                    foreach (Track unTrack in lesTracks)
                    {
                        WMPLib.IWMPMedia unPMedia = formulaire.wmpLecteur.newMedia(unTrack.preview);
                        formulaire.wmpLecteur.currentPlaylist.appendItem(unPMedia);
                    }
                }
                formulaire.Show();
                formulaire.wmpLecteur.Ctlcontrols.play();
            }
        }
                    
        private void lstTitres_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedTrack = (Track)lstTitres.SelectedItem;
            string urlWidget = DeezerPlugin.getUrlPluginTrack(selectedTrack.id);
            urlWidget = urlWidget.Replace("http", "https");
            wbExtrait.CoreWebView2.Navigate(urlWidget);
        }

        private void FrmDemarrage_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Etes-vous sûr de vouloir quitter ?", "ZiK'nCo : question",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                e.Cancel = true;
        }

        private void rechercheDAlbumsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRechercheAlbum formulaire = new FrmRechercheAlbum();
            formulaire.Show();
        }

        private void lstAlbums_DoubleClick(object sender, EventArgs e)
        {
            FrmPlaylist formulaire = new FrmPlaylist();
            List<Track> lesTracks = selectedAlbum.getLesTracks(); 
            foreach (Track unTrack in lesTracks)
            { 
                formulaire.lstGauche.Items.Add(unTrack);
                formulaire.lstGauche.DisplayMember = "title"; 
            }
            formulaire.Show(); 
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            if (FrmCoverFlow.ActiveForm != null)
            {
                FrmCoverFlow formulaire1 = new FrmCoverFlow();
                formulaire1.selectedArtistDetails = DeezerApi.getDetailsArtistById(selectedArtist.id);
                formulaire1.Show();

                Cursor.Current = Cursors.Default;

            }
            if (selectedAlbumDetails.theArtist.nbAlbums == 0)
            {
                picIpod.Enabled = false;
            }
        }

        private void ouvrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void masquerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void quitterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtArtisteRecherche_TextChanged(object sender, EventArgs e)
        {

        }
    }
}                


        


       

        
    
    


    






