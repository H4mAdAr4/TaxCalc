namespace TaxCalc.Resources.Classes.Abstract {
    abstract class Person {
        public string Name { get; private set; }
        public double AnnualGains { get; private set; }

        protected Person(string name, double annualGains) {
            Name = name;
            AnnualGains = annualGains;
        }

        public abstract double Tax();
    }
}
