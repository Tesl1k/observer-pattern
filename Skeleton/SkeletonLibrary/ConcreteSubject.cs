using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkeletonLibrary
{
    public class ConcreteSubject : ISubject
    {     

        public string state;        

        List<ConcreteObserver> users = new List<ConcreteObserver>();

        public string State 
        {
            get
            {
                return state;
            }

            set
            {
                state = value;
                ObserversMessage = notifyObservers();
            }

        }

        public string ObserversMessage { get; set; }
        public void registerObserver(ConcreteObserver observer, string name)
        {
            observer.Name = name;
            users.Add(observer);
        }

        public void removeObserver(ConcreteObserver observer)
        {
            users.Remove(observer);
        }       
        
        
        public string notifyObservers()
        {
            string x = "";

            foreach (var user in users)
            {
                x += user.Update() + "\n";                
            }

            return x;
        }
    }
}
