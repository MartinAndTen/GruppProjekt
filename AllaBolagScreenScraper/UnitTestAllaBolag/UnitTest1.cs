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
        public void TestReturnsCorrectCompanyMame()
        {
            //Arrange
           ScreenScraperUpplysning scr = new ScreenScraperUpplysning();
            string expexted = "Mattias Asplund Aktiebolag";
            //Act
            Task<string> actual = scr.ScreenScrapeAsync("5565995239");
            string actual1 = actual.Result;
            //Assert
            Assert.AreEqual(expexted, actual1);

            //Arrange
            ScreenScraperAllaBolag scr1 = new ScreenScraperAllaBolag();
            string expexted1 = "Mattias Asplund Aktiebolag";
            //Act
            Task<string> actual2 = scr.ScreenScrapeAsync("5565995239");
            string actual22 = actual2.Result;
            //Assert
            Assert.AreEqual(expexted1, actual22);


            //Arrange
            ScreenScraperEniro scr2 = new ScreenScraperEniro();
            string expexted2 = "Mattias Asplund Aktiebolag";
            //Act
            Task<string> actual3 = scr.ScreenScrapeAsync("5565995239");
            string actual33 = actual3.Result;
            //Assert
            Assert.AreEqual(expexted2, actual33);


            //Arrange
            ScreenScraperHitta scr4 = new ScreenScraperHitta();
            string expexted4 = "Mattias Asplund Aktiebolag";
            //Act
            Task<string> actual4 = scr.ScreenScrapeAsync("5565995239");
            string actual44 = actual4.Result;
            //Assert
            Assert.AreEqual(expexted4, actual44);
        }
    }
}
