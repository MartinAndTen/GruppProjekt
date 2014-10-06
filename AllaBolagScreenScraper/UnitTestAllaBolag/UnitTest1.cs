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
        public void TestUpplysningReturnsCorrectCompanyName()
        {
            //Arrange
            string expected = "Mattias Asplund Aktiebolag";
            ScreenScraperUpplysning scrUpplysning = new ScreenScraperUpplysning();
            //Act
            Task<string> upplysningTask = scrUpplysning.ScreenScrapeAsync("5565995239");
            string actual = upplysningTask.Result;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestHittaReturnsCorrectCompanyName()
        {
            //Arrange
            string expected = "Mattias Asplund Aktiebolag";
            ScreenScraperHitta scrHitta = new ScreenScraperHitta();
            //Act
            Task<string> hittaTask = scrHitta.ScreenScrapeAsync("5565995239");
            string actual = hittaTask.Result;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestEniroReturnsCorrectCompanyName()
        {
            //Arrange
            string expected = "Mattias Asplund Aktiebolag";
            ScreenScraperEniro scrEniro = new ScreenScraperEniro();
            //Act
            Task<string> eniroTask = scrEniro.ScreenScrapeAsync("5565995239");
            string actual = eniroTask.Result;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestAllaBolagReturnsCorrectCompanyName()
        {
            //Arrange
            string expected = "Mattias Asplund Aktiebolag";
            ScreenScraperAllaBolag scrAllaBolag = new ScreenScraperAllaBolag();
            //Act
            Task<string> allaBolagTask = scrAllaBolag.ScreenScrapeAsync("5565995239");
            string actual = allaBolagTask.Result;
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
