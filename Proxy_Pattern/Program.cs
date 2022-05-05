using Proxy_Pattern.Structural;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy_Pattern
{
    /// <summary>
    /// Proxy Design Pattern
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Structural Code
            Console.WriteLine("***Structural Code****\n");
            // Create proxy and request a service
            Proxy proxy = new Proxy();
            proxy.Request();
            #endregion
            Console.WriteLine("==========================");
            #region Real-world Code
            Console.WriteLine("***Real-world Code****\n");

            #endregion
        }
    }
}
