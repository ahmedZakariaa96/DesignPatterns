using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace designPatternFirstLesson1
{
    interface Swimming
    {
        void Swim();
    }
    abstract class Birds
    {
        public void walk()
        {
            Console.WriteLine("I can walk");
        }
        abstract public void fly();
    }
    class kitcheen : Birds, Swimming
    {
        private float weight;
        public float Weight {
            get => this.weight;
            set => this.weight = value;
            //get
            //{
            //    return this.weight;
            //}
            //set
            //{
            //    this.weight = value;
            //}
        }
        public override void fly()
        {
            Console.WriteLine("I can't fly");
        }
        public void Swim()
        {
            Console.WriteLine("I can swim");
        }
        public void displayWeight()
        {
            Console.WriteLine(this.weight);
        }
    }
    class Eagle : Birds
    {
        public override void fly()
        {
            Console.WriteLine("I can  fly");
        }
    }
    class Db
    {
        public void connection()
        {
            Console.WriteLine("connection is done");
        }
        public void fetch()
        {
            Console.WriteLine("fetch is done");
        }
    }
    class user
    {
        public Db db;
        public user()
        {
            db = new Db();
        }
        public void show()
        {
            Console.WriteLine("users Data ");
            db.connection();
            db.fetch();
        }
    }
    class Teacher
    {
        private string name { set; get; }
        private int salary { set; get; }
        public Teacher(string name, int salary)
        {
            this.name = name;
            this.salary = salary;
        }
        public void displayTeacherData(int i)
        {
            Console.WriteLine("Data About Teacher number " + i);
            Console.WriteLine(this.name);
            Console.WriteLine(this.salary);
            Console.WriteLine("----------------------------------------------");

        }
    }
    class School
    {
        private string schoolName { get; set; }
        private List<Teacher> teachersList;
        public School(string schoolName, List<Teacher> teachersList)
        {
            this.schoolName = schoolName;
            this.teachersList = teachersList;
        }
        public void showData()
        {
            Console.WriteLine("School Name:- " + this.schoolName);
            int counter = 1;
            foreach (var teacher in teachersList)
            {
                teacher.displayTeacherData(counter++);
            }
        }
    }
    //---------------------------
    enum Types { pdf, xml, png, jpg };
    class Product
    {
        private int id;
        private string name;
        public string Name { get => this.name;
            set => this.name = value;
        }

        private int cost;
        public Product(int id, string name, int cost)
        {
            this.id = id;
            this.name = name;
            this.cost = cost;
        }
        public void displayProduct()
        {
            Console.WriteLine("Product Info");
            Console.WriteLine("id:-" + this.id);
            Console.WriteLine("name:-" + this.name);
            Console.WriteLine("cost:-" + this.cost);
            Console.WriteLine("-----------------------------------------------");
        }
    }
    class Orders
    {
        private List<Product> productList;
        public Orders()
        {
            this.productList = new List<Product>();
        }
        public Orders(List<Product> productList)
        {
            this.productList = productList;
        }
        public void insertOrders(List<Product> productList)
        {
            this.productList = productList;
        }
        public void getOrders()
        {
            foreach (var product in this.productList)
            {
                product.displayProduct();
            }
        }

    }
    class Export
    {
        public void export(string type, Product product)
        {
            switch (type)
            {
                case "pdf":
                    Console.WriteLine("product is convert to pdf");
                    break;

                case "jpg":
                    Console.WriteLine("product is convert to jpg");
                    break;

                case "png":
                    Console.WriteLine("product is convert to png");
                    break;

                default:
                    Console.WriteLine("product is convert to xml");
                    break;
            }


        }
    }
    interface Export1
    {
        void export(Product product);
    }
    class PdfExport : Export1
    {
        public void export(Product product)
        {
            Console.WriteLine("product Name:- " + product.Name + " is convert to pdf");
        }
    }
    class HtmlExport : Export1
    {
        public void export(Product product)
        {
            Console.WriteLine("product is convert to Html");
        }
    }
    class XmlExport : Export1
    {
        public void export(Product product)
        {
            Console.WriteLine("product is convert to Xml");
        }
    }
    class JpgExport : Export1
    {
        public void export(Product product)
        {
            Console.WriteLine("product is convert to jpg");
        }
    }
    //------------------------------------
    abstract public class Car
    {
        abstract public void start();
        abstract public void stop();
        abstract public void getOil();
    }
    public class BMW : Car
    {
        public override void getOil()
        {
            Console.WriteLine("BMW Is get oil");
        }

        public override void start()
        {
            Console.WriteLine("BMW Is Start");
        }

        public override void stop()
        {
            Console.WriteLine("BMW Is stop");
        }
    }
    public class Opel : Car
    {
        public override void getOil()
        {
            Console.WriteLine("Opel Is get oil");
        }

        public override void start()
        {
            Console.WriteLine("Opel Is Start");
        }

        public override void stop()
        {
            Console.WriteLine("Opel Is stop");
        }
    }
    public class ElCar
    {
        Car car;
        public ElCar(Car car)
        {
            this.car = car;
        }
        public void EStart()
        {
            this.car.start();
        }
        public void EStop()
        {
            this.car.stop();
        }
    }
    //-------------------------
    public interface  DBConnection
    {
          void connect();
          void fetch();
    }
    public class Db2 : DBConnection
    {
        public void connect()
        {
            Console.WriteLine("db is connected");
        }

        public void fetch()
        {
            Console.WriteLine("db is fetched");
        }
    }
    public class Cloud : DBConnection
    {
        public void connect()
        {
            Console.WriteLine("Cloud is connected");
        }

        public void fetch()
        {
            Console.WriteLine("Cloud is fetched");
        }
    }
    public class user1
    {
        DBConnection db;
        public user1(DBConnection db)
        {
            this.db = db;
        }
        public void userInfo()
        {
            this.db.connect();
            this.db.fetch();
        }

    }
}


