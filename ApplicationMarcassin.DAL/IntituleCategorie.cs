//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ApplicationMarcassin.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class IntituleCategorie
    {
        public int Id_Categorie { get; set; }
        public int Id_Langue { get; set; }
        public string intitule { get; set; }
    
        public virtual Categorie Categorie { get; set; }
        public virtual Langue Langue { get; set; }
    }
}
