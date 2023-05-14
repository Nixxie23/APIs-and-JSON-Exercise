using Microsoft.Extensions.Configuration;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIsAndJSON
{
    public class OpenWeatherMapAPI : APIs
    {
        HttpClient client = new HttpClient();
       

        public void cityWeather(string city) 
        {

            
            var response = client.GetStringAsync($"https://api.openweathermap.org/data/2.5/weather?q={city}&units=imperial&appid={key}").Result;
            JObject goodResponse = JObject.Parse(response);
            var temperature = goodResponse["main"]["temp"];
            Console.WriteLine($"The temperature in {city} is {temperature} degrees fahrenheit.");
            

            

        }
        public void cityWeather(string city, string aPIKey)
        {


            var response = client.GetStringAsync($"https://api.openweathermap.org/data/2.5/weather?q={city}&units=imperial&appid={aPIKey}").Result;
            JObject goodResponse = JObject.Parse(response);
            var temperature = goodResponse["main"]["temp"];
            Console.WriteLine($"The temperature in {city} is {temperature} degrees fahrenheit.");




        }



    }
}
