namespace TaxReader.Entities
{
    internal abstract class Taxpayers
    {
        public string Name { get; set; }
        public double AnnualIncome { get; set; }

        public Taxpayers()
        {
        }

        public Taxpayers(string name, double annualIncome)
        {
            Name = name;
            AnnualIncome = annualIncome;
        }

        public abstract double Tax();
    }
}
