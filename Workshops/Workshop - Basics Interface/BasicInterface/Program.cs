﻿using BasicInterface.Classes;
using BasicInterface.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Old stuff
            //IFlyable bird = new Bird();
            //IFlyable plane = new Plane();

            //bird.Fly();
            //plane.Fly();
            #endregion

            #region New stuff
            // Typing an object variable to an interface means we can treat
            // all classes/object implementing this interface the same way.
            // For example we may add different classes to a List of interfaces.
            // The downside is that we cannot access properties or methods that
            // are specific for Bird or Plane without type casting.
            List<IFlyable> flyingThings = new List<IFlyable>
            {
                new Bird { Color = "Red", TopSpeed = 30 },
                new Plane { TopSpeed = 1000 }
            };

            Console.WriteLine("Flying things: ");
            foreach (var flyingThing in flyingThings)
            {
                #region Will crash when we get to Plane
                //Console.WriteLine(((Bird)flyingThing).Color);
                #endregion

                flyingThing.Fly();
                Console.WriteLine("at the speed {0}", flyingThing.TopSpeed);
            }

            List<ISpeakable> speakingThings = new List<ISpeakable>
            {
                new Bird { Color = "Blue", TopSpeed = 40 },
                new Person(),
                new Dog()
            };

            Console.WriteLine("Speaking things: ");
            foreach (var speakingThing in speakingThings)
            {
                Console.WriteLine(speakingThing.Speak());
            }
            #endregion
        }
    }
}
