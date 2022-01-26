using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SkeletonLibrary;

namespace Skeleton
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteSubject basa = new ConcreteSubject();
            ConcreteObserver man = new ConcreteObserver();
            ConcreteObserver woman = new ConcreteObserver();


            basa.registerObserver(man, "Саша");

            basa.State = "1";

            Console.WriteLine(man.Counter);
            Console.WriteLine(woman.Counter);
            Console.WriteLine(basa.ObserversMessage);

            basa.registerObserver(woman, "Маша");
            basa.State = "2";

            Console.WriteLine(man.Counter);
            Console.WriteLine(woman.Counter);
            Console.WriteLine(basa.ObserversMessage);

            basa.removeObserver(woman);
            basa.State = "3";

            Console.WriteLine(man.Counter);
            Console.WriteLine(woman.Counter);
            Console.WriteLine(basa.ObserversMessage);


            Console.ReadKey();
            
        }

    }
}
