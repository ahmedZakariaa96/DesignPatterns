using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace designPatternFirstLesson1
{
    public  class SingleObject
    {
        private static  SingleObject singleObject ;
        private static object _lock = new object();
        private SingleObject()
        {
            //load data 
        }
        public static  SingleObject getInstanceObject()
        {
            //using double check and lock statment
            if(singleObject==null)
            {
                lock(_lock)
                {
                    if(singleObject == null)
                    singleObject = new SingleObject();
                }
            }
            return  singleObject;
        }
        public void message()
        {
            Console.WriteLine("Welcome Single Ton Design Pattern");
        }
    }
}
