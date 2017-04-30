using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;
using Xamarin.UITest.Android;

namespace UITest
{
    [TestFixture]
    public class Tests
    {
        AndroidApp app;

        [SetUp]
        public void BeforeEachTest()
        {
            // TODO: If the Android app being tested is included in the solution then open
            // the Unit Tests window, right click Test Apps, select Add App Project
            // and select the app projects that should be tested.
            app = ConfigureApp
                .Android
                .ApkFile("D:\\MobileApp\\UITestDemo\\UITestDemo\\bin\\Debug\\UITestDemo.UITestDemo.apk")
                .StartApp();
        }

        [Test]
        public void AppLaunches()
        {
            app.Tap(c => c.Marked("MyButton"));
            app.Tap(c => c.Marked("MyButton"));
            app.Tap(c => c.Marked("MyButton"));

            app.EnterText(c => c.Id("editText1"),"Imran Aftab Rana");
        }
    }
}

