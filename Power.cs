using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots
{
    public class Power
    {
        DemonRobot gen = new DemonRobot("Genos", "Combat", "Pure Chaos", 9001, 100, 10);
        PsychicRobot joy = new PsychicRobot("Joy", "Esper", "Complete mind torture", 8500, 100, 9);
        public int healthGenos;
        public int healthJoy;
        public int ppGenos;
        public int ppJoy;
     

        //public int move()
        //{
        //    totalpower -= 10;
        //    Console.WriteLine(totalpower);
        //    return totalpower;
        //}
        //public int blast()
        //{
        //    totalpower -= 25;
        //    Console.WriteLine(totalpower);
        //    return totalpower;
        //}
        //public int recover()
        //{
        //    totalpower -= 25;
        //    Console.WriteLine(totalpower);
        //    return totalpower;
        //}
        //public int checklevels()
        //{
        //    Console.WriteLine(totalpower);
        //    return totalpower;
        //}
        //public int sufficientpower()
        //{
        //    int totalpower2 = totalpower;
        //    return totalpower;
        //}
        public void genosVjoy()
        {
            healthGenos = gen.health;
            healthJoy = joy.health;
            ppGenos = gen.pP;
            ppJoy = joy.pP;
            
            Console.WriteLine("Genos turn, pick a attack Magama Blast (1) or HellRain (2)");
            while ((healthGenos > 0) && (healthJoy > 0))
            {
                string reader = Console.ReadLine();
                switch (reader)
                {
                    case "1":
                        gen.MagmaBlast();
                        joy.takeMagmaBlast();
                        healthJoy -= 25;
                        ppGenos -= 4;
                        Console.WriteLine("Joy's health is now: " + healthJoy);
                        Console.WriteLine("Genos's PP is now at :" + ppGenos + "/10");
                        break;
                    case "2":
                        gen.HellRain();
                        joy.takeHellRain();
                        healthJoy -= 10;
                        ppGenos -= 2;
                        Console.WriteLine("Joy's health is now: " + healthJoy);
                        Console.WriteLine("Genos's PP is now at :" + ppGenos + "/10");
                        break;
                    case "3":

                        break;

                    default:
                        break;
                }

                Console.WriteLine("Joy's turn, pick a attack Brain Scramble (1) or HellRain (2)");
                string leer = Console.ReadLine();
                switch (leer)
                {
                    case "1":
                        joy.brainScramble();
                        gen.takeBrainScramble();
                        healthGenos -= 5;
                        ppJoy -= 1;
                        Console.WriteLine("Genos's health is now:  " + healthGenos);
                        Console.WriteLine("Joy's PP is now at :" + ppJoy + "/10");
                        break;
                    case "2":
                        joy.laserlabotamy();
                        healthGenos -= 45;
                        ppJoy -= 6;
                        Console.WriteLine("Geno's health is now: " + healthGenos);
                        Console.WriteLine("Joy's PP is now at :" + ppJoy + "/10");
                        break;
                    default:
                        break;
                }
            }
            if(healthGenos <= 0)
            {
                Console.WriteLine("Joy is the winner" );
            }
            if(healthJoy <= 0)
            {
                Console.WriteLine("Genos is the winner");
            }
        }
        public void combatMain()
        {
            Console.WriteLine("Pick a robot.  Genos or Joy");
            String robo1 = Console.ReadLine();
            Console.WriteLine("Now Pick a second robot.  Genos or Joy");
            String robo2 = Console.ReadLine();
            if((robo1 == "Genos") & (robo2 == "Joy"))
             {
                // continue off when a switch statement to implement combat.  
            }
            
        }
    }
}
