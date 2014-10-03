﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AllaBolagScreenScraper
{

      
    class ScreenScraperAllaBolag:IScreenScraper
    {
        public string Result;
        public string content;
       

        HttpClient client = new HttpClient();

        public async Task<string> ScreenScrapeAsync(string id)
        {
           
            string Adress = Form1.Adress;
            var response = await client.GetAsync(Adress);
            var v = await response.Content.ReadAsStringAsync();
            content = v;
         
            return GetComapnyName(Form1.Title);
        }


        public string GetComapnyName(string Title)
        {
            string mc = Regex.Match(content, Title).ToString();
            Result = mc;
            Result = Regex.Replace(Result, @"<[^>]*>", String.Empty);
            return Result;
        }
    }
}