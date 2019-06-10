using System;
using System.Linq;

namespace ConsoleApp3
{
	public class PhoneNumberValidation
	{
		public bool IsPhoneNumberFormatedCorrectly(string phoneNumber)
		{
			var span = phoneNumber.AsSpan();
			if (span.Length != 14
				|| span[0] != '('
				|| span[4] != ')'
				|| span[5] != ' '
				|| span[9] != '-')
			{
				return false;
			}

			if (!AreAllCharactersNumeric(span.Slice(1, 3))
				|| !AreAllCharactersNumeric(span.Slice(6, 3))
				|| !AreAllCharactersNumeric(span.Slice(10, 4)))
			{
				return false;
			}

			return true;
		}

		public bool AreAllCharactersNumeric(ReadOnlySpan<char> span)
		{
			foreach (char c in span)
			{
				if (!Char.IsNumber(c))
				{
					return false;
				}
			}
			return true;
		}
	}
}
