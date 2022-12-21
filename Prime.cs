using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logocalprogram
{
    internal class Prime
    {
        public static void pri()
        {
            int i=2;
            Console.WriteLine("--ENTER NUMBER HERE--");
            int x = Convert.ToInt32(Console.ReadLine());
                while (x % i != 0)
                {
                    i++;
                }
                if (x == i)
                {
                    Console.WriteLine(x + " : IS PRIME NUMBER ");
                }
                else
                {
                    Console.WriteLine(x + " : IS NOT NUMBER ");
                }
        }
    }
}

