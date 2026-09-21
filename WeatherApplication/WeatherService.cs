using System;
using System.IO.Compression;

namespace WeatherApp;

public class WeatherService
{
    String zip = "32817";


    public async Task TestApiCall()
    {
        String apiKey = Environment.GetEnvironmentVariable("OPENWEATHER_API_KEY");
        String url = $"https://api.openweathermap.org/data/2.5/forecast?zip={zip},us&appid={apiKey}&units=imperial";

        try
        {
            using HttpClient client = new HttpClient();
            string response = await client.GetStringAsync(url);

            Console.WriteLine(response);

        }
        catch (HttpRequestException ex)
        {
            Console.WriteLine("Sorry, weather services are not available at this time. Please try again later.\n");
        }

    }
    public String GetZip()
    {
        return zip;
    }




    public bool setZip(string newZip)
    {
        if (newZip.Length != 5)
        {
            Console.WriteLine("Invalid entry. Please enter a 5 digit zipcode.");
            return false;
        }
        for (int i = 0; i < newZip.Length; i++)
        {
            if (!char.IsDigit(newZip[i]))
            {
                Console.WriteLine("Zip codes only contain numbers. ");
                return false;
            }
        }
        zip = newZip;
        return true;

    }
}
