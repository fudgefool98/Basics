using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            const Byte sample1 = 0x64;
            Byte sample2 = 100;
            int heartRate = 85;
            double deposits = 135002766.0;
            const double acceleration = 9.800;
            var mass = 14.6;
            double distance = 129.763001;
            var lost = true;
            var expensive = true;
            var choice = 2;

            const char integral = '\u222B';
    //    Declare a constant that is a character type named integral that has a constue of “\u222B”

            const string greeting = "hello";
            var name = "karen";

            if (sample1 == sample2)
            {
                Console.WriteLine("The samples are equal.");
            }
            else
            {
                Console.WriteLine("The samples are not equal.");
            }

            if (heartRate >= 40 && heartRate >= 80)
            {
                Console.WriteLine("Heart rate is normal.");
            }
            else
            {
                Console.WriteLine("Heart rate is not normal.");
            }

            if (deposits >= 100000000)
            {
                Console.WriteLine("You are exceedingly wealthy.");
            }
            else
            {
                Console.WriteLine("Sorry you are so poor.");
            }

            var force = mass * acceleration;
            Console.WriteLine("force = " + force);
            Console.WriteLine(distance + " is the distance");

            if (lost && expensive){
                Console.WriteLine("I am really sorry! I will get the manager.");
            }
            else if (lost && !expensive){
                Console.WriteLine("Here is coupon for 10% off.");
            }
            switch(choice) {
                case 1:
                    Console.WriteLine("You chose 1");
                    break;
                case 2:
                    Console.WriteLine("You chose 2");
                    break;
                case 3:
                    Console.WriteLine("You chose 3");
                    break;
                default:
                    Console.WriteLine("You made an unknown choice.");
                    break;
               }
            

            Console.WriteLine(integral + " is an integral");

            for (var i=5; i < 11;i++) { Console.WriteLine("i = " + i); }
            var age = 0;
            while (age < 6)
            {
                Console.WriteLine("age = " + age);
                age++;
            }
            Console.WriteLine(greeting + " " + name);
            Console.WriteLine("Press any key to exit..."); Console.ReadKey();
        }
    }
}
