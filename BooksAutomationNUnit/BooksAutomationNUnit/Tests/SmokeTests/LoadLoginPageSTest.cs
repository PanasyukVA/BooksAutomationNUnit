using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using BooksAutomationNUnit.Utilities;
using NUnit.Framework;

namespace BooksAutomationNUnit.Tests.SmokeTests
{
    [TestFixture]
    public class LoadLoginPageSTest : BaseTest
    {
        [Test, Category("SmokeTests")]
        public void LoadLoginPage()
        {
            // Arrange
            string expectedPageCaption = "Log iin.";
            string actualPageCaption;

            // Act
            fixture.Pages.loginPage.GetPage();
            actualPageCaption = fixture.Pages.loginPage.CaptionLabel.Text;

            // Assert
            Assert.AreEqual(expectedPageCaption, actualPageCaption, String.Format("The {0} page is not loaded", expectedPageCaption));
        }
    }
}
