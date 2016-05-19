using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.iOS;
using Xamarin.UITest.Queries;

namespace CreditCardValidator.iOS.UITests
{
	[TestFixture]
	public class Tests
	{
		[SetUp]
		public void BeforeEachTest()
		{
			string appBundlePath = Environment.GetEnvironmentVariable ("APP_BUNDLE_PATH");

			if (appBundlePath != null && appBundlePath != "") {
				// In case of Bitrise step: steps-xamarin-uitest
				ConfigureApp
					.iOS
					.AppBundle (appBundlePath)
					.StartApp ();
			} else {
				// In case of Bitrise step: steps-xamarin-testcloud
				ConfigureApp
					.iOS
					.StartApp ();
			}
		}

		[Test]
		public void AssertTrue()
		{
			Assert.True (true);
		}
	}
}


