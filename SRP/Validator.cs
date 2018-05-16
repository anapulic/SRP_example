using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    public class Validator
    {
        public static bool validiraj(Korisnik korisnik) {
            //Validacija imena i prezimena
            if (string.IsNullOrWhiteSpace(korisnik.ime))
            {
                Poruka.prikaziValidacijskuGresku("ime");
                return false;
            }

            if (string.IsNullOrWhiteSpace(korisnik.prezime))
            {
                Poruka.prikaziValidacijskuGresku("prezime");
                return false;
            }

            return true;
        }
    }
}




