using System.Linq;

namespace ConsoleApp3
{
	public class EmailValidationService
	{
		public bool IsOk(string email)
		{
			if (string.IsNullOrEmpty(email))
			{
				return false;
			}

			var splited = email.Split('@');
			if (splited.Count() != 2)
			{
				return false;
			}

			if (string.IsNullOrEmpty(splited[0]))
			{
				return false;
			}

			if (string.IsNullOrEmpty(splited[1]))
			{
				return false;
			}

			if (!char.IsLetter(splited[0].First()))
			{
				return false;
			}

			if (splited[1].ToArray().Where(x => x == '.').Count() != 1)
			{
				return false;
			}

			return true;
		}
	}
}
