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
			string[] Directories = Directory.GetDirectories(@"C:\Users\shreyas\Desktop\assignment 5");
			foreach (string dir in Directories)
				Console.WriteLine(dir);
			string[] files = Directory.GetFiles(@"C:\Users\shreyas\Desktop\assignment 5");
			foreach (string file in files) Console.WriteLine(file);

			Console.ReadKey();

		}
	}
}

