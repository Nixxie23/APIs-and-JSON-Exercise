﻿using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System.Data;

namespace APIsAndJSON
{
    public class Program
    {
        static void Main(string[] args)
        {
            var convo1 = new RonVSKanyeAPI();
            var weatherCheck = new OpenWeatherMapAPI();
          convo1.RonKanyeConvo();
            weatherCheck.cityWeather("Dayton");
            
        }
    }
}
