using System.Xml.Schema;

namespace TaxReader.Entities
{
    internal class NaturalPerson : Taxpayers
    {
        public double HealthcareExpenses { get; set; }

        public NaturalPerson(string name, double annualIncome, double healthcareExpenses)
            : base(name, annualIncome)
        {
            HealthcareExpenses = healthcareExpenses;
        }

        public override double Tax()
        {
            if (AnnualIncome < 20000)
            {
               return AnnualIncome * 0.15 - HealthcareExpenses * 0.5;
            }

            else
            {
                return AnnualIncome * 0.25 - HealthcareExpenses * 0.5;
            }
        }
    }
}
