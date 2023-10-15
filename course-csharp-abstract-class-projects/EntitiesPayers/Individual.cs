using System;
using System.Text;

namespace course_csharp_abstract_class_projects.EntitiesPayers
{
    public class Individual : TaxPayer
    {
        protected double HealthExpenditures {  get; set; }

        public Individual(string name, double anualIncome, double healthExpenditures)
                          : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax()
        {
            double tax = 0.0;

            if (AnualIncome < 20000.00)
            {
                tax = (AnualIncome * 0.15) - (HealthExpenditures * 0.5);
            }
            if (AnualIncome >= 20000.00)
            {
                tax = (AnualIncome * 0.25) - (HealthExpenditures * 0.5);
            }

            return tax;
        }
        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append($"{Name}: {Tax():c}");
            return builder.ToString();
        }
    }
}
