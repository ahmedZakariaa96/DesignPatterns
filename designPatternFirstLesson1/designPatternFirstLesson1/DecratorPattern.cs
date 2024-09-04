using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace designPatternFirstLesson1
{
    public interface Shap
    {
        void draw();
    }
    public class Rectangle : Shap
    {
        public void draw()
        {
            Console.WriteLine("rectangle is drawing now");
        }
    }
    public class Circle : Shap
    {
        public void draw()
        {
            Console.WriteLine("Circle is drawing now");
        }
    }
    public abstract class ShapDecrator : Shap
    {
        protected Shap shapDecrator;
        public ShapDecrator(Shap shap)
        {
            this.shapDecrator = shap;
        }

        public virtual void draw()
        {
            this.shapDecrator.draw();
        }
    }
    public class BorderShapDecrator:ShapDecrator
    {
        public BorderShapDecrator(Shap shapDecrator) :base(shapDecrator)
        {
        }
        public override void draw()
        {
            this.setBorder(this.shapDecrator);
            shapDecrator.draw();
        }

        public void setBorder(Shap shapDecrator)
        {
            Console.WriteLine("Red Borrder is Added");
        }
    }
    public class PaddingShapDecrator : ShapDecrator
    {
        public PaddingShapDecrator(Shap shapDecrator) : base(shapDecrator)
        {
        }
        public override void draw()
        {
            this.setBorder(this.shapDecrator);
            shapDecrator.draw();
        }

        public void setBorder(Shap shapDecrator)
        {
            Console.WriteLine("Padding is Added");
        }
    }
}
