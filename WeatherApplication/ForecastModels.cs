using System;
using System.Runtime.InteropServices;
using System.Text.Json;

namespace WeatherApplication
{
    internal class ForecastModels
    {
        public class city
        {
            public string name { get; set; }
        }
        public class MainData 
        {
            public double temp { get; set; } 
        }
        
        public class ForecastEntry
        {
            public string dt_txt { get; set; }
            public MainData main { get; set; }

        }

        public class ForecastResponse
        {
            public city city { get; set; }
            public List<ForecastEntry> list { get; set; }
        }
    }
}