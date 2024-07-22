using Assm5_oop.Class;

namespace Assm5_oop
{
    internal class Program
    {
        static Point3D ReadPointFromUser(string pointName)
        {
            int x, y, z;
            while (true)
            {
                try
                {
                    Console.Write($"Enter X coordinate for {pointName}: ");
                    x = Convert.ToInt32(Console.ReadLine());

                    Console.Write($"Enter Y coordinate for {pointName}: ");
                    y = Convert.ToInt32(Console.ReadLine());

                    Console.Write($"Enter Z coordinate for {pointName}: ");
                    z = Convert.ToInt32(Console.ReadLine());

                    return new Point3D(x, y, z);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter integer values for coordinates.");
                }
            }
        }

            static void Main(string[] args)
        {

            #region First Project

            #region Q1

            //Point3D point3D = new Point3D();

            //point3D.X = 10;
            //point3D.Y = 20;
            //point3D.Z = 30;

            //Console.WriteLine(point3D);

            #endregion

            #region Q2 
            //Point3D P = new Point3D(10, 10, 10);

            //Console.WriteLine(P.ToString());

            #endregion

            #region Q3 
            //Point3D P1 = ReadPointFromUser("P1");
            //Point3D P2 = ReadPointFromUser("P2");

            //Console.WriteLine(P1.ToString());
            //Console.WriteLine(P2.ToString());
            #endregion

            #region Q4 
            //Point3D P1 = ReadPointFromUser("P1");
            //Point3D P2 = ReadPointFromUser("P2");

            //Console.WriteLine(P1.ToString());
            //Console.WriteLine(P2.ToString());
            //if (P1 == P2)
            //{
            //    Console.WriteLine("P1 and P2 are equal.");
            //}
            //else
            //{
            //    Console.WriteLine("P1 and P2 are not equal.");
            //}
            #endregion

            #region Q5 

            //    Point3D[] points = new Point3D[]
            //   {
            //        new Point3D(3, 2, 5),
            //        new Point3D(1, 5, 8),
            //        new Point3D(3, 1, 7),
            //        new Point3D(2, 4, 9),
            //        new Point3D(1, 3, 6)
            //   };

            //    Console.WriteLine("Before sorting:");
            //    foreach (var point in points)
            //    {
            //        Console.WriteLine(point);
            //    }

            //    Array.Sort(points, ComparePoints);

            //    Console.WriteLine("\nAfter sorting:");
            //    foreach (var point in points)
            //    {
            //        Console.WriteLine(point);
            //    }
            //}

            //static int ComparePoints(Point3D p1, Point3D p2)
            //{
            //    int result = p1.X.CompareTo(p2.X);
            //    if (result == 0)
            //    {
            //        result = p1.Y.CompareTo(p2.Y);
            //    }
            //    return result;

            #endregion

            #region Q6


            // Point3D[] points = new Point3D[]
            //{
            //     new Point3D(3, 2, 5),
            //     new Point3D(1, 5, 8),
            //     new Point3D(3, 1, 7),
            //     new Point3D(2, 4, 9),
            //     new Point3D(1, 3, 6)
            //};

            // Console.WriteLine("Before sorting:");
            // foreach (var point in points)
            // {
            //     Console.WriteLine(point);
            // }

            // Array.Sort(points);

            // Console.WriteLine("\nAfter sorting:");
            // foreach (var point in points)
            // {
            //     Console.WriteLine(point);
            // }


            // Point3D clonedPoint = (Point3D)points[0].Clone();
            // Console.WriteLine("\nCloned Point:");
            // Console.WriteLine(clonedPoint);

            // clonedPoint.X = 99;
            // clonedPoint.Y = 99;
            // clonedPoint.Z = 99;

            // Console.WriteLine("\nAfter modifying the cloned point:");
            // Console.WriteLine("Original Point: " + points[0]);
            // Console.WriteLine("Cloned Point: " + clonedPoint);
            #endregion

            #endregion

            #region Second Project

            //int x = 10;
            //int y = 5;


            //int sum = Maths.Add(x, y);
            //int difference = Maths.Subtract(x, y);
            //int product = Maths.Multiply(x, y);
            //double quotient = Maths.Divide(x, y);

            //Console.WriteLine($"Add: {x} + {y} = {sum}");
            //Console.WriteLine($"Subtract: {x} - {y} = {difference}");
            //Console.WriteLine($"Multiply: {x} * {y} = {product}");
            //Console.WriteLine($"Divide: {x} / {y} = {quotient}");

            #endregion

            #region Third Project

            #region Q1.2
            //Duration d1 = new Duration(1, 30, 45);
            //Duration d2 = new Duration(1, 30, 45);
            //Duration d3 = new Duration(2, 15, 30);

            //Console.WriteLine("Duration 1: " + d1.ToString());
            //Console.WriteLine("Duration 2: " + d2.ToString());
            //Console.WriteLine("Duration 3: " + d3.ToString());

            //Console.WriteLine("d1 equals d2: " + d1.Equals(d2));
            //Console.WriteLine("d1 equals d3: " + d1.Equals(d3));

            //Console.WriteLine("Hash code of d1: " + d1.GetHashCode());
            //Console.WriteLine("Hash code of d2: " + d2.GetHashCode());
            //Console.WriteLine("Hash code of d3: " + d3.GetHashCode());

            #endregion


            #region Q3
            //Duration d1 = new Duration(1, 10, 15);
            //Console.WriteLine(d1.ToString()); 

            //Duration d2 = new Duration(3600);
            //Console.WriteLine(d2.ToString());

            //Duration d3 = new Duration(7800);
            //Console.WriteLine(d3.ToString()); 

            //Duration d4 = new Duration(666);
            //Console.WriteLine(d4.ToString());

            #endregion


            #region Q4

            //Duration d1 = new Duration(1, 10, 15);
            //Duration d2 = new Duration(7800);

            //Duration d3 = d1 + d2;
            //Console.WriteLine("D3 (d1 + d2): " + d3.ToString());

            //d3 = d1 + 7800;
            //Console.WriteLine("D3 (d1 + 7800): " + d3.ToString());

            //d3 = 666 + d3;
            //Console.WriteLine("D3 (666 + d3): " + d3.ToString());

            //d3 = ++d1;
            //Console.WriteLine("D3 (++d1): " + d3.ToString());

            //d3 = --d2;
            //Console.WriteLine("D3 (--d2): " + d3.ToString());

            //d1 = d1 - d2;
            //Console.WriteLine("D1 (d1 - d2): " + d1.ToString());

            //Console.WriteLine("d1 > d2: " + (d1 > d2));
            //Console.WriteLine("d1 <= d2: " + (d1 <= d2));

            //if (d1)
            //{
            //    Console.WriteLine("d1 is not zero.");
            //}
            //else
            //{
            //    Console.WriteLine("d1 is zero.");
            //}

            //DateTime dt = (DateTime)d1;
            //Console.WriteLine("DateTime representation of d1: " + dt);
            #endregion

            #endregion


        }
    }
}
