using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace designPatternFirstLesson1
{
    //1-create interface and class that inharted from this interface
    public interface ShapAbstract
    {
        void draw();
    }
    public class RectangleAbstract : ShapAbstract
    {
        public void draw()
        {
            Console.WriteLine("drawing rectangle");
        }
    }
    public class RoundedRectangleAbstract : ShapAbstract
    {
        public void draw()
        {
            Console.WriteLine("drawing rounded rectangle");
        }
    }
    public class SquareAbstract : ShapAbstract
    {
        public void draw()
        {
            Console.WriteLine("drawing square");
        }
    }
    public class RoundedSquareAbstract : ShapAbstract
    {
        public void draw()
        {
            Console.WriteLine("drawing rounded square");
        }
    }

    //2-create abstract class and class
    public interface  AbstractFactory
    {
        ShapAbstract getShape(string type);
    }
    public class ShapAbstractFactory : AbstractFactory
    {
        public  ShapAbstract getShape(string type)
        {
            if(type.ToLower()=="rectangle")
            {
                return new RectangleAbstract();
            }
            else if(type.ToLower() == "square")
            {
                return new SquareAbstract();
            }
            else
            {
                return null;
            }
        }
    }
    public class RoundedShapAbstractFactory : AbstractFactory
    {
        public  ShapAbstract getShape(string type)
        {
            if (type.ToLower() == "rectangle")
            {
                return new RoundedRectangleAbstract();
            }
            else if (type.ToLower() == "square")
            {
                return new RoundedSquareAbstract();
            }
            else
            {
                return null;
            }
        }
    }

   //3- create factroy producer
    public class FactoryProducer
    {
        public AbstractFactory getType(bool rounded)
        {
            if(rounded)
            {
                return new RoundedShapAbstractFactory();

            }
            else
            {
                return new ShapAbstractFactory();
            }
        }
    }
}
