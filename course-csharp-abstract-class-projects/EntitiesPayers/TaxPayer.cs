using System;

namespace course_csharp_abstract_class_projects.EntitiesPayers
{
    public abstract class TaxPayer
    {
        protected string Name { get; set; }
        protected double AnualIncome { get; set; }

        public TaxPayer(string name, double anualIncome)
        {
            Name = name;
            AnualIncome = anualIncome;
        }
        public abstract double Tax();
    }
}
