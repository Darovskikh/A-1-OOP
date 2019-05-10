using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Lesson_1_OOP
{
    class Order
    {
        public int OrderNumber { get; private set; }
        public string CustomerFullName { get; private set; }
        public string DeliveryAdress { get; private set; }
        public double OrderPrice { get; private set; }
        public List<Product> Products { get; private set; }
        private Customer Customer { get;  set; }
    }
}
