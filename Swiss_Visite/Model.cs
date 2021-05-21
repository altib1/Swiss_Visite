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


    }
}
