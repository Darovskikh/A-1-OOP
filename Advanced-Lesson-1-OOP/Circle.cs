using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Lesson_1_OOP
{
    class Circle : AreaCount
    {
        public double Radius { get; }
        public double Area { get; private set; }

        public Circle(double radius)
        {
            Radius = radius;
            CalculateArea();
        }
        public void CalculateArea()
        {
            Area = Math.Round(Math.PI * Math.Pow(Radius, 2), 2);
        }
    }
}
