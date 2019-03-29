using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class MethodOverloding
    {

        public void add(int a, int b)
        {
            Console.WriteLine(a+b);
        }

        public void add(Vector v1, Vector v2)
        {
            Vector v3 = new Vector();
            v3.X = v1.X + v2.X;
            v3.Y = v1.Y + v2.Y;
			Console.WriteLine("x= {0} and y={1}",v3.X,v2.Y);
		}
	}
	  
	class MainClass
	{
	  
			static void Main(string[] args)
			{
				MethodOverloding m = new MethodOverloding();
				m.add(2,5);
				Vector v1 = new Vector();
				Vector v2 = new Vector();
				v1.X = 2;
				v1.Y = 3;
				v2.X = 4;
				v2.Y = 5;
				m.add(v1, v2);
			}
	}

    class Vector
    {
        int x, y;
		
		public int X{
			
			get{
				return x;
			}
			set{
				this.x = value;
			}
		}

		public int Y{
			
			get{
				return y;
			}
			set{
				this.y = value;
			}
		}
	}
}
