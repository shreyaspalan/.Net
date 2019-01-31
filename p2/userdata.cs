using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Class2
    {
        static void Main(String[] args)
        {
            String s1, s2;
            Console.WriteLine("Enter Your Name: ");
            s1 = Console.ReadLine();
            Console.WriteLine("Enter Your Country: ");
            s2 = Console.ReadLine();
            Console.WriteLine("Hello {0} from Country {1} ", s1, s2);
        }
    }
}
