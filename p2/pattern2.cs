using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Class1
    {
        static void Main(string[] args) {

            String s1;
            Console.WriteLine("size of an array");
            s1= Console.ReadLine();
        
            int i, j;
            for (i = 1; i <= 4; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }

                Console.WriteLine("");
            }
            Console.ReadKey();



        }
    }
}
