using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Lesson_1_OOP
{
    class Appliances : Product
    {
        public int Power { get; set; }
        public string EnergyClass { get; set; }
        public string Type { get; set; }
    }
}
