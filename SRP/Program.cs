using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    class Program
    {
        static void Main(string[] args)
        {
            Poruka.pozeliDobrodoslicu();

            Korisnik korisnik = UnosPodataka.dohvatiPodatke();

            bool validiraniKorisnik = Validator.validiraj(korisnik);
            if (!validiraniKorisnik) {
                Poruka.zavrsi();
                return;
            }

            Generator.generirajRacun(korisnik);

            Poruka.zavrsi();
        }
    }
}






