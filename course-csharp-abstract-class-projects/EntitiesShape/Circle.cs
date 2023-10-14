using System;
using System.Text;

namespace course_csharp_abstract_class_projects.EntitiesShape
{
    public class Circle : Shape
    {
        public double Radius { get; set; }
        public Circle() { }
        public Circle(double radius)
        {
            Radius = radius;
        }
        public override double Area() => 3.14 * (Radius * Radius);
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append($"{Area()}");

            return stringBuilder.ToString();
        }
    }
}
