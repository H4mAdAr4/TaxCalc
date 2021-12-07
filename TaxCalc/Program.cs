using System;
using System.Globalization;
using System.Collections.Generic;
using TaxCalc.Resources.Classes.Abstract;
using TaxCalc.Resources.Methods;
using TaxCalc.Resources.Menus;

namespace TaxCalc {
    class Program {
        public static void Main() {
            try {
                List<Person> people = new List<Person>();

                Console.WriteLine("TAX MANAGEMENT SYSTEM");
                Console.WriteLine("---------------------");
                Console.Write("Welcome user! Please state the number of contributors: ");
                int cont = int.Parse(Console.ReadLine());

                for (int i = 0; i < cont; i++) {
                    CreateContributor.AddContributor(people);
                }

                TaxesMenu.ShowTaxes(people);
                OperationsMenu.ExitMenu();

            } catch (FormatException) {
                Console.Clear();
                Console.WriteLine("Field contributors must be a number!");
                Console.WriteLine("");
                Main();
                throw;
            }
        }
    }
}
