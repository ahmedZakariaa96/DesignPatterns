using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace designPatternFirstLesson1
{
    public interface ShapFacade
    {
        void draw();
    }
    public class CircleFacade : ShapFacade
    {
        public void draw()
        {
            Console.WriteLine("CircleFacade is drawing");
        }

    }
    public class RectangleFacade : ShapFacade
    {
        public void draw()
        {
            Console.WriteLine("RectangleFacade is drawing");
        }

    }
    public class SquareFacade : ShapFacade
    {
        public void draw()
        {
            Console.WriteLine("SquareFacade is drawing");
        }

    }

    public class ShapMacker
    {
        CircleFacade circel;
        RectangleFacade rectangle;
        SquareFacade square;
        public ShapMacker()
        {
            this.circel = new CircleFacade();
            this.square = new SquareFacade();
            this.rectangle = new RectangleFacade();
        }
        public void  drawCircle()
        {
            this.circel.draw();
        }
        public void drawSquare()
        {
            this.square.draw();
        }
        public void drawRectangle()
        {
            this.rectangle.draw();
        }
    }
}
