using Atata;
using NUnit.Framework;

namespace testAtata
{
    public class PageTests
    {
        [SetUp]
        public void Setup()
        {
            AtataContext.Configure()
                        .UseChrome()
                        .UseBaseUrl("https://demo.atata.io/")
                        .UseNUnitTestName()
                        .AddNUnitTestContextLogging()
                        .AddScreenshotFileSaving()
                        .LogNUnitError()
                        .TakeScreenshotOnNUnitError()
                        .Build();
        }

        [TearDown]
        public void TearDown()
        {
            AtataContext.Current?.CleanUp();
        }

        [Ignore("skip")]
        [Test]
        public void SignInSuccess()
        {
            SignIn();
        }
        
        [Test]
        public void AddUserSuccess()
        {
            SignIn()
                .New()
                .FirstName.SetRandom(out var firatName)
                .LastName.SetRandom(out var lastName)
                .Email.SetRandom(out var email)
                .Office.Set(Office.Tokio)
                .Gender.Set(Gender.Female)
                .Save()
                .Users.Rows.Count.Should.BeGreater(2);
        }

        private static UsersPage SignIn()
        {
            return Go.To<SignInPage>()
                     .Email.Set("admin@mail.com")
                     .Password.Set("abc123")
                     .SignIn.ClickAndGo();
        }
    }
}