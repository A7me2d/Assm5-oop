using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assm5_oop.operter_Overloading
{
    internal class Complex
    {
        public int Real { get; set; }

        public int Imag { get; set; }

        public override string ToString()
        {
            return $"{Real} + {Imag}i" ;
        }


        #region Operators Over
        public static Complex operator +(Complex Left, Complex Right)
        {
            return new Complex
            {
                Real = (Left?.Real ?? 0) + (Right?.Real ?? 0),
                Imag = (Left?.Imag ?? 0) + (Right?.Imag ?? 00)

            };
        }

        public static Complex operator -(Complex Left, Complex Right)
        {
            return new Complex
            {
                Real = (Left?.Real ?? 0) - (Right?.Real ?? 0),
                Imag = (Left?.Imag ?? 0) - (Right?.Imag ?? 0)
            };
        }

        public static Complex operator ++(Complex C)
        {
            return new Complex
            {
                Real = (C?.Real ?? 0) + 1,
                Imag = (C?.Imag ?? 0)
            };
        }

        public static Complex operator --(Complex C)
        {
            return new Complex()
            {
                Real = (C?.Real ?? 0) - 1,
                Imag = (C?.Imag ?? 0)
            };
        }

        public static bool operator >(Complex Left, Complex Right)
        {
            if (Left.Real == Right.Imag)
                return Left.Imag > Right.Imag;
            else
                return Left.Real > Right.Real;
        }

        public static bool operator <(Complex Left, Complex Right)
        {
            if (Left.Real == Right.Imag)
                return Left.Imag < Right.Imag;
            else
                return Left.Real < Right.Real;
        }

        #endregion

        #region Casting
        public static explicit operator int ( Complex C)
        {
            return C?.Real ?? 0;
        }

        public static implicit operator double(Complex C)
        {
            return C?.ToString() ?? string.Empty;
        }
        #endregion

    }
}
