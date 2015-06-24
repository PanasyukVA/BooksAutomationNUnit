using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using BooksAutomationNUnit.Utilities;
using NUnit.Framework;

namespace BooksAutomationNUnit.Tests.FunctionalTests
{
    [TestFixture]
    public class EditAuthorFTest : BaseTest
    {
        [Test, Category("FunctionalTests")]
        public void EditAuthor()
        {
            // Arrange
            bool actualResult;

            // Act
            fixture.Pages.loginPage.GetPage();
            fixture.Pages.loginPage.Login(fixture.config.Books_UserEmail, fixture.config.Books_UserPassword);
            fixture.Pages.booksPage.EditAuthor(1, "AuthorEditTest");
            actualResult = fixture.Pages.booksPage.AuthorResultModalLabel.Displayed;

            // Assert
            Assert.IsTrue(actualResult, "The author is not edited.");
        }
    }
}
