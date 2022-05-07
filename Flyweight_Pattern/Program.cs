﻿using Flyweight_Pattern.Structural;
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
            FlyweightFactory factory = new FlyweightFactory();
            
            #endregion
            Console.WriteLine("\n===============================\n");
            #region Real-world Code
            Console.WriteLine("-------------------Real-world Code------------------\n");

            #endregion
        }
    }
}