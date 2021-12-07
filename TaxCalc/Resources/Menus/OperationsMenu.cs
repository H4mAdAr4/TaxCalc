using System;

namespace TaxCalc.Resources.Menus {
    class OperationsMenu {
        public static void ExitMenu() {
            Console.WriteLine("---------------------");
            Console.Write("Thank you user! Do you wish to do another operation? (y/n): ");
            char choice = char.Parse(Console.ReadLine());
            if (choice == 'y') {
                Program.Main();
            } else {
                Environment.Exit(0);
            }
        }
    }
}
