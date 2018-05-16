using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    public class Generator
    {
        public static void generirajRacun(Korisnik korisnik) {
            //Stvori korisnicko ime
            Console.WriteLine($"Vaše korisničko ime je: {korisnik.ime.Substring(0, 1)}{korisnik.prezime}");
        }
    }
}



