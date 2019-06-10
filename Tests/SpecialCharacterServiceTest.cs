using ConsoleApp3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace Tests
{
	public class SpecialCharacterServiceTest
	{
		[Fact]
		public void ShouldRemoveSpecialCharacters()
		{
			var sprecialCharacter = new char[] { '!', '$', '(', ')', '-', '@', '#', '%', '^', '\\' };
			var strings = new string[] { "The quick brown fox!", "% fd76$fd(-)6GvKlO.", "D0n$c sed 0di0 du1" };
			var service = new SpecialCharacterService();

			foreach(var s in strings)
			{
				var s2 = service.RemoveSpecialCharacter(s);
				Assert.DoesNotContain(s2.ToCharArray(), x => sprecialCharacter.Contains(x));
			}
		}
	}
}
