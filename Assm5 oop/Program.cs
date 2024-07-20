using Assm5_oop.operter_Overloading;

namespace Assm5_oop
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region Opertaor Over LOading



            Complex C1 = new Complex() { Real = 3, Imag = 5 };

            Console.WriteLine(C1);

            Complex C2 = new Complex() { Real = 2, Imag = 4 };

            Console.WriteLine(C2);


            #region Binary

            //Complex C3 = C1 + C2;

            //Console.WriteLine("============");

            //Console.WriteLine(C3);

            //Complex C3 = C1 - C2;
            //Console.WriteLine("============");

            //Console.WriteLine(C3);


            //Complex C3 = default;
            //C3 += C1;

            //Console.WriteLine(C3);
            #endregion



            #endregion




        }
    }
}
