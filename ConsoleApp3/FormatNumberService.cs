namespace ConsoleApp3
{
	public class FormatNumberService
	{
		public string FormatNumber(int i)
		{
			if (i < 1000)
			{
				return i.ToString();
			}

			var r = i / 1000;
			var l = i % 1000;

			return $"{r},{l.ToString("000")}";
		}
	}
}
