using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots
{
    public class Logs
    {
        List<RoboMain> garage = new List<RoboMain>();

        DemonRobot Genos = new DemonRobot("Genos", "Combat", "Pure Chaos", 9001, 100, 10);
        PsychicRobot Joy = new PsychicRobot("Joy", "Esper", "Complete mind torture", 8500, 100, 9);
        WindRobot Vision = new WindRobot("Vision", "Elemental", "Uses powerful wind abilities", 8997, 100);
        DefenseRobot Huggy = new DefenseRobot("Huggy Boo", "Defense", "Will protect you at any cost", 4500, 150);

        public void storage()
        {

            garage.Add(Genos);
            garage.Add(Joy);
            garage.Add(Vision);
            garage.Add(Huggy);
            foreach (RoboMain robot in garage)
            {
                Console.WriteLine("Hi my name is " + robot.name);
                Console.WriteLine("I do " + robot.mainFunction);
                
            }

        }
    }
}
