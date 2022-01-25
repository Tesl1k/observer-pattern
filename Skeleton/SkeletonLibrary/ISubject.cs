using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkeletonLibrary
{
    public interface ISubject
    {
        string Name { get; set; }
        void registerObserver(IObserver observer, string name);

        void removeObserver(IObserver observer);

        string notifyObservers();

    }
}
