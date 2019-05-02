using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Lesson_1_OOP
{
    class Rectangle : AreaCount
    {
        public double A { get; }

        public double B { get; }
        public double Area { get; private set; }

        public Rectangle(double a, double b)
        {
            A = a;
            B = b;
            CalculateArea();
        }
        public void CalculateArea()
        {
            Area = A * B;
        }
    }
}
