using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC01.BO
{
    

        [Serializable]
        public class Ecole
        {
            public string Nom { get; set; }
            public string Date_creation { get; set; }
            public string Email { get; set; }
            public int Contact { get; set; }
            public Ecole()
            {

            }
            public Ecole(string nom, string date_creation, string email, int contact)
            {
                Nom = nom;

                Date_creation = date_creation;

                Email = email;

                Contact = contact;


            }


        }
    
}
