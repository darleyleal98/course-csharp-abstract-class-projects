﻿using System;
using course_csharp_abstract_class_projects.Entities.Enums;

namespace course_csharp_abstract_class_projects.EntitiesShape
{
    public class MainForShapeTest
    {
        public static void Test()
        {
            try
            {
                Console.Write("Enter the number os shapes: ");
                int quantityOfShapes = int.Parse(Console.ReadLine());

                List<Shape> listOfShapes = new List<Shape>();

                for (int i = 0; i < quantityOfShapes; i++)
                {
                    Console.WriteLine($"Shape #{i + 1} data: ");
                    Console.Write("Rectangle or Circle (r/c)? ");
                    string typeOfShape = Console.ReadLine().ToUpper();

                    Console.Write("Color (Black/ Blue/ Red)? ");
                    Color colorOfShape = Enum.Parse<Color>(Console.ReadLine());

                    switch (typeOfShape)
                    {
                        case "R":
                            Console.Write("Width: ");
                            double withOfShape = double.Parse(Console.ReadLine());

                            Console.Write("Height: ");
                            double heightOfShape = double.Parse(Console.ReadLine());

                            listOfShapes.Add(new Rectangle(withOfShape, heightOfShape, colorOfShape));
                            break;

                        case "C":
                            Console.Write("Radius: ");
                            double radiusOfShape = double.Parse(Console.ReadLine());

                            listOfShapes.Add(new Circle(radiusOfShape, colorOfShape));
                            break;

                        default:
                            throw new Exception("This option does not exist, please try again!");
                            break;
                    }
                }
                Console.WriteLine("SHAPE OF AREAS");
                foreach (Shape shapes in listOfShapes)
                {
                    Console.WriteLine(shapes.ToString());
                }
            }
            catch
            {
                throw new Exception("This option does not exist, please try again!");
            }
        }
    }
}
