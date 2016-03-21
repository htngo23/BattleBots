using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots
{
    class DemonRobot : RoboMain
    {
        public DemonRobot(String Name, String type, String MainFunction, int PowerLevel, int Health, int PP)
        {
            name = Name;
            this.type = type;
            mainFunction = MainFunction;
            powerLevel = PowerLevel;
            health = Health;
            pP = PP;
        }
        public void MagmaBlast()
        {
            Console.WriteLine("Genos : INCENERATE!!! It looks like a nuke was just dropped...");
            Console.WriteLine("Your opponent took 25 damage");

        }

        public void HellRain()
        {
            Console.WriteLine("Flurries of metal melting demon blood falls from the sky");
            Console.WriteLine("Your opponent took 15 damage");
        }
        public int takeBrainScramble()
        {
            health -= 5;
            Console.WriteLine("Genos says : HAHA that tickles");
            return health;
        }
        public int takeLaserlabotomy()
        {
            health -= 45;
            Console.WriteLine("Genos says : HAHA that tickles");
            return health;
        }
    }
}