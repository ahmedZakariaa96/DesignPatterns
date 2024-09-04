using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace designPatternFirstLesson1
{
    //1 create Observer inteface 
    public  interface Observer
    {
        void update(string type,int price);
    }
    //2 create class that inhirtance of this inteface
    public class Customer : Observer
    {
        string name;
        public Customer(string name)
        {
            this.name = name;
        }
        public void update(string type,int price)
        {
            Console.WriteLine("Hello " + this.name + " the price of "+type+" is " + price);
        }
    }
    public class Subblier : Observer
    {
        string name;
        public Subblier(string name)
        {
            this.name = name;
        }
        public void update(string type,int price)
        {
            Console.WriteLine("Hello " + this.name + " the price of " + type + " is " + price);
        }
    }
    //--------------------------------------
    //3 create interface product
    public interface ProductObs
    {
        void register(List<Observer> observers);
        void unRegister(List<Observer> observers);
        void notfy();
    }

    //4 craete class that use this interface and notfy all observers
    public class Labtop : ProductObs
    {
        List<Observer> observers;
        int Price;
        public Labtop(int price )
        {
            this.observers = new List<Observer>();
            this.Price = price;
        }
        public void notfy()
        {
            foreach(var observ in observers)
            {
                observ.update("labtop",this.Price);
            }
        }

        public void register(List<Observer> _observers)
        {
            foreach (var observ in _observers)
            {
                this.observers.Add(observ);
            }
        }

        public void unRegister(List<Observer> _observers)
        {
            foreach (var observ in _observers)
            {
                this.observers.Remove(observ);
            }
        }
    }
    public class Mobile : ProductObs
    {
        List<Observer> observers;
        int Price;

        public Mobile(int price)
        {
            this.observers = new List<Observer>();
            this.Price = price;

        }
        public void notfy()
        {
            foreach (var observ in observers)
            {
                observ.update("Mobile", this.Price);
            }
        }

        public void register(List<Observer> _observers)
        {
            foreach (var observ in _observers)
            {
                this.observers.Add(observ);
            }
        }

        public void unRegister(List<Observer> _observers)
        {
            foreach (var observ in _observers)
            {
                this.observers.Remove(observ);
            }
        }
    }
}
