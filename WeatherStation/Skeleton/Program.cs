using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SkeletonLibrary;

namespace Skeleton
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherData weatherData = new WeatherData();
            CurrentConditionsDisplay currentConditionsDisplay = new CurrentConditionsDisplay(weatherData);
            StatisticsDisplay statisticsDisplay = new StatisticsDisplay(weatherData);
            ForecastDisplay forecastDisplay = new ForecastDisplay(weatherData);
                      
            Console.WriteLine(weatherData.setMeasurements(22, 65, 30, 21, 23, 63, 67, 27, 31, 26, 70, 34));

            Console.WriteLine(weatherData.setMeasurements(23, 53, 27, 25, 19, 59, 64, 21, 28, 31, 65, 30));


            Console.ReadKey();
            
        }

    }
}
