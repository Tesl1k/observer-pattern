using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkeletonLibrary
{
    public class WeatherData : ISubject
    {     

        public string state;
        float temperatur;
        float humidity;
        float pressure;
        //float MinTemperature;
        //float MaxTemperature;
        //float AvgTemperature;
        //float MinHumidity;
        //float MaxHumidity;
        //float AvgHumidity;
        //float MinPressure;
        //float MaxPressure;
        //float AvgPressure;

        public string Name { get; set; }


        public List<IObserver> users = new List<IObserver>();

        public void registerObserver(IObserver observer)
        {
            users.Add(observer);
        }

        public void removeObserver(IObserver observer)
        {
            users.Remove(observer);
        }       
        
        
        public string notifyObservers()
        {
            string x = "";

            foreach (var user in users)
            {
                if(x)               
            }

            return x;
        }

        public string measurementsChanges()
        {
            return notifyObservers();
        }

        public string setMeasurements(float temperatur, float humidity, float pressure)
        {
            this.temperatur = temperatur;
            this.humidity = humidity;
            this.pressure = pressure;
            return measurementsChanges();
        }

        public string setMeasurements(float t1, float t2, float h1, float h2, float p1, float p2)
        {
            StatisticsDisplay.MinTemperature = t1;
            StatisticsDisplay.MaxTemperature = t2;
            StatisticsDisplay.AvgTemperature = (t1 + t2) / 2;
            StatisticsDisplay.MinHumidity = h1;
            StatisticsDisplay.MaxHumidity = h2;
            StatisticsDisplay.AvgHumidity = (h1 + h2) / 2;
            StatisticsDisplay.MinPressure = p1;
            StatisticsDisplay.MaxPressure = p2;
            StatisticsDisplay.AvgPressure = (p1 + p2) / 2;
            return measurementsChanges();
        }
    }
}
