using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using BooksAutomationNUnit.Utilities;
using NUnit.Framework;

namespace BooksAutomationNUnit.Tests.SmokeTests
{
    [TestFixture]
    public class LoadMainPageSTest : BaseTest
    {
        [Test, Category("SmokeTests")]
        public void LoadMainPage()
        {
            // Arrange
            string expectedPageCaption = "Books";
            string actualPageCaption;

            // Act
            fixture.Pages.booksPage.GetPage();
            actualPageCaption = fixture.Pages.booksPage.CaptionLabel.Text;

            // Assert
            Assert.AreEqual(expectedPageCaption, actualPageCaption, String.Format("The {0} page is not loaded", expectedPageCaption));
        }
    }
}
