using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    public class UnosPodataka
    {
        public static Korisnik dohvatiPodatke() {
            //Zatrazi od korisnika unos podataka
            Korisnik korisnik = new Korisnik();

            Console.WriteLine("Vaše ime je: ");
            korisnik.ime = Console.ReadLine();

            Console.WriteLine("Vaše prezime je: ");
            korisnik.prezime = Console.ReadLine();

            return korisnik;
        }
    }
}


