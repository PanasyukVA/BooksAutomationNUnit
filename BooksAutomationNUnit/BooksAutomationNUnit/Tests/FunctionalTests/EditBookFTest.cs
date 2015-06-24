using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using BooksAutomationNUnit.Utilities;
using NUnit.Framework;

namespace BooksAutomationNUnit.Tests.FunctionalTests
{
    [TestFixture]
    public class EditBookFTest : BaseTest
    {
        [Test, Category("FunctionalTests")]
        public void EditBook()
        {
            // Arrange
            bool actualResult;

            // Act
            fixture.Pages.loginPage.GetPage();
            fixture.Pages.loginPage.Login(fixture.config.Books_UserEmail, fixture.config.Books_UserPassword);
            fixture.Pages.booksPage.EditBook(1, "BookEditTest", new int[] {1, 2});
            actualResult = fixture.Pages.booksPage.BookResultModalLabel.Displayed;

            // Assert
            Assert.IsTrue(actualResult, "The book is not edited.");
        }
    }
}
