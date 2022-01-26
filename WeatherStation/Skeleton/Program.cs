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
                      
            Console.WriteLine(weatherData.setMeasurements(22, 65, 30));
            Console.WriteLine(weatherData.setMeasurements(24, 26, 66, 70, 29, 31));

            Console.ReadKey();
            
        }

    }
}
