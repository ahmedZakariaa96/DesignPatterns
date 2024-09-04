using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace designPatternFirstLesson1
{
    public interface Internet 
    {
        void connectTo(string host);
    }
    public class RealInternet : Internet
    {
        public void connectTo(string host)
        {
            Console.WriteLine("Connected To The " + host);
        }
    }
    public class ProxyInternet : Internet
    {
        RealInternet realInternet;
        List<string> banned = new List<string>();

        public ProxyInternet()
        {
            this.banned.Add("www.a@yahoo.com");
            this.banned.Add("www.b@yahoo.com");
            this.banned.Add("www.c@yahoo.com");
            realInternet = new RealInternet();
        }
        public void connectTo(string host)
        {
            if(banned.Contains(host))
            {
                Console.WriteLine("this " + host + " is banned");
            }
            else
            {
                realInternet.connectTo(host);
            }
        }
    }
}
