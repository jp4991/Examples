using ConsoleApp3;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Tests
{
	public class EmailValidationServiceTest
	{
		[Fact]
		public void ValidateEmails()
		{
			var service = new EmailValidationService();
			var invalidEmails = new string[]
			{
				"@edabit.com",
				"hello.email@com",
				"hello.email@"
			};
			foreach (var t in invalidEmails)
			{
				Assert.False(service.IsOk(t));
			}

			var validEmails = new string[]
			{
				"e@edabit.com",
				"john.smith@email.com"
			};
			foreach (var t in validEmails)
			{
				Assert.True(service.IsOk(t));
			}

		}
	}
}
