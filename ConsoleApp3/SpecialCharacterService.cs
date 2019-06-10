using System;
using System.Linq;

namespace ConsoleApp3
{
	public class SpecialCharacterService
	{
		private readonly char[] _sprecialCharacter = new char[] { '!', '$', '(', ')', '-', '@', '#', '%', '^', '\\' };
		public string RemoveSpecialCharacter(string s)
		{
			var s2 = s.ToCharArray().Where(x => !_sprecialCharacter.Contains(x))
				.ToArray();
			return new string(s2);
		}
	}
}
