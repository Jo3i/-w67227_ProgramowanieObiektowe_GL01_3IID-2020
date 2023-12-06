using System;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Zad1();
            Zad2();
        }
        /*static void Zad1()
        {
            Shape shape = new Circle(5);

            Console.WriteLine(shape.CalculateArea());
        }*/
        static void Zad2()
        {
            var account = new Bank.Account();

            account.Add(new Bank.IncomeTransaction() { Amount = 400 });
            account.Add(new Bank.IncomeTransaction() { Amount = 500 });
            account.Add(new Bank.IncomeTransaction() { Amount = 600 });
            account.Add(new Bank.ExpenseTransaction() { Amount = 600 });
            account.Add(new Bank.ExpenseTransaction() { Amount = 400 });
            account.Add(new Bank.ExpenseTransaction() { Amount = 200 });

            account.DisplaySummary();
        }
        
    }
}
