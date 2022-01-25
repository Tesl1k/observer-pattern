using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkeletonLibrary
{
    public class ConcreteObserver : IObserver
    {
        public string Name { get; set; }
        public string Update()
        {
            return $"Пользователь {Name} ({GetType()}) оповещён";
        }
    }
}
