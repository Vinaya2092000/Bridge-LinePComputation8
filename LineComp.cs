using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison8
{
    // //Already using class so attaching same program
    public class LineComp
    {
        //equality of two lines based on the end points,
        public void Length()
        {
            Console.WriteLine("Enter the line point x1: ");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the line point x2: ");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the line point y1: ");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the line point y2: ");
            int y2 = Convert.ToInt32(Console.ReadLine());
            var len1 = Math.Sqrt((Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)));
            Console.WriteLine(len1);

            Console.WriteLine("Enter the line point x3: ");
            int x3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the line point x4: ");
            int x4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the line point y3: ");
            int y3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the line point y4: ");
            int y4 = Convert.ToInt32(Console.ReadLine());
            var len2 = Math.Sqrt((Math.Pow(x3 - x4, 2) + Math.Pow(y3 - y4, 2)));
            Console.WriteLine(len2);
            if (len1.Equals(len2))
            {
                Console.WriteLine("The two lines are equal");
            }
            else if (len1 < len2)
            {
                Console.WriteLine(" Line 1 is lesser than Line 2");
            }
            else if (len2 < len1)
            {
                Console.WriteLine(" Line 1 is greater than Line 2");
            }
            else
            {
                Console.WriteLine("lines are not equal");
            }
        }
    }
}
