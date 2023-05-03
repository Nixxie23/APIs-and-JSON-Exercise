using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIsAndJSON
{
    public class OpenWeatherMapAPI
    {
        HttpClient client = new HttpClient();
        
        
    public void cityWeather(string city) 
        { 

            
            var weatherURL = $"https://api.openweathermap.org/data/2.5/weather?q={city}&units=imperial&appid=98d22f11723621da9e593b63a7e84ae0";
            var response = client.GetStringAsync(weatherURL).Result;
            JObject goodResponse = JObject.Parse(response);
            var temperature = goodResponse["main"]["temp"];
            Console.WriteLine($"The temperature in {city} is {temperature} degrees fahrenheit.");
            

            

        }
            
            
            
            
            }
}
