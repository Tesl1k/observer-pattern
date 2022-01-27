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
        public string Update(float temp, float humidity, float pressure, float tmin, float tmax, float tavg, float hmin, float havg, float hmax, float pmin, float pmax, float pavg, float tprog, float hprog, float pprog)
        {
            MinTemperature = tmin;
            MaxTemperature = tmax;
            AvgTemperature = (tmin + tmax) /2; 
            MinHumidity = hmin;
            MaxHumidity = hmax;
            AvgHumidity = (hmin + hmax) / 2;
            MinPressure = pmin;
            MaxPressure = pmax;
            AvgPressure = (pmin + pmax) / 2;
            return Display();
        }

        public string Display()
        {
            return $"Минимальное, среднее и максимальное знаечение (темература/влажность/давление): \nТемпература = {MinTemperature}°/{AvgTemperature}°/{MaxTemperature}°. Влажность = {MinHumidity}%/{AvgHumidity}%/{MaxHumidity}%. Давление = {MinPressure}/{AvgPressure}/{MaxPressure}. ({this.GetType()})";
        }
    }
}
