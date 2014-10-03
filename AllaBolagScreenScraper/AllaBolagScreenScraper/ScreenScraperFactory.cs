using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllaBolagScreenScraper
{
    class ScreenScraperFactory
    {
        public static IScreenScraper CreateScreenScrape(string type)
        {
            IScreenScraper scraper = null;
            if (type == "Allabolag.se")
            {
                scraper = new ScreenScraperAllaBolag();
            }
            else if (type == "Upplysning.se")
            {
                scraper = new ScreenScraperUpplysning();
            }
            return scraper;
        }

    }
}
