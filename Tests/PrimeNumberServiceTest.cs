using ConsoleApp3;
using System;
using Xunit;

namespace Tests
{
	public class PrimeNumberServiceTest
	{
		[Fact]
		public void ShouldThrowExceptionIfNumberIsSmallerThen1()
		{
			var service = new PrimeNumberService();
			Assert.Throws<InvalidOperationException>(() => service.IsPrimeNumer(-1));
			Assert.Throws<InvalidOperationException>(() => service.IsPrimeNumer(0));
		}

		[Fact]
		public void ShouldReturnsTrueForPrimeNumber()
		{
			var service = new PrimeNumberService();
			Assert.True(service.IsPrimeNumer(2));
			Assert.True(service.IsPrimeNumer(3));
			Assert.True(service.IsPrimeNumer(7));
		}

		[Fact]
		public void ShouldReturnsFalseForNumberThatIsNotPrime()
		{
			var service = new PrimeNumberService();
			Assert.True(service.IsPrimeNumer(4));
			Assert.True(service.IsPrimeNumer(16));
			Assert.True(service.IsPrimeNumer(22));
		}
	}
}
