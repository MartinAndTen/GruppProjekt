using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AllaBolagScreenScraper
{
   public class ScreenScraperHitta : ScreenScraperCompany, IScreenScraper
    {
        public override string RegexPattern
        {
            get
            {
                return "<h1[^>]*?>(?<TagText>.*?)</h1>";
            }
        }

        public override string Url
        {
            get
            {
                return "http://www.hitta.se/sök?vad=";
            }
        }
 
        string IScreenScraper.Result
        {
            get
            {
                return Result;
            }
            set
            {
                Result = value;
            }
        }
    }
}
