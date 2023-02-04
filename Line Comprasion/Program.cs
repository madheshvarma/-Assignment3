using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
namespace Line_Comprasion
{
    internal class Program
    {
        public class LineComparison
        {
            int x1, y1, x2, y2;
            public static void FindLine()
            {
                Console.WriteLine("Please enter the Coordinates : ");
                var x1 = Convert.ToInt32(Console.ReadLine());
                var y1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter the Coordinates : ");
                var x2 = Convert.ToInt32(Console.ReadLine());
                var y2 = Convert.ToInt32(Console.ReadLine());

                var finalResult = Distance(x1, x2, y1, y2);

                Console.WriteLine("Distance between coordinates {0},{1} and {2},{3} is {4}", x1, y1, x2, y2, finalResult);
            }
            private static double Distance(double x1, double x2, double y1, double y2)

            {
                var temp1 = Math.Pow((x2 - x1), 2);
                var temp2 = Math.Pow((y2 - y1), 2);
                var result = Math.Sqrt(temp1 + temp2);
                return result;
            }
        }
    }

    
    
}
