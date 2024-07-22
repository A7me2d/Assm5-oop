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
            //Point3D point3D = new Point3D();

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
        }


    }
}
