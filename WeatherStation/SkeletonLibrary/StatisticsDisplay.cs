using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkeletonLibrary
{
    public class StatisticsDisplay : IObserver, IDisplayElement
    {
        public static float MinTemperature;
        public static float MaxTemperature;
        public static float AvgTemperature;
        public static float MinHumidity;
        public static float MaxHumidity;
        public static float AvgHumidity;
        public static float MinPressure;
        public static float MaxPressure;
        public static float AvgPressure;
        private ISubject weatherData;

        public StatisticsDisplay(ISubject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.registerObserver(this);
        }

        public string Update(float temp, float humidity, float pressure)
        {
            return ToUpdate(MinTemperature, MaxTemperature, MinHumidity, MaxHumidity, MinPressure, MaxPressure);
        }
        public string ToUpdate(float t1, float t2, float h1, float h2, float p1, float p2)
        {
            MinTemperature = t1;
            MaxTemperature = t2;
            AvgTemperature = (t1 + t2)/2; 
            MinHumidity = h1;
            MaxHumidity = h2;
            AvgHumidity = (h1 + h2) / 2;
            MinPressure = p1;
            MaxPressure = p2;
            AvgPressure = (p1 + p2) / 2;
            return Display();
        }

        public string Display()
        {
            return $"Минимальное, среднее и максимальное знаечение (темература/влажность/давление): \nТемпература = {MinTemperature}°/{AvgTemperature}°/{MaxTemperature}°. Влажность = {MinHumidity}%/{AvgHumidity}%/{MaxHumidity}%. Давление = {MinPressure}/{AvgPressure}/{MaxPressure}. ({this.GetType()})";
        }
    }
}
