using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace designPatternFirstLesson1
{   //1 abstract and classes
    public abstract class ShapePrototypePattern : ICloneable
    {
        private int id;
        protected string type;
        public abstract void draw();
        public string getType()
        {
            return type;
        }
        public int getId()
        {
            return id;
        }
        public void setId(int id)
        {
            this.id = id;
        }

        public object Clone()
        {
            object clone = null;
            try
            {
                clone = this.Clone();//super.clone();
                return clone;
            }

            catch
            {
                return clone;
            }
            
        }
    }
    public class RectanglePrototypePattern : ShapePrototypePattern
    {
        public RectanglePrototypePattern()
        {
            this.type = "Rectangle";
        }
        public override void draw()
        {
            Console.WriteLine("Rectangle is drawing");
        }
    }
    public class SquarePrototypePattern : ShapePrototypePattern
    {
        public SquarePrototypePattern()
        {
            this.type = "Square";
        }
        public override void draw()
        {
            Console.WriteLine("Square is drawing");
        }
    }
    public class CirclePrototypePattern : ShapePrototypePattern
    {
        public CirclePrototypePattern()
        {
            this.type = "Circle";
        }
        public override void draw()
        {
            Console.WriteLine("Circle is drawing");
        }
    }
    //2 create shapeCash and put shapes in it
    public class ShapeCash
    {
        private static Hashtable shapMap = new Hashtable();
        public static ShapePrototypePattern getShape(int id)
        {
            ShapePrototypePattern shap = (ShapePrototypePattern)shapMap[id];
            return  shap;
        }
        public static void  loadCash()
        {
            CirclePrototypePattern c1 = new CirclePrototypePattern();
            c1.setId(1);
            shapMap[c1.getId()] = c1;
            //--------------------------------------------
            RectanglePrototypePattern r1 = new RectanglePrototypePattern();
            r1.setId(2);
            shapMap[r1.getId()] = r1;
            //--------------------------------------------
            SquarePrototypePattern s1 = new SquarePrototypePattern();
            s1.setId(3);
            shapMap[s1.getId()] = s1;
        }
    }

}
