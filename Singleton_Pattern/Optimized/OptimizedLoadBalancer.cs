using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Demo
{
    public sealed class OptimizedLoadBalancer
    {
        // Static members are 'eagerly initialized', that is, 
        // immediately when class is loaded for the first time.
        // .NET guarantees thread safety for static initialization
        private static readonly OptimizedLoadBalancer instance = new OptimizedLoadBalancer();

        private readonly List<Server> servers;
        private readonly Random random = new Random();

        // Note: constructor is 'private'
        private OptimizedLoadBalancer()
        {
            // Load list of available servers
            servers = new List<Server>
                {
                  new Server{ Name = "ServerI", IP = "120.14.220.18" },
                  new Server{ Name = "ServerII", IP = "120.14.220.19" },
                  new Server{ Name = "ServerIII", IP = "120.14.220.20" },
                  new Server{ Name = "ServerIV", IP = "120.14.220.21" },
                  new Server{ Name = "ServerV", IP = "120.14.220.22" },
                };
        }

        public static OptimizedLoadBalancer GetOptimizedLoadBalancer()
        {
            return instance;
        }
        // Simple, but effective load balancer
        public Server NextServer
        {
            get {
                int r = random.Next(servers.Count);
                return servers[r];
            }
        }
    }

    /// <summary>
    /// Represents a server machine
    /// </summary>
    public class Server
    {
        public string Name { get; set; }
        public string IP { get; set; }
    }
}
