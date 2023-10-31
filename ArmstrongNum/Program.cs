using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmstrongNum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Can you give the number maybe?");
            string numstr = Console.ReadLine();
            int total = ArmstrongNumbers(numstr);

            if (total == int.Parse(numstr))
            {
                Console.WriteLine("That's an Armstrong Number!!");
            } else
            {
                Console.WriteLine("That's not an Armstrong Number!!");
            }
            Console.ReadLine();
        }
        
        static int ArmstrongNumbers(string numstr)
        {
            int num = int.Parse(numstr);
            int total = 0;

            for (int i = 0; i < numstr.Length; i++)
            {
                int digit = int.Parse(numstr[i].ToString());
                total += (int)Math.Pow(digit, numstr.Length);
            }

            return total;
        }
       
    }
}
