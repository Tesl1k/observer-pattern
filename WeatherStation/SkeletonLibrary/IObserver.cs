using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkeletonLibrary
{
    public interface IObserver
    {
        
        string Update(float temp, float humidity, float pressure, float tmin, float tmax, float tavg, float hmin, float havg, float hmax, float pmin, float pmax, float pavg, float tprog, float hprog, float pprog);


    }
}
