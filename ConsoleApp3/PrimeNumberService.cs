using System;

namespace ConsoleApp3
{
	public class PrimeNumberService
	{
		public bool IsPrimeNumer(int i)
		{
			if (i < 1)
			{
				throw new InvalidOperationException();
			}
			if (i == 1)
			{
				return false;
			}
			if (i == 2)
			{
				return true;
			}

			for (int j = 2; j < i; j++)
			{
				if (i % j == 0)
				{
					return false;
				}
			}

			return true;
		}
	}
}
