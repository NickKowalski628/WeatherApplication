/*
using System;
namespace WeatherApp;
class Program
{
    static async Task Main(string[] args)
    {
        WeatherService service = new WeatherService();
        bool running = true;
        
        Console.WriteLine("Hello and welcome to my weather application!");
        {

        bool success = false;
        while(!success)
        {
            Console.WriteLine("Please enter your zipcode: ");
            String NewZip = Console.ReadLine();
            success = service.setZip(NewZip);
        }
        
        }


        while (running)
        {
            Console.WriteLine("1.Get forecast");
            Console.WriteLine("2.Change zip code");
            Console.WriteLine("3.Exit");

            String choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    {
                        Console.WriteLine($"Getting forecase for Zipcode: {service.GetZip()}");
                        await service.TestApiCall();
                        break;
                    }

                case "2":
                    {

                    Console.WriteLine($"Your current zipcode is:{service.GetZip()}");
                    bool success = false;
                    while (!success)
                    {
                        Console.WriteLine("What would you like to change the zip code to? ");
                        String newZip = Console.ReadLine();
                        success = service.setZip(newZip);

                    }
                    break;
                    }


                case "3":
                    {

                    //exit
                    Console.WriteLine("Thanks for using me, goodbye!");
                    running = false;
                    break;
                    }
                default:
                    Console.WriteLine("Invalid choice, please try again");
                    break;
            }

        }
    }
}

 */