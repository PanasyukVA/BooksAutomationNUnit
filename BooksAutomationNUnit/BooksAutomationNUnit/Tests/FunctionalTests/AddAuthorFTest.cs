using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using BooksAutomationNUnit.Utilities;
using NUnit.Framework;

namespace BooksAutomationNUnit.Tests.FunctionalTests
{
    [TestFixture]
    public class AddAuthorFTest : BaseTest
    {
        [Test, Category("FunctionalTests")]
        public void AddAuthor()
        {
            // Arrange
            bool actualResult;
                
            // Act
            fixture.Pages.loginPage.GetPage();
            fixture.Pages.loginPage.Login(fixture.config.Books_UserEmail, fixture.config.Books_UserPassword);
            fixture.Pages.booksPage.AddAuthor("AuthorAddTest");
            actualResult = fixture.Pages.booksPage.AuthorResultModalLabel.Displayed;
                
            // Assert
            Assert.IsTrue(actualResult, "The author is not added.");
        }
    }
}
