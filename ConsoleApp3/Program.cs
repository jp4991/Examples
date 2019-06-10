using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Diagnosers;
using BenchmarkDotNet.Running;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace ConsoleApp3
{
	class Program
	{
		static void Main(string[] args)
		{
			void T()
			{

			}

			var number = new int[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
			var span = new Span<int>(number, 3, 2);
			foreach(int i in span)
			{
				Console.WriteLine($"{ i }");
			}
		}

		private static void ChangeTuple(ref (int m1, int m2) tuple1)
		{
			tuple1.m1 = 12;
			tuple1.m2 = 12;
		}

		public struct s : IEquatable<s>
		{
			public s(int t, int t1)
			{
				MyProperty1 = t;
				MyProperty2 = t1;
			}

			public int MyProperty1 { get; set; }
			public int MyProperty2 { get; set; }

			public void S()
			{
				Console.WriteLine("S");
			}

			public override int GetHashCode() => "ASD".GetHashCode();

			public bool Equals(s other)
			{
				throw new NotImplementedException();
			}
		}

		public static (int, int) GetMaxMin(IEnumerable<int> list)
		{
			using (var interator = list.GetEnumerator())
			{
				if (!interator.MoveNext())
				{
					throw new InvalidOperationException();
				}

				var tmpMax = interator.Current;
				var tmpMin = interator.Current;

				while (interator.MoveNext())
				{
					tmpMax = Math.Max(tmpMax, interator.Current);
					tmpMin = Math.Min(tmpMin, interator.Current);
				}

				return (tmpMax, tmpMin);
			}
		}
	}
}
