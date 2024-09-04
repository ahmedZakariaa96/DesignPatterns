using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace designPatternFirstLesson1
{
    //1 create abstract class and real and null object
    public abstract class AbstractCustomer
    {
        protected string name;
        public abstract Boolean isNull();
        public abstract string getName();

    }
    public class RealCustomer:AbstractCustomer
    {
        public RealCustomer(string name)
        {
            this.name = name;
        }

        public override string getName()
        {
            return this.name;
        }

        public override bool isNull()
        {
            return false;
        }
    }
    public class NullCustomer : AbstractCustomer
    {
        public override string getName()
        {
            return "this customer is not founded at dataBase";
        }

        public override bool isNull()
        {
            return true;
        }
    }
    //2 create customer factory
    public class Customerfactory
    {
        public static string[] names = { "ahmed", "ali", "Mostafe" };
        public static AbstractCustomer getCustomerName(string name)
        {
            foreach (var nameItem in names)
            {
                if(nameItem.ToLower()==name.ToLower())
                {
                    return new RealCustomer(name);
                }

            }
            return new NullCustomer();
        }
    }
}
