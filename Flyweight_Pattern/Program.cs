using Flyweight_Pattern.RealWorld;
using Flyweight_Pattern.Structural;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight_Pattern
{
    /// <summary>
    /// Flyweight Design Pattern
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Structural Code
            Console.WriteLine("------------------Structural Code--------------------\n");
            // Arbitrary extrinsic state
            int extrinsicstate = 22;
            FlyweightFactory factoryI = new FlyweightFactory();
            // Work with different flyweight instances
            Flyweight fx = factoryI.GetFlyweight("X");
            fx.Operation(--extrinsicstate);
            Flyweight fy = factoryI.GetFlyweight("Y");
            fy.Operation(--extrinsicstate);
            Flyweight fz = factoryI.GetFlyweight("Z");
            fz.Operation(--extrinsicstate);

            UnsharedConcreteFlyweight unsharedConcreteFlyweight = new UnsharedConcreteFlyweight();
            unsharedConcreteFlyweight.Operation(--extrinsicstate);
            #endregion

            Console.WriteLine("\n===============================\n");

            #region Real-world Code
            Console.WriteLine("-------------------Real-world Code------------------\n");
            // Build a document with text
            string document = "AAZZBBZB";
            char[] chars = document.ToCharArray();

            CharacterFactory factoryII = new CharacterFactory();

            // extrinsic state
            int pointSize = 10;

            // Foreach character use a flyweight object
            foreach(char c in chars)
            {
                pointSize++;
                Character character = factoryII.GetCharacter(c);
                character.Display(pointSize);
            }
            #endregion
        }
    }
}
