using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using BooksAutomationNUnit.Utilities;
using NUnit.Framework;

namespace BooksAutomationNUnit.Tests.SmokeTests
{
    [TestFixture]
    public class LogInOnSiteSTest : BaseTest
    {
        [Test, Category("SmokeTests")]
        public void LogInOnSite()
        {
            // Arrange
            bool actualResult;

            // Act
            fixture.Pages.loginPage.GetPage();
            fixture.Pages.loginPage.Login(fixture.config.Books_UserEmail, fixture.config.Books_UserPassword);
            try
            {
                actualResult = fixture.driver.FindElement(By.LinkText(String.Format("Hello {0}!", fixture.config.Books_UserEmail))).Displayed;
            }
            catch (NoSuchElementException)
            {
                actualResult = false;
            }

            // Assert
            Assert.IsTrue(actualResult, "Unable to log in on the site");
        }
    }
}
