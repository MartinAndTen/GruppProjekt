using System;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using AllaBolagScreenScraper;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace UnitTestAllaBolag
{
    [TestClass]
    public class ScreenScraper
    {
        [TestMethod]
        public void TestUpplysningReturnsCorrectCompanyMame()
        {
            //Arrange
           ScreenScraperUpplysning scr = new ScreenScraperUpplysning();
            string expexted = "Mattias Asplund Aktiebolag";
            //Act
            Task<string> actual = scr.ScreenScrapeAsync("5565995239");
            string actual1 = actual.Result;
            //Assert
            Assert.AreEqual(expexted, actual1);
        }
    }
}
