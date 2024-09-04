using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace designPatternFirstLesson1
{
    public interface ShapFactor
    {
        void draw();
    }
    public class CircleFactor : ShapFactor
    {
        public void draw()
        {
            Console.WriteLine("CircleFactor is drawing");
        }
    }
    public class RectangleFactor : ShapFactor
    {
        public void draw()
        {
            Console.WriteLine("RectangleFactor is drawing");
        }
    }

    public class factor
    {
        public ShapFactor  GetShape(string typeShape)
        {
             if (typeShape == "circle")
            {
                return new CircleFactor();
            }
            else if (typeShape == "rectangle")
            {
                return new RectangleFactor();
            }
            else
            {
                return null;
            }
        }
    }
}
