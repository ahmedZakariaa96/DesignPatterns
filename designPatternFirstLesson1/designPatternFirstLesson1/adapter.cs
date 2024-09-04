using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace designPatternFirstLesson1
{
    //1)create target interface and class that implemnted this interface 
    public interface Attacker
    {
        void driving();
        void shooting();
    }
    public class tank : Attacker
    {
        public void driving()
        {
            Console.WriteLine("tank is driving Now");
        }

        public void shooting()
        {
            Console.WriteLine("tank is shooting Now");
        }
    }

    //3)create adapter class that convert from source to target (AirForce->Attacker)

    public class Adapter : Attacker
    {
        AirForce airforce;
        public Adapter(AirForce airforce)
        {
            this.airforce = airforce;
        }
        public void driving()
        {
            this.airforce.flying();
        }
        public void shooting()
        {
            this.airforce.rocketFire();
        }
    }

    //2)create source interface and class that implemented this interface
    public interface AirForce
    {
        void flying();
        void rocketFire();
    }

    public class WarPlants : AirForce
    {
        public void flying()
        {
            Console.WriteLine("WarPlants is flying Now");
        }

        public void rocketFire()
        {
            Console.WriteLine("WarPlants is rocketFireing Now");
        }
    }
}
