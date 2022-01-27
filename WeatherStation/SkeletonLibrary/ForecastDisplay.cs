using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkeletonLibrary
{
    public class ForecastDisplay : IObserver, IDisplayElement
    {
        private float temperature;
        private float humidity;
        private float pressure;
        private ISubject weatherData;

        public ForecastDisplay(ISubject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.registerObserver(this);
        }
        public string Update(float temp, float humidity, float pressure, float tmin, float tmax, float tavg, float hmin, float havg, float hmax, float pmin, float pmax, float pavg, float tprog, float hprog, float pprog)
        {
            this.temperature = temp;
            this.humidity = humidity;
            this.pressure = pressure;
            return Display();
        }

        public string Display()
        {
            return $"Прогноз: Температура = {temperature}°. Влажность = {humidity}%. Давление = {pressure}. ({this.GetType()})\n";
        }
    }
}
