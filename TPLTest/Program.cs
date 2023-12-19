using System.Diagnostics;

namespace TPLTest
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Task<long> task = Task.Run(static () =>
			{
				long sum = 0;

				for (int i = 0; i < 1E09; i++)
					sum += i;

				return sum;
			});

			Console.WriteLine("Task running...");

			//long result = task.Result; // blocking method of getting result

			//Console.WriteLine("Task completed. Result: {0}", result);

			task.ContinueWith(t => CalcFinished(t));
			Console.WriteLine("Tasl still running");
			Console.ReadLine();
		}


		static void CalcFinished(Task<long> task)
		{
			Console.WriteLine("Task completed. Result: {0}", task.Result);
		}
	}
}