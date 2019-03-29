using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            for (i = 5; i > 0; i--)
            {
                for (j = i; j > 0; j--)
                {
                    Console.Write("@");
                }

                Console.WriteLine("");
            }
            Console.ReadKey();
        }
    }
}
