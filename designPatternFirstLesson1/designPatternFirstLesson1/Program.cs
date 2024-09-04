using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace designPatternFirstLesson1
{
    class Program
    {
        static void Main(string[] args)
        {

            ////composite pattern
            //Employee ceo = new Employee("ahmed", "CEO", "4k");
            //Employee headMarket = new Employee("ali", "market", "3k");
            //Employee headSales = new Employee("mostafe", "Sales", "3k");

            //Employee empMarket1 = new Employee("momo", "market", "2k");
            //Employee empMarket2 = new Employee("moka", "market", "2k");

            //Employee empSales1 = new Employee("abdalle", "sales", "1k");
            //Employee empSales2 = new Employee("mohamoued", "sales", "1k");

            //ceo.add(headMarket);
            //ceo.add(headSales);

            //headSales.add(empSales1);
            //headSales.add(empSales2);

            //headMarket.add(empMarket1);
            //headMarket.add(empMarket2);

            //ceo.display();
            //---------------------------

            //front conntrolller pattern
            //FrontController fC = new FrontController();
            //fC.dispatchRequest("stuDent");
            //Console.WriteLine("_________________________________");
            //fC.dispatchRequest("HOme");
            //Console.WriteLine("_________________________________");
            //fC.dispatchRequest("bbbb");

            //---------------------------------------------
            //// transfar object pattern
            //StudentBO stdbo = new StudentBO();
            //stdbo.display();
            //stdbo.updateStudent(stdbo.getStudent(2), "mohmed");
            //Console.WriteLine("-------------------------------");
            //stdbo.display();
            //stdbo.deleteStudent(1);
            //Console.WriteLine("-------------------------------");
            //stdbo.display();
            //stdbo.add(new StudentVo("moka", 3));
            //Console.WriteLine("-------------------------------");
            //stdbo.display();
            ////---------------------------------
            //// Null Object Pattern
            AbstractCustomer c1 = Customerfactory.getCustomerName("momo");
            AbstractCustomer c2 = Customerfactory.getCustomerName("ahmed");
            AbstractCustomer c3 = Customerfactory.getCustomerName("ali");
            AbstractCustomer c4 = Customerfactory.getCustomerName("mostafe");
            Console.WriteLine(c1.getName());
            Console.WriteLine(c1.isNull());
            Console.WriteLine(c2.getName());
            Console.WriteLine(c2.isNull());
            Console.WriteLine(c3.getName());
            Console.WriteLine(c3.isNull());
            Console.WriteLine(c4.getName());
            Console.WriteLine(c4.isNull());

            ////-----------------------------------
            ////prototype patterns
            //ShapeCash.loadCash();
            //ShapePrototypePattern s1 = ShapeCash.getShape(1);
            //s1.draw();
            //Console.WriteLine(s1.getType());
            //s1 = ShapeCash.getShape(2);
            //s1.draw();
            //Console.WriteLine(s1.getType());
            //s1 = ShapeCash.getShape(3);
            //s1.draw();
            //Console.WriteLine(s1.getType());
            ////-----------------------
            ////abstract factory
            //FactoryProducer fp = new FactoryProducer();
            //AbstractFactory af = fp.getType(false);//true rounded
            //ShapAbstract saf = af.getShape("rectangle");
            //saf.draw();
            //saf = af.getShape("square");
            //saf.draw();
            ////--------------------------
            ////factor design pattern
            //factor f = new factor();
            //ShapFactor shapFactor = f.GetShape("circle");
            //shapFactor.draw();
            //shapFactor = f.GetShape("rectangle");
            //shapFactor.draw();
            ////------------------------------
            //facade pattern
            //ShapFacade circle = new CircleFacade();
            //circle.draw();
            //ShapMacker shapMacker = new ShapMacker();
            //shapMacker.drawRectangle();
            //shapMacker.drawCircle();
            //shapMacker.drawSquare();
            //-------------------------------
            //////singleTon design
            //SingleObject single = SingleObject.getInstanceObject();
            //single.message();

            //-------------------------------
            //Attacker tank = new tank();
            //tank.driving();
            //tank.shooting();
            //Console.WriteLine("--------------------");
            //AirForce airFace = new WarPlants();
            //airFace.flying();
            //airFace.rocketFire();
            //Console.WriteLine("--------------------");
            //Adapter adapter = new Adapter(airFace);
            //adapter.driving();
            //adapter.shooting();
            //----------------------------
            ////proxy Pattern
            //Internet proxInternet = new ProxyInternet();
            //proxInternet.connectTo("www.a@yahoo.com");
            //proxInternet.connectTo("www.ab@yahoo.com");
            //---------------------------
            //Template design patten
            //Game game = new Footbal();
            //game.play();
            //game = new Tennis();
            //game.play();
            ////-----------------------
            //Decratore design pattern
            //Shap rec = new Rectangle();
            //rec.draw();
            //Shap BSD = new BorderShapDecrator(rec);
            //BSD.draw();
            //Console.WriteLine("_____________________________");
            //Shap circle = new Circle();
            //circle.draw();
            //BSD = new PaddingShapDecrator(circle);
            //BSD.draw();
            ////-----------------------------------------------
            //state patterns
            //Computer com = new Computer();
            //StartState stS = new StartState();
            //stS.doAction(com);
            //com.message();
            //StopState spS = new StopState();
            //spS.doAction(com);
            //com.message();

            //SleepState slS = new SleepState();
            //slS.doAction(com);
            //com.message();
            //-------------------------------------
            ////command pattern
            //FirstStock s = new FirstStock("t-shirt", 50);
            //SecondStock s2 = new SecondStock("shoes", 50);

            //BuyStock b1 = new BuyStock(s);
            //SellStock s1 = new SellStock(s2);
            //Broker broker = new Broker();
            //broker.takeOrder(b1);
            //broker.takeOrder(s1);
            //broker.takeOrder(b1);
            //broker.placeOrder();
            ////--------------------------------------------------
            //// observer design patterns
            //Customer c1 = new Customer("ahmed");
            //Subblier s1 = new Subblier("ali");
            //List<Observer> obs = new List<Observer>() { c1, s1 };
            //List<Observer> obs2 = new List<Observer>() { s1 };
            //Labtop labtop = new Labtop(1000);
            //labtop.register(obs);
            //labtop.notfy();
            //labtop.unRegister(obs2);
            //labtop.notfy();
            //Console.WriteLine("______________________________________");

            //Mobile mobile = new Mobile(2000);
            //mobile.register(obs);
            //mobile.notfy();
            //List<Observer> obs3 = new List<Observer>() { c1 };
            //mobile.unRegister(obs3);
            //mobile.notfy();
            //------------------------------------------------------
            ////strategy Design Pattern
            //1
            //OperationAdd<int> opAdd = new OperationAdd<int>();
            //OperationSubstract<int> opSub = new OperationSubstract<int>();
            //OperationMultiply<int> opMul = new OperationMultiply<int>();
            //Console.WriteLine("add=" + opAdd.doOpertation(1, 1));
            //Console.WriteLine("sub=" + opSub.doOpertation(1, 1));
            //Console.WriteLine("mul=" + opMul.doOpertation(1, 1));
            //Console.WriteLine("______________________________________");
            ////------------------------------------------------------------
            //2
            //ContextStartgeyPattern<int> csp = new ContextStartgeyPattern<int>(opAdd);
            //Console.WriteLine("add=" + csp.executeStrategy(1, 1));
            //csp = new ContextStartgeyPattern<int>(opSub);
            //Console.WriteLine("sub=" + csp.executeStrategy(1, 1));
            //csp = new ContextStartgeyPattern<int>(opMul);
            //Console.WriteLine("mul=" + csp.executeStrategy(1, 1));
            //Console.WriteLine("______________________________________");
            ////------------------------------------------------------------
            ////3
            //ContextStartgeyPattern<double> csp2 = new ContextStartgeyPattern<double>(new OperationAdd<double>());
            //Console.WriteLine("add=" + csp2.executeStrategy(1, 1.2));
            //csp2 = new ContextStartgeyPattern<double>(new OperationSubstract<double>());
            //Console.WriteLine("sub=" + csp2.executeStrategy(1.2, 1));
            //csp2 = new ContextStartgeyPattern<double>(new OperationMultiply<double>());
            //Console.WriteLine("mul=" + csp2.executeStrategy(1, 1));
            //Console.WriteLine("______________________________________");
            ////-------------------------------------------------------------
            //Db2 db = new Db2();
            //Cloud cloud = new Cloud();
            //user1 user = new user1(db);
            //user.userInfo();
            //user1 user2 = new user1(cloud);
            //user2.userInfo();
            //--------------------------------------------------------
            //    BMW Bmw = new BMW();
            //    Bmw.start();
            //    Bmw.start();
            //    Bmw.getOil();
            //    //-----------------
            //    Opel Opel = new Opel();
            //    Opel.start();
            //    Opel.start();
            //    Opel.getOil();
            //    //------------------------------------------------
            //    ElCar elCar = new ElCar(Opel);
            //    elCar.EStart();
            //    elCar.EStop();
            //------------------------------------------------
            //Product p1 = new Product(1, "product1", 200);
            //Product p2 = new Product(2, "product2", 400);
            //Product p3 = new Product(3, "product3", 600);
            //List<Product> productList = new List<Product>() { p1, p2, p3 };
            //Orders order1 = new Orders();
            //order1.insertOrders(productList);
            //order1.getOrders();
            //PdfExport pdfExport = new PdfExport();
            //pdfExport.export(p1);

            //-------------------------------------------------
            //List<Teacher> teacherList = new List<Teacher>() {new Teacher("ahmed",200)
            // ,new Teacher("ali",400)
            // ,new Teacher("mostafe",600),
            //};
            //School school = new School("Naboya Mouse", teacherList);
            //school.showData();
            //------------------------------------------
            //Db db = new Db();
            //user user1 = new user();
            //user1.show();
            //---------------------------------------
            //kitcheen kit1 = new kitcheen();
            //kit1.fly();
            //kit1.Swim();
            //kit1.walk();
            //kit1.displayWeight();
            //kit1.Weight = 3;
            //kit1.displayWeight();
            ////-----------------------------
            //Eagle eagle = new Eagle();
            //eagle.fly();
            //eagle.walk();
            //------------------------------------

            Console.ReadKey();
        }
    }
}
