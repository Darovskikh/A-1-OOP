using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Lesson_1_OOP
{
    class Electronics : Product
    {
        public int NumberOfCameras { get; set;}
        public bool IsWaterProof { get; set; }
        public int BatteryCapacity { get; set; }
    }
}
