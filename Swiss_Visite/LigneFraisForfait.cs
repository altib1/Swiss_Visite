//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Swiss_Visite
{
    using System;
    using System.Collections.Generic;
    
    public partial class LigneFraisForfait
    {
        public string idVisiteur { get; set; }
        public string mois { get; set; }
        public string idFraisForfait { get; set; }
        public Nullable<int> quantite { get; set; }
    
        public virtual fichefrais fichefrais { get; set; }
        public virtual FraisForfait FraisForfait { get; set; }
    }
}
