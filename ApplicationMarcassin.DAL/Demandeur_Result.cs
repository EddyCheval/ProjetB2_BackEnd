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
    
    public partial class Demandeur_Result
    {
        public Nullable<int> Id_Employe { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public Nullable<int> Id_Competence { get; set; }
        public string Intitule { get; set; }
        public string Description { get; set; }
        public Nullable<int> Tutorant { get; set; }
        public string NomTutorant { get; set; }
        public string PrenomTutorant { get; set; }
    }
}
