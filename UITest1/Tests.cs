using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace UITest1
{
    [TestFixture(Platform.Android)]
    [TestFixture(Platform.iOS)]
    public class Tests
    {
        IApp app;
        Platform platform;

        public Tests(Platform platform)
        {
            this.platform = platform;
        }

        [SetUp]
        public void BeforeEachTest()
        {
            app = AppInitializer.StartApp(platform);
        }

        [Test]
        public void AppLaunches()
        {
            app.Screenshot("First screen.");
        }

        [Test]
        public void NewTest1()
        {
            app.Tap(x => x.Text("Click Me!"));
            app.ClearText(x => x.Class("EntryEditText").Text("Judy"));
            app.Tap(x => x.Text("VS 2017 Best Of Launch").Index(2));
            app.Tap(x => x.Text("Des Moines"));
            app.Tap(x => x.Class("EntryEditText").Index(3));
            app.EnterText(x => x.Class("EntryEditText").Index(3), "h");
            app.Tap(x => x.Text("Name:"));
            app.Tap(x => x.Text("Save"));
            app.Tap(x => x.Class("EntryEditText"));
            app.EnterText(x => x.Class("EntryEditText"), "ut");
            app.Tap(x => x.Text("Click Me!"));
            app.ClearText(x => x.Class("EntryEditText").Text("ughtruth"));
            app.Screenshot("Cleared text");
            app.Tap(x => x.Class("PageRenderer"));
            app.SwipeLeftToRight();
            app.Screenshot("Swiped right");
        }

        [Test]
        public void NewTest()
        {
        }

        [Test]
        public void NewTest2()
        {
            app.Tap(x => x.Text("About"));
            app.Tap(x => x.Text("Other stuff"));
            app.SwipeRightToLeft();
            app.ScrollDown();
            app.Tap(x => x.Text("Click Me!"));
        }

        [Test]
        public void NewTest3()
        {
            app.Tap(x => x.Text("Click Me!"));
            app.Tap(x => x.Text("Click Me!"));
            app.Tap(x => x.Class("Platform_DefaultRenderer").Index(9));
            app.ScrollDownTo("Save");
            app.Tap(x => x.Text("Save"));
            app.SwipeLeftToRight();
            app.Tap(x => x.Text("Events"));
            app.Tap(x => x.Text("About"));
            app.Tap(x => x.Text("Other stuff"));
            app.Tap(x => x.Text("Click Me!"));
            app.Tap(x => x.Class("EntryEditText"));
            app.EnterText(x => x.Class("EntryEditText"), "hhhhh");
            app.Tap(x => x.Text("Click Me!"));
            app.Tap(x => x.Class("Platform_DefaultRenderer").Index(10));
            app.ScrollDownTo("Save");
            app.Tap(x => x.Text("Save"));
            app.Screenshot("Tapped on view with class: AppCompatButton with text: Save");
            app.SwipeLeftToRight();
            app.Screenshot("Swiped right");
            app.Tap(x => x.Class("MasterDetailPageRenderer"));
            app.Tap(x => x.Text("VS 2017 Best Of Launch"));
            app.Screenshot("Tapped on view with class: FormsTextView with text: VS 2017 Best Of Launch");
        }

    }
}

