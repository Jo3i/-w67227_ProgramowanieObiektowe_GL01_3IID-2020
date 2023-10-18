using System;

namespace LAB1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wybierz zadanie:");
            Console.WriteLine("Zadanie 1 - Sprawdzanie, czy podana przez użytkownika liczba jest parzysta czy nie.");
            Console.WriteLine("Zadanie 2 - Wypisz na konsoli wszystkie parzyste liczby od 1 do N,gdzie N jest liczbą wprowadzoną przez użytkownika.");
            Console.WriteLine("Zadanie 4 - Obliczanie silni ze wskazanej przez użytkownika liczby.");
            Console.WriteLine("Zadanie 5 - Napisz grę, w której komputer losuje liczbę, a użytkownik próbuje odgadnąć ją w jak najmniejszej liczbie prób.");
            Console.WriteLine("Zadanie 6 - Przeliczanie jednostek miar, Celsiusza na Fahrenheita lub między jednostkami długości");

            //ZADANIE 3
            var ZadanieN = Console.ReadLine();
            switch (int.Parse(ZadanieN))
            {
                case 1:
                    zadanie1();
                    break;
                case 2:
                    zadanie2();
                    break;
                case 4:
                    zadanie4();
                    break;
                case 5:
                    zadanie5();
                    break;
                case 6:
                    zadanie6();
                    break;
                case 0:
                    return;
            }


            static void zadanie1()
            {
                //ZADANIE 1
                Console.WriteLine("Sprawdzanie, czy podana przez użytkownika liczba jest parzysta czy nie.");
                Console.WriteLine("Podaj liczbe");
                int zad1 = int.Parse(Console.ReadLine());
                if (zad1 % 2 == 0)
                {
                    Console.WriteLine("Liczba jest parzysta");
                }
                else
                {
                    Console.WriteLine("Liczba jest nieparzysta");
                }
            }

            static void zadanie2()
            {
                //ZADANIE 2
                Console.WriteLine("Wypisz na konsoli wszystkie parzyste liczby od 1 do N,gdzie N jest liczbą wprowadzoną przez użytkownika.");
                if (int.TryParse(Console.ReadLine(), out int n))
                {
                    if (n >= 1)
                    {
                        Console.WriteLine($"Parzyste liczby od 1 do {n}:");
                        for (int i = 2; i <= n; i += 2)
                        {
                            Console.WriteLine(i);
                        }
                    }
                    else
                    {
                        Console.WriteLine("N musi być liczbą większą lub równą 1.");
                    }
                }
                else
                {
                    Console.WriteLine("Proszę podać liczbę całkowitą.");
                }
            }

            static void zadanie4()
            {
                //zadanie 4
                Console.WriteLine("Obliczanie silni ze wskazanej przez użytkownika liczby.");
                Console.WriteLine("Podaj liczbe");
                if (int.TryParse(Console.ReadLine(), out int n))
                {
                    if (n >= 0)
                    {
                        int silnia = liczsilnia(n);
                        Console.WriteLine($"Silnia z {n} wynosi: {silnia}");
                    }
                    else
                    {
                        Console.WriteLine("Podaj nieujemną liczbę całkowitą.");
                    }
                }
                else
                {
                    Console.WriteLine("To nie jest poprawna liczba całkowita.");
                }

                static int liczsilnia(int n)
                {
                    if (n == 0)
                        return 1;

                    int result = 1;
                    for (int i = 1; i <= n; i++)
                    {
                        result *= i;
                    }

                    return result;
                };


            }
            static void zadanie5()
            {
                //zadanie 5
                Console.WriteLine("Gra zagadkowa! Spróbuj zgadnąć wylowosaną liczbę od 1 do 10!");
                var random = new Random();
                var number = random.Next(1, 11);//losowanie od 1 do 10
                int count = 0;
                int shoot;
                do
                {
                    count++;
                    Console.WriteLine("podaj liczbe");
                    var input = Console.ReadLine();
                    shoot = int.Parse(input);

                }
                while (shoot != number);
                Console.WriteLine($"Gratulacje! zgadłeś! za {count} razem");

            }

            static void zadanie6()
            {
                //zadanie 6
                Console.WriteLine("Wybierz jednostki, które chcesz przeliczać:");
                Console.WriteLine("1. Metry na centymetry");
                Console.WriteLine("2. Centymetry na metry");
                Console.WriteLine("3. Celsjusz na Fahrenheit");
                Console.WriteLine("4. Fahrenheit na Celsjusz");

                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    switch (choice)
                    {
                        case 1:
                            MetrNaCentymetr();
                            break;
                        case 2:
                            CentymetrNaMetr();
                            break;
                        case 3:
                            CelsjuszNaFahrenheit();
                            break;
                        case 4:
                            FahrenheitNaCelsjusz();
                            break;
                        default:
                            Console.WriteLine("Nieprawidłowy wybór.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Nieprawidłowy wybór. Wybierz 1 lub 2.");
                }

                static void CelsjuszNaFahrenheit()
                {
                    Console.WriteLine("Podaj stopnie Celsjusza: ");
                    if (double.TryParse(Console.ReadLine(), out double C))
                    {
                        double F = (C*9/5)+32;
                        Console.WriteLine($"Stopnie w Fahrenheitach: {F} F");
                    }
                }

                static void FahrenheitNaCelsjusz()
                {
                    Console.WriteLine("Podaj stopnie Fahrenheita: ");
                    if (double.TryParse(Console.ReadLine(), out double F))
                    {
                        double C = (F-32)*5/9;
                        Console.WriteLine($"Stopnie w Fahrenheit'ach: {C} F");
                    }
                }

                static void MetrNaCentymetr()
                {
                    Console.Write("Podaj długość w metrach: ");
                    if (double.TryParse(Console.ReadLine(), out double m))
                    {
                        double cm = m * 100;
                        Console.WriteLine($"Długość w centymetrach: {cm} cm");
                    }
                    else
                    {
                        Console.WriteLine("To nie jest prawidłowa długość w metrach.");
                    }
                }

                static void CentymetrNaMetr()
                {
                    Console.Write("Podaj długość w centymetrach: ");
                    if (double.TryParse(Console.ReadLine(), out double cm))
                    {
                        double m = cm / 100;
                        Console.WriteLine($"Długość w metrach: {m} m");
                    }
                    else
                    {
                        Console.WriteLine("To nie jest prawidłowa długość w centymetrach.");
                    }
                }


            }
        }
    }
}