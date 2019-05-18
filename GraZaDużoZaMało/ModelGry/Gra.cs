using System;

namespace ModelGry
{
    public class Gra
    {
        //pola
        int wylosowana;
        int zakresOD, zakresDO;

        //ToDo: historia rozgrywki
        public Gra(int min, int max)
        {
            wylosowana = Losuj(min, max);
        }
        private int Losuj(int min = 1, int max = 100)
        {
            Random generator = new Random();
            int wylosowana = generator.Next(min, max + 1);
            return wylosowana;
        }
    }
}
