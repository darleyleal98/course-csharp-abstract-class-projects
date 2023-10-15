using System;
using System.Text;

namespace course_csharp_abstract_class_projects.EntitiesPayers
{
    public class Company : TaxPayer
    {
        protected int NumberOfEmployees { get; set; }
        public Company(string name, double anualIncome, int numberOfEmployees) 
                       : base(name, anualIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double Tax()
        {
            double tax = 0.0;

            if (NumberOfEmployees > 10)
            {
                tax = AnualIncome * 0.14;
            }
            if (NumberOfEmployees <= 10)
            {
                tax = AnualIncome * 0.16;
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
