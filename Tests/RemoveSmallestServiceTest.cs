using ConsoleApp3;
using Xunit;

namespace Tests
{
	public class RemoveSmallestServiceTest
	{
		[Fact]
		public void IsOk()
		{
			var service = new RemoveSmallestService();
			var numbers = new int[] { 12, 65, 34, 10, 3, 1 };
			numbers = service.RemoveSmallestValue(numbers);
			Assert.DoesNotContain(1, numbers);
		}
	}
}
