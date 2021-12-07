using System;
using System.Collections.Generic;
using System.Globalization;
using TaxCalc.Resources.Classes.Abstract;
using TaxCalc.Resources.Classes.Extensions;

namespace TaxCalc.Resources.Methods {
    class CreateNaturalPerson {
        public static void AddNaturalPerson(List<Person> people) {
            Console.Clear();
            Console.WriteLine("TAX MANAGEMENT SYSTEM");
            Console.WriteLine("---------------------");
            Console.Write("Please state the person's name: ");
            string name = Console.ReadLine();
            Console.Write("Please state the person's annual gains: ");
            double gains = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Please state the person's total health bills: ");
            double bills = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Person person = new NaturalPerson(name, gains, bills);
            people.Add(person);
        }
    }
}
