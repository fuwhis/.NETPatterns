using Singleton_Demo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Structural Code of Singleton Pattern
            Console.WriteLine("------------------Structural Code--------------------");
            // Constructor is protected -- cannot use 'new'
            Singleton s1 = Singleton.Instance();
            Singleton s2 = Singleton.Instance();

            // Test for same instance
            if(s1 == s2)
            {
                Console.WriteLine("Objects are the same instance.");
            }
            #endregion

            Console.WriteLine("\n-------------------Real-world Code------------------");

            #region Real-world Code of LoadBalancer
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
            
            #endregion

            Console.WriteLine("\n-----------------Optimized Code--------------------");

            #region Optimized LoadBalancer code
            var ba1 = OptimizedLoadBalancer.GetOptimizedLoadBalancer();
            var ba2 = OptimizedLoadBalancer.GetOptimizedLoadBalancer();
            var ba3 = OptimizedLoadBalancer.GetOptimizedLoadBalancer();
            var ba4 = OptimizedLoadBalancer.GetOptimizedLoadBalancer();
            // Confirm these are the same instance
            if(b1 == b2 && b2 == b3 && b3 == b4)
            {
                Console.WriteLine("Same instance\n");
            }
            // Next, load balance 15 requests for a server
            var optBalancer = OptimizedLoadBalancer.GetOptimizedLoadBalancer();
            for(int i = 0 ; i < 15 ; i++)
            {
                string serverName = optBalancer.NextServer.Name;
                Console.WriteLine("Dispatch request to: " + serverName);
            }
            #endregion

        }
    }
}
