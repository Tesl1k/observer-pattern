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

        public string Name { get; set; }


        List<IObserver> users = new List<IObserver>();

        public void registerObserver(IObserver observer, string name)
        {
            observer.Name = name;
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
                x += user.Update(temperatur, humidity, pressure) + "\n";                
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
    }
}
