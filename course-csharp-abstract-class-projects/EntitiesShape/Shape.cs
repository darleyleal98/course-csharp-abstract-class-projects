using course_csharp_abstract_class_projects.Entities.Enums;
using System;

namespace course_csharp_abstract_class_projects.EntitiesShape
{ 
    public abstract class Shape
    {
        public Color Color { get; set; }
        public Shape(Color color)
        {
            Color = color;
        }
        public abstract double Area();
    }
}
