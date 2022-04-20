﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Simple Singleton Pattern
            //// Constructor is protected -- cannot use 'new'
            //Singleton s1 = Singleton.Instance();
            //Singleton s2 = Singleton.Instance();

            //// Test for same instance
            //if(s1 == s2)
            //{
            //    Console.WriteLine("Objects are the same instance.");
            //}

            //// Wait for user
            //Console.ReadKey();
            #endregion

            #region real-world LoadBalancer
            LoadBalancer b1 = LoadBalancer.GetLoadBalancer();
            LoadBalancer b2 = LoadBalancer.GetLoadBalancer();
            LoadBalancer b3 = LoadBalancer.GetLoadBalancer();
            LoadBalancer b4 = LoadBalancer.GetLoadBalancer();

            // Same instance?
            if(b1 == b2 && b2 == b3 && b3 == b4)
            {
                Console.WriteLine("Same instance\n");
            }

            // Load balance 15 server request
            LoadBalancer balancer = LoadBalancer.GetLoadBalancer();
            for(int i = 0 ; i < 15 ; i++)
            {
                string server = balancer.Server;
                Console.WriteLine($"{i} - Dispatch Request to: " + server);
            }

            //Wait for user
            Console.ReadKey();
            #endregion

        }
    }
}
