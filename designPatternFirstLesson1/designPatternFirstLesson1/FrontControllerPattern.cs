using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace designPatternFirstLesson1
{
    public class StudentView
    {
        public void show()
        {
            Console.WriteLine("Displaying Student Page");
        }
    }
    public class HomeView
    {
        public void show()
        {
            Console.WriteLine("Displaying Home Page");
        }
    }
    public class Dispatcher
    {
        private StudentView stdView;
        private HomeView homeView;
        public Dispatcher()
        {
            stdView = new StudentView();
            homeView = new HomeView();
        }
        public void dispatch(string request)
        {
            if(request.ToLower()=="student")
            {
                this.stdView.show();
            }
            else
            {
                this.homeView.show();
            }
        }
    }

    public class FrontController
    {
        private Dispatcher dispatcher;
        public FrontController()
        {
            this.dispatcher = new Dispatcher();
        }
        public bool isAuthontication()
        {
            Console.WriteLine("User is authenticated successfully.");
            return true;
        }
        public void trackRequest(string request)
        {
            Console.WriteLine("Page requested: " +request);
        }
        public void dispatchRequest(string request)
        {
            this.trackRequest(request);
            if(this.isAuthontication())
            {
                this.dispatcher.dispatch(request);
            }
        }
    }
}
