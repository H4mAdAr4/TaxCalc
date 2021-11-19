namespace TaxCalc.Entities {
    class NaturalPerson : Person {
        public double HealthBills { get; private set; }

        public NaturalPerson(string name, double annualGains, double healthBills) : base(name, annualGains) {
            HealthBills = healthBills;
        }

        public override double Tax() {
            double aux = 0;
            switch (AnnualGains, HealthBills) {
                case var e when (AnnualGains < 20000.00 && HealthBills > 0):
                    aux = (AnnualGains * 0.15) - (HealthBills * 0.5);
                    break;
                case var e when (AnnualGains < 20000.00 && HealthBills < 0):
                    aux = AnnualGains * 0.15;
                    break;
                case var e when (AnnualGains > 20000.00 && HealthBills > 0):
                    aux = (AnnualGains * 0.25) - (HealthBills * 0.5);
                    break;
                case var e when (AnnualGains > 20000.00 && HealthBills < 0):
                    aux = AnnualGains * 0.25;
                    break;
            }
            return aux;
        }
    }
}
