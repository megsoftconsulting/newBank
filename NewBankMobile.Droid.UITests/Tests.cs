using System;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Android;
using Xamarin.UITest.Queries;

namespace NewBankMobile.Droid.UITests
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void BeforeEachTest()
        {
            var path = @"../../../NewBankMobile.Droid/bin/Debug/";
            var apkName = "com.megsoftconsulting.talk.newbankmobile.apk";
            var apkPath = $"{path}{apkName}";

            app = ConfigureApp
                .Android
                .ApkFile(apkPath)
                .EnableLocalScreenshots()
                //.PreferIdeSettings()
                //.DeviceSerial("")
                .StartApp();
        }

        private AndroidApp app;

        [Test]
        public void ClickingButtonTwiceShouldChangeItsLabel()
        {
            Func<AppQuery, AppQuery> MyButton = c => c.Button("myButton");

            app.Tap(MyButton);
            app.Tap(MyButton);
            var results = app.Query(MyButton);
            app.Screenshot("Button clicked twice.");

            Assert.AreEqual("2 clicks!", results[0].Text);
        }
    }
}