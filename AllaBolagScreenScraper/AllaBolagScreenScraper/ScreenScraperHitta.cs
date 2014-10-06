using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AllaBolagScreenScraper
{
   public class ScreenScraperHitta :IScreenScraper
    {

        private string Result;
        private string content;

        HttpClient client = new HttpClient();



        public async Task<string> ScreenScrapeAsync(string id)
        {
            string Adress = "http://www.hitta.se/sök?vad=" + id;
            var response = await client.GetAsync(Adress);
            var v = await response.Content.ReadAsStringAsync();
            content = v;
            return GetComapnyName("<h1[^>]*?>(?<TagText>.*?)</h1>");
        }

        public string GetComapnyName(string title)
        {
            string mc = Regex.Match(content, title).ToString();
            Result = mc;
            Result = Regex.Replace(Result, @"<[^>]*>", String.Empty);
            return Result;
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
