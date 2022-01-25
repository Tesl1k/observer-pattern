using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkeletonLibrary
{
    public class CurrentConditionsDisplay : IObserver, IDisplayElement
    {
        private float temperature;
        private float humidity;
        private float pressure;
        private ISubject weatherData;
        public string Name { get; set; }

        public CurrentConditionsDisplay(ISubject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.registerObserver(this, Name);
        }
        public string Update(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            return Display();
        }
        
        public string Display()
        {
            return $"Температура = {temperature}°. Влажность = {humidity}%. Давление = {pressure}. Пользователь {Name} ({GetType()}) оповещён";
        }
    }
}
