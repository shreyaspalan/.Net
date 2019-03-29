using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace p2
{
	class ListFile
	{
		public static void Main() 
		{
		
			using (StreamReader SR = new StreamReader(@"C:\Users\shreyas\Desktop\assignment 5\f2.txt")) {
            string line = null;
            while ((line = SR.ReadLine()) != null) {
               Console.WriteLine(line);
            }
         }
		
		}
	}
}