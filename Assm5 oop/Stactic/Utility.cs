using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assm5_oop.Stactic
{
    internal static class Utility
    {
        //public int X { get; set; }
        //public int Y { get; set; }

        //public Utility(int x , int y) {
        //    X = x;
        //    Y = y;
        //    //pi = 3.14;
        //}


           static Utility()
        {
            //pi = 3.14;
        }





        //public override string ToString()
        //{
        //    return $"X = {X} , Y = {Y}";
        //}

        public static double CmToInCh(double cm)
        {
            return cm / 2.45;
        }


        //private readonly static double pi = 3.14;

        private const double pi = 3.14;

        public static double PI
        {
            get { return pi; }
            //set { pi = value; }
        }

        public static double CalcCircle(double R)
        {
            return PI * R * R;
        }

 
    }
}
