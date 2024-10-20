using Btssio.Deezer;
using Btssio.Musique;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZiKnCo_MoteurRechercheDeezer
{
    public partial class FrmPlaylist : Form
    {

        #region Champs
        private Album selectedAlbum = new Album();
        private Artist selectedArtists = new Artist();


        private const string MESSAGE_DISCOGRAPHIE_INDISPONIBLE = "Désolé, la discographie pour '#valeur#' n'est pas disponible...";
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
        enum ModeTransfert
        {
            Un,
            Tous,
            Certains
        }
        private void transferer(ListBox lstSource, ListBox lstDestination, ModeTransfert mode)
        {
            switch(mode)
            {
                case ModeTransfert.Un: 
                        lstDestination.Items.Add(lstSource.SelectedItem); 
                        lstSource.Items.Remove(lstSource.SelectedItem);
                    break;
                
                case ModeTransfert.Tous:
                        foreach (object lstDestinations in lstSource.Items)
                        {
                            lstDestination.Items.Add(lstDestinations);
                        }
                        lstSource.Items.Clear();
                    break;

            }

            if (lstSource.Items.Count > 0)
                lstSource.SelectedIndex = 0;
                
        }
        private void boutonsTransfert_Click(object sender, EventArgs e)
        {
            Button boutonDeclencheur = (Button)(sender);
            switch (boutonDeclencheur.Name)
            {
                case "btnVersDroiteUN":
                    transferer(lstGauche, lstDroite, ModeTransfert.Un);
                    if (lstGauche.Items.Count == 0)
                    {
                        btnVersDroiteUN.Enabled = false;
                        btnVersDroiteTous.Enabled = false;
                    }
                    
                    break;

                case "btnVersDroiteTous":
                    transferer(lstGauche, lstDroite, ModeTransfert.Tous);
                    break;
                case "btnVersGaucheUn":
                    transferer(lstDroite, lstGauche, ModeTransfert.Un);
                    break;
                case "btnVersGaucheTous":
                    transferer(lstDroite, lstGauche, ModeTransfert.Tous);
                    break;
            }
        }
        #endregion




        public FrmPlaylist()
        {
            InitializeComponent();
            btnVersDroiteUN.Click += new System.EventHandler(boutonsTransfert_Click);
            btnVersGaucheUn.Click += new System.EventHandler(boutonsTransfert_Click);
            btnVersDroiteTous.Click += new System.EventHandler(boutonsTransfert_Click);
            btnVersGaucheTous.Click += new System.EventHandler(boutonsTransfert_Click);
        }

        private void lstDroite_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstDroite.Items.Count == 0)
            {
                btnVersGaucheTous.Enabled = false;
                btnVersGaucheUn.Enabled = false;
            }
            else
            {
                btnVersGaucheUn.Enabled = true;
                btnVersGaucheTous.Enabled = true;
                btnVersDroiteTous.Enabled = false;
                btnVersDroiteUN.Enabled = false;
            }

    

        }
        private void lstGauche_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstGauche.Items.Count == 0)
            {
                btnVersDroiteTous.Enabled = false;
                btnVersDroiteUN.Enabled = false;
            }
            else
            {
                btnVersDroiteUN.Enabled = true;
                btnVersDroiteTous.Enabled = true;
                btnVersGaucheTous.Enabled = false;
                btnVersGaucheUn.Enabled = false;
            }

            

            




        }

        private void FrmPlaylist_Load(object sender, EventArgs e)
        {

            for(int i=1;i<=10;i++)
            {
                lstGauche.Items.Add("Titre " + i);
            }

            lstGauche.SelectedIndex = 0;
            btnVersGaucheUn.Enabled = false;
            btnVersGaucheTous.Enabled = false;
           
        }

        

        private void btnEcouterExtraitV3_Click(object sender, EventArgs e)
        {
            if (lstDroite.Items.Count == 0)
            {
                message = MESSAGE_DISCOGRAPHIE_INDISPONIBLE.Replace("#valeur#", selectedArtists.name);
                MessageBox.Show(message, "ZiK'nCo : avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnEcouterExtraitV3.Enabled = false;
            }
            else
            {
                FrmLecteurMultimedia formulaire = new FrmLecteurMultimedia();
                foreach (Track unTrack in lstDroite.Items)
                {
                    WMPLib.IWMPMedia unPMedia = formulaire.wmpLecteur.newMedia(unTrack.preview);
                    formulaire.wmpLecteur.currentPlaylist.appendItem(unPMedia);
                }

                formulaire.Show();
                formulaire.wmpLecteur.Ctlcontrols.play();
            }
        }

        private void btnVersDroiteTous_Click(object sender, EventArgs e)
        {
            btnVersDroiteTous.Enabled = false;
            btnVersDroiteUN.Enabled = false;
        }

        private void btnVersGaucheTous_Click(object sender, EventArgs e)
        {
            btnVersGaucheUn.Enabled = false;
            btnVersGaucheTous.Enabled = false;
        }
    }
}



        
    

//Consigne Rapport de mission
//Pas de grosse taille de police 
// Format diaporama défendue


