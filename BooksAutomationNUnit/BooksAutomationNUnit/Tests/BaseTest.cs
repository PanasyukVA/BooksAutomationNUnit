using System;
using BooksAutomationNUnit.Utilities;
using NUnit.Framework;

namespace BooksAutomationNUnit.Tests
{
    [TestFixture]
    public class BaseTest
    {
        private TestContext testContextInstance;

        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }
        public static TestFixture fixture;

        [AssemblyInitialize]
        public static void AssemblyInitialize(TestContext context)
        {
            fixture = new TestFixture();
        }

        [AssemblyCleanup]
        public static void AssemblyCleanUp()
        {
            fixture.Dispose();
        }

        [TestCleanup]
        public void TestCleanUp()
        {
            if (TestContext.CurrentTestOutcome == UnitTestOutcome.Failed)
            {
                fixture.Pages.booksPage.TakeScreenshot(fixture.driver, TestContext.TestResultsDirectory, TestContext.FullyQualifiedTestClassName);
            }
            fixture.Pages.booksPage.ConfirmationResult();
            fixture.Pages.loginPage.Logoff();
        }
    }
}
