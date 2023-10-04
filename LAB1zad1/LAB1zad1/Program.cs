using System;

namespace LAB1zad1
{
    class Program
    {
        static void Main(string[] args)
        {
            // zadanie 1
            Console.WriteLine("1. Sprawdź czy liczba jest parzysta czy nie");
            int liczba = int.Parse(Console.ReadLine());
            if (liczba % 2 == 0)
            {
                Console.WriteLine("zgadłeś");
            }
            else
            {
                Console.WriteLine("nope");
            }
            //zadanie 2
            Console.WriteLine("2. Wypisanie liczb parzystych od 1 do N");
            int liczba1 = int.Parse(Console.ReadLine());
            for (int i = 0;i<=liczba1;i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            //Zadanie 3
            
            Console.WriteLine("3.  1 Sprawdź czy podana liczba jest parzysta");
            Console.WriteLine("3.  2 wypisywanie liczb parzystych");
            int liczba3 = int.Parse(Console.ReadLine());
            switch(int.Parse(liczba3))
            {
                case 1:
                    DisplayNumberIsEven();
                    break;
                case 2:
                    DisplayNumbers();
                    break;
                case 4:
                    silnia();
                    break
            }
            

            //zadanie 4
            Console.WriteLine("4. Podaj liczbę której chcesz sprawdzić silnię");
            int liczba4 = int.Parse(Console.ReadLine());
            Console.WriteLine(liczba4 + "! = " + silnia(liczba4));
        }
        static void silnia(int i) {
            static int silnia(int i)
            {
                if (i < 1)
                    return 1;
                else
                    return i * silnia(i - 1);
            }
        }
        static void DisplayNumberIsEven()
        {
            int liczba = int.Parse(Console.ReadLine());
            if (liczba % 2 == 0)
            {
                Console.WriteLine("zgadłeś");
            }
            else
            {
                Console.WriteLine("nope");
            }
        }
        static void DisplayNumbers()
        {
            Console.WriteLine("2. Wypisanie liczb parzystych od 1 do N");
            int liczba1 = int.Parse(Console.ReadLine());
            for (int i = 0; i <= liczba1; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
