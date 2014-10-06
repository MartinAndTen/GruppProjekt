using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AllaBolagScreenScraper
{
    public abstract class ScreenScraperCompany
    {
        public abstract string Url { get; }
        public abstract string RegexPattern { get; }

        public string content;
        public string Result;

        public async Task<string> ScreenScrapeAsync(string id)
        {
            HttpClient client = new HttpClient();
            string Adress = Url + id;
            var response = await client.GetAsync(Adress);
            var v = await response.Content.ReadAsStringAsync();
            content = v;
            return GetComapnyName(RegexPattern);
        }

        public string GetComapnyName(string title)
        {
            string mc = Regex.Match(content, title).ToString();
            Result = mc;
            Result = Regex.Replace(Result, @"<[^>]*>", String.Empty);
            return Result;
        }
    }
}
