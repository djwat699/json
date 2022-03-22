using System;
using System.Text.Json;
namespace jason
{
    class Program
    {
        public static void Main()
        {
            var weatherForecast = new WeatherForecast
            {
                Date = DateTime.Parse("2019-08-01"),
                TemperatureCelsius = 25,
                Summary = "Hot"
            };

            var PhoenixForecast = new WeatherForecast
            {
                Date = DateTime.Parse("2022-03-22"),
                TemperatureCelsius = 25,
                Summary = "Hot"
            };

            string jsonString = JsonSerializer.Serialize(weatherForecast);

            Console.WriteLine(jsonString);

            string PheonixString = JsonSerializer.Serialize(weatherForecast);

            Console.WriteLine(PheonixString);

            WeatherForecast w = JsonSerializer.Deserialize<WeatherForecast>(PheonixString);


            Console.ReadKey();

        }

    }
}
