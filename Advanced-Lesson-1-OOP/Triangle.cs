using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Lesson_1_OOP
{
    class Triangle : AreaCount
    {
        public double Height { get; }
        public double Base { get; }
        public double Area { get; private set; }

        public Triangle(double height, double @base)
        {
            Height = height;
            Base = @base;
            CalculateArea();
        }
        public void CalculateArea()
        {
            Area = 0.5 * Base * Height;
        }
    }
}
