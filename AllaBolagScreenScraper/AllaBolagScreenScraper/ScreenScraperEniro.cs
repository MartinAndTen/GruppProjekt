using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AllaBolagScreenScraper
{
   public class ScreenScraperEniro : ScreenScraperCompany, IScreenScraper
    {
        public override string RegexPattern
        {
            get
            {
                return "<span [^>]*class=(\"|')hit-company-name-ellipsis(\"|')>(.*?)</span>";
            }
        }

        public override string Url
        {
            get
            {
                return "http://gulasidorna.eniro.se/hitta:";
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
