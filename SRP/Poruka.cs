using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    public class Poruka
    {
        public static void pozeliDobrodoslicu() {
            Console.WriteLine("Dobrodošli u aplikaciju za generiranje korisničkog imena!");
        }

        public static void zavrsi() {
            Console.ReadLine();
        }

        public static void prikaziValidacijskuGresku(string podatak) {
            Console.WriteLine($"Molim unesite {podatak}!");
        }
    }
}





