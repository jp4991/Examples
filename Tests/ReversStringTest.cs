using ConsoleApp3;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Tests
{
	public class ReversStringTest
	{
		[Theory]
		[InlineData("abc")]
		public void ShouldReverseStringCorrectly(string str)
		{
			var service = new ReversString();
			Assert.Equal("cba", service.Revers(str));
		}
	}
}
