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
                return RegexPattern;
            }
            //set
            //{
            //    RegexPattern = "<span [^>]*class=(\"|')hit-company-name-ellipsis(\"|')>(.*?)</span>";
            //}
        }

        public override string Url
        {
            get
            {
                return Url;
            }
            //set
            //{
            //    Url = "http://gulasidorna.eniro.se/hitta:";
            //}
        }
        //private string Result;
        //private string content;

        //HttpClient client = new HttpClient();
        //public async Task<string> ScreenScrapeAsync(string id)
        //{
        //    string Adress = "http://gulasidorna.eniro.se/hitta:" + id;
        //    HttpResponseMessage response = await client.GetAsync(Adress);
        //    var v = await response.Content.ReadAsStringAsync();
        //    content = v;
        //    return GetComapnyName("<span [^>]*class=(\"|')hit-company-name-ellipsis(\"|')>(.*?)</span>");  
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
