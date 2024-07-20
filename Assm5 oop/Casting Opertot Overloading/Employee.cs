using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assm5_oop.Casting_Opertot_Overloading
{
    internal class Employee
    {
        public int Id { get; set; }
        public string? Fullname { get; set; }
        public string? Email { get; set; }

        public string? Password { get; set; }

        public Guid SecurtyStamp { get; set; }
    }
}
