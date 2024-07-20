using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assm5_oop.partial
{
    internal partial class Employee
    {
        public void Print() {
            Console.WriteLine("iam employee");
        }

        public int Test {  get; set; }

        public partial void Tst()
        {
            Console.WriteLine("Done");     
        }
    }
}
