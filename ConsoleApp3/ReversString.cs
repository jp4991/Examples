using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp3
{
	public class ReversString
	{
		public string Revers(string str)
		{
			return new string(str.ToCharArray().Reverse().ToArray());
		}
	}
}
