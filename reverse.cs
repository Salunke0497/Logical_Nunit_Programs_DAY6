using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logocalprogram
{
    internal class reverse
    {
        
        public static void rev()
        {
            int result = 0;
            int remainder;
            int x;
            Console.WriteLine("--ENTER NUMBER HERE--");
            x=Convert.ToInt32(Console.ReadLine());
            while(x!=0)
            {
                remainder = x % 10;
                result = result * 10 + remainder;
                x = x / 10;
            }
            Console.WriteLine("-----------------------");
            Console.WriteLine("Your Reverse Number Is");
            Console.WriteLine(result);

        }
        
    }
}
