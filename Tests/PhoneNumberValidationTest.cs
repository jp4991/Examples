using ConsoleApp3;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Tests
{
	public class PhoneNumberValidationTest
	{
		[Fact]
		public void PhoneNumbersFormatedCorrectly()
		{
			var service = new PhoneNumberValidation();
			Assert.True(service.IsPhoneNumberFormatedCorrectly("(123) 342-2354"));
			Assert.False(service.IsPhoneNumberFormatedCorrectly("(123)342 2354"));
			Assert.False(service.IsPhoneNumberFormatedCorrectly("(123) 342 2354"));
		}
	}
}
