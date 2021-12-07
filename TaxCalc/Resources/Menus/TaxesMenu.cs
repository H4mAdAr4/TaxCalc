using System;
using System.Collections.Generic;
using System.Globalization;
using TaxCalc.Resources.Classes.Abstract;

namespace TaxCalc.Resources.Menus {
    class TaxesMenu {
        public static double ShowTaxes(List<Person> people) {
            double totalTaxes = 0;
            
            Console.Clear();
            Console.WriteLine("TAX MANAGEMENT SYSTEM");
            Console.WriteLine("---------------------");
            Console.WriteLine("TAXES PAID:");
            foreach (Person person in people) {
                Console.WriteLine($"{person.Name}: $" + person.Tax().ToString("F2", CultureInfo.InvariantCulture));
                totalTaxes += person.Tax();
            }
            Console.WriteLine();
            Console.WriteLine("Total Taxes: $" + totalTaxes.ToString("F2", CultureInfo.InvariantCulture));

            return totalTaxes;
        }
    }
}
