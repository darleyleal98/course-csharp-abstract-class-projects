using course_csharp_abstract_class_projects.EntitiesShape;
using course_csharp_abstract_class_projects.Entities.Enums;
using System;
using course_csharp_abstract_class_projects.EntitiesPayers;

namespace course_csharp_abstract_class_projects
{
    public class Program
    {
        static void Main()
        {
            try
            {
                List<TaxPayer> listOfTaxPayers = new List<TaxPayer>();

                Console.Write("Enter the number of tax payers: ");
                int quantityPayers = int.Parse(Console.ReadLine());

                for (int i = 0; i < quantityPayers; i++)
                {
                    Console.WriteLine($"Ta payer #{i + 1} data:");

                    Console.Write("Individual or company (I/ C)? ");
                    string option = Console.ReadLine().ToUpper();

                    Console.Write("Name: ");
                    string name = Console.ReadLine();

                    Console.Write("Anual income: ");
                    double anualIncome = double.Parse(Console.ReadLine());

                    switch (option)
                    {
                        case "I":
                            Console.Write("Health expenditures: ");
                            double expenditure = double.Parse(Console.ReadLine());
                            listOfTaxPayers.Add(new Individual(name, anualIncome, expenditure));

                            break;

                        case "C":
                            Console.Write("Number of employees: ");
                            int employees = int.Parse(Console.ReadLine());
                            listOfTaxPayers.Add(new Company(name, anualIncome, employees));
                            break;

                        default:
                            throw new Exception("This option does not exist, please try again!");
                            break;
                    }
                }
                double sum = 0.0;

                Console.WriteLine("\nTAXES PAID:");

                foreach (var taxPayer in listOfTaxPayers)
                {
                    Console.WriteLine(taxPayer.ToString());
                    sum += taxPayer.Tax();
                }

                Console.WriteLine($"\nTOTAL TAXES: {sum:c}");
            }
            catch
            {
                throw new Exception("This option does not exist, please try again!");
            }
        }
    }
}