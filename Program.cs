using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_8
{
    class Program
    {
        static void Main(string[] args)

        {
            //Declaring variables
            int [] a = new int [5];
            int x = 0;

            do
            {
                //Requesting data from the user
                Console.Write(" Enter the first number: ");
                x = Convert.ToInt32(Console.ReadLine());
                a[0] = x;
            }
            while (a[0] < 0 || a[0] > 147483647);

            do
            {
                Console.Write(" Enter the second number: ");
                x = Convert.ToInt32(Console.ReadLine());
                a[1] = x;
            }
            while ( a[1]< 0 && a[1] > 147483647);

            do
            {
                Console.Write(" Enter the third number: ");
                x = Convert.ToInt32(Console.ReadLine());
                a[2] = x;
            }
            while (a[2] < 0 && a[2] > 147483647);

            do
            {
                Console.Write(" Enter the fourth number: ");
                x = Convert.ToInt32(Console.ReadLine());
                a[3] = x;
            }
            while (a[3] < 0 && a[3] > 147483647);

            do
            {
                Console.Write(" Enter the fifth number: ");
                x = Convert.ToInt32(Console.ReadLine());
                a[4] = x;
            }
            while (a[4] < 0 && a[4] > 147483647);

            //Calculated
            for (int i = 0; i<4; i++)
            {
                if (a[i] >= a[i + 1])
                {
                    
                    a[i + 1] = a[i];
                }
                x = a[i+1];
            }

            //Showing result
            Console.WriteLine(" The greatest number is: {0}", x);

            Console.ReadKey();
          
            
        }
    }
}
