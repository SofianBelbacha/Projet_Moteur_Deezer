using ZiKnCo_MoteurRechercheDeezer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Btssio.Musique;
using Btssio.Deezer; 
using Btssio.Tools;

namespace ZiKnCo_MoteurRechercheDeezer
{
    internal static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //DeezerApi.modeLocalTaupe = true;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmDemarrage());
            //Application.Run(new FrmPlaylist());
            //Application.Run(new FrmCoverFlow());    



            #region Tests V2 de Méthodes dans la fenêtre de sortie
            //List<Artist> lesArtistes = new List<Artist>();
            //DeezerApi.discoComplete = true;
            //string recherche = "bob";
            //lesArtistes = DeezerApi.getAllArtistsByName(recherche);

            //Console.WriteLine(lesArtistes[0].name);
            //Console.WriteLine(lesArtistes[1].name);
            //Console.WriteLine(lesArtistes[3].name);


            //int i = 0;
            //for (i = 0; i < lesArtistes.Count; i++)
            //{
            //    Console.WriteLine(lesArtistes[i].name);
            //}
            ////utiliser seulement sur toutes les artistes//
            //foreach (Artist unArtiste in lesArtistes)
            //{
            //    Console.WriteLine(unArtiste.name);
            //}
            //i = 0;
            //while (i< lesArtistes.Count -1)
            //{
            //   Console.WriteLine(lesArtistes[i].name);
            //    i++;
            //}
            //i = 0;
            //do
            //{
            //    Console.WriteLine(lesArtistes[i].name);
            //    i++;
            //}
            //while (i < lesArtistes.Count);





            #endregion
            #region NAVIGATION DANS LA DLL ET STRUCTURE REPETITIVE

            #endregion
            #region NAVIGATION DANS LA DLL
            #endregion
            #region EXERCICE 1 : Afficher l'image du premier artiste trouvé pour le nom « vaughan »

            //Artist theArtist = DeezerApi.getFirstArtistByName("vaughan");
            //Console.WriteLine(theArtist.picture);
            #endregion
            #region EXERCICE 2 : Afficher le titre du premier album trouvé par Deezer pour le nom «djangology »
            //List<Album> lesAlbums = DeezerApi.getAllAlbumsByName("djangology");
            //Album premierAlbum = lesAlbums[0];
            //Console.WriteLine(premierAlbum.title);
            #endregion
            #region  EXERCICE 3 : Afficher le nom de l’artiste correspondant à l’exercice 2

            //Console.WriteLine (premierAlbum.theArtist.name);
            //ou
            //Artist theArtist = premierAlbum.theArtist;
            //console.Writline ( the Artist.name);
            #endregion
            #region EXERCICE 4 : Afficher le nom de l’artiste du premier Track nommé « Minor Swing » (2 solutions de navigation possibles)
            //List<Track> lesTrack = DeezerApi.getAllTracksByName("Minor Swing");
            //Console.WriteLine(lesTrack[0].theAlbum.theArtist.name);

            #endregion
            #region ➢ STRUCTURES REPETITIVES (BOUCLES)
            //Track premierTrack = lesTrack[0];
            //Album albumDuTrack = premierTrack.theAlbum;

            #endregion
            #region  EXERCICE 1 : Afficher toutes les couvertures d'albums de nom "Bande Originale"
            //List<Album> lesAlbums = DeezerApi.getAllAlbumsByName("Bande Originale");
            //foreach (Album unalbum in lesAlbums)
            //{
            //    Console.WriteLine(unalbum.cover);
            //}
            #endregion
            #region EXERCICE 1bis : idem EXERCICE 1 mais avec les 3 premiers albums trouvés
            //int n
            //for (n = 0; i < 3; n++)
            //{
            //    Console.WriteLine(lesAlbums[n].cover);
            //}
            #endregion
            #region  EXERCICE 1ter : idem EXERCICE 1bis mais en utilisant l’instruction répétitive "while"
            // int i = 0;
            //while (i < 3 )
            //{
            //    Console.WriteLine(lesAlbums[n].cover);
            //    n++;
            //}
            #endregion
            #region EXERCICE 2 : Afficher tous les mp3 de l'album le plus récent de STROMAE (premier trouvé par Deezer)
            //List<Artist> lesArtiste  = new List<Artist>();
            //lesArtiste = DeezerApi.getFirstArtistByName("STROMAE");

            //foreach (Track untrack in lesTRACKS)
            //{
            //    Console.WriteLine(untrack.preview);
            //}

            //Artist Stromae = new Artist();
            //Stromae = DeezerApi.getFirstArtistByName("Stromae");

            //Artist StromaeDétails = DeezerApi.getDetailsArtistById(Stromae.id);
            //List<Album> AlbumdeStromae = StromaeDétails.getLesAlbums();

            //Album dernierAlbumStromae = AlbumdeStromae[0];

            //List<Track> lesTitreDuDerniersAlbumdeStromae = dernierAlbumStromae.getLesTracks();



            #endregion
            #region EXERCICE 3 : Afficher tous les mp3 des 3 premiers albums trouvés pour l'artiste "DAFT PUNK"
            //List<Track> lesTRACKS = new List<Track>();
            //lesTRACKS = DeezerApi.getAllTracksByName("DAFT PUNK");

            //foreach (Track untrack in lesTRACKS)
            //{
            //    Console.WriteLine(untrack.preview);
            //}

            //Artist dafPunk = DeezerApi.getFirstArtistByName("daft punk");
            //dafPunk = DeezerApi.getDetailsArtistById(dafPunk.id);

            //List<Album> lesAlbums = dafPunk.getLesAlbums();

            //int i;
            //for (i = 0; i < 3; i++)
            //{

            //    List<Track> lesTracks = lesAlbums[i].getLesTracks();
            //    foreach (Track unTrack in lesTracks)
            //    {
            //        Console.WriteLine(unTrack.preview);
            //    }
            //}


            #endregion








            #region Tests V1 de Méthodes dans la fenêtre de sortie
            //Artist monArtist = new Artist();
            //string recherche = "zaz";
            //monArtist = DeezerApi.getFirstArtistByName(recherche);
            //if (monArtist == null)
            //{
            //    Console.WriteLine("\nDésolé, artiste '" + recherche + "' inconnu sur Deezer ...");
            //}
            //else
            //{
            //    Console.WriteLine("\nInformations du premier artiste trouvé :");
            //    Console.WriteLine("----------------------------------------");
            //    Console.WriteLine("Nom : " + monArtist.name); Console.WriteLine("ID : " + monArtist.id);
            //    Console.WriteLine("Lien de la photo : " + monArtist.picture);
            //    Console.WriteLine("Lien direct Deezer de l'artiste : " + monArtist.link);
            //    Console.WriteLine("Lien du PLUGIN de RADIO de l'artiste : " + DeezerPlugin.getUrlPluginRadio(monArtist.id));
            //    Console.WriteLine("\nEt voilà le travail !");
            //}
            #endregion

        }
    }
}
