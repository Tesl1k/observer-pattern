using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkeletonLibrary
{
    public class StatisticsDisplay : IObserver, IDisplayElement
    {
        private float MinTemperature;
        private float MaxTemperature;
        private float AvgTemperature;
        private float MinHumidity;
        private float MaxHumidity;
        private float AvgHumidity;
        private float MinPressure;
        private float MaxPressure;
        private float AvgPressure;
        private ISubject weatherData;

        public StatisticsDisplay(ISubject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.registerObserver(this);
        }

        public string Update(float t1, float t2, float t3, float h1, float h2, float h3, float p1, float p2, float p3)
        {
            this.MinTemperature = t1;
            this.MaxTemperature = t2;
            this.AvgTemperature = t3;
            return Display();
        }

        public string Display()
        {
            return $"Минимальное, среднее и максимальное знаечение (темература/влажность/давление): \nТемпература = {temperature}°. Влажность = {humidity}%. Давление = {pressure}. ({this.GetType()})";
        }
    }
}
