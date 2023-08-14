using System;
using System.Collections.Generic;
using System.Globalization;
using TaxReader.Entities;

namespace TaxReader
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Taxpayers> list = new List<Taxpayers>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Natural Person or Legal Entity (n/l)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Annual Income: $");
                double annualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (ch == 'l' ||  ch == 'L')
                {
                    Console.Write("Number of employees: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine());
                    list.Add(new LegalEntity(name, annualIncome, numberOfEmployees));
                }

                else
                {
                    Console.Write("Health expenditures: $");
                    double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new NaturalPerson(name, annualIncome, healthExpenditures));
                }
            }

            double sum = 0;
            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");
            foreach (Taxpayers taxpayers in list)
            {
                double tax = taxpayers.Tax();
                Console.WriteLine(taxpayers.Name + ": $" + tax.ToString("F2", CultureInfo.InvariantCulture));
                sum += tax;
            }

            Console.WriteLine();
            Console.WriteLine("TOTAL TAXES: $" + sum.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}