using System;
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
    }
}
