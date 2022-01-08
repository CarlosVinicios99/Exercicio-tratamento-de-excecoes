using System;
using System.Globalization;

using Exercicio1.Entities;
using Exercicio1.Entities.Exceptions;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the account data: ");

                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());

                Console.Write("Holder: ");
                string holder = Console.ReadLine();

                Console.Write("Initial Balance: ");
                double initialBalance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Withdraw Limit: ");
                double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Account account = new Account(number, holder, initialBalance, withdrawLimit);

                Console.WriteLine();
                Console.Write("Enter amount for withdraw: ");
                double amountWithdraw = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                account.Withdraw(amountWithdraw);
            }

            catch(DomainException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
