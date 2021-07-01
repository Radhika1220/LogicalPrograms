using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;

namespace LogicalPrograms
{
	/// <summary>
	/// P6-Calculate the Elapsed Time
	/// </summary>
	class StopWatch
	{
		public static void ElapsedTime()
		{
			
			Stopwatch stopwatch = new Stopwatch();
			stopwatch.Start();
			for (int i = 0; i < 1000; i++)
			{
				Thread.Sleep(1);
			}
			stopwatch.Stop();

			Console.WriteLine("Time elapsed: {0}",stopwatch.Elapsed);
		}
	}
}