using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots
{
    class PsychicRobot:RoboMain
    {

        public PsychicRobot(String Name, String type, String MainFunction, int Powerlevel, int Health, int PP)
        {
            name = Name;
            this.type = type;
            mainFunction = MainFunction;
            powerLevel = Powerlevel;
            health = Health;
            pP = PP;
        }
        public int takeMagmaBlast()
        {
            health -= 25;
            Console.WriteLine("Damn thats hot...");
            return health;
        }
        public int takeHellRain()
        {
            Console.WriteLine("Make it rain baby");
            return health;
        }
        public void brainScramble()
        {
            Console.WriteLine("Dana White says: Robots don't have brains... but you still hurt him! ");
            Console.WriteLine("Your opponent took 5 damage");

        }
        public void laserlabotamy()
        {
            Console.WriteLine("AHHHH WTF, says Genos");
            
        }
    }
}
