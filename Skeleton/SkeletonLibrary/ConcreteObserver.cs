using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkeletonLibrary
{
    public class ConcreteObserver : IObserver
    {
        public int Counter { get; set; } = 0;
        public string Name { get; set; }

        public string Update()
        {
            Counter += 1;
            return $"Пользователь {Name} ({GetType()}) оповещён.";
        }
    }
}
