using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assm5_oop.Sealed
{
    internal class Parent
    {

        private int salary;
        public virtual int Salary
        {
            get { return Salary; }
            set { Salary = value + 100; }
        }
        public virtual void Print() 
        {

            Console.WriteLine("hello from Parent");
        }
    }

    internal class Child : Parent
    {
        public sealed override void Print()
        {
            Console.WriteLine("hello from Child");
        }


        public sealed override int Salary 
        {
            get => base.Salary;
            set => base.Salary = value < 5000 ? 5000 : value;
        }
    }

    class GrandChild : Child
    {
        //public override void Print()
        //{
        //    Console.WriteLine("hello from GrndChild");
        //}
    }
}
