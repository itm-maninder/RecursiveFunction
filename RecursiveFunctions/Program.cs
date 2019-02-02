using System;
using System.Diagnostics;
using System.Threading;

namespace RecursiveFunctions
{
	class Program
	{
		
		static void Main(string[] args)
		{
			if(args!=null && args.Length == 2)
			{
				int v1 = int.Parse(args[0]);
				int v2 = int.Parse(args[1]);

				if (v1 < 0 || v2 < 0)
					Console.WriteLine("Both nums have to be positive");
				else
				{
					var tsmain = new Stopwatch();
					tsmain.Start();
					var ts = CalcExecuteTime(v1, v2, tsmain);
				}				
			}
			else
			{
				Console.WriteLine("Use appname num1 num2");
				Console.WriteLine("Both nums have to be positive");
			}			
			//Console.ReadLine();
		}

		private static long CalcExecuteTime(int v1, int v2, Stopwatch ts)
		{
			Thread.Sleep(1);
			Console.WriteLine($"V1:{v1} V2:{v2} ms:{ts.ElapsedMilliseconds}");

			if (v1 == v2)
			{
				ts.Stop();
				return ts.ElapsedMilliseconds;
			}
			else if (v1>v2)
			{
				v1--;
				return CalcExecuteTime(v1, v2,ts);
			}
			else
			{
				v2--;
				return CalcExecuteTime(v1, v2,ts);
			}
		}
	}
}
