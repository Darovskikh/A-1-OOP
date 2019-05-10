using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Lesson_1_OOP
{
    class Product
    {
        public string NameOfProduct { get; set; } 
        public double Price { get; set; }
        public int Amount { get; set; }
        public Rate Rate { get; set; }
        public string Manufacturer { get; set; }

        public void CheckPrice(Product product1, Product product2)
        {
            if (product1 > product2)
            {
                Console.WriteLine($"{product1}>{product2}");
            }
            else if (product1 == product2)
            {
                Console.WriteLine($"{product1}={product2}");
            }
            
            else
            {
                Console.WriteLine($"{product1}<{product2}");
            }
        }
        public static bool operator ==(Product  pr1, Product pr2)
        {
            if (pr1.Price  == pr2.Price)
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Product pr1, Product pr2)
        {
            if (pr1.Price != pr2.Price)
            {
                return true;
            }
            return false;
        }

        public static bool operator >(Product pr1, Product pr2)
        {
            return pr1.Price > pr2.Price;
        }
        public static bool operator <(Product pr1, Product pr2)
        {
            return pr1.Price < pr2.Price;
        }
    }
}
