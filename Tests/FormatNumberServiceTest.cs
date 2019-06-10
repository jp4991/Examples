using ConsoleApp3;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Tests
{
	public class FormatNumberServiceTest
	{
		[Fact]
		public void ShouldCorrectlyFormatsNumber()
		{
			var service = new FormatNumberService();

			Assert.Equal("20", service.FormatNumber(20));
			Assert.Equal("1,020", service.FormatNumber(1020));
			Assert.Equal("1,000", service.FormatNumber(1000));
		}
	}
}
