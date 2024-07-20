using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assm5_oop.Abstraction
{
    internal abstract class Shape
    {
        public decimal Dim01 { get; set; }
        public decimal Dim02 { get; set; }

        public abstract decimal CalcAre();

        public abstract  decimal Perimeter { get; }

        public Shape(decimal dim01 , decimal dim2)
        {

            Dim01 = dim01;
            Dim02 = dim2;
        }
    }

    class RectBase : Shape
    {
        public RectBase(decimal dim01 , decimal dim02) : base (dim01 , dim02)
        {}
        public override decimal CalcAre()
        {
            return Dim01 + Dim02;
        }
    }

    class Rectangle : RectBase
    {
        public Rectangle(decimal dim01, decimal dim02) : base(dim01, dim02)
        {
        }

        public override decimal Perimeter
        {
            get { return 2 * (Dim01 + Dim02); }
        }


    }

    class Square : RectBase
    {
        public Square (decimal Dim) : base(Dim , Dim)
        {
            Dim01 = Dim02 = Dim;
        }
        public override decimal Perimeter
            {
            get { return Dim01 * 4; }
            }

    
    }

    class Circle : Shape
    {
        public Circle(decimal Redius) : base(Redius , Redius)
        {
            Dim01 = Dim02 = Redius;
        }
        public override decimal Perimeter
            => 2 * 3.14M * Dim01;

        public override decimal CalcAre()
        {
            return 3.14M * Dim01 * Dim01;
        }
    }
}
