using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logocalprogram
{
    internal class fibonacci
    {
        public static void fibbo()
        {
            int a = 0;
            int b = 1;
            int c;
            Console.WriteLine("---ENTER NUMBER HERE---");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a);
            Console.WriteLine(b);
            for (int i = 0; i < x; i++)
            {
                c = a + b;
                a = b;
                b = c;
                Console.WriteLine(c);

            }
        }
    }
}
