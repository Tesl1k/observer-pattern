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
        float temperature;
        float humidity;
        float pressure;
        float MinTemperature;
        float MaxTemperature;
        float AvgTemperature;
        float MinHumidity;
        float MaxHumidity;
        float AvgHumidity;
        float MinPressure;
        float MaxPressure;
        float AvgPressure;
        float progTemperature;
        float progHumidity;
        float progPressure;

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
                x += user.Update(temperature, humidity, pressure, MinTemperature, MaxHumidity, AvgTemperature, MinHumidity, MaxHumidity, AvgHumidity, MinPressure, MaxPressure, AvgPressure, progTemperature, progHumidity, progPressure)     ;           
            }

            return x;
        }

        public string measurementsChanges()
        {
            return notifyObservers();
        }

        public string setMeasurements(float temp, float humidity, float pressure, float tmin, float tmax, float hmin, float hmax, float pmin, float pmax, float tprog, float hprog, float pprog)
        {
            this.temperature = temp;
            this.humidity = humidity;
            this.pressure = pressure;
            this.MinTemperature = tmin;
            this.MaxTemperature = tmax;
            this.AvgTemperature = (tmin + tmax) / 2;
            this.MinHumidity = hmin;
            this.MaxHumidity = hmax;
            this.AvgHumidity = (hmin + hmax) / 2;
            this.MinPressure = pmin;
            this.MaxPressure = pmax;
            this.AvgPressure = (pmin + pmax) / 2;
            return measurementsChanges();
        }
        
    }
}
