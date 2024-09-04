using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace designPatternFirstLesson1
{

    //1 create request class
    public interface Stock
    {
        void buy();
        void sell();
       
    }
    public class FirstStock:Stock
    {
        private string name;
        private int quantity;
        public FirstStock(string name,int quantity)
        {
            this.name = name;
            this.quantity = quantity;
        }
        public void buy()
        {
            Console.WriteLine("Stock [Name:" + name + " Quantity: " + quantity + "] bought");
        }
        public void sell()
        {
            Console.WriteLine("Stock [Name:" + name + " Quantity: " + quantity + "] sold");
        }
    }
    public class SecondStock : Stock
    {
        private string name;
        private int quantity;
        public SecondStock(string name, int quantity)
        {
            this.name = name;
            this.quantity = quantity;
        }
        public void buy()
        {
            Console.WriteLine("Stock [Name:" + name + " Quantity: " + quantity + "] bought");
        }
        public void sell()
        {
            Console.WriteLine("Stock [Name:" + name + " Quantity: " + quantity + "] sold");
        }
    }
    //2 create command interface
    public interface Order
    {
        void execute();
    }

    //3 create concrete class implemented the order interface
    class BuyStock :Order
    {
        Stock stock;
        public BuyStock(Stock stock)
        {
            this.stock = stock;
        }

        public void execute()
        {
            this.stock.buy();
        }
    }
    class SellStock : Order
    {
        Stock stock;
        public SellStock(Stock stock)
        {
            this.stock = stock;
        }

        public void execute()
        {
            this.stock.sell();
        }
    }

    //4 create command invoker
    class Broker
    {
        List<Order> orders=new List<Order>();
        public void takeOrder(Order order)
        {
            this.orders.Add(order);
        }
        public void placeOrder()
        {
            foreach(var order in orders)
            {
                order.execute();
            }
            orders.Clear();
        }
    }

}
