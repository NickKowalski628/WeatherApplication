using System;
using System.Runtime.InteropServices;
using System.Text.Json;

namespace WeatherApplication
{
    internal class Deserializer
    {
        public class city
        {
            public String name{ get; set; }
            public int id { get; set; }

        }
        public class ForecastResponse
        {
            public city city { get; set; }
        }
        public class Program
        {
            public static async Task Main()
            {
                string fileName = "Forecast.json";
                using FileStream openStream = File.OpenRead(fileName);
                ForecastResponse? weatherforecast = await JsonSerializer.DeserializeAsync<ForecastResponse>(openStream);
                Console.WriteLine($"City:{weatherforecast?.city?.name}");
                
            }
        }
    }



}
