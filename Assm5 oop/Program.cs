﻿using Assm5_oop.Casting_Opertot_Overloading;
using Assm5_oop.operter_Overloading;

namespace Assm5_oop
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region Opertaor Over LOading



            //Complex C1 = new Complex() { Real = 3, Imag = 5 };

            //Console.WriteLine("C1" , C1);

            //Complex C2 = new Complex() { Real = 2, Imag = 4 };

            //Console.WriteLine(C2);

            //Complex C3 = default;

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

            #region Unary Operator
            //C3 = ++C1;

            //C3 = C1++;
            //C3 = --C1;
            //Console.WriteLine("=================");
            //Console.WriteLine("C3 ", C3);
            //Console.WriteLine("C1", C1);

            #endregion


            #region Construct

            //if(C1 > C2)

            //    Console.WriteLine("C1 is greater than C2");

            //else if (C1 < C2)

            //    Console.WriteLine("C1 is less than C2");
            #endregion





            #endregion


            #region Casting Operations OverLoading

            //object obj = 2;
            // int X = (int)obj;

            //Complex C1 = new Complex() { Real = 2, Imag = 4 };
            //string S1 =  C1;
            // S1 =(string) C1;
            //Console.WriteLine(S1);


            //int Y = (int)C1;

            //    Console.WriteLine(C1);
            //    Console.WriteLine(Y);
            #endregion


            #region 

            //Employee employee = new Employee()
            //{
            //    Id = 10,
            //    Fullname = "Ahmed Hany",
            //    Password = "Pssword",
            //    Email = "john.doe@gmail.com",
            //    SecurtyStamp = Guid.NewGuid(),
            //};

            //EmployeeViewModel viewModel = new EmployeeViewModel();

            //viewModel = (EmployeeViewModel)employee;

            //Console.WriteLine(viewModel.FirstName);
            //Console.WriteLine(viewModel.LastName);

        //    object obj = new EmployeeViewModel() { FirstName = "John", LastName = "Hany" , Email = "Ahmed@gmailcom
        //}
  
        //    EmployeeViewModel E = (EmployeeViewModel)obj;

            #endregion


            #region

            #endregion



        }
    }
}
