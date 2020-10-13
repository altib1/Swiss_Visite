using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swiss_Visite
{
    class ModelMission3
    {
       
        public static BALNEntities maConnexion;
     

       

        public static void init()
        {
            /* Instantiation d’un objet de la classe typée chaine de connexion SqlConnection */
            maConnexion = new BALNEntities();
            
        }

       
    }
}
