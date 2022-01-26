using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkeletonLibrary
{
    public interface IObserver
    {
        
        string Update(float temp, float humidity, float pressure);


    }
}
