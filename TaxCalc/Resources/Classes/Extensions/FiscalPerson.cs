using TaxCalc.Resources.Classes.Abstract;

namespace TaxCalc.Resources.Classes.Extensions {
    class FiscalPerson : Person {
        public int Workers { get; private set; }

        public FiscalPerson(string name, double annualGains, int workers) : base(name, annualGains) {
            Workers = workers;
        }

        public override double Tax() {
            if(Workers <= 10) {
                return AnnualGains * 0.16;
            } else {
                return AnnualGains * 0.14;
            }
        }
    }
}
