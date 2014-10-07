using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AllaBolagScreenScraper
{
    public class ScreenScraperAllaBolag : ScreenScraperCompany, IScreenScraper
    {
        public override string RegexPattern
        {
            get
            {
                return "<span [^>]*class=(\"|')reportTitleBig(\"|')>(.*?)</span>";
            }
        }

        public override string Url
        {
            get
            {
                return "http://www.allabolag.se/";
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
