using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AllaBolagScreenScraper
{
    public class ScreenScraper
    {
        public string Result;
        public string content;
        public string Adress;

        HttpClient client = new HttpClient();
          
        public string GetCOmpanyInfo(string OrgNumber)
        {
       

            Adress = "http://www.allabolag.se" + "/" + OrgNumber;


            return Adress;

        }

        public async Task Start(string OrgNmber)
        {
            GetCOmpanyInfo(OrgNmber);
            
            var response = await client.GetAsync(Adress);
            var v = await response.Content.ReadAsStringAsync();
            content = v;
            string Title = "<span [^>]*class=(\"|')reportTitleBig(\"|')>(.*?)</span>";
            string mc = Regex.Match(content, Title).ToString();
            Result = mc;
            Result = Regex.Replace(Result, @"<[^>]*>", String.Empty);


        }

    }
}
