﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swiss_Visite
{
    public static class ModelMission3
    {
       
        public static BALNEntities maConnexion;
     

       

        public static void init()
        {
            /* Instantiation d’un objet de la classe typée chaine de connexion SqlConnection */
            maConnexion = new BALNEntities();
            
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

            return LQuery.ToList()[0];
        }

        public static List<FraisForfait> listefraisforfait()
        {
            return maConnexion.FraisForfait.ToList();
        }

        public static fichefrais recherchefichefrais(string vid)
        {

            var LQuery = maConnexion.fichefrais.ToList()

                           .Where(x => x.idVisiteur == vid)
                           .Where(x => x.mois == DateTime.Now.Month.ToString());
                         
            // .Select(x => new {x.id, x.libelle });

            return LQuery.ToList()[0];
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

                           .Where(x => x.idVisiteur == idvisiteur)
                           .Where(x => x.mois == mois);

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
        public static bool enregfichefrais( string idvisiteur, string mois, string etat, string nbjustificatifs)
        {
            bool vretour = true;
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
                    maConnexion.SaveChanges();
                }
            }
            catch (Exception)
            {
                vretour = false;
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
            maConnexion.SaveChanges();

        }
        public static void enregsoir(string idvisiteurs, string mois, string idfraisforfait, string quantite)
        {
            LigneFraisForfait soir = new LigneFraisForfait();

            soir.idVisiteur = idvisiteurs;
            soir.mois = mois;
            soir.quantite = int.Parse(quantite);
            soir.idFraisForfait = idfraisforfait;
            maConnexion.LigneFraisForfait.Add(soir);
            maConnexion.SaveChanges();

        }

        public static void enregmidi(string idvisiteurs, string mois, string idfraisforfait, string quantite)
        {
            LigneFraisForfait midi = new LigneFraisForfait();

            midi.idVisiteur = idvisiteurs;
            midi.mois = mois;
            midi.quantite = int.Parse(quantite);
            midi.idFraisForfait = idfraisforfait;
            maConnexion.LigneFraisForfait.Add(midi);
            maConnexion.SaveChanges();

        }

        public static void enregforfnuite(string idvisiteurs, string mois, string idfraisforfait, string quantite)
        {
            LigneFraisForfait forfnuite = new LigneFraisForfait();

            forfnuite.idVisiteur = idvisiteurs;
            forfnuite.mois = mois;
            forfnuite.quantite = int.Parse(quantite);
            forfnuite.idFraisForfait = idfraisforfait;
            maConnexion.LigneFraisForfait.Add(forfnuite);
            maConnexion.SaveChanges();

        }

        public static void enregfraiskm(string idvisiteurs, string mois, string idfraisforfait, string quantite)
        {
            LigneFraisForfait fraiskm = new LigneFraisForfait();

            fraiskm.idVisiteur = idvisiteurs;
            fraiskm.mois = mois;
            fraiskm.quantite = int.Parse(quantite);
            fraiskm.idFraisForfait = idfraisforfait;
            maConnexion.LigneFraisForfait.Add(fraiskm);
            maConnexion.SaveChanges();

        }



    }
}
