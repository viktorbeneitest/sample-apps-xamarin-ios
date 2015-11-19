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
			string bundleID = "com.bitfall.creditcardvalidator";
			string deviceUDID = Environment.GetEnvironmentVariable ("IOS_SIMULATOR_UDID");

			ConfigureApp
				.iOS
				.InstalledApp(bundleID)
				.DeviceIdentifier(deviceUDID)
				.StartApp();
		}

		[Test]
		public void AssertTrue()
		{
			Assert.True (true);
		}
	}
}


