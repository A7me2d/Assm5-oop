﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assm5_oop.Casting_Opertot_Overloading
{
    internal class EmployeeViewModel 
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }

        #region Casting Overloading
        public static explicit operator EmployeeViewModel(Employee employee)
        {
            string[]? Names = employee?.Fullname?.Split(" ");
            return new EmployeeViewModel()
            {
              Email = employee?.Email ?? string.Empty,
              FirstName = Names?.Length > 0 ? Names[0] : string.Empty,
              LastName = Names?.Length > 1 ? Names[1] : string.Empty

            };
        }
        #endregion

    }
}
