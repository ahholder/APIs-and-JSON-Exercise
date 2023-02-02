using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace APIsAndJSON
{
    public class OpenWeatherMapAPI
    {
        public static string GetTempF(double lat, double lon)
        {
            string final = "";
            string city = "Birmingham";
            //string key = "742a8aeeb2dc9a2d8edb43e9cd85f25d";
            //string key = "ad5615a2c000faf6567ca7e13d42ac45";
            string key = "4369b783b461e7b4754b6bbff8d30ca2";
            //string key = "AH_TrueCoders";
            string weatherURL = $"https://api.openweathermap.org/data/2.5/weather?lat=";
            string searcher = $"{weatherURL}{lat}&lon={lon}&appid={key}";
            searcher += "&units=imperial";
            //searcher = "api.openweathermap.org/data/2.5/weather?q=London,uk&APPID=4369b783b461e7b4754b6bbff8d30ca2";
            //Console.WriteLine(searcher); //Testing
            //Console.ReadLine(); //Testing
            //string searcher = $"http://api.openweathermap.org/data/2.5/forecast?q={city}&appid={key}&units=imperial";
            var client = new HttpClient();
            var response = client.GetStringAsync(searcher).Result;
            var formattedResponse = JObject.Parse(response);
            //var temp = formattedResponse["list"][0]["main"]["temp"];
            var temp = formattedResponse["main"]["temp"];
            string time = $"{DateTime.Now.Hour}:{DateTime.Now.Minute} on {DateTime.Now.Month}/{DateTime.Now.Day}/{DateTime.Now.Year}";
            final = $"It is {temp}°F at coordinates ({lat}, {lon}) as of {time}!";
            //final = response.ToString(); //Testing
            return final;
        }
    }
}

//{"coord":{"lon":-87.11,"lat":33.11},"weather":[{"id":501,"main":"Rain","description":"moderate rain","icon":"10d"}],"base":"stations","main":{"temp":45.59,"feels_like":43.29,"temp_min":42.39,"temp_max":48.69,"pressure":1020,"humidity":96,"sea_level":1020,"grnd_level":1005},"visibility":10000,"wind":{"speed":4.65,"deg":70,"gust":14.47},"rain":{"1h":1.54},"clouds":{"all":100},"dt":1675364076,"sys":{"type":2,"id":2002146,"country":"US","sunrise":1675341803,"sunset":1675380048},"timezone":-21600,"id":4096956,"name":"West Blocton","cod":200}
