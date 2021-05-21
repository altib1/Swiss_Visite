using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace Swiss_Visite
{
    public static class Model
    {
        private static Visiteur utilisateurConnecte;
        private static bool connexionValide;
        public static GSBbdd maConnexion;
        public static string idclient;

        public static Visiteur UtilisateurConnecte { get => utilisateurConnecte; set => utilisateurConnecte = value; }
        public static bool ConnexionValide { get => connexionValide; set => connexionValide = value; }

        public static void init()
        {
            /* Instantiation d’un objet de la classe typée chaine de connexion SqlConnection */
            maConnexion = new GSBbdd();
            ConnexionValide = false;
        }
        private static string GetMd5Hash(string PasswdSaisi)
        {
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(PasswdSaisi);
            byte[] hash = (MD5.Create()).ComputeHash(inputBytes);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("x2"));
            }
            return sb.ToString();
        }
        public static Visiteur rechercheVisiteur(string id)
        {
            Visiteur vretour = null;
            var LQuery = maConnexion.Visiteur.ToList()
                           .Where(x => x.identifiant == id);
            if(LQuery.ToList().Count==1)
            {
                vretour=(Visiteur)LQuery.ToList()[0];
            }
            return vretour;
        }
        public static string validConnexion(string id, string mp)
        {
           
            string message = "";
            Visiteur v1 = rechercheVisiteur(id);
            if ( v1 != null)
            {
                if ((GetMd5Hash(mp) == v1.password))
                {
                    UtilisateurConnecte = v1;
                    connexionValide = true;
                    idclient = id;

                }
            }
          

            if (!connexionValide)
            {
                MessageBox.Show("Erreur identifiant / MP");
            }
        

            
            // Ecrire le code qui renvoie le message à afficher et mets à jour les variables utilisateurConnecte et connexionValide, la comparaison des mots de passes se fera via utilisateurConnecte.passwd.Substring(2).Equals(GetMd5Hash(mp))
            return message;
        }




        public static FraisForfait rechercheFraisForfait(string vid)
        {

            var LQuery = maConnexion.FraisForfait.ToList()
                           .Where(x => x.id == vid);

            return LQuery.ToList()[0];
        }

        public static Object recherchefraiskilometrique()
        {

            var LQuery = maConnexion.FraisForfait.ToList()

                           .Where(x => x.Kilometrique == true);
            // .Select(x => new {x.id, x.libelle });

            return LQuery.ToList();
        }

        public static Object idlignefrais(string libelle)
        {

            var LQuery = maConnexion.FraisForfait.ToList()

                           .Where(x => x.libelle == libelle);
            // .Select(x => new {x.id, x.libelle });
            if (LQuery.ToList().Count > 0)
            {
                return LQuery.ToList()[0];
            }
            else
            {
                return null;
            }
        }

        public static List<FraisForfait> listefraisforfait()
        {
            return maConnexion.FraisForfait.ToList();
        }

        public static Object recherchefichefrais(string vid)
        {

            var LQuery = maConnexion.fichefrais.ToList()

                           .Where(x => x.idVisiteur == vid)
                           .Select(x => x.mois);


            // .Select(x => new {x.id, x.libelle });

            return LQuery.ToList();
        }

        public static fichefrais ajouterfichefrais(string vid, string mois)
        {

            var LQuery = maConnexion.fichefrais.ToList()

                           .Where(x => x.idVisiteur == vid)
                           .Where(x => x.mois == DateTime.Now.Month.ToString());

            // .Select(x => new {x.id, x.libelle });
            if (LQuery.ToList().Count > 0)
            {
                return LQuery.ToList()[0];
            }
            else
            {
                return null;
            }
        }

        public static fichefrais modifierfichefrais(string vid, string mois)
        {

            var LQuery = maConnexion.fichefrais.ToList()

                           .Where(x => x.idVisiteur == vid)
                           .Where(x => x.mois == DateTime.Now.Month.ToString());

            // .Select(x => new {x.id, x.libelle });
            if (LQuery.ToList().Count > 0)
            {
                return LQuery.ToList()[0];
            }
            else
            {
                return null;
            }
        }

        public static fichefrais veriffraisforfait(string idvisiteur, string mois)
        {

            var LQuery = maConnexion.fichefrais.ToList()

                           .Where(x => x.idVisiteur == idvisiteur && x.mois == mois);


            // .Select(x => new {x.id, x.libelle });
            if (LQuery.ToList().Count > 0)
            {
                return LQuery.ToList()[0];
            }
            else
            {
                return null;
            }
        }

        // methodes de enregistrement des données dans la bdd
        public static bool enregfichefrais(string idvisiteur, string mois, string etat, string nbjustificatifs)
        {
            bool vretour = false;
            try
            {
                if (veriffraisforfait(idvisiteur, mois) == null)
                {


                    fichefrais lafiche = new fichefrais();

                    lafiche.idVisiteur = idvisiteur;
                    lafiche.mois = mois;
                    lafiche.idEtat = etat;
                    lafiche.nbJustificatifs = int.Parse(nbjustificatifs);
                    lafiche.dateModif = DateTime.Now;

                    maConnexion.fichefrais.Add(lafiche);
                    try
                    {
                        maConnexion.SaveChanges();

                    }
                    catch (Exception ex)
                    {

                        maConnexion.Dispose();
                        init();
                    }
                    vretour = true;
                }
            }
            catch (Exception)
            {

            }
            return vretour;



        }

        public static void enregnuite(string idvisiteurs, string mois, string idfraisforfait, string quantite)
        {

            LigneFraisForfait nuite = new LigneFraisForfait();

            nuite.idVisiteur = idvisiteurs;
            nuite.mois = mois;
            nuite.quantite = int.Parse(quantite);
            nuite.idFraisForfait = idfraisforfait;
            maConnexion.LigneFraisForfait.Add(nuite);
            try
            {
                maConnexion.SaveChanges();
            }
            catch (Exception ex)
            {
                maConnexion.Dispose();
                init();
            }

        }
        public static void enregsoir(string idvisiteurs, string mois, string idfraisforfait, string quantite)
        {
            LigneFraisForfait soir = new LigneFraisForfait();

            soir.idVisiteur = idvisiteurs;
            soir.mois = mois;
            soir.quantite = int.Parse(quantite);
            soir.idFraisForfait = idfraisforfait;
            maConnexion.LigneFraisForfait.Add(soir);
            try
            {
                maConnexion.SaveChanges();
            }
            catch (Exception ex)
            {
                maConnexion.Dispose();
                init();
            }

        }

        public static void enregmidi(string idvisiteurs, string mois, string idfraisforfait, string quantite)
        {
            LigneFraisForfait midi = new LigneFraisForfait();

            midi.idVisiteur = idvisiteurs;
            midi.mois = mois;
            midi.quantite = int.Parse(quantite);
            midi.idFraisForfait = idfraisforfait;
            maConnexion.LigneFraisForfait.Add(midi);


            try
            {
                maConnexion.SaveChanges();
            }
            catch (Exception ex)
            {
                maConnexion.Dispose();
                init();
            }

        }

        public static void enregforfnuite(string idvisiteurs, string mois, string idfraisforfait, string quantite)
        {
            LigneFraisForfait forfnuite = new LigneFraisForfait();

            forfnuite.idVisiteur = idvisiteurs;
            forfnuite.mois = mois;
            forfnuite.quantite = int.Parse(quantite);
            forfnuite.idFraisForfait = idfraisforfait;
            maConnexion.LigneFraisForfait.Add(forfnuite);
            try
            {
                maConnexion.SaveChanges();
            }
            catch (Exception ex)
            {
                maConnexion.Dispose();
                init();
            }

        }

        public static void enregfraiskm(string idvisiteurs, string mois, string idfraisforfait, string quantite)
        {
            LigneFraisForfait fraiskm = new LigneFraisForfait();

            fraiskm.idVisiteur = idvisiteurs;
            fraiskm.mois = mois;
            fraiskm.quantite = int.Parse(quantite);
            fraiskm.idFraisForfait = idfraisforfait;
            maConnexion.LigneFraisForfait.Add(fraiskm);
            try
            {
                maConnexion.SaveChanges();
            }
            catch (Exception ex)
            {
                maConnexion.Dispose();
                init();
            }

        }
        // enregistrement des frais hors forfait
        public static void enregfraishorsforfait(string iteration, string idvisiteurs, string mois, string libelle, string montant)
        {
            LigneFraisHorsForfait fraiskm = new LigneFraisHorsForfait();

            fraiskm.idVisiteur = idvisiteurs;
            fraiskm.mois = mois;
            fraiskm.date = DateTime.Now;
            fraiskm.montant = int.Parse(montant);
            fraiskm.libelle = libelle;
            fraiskm.id = int.Parse(iteration);
            maConnexion.LigneFraisHorsForfait.Add(fraiskm);
            try
            {
                maConnexion.SaveChanges();
            }
            catch (Exception ex)
            {
                maConnexion.Dispose();
                init();
            }

        }

        // tout les fiches frais 

        public static List<fichefrais> ToutesLesfichesfrais(string id, string annee)
        {
            var LQuery = maConnexion.fichefrais.ToList()

                           .Where(x => x.idVisiteur.Equals(id) && x.mois.Substring(2,4).Equals(annee));



           
                return LQuery.ToList();
           

        }


        //lignefraishorsforfait NUite


        public static LigneFraisForfait LignefraisForfaitNUI(string id, string mois)
        {
            var LQuery = maConnexion.LigneFraisForfait.ToList()

                           .Where(x => x.idVisiteur == id && x.mois == mois && x.idFraisForfait == "NUI");



            if (LQuery.ToList().Count > 0)
            {
                return LQuery.ToList()[0];
            }
            else
            {
                return null;
            }

        }

        //ligen frais forfait midi
        public static LigneFraisForfait LignefraisForfaitREM(string id, string mois)
        {
            var LQuery = maConnexion.LigneFraisForfait.ToList()

                           .Where(x => x.idVisiteur == id && x.mois == mois && x.idFraisForfait == "REM");



            if (LQuery.ToList().Count > 0)
            {
                return LQuery.ToList()[0];
            }
            else
            {
                return null;
            }

        }

        //ligne frais forfait soir
        public static LigneFraisForfait LignefraisForfaitRES(string id, string mois)
        {
            var LQuery = maConnexion.LigneFraisForfait.ToList()

                           .Where(x => x.idVisiteur == id && x.mois == mois && x.idFraisForfait == "RES");


            if (LQuery.ToList().Count > 0)
            {
                return LQuery.ToList()[0];
            }
            else
            {
                return null;
            }

        }


        //ligen frais forfait frofait nuite
        public static LigneFraisForfait LignefraisForfaitETP(string id, string mois)
        {
            var LQuery = maConnexion.LigneFraisForfait.ToList()

                           .Where(x => x.idVisiteur == id && x.mois == mois && x.idFraisForfait == "ETP");



            if (LQuery.ToList().Count > 0)
            {
                return LQuery.ToList()[0];
            }
            else
            {
                return null;
            }

        }


        //ligne frais hors forfait 

        public static LigneFraisForfait LignefraisForfaitkilometrique(string id, string mois)
        {
            var LQuery = maConnexion.LigneFraisForfait.ToList()

                           .Where(x => x.idVisiteur == id && x.mois == mois && x.idFraisForfait == x.FraisForfait.id
                              && x.FraisForfait.Kilometrique == true);




            if (LQuery.ToList().Count > 0)
            {
                return LQuery.ToList()[0];
            }
            else
            {
                return null;
            }

        }


        //Alter requettes pour modifier les informations



        public static void alterenregnuite(string idvisiteurs, string mois, string idfraisforfait, string quantite)
        {

            LigneFraisForfait nuite = maConnexion.LigneFraisForfait.Where(x => x.idVisiteur == idvisiteurs && x.mois == mois && x.idFraisForfait == "NUI").FirstOrDefault();
            if (nuite == null) throw new Exception("");

            nuite.idVisiteur = idvisiteurs;
            nuite.mois = mois;
            nuite.quantite = int.Parse(quantite);
            nuite.idFraisForfait = idfraisforfait;
            try
            {
                maConnexion.SaveChanges();
            }
            catch (Exception ex)
            {
                maConnexion.Dispose();
                init();
            }



        }
        public static void alterenregsoir(string idvisiteurs, string mois, string idfraisforfait, string quantite)
        {
            LigneFraisForfait soir = maConnexion.LigneFraisForfait.Where(x => x.idVisiteur == idvisiteurs && x.mois == mois && x.idFraisForfait == "RES").FirstOrDefault();
            if (soir == null) throw new Exception("");

            soir.idVisiteur = idvisiteurs;
            soir.mois = mois;
            soir.quantite = int.Parse(quantite);
            soir.idFraisForfait = idfraisforfait;
            
            try
            {
                maConnexion.SaveChanges();
            }
            catch (Exception ex)
            {
                maConnexion.Dispose();
                init();
            }

        }

        public static void alterenregmidi(string idvisiteurs, string mois, string idfraisforfait, string quantite)
        {
            LigneFraisForfait midi = maConnexion.LigneFraisForfait.Where(x => x.idVisiteur == idvisiteurs && x.mois == mois && x.idFraisForfait == "REM").FirstOrDefault();
            if (midi == null) throw new Exception("");

            midi.idVisiteur = idvisiteurs;
            midi.mois = mois;
            midi.quantite = int.Parse(quantite);
            midi.idFraisForfait = idfraisforfait;
           


            try
            {
                maConnexion.SaveChanges();
            }
            catch (Exception ex)
            {
                maConnexion.Dispose();
                init();
            }

        }

        public static void alterenregforfnuite(string idvisiteurs, string mois, string idfraisforfait, string quantite)
        {
            LigneFraisForfait forfnuite = maConnexion.LigneFraisForfait.Where(x => x.idVisiteur == idvisiteurs && x.mois == mois && x.idFraisForfait == "ETP").FirstOrDefault();
            if (forfnuite == null) throw new Exception("");

            forfnuite.idVisiteur = idvisiteurs;
            forfnuite.mois = mois;
            forfnuite.quantite = int.Parse(quantite);
            forfnuite.idFraisForfait = idfraisforfait;
          
            try
            {
                maConnexion.SaveChanges();
            }
            catch (Exception ex)
            {
                maConnexion.Dispose();
                init();
            }

        }

        public static void alterenregfraiskm(string idvisiteurs, string mois, string idfraisforfait, int quantite)
        {

            LigneFraisForfait fraiskm = maConnexion.LigneFraisForfait.Where(x => x.idVisiteur == idvisiteurs && x.mois == mois && x.idFraisForfait == idfraisforfait && x.quantite == quantite).FirstOrDefault();
            if (fraiskm == null) throw new Exception("");

            fraiskm.idVisiteur = idvisiteurs;
            fraiskm.mois = mois;
            fraiskm.quantite = quantite;
            fraiskm.idFraisForfait = idfraisforfait;
           
            try
            {
                maConnexion.SaveChanges();
            }
            catch (Exception ex)
            {
                maConnexion.Dispose();
                init();
            }

        }
        // enregistrement des frais hors forfait
        public static void alterenregfraishorsforfait(string iteration, string idvisiteurs, string mois, string libelle, string montant)
        {
            LigneFraisHorsForfait fraishors = maConnexion.LigneFraisHorsForfait.Where(x => x.idVisiteur == idvisiteurs && x.mois == mois && x.libelle == libelle && x.montant == int.Parse(montant)).FirstOrDefault();
            if (fraishors == null) throw new Exception("");

            fraishors.idVisiteur = idvisiteurs;
            fraishors.mois = mois;
            fraishors.date = DateTime.Now;
            fraishors.montant = int.Parse(montant);
            fraishors.libelle = libelle;
            fraishors.id = int.Parse(iteration);
           
            try
            {
                maConnexion.SaveChanges();
            }
            catch (Exception ex)
            {
                maConnexion.Dispose();
                init();
            }


        }


    }
}
