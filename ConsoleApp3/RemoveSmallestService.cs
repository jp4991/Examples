using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp3
{
	public class RemoveSmallestService
	{
		public int[] RemoveSmallestValue(int[] array) => array.OrderBy(x => x).Skip(1).ToArray();
	}
}
