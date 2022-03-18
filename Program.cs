using System;
using System.Collections.Generic;

namespace CFPL_Interpreter_Console
{
	class Program
	{
		static void Main(string[] args)
		{
			// if(args.Length == 0)
			// {
			// 	Console.WriteLine("Please specifiy file");
			// 	return;
			// }
			Interpreter inter = new Interpreter("test.cpfl");
			try
			{
				inter.Run();
			}
			catch(ErrorException e)
			{
				Console.WriteLine(e.Message+"\n\nProgram exited with code -1.");
				Console.ReadKey();
				return;
			}

			Console.WriteLine("\n\nProgram successfully exited code 0.");
			Console.ReadKey();
		}
	}
}
