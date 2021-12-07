using System;
using System.Collections.Generic;
using System.Globalization;
using TaxCalc.Resources.Classes.Abstract;
using TaxCalc.Resources.Classes.Extensions;

namespace TaxCalc.Resources.Methods {
    class CreateFiscalPerson {
        public static void AddFiscalPerson(List<Person> people) {
            Console.Clear();
            Console.WriteLine("TAX MANAGEMENT SYSTEM");
            Console.WriteLine("---------------------");
            Console.Write("Please state the company's name: ");
            var name = Console.ReadLine();
            Console.Write("Please state the company's annual gains: ");
            var gains = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Please state the company's total number of workers: ");
            var workers = int.Parse(Console.ReadLine());

            Person person = new FiscalPerson(name, gains, workers);
            people.Add(person);
        }
    }
}
