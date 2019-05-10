using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Lesson_1_OOP
{
    class Customer
    {
        public string NickName { get; private set; }
        public string PhoneNumber { get; private set; }
        public  string FullName { get;  private set; }
        public  string Adress { get; private set; }
        private Cart Cart { get; set; }
        private List <Order> Orders { get; set; }
        
    }
}
