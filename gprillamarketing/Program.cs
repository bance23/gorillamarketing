using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace gprillamarketing
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            
            Random random = new Random();

            Console.WriteLine("Szia! Induljon a játék!");

            //bekérjük hány játékos lesz és mentjük változóba
            Console.WriteLine("Hány játékos fog játszani?");
            int jatekosszam = Convert.ToInt32(Console.ReadLine());

            string[] jatekosok = new string[jatekosszam];

            //feltöltjük a játékosoknak a nevét
            for (int i = 0; i < jatekosok.Length; i++)
            {
                Console.WriteLine("Hogy hívják a " + (i + 1) + ". játékost");
                string jatekosnev = Console.ReadLine();
                jatekosok[i] = jatekosnev;

            }

            //kiírjuk, hogy kisorsoljuk a zsűrit aki témát választ és értékeli a többi játékost

            Console.WriteLine("És most egy billentyű megnyomásával ki kell sorsolni,hogy ki lesz a zsűri. Nyomj meg egy gombot!");
            Console.ReadKey();

            int zsurisorszam = random .Next(jatekosok.Length);
            Console.WriteLine(jatekosok[zsurisorszam] + " lesz a zsűri ebben a körben");

            //létrehozzuk a játékosok tömböt a zsűri nélkül
            string[] versenyzok = new string[jatekosszam - 1];

            int ideiglenes;

            for (int n = 0; n < versenyzok.Length -1; n++)
            {
                if (n != zsurisorszam)
                {
                    versenyzok[n] = jatekosok[n];
                }
                else
                {
                    versenyzok[n] = jatekosok[n + 1];
                    ideiglenes = n + 2;
                    for (int m = (ideiglenes); m < versenyzok.Length - 1; m++)
                    {
                        versenyzok[m - 1] = jatekosok[m];
                    }
                }
            }


            //a kör témájának kiválasztása
            string[] temak = { "Filmek", "Tárgyak", "Zenekarok", "Egyetemi kurzusok",};

            Console.WriteLine("A következő témákből választhatsz.:");
            Console.WriteLine("Filmek");
            Console.WriteLine("Tárgyak");
            Console.WriteLine("Zenekarok");
            Console.WriteLine("Egyetemi kurzusok");
            Console.WriteLine("Hanyadik legyen?");

            int temasorszam = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("A kiválasztott téma: " + temak[temasorszam - 1]);

            //betúszám közlés és sorsolás
            Console.WriteLine("Most pedig egy billentyű megnyomásával betüket sorsolhatsz. Random lesznek betűk minimum 2 és legfeljebb 4.");

            int betuszam = random .Next(2,5);

            // random betük sorsolása
            Console.WriteLine("A betűk:");
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var stringChars = new char[betuszam];
            var rand = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[rand.Next(chars.Length)];
            }

            var finalString = new String(stringChars);
            Console.WriteLine(finalString);

            //játékosok válaszai:

            for (int i = 0; i < jatekosszam; i++)
            {
                if (i != zsurisorszam)
                {
                    Console.WriteLine(jatekosok[i] + " válasza következik. Kérlek írd be!");
                    string valasz = Console.ReadLine();
                    Console.WriteLine(jatekosok[i] + " válasza: " + valasz);
                }
            }

            //a kör nyertesének kiválasztása

            Console.WriteLine(jatekosok[zsurisorszam] + " a válaszok elolvasása után itt vannak a játékosok:");

            for (int l = 0; l < jatekosszam; l++)
            {
                if (l != zsurisorszam)
                {
                    Console.WriteLine(jatekosok[l]);
                }
                
            }



            Console.WriteLine("Hanyadik játékos válasza nyerte el legjobban a tetszésedet?");

            int nyertesjatekos = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("A játék nyertese: " + versenyzok[nyertesjatekos - 1]);
            Console.WriteLine("Köszönjük, hogy velünk játszott. Viszlát!");



            Console.ReadKey();



        }
    }
}
