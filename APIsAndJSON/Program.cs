using System;
using System.Net.Http;
using static System.Net.WebRequestMethods;
using Newtonsoft.Json.Linq;

namespace APIsAndJSON
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine("Exercise 1: A Conversation");
            Console.WriteLine("-------------------------");
            Console.WriteLine(Talker(0, QuoteGenerator.Kanye()));
            Console.WriteLine("-------------------------");
            Console.WriteLine(Talker(1, QuoteGenerator.Swanson()));
            Console.WriteLine();
            Console.WriteLine("-------------------------");
            Console.WriteLine("Exercise 2: Weather Forecast");
            Console.WriteLine("-------------------------");
            Console.WriteLine(OpenWeatherMapAPI.GetTempF(33.11,-87.11));
            Console.WriteLine();

            //No Bonus to avoid another account signup
            /*Console.WriteLine("-------------------------");
            Console.WriteLine("Bonus: Call of Duty Warfare");
            Console.WriteLine("-------------------------");*/
        }
        static string Talker(int person, string words)
        {
            if (person == 0) return "Kanye West: " + "\"" + words + "\"";
            return "Ron Swanson: " + "\"" + words + "\"";
        }
    }
}
