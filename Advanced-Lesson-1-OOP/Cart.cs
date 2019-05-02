using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Lesson_1_OOP
{
    class Cart
    {
        private List< Product > Products { get; set; }
        private double TotalPrice { get; set; }
        private Promotion Promo { get; set; }
        private Customer Customer { get; set; }
        private List<Promotion> Promotions { get; set; }
    }
}
