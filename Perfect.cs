using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logocalprogram
{
    internal class Perfect
    {
        public static void per()
        {
            int sum = 0;
            Console.WriteLine("ENTER NUMBER HERE");
            int x = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < x; i++)
            {
                if (x % i == 0)
                {
                    sum = sum + i;
                    Console.Write("divisior of x : " + i);
                }
            }
            
            if (sum == x)
            {
                Console.WriteLine(x + " : Is a perfect number ");
            }
            else
            {
                Console.WriteLine(x + " : Is Not a perfect number");
            }
        }
    }
}
    