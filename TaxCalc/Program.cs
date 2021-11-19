using System;
using System.Globalization;
using System.Collections.Generic;
using TaxCalc.Entities;

namespace TaxCalc {
    class Program {
        static void Main() {
            double totalTaxes = 0;
            List<Person> people = new List<Person>();

            Console.WriteLine("TAX MANAGEMENT SYSTEM");
            Console.WriteLine("---------------------");
            Console.Write("Welcome user! Please state the number of contributors: ");
            int cont = int.Parse(Console.ReadLine());
            for (int i = 0; i < cont; i++) {
                AddCont();
                void AddCont() {
                    Console.Clear();
                    Console.WriteLine("TAX MANAGEMENT SYSTEM");
                    Console.WriteLine("---------------------");
                    Console.Write("Please state the contributor type (Natural/Fiscal): ");
                    string contType = Console.ReadLine();

                    switch (contType) {
                        case var e when contType == "Natural":
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
                            break;
                        case var e when contType == "Fiscal":
                            Console.Clear();
                            Console.WriteLine("TAX MANAGEMENT SYSTEM");
                            Console.WriteLine("---------------------");
                            Console.Write("Please state the company's name: ");
                            name = Console.ReadLine();
                            Console.Write("Please state the company's annual gains: ");
                            gains = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                            Console.Write("Please state the company's total number of workers: ");
                            int workers = int.Parse(Console.ReadLine());

                            person = new FiscalPerson(name, gains, workers);
                            people.Add(person);
                            break;
                        default:
                            AddCont();
                            break;
                    }
                }
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
                Console.WriteLine("---------------------");
                Console.Write("Thank you user! Do you wish to do another operation? (y/n): ");
                char choice = char.Parse(Console.ReadLine());
                if (choice == 'y') {
                    Main();
                } else {
                    Environment.Exit(0);
                }
            }
        }
    }
}
