using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace designPatternFirstLesson1
{
   public abstract class Game
    {
        public abstract  void initilize();
        public abstract void start();
        public abstract void end();

        public void play()
        {
            this.initilize();
            this.start();
            this.end();
        }

    }

    public class Footbal : Game
    {
        public override void end()
        {
            Console.WriteLine("Footbal Game is Ending");
        }

        public override void initilize()
        {
            Console.WriteLine("Footbal Game is initilizing");
        }

        public override void start()
        {
            Console.WriteLine("Footbal Game is Starting");
        }
    }
    public class Tennis : Game
    {
        public override void end()
        {
            Console.WriteLine("Tennis Game is Ending");
        }

        public override void initilize()
        {
            Console.WriteLine("Tennis Game is initilizing");
        }

        public override void start()
        {
            Console.WriteLine("Tennis Game is Starting");
        }
    }
}
