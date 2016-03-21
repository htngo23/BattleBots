using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots
{
    class WindRobot : RoboMain
    {
        public WindRobot(String Name, String type, String MainFunction, int PowerLevel, int Health)
        {
            name = Name;
            this.type = type;
            mainFunction = MainFunction;
            powerLevel = PowerLevel;
            health = Health;
        }
    }
}
