using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Demo
{
    public class LoadBalancer
    {
        static LoadBalancer instance;
        List<string> servers = new List<string>();
        Random random = new Random();

        // Lock synchronization object

        private static object locker = new object();

        // Constructor (protected) 
        protected LoadBalancer()
        {
            // List of available servers
            servers.Add("Server I");
            servers.Add("Server II");
            servers.Add("Server III");
            servers.Add("Server IV");
            servers.Add("Server V");
        }

        public static LoadBalancer GetLoadBalancer()
        {
            // Support multithreaded application through
            // 'Double checked locking' pattern which (once the instance exists) avoid locking each time the method is invoked
            if(instance == null)
            {
                lock(locker)
                {
                    if(instance == null)
                    {
                        instance = new LoadBalancer();
                    }
                }
            }
            return instance;
        }

        // Simple, but effective random load balancer
        public string Server
        {
            get
            {
                int r = random.Next(servers.Count);
                return servers[r].ToString();
            }
        }
    }
}
