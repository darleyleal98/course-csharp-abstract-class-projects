using course_csharp_abstract_class_projects.Entities.Enums;
using System;
using System.Text;

namespace course_csharp_abstract_class_projects.EntitiesShape
{
    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height, Color color) : base(color)
        {
            Width = width;
            Height = height;
        }   
        public override double Area() => Width * Height;
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append($"{Area()}");

            return stringBuilder.ToString();
        }
    }
}
