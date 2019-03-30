using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraMonolitycznie
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Witaj!");
            Console.Write("Podaj swoje imie: ");
            string x = Console.ReadLine();
            Console.WriteLine($"Witaj, {x}");
            */

            // 1. Komputer losuje

            Random generator = new Random();
            int wylosowana = generator.Next(1, 101);
            Console.WriteLine("Wylosowałem liczbę od 1 do 100. \n Odgadnij ją.");

#if(DEBUG)
            Console.WriteLine(wylosowana);
#endif


            //wykonuj
            bool trafiono = false; //wartownik (zwany czasem: flagą)
            do
            {
                #region 2. Człowiek proponuje rozwiąznie
                Console.Write("Podaj swoją propozycję: ");
                string tekst = Console.ReadLine();
                if (tekst.ToLower() == "x")
                    break;
                int propozycja = 0;

                try
                {
                    propozycja = Convert.ToInt32(tekst);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Nie podano liczby");
                    continue;
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Liczba nie mieści się w rejestrze");
                    continue;
                }

                Console.WriteLine($"Przyjołeść wartość {propozycja}");
                #endregion

                #region 3. Komputer ocenia propozycje
                if (propozycja < wylosowana)
                    Console.WriteLine("Za mało");
                else if (propozycja > wylosowana)
                    Console.WriteLine("Za dużo");
                else
                {
                    Console.WriteLine("Trafiono");
                    trafiono = true;
                }

                #endregion
            }
            while( !trafiono );
            //do momentu trafienia
            Console.WriteLine("Koniec gry");
        }
    }
}



