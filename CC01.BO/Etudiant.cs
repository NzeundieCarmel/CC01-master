using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC01.BO
{
    [Serializable]
    public class Etudiant
    {
      
        public byte[] Photo { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime Né_le { get; set; }
        public string Matricule { get; set; }
        public int Contact { get; set; }
        public string Email { get; set; }


        public Etudiant()
        {

        }

        public Etudiant(byte[] photo, string nom, string prenom, DateTime né_le, 
            string matricule, int contact, string email)
        {
            Photo = photo;
            Nom = nom;
            Prenom = prenom;
            Né_le = né_le;
            Matricule = matricule;
            Contact = contact;
            Email = email;
        }

        public override bool Equals(object obj)
        {
            return obj is Etudiant etudiant &&
                   Matricule == etudiant.Matricule;
        }

        public override int GetHashCode()
        {
            return 797189699 + EqualityComparer<string>.Default.GetHashCode(Matricule);
        }
    }
}
