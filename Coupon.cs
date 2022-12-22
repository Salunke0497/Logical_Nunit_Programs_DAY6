using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logocalprogram
{
    internal class Coupon
    {
        public static char[] Num = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz".ToCharArray();
        public static void coup()
        {
            Console.WriteLine("Enter N number of coupon: ");
            int N = Convert.ToInt32(Console.ReadLine());

            int CLength = 6;

            Random random = new Random();

            for (int CNum = 1; CNum <= N; CNum++)
            {
                StringBuilder STRING = new StringBuilder();
                for (int i = 0; i < CLength; i++)
                {
                    int position = random.Next(0, Num.Length);
                    STRING.Append(Num[position]);
                }
             Console.WriteLine("Unique Coupon Number - {0}:  {1}", CNum, STRING);
            }
        }
    }
}
