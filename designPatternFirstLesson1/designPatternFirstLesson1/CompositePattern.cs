using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace designPatternFirstLesson1
{
   public class Employee
    {
         string name;
         string depertMent;
         string salary;
         List<Employee> subEmployews;

        public Employee(string name,string dep,string salary)
        {
            this.name = name;
            this.depertMent = dep;
            this.salary = salary;
            this.subEmployews = new List<Employee>();

        }

        public void add(Employee emp)
        {
            this.subEmployews.Add(emp);
        }
        public void remove(Employee emp)
        {
            this.remove(emp);
        }
        public List<Employee> getAllEmployee()
        {
            return this.subEmployews;
        }

        public void toString()
        {
            Console.WriteLine("name is " + this.name + " department is " + this.depertMent + " and salary is " + this.salary);
        }

       public void display()
        {
            this.toString();
            Console.WriteLine("-----------------------------");
            foreach (var headEmployee in this.getAllEmployee())
            {
                Console.Write("Head is:- "); headEmployee.toString();
                foreach (var employee in headEmployee.getAllEmployee())
                {
                    Console.Write("Employee is:- "); employee.toString();
                }
                Console.WriteLine("-----------------------------");

            }
        }
    }
}
