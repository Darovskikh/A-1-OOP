using System;
using System.Collections.Generic;
using System.Linq;

namespace Advanced_Lesson_1_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lesson.AbstractionShapeExample();
            //Lesson.OverloadingExample();
            //Lesson.InheritanceTransportExample();

            //Practice.A_L1_P7_OperatorsOverloading();

            ExecuteTask1();

            Console.ReadKey();
        }
        public static void ExecuteTask1()
        {
            double[,] areas = new double[10, 3];
            for (int i = 1; i <= 10; i++)
            {
                int j = i - 1;
                Rectangle rectangle = new Rectangle(i, i);
                Triangle triangle = new Triangle(i, i);
                Circle circle = new Circle(i);
                areas[j, 0] = rectangle.Area;
                areas[j, 1] = triangle.Area;
                areas[j, 2] = circle.Area;
            }

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{areas[i, j]}     ");
                }
                Console.WriteLine();
            }
        }
    }
}
