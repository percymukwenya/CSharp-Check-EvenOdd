using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckEven
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            Console.WriteLine("Please enter a number");
            i = int.Parse(Console.ReadLine());

            if(i%2==0)
            {
                Console.WriteLine("{0} is an even number", i);
            }
            else
            {
                Console.WriteLine("{0) is an odd number", i);
            }
        }
    }
}
