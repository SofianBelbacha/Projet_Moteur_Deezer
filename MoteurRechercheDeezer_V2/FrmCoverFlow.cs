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
using System.Net;
using CDI.IndexCard3D;
using Track = Btssio.Musique.Track;

namespace ZiKnCo_MoteurRechercheDeezer
{
    public partial class FrmCoverFlow : Form
    {
        #region champs
        public Artist selectedArtist = new Artist();
        private List<Album> lesAlbums = new List<Album>();
        public Artist selectedArtistDetails = new Artist();
        private Track selectedTrack = new Track();
        List<Track>lesTracks = new List<Track>();
        private Album selectedAlbums = new Album();
        private Album selectedAlbumDetails = new Album();
        private Album unAlbum = new Album();




        #endregion

        #region Méthode

        private void chargerTitreSelectedAlbum()
        {
            Cursor.Current = Cursors.WaitCursor;

            Album selectedAlbum = lesAlbums.ElementAt(iC3DAlbums.ActiveCard - 1);
            lesTracks = selectedAlbum.getLesTracks();
            lstTitres.DataSource = lesTracks;
            lstTitres.DisplayMember = "titre";
            int indexTitre = 1;
            wmpLecteur.currentPlaylist.clear();

            foreach (Track unTrack in lesTracks)
            {
                WMPLib.IWMPMedia unPMedia = wmpLecteur.newMedia(unTrack.preview);
                unPMedia.setItemInfo("nomTitre", unTrack.title);
                unPMedia.setItemInfo("xSurY", indexTitre.ToString());
                wmpLecteur.currentPlaylist.appendItem(unPMedia);
            
                indexTitre++;            
            }
            UseWaitCursor = default;
            wmpLecteur.Ctlcontrols.play();



        }
        #endregion
        public FrmCoverFlow()
        {
            InitializeComponent();
        }

        private void FrmCoverFlow_Load(object sender, EventArgs e)
        {
            lesAlbums = selectedArtistDetails.getLesAlbums();
            WebClient wClient = new WebClient();
            string nomImage;
            int i;
            for (i = 0; i < lesAlbums.Count; i++)
            {
                nomImage = "image" + i + ".jpg";
                wClient.DownloadFile(lesAlbums[i].cover, nomImage);
                Card c = new Card(lesAlbums[i].title, nomImage);
                iC3DAlbums.IndexCards.Add(c);
            }
            iC3DAlbums.IndexCards.LoadTexturesToMemory();
            chargerTitreSelectedAlbum();
        }

        private void iC3DAlbums_RenderText(object sender, EventArgs e)
        {
            Font fntNom = new Font("Arial", 30, FontStyle.Regular, GraphicsUnit.Pixel);
            Font fntTitre = new Font("Arial", 20, FontStyle.Italic, GraphicsUnit.Pixel);

            string titre = iC3DAlbums.IndexCards.ElementAt(iC3DAlbums.ActiveCard - 1).Title;

            iC3DAlbums.DrawText(0, iC3DAlbums.Height - 75, selectedArtistDetails.name, IC3D.TextAlignment.Center, fntNom, Color.FloralWhite);
            iC3DAlbums.DrawText(0, iC3DAlbums.Height - 45, titre, IC3D.TextAlignment.Center, fntTitre, Color.Wheat);

        }

        private void iC3DAlbums_IndexCardChanged(object sender, IndexCardEventArgs e)
        {
            chargerTitreSelectedAlbum();
        }

        private void wmpLecteur_CurrentItemChange(object sender, AxWMPLib._WMPOCXEvents_CurrentItemChangeEvent e)
        {

            lblTitre.Text = wmpLecteur.currentMedia.getItemInfo("nomTitre");
            lblXsurY.Text = wmpLecteur.currentMedia.getItemInfo("XSury") + "sur" + lesTracks.Count.ToString();
            if(lstTitres.SelectedIndex >= 1)            
            {
                lstTitres.SelectedIndex = 0;
                lstTitres.SelectedIndex = Convert.ToInt32(wmpLecteur.currentMedia.getItemInfo("XSury"));                
            }
            
        }

        private void lblXsurY_MouseHover(object sender, EventArgs e)
        {
            panListeTitres.Visible = true;
        }

        private void lstTitres_MouseLeave(object sender, EventArgs e)
        {
            panListeTitres.Visible = false;
        }

        private void lstTitres_Click(object sender, EventArgs e)
        {
            WMPLib.IWMPMedia unMedia = wmpLecteur.currentPlaylist.get_Item(lstTitres.SelectedIndex);
            wmpLecteur.Ctlcontrols.playItem(unMedia);
        }

        private void lblXsurY_Click(object sender, EventArgs e)
        {

        }
    }
}
