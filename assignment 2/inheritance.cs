using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Car    {

        public String name;

        public Car(String name)
        {
            this.name = name;
        }
        public Car()
        {        
		}

    }

    class Maruti : Car
    {

        public Maruti(String name): base(name) { }

        public void display()
        {
            Console.WriteLine(name);
        }
    }

    class Mahindra : Car
    {
        public Mahindra(String name) : base(name) { }

        public void display()
        {
            Console.WriteLine(name);
        }
    }

    class MainClass
    {
        public static void Main()
        {
            Maruti maruti = new Maruti("maruti 800");
            Mahindra mahindra = new Mahindra("XUV 500");
            mahindra.display();
            maruti.display();
			Console.ReadKey();
	   }
    }
}
