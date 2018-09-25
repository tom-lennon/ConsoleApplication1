using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication1.Subfolder;
using ConsoleApplication1.TestFolder;

namespace ConsoleApplication1 {
	class Program {
		static void Main(string[] args) {
			
			Console.WriteLine("A simple console application.");
			Console.WriteLine("Adding a new line to flag a change within SourceTree");
			Console.WriteLine("Adding a second line to flag a change from SourceTree to Github");
			//var s = new Subclass();
			//s.Write();
			TestClass.TestWrite();
		}
	}
}
