using System;
using System.Collections.Generic;
using TaxCalc.Resources.Classes.Abstract;

namespace TaxCalc.Resources.Methods {
    class CreateContributor {
        public static void AddContributor(List<Person> people) {
            AddCont();
            void AddCont() {
                Console.Clear();
                Console.WriteLine("TAX MANAGEMENT SYSTEM");
                Console.WriteLine("---------------------");
                Console.Write("Please state the contributor type (Natural/Fiscal): ");
                string contType = Console.ReadLine();

                switch (contType) {
                    case var e when contType == "Natural":
                        CreateNaturalPerson.AddNaturalPerson(people);
                        break;
                    case var e when contType == "Fiscal":
                        CreateFiscalPerson.AddFiscalPerson(people);
                        break;
                    default:
                        AddCont();
                        break;
                }
            }
        }
    }
}
