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
            //set
            //{
            //    RegexPattern = value;
            //}
        }

        public override string Url
        {
            get
            {
                return "http://www.allabolag.se/";
            }
            //set
            //{
            //    Url = value;
            //}
        }
        //private string Result;
        //private string content;

        //HttpClient client = new HttpClient();

        //public async Task<string> ScreenScrapeAsync(string id)
        //{
        //    string Adress = "http://www.allabolag.se/" + id;
        //    var response = await client.GetAsync(Adress);
        //    var v = await response.Content.ReadAsStringAsync();
        //    content = v;
        //    return GetComapnyName("<span [^>]*class=(\"|')reportTitleBig(\"|')>(.*?)</span>");
        //}

        //public string GetComapnyName(string title)
        //{
        //    string mc = Regex.Match(content, title).ToString();
        //    Result = mc;
        //    Result = Regex.Replace(Result, @"<[^>]*>", String.Empty);
        //    return Result;
        //}

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
