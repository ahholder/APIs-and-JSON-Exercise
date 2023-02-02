using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIsAndJSON
{
    public class QuoteGenerator
    {
        public static string Kanye()
        {
            var client = new HttpClient();
            string kanyeURL = "https://api.kanye.rest";
            var kanyeResponse = client.GetStringAsync(kanyeURL).Result;
            //string swansonURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";
            //var ronResponse = client.GetStringAsync(swansonURL).Result;

            var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();
            if (kanyeQuote[kanyeQuote.Length - 1] != '.' && kanyeQuote[kanyeQuote.Length - 1] != '!' && kanyeQuote[kanyeQuote.Length - 1] != '?') kanyeQuote += ".";
            //var ronQuote = JObject.Parse(ronResponse).GetValue("quote").ToString();
            //var ronQuote = ronResponse;

            return kanyeQuote;
            //Console.WriteLine(ronResponse);
        }
        public static string Swanson()
        {
            var client = new HttpClient();
            //string kanyeURL = "https://api.kanye.rest";
            //var kanyeResponse = client.GetStringAsync(kanyeURL).Result;
            string swansonURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";
            var ronResponse = client.GetStringAsync(swansonURL).Result;

            //var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();
            //var ronQuote = JObject.Parse(ronResponse).GetValue("quote").ToString();
            //var ronQuote = JObject.Parse(ronResponse).ToString();
            var ronQuote = ronResponse;
            ronQuote = ronQuote.Replace('[',' ');
            ronQuote = ronQuote.Replace(']', ' ');
            ronQuote = ronQuote.Replace('"', ' ');
            ronQuote = ronQuote.Trim();

            return ronQuote;
            //Console.WriteLine(ronResponse);
        }
    }
}
