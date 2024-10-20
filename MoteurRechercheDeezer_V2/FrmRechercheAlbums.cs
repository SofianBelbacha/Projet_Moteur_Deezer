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
    public partial class FrmRechercheAlbum : Form
    {
        #region champs
        private Artist selectedArtists = new Artist();
        private Artist selectedArtistDetails = new Artist();
        private List<Album> unAlbums = new List<Album>();
        private Album selectedAlbum = new Album();
        private Album selectedAlbumDetails = new Album();
        private List<Track> lesTracks = new List<Track>();
        private Track selectedTrack = new Track();


        private const string MESSAGE_RECHERCHE_ARTISTE = "Recherche en cours, veuillez patienter...";
        private const string MESSAGE_SAISIE_ARTISTE = "Veuillez saisir un album à rechercher";

        private const string MESSAGE_ARTISTE_INCONNU = "Désolé, l'album '#valeur#' est inconnu sur Deezer ...";
        private const string MESSAGE_DISCOGRAPHIE_INDISPONIBLE = "Désolé, la discographie pour '#valeur#' n'est pas disponible...";
        private string message;


        #endregion

        #region Méthodes
        private void rechercherNewArtistes()
        {
            if (txtAlbumRecherche.Text == String.Empty)
            {
                erp2.SetError(txtAlbumRecherche, MESSAGE_SAISIE_ARTISTE);

            }

            else
            {
                Cursor.Current = Cursors.WaitCursor;
                lblMessage2.Text = MESSAGE_RECHERCHE_ARTISTE;
                lblMessage2.Refresh();
                txtAlbumRecherche.Clear();

            }
        }
        #endregion
        public FrmRechercheAlbum()
        {
            InitializeComponent();
        }

        private void lstTitres2_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedTrack = (Track)lstTitres2.SelectedItem;
            string urlWidget = DeezerPlugin.getUrlPluginTrack(selectedTrack.id);
            urlWidget = urlWidget.Replace("http", "https");
            webExtraits.CoreWebView2.Navigate(urlWidget);
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            List<Album> unalbums = new List<Album>();
            string recherche = txtAlbumRecherche.Text;
            unalbums = DeezerApi.getAllAlbumsByName(recherche);
            rechercherNewArtistes();


            if (unalbums.Count == 0)
            {
                message = MESSAGE_ARTISTE_INCONNU.Replace("#valeur#", recherche);
                lblMessage2.Text = message;
                erp2.SetError(txtAlbumRecherche, message);
            }
            else
            {
                lstAlbums2.DataSource = unalbums;
                lstAlbums2.DisplayMember = "Titre";
                txtAlbumRecherche.Text = string.Empty;

                erp2.SetError(txtAlbumRecherche, String.Empty);
                //lstAlbums2.SelectedIndexChanged -= new System.EventHandler(lstAlbums2_SelectedIndexChanged);
                //lstAlbums2.SelectedIndexChanged += new System.EventHandler(lstAlbums2_SelectedIndexChanged);
                //lstAlbums2_SelectedIndexChanged(lstAlbums2, new EventArgs());
                lblMessage2.Text = string.Empty;
                grbAlbum.Visible = true;
                rechercherNewArtistes();



            }


        }

        private void lstAlbums2_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedAlbum = (Album)lstAlbums2.SelectedItem;
            picAlbum2.ImageLocation = selectedAlbum.cover;
            lklDeezerlien2.Text = selectedAlbum.theArtist.link;
            selectedAlbumDetails = DeezerApi.getDetailsAlbumById(selectedAlbum.id);
            lesTracks = selectedAlbumDetails.getLesTracks();
            lstTitres2.DataSource = lesTracks;
            lstTitres2.DisplayMember = "titre";
            lblPictureTitre.Text = selectedAlbum.title;

            lblPictureTitre2.Text = selectedAlbum.theArtist.name;
            picArtistes2.ImageLocation = selectedAlbum.theArtist.picture;
            
        }

        private void btnEcouterAlbums_Click(object sender, EventArgs e)
        {
            Album selectedAlbumDetails = new Album();
            selectedAlbumDetails = DeezerApi.getDetailsAlbumById(selectedAlbum.id);
            if (selectedAlbumDetails.theArtist.nbAlbums == 0)
            {
                message = MESSAGE_DISCOGRAPHIE_INDISPONIBLE.Replace("#valeur#", selectedArtists.name);
                MessageBox.Show(message, "ZiK'nCo : avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnEcouterAlbums.Enabled = false;
            }
            else
            {
                FrmLecteurMultimedia formulaire = new FrmLecteurMultimedia();
                List<Track> lesTracks = selectedAlbumDetails.getLesTracks();
                foreach (Track unTrack in lesTracks)
                {
                    WMPLib.IWMPMedia unPMedia = formulaire.wmpLecteur.newMedia(unTrack.preview);
                    formulaire.wmpLecteur.currentPlaylist.appendItem(unPMedia);
                }
                
                formulaire.Show();
                formulaire.wmpLecteur.Ctlcontrols.play();
            }
        }

        private async void FrmRechercheAlbum_Load(object sender, EventArgs e)
        {
            await webExtraits.EnsureCoreWebView2Async(null);
        }

        private void FrmRechercheAlbum_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Etes-vous sûr de vouloir quitter ?", "ZiK'nCo : question",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                e.Cancel = true;
        }

        private void txtAlbumRecherche_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return) btnEnter.PerformClick();

        }

        private void lklDeezerlien2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(lklDeezerlien2.Text);

        }

        private void grbAlbum_Enter(object sender, EventArgs e)
        {

        }
    }
}
