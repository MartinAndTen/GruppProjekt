using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AllaBolagScreenScraper
{
   public interface IScreenScraper
   {


       Task<string> ScreenScrapeAsync(string id);
       string GetComapnyName(string Title);

   }
}
