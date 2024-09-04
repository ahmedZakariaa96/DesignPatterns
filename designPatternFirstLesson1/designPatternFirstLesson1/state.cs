using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace designPatternFirstLesson1
{
    //create state interface 
    public interface State
    {
        void doAction(Computer com);
        void message();
    }
    //2 create classs that implemenetd this interface
    public class StartState : State
    {
        public void doAction(Computer com)
        {
            Console.WriteLine("State is Start");
            com.setState(this);
        }
        public void message()
        {
            Console.WriteLine("The computer is Starting");
        }
    }
    public class StopState : State
    {
        public void doAction(Computer com)
        {
            Console.WriteLine("State is Stop");
            com.setState(this);
        }
        public void message()
        {
            Console.WriteLine("The computer is Stoping");
        }
    }
    public class SleepState : State
    {
        public void doAction(Computer com)
        {
            Console.WriteLine("State is Sleep");
            com.setState(this);
        }
        public void message()
        {
            Console.WriteLine("The computer is Sleeping");
        }
    }
    //3 show change using function messages;
    public class Computer
    {
        State state;
        public Computer()
        {
            this.state = null;
        }
        public void setState(State state)
        {
            this.state = state;
        }
        public void message()
        {
            this.state.message();
        }
    }
}
