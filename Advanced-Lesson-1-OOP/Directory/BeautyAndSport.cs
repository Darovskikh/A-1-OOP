using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Lesson_1_OOP
{
    class BeautyAndSport : Product
    {
        public string KindOfSport { get; set; }
        public enum Target
        {
            Men = 2,
            Women = 4,
            Kids = 8
        }
    }
    
}
