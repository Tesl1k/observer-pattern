using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkeletonLibrary
{
    public interface ISubject
    {
        void registerObserver(ConcreteObserver observer, string name);

        void removeObserver(ConcreteObserver observer);

        string notifyObservers();

    }
}
